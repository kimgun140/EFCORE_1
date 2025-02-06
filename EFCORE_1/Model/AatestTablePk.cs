using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class AatestTablePk
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Url { get; set; }
        public string Description { get; set; } = null!;
    }
}
