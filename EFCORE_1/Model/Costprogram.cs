using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class Costprogram
    {
        public string CopgCopldate { get; set; } = null!;
        public string CopgCoplmedaid { get; set; } = null!;
        public string CopgPrgmareaid { get; set; } = null!;
        public string CopgType { get; set; } = null!;
        public decimal CopgPrgmid { get; set; }
        public decimal CopgSec { get; set; }
        public string CopgCostkey { get; set; } = null!;
        public decimal CopgCost { get; set; }

        public virtual Program Copg { get; set; } = null!;
    }
}
