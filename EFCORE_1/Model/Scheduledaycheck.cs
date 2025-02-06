using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class Scheduledaycheck
    {
        public decimal ScdycheckId { get; set; }
        public string ScdycheckAreaid { get; set; } = null!;
        public string ScdycheckMedaid { get; set; } = null!;
        public string ScdycheckDate { get; set; } = null!;
        public string? ScdycheckChecked { get; set; }
        public DateTime? ScdycheckRegdate { get; set; }

        public virtual Areainfo ScdycheckArea { get; set; } = null!;
        public virtual Mediainfo ScdycheckMeda { get; set; } = null!;
    }
}
