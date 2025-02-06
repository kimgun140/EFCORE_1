using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class MpsSongInfoIdx
    {
        public string SongId { get; set; } = null!;
        public string? Composer { get; set; }
        public string? Lyricist { get; set; }
        public string? Arranger { get; set; }
    }
}
