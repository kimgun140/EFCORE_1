using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class MpsClassic
    {
        public string SongId { get; set; } = null!;
        public string? OpusNo { get; set; }

        public virtual MpsSong Song { get; set; } = null!;
    }
}
