using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class Areainfo
    {
        public Areainfo()
        {
            Programaliases = new HashSet<Programalias>();
            Programs = new HashSet<Program>();
            Schedulebases = new HashSet<Schedulebase>();
            Scheduledaychecks = new HashSet<Scheduledaycheck>();
            Scheduledays = new HashSet<Scheduleday>();
            Songs = new HashSet<Song>();
            Userinfos = new HashSet<Userinfo>();
        }

        public string AreaId { get; set; } = null!;
        public string AreaName { get; set; } = null!;
        public decimal? AreaOrder { get; set; }

        public virtual ICollection<Programalias> Programaliases { get; set; }
        public virtual ICollection<Program> Programs { get; set; }
        public virtual ICollection<Schedulebase> Schedulebases { get; set; }
        public virtual ICollection<Scheduledaycheck> Scheduledaychecks { get; set; }
        public virtual ICollection<Scheduleday> Scheduledays { get; set; }
        public virtual ICollection<Song> Songs { get; set; }
        public virtual ICollection<Userinfo> Userinfos { get; set; }
    }
}
