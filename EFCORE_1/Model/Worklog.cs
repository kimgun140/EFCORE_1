using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class Worklog
    {
        public DateTime WlogDate { get; set; }
        public string? WlogMedia { get; set; }
        public string WlogStifip { get; set; } = null!;
        public string? WlogUsernum { get; set; }
        public string WlogType { get; set; } = null!;
        public string? WlogExefile { get; set; }
        public string WlogMemo { get; set; } = null!;
    }
}
