using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class Screeninfo
    {
        public Screeninfo()
        {
            Usergroups = new HashSet<Usergroup>();
        }

        public string ScrnId { get; set; } = null!;
        public string ScrnName { get; set; } = null!;
        public decimal? ScrnOrder { get; set; }

        public virtual ICollection<Usergroup> Usergroups { get; set; }
    }
}
