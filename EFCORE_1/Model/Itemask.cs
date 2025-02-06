using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class Itemask
    {
        public string? IaskItemtype { get; set; }
        public string IaskFileid { get; set; } = null!;
        public string? IaskAskuser { get; set; }
        public DateTime? IaskAsktime { get; set; }
        public string? IaskExport { get; set; }
        public DateTime? IaskExptime { get; set; }
        public string? IaskExpfile { get; set; }
        public string? IaskExppath { get; set; }
        public string? IaskTake { get; set; }
        public string? IaskTakeuser { get; set; }
        public DateTime? IaskTaketime { get; set; }
    }
}
