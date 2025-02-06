using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class MpsClass
    {
        public MpsClass()
        {
            InverseParentCodeNavigation = new HashSet<MpsClass>();
            Albums = new HashSet<MpsAlbum>();
            Songs = new HashSet<MpsSong>();
        }

        public decimal Code { get; set; }
        public decimal? ParentCode { get; set; }
        public string? CodeName { get; set; }

        public virtual MpsClass? ParentCodeNavigation { get; set; }
        public virtual ICollection<MpsClass> InverseParentCodeNavigation { get; set; }

        public virtual ICollection<MpsAlbum> Albums { get; set; }
        public virtual ICollection<MpsSong> Songs { get; set; }
    }
}
