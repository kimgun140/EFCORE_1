using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class MpsSongArtistIdx
    {
        public string SongId { get; set; } = null!;
        public string? ArtistId { get; set; }
        public string? ArtistRepName { get; set; }
        public string? ArtistAddName { get; set; }
        public string? FeatName { get; set; }

        public virtual MpsSong Song { get; set; } = null!;
    }
}
