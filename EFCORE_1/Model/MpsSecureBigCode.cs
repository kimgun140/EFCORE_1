using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class MpsSecureBigCode
    {
        public MpsSecureBigCode()
        {
            MpsAlbums = new HashSet<MpsAlbum>();
            MpsSecureMidCodes = new HashSet<MpsSecureMidCode>();
        }

        public string Code { get; set; } = null!;
        public string? CodeName { get; set; }

        public virtual ICollection<MpsAlbum> MpsAlbums { get; set; }
        public virtual ICollection<MpsSecureMidCode> MpsSecureMidCodes { get; set; }
    }
}
