using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class Costcodelist
    {
        public string CoclDate { get; set; } = null!;
        public string CoclMedaid { get; set; } = null!;
        public string CoclTitle { get; set; } = null!;
        public string CoclUsernum { get; set; } = null!;
        public DateTime CoclRegdate { get; set; }

        public virtual Mediainfo CoclMeda { get; set; } = null!;
        public virtual Userinfo CoclUsernumNavigation { get; set; } = null!;
    }
}
