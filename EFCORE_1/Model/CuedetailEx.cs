using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class CuedetailEx
    {
        public decimal CueCuesheetId { get; set; }
        public decimal CueCartNo { get; set; }
        public decimal CueCartOrder { get; set; }
        public string CueItemid { get; set; } = null!;
        public string CueItemtype { get; set; } = null!;
        public string CueFademode { get; set; } = null!;
        public string CueChainmode { get; set; } = null!;
        public string CueEdited { get; set; } = null!;
        public decimal? CueSom { get; set; }
        public decimal? CueEom { get; set; }
        public decimal? CueProgramid { get; set; }
        public decimal? CueCmgroupid { get; set; }
        public decimal? CueTrackno { get; set; }
        public decimal? CueChainreturntrackno { get; set; }

        public virtual CuesheetEx CueCuesheet { get; set; } = null!;
    }
}
