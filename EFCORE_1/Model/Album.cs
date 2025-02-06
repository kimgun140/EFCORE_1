using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class Album
    {
        public Album()
        {
            Albumtracks = new HashSet<Albumtrack>();
        }

        public decimal AlbmId { get; set; }
        public string? AlbmTitle2 { get; set; }
        public string AlbmTitle1 { get; set; } = null!;
        public string? AlbmTitle3 { get; set; }
        public string AlbmSbigid { get; set; } = null!;
        public string? AlbmSmidid { get; set; }
        public string AlbmFom { get; set; } = null!;
        public string? AlbmBarcode { get; set; }
        public string? AlbmImgpath { get; set; }
        public string? AlbmArtist { get; set; }
        public string? AlbmSale { get; set; }
        public string? AlbmDistributor { get; set; }
        public string? AlbmMemo { get; set; }
        public string AlbmUsed { get; set; } = null!;
        public string? AlbmUsernum { get; set; }
        public string? AlbmGrpno { get; set; }
        public DateTime AlbmRegdate { get; set; }
        public string? AlbmAskno { get; set; }
        public string? AlbmPrdco { get; set; }
        public string? AlbmTitle4 { get; set; }
        public string? AlbmPrdno { get; set; }
        public string? AlbmInputdiv { get; set; }
        public decimal? AlbmCopy { get; set; }
        public DateTime? AlbmDusdate { get; set; }
        public string? AlbmDuse { get; set; }
        public string? AlbmDusememo { get; set; }
        public string? AlbmSavepic { get; set; }
        public string? AlbmLendpre { get; set; }
        public string? AlbmLenduser { get; set; }
        public DateTime? AlbmLendpredat { get; set; }
        public string? AlbmLend { get; set; }
        public string? AlbmArea { get; set; }
        public string? AlbmTypeno { get; set; }
        public string? AlbmLang { get; set; }
        public DateTime? AlbmArgdate { get; set; }
        public string? AlbumThumbpathCbs { get; set; }

        public virtual Songbigcode AlbmSbig { get; set; } = null!;
        public virtual Userinfo? AlbmUsernumNavigation { get; set; }
        public virtual ICollection<Albumtrack> Albumtracks { get; set; }
    }
}
