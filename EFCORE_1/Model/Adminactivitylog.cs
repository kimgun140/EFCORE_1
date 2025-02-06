using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class Adminactivitylog
    {
        public int LogId { get; set; }
        public string AdminId { get; set; } = null!;
        public DateTime ActivityDatetime { get; set; }
        public string AccessIp { get; set; } = null!;
        public string SubjectId { get; set; } = null!;
        public string? SubjectName { get; set; }
        public string ActivityId { get; set; } = null!;
        public string? ActivityDescription { get; set; }
    }
}
