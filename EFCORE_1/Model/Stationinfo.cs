using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class Stationinfo
    {
        public string StifIp { get; set; } = null!;
        public string StifName { get; set; } = null!;
        public string StifLogin { get; set; } = null!;
        public string? StifUsernum { get; set; }
    }
}
