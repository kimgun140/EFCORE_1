using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class Itemcodehigh
    {
        public Itemcodehigh()
        {
            Cms = new HashSet<Cm>();
            Itemcodelows = new HashSet<Itemcodelow>();
            Itemfiles = new HashSet<Itemfile>();
        }

        public string ItchId { get; set; } = null!;
        public string ItchName { get; set; } = null!;
        public string? ItchInfo { get; set; }
        public decimal? ItchOrder { get; set; }

        public virtual ICollection<Cm> Cms { get; set; }
        public virtual ICollection<Itemcodelow> Itemcodelows { get; set; }
        public virtual ICollection<Itemfile> Itemfiles { get; set; }
    }
}
