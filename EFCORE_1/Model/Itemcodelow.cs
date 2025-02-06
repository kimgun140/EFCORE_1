using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class Itemcodelow
    {
        public string ItclItchid { get; set; } = null!;
        public decimal ItclId { get; set; }
        public string ItclName { get; set; } = null!;
        public string? ItclInfo { get; set; }
        public decimal? ItclOrder { get; set; }
        public string? ItclUsed { get; set; }

        public virtual Itemcodehigh ItclItch { get; set; } = null!;
    }
}
