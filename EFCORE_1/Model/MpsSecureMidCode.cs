using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class MpsSecureMidCode
    {
        public string Code { get; set; } = null!;
        public string ParentCode { get; set; } = null!;
        public string? CodeName { get; set; }

        public virtual MpsSecureBigCode ParentCodeNavigation { get; set; } = null!;
    }
}
