namespace YamahaProgramAnalyzer.Models
{
    public class MountModel
    {
        public int No { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Rotation { get; set; }
        public int Fid { get; set; }
        public int Bad { get; set; }
        public string Comp { get; set; }
        public int Group { get; set; }
        public string Opt { get; set; }
        public string Opt2 { get; set; }
        public int Head { get; set; }
        public int Nozzle { get; set; }
        public string Exec { get; set; }
        public string RefDes { get; set; }
        public int OrgBlk { get; set; }
        public double MaskDX { get; set; }
        public double MaskDY { get; set; }
        public int SeqOrder { get; set; }
        public int GroupID { get; set; }
        public int GrpOrder { get; set; }
        public int CodeScan { get; set; }
        public int MntStage { get; set; }
    }
}