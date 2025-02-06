using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class Permissionchangelog
    {
        public decimal PermissionLogId { get; set; }
        public decimal UserId { get; set; }
        public string AccessIp { get; set; } = null!;
        public DateTime ProcessedDatetime { get; set; }
        public string PermissionChangeDetail { get; set; } = null!;
        public string SubjectId { get; set; } = null!;
        public string SubjectName { get; set; } = null!;
    }
}
