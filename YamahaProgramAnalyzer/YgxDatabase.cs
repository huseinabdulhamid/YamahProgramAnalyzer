using System;
using System.Collections.Generic;
using YamahaProgramAnalyzer.Models;

namespace YamahaProgramAnalyzer
{
    public class YgxDatabase
    {
        public string SourceFile { get; set; } = string.Empty;
        public DateTime ImportedAt { get; set; }

        public List<MountModel> Mounts { get; set; } = new List<MountModel>();
        public List<PartModel> Parts { get; set; } = new List<PartModel>();

        public List<string> Warnings { get; set; } = new List<string>();
    }

}