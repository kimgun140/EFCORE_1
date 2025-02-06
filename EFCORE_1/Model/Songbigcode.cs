using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class Songbigcode
    {
        public Songbigcode()
        {
            Albums = new HashSet<Album>();
            Songmiddcodes = new HashSet<Songmiddcode>();
            Songs = new HashSet<Song>();
        }

        public string SbigId { get; set; } = null!;
        public string SbigName { get; set; } = null!;
        public decimal? SbigOrder { get; set; }
        public string? SbigUsed { get; set; }

        public virtual ICollection<Album> Albums { get; set; }
        public virtual ICollection<Songmiddcode> Songmiddcodes { get; set; }
        public virtual ICollection<Song> Songs { get; set; }
    }
}
