using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class Divisionlow
    {
        public Divisionlow()
        {
            Userinfos = new HashSet<Userinfo>();
        }

        public string DvslId { get; set; } = null!;
        public string DvslName { get; set; } = null!;
        public decimal? DvslOrder { get; set; }
        public string DvslDvshid { get; set; } = null!;

        public virtual Divisionhigh DvslDvsh { get; set; } = null!;
        public virtual ICollection<Userinfo> Userinfos { get; set; }
    }
}
