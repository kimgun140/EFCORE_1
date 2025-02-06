using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class Taglist
    {
        public string TgltTitle { get; set; } = null!;
        public string TgltFiletype { get; set; } = null!;
        public DateTime TgltRegdate { get; set; }
        public DateTime? TgltSearchdate { get; set; }
        public string TgltFileid { get; set; } = null!;
        public string? TgltUsernum { get; set; }

        public virtual Userinfo? TgltUsernumNavigation { get; set; }
    }
}
