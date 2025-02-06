using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class Usergroup
    {
        public string GrupRead { get; set; } = null!;
        public string GrupWrite { get; set; } = null!;
        public string GrupDel { get; set; } = null!;
        public string GrupGrifid { get; set; } = null!;
        public string GrupScrnid { get; set; } = null!;

        public virtual Groupinfo GrupGrif { get; set; } = null!;
        public virtual Screeninfo GrupScrn { get; set; } = null!;
    }
}
