using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class Cmagency
    {
        public Cmagency()
        {
            Cms = new HashSet<Cm>();
        }

        public decimal CmagId { get; set; }
        public string CmagName { get; set; } = null!;
        public string CmagUsed { get; set; } = null!;
        public string? CmagCode { get; set; }

        public virtual ICollection<Cm> Cms { get; set; }
    }
}
