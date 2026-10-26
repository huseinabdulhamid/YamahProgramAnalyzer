using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Xml;
using YamahaProgramAnalyzer.Models;

namespace YamahaProgramAnalyzer.Services
{
    /// <summary>
    /// Parser file YGX/XML Yamaha — GENERIC.
    /// Mount : atribut dibaca langsung dari elemen &lt;Mount&gt;.
    /// Part  : SELURUH elemen anak &lt;Part_XXX&gt; (apa pun nomornya) disisir,
    ///         setiap atributnya dicocokkan ke properti PartModel lewat NAMA
    ///         (bukan nomor blok yang di-hardcode) — sehingga part dengan
    ///         ShapeType/Algorithm apa pun (chip, IC, BGA, tray, connector,
    ///         library-linked, dll.) tetap terbaca lengkap.
    ///         Imbuhan arah N/S/E/W (mis. RlrOffsetN) di-strip agar bertemu
    ///         properti dasarnya (RlrOffset). Nilai pertama yang tidak kosong
    ///         untuk suatu field yang menang (tidak ditimpa nilai kosong berikutnya).
    /// </summary>
    public class YgxParser
    {
        private static readonly string[] DirectionalBases =
        {
            "RlrOffset", "LeadNum", "LeadPitch", "LeadWidth", "LeadLength"
        };

        private static readonly Dictionary<string, PropertyInfo> PartPropsByName =
            BuildPartPropertyMap();

        public YgxDatabase Load(string filePath)
        {
            var database = new YgxDatabase();

            var doc = new XmlDocument();
            doc.Load(filePath);

            LoadMounts(doc, database);
            LoadParts(doc, database);

            return database;
        }

        // =========================================================
        // MOUNT
        // =========================================================
        private void LoadMounts(XmlDocument doc, YgxDatabase database)
        {
            XmlNodeList mountNodes = doc.SelectNodes("//Mounts/Mount");
            if (mountNodes == null) return;

            foreach (XmlNode node in mountNodes)
            {
                try
                {
                    var mount = new MountModel
                    {
                        No = ToInt(node.Attributes["No"]?.Value),
                        X = ToDouble(node.Attributes["X"]?.Value),
                        Y = ToDouble(node.Attributes["Y"]?.Value),
                        Rotation = ToDouble(node.Attributes["R"]?.Value),
                        Fid = ToInt(node.Attributes["Fid"]?.Value),
                        Bad = ToInt(node.Attributes["Bad"]?.Value),
                        Comp = SafeString(node.Attributes["Comp"]?.Value),
                        Group = ToInt(node.Attributes["Group"]?.Value),
                        Opt = SafeString(node.Attributes["Opt"]?.Value),
                        Opt2 = SafeString(node.Attributes["Opt2"]?.Value),
                        Head = ToInt(node.Attributes["Head"]?.Value),
                        Nozzle = ToInt(node.Attributes["Nozzle"]?.Value),
                        Exec = SafeString(node.Attributes["Exec"]?.Value),
                        RefDes = SafeString(node.Attributes["Comment"]?.Value),
                        OrgBlk = ToInt(node.Attributes["OrgBlk"]?.Value),
                        MaskDX = ToDouble(node.Attributes["MaskDX"]?.Value),
                        MaskDY = ToDouble(node.Attributes["MaskDY"]?.Value),
                        SeqOrder = ToInt(node.Attributes["SeqOrder"]?.Value),
                        GroupID = ToInt(node.Attributes["GroupID"]?.Value),
                        GrpOrder = ToInt(node.Attributes["GrpOrder"]?.Value),
                        CodeScan = ToInt(node.Attributes["CodeScan"]?.Value),
                        MntStage = ToInt(node.Attributes["MntStage"]?.Value)
                    };

                    database.Mounts.Add(mount);
                }
                catch (Exception ex)
                {
                    database.Warnings.Add($"Mount dilewati karena error: {ex.Message}");
                }
            }
        }


        // =========================================================
        // PART — GENERIC (kunci perbaikan)
        // =========================================================
        private void LoadParts(XmlDocument doc, YgxDatabase database)
        {
            XmlNodeList partNodes = doc.SelectNodes("//Parts/Part");
            if (partNodes == null) return;

            foreach (XmlNode partNode in partNodes)
            {
                try
                {
                    var part = new PartModel
                    {
                        No = ToInt(partNode.Attributes["No"]?.Value)
                    };

                    // Sisir SEMUA elemen anak (Part_001, Part_012, Part_025,
                    // Part_057, Part_100, dst — apa pun nomornya) dan cocokkan
                    // setiap atributnya ke properti PartModel lewat nama.
                    foreach (XmlNode child in partNode.ChildNodes)
                    {
                        if (child.NodeType != XmlNodeType.Element || child.Attributes == null)
                            continue;

                        foreach (XmlAttribute attr in child.Attributes)
                        {
                            string key = StripDirection(attr.Name);

                            if (!PartPropsByName.TryGetValue(key, out PropertyInfo prop))
                                continue;

                            string current = (prop.GetValue(part) as string) ?? string.Empty;
                            if (current.Length > 0)
                                continue; // nilai pertama yang tidak kosong menang

                            string value = SafeString(attr.Value);
                            if (value.Length > 0)
                            {
                                prop.SetValue(part, value);
                            }
                        }
                    }

                    // Fallback: jangan biarkan part "hilang" dari dropdown
                    // hanya karena PartsName kosong (mis. part library-linked
                    // yang namanya tidak disimpan inline di file ini).
                    if (string.IsNullOrWhiteSpace(part.PartsName))
                    {
                        part.PartsName = $"(Part No. {part.No})";
                        database.Warnings.Add(
                            $"Part No. {part.No}: PartsName kosong di file YGX, " +
                            $"diberi nama sementara \"{part.PartsName}\".");
                    }

                    database.Parts.Add(part);
                }
                catch (Exception ex)
                {
                    database.Warnings.Add(
                        $"Part No. {SafeString(partNode.Attributes?["No"]?.Value)} " +
                        $"dilewati karena error: {ex.Message}");
                }
            }
        }

        private static string StripDirection(string attrName)
        {
            if (attrName.Length > 1)
            {
                char suffix = attrName[attrName.Length - 1];
                if (suffix == 'N' || suffix == 'S' || suffix == 'E' || suffix == 'W')
                {
                    string baseCandidate = attrName.Substring(0, attrName.Length - 1);
                    foreach (var baseName in DirectionalBases)
                    {
                        if (string.Equals(baseName, baseCandidate, StringComparison.OrdinalIgnoreCase))
                            return baseName;
                    }
                }
            }
            return attrName;
        }

        private static Dictionary<string, PropertyInfo> BuildPartPropertyMap()
        {
            var map = new Dictionary<string, PropertyInfo>(StringComparer.OrdinalIgnoreCase);

            foreach (var prop in typeof(PartModel).GetProperties())
            {
                if (prop.PropertyType != typeof(string))
                    continue; // No (int) ditangani terpisah

                if (!map.ContainsKey(prop.Name))
                {
                    map.Add(prop.Name, prop);
                }
            }

            return map;
        }

        private static string SafeString(string value)
        {
            return value == null ? string.Empty : value.Trim();
        }

        private static int ToInt(string value)
        {
            int.TryParse(SafeString(value), NumberStyles.Any, CultureInfo.InvariantCulture, out int result);
            return result;
        }

        private static double ToDouble(string value)
        {
            double.TryParse(SafeString(value), NumberStyles.Any, CultureInfo.InvariantCulture, out double result);
            return result;
        }
    }
}