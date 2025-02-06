using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class MpsAlbumArtistMap
    {
        public decimal AlbumId { get; set; }
        public decimal ArtistId { get; set; }
        public decimal? ArtistOrder { get; set; }

        public virtual MpsAlbum Album { get; set; } = null!;
        public virtual MpsArtist Artist { get; set; } = null!;
    }
}
