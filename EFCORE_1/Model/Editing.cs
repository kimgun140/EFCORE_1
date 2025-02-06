using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class Editing
    {
        public string EditFileid { get; set; } = null!;
        public string EditFiletype { get; set; } = null!;
        public string? EditSom { get; set; }
        public string? EditEom { get; set; }
        public string? EditFilelength { get; set; }
        public string EditUsernum { get; set; } = null!;
        public string? EditUpusernum { get; set; }
        public DateTime EditEditdate { get; set; }
        public DateTime? EditUpdate { get; set; }
        public string? EditWorkpath { get; set; }
        public string? EditFilepath { get; set; }
        public string EditTitle { get; set; } = null!;
        public string? EditAudiomode { get; set; }
        public decimal? EditFreq { get; set; }
        public decimal? EditBitrate { get; set; }
        public string? EditDeldate { get; set; }
        public string? EditIsedit { get; set; }
        public string? EditIsaudio { get; set; }

        public virtual Userinfo EditUsernumNavigation { get; set; } = null!;
    }
}
