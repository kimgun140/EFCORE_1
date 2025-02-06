using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class Divisionhigh
    {
        public Divisionhigh()
        {
            Divisionlows = new HashSet<Divisionlow>();
            Userinfos = new HashSet<Userinfo>();
        }

        public string DvshId { get; set; } = null!;
        public string DvshName { get; set; } = null!;
        public decimal? DvshOrder { get; set; }

        public virtual ICollection<Divisionlow> Divisionlows { get; set; }
        public virtual ICollection<Userinfo> Userinfos { get; set; }
    }
}
