using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class MpsVwRootClass
    {
        public decimal? RootCode { get; set; }
        public decimal Code { get; set; }
        public decimal? ParentCode { get; set; }
        public string? CodeName { get; set; }
    }
}
