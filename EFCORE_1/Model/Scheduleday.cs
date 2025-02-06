using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class Scheduleday
    {
        public Scheduleday()
        {
            Schedaydetails = new HashSet<Schedaydetail>();
        }

        public string ScdyAreaid { get; set; } = null!;
        public string ScdyMedaid { get; set; } = null!;
        public string ScdyDate { get; set; } = null!;
        public string ScdyUsernum { get; set; } = null!;
        public string ScdyType { get; set; } = null!;
        public DateTime ScdyRegdate { get; set; }
        public string? ScdyWritable { get; set; }

        public virtual Areainfo ScdyArea { get; set; } = null!;
        public virtual Mediainfo ScdyMeda { get; set; } = null!;
        public virtual Userinfo ScdyUsernumNavigation { get; set; } = null!;
        public virtual ICollection<Schedaydetail> Schedaydetails { get; set; }
    }
}
