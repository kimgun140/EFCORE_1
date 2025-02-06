using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class MpsCommonCode
    {
        public MpsCommonCode()
        {
            MpsAlbumFormNavigations = new HashSet<MpsAlbum>();
            MpsAlbumIsuseNavigations = new HashSet<MpsAlbum>();
            MpsAlbumLoanStatusNavigations = new HashSet<MpsAlbum>();
            MpsAlbumReceivingNavigations = new HashSet<MpsAlbum>();
            MpsSongGradeNavigations = new HashSet<MpsSong>();
            MpsSongIstitleNavigations = new HashSet<MpsSong>();
            MpsSongReceivingNavigations = new HashSet<MpsSong>();
            MpsSongTypeNavigations = new HashSet<MpsSong>();
        }

        public string Code { get; set; } = null!;
        public string? ParentCode { get; set; }
        public string? CodeName { get; set; }

        public virtual ICollection<MpsAlbum> MpsAlbumFormNavigations { get; set; }
        public virtual ICollection<MpsAlbum> MpsAlbumIsuseNavigations { get; set; }
        public virtual ICollection<MpsAlbum> MpsAlbumLoanStatusNavigations { get; set; }
        public virtual ICollection<MpsAlbum> MpsAlbumReceivingNavigations { get; set; }
        public virtual ICollection<MpsSong> MpsSongGradeNavigations { get; set; }
        public virtual ICollection<MpsSong> MpsSongIstitleNavigations { get; set; }
        public virtual ICollection<MpsSong> MpsSongReceivingNavigations { get; set; }
        public virtual ICollection<MpsSong> MpsSongTypeNavigations { get; set; }
    }
}
