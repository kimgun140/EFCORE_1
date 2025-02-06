using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class Bookmark
    {
        public string BkmkFileid { get; set; } = null!;
        public string? BkmkFiletype { get; set; }
        public string BkmkUsernum { get; set; } = null!;

        public virtual Userinfo BkmkUsernumNavigation { get; set; } = null!;
    }
}
