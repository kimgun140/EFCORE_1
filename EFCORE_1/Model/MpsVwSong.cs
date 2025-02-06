using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class MpsVwSong
    {
        public string? ArtistId { get; set; }
        public string? ArtistName { get; set; }
        public string? AlbumTitle { get; set; }
        public string? AlbumAddTitle { get; set; }
        public decimal? AlbumSeqNo { get; set; }
        public string? AlbumGlobalTitle { get; set; }
        public string? Agency { get; set; }
        public string? AlbumReleaseDate { get; set; }
        public string? AlbumImagePath { get; set; }
        public string? AlbumAddType { get; set; }
        public string? AlbumType { get; set; }
        public string? AlbumRentalStatus { get; set; }
        public string? AlbumMemo { get; set; }
        public string? AlbumCallNo { get; set; }
        public decimal? AlbumId { get; set; }
        public string SongId { get; set; } = null!;
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
        public string? SongPath { get; set; }
        public string? Memo { get; set; }
        public string? Grade { get; set; }
        public string? Istitle { get; set; }
        public string? Receiving { get; set; }
        public string? Type { get; set; }
        public string? AddArtist { get; set; }
        public decimal? CateCode { get; set; }
        public string? CateCodeName { get; set; }
        public decimal? CateParentCode { get; set; }
        public decimal? CateRootCode { get; set; }
        public string? CateFullName { get; set; }
        public decimal? InstId { get; set; }
        public string? InstName { get; set; }
        public decimal? InstOrder { get; set; }
        public string? AlbumStockMainLocation { get; set; }
        public string? AlbumStockMiddleLocation { get; set; }
        public string? AlbumStockLocation { get; set; }
        public string? Lyricist { get; set; }
        public string? Lyrics { get; set; }
        public string? GradeName { get; set; }
        public string? ReceivingName { get; set; }
        public string? IstitleName { get; set; }
        public string? TypeName { get; set; }
        public string? OpusNo { get; set; }
        public string? MstInfo { get; set; }
        public decimal? DlCnt { get; set; }
        public decimal? LikeCnt { get; set; }
        public decimal? LbhCnt { get; set; }
        public string? SongTag { get; set; }
        public string? Keyword { get; set; }
    }
}
