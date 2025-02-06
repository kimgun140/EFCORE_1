using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class Cmconsent
    {
        public Cmconsent()
        {
            Cms = new HashSet<Cm>();
        }

        public decimal CmcsId { get; set; }
        public string CmcsName { get; set; } = null!;
        public string CmcsUsed { get; set; } = null!;

        public virtual ICollection<Cm> Cms { get; set; }
    }
}
