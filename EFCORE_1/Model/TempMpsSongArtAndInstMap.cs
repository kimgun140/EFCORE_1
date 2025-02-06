using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class TempMpsSongArtAndInstMap
    {
        public string? SongId { get; set; }
        public decimal? ArtistId { get; set; }
        public decimal? InstId { get; set; }
        public decimal? InstOrder { get; set; }
    }
}
