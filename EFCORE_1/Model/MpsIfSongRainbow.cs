using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class MpsIfSongRainbow
    {
        public decimal Seq { get; set; }
        public string? SongId { get; set; }
        public string? ActionFlag { get; set; }
        public DateTime? RegDtm { get; set; }
    }
}
