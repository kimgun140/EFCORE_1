using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class Itemfile
    {
        public string ItemId { get; set; } = null!;
        public decimal? ItemItclid { get; set; }
        public string ItemTitle { get; set; } = null!;
        public string ItemRuntime { get; set; } = null!;
        public string ItemUsernum { get; set; } = null!;
        public DateTime ItemRegdate { get; set; }
        public string? ItemNewsuserid { get; set; }
        public DateTime? ItemNewsregdate { get; set; }
        public string? ItemMemo { get; set; }
        public string? ItemFilename { get; set; }
        public string? ItemFilepath { get; set; }
        public string ItemUsed { get; set; } = null!;
        public string? ItemArea { get; set; }
        public decimal? ItemPgmid { get; set; }
        public string? ItemTag { get; set; }
        public string? ItemPlace { get; set; }
        public string ItemItchid { get; set; } = null!;
        public string? ItemMedaid { get; set; }
        public string? ItemClipid { get; set; }
        public decimal? ItemDowncnt { get; set; }
        public decimal? ItemDuration { get; set; }
        public DateTime? ItemDowndate { get; set; }

        public virtual Itemcodehigh ItemItch { get; set; } = null!;
        public virtual Mediainfo? ItemMeda { get; set; }
        public virtual Userinfo ItemUsernumNavigation { get; set; } = null!;
    }
}
