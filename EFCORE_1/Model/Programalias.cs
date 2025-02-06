using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class Programalias
    {
        public string PrgmaliasAreaid { get; set; } = null!;
        public string PrgmaliasMedaid { get; set; } = null!;
        public decimal PrgmaliasId { get; set; }
        public string? PrgmaliasAlias { get; set; }
        public DateTime PrgmaliasRegdate { get; set; }

        public virtual Areainfo PrgmaliasArea { get; set; } = null!;
        public virtual Mediainfo PrgmaliasMeda { get; set; } = null!;
    }
}
