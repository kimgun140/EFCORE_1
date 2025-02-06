using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class MpsSongInstMap
    {
        public string SongId { get; set; } = null!;
        public decimal InstId { get; set; }
        public decimal InstOrder { get; set; }

        public virtual MpsInst Inst { get; set; } = null!;
        public virtual MpsSong Song { get; set; } = null!;
    }
}
