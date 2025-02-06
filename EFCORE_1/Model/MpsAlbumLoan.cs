using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class MpsAlbumLoan
    {
        public decimal LoanId { get; set; }
        public decimal AlbumId { get; set; }
        public string? UserId { get; set; }
        public DateTime? Bordate { get; set; }
        public DateTime? Retdate { get; set; }
        public string? Status { get; set; }

        public virtual MpsAlbum Album { get; set; } = null!;
        public virtual Userinfo? User { get; set; }
    }
}
