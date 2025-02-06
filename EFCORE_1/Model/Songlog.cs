using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class Songlog
    {
        public string SlogSongid { get; set; } = null!;
        public DateTime SlogDate { get; set; }
        public string? SlogPrgmareaid { get; set; }
        public string? SlogPrgmmedaid { get; set; }
        public decimal? SlogPrgmid { get; set; }
        public string SlogUsernum { get; set; } = null!;

        public virtual Program? SlogPrgm { get; set; }
        public virtual Song SlogSong { get; set; } = null!;
        public virtual Userinfo SlogUsernumNavigation { get; set; } = null!;
    }
}
