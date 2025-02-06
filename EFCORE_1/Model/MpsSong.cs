using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class MpsSong
    {
        public MpsSong()
        {
            MpsSongArtistMaps = new HashSet<MpsSongArtistMap>();
            MpsSongIndices = new HashSet<MpsSongIndex>();
            MpsSongInstMaps = new HashSet<MpsSongInstMap>();
            Codes = new HashSet<MpsClass>();
        }

        public string SongId { get; set; } = null!;
        public decimal? AlbumId { get; set; }
        public string? RepTitle { get; set; }
        public string? AddTitle { get; set; }
        public string? IntlTitle { get; set; }
        public decimal? Track { get; set; }
        public string? Genre { get; set; }
        public string? Duration { get; set; }
        public DateTime? Regdate { get; set; }
        public DateTime? Editdate { get; set; }
        public string? Composer { get; set; }
        public string? Arranger { get; set; }
        public string? Filepath { get; set; }
        public string? Filename { get; set; }
        public string? Memo { get; set; }
        public string? Grade { get; set; }
        public string? Istitle { get; set; }
        public string? Receiving { get; set; }
        public string? Type { get; set; }
        public string? AddArtist { get; set; }
        public string? SongTag { get; set; }

        public virtual MpsAlbum? Album { get; set; }
        public virtual MpsCommonCode? GradeNavigation { get; set; }
        public virtual MpsCommonCode? IstitleNavigation { get; set; }
        public virtual MpsCommonCode? ReceivingNavigation { get; set; }
        public virtual MpsCommonCode? TypeNavigation { get; set; }
        public virtual MpsClassic? MpsClassic { get; set; }
        public virtual MpsSongAddInfo? MpsSongAddInfo { get; set; }
        public virtual MpsSongArtistIdx? MpsSongArtistIdx { get; set; }
        public virtual MpsSongClassIdx? MpsSongClassIdx { get; set; }
        public virtual MpsSongInfo? MpsSongInfo { get; set; }
        public virtual ICollection<MpsSongArtistMap> MpsSongArtistMaps { get; set; }
        public virtual ICollection<MpsSongIndex> MpsSongIndices { get; set; }
        public virtual ICollection<MpsSongInstMap> MpsSongInstMaps { get; set; }

        public virtual ICollection<MpsClass> Codes { get; set; }
    }
}
