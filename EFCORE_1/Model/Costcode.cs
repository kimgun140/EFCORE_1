using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class Costcode
    {
        public string CocdCopldate { get; set; } = null!;
        public string CocdType { get; set; } = null!;
        public string CocdCostkey { get; set; } = null!;
        public string CocdCoplmedaid { get; set; } = null!;
        public decimal CocdSec { get; set; }
        public decimal CocdCost { get; set; }

        public virtual Costpgmlist CocdCopldateNavigation { get; set; } = null!;
    }
}
