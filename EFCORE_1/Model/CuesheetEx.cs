using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class CuesheetEx
    {
        public CuesheetEx()
        {
            Cuedetailices = new HashSet<CuedetailEx>();
        }

        public decimal CuesheetId { get; set; }
        public string CuesheetTitle { get; set; } = null!;
        public string? CuesheetMemo { get; set; }
        public string? CuesheetUsernum { get; set; }
        public DateTime CuesheetSavedate { get; set; }

        public virtual Userinfo? CuesheetUsernumNavigation { get; set; }
        public virtual ICollection<CuedetailEx> Cuedetailices { get; set; }
    }
}
