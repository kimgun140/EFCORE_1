using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class MpsArtist
    {
        public MpsArtist()
        {
            MpsAlbumArtistMaps = new HashSet<MpsAlbumArtistMap>();
            MpsSongArtistMaps = new HashSet<MpsSongArtistMap>();
            Insts = new HashSet<MpsInst>();
        }

        public decimal ArtistId { get; set; }
        public string? RepName { get; set; }
        public string? AddName { get; set; }
        public string? Gender { get; set; }
        public DateTime? Regdate { get; set; }
        public DateTime? Editdate { get; set; }

        public virtual ICollection<MpsAlbumArtistMap> MpsAlbumArtistMaps { get; set; }
        public virtual ICollection<MpsSongArtistMap> MpsSongArtistMaps { get; set; }

        public virtual ICollection<MpsInst> Insts { get; set; }
    }
}
