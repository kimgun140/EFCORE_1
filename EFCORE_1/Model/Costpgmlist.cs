using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class Costpgmlist
    {
        public Costpgmlist()
        {
            Costcodes = new HashSet<Costcode>();
        }

        public string CoplDate { get; set; } = null!;
        public string? CoplMedaid { get; set; }
        public string CoplTitle { get; set; } = null!;
        public string CoplUsernum { get; set; } = null!;
        public DateTime CoplRegdate { get; set; }

        public virtual Userinfo CoplUsernumNavigation { get; set; } = null!;
        public virtual ICollection<Costcode> Costcodes { get; set; }
    }
}
