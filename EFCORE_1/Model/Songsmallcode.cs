using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class Songsmallcode
    {
        public string SsmlId { get; set; } = null!;
        public string SsmlSmidid { get; set; } = null!;
        public string SsmlName { get; set; } = null!;
        public decimal? SsmlOrder { get; set; }
        public string? SsmlUsed { get; set; }
        public string? SsmlSbigid { get; set; }

        public virtual Songmiddcode? SsmlS { get; set; }
    }
}
