using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class Schebasedetail
    {
        public decimal SbdtScbsseq { get; set; }
        public string SbdtScbsareaid { get; set; } = null!;
        public string SbdtScbsmedaid { get; set; } = null!;
        public string SbdtScbsweek { get; set; } = null!;
        public decimal SbdtNum { get; set; }
        public string SbdtBrdtime { get; set; } = null!;
        public string SbdtRuntime { get; set; } = null!;
        public decimal? SbdtCtrlid2 { get; set; }
        public string SbdtDiff { get; set; } = null!;
        public string SbdtPgtype { get; set; } = null!;
        public decimal SbdtPrgmid { get; set; }
        public decimal? SbdtPrgmprtid { get; set; }
        public string SbdtTitle { get; set; } = null!;
        public string SbdtBrdtype { get; set; } = null!;
        public decimal SbdtFadein { get; set; }
        public decimal SbdtFadeout { get; set; }
        public string SbdtTrtype { get; set; } = null!;
        public decimal SbdtLevel { get; set; }
        public string? SbdtFilename { get; set; }
        public string? SbdtFilepath { get; set; }
        public decimal? SbdtCmcount { get; set; }
        public string? SbdtMemo { get; set; }
        public string SbdtTimed { get; set; } = null!;
        public decimal SbdtCtrlid1 { get; set; }
        public decimal? SbdtToneunder { get; set; }
        public decimal? SbdtToneover { get; set; }
        public string? SbdtRecord { get; set; }

        public virtual Controlinfo SbdtCtrlid1Navigation { get; set; } = null!;
        public virtual Schedulebase SbdtScbs { get; set; } = null!;
    }
}
