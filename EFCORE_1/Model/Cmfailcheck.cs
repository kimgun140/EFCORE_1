using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class Cmfailcheck
    {
        public string CmfcCmid { get; set; } = null!;
        public string CmfcFaildate { get; set; } = null!;
        public DateTime CmfcRegdate { get; set; }
        public string? CmfcMemo { get; set; }
        public string CmfcUsernum { get; set; } = null!;
        public decimal? CmfcIndex { get; set; }
        public decimal? CmfcPrgmid { get; set; }

        public virtual Cm CmfcCm { get; set; } = null!;
        public virtual Cmassign? CmfcIndexNavigation { get; set; }
        public virtual Userinfo CmfcUsernumNavigation { get; set; } = null!;
    }
}
