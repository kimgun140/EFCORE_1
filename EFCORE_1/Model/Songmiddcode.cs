using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class Songmiddcode
    {
        public Songmiddcode()
        {
            Songsmallcodes = new HashSet<Songsmallcode>();
        }

        public string SmidId { get; set; } = null!;
        public string SmidName { get; set; } = null!;
        public decimal? SmidOrder { get; set; }
        public string SmidSbigid { get; set; } = null!;
        public string? SmidUsed { get; set; }

        public virtual Songbigcode SmidSbig { get; set; } = null!;
        public virtual ICollection<Songsmallcode> Songsmallcodes { get; set; }
    }
}
