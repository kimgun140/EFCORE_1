using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class MpsRequestSong
    {
        public decimal? ReqId { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public string? Reason { get; set; }
        public DateTime? Regdate { get; set; }
        public string? UserId { get; set; }
        public string? Status { get; set; }
    }
}
