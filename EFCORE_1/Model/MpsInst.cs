using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class MpsInst
    {
        public MpsInst()
        {
            MpsSongInstMaps = new HashSet<MpsSongInstMap>();
            Artists = new HashSet<MpsArtist>();
        }

        public decimal InstId { get; set; }
        public string? RepName { get; set; }
        public string? AddName { get; set; }

        public virtual ICollection<MpsSongInstMap> MpsSongInstMaps { get; set; }

        public virtual ICollection<MpsArtist> Artists { get; set; }
    }
}
