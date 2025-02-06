using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class MpsIfLbhRainbow
    {
        public decimal Seq { get; set; }
        public string? MediaId { get; set; }
        public string? MediaName { get; set; }
        public decimal? PgmId { get; set; }
        public string? PgmName { get; set; }
        public string? SongId { get; set; }
        public string? SongName { get; set; }
        public string? ArtistName { get; set; }
        public decimal? SongLength { get; set; }
        public string? ActionFlag { get; set; }
        public DateTime? ActionDtm { get; set; }
        public DateTime? RegDtm { get; set; }
    }
}
