using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class MpsSongClassIdx
    {
        public string SongId { get; set; } = null!;
        public string? ClassCode { get; set; }

        public virtual MpsSong Song { get; set; } = null!;
    }
}
