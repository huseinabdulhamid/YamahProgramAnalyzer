using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using YamahaProgramAnalyzer.Models;
using YamahaProgramAnalyzer.Services;

namespace YamahaProgramAnalyzer
{
    public partial class FrmMain : Form
    {
        private YgxDatabase _database;
        private string _currentFile = string.Empty;

        private readonly Color ColorHeader = Color.FromArgb(15, 43, 70);
        private readonly Color ColorText = Color.FromArgb(35, 45, 55);
        private readonly Color ColorSubText = Color.FromArgb(100, 110, 120);
        private readonly Color ColorSuccess = Color.FromArgb(40, 150, 95);
        private readonly Color ColorError = Color.FromArgb(190, 60, 60);
        private readonly Color ColorLink = Color.FromArgb(0, 90, 158);

        public FrmMain()
        {
            InitializeComponent();
            InitializeApplication();
        }

        private void InitializeApplication()
        {
            lblStatus.Text = "READY";
            lblStatus.ForeColor = ColorSuccess;
            lblFile.Text = "No YGX file loaded";
            lblDatabaseInfo.Text = "Database: 0 Mount | 0 Part";
            lblMountCount.Text = "0";
            lblPartCount.Text = "0";

            ConfigureMountParameterGrid();
            ConfigurePartParameterGrid();

            ResetMount();
            ResetPart();
        }

        // =========================================================
        // OPEN / LOAD
        // =========================================================
        private void btnOpenYGX_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.Filter = "YGX Files (*.ygx)|*.ygx|XML Files (*.xml)|*.xml|All Files (*.*)|*.*";
                dlg.Title = "Open Yamaha YGX Program";

                if (dlg.ShowDialog() != DialogResult.OK)
                    return;

                LoadYgxFile(dlg.FileName);
            }
        }

        private void LoadYgxFile(string fileName)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                SetStatus("LOADING...", Color.Orange);

                var parser = new YgxParser();
                _database = parser.Load(fileName);
                _currentFile = fileName;

                cmbRefDes.DataSource = null;
                cmbRefDes.DataSource = _database.Mounts
                    .Where(x => !string.IsNullOrWhiteSpace(x.RefDes))
                    .Select(x => x.RefDes)
                    .Distinct()
                    .OrderBy(x => x)
                    .ToList();

                cmbPartName.DataSource = null;
                cmbPartName.DataSource = _database.Parts
                    .Where(x => !string.IsNullOrWhiteSpace(x.PartsName))
                    .Select(x => x.PartsName)
                    .Distinct()
                    .OrderBy(x => x)
                    .ToList();

                lblFile.Text = Path.GetFileName(fileName);
                lblDatabaseInfo.Text = $"Database: {_database.Mounts.Count} Mount | {_database.Parts.Count} Part";
                lblMountCount.Text = _database.Mounts.Count.ToString();
                lblPartCount.Text = _database.Parts.Count.ToString();

                SetStatus("READY", ColorSuccess);

                ResetMount();
                ResetPart();

                if (cmbRefDes.Items.Count > 0) cmbRefDes.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                SetStatus("ERROR", Color.Red);
                MessageBox.Show(ex.Message, "Import Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                string warningNote = _database.Warnings.Count > 0
                    ? $"\n\n⚠ {_database.Warnings.Count} catatan saat import:\n" +
                      string.Join("\n", _database.Warnings.ConvertAll(w => "• " + w))
                    : string.Empty;

                MessageBox.Show(
                    $"Import berhasil.\n\nTotal Mount : {_database.Mounts.Count}\nTotal Part  : {_database.Parts.Count}{warningNote}",
                    "Yamaha Program Analyzer",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        // =========================================================
        // MOUNT PARAMETER (BOX KIRI)
        // =========================================================
        private void cmbRefDes_SelectedIndexChanged(object sender, EventArgs e) => SearchMount();
        private void btnSearchMount_Click(object sender, EventArgs e) => SearchMount();

        private void btnResetMount_Click(object sender, EventArgs e)
        {
            // Reset digabung: Mount & Part adalah satu alur kerja (smart-link)
            ResetMount();
            ResetPart();
        }

        private void cmbMountInstance_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMountInstance.Tag is List<MountModel> matches &&
                cmbMountInstance.SelectedIndex >= 0 &&
                cmbMountInstance.SelectedIndex < matches.Count)
            {
                var mount = matches[cmbMountInstance.SelectedIndex];
                dgvMountParameter.DataSource = BuildMountParameters(mount);
                AutoLinkPart(mount);
            }
        }

        private void SearchMount()
        {
            if (_database == null)
            {
                MessageBox.Show("Silakan buka file YGX terlebih dahulu.", "Belum Ada Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string refdes = cmbRefDes.Text.Trim();
            if (string.IsNullOrWhiteSpace(refdes))
                return;

            var matches = _database.Mounts
                .Where(x => !string.IsNullOrEmpty(x.RefDes) &&
                            x.RefDes.Equals(refdes, StringComparison.OrdinalIgnoreCase))
                .ToList();

            cmbMountInstance.SelectedIndexChanged -= cmbMountInstance_SelectedIndexChanged;
            cmbMountInstance.Items.Clear();
            cmbMountInstance.Visible = false;
            cmbMountInstance.SelectedIndexChanged += cmbMountInstance_SelectedIndexChanged;

            if (matches.Count == 0)
            {
                lblMountResultInfo.Text = $"Tidak ditemukan data untuk \"{refdes}\".";
                lblMountResultInfo.ForeColor = ColorError;
                dgvMountParameter.DataSource = null;
                ResetPart();
                return;
            }

            lblMountResultInfo.Text = $"{matches.Count} hasil ditemukan untuk \"{refdes}\".";
            lblMountResultInfo.ForeColor = ColorSuccess;

            if (matches.Count > 1)
            {
                cmbMountInstance.Tag = matches;
                foreach (var m in matches)
                    cmbMountInstance.Items.Add($"Mount No. {m.No}  (Comp {m.Comp})");

                cmbMountInstance.Visible = true;
                cmbMountInstance.SelectedIndex = 0; // otomatis memicu AutoLinkPart lewat event di atas
            }
            else
            {
                dgvMountParameter.DataSource = BuildMountParameters(matches[0]);
                AutoLinkPart(matches[0]);
            }
        }

        private void ResetMount()
        {
            cmbRefDes.SelectedIndex = -1;
            cmbMountInstance.Items.Clear();
            cmbMountInstance.Visible = false;
            dgvMountParameter.DataSource = null;
            lblMountResultInfo.Text = "Pilih Reference Designator, lalu klik Mount Parameter.";
            lblMountResultInfo.ForeColor = ColorSubText;
        }

        private List<MountParameterResult> BuildMountParameters(MountModel m)
        {
            var result = new List<MountParameterResult>();
            int no = 0;

            void Add(string parameter, string description, object value)
            {
                no++;
                result.Add(new MountParameterResult
                {
                    No = no,
                    Parameter = parameter,
                    Description = description,
                    Value = value == null ? string.Empty : value.ToString()
                });
            }

            Add("No", "No", m.No);
            Add("X", "Posisi X", m.X);
            Add("Y", "Posisi Y", m.Y);
            Add("R", "Rotasi", m.Rotation);
            Add("Fid", "Fiducial", m.Fid);
            Add("Bad", "Status Bad", m.Bad);
            Add("Comp", "Kode Komponen (No. Part)", m.Comp);
            Add("Group", "Grup", m.Group);
            Add("Opt", "No. Nozzle / Opsi", m.Opt);
            Add("Opt2", "Opsi 2", m.Opt2);
            Add("Head", "Head Mesin", m.Head);
            Add("Nozzle", "Jenis Nozzle", m.Nozzle);
            Add("Exec", "Status Eksekusi", m.Exec);
            Add("Comment", "Reference Designator", m.RefDes);
            Add("OrgBlk", "Original Block", m.OrgBlk);
            Add("MaskDX", "Offset Mask X", m.MaskDX);
            Add("MaskDY", "Offset Mask Y", m.MaskDY);
            Add("SeqOrder", "Sequence Order", m.SeqOrder);
            Add("GroupID", "ID Grup", m.GroupID);
            Add("GrpOrder", "Urutan Grup", m.GrpOrder);
            Add("CodeScan", "Code Scan", m.CodeScan);
            Add("MntStage", "Mount Stage", m.MntStage);

            return result;
        }

        // =========================================================
        // SMART LINK: Mount.Comp -> Part.No
        // =========================================================
        private void AutoLinkPart(MountModel mount)
        {
            if (_database == null || mount == null)
                return;

            string compNo = (mount.Comp ?? string.Empty).Trim();

            if (string.IsNullOrEmpty(compNo))
            {
                lblPartResultInfo.Text = "Mount ini tidak memiliki referensi Part (Comp kosong).";
                lblPartResultInfo.ForeColor = ColorSubText;
                dgvPartParameter.DataSource = null;
                return;
            }

            var linkedPart = _database.Parts.FirstOrDefault(p => p.No.ToString() == compNo);

            if (linkedPart == null)
            {
                lblPartResultInfo.Text = $"Part dengan No. {compNo} tidak ditemukan di database.";
                lblPartResultInfo.ForeColor = ColorError;
                dgvPartParameter.DataSource = null;
                return;
            }

            // Sinkronkan dropdown Part Name tanpa memicu SearchPart() manual
            cmbPartName.SelectedIndexChanged -= cmbPartName_SelectedIndexChanged;
            cmbPartName.SelectedItem = linkedPart.PartsName;
            cmbPartName.SelectedIndexChanged += cmbPartName_SelectedIndexChanged;

            cmbPartInstance.SelectedIndexChanged -= cmbPartInstance_SelectedIndexChanged;
            cmbPartInstance.Items.Clear();
            cmbPartInstance.Visible = false;
            cmbPartInstance.SelectedIndexChanged += cmbPartInstance_SelectedIndexChanged;

            dgvPartParameter.DataSource = BuildPartParameters(linkedPart);

            lblPartResultInfo.Text =
                $"🔗 Auto-linked dari Mount Comp #{compNo}  →  {linkedPart.PartsName}  (Part No. {linkedPart.No})";
            lblPartResultInfo.ForeColor = ColorLink;
        }

        // =========================================================
        // PART PARAMETER (BOX KANAN) — tetap bisa dipakai manual
        // =========================================================
        private void cmbPartName_SelectedIndexChanged(object sender, EventArgs e) => SearchPart();
        private void btnSearchPart_Click(object sender, EventArgs e) => SearchPart();
        private void btnResetPart_Click(object sender, EventArgs e) => ResetPart();

        private void cmbPartInstance_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPartInstance.Tag is List<PartModel> matches &&
                cmbPartInstance.SelectedIndex >= 0 &&
                cmbPartInstance.SelectedIndex < matches.Count)
            {
                dgvPartParameter.DataSource = BuildPartParameters(matches[cmbPartInstance.SelectedIndex]);
            }
        }

        private void SearchPart()
        {
            if (_database == null)
            {
                MessageBox.Show("Silakan buka file YGX terlebih dahulu.", "Belum Ada Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string partName = cmbPartName.Text.Trim();
            if (string.IsNullOrWhiteSpace(partName))
                return;

            var matches = _database.Parts
                .Where(x => !string.IsNullOrEmpty(x.PartsName) &&
                            x.PartsName.Equals(partName, StringComparison.OrdinalIgnoreCase))
                .ToList();

            cmbPartInstance.SelectedIndexChanged -= cmbPartInstance_SelectedIndexChanged;
            cmbPartInstance.Items.Clear();
            cmbPartInstance.Visible = false;
            cmbPartInstance.SelectedIndexChanged += cmbPartInstance_SelectedIndexChanged;

            if (matches.Count == 0)
            {
                lblPartResultInfo.Text = $"Tidak ditemukan data untuk \"{partName}\".";
                lblPartResultInfo.ForeColor = ColorError;
                dgvPartParameter.DataSource = null;
                return;
            }

            lblPartResultInfo.Text = $"🔍 {matches.Count} hasil ditemukan untuk \"{partName}\" (pencarian manual).";
            lblPartResultInfo.ForeColor = ColorSuccess;

            if (matches.Count > 1)
            {
                cmbPartInstance.Tag = matches;
                foreach (var p in matches)
                    cmbPartInstance.Items.Add($"Part No. {p.No}  ({p.DatabaseNo})");

                cmbPartInstance.Visible = true;
                cmbPartInstance.SelectedIndex = 0;
            }
            else
            {
                dgvPartParameter.DataSource = BuildPartParameters(matches[0]);
            }
        }

        private void ResetPart()
        {
            cmbPartName.SelectedIndexChanged -= cmbPartName_SelectedIndexChanged;
            cmbPartName.SelectedIndex = -1;
            cmbPartName.SelectedIndexChanged += cmbPartName_SelectedIndexChanged;

            cmbPartInstance.Items.Clear();
            cmbPartInstance.Visible = false;
            dgvPartParameter.DataSource = null;
            lblPartResultInfo.Text = "Pilih Part Name, lalu klik PartsParameter (atau otomatis lewat pencarian Mount).";
            lblPartResultInfo.ForeColor = ColorSubText;
        }

        private List<PartParameterResult> BuildPartParameters(PartModel p)
        {
            var result = new List<PartParameterResult>();
            int no = 0;

            void Add(string category, string code, string label, string value)
            {
                no++;
                result.Add(new PartParameterResult
                {
                    No = no,
                    Category = category,
                    Parameter = code,
                    Description = label,
                    Value = value ?? string.Empty
                });
            }

            Add("IDENTITAS", "Comment", "Komentar", p.Comment);
            Add("IDENTITAS", "DatabaseNo", "No. Database", p.DatabaseNo);

            Add("BENTUK & FEEDER", "ShapeType", "Tipe Bentuk", p.ShapeType);
            Add("BENTUK & FEEDER", "Package", "Kemasan", p.Package);
            Add("BENTUK & FEEDER", "FdrType", "Tipe Feeder", p.FdrType);
            Add("BENTUK & FEEDER", "ReelDiameter", "Diameter Reel", p.ReelDiameter);

            Add("POSISI & OFFSET", "XPos", "Posisi X", p.XPos);
            Add("POSISI & OFFSET", "YPos", "Posisi Y", p.YPos);
            Add("POSISI & OFFSET", "FdrIdxStep", "Langkah Index Feeder", p.FdrIdxStep);
            Add("POSISI & OFFSET", "FdrIdxSpeed", "Kecepatan Index Feeder", p.FdrIdxSpeed);

            Add("DIMENSI BODY", "BodyX", "Dimensi Body X", p.BodyX);
            Add("DIMENSI BODY", "BodyY", "Dimensi Body Y", p.BodyY);
            Add("DIMENSI BODY", "BodyZ", "Dimensi Body Z", p.BodyZ);
            Add("DIMENSI BODY", "OffsetX", "Offset X", p.OffsetX);
            Add("DIMENSI BODY", "OffsetY", "Offset Y", p.OffsetY);
            Add("DIMENSI BODY", "OffsetR", "Offset Rotasi", p.OffsetR);
            Add("DIMENSI BODY", "MoldX", "Dimensi Mold X", p.MoldX);
            Add("DIMENSI BODY", "MoldY", "Dimensi Mold Y", p.MoldY);
            Add("DIMENSI BODY", "MoldZ", "Dimensi Mold Z", p.MoldZ);
            Add("DIMENSI BODY", "Thicknesschk", "Cek Ketebalan", p.Thicknesschk);

            Add("LEAD/KAKI KOMPONEN", "RlrOffset", "Offset Roller", p.RlrOffset);
            Add("LEAD/KAKI KOMPONEN", "RlrWidth", "Lebar Roller", p.RlrWidth);
            Add("LEAD/KAKI KOMPONEN", "LeadNum", "Jumlah Kaki", p.LeadNum);
            Add("LEAD/KAKI KOMPONEN", "LeadPitch", "Jarak Antar Kaki", p.LeadPitch);
            Add("LEAD/KAKI KOMPONEN", "LeadWidth", "Lebar Kaki", p.LeadWidth);
            Add("LEAD/KAKI KOMPONEN", "LeadLength", "Panjang Kaki", p.LeadLength);

            Add("VISION/ALIGNMENT", "Alignment", "Metode Alignment", p.Alignment);
            Add("VISION/ALIGNMENT", "AutoThreshold", "Auto Threshold", p.AutoThreshold);
            Add("VISION/ALIGNMENT", "Threshold", "Ambang Batas", p.Threshold);
            Add("VISION/ALIGNMENT", "Tolerance", "Toleransi", p.Tolerance);
            Add("VISION/ALIGNMENT", "SearchArea", "Area Pencarian", p.SearchArea);
            Add("VISION/ALIGNMENT", "DatumAngle", "Sudut Datum", p.DatumAngle);

            Add("PENCAHAYAAN", "LightSetting", "Setting Cahaya", p.LightSetting);
            Add("PENCAHAYAAN", "LightLevel", "Level Cahaya", p.LightLevel);
            Add("PENCAHAYAAN", "MainLightLevel", "Level Cahaya Utama", p.MainLightLevel);
            Add("PENCAHAYAAN", "CoaxsLightLevel", "Level Cahaya Coaxial", p.CoaxsLightLevel);
            Add("PENCAHAYAAN", "SideLightLevel", "Level Cahaya Samping", p.SideLightLevel);

            Add("NOZZLE & PICK", "Nozzle", "Nozzle", p.Nozzle);
            Add("NOZZLE & PICK", "XYSpeed", "Kecepatan XY", p.XYSpeed);
            Add("NOZZLE & PICK", "ConvYSpeed", "Kecepatan Konveyor Y", p.ConvYSpeed);
            Add("NOZZLE & PICK", "FdrAngle", "Sudut Feeder", p.FdrAngle);
            Add("NOZZLE & PICK", "Action", "Aksi", p.Action);
            Add("NOZZLE & PICK", "Retry", "Percobaan Ulang", p.Retry);

            Add("PARAMETER PICK", "PckHeight", "Tinggi Pick", p.PckHeight);
            Add("PARAMETER PICK", "PckTimer", "Waktu Tunggu Pick", p.PckTimer);
            Add("PARAMETER PICK", "PckSpeed", "Kecepatan Pick", p.PckSpeed);
            Add("PARAMETER PICK", "PckVLevel", "Level Vakum Pick", p.PckVLevel);

            Add("PARAMETER MOUNT", "MntHeight", "Tinggi Mount", p.MntHeight);
            Add("PARAMETER MOUNT", "MntTimer", "Waktu Tunggu Mount", p.MntTimer);
            Add("PARAMETER MOUNT", "MntSpeed", "Kecepatan Mount", p.MntSpeed);
            Add("PARAMETER MOUNT", "MntPLevel", "Level Tekanan Mount", p.MntPLevel);

            return result;
        }

        // =========================================================
        // GRID STYLING
        // =========================================================
        private void ConfigureMountParameterGrid()
        {
            dgvMountParameter.AutoGenerateColumns = false;
            dgvMountParameter.Columns.Clear();

            dgvMountParameter.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colNo",
                HeaderText = "No",
                DataPropertyName = "No",
                Width = 50,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });
            dgvMountParameter.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colParameter",
                HeaderText = "Parameter",
                DataPropertyName = "Parameter",
                Width = 150
            });
            dgvMountParameter.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colDescription",
                HeaderText = "Description",
                DataPropertyName = "Description",
                Width = 200
            });
            dgvMountParameter.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colValue",
                HeaderText = "Value",
                DataPropertyName = "Value",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            StyleParameterGrid(dgvMountParameter);
        }

        private void ConfigurePartParameterGrid()
        {
            dgvPartParameter.AutoGenerateColumns = false;
            dgvPartParameter.Columns.Clear();

            dgvPartParameter.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colNo",
                HeaderText = "No",
                DataPropertyName = "No",
                Width = 40,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });
            dgvPartParameter.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCategory",
                HeaderText = "Category",
                DataPropertyName = "Category",
                Width = 130
            });
            dgvPartParameter.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colParameter",
                HeaderText = "Parameter",
                DataPropertyName = "Parameter",
                Width = 100
            });
            dgvPartParameter.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colDescription",
                HeaderText = "Description",
                DataPropertyName = "Description",
                Width = 170
            });
            dgvPartParameter.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colValue",
                HeaderText = "Value",
                DataPropertyName = "Value",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            StyleParameterGrid(dgvPartParameter);
        }

        private void StyleParameterGrid(DataGridView grid)
        {
            grid.ReadOnly = true;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.RowHeadersVisible = false;
            grid.EnableHeadersVisualStyles = false;
            grid.BackgroundColor = Color.White;
            grid.BorderStyle = BorderStyle.None;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.MultiSelect = false;

            grid.ColumnHeadersDefaultCellStyle.BackColor = ColorHeader;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            grid.ColumnHeadersHeight = 32;

            grid.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            grid.DefaultCellStyle.ForeColor = ColorText;
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(210, 228, 243);
            grid.DefaultCellStyle.SelectionForeColor = ColorText;
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);

            grid.RowTemplate.Height = 24;
        }

        // =========================================================
        // STATUS
        // =========================================================
        private void SetStatus(string status, Color color)
        {
            lblStatus.Text = status;
            lblStatus.ForeColor = color;
        }
    }
}