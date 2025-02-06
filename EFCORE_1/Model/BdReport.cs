using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class BdReport
    {
        public DateTime RecDatetime { get; set; }
        public string JournalistId { get; set; } = null!;
        public string ReportFilepath { get; set; } = null!;
        public string ReportFiletype { get; set; } = null!;
        public decimal ReportLength { get; set; }
        public string? NewsCd { get; set; }
        public string? Reportname { get; set; }
    }
}
