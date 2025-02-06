using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class MpsIdxSongInfoWord
    {
        public string SongId { get; set; } = null!;
        public string? ArtistType { get; set; }
        public string? IdxKeyword { get; set; }
    }
}
