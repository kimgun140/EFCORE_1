using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class MpsVwSongHistory
    {
        public string? SongId { get; set; }
        public decimal? LbhToday { get; set; }
        public decimal? LbhDay3 { get; set; }
        public decimal? LbhWeek1 { get; set; }
        public decimal? LbhWeek2 { get; set; }
    }
}
