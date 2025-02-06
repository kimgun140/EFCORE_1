using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class Song
    {
        public Song()
        {
            Albumtracks = new HashSet<Albumtrack>();
        }

        public string SongId { get; set; } = null!;
        public string SongSbigid { get; set; } = null!;
        public string? SongSmidid { get; set; }
        public string SongAreaid { get; set; } = null!;
        public string? SongTitle1 { get; set; }
        public string? SongFilename { get; set; }
        public string? SongTitle2 { get; set; }
        public string? SongFilepath { get; set; }
        public string? SongTitle3 { get; set; }
        public decimal? SongAlbmid { get; set; }
        public decimal? SongAlbmtrack { get; set; }
        public string? SongTitle4 { get; set; }
        public string SongUsernum { get; set; } = null!;
        public DateTime? SongRegdate { get; set; }
        public string? SongKeyword1 { get; set; }
        public decimal? SongBitrate { get; set; }
        public decimal? SongFreq { get; set; }
        public string? SongFormat { get; set; }
        public string? SongKeyword2 { get; set; }
        public string? SongMode { get; set; }
        public string? SongKeyword3 { get; set; }
        public string? SongArtist1 { get; set; }
        public string? SongKeyword4 { get; set; }
        public string? SongWriter { get; set; }
        public string? SongComposer { get; set; }
        public string? SongArtist2 { get; set; }
        public string? SongRuntime { get; set; }
        public string? SongArtist3 { get; set; }
        public string SongUsed { get; set; } = null!;
        public string? SongArtist4 { get; set; }
        public string? SongMemo { get; set; }
        public string? SongSsmlid { get; set; }
        public string? SongPlaytype { get; set; }
        public string? SongOmnidiv { get; set; }
        public string? SongImgpath { get; set; }
        public string? SongForbidden { get; set; }
        public string? SongLang { get; set; }
        public string? SongLyrics { get; set; }
        public string? SongRecdate { get; set; }
        public string? SongArranger { get; set; }
        public string? SongSerno { get; set; }
        public string? SongMusist1 { get; set; }
        public string? SongMusist2 { get; set; }
        public string? SongMusist3 { get; set; }
        public string? SongMusist4 { get; set; }
        public string? SongTag { get; set; }
        public string? SongClipid { get; set; }
        public string? SongHityear { get; set; }
        public decimal SongDowncnt { get; set; }
        public string? SongTitlesong { get; set; }
        public decimal? SongDuration { get; set; }
        public string? SongArtist5 { get; set; }
        public string? SongArtist6 { get; set; }
        public string? SongArtist7 { get; set; }
        public string? SongArtist8 { get; set; }
        public string? SongArtist9 { get; set; }
        public string? SongArtist10 { get; set; }
        public string? SongMusist5 { get; set; }
        public string? SongMusist6 { get; set; }
        public string? SongMusist7 { get; set; }
        public string? SongMusist8 { get; set; }
        public string? SongMusist9 { get; set; }
        public string? SongMusist10 { get; set; }
        public DateTime? SongDowndate { get; set; }
        public string? SongServicetitleCbs { get; set; }
        public byte[]? SongLyricslobCbs { get; set; }

        public virtual Areainfo SongArea { get; set; } = null!;
        public virtual Songbigcode SongSbig { get; set; } = null!;
        public virtual Userinfo SongUsernumNavigation { get; set; } = null!;
        public virtual ICollection<Albumtrack> Albumtracks { get; set; }
    }
}
