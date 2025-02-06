using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class Songartistcode
    {
        public string SatcCode { get; set; } = null!;
        public string SatcEngname { get; set; } = null!;
        public string? SatcKorname { get; set; }
        public string? SatcDiv { get; set; }
        public string? SatcUsernum { get; set; }
        public DateTime SatcRegdate { get; set; }

        public virtual Userinfo? SatcUsernumNavigation { get; set; }
    }
}
