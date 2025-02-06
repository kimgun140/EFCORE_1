using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class Cmgroup
    {
        public Cmgroup()
        {
            Cmassignrevs = new HashSet<Cmassignrev>();
            Cmassigns = new HashSet<Cmassign>();
            Cuedetails = new HashSet<Cuedetail>();
        }

        public decimal CmgrId { get; set; }
        public string CmgrName { get; set; } = null!;

        public virtual ICollection<Cmassignrev> Cmassignrevs { get; set; }
        public virtual ICollection<Cmassign> Cmassigns { get; set; }
        public virtual ICollection<Cuedetail> Cuedetails { get; set; }
    }
}
