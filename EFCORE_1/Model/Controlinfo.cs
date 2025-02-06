using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class Controlinfo
    {
        public Controlinfo()
        {
            Programs = new HashSet<Program>();
            Schebasedetails = new HashSet<Schebasedetail>();
            Schedaydetails = new HashSet<Schedaydetail>();
        }

        public decimal CtrlId { get; set; }
        public string CtrlName { get; set; } = null!;
        public decimal? CtrlOrder { get; set; }
        public decimal? CtrlNo { get; set; }
        public string? CtrlFilech { get; set; }
        public string? CtrlLivech { get; set; }
        public string? CtrlMedia { get; set; }

        public virtual ICollection<Program> Programs { get; set; }
        public virtual ICollection<Schebasedetail> Schebasedetails { get; set; }
        public virtual ICollection<Schedaydetail> Schedaydetails { get; set; }
    }
}
