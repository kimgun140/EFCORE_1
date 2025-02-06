using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class MpsSongArtistMap
    {
        public string SongId { get; set; } = null!;
        public decimal ArtistId { get; set; }
        public decimal? ArtistOrder { get; set; }

        public virtual MpsArtist Artist { get; set; } = null!;
        public virtual MpsSong Song { get; set; } = null!;
    }
}
