using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class Schedulebase
    {
        public Schedulebase()
        {
            Schebasedetails = new HashSet<Schebasedetail>();
        }

        public string ScbsAreaid { get; set; } = null!;
        public string ScbsMedaid { get; set; } = null!;
        public decimal ScbsSeq { get; set; }
        public string ScbsWeek { get; set; } = null!;
        public string ScbsType { get; set; } = null!;
        public string ScbsTitle { get; set; } = null!;
        public string? ScbsEdate { get; set; }
        public string ScbsSdate { get; set; } = null!;
        public string? ScbsMemo { get; set; }
        public string ScbsUsernum { get; set; } = null!;
        public DateTime ScbsRegdate { get; set; }
        public string? ScbsWritable { get; set; }

        public virtual Areainfo ScbsArea { get; set; } = null!;
        public virtual Mediainfo ScbsMeda { get; set; } = null!;
        public virtual Userinfo ScbsUsernumNavigation { get; set; } = null!;
        public virtual ICollection<Schebasedetail> Schebasedetails { get; set; }
    }
}
