using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class Cmclient
    {
        public Cmclient()
        {
            Cms = new HashSet<Cm>();
        }

        public decimal CmclId { get; set; }
        public string CmclName { get; set; } = null!;
        public string CmclUsed { get; set; } = null!;

        public virtual ICollection<Cm> Cms { get; set; }
    }
}
