using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class RbtSongForSearchEngine
    {
        public string SongId { get; set; } = null!;
        public string? SongTitle1 { get; set; }
        public string? SongArtist1 { get; set; }
        public string? SongArtist2 { get; set; }
        public string? SongArtist3 { get; set; }
        public string? SongArtist4 { get; set; }
        public decimal SongDowncnt { get; set; }
    }
}
