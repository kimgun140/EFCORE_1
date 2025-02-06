using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class MpsVwSongSearch
    {
        public decimal? AlbumId { get; set; }
        public string SongId { get; set; } = null!;
        public string? AlbumRepTitle { get; set; }
        public string? AlbumAddTitle { get; set; }
        public string? AlbumRelyear { get; set; }
        public string? AlbumLoanStatus { get; set; }
        public DateTime? AlbumRegdate { get; set; }
        public string? AlbumMemo { get; set; }
        public string? AlbumClassCode { get; set; }
        public string? AlbumImagePath { get; set; }
        public decimal? SongTrack { get; set; }
        public string? SongIstitle { get; set; }
        public string? SongRepTitle { get; set; }
        public string? SongAddTitle { get; set; }
        public string? SongArtistId { get; set; }
        public string? SongArtistRepName { get; set; }
        public string? SongArtistAddName { get; set; }
        public string? SongComposer { get; set; }
        public string? SongArranger { get; set; }
        public string? SongLyricist { get; set; }
        public string? SongClassCode { get; set; }
        public decimal? SongDlCnt { get; set; }
        public decimal? SongLikeCnt { get; set; }
        public string? SongDuration { get; set; }
        public DateTime? SongRegdate { get; set; }
        public DateTime? SongEditdate { get; set; }
        public string? SongFilename { get; set; }
        public string? SongFilepath { get; set; }
        public string? SongLyrics { get; set; }
    }
}
