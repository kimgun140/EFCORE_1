using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class Defaultconf
    {
        public string DftcCode { get; set; } = null!;
        public string DftcValue { get; set; } = null!;
        public string? DftcName { get; set; }
        public string? DftcMemo { get; set; }
    }
}
