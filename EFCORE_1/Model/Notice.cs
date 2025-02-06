using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class Notice
    {
        public decimal NotcId { get; set; }
        public string NotcType { get; set; } = null!;
        public string NotcSender { get; set; } = null!;
        public string? NotcReceiver { get; set; }
        public string NotcTitle { get; set; } = null!;
        public string NotcContent { get; set; } = null!;
        public string? NotcSdate { get; set; }
        public string? NotcEdate { get; set; }
        public string? NotcCheck { get; set; }
        public DateTime? NotcRegdate { get; set; }
    }
}
