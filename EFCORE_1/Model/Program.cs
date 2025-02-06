using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class Program
    {
        public Program()
        {
            Cmassignrevs = new HashSet<Cmassignrev>();
            Cmassigns = new HashSet<Cmassign>();
            Costprograms = new HashSet<Costprogram>();
            Cuesheets = new HashSet<Cuesheet>();
            Recprograms = new HashSet<Recprogram>();
        }

        public string PrgmAreaid { get; set; } = null!;
        public string PrgmMedaid { get; set; } = null!;
        public decimal PrgmId { get; set; }
        public decimal? PrgmParentid { get; set; }
        public string PrgmTitle { get; set; } = null!;
        public string PrgmPgtype { get; set; } = null!;
        public string PrgmBrdtime { get; set; } = null!;
        public string PrgmRuntime { get; set; } = null!;
        public decimal PrgmCtrlid1 { get; set; }
        public decimal? PrgmCtrlid2 { get; set; }
        public string PrgmTrtype { get; set; } = null!;
        public decimal PrgmFadein { get; set; }
        public decimal PrgmFadeout { get; set; }
        public decimal PrgmLevel { get; set; }
        public string PrgmBrdtype { get; set; } = null!;
        public string PrgmTimed { get; set; } = null!;
        public string PrgmUsernum { get; set; } = null!;
        public string PrgmUsed { get; set; } = null!;
        public string? PrgmMemo { get; set; }
        public string? PrgmSdate { get; set; }
        public string? PrgmEdate { get; set; }
        public string PrgmWeek1 { get; set; } = null!;
        public string PrgmWeek2 { get; set; } = null!;
        public string PrgmWeek3 { get; set; } = null!;
        public string PrgmWeek4 { get; set; } = null!;
        public string PrgmWeek5 { get; set; } = null!;
        public string PrgmWeek6 { get; set; } = null!;
        public string PrgmChkdate { get; set; } = null!;
        public DateTime PrgmRegdate { get; set; }
        public string PrgmWeek7 { get; set; } = null!;
        public string? PrgmRelay { get; set; }

        public virtual Areainfo PrgmArea { get; set; } = null!;
        public virtual Controlinfo PrgmCtrlid1Navigation { get; set; } = null!;
        public virtual Mediainfo PrgmMeda { get; set; } = null!;
        public virtual Userinfo PrgmUsernumNavigation { get; set; } = null!;
        public virtual ICollection<Cmassignrev> Cmassignrevs { get; set; }
        public virtual ICollection<Cmassign> Cmassigns { get; set; }
        public virtual ICollection<Costprogram> Costprograms { get; set; }
        public virtual ICollection<Cuesheet> Cuesheets { get; set; }
        public virtual ICollection<Recprogram> Recprograms { get; set; }
    }
}
