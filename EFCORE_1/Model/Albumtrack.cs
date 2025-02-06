using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class Albumtrack
    {
        public decimal AbtrAlbmid { get; set; }
        public decimal AbtrTrack { get; set; }
        public string? AbtrSongid { get; set; }
        public string? AbtrSongtitle { get; set; }
        public string? AbtrArtist { get; set; }
        public string? AbtrRuntime { get; set; }
        public string? AbtrTitlesong { get; set; }

        public virtual Album AbtrAlbm { get; set; } = null!;
        public virtual Song? AbtrSong { get; set; }
    }
}
