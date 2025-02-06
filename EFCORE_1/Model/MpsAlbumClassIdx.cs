using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class MpsAlbumClassIdx
    {
        public decimal AlbumId { get; set; }
        public string? ClassCode { get; set; }

        public virtual MpsAlbum Album { get; set; } = null!;
    }
}
