using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class MpsSongAddInfo
    {
        public string SongId { get; set; } = null!;
        public string? MstInfo { get; set; }
        public decimal? DlCnt { get; set; }
        public decimal? LikeCnt { get; set; }
        public decimal? LbhCnt { get; set; }

        public virtual MpsSong Song { get; set; } = null!;
    }
}
