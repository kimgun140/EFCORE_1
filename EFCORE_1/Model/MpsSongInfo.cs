using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class MpsSongInfo
    {
        public string SongId { get; set; } = null!;
        public string? Lyricist { get; set; }
        public string? Lyrics1 { get; set; }
        public string? Lyrics2 { get; set; }

        public virtual MpsSong Song { get; set; } = null!;
    }
}
