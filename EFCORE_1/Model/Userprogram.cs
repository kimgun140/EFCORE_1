using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class Userprogram
    {
        public string UpgmUsernum { get; set; } = null!;
        public string UpgmPrgmareaid { get; set; } = null!;
        public string? UpgmPrgmmedaid { get; set; }
        public decimal? UpgmPrgmid { get; set; }
        public string? UpgmItclhid { get; set; }
        public decimal? UpgmItcllid { get; set; }

        public virtual Itemcodelow? UpgmItcll { get; set; }
        public virtual Program? UpgmPrgm { get; set; }
        public virtual Userinfo UpgmUsernumNavigation { get; set; } = null!;
    }
}
