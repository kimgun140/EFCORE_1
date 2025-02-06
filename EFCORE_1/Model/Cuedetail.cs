using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class Cuedetail
    {
        public decimal? CsdtPgmparentid { get; set; }
        public string? CsdtBrddate { get; set; }
        public string? CsdtWeek { get; set; }
        public decimal CsdtCustseq { get; set; }
        public string CsdtType { get; set; } = null!;
        public string? CsdtBrdtime { get; set; }
        public decimal CsdtNo { get; set; }
        public string? CsdtRuntime { get; set; }
        public string? CsdtTitle { get; set; }
        public string? CsdtFilename { get; set; }
        public string CsdtCustareaid { get; set; } = null!;
        public decimal? CsdtCmgrid { get; set; }
        public decimal? CsdtFadein { get; set; }
        public decimal? CsdtFadeout { get; set; }
        public string CsdtEndtype { get; set; } = null!;
        public string CsdtItemtype { get; set; } = null!;
        public string? CsdtTrtype { get; set; }
        public string? CsdtItemid { get; set; }
        public string? CsdtFilepath { get; set; }
        public string? CsdtTimed { get; set; }
        public string? CsdtCustmedaid { get; set; }
        public decimal CsdtCustprgmid { get; set; }
        public string CsdtSpos { get; set; } = null!;
        public string CsdtEpos { get; set; } = null!;
        public string CsdtEdit { get; set; } = null!;
        public string? CsdtSubtitle { get; set; }

        public virtual Cmgroup? CsdtCmgr { get; set; }
    }
}
