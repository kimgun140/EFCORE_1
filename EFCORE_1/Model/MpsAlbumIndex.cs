using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class MpsAlbumIndex
    {
        public decimal AlbumId { get; set; }
        public string Keyword { get; set; } = null!;

        public virtual MpsAlbum Album { get; set; } = null!;
    }
}
