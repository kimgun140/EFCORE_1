using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class MpsSongIndex
    {
        public string SongId { get; set; } = null!;
        public string Keyword { get; set; } = null!;

        public virtual MpsSong Song { get; set; } = null!;
    }
}
