using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class Cuesheet
    {
        public decimal CustSeq { get; set; }
        public string CustPrgmareaid { get; set; } = null!;
        public string CustPrgmmedaid { get; set; } = null!;
        public decimal? CustPrgmparentid { get; set; }
        public string? CustBrddate { get; set; }
        public string? CustWeek { get; set; }
        public DateTime CustRegdate { get; set; }
        public string CustUsernum { get; set; } = null!;
        public decimal CustPrgmid { get; set; }

        public virtual Program CustPrgm { get; set; } = null!;
        public virtual Userinfo CustUsernumNavigation { get; set; } = null!;
    }
}
