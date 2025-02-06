using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class Cm
    {
        public Cm()
        {
            Cmassignrevs = new HashSet<Cmassignrev>();
            Cmassigns = new HashSet<Cmassign>();
        }

        public string CmId { get; set; } = null!;
        public decimal? CmCmclid { get; set; }
        public decimal? CmCmagid { get; set; }
        public string CmRuntime { get; set; } = null!;
        public string CmTitle { get; set; } = null!;
        public DateTime CmRegdate { get; set; }
        public string? CmReturndate { get; set; }
        public string? CmLimit { get; set; }
        public string? CmFilename { get; set; }
        public string? CmFilepath { get; set; }
        public string? CmClientname { get; set; }
        public string? CmAgencyname { get; set; }
        public string CmUsernum { get; set; } = null!;
        public string? CmDiscusnum { get; set; }
        public string CmUsed { get; set; } = null!;
        public decimal? CmCmcsid { get; set; }
        public string? CmConsentname { get; set; }
        public string? CmItchid { get; set; }
        public decimal? CmItclid { get; set; }
        public string? CmMedia { get; set; }
        public decimal? CmVruntime { get; set; }
        public string CmViewtitle { get; set; } = null!;
        public string? CmMemo { get; set; }
        public string? CmClipid { get; set; }
        public decimal? CmDuration { get; set; }

        public virtual Cmagency? CmCmag { get; set; }
        public virtual Cmclient? CmCmcl { get; set; }
        public virtual Cmconsent? CmCmcs { get; set; }
        public virtual Itemcodehigh? CmItch { get; set; }
        public virtual Userinfo CmUsernumNavigation { get; set; } = null!;
        public virtual ICollection<Cmassignrev> Cmassignrevs { get; set; }
        public virtual ICollection<Cmassign> Cmassigns { get; set; }
    }
}
