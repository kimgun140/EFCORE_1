using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class MpsAlbum
    {
        public MpsAlbum()
        {
            MpsAlbumArtistMaps = new HashSet<MpsAlbumArtistMap>();
            MpsAlbumIndices = new HashSet<MpsAlbumIndex>();
            MpsAlbumLoans = new HashSet<MpsAlbumLoan>();
            MpsSongs = new HashSet<MpsSong>();
            Codes = new HashSet<MpsClass>();
        }

        public decimal AlbumId { get; set; }
        public string? SecureCode { get; set; }
        public string? SecurePcode { get; set; }
        public decimal? SecureNum { get; set; }
        public string? RepTitle { get; set; }
        public string? AddTitle { get; set; }
        public string? IntlTitle { get; set; }
        public string? Agency { get; set; }
        public string? Relyear { get; set; }
        public DateTime? Regdate { get; set; }
        public DateTime? Editdate { get; set; }
        public string? ImagePath { get; set; }
        public string? Isuse { get; set; }
        public DateTime? Deldate { get; set; }
        public string? Receiving { get; set; }
        public string? Form { get; set; }
        public string? LoanStatus { get; set; }
        public string? AddArtist { get; set; }
        public string? Memo { get; set; }

        public virtual MpsCommonCode? FormNavigation { get; set; }
        public virtual MpsCommonCode? IsuseNavigation { get; set; }
        public virtual MpsCommonCode? LoanStatusNavigation { get; set; }
        public virtual MpsCommonCode? ReceivingNavigation { get; set; }
        public virtual MpsSecureBigCode? SecurePcodeNavigation { get; set; }
        public virtual MpsAlbumClassIdx? MpsAlbumClassIdx { get; set; }
        public virtual ICollection<MpsAlbumArtistMap> MpsAlbumArtistMaps { get; set; }
        public virtual ICollection<MpsAlbumIndex> MpsAlbumIndices { get; set; }
        public virtual ICollection<MpsAlbumLoan> MpsAlbumLoans { get; set; }
        public virtual ICollection<MpsSong> MpsSongs { get; set; }

        public virtual ICollection<MpsClass> Codes { get; set; }
    }
}
