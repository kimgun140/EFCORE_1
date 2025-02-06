using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class TempSongmusistcode
    {
        public string SmstCode { get; set; } = null!;
        public string? SmstName { get; set; }
        public string? SmstUsernum { get; set; }
        public DateTime SmstRegdate { get; set; }
        public decimal? SmstMpscode { get; set; }
    }
}
