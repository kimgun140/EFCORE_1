using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class Groupinfo
    {
        public Groupinfo()
        {
            Usergroups = new HashSet<Usergroup>();
            Userinfos = new HashSet<Userinfo>();
        }

        public string GrifId { get; set; } = null!;
        public string GrifName { get; set; } = null!;
        public decimal? GrifOrder { get; set; }

        public virtual ICollection<Usergroup> Usergroups { get; set; }
        public virtual ICollection<Userinfo> Userinfos { get; set; }
    }
}
