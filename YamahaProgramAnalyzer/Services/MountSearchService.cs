using System.Collections.Generic;
using YamahaProgramAnalyzer.Models;

namespace YamahaProgramAnalyzer.Services
{
    public static class MountSearchService
    {
        public static List<MountParameterResult>
            BuildResult(MountModel mount)
        {
            return new List<MountParameterResult>
            {
                new MountParameterResult { No=1, Parameter="No", Description="Mount No", Value=mount.No.ToString() },
                new MountParameterResult { No=2, Parameter="X", Description="Position X", Value=mount.X.ToString() },
                new MountParameterResult { No=3, Parameter="Y", Description="Position Y", Value=mount.Y.ToString() },
                new MountParameterResult { No=4, Parameter="R", Description="Rotation", Value=mount.Rotation.ToString() },
                new MountParameterResult { No=5, Parameter="Fid", Description="Fiducial", Value=mount.Fid.ToString() },
                new MountParameterResult { No=6, Parameter="Bad", Description="Bad Status", Value=mount.Bad.ToString() },
                new MountParameterResult { No=7, Parameter="Comp", Description="Component No", Value=mount.Comp.ToString() },
                new MountParameterResult { No=8, Parameter="Group", Description="Group", Value=mount.Group.ToString() },
                new MountParameterResult { No=9, Parameter="Opt", Description="Option", Value=mount.Opt },
                new MountParameterResult { No=10, Parameter="Head", Description="Machine Head", Value=mount.Head.ToString() },
                new MountParameterResult { No=11, Parameter="Nozzle", Description="Nozzle", Value=mount.Nozzle.ToString() },
                new MountParameterResult { No=12, Parameter="Exec", Description="Execution", Value=mount.Exec },
                new MountParameterResult { No=13, Parameter="RefDes", Description="Reference Designator", Value=mount.RefDes },
                new MountParameterResult { No=14, Parameter="OrgBlk", Description="Original Block", Value=mount.OrgBlk.ToString() },
                new MountParameterResult { No=15, Parameter="MaskDX", Description="Mask Offset X", Value=mount.MaskDX.ToString() },
                new MountParameterResult { No=16, Parameter="MaskDY", Description="Mask Offset Y", Value=mount.MaskDY.ToString() },
                new MountParameterResult { No=17, Parameter="GroupID", Description="Group ID", Value=mount.GroupID.ToString() },
                new MountParameterResult { No=18, Parameter="GrpOrder", Description="Group Order", Value=mount.GrpOrder.ToString() }
            };
        }
    }
}