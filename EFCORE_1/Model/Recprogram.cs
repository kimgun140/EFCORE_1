using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class Recprogram
    {
        public string RecId { get; set; } = null!;
        public string RecBrdtime { get; set; } = null!;
        public string RecTitle { get; set; } = null!;
        public string RecUsernum { get; set; } = null!;
        public DateTime RecRegdate { get; set; }
        public string? RecMemo { get; set; }
        public string RecRuntime { get; set; } = null!;
        public string? RecFilename { get; set; }
        public string RecBrddate { get; set; } = null!;
        public string RecUsed { get; set; } = null!;
        public string RecPrgmareaid { get; set; } = null!;
        public string? RecFilepath { get; set; }
        public string RecPrgmmedaid { get; set; } = null!;
        public decimal RecPrgmid { get; set; }
        public string? RecClipid { get; set; }
        public decimal? RecDuration { get; set; }

        public virtual Program RecPrgm { get; set; } = null!;
        public virtual Userinfo RecUsernumNavigation { get; set; } = null!;
    }
}
