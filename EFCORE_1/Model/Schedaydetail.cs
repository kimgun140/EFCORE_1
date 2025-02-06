using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class Schedaydetail
    {
        public string SddtScdyareaid { get; set; } = null!;
        public string SddtScdymedaid { get; set; } = null!;
        public string SddtScdydate { get; set; } = null!;
        public decimal SddtNum { get; set; }
        public string SddtBrdtime { get; set; } = null!;
        public string SddtRuntime { get; set; } = null!;
        public string SddtTimed { get; set; } = null!;
        public decimal? SddtCtrlid2 { get; set; }
        public string SddtDiff { get; set; } = null!;
        public string SddtPgtype { get; set; } = null!;
        public decimal SddtPrgmid { get; set; }
        public decimal? SddtPrgmprtid { get; set; }
        public string SddtTitle { get; set; } = null!;
        public string SddtBrdtype { get; set; } = null!;
        public decimal SddtFadein { get; set; }
        public decimal SddtFadeout { get; set; }
        public string SddtTrtype { get; set; } = null!;
        public decimal SddtLevel { get; set; }
        public string? SddtFilename { get; set; }
        public string? SddtFilepath { get; set; }
        public decimal? SddtCmcount { get; set; }
        public string? SddtMemo { get; set; }
        public decimal SddtCtrlid1 { get; set; }
        public string SddtBrddate { get; set; } = null!;
        public decimal? SddtToneunder { get; set; }
        public decimal? SddtToneover { get; set; }
        public string? SddtRecord { get; set; }

        public virtual Controlinfo SddtCtrlid1Navigation { get; set; } = null!;
        public virtual Scheduleday SddtScdy { get; set; } = null!;
    }
}
