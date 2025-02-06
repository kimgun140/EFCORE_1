using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class Cmassign
    {
        public string CmasnPrgmareaid { get; set; } = null!;
        public string CmasnPrgmmedaid { get; set; } = null!;
        public decimal CmasnPrgmid { get; set; }
        public string CmasnCmid { get; set; } = null!;
        public decimal CmasnCmgrid { get; set; }
        public decimal CmasnNum { get; set; }
        public string CmasnSdate { get; set; } = null!;
        public string CmasnEdate { get; set; } = null!;
        public string CmasnTitle { get; set; } = null!;
        public string CmasnViewtitle { get; set; } = null!;
        public string CmasnUsernum { get; set; } = null!;
        public decimal? CmasnPrgmprtid { get; set; }
        public decimal CmasnIndex { get; set; }
        public DateTime CmasnRegdate { get; set; }
        public string CmasnPgmtype { get; set; } = null!;
        public decimal CmasnCostsec { get; set; }
        public string? CmasnMemo { get; set; }
        public decimal? CmasnClientid { get; set; }
        public decimal? CmasnAgencyid { get; set; }
        public decimal? CmasnConsid { get; set; }
        public decimal? CmasnSubnum { get; set; }

        public virtual Cm CmasnCm { get; set; } = null!;
        public virtual Cmgroup CmasnCmgr { get; set; } = null!;
        public virtual Program CmasnPrgm { get; set; } = null!;
        public virtual Userinfo CmasnUsernumNavigation { get; set; } = null!;
    }
}
