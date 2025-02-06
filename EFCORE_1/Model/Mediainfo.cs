using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class Mediainfo
    {
        public Mediainfo()
        {
            Costcodelists = new HashSet<Costcodelist>();
            Itemfiles = new HashSet<Itemfile>();
            Programaliases = new HashSet<Programalias>();
            Programs = new HashSet<Program>();
            Schedulebases = new HashSet<Schedulebase>();
            Scheduledaychecks = new HashSet<Scheduledaycheck>();
            Scheduledays = new HashSet<Scheduleday>();
        }

        public string MedaId { get; set; } = null!;
        public string MedaName { get; set; } = null!;
        public decimal? MedaOrder { get; set; }

        public virtual ICollection<Costcodelist> Costcodelists { get; set; }
        public virtual ICollection<Itemfile> Itemfiles { get; set; }
        public virtual ICollection<Programalias> Programaliases { get; set; }
        public virtual ICollection<Program> Programs { get; set; }
        public virtual ICollection<Schedulebase> Schedulebases { get; set; }
        public virtual ICollection<Scheduledaycheck> Scheduledaychecks { get; set; }
        public virtual ICollection<Scheduleday> Scheduledays { get; set; }
    }
}
