using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class Userinfo
    {
        public Userinfo()
        {
            Albums = new HashSet<Album>();
            Cmassignrevs = new HashSet<Cmassignrev>();
            Cmassigns = new HashSet<Cmassign>();
            Cms = new HashSet<Cm>();
            Costcodelists = new HashSet<Costcodelist>();
            Costpgmlists = new HashSet<Costpgmlist>();
            Cuesheetices = new HashSet<CuesheetEx>();
            Cuesheets = new HashSet<Cuesheet>();
            Editings = new HashSet<Editing>();
            Itemfiles = new HashSet<Itemfile>();
            MpsAlbumLoans = new HashSet<MpsAlbumLoan>();
            Programs = new HashSet<Program>();
            Recprograms = new HashSet<Recprogram>();
            Schedulebases = new HashSet<Schedulebase>();
            Scheduledays = new HashSet<Scheduleday>();
            Songartistcodes = new HashSet<Songartistcode>();
            Songmusistcodes = new HashSet<Songmusistcode>();
            Songs = new HashSet<Song>();
        }

        public string? UserId { get; set; }
        public string UserPw { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string UserGrifid { get; set; } = null!;
        public string UserAreaid { get; set; } = null!;
        public string UserLogin { get; set; } = null!;
        public string? UserIndate { get; set; }
        public string? UserPhon { get; set; }
        public string? UserTel { get; set; }
        public string UserDvshid { get; set; } = null!;
        public string UserUsed { get; set; } = null!;
        public string? UserEmail { get; set; }
        public string UserDvslid { get; set; } = null!;
        public string? UserMemo { get; set; }
        public string UserNum { get; set; } = null!;

        public virtual Areainfo UserArea { get; set; } = null!;
        public virtual Divisionhigh UserDvsh { get; set; } = null!;
        public virtual Divisionlow UserDvsl { get; set; } = null!;
        public virtual Groupinfo UserGrif { get; set; } = null!;
        public virtual ICollection<Album> Albums { get; set; }
        public virtual ICollection<Cmassignrev> Cmassignrevs { get; set; }
        public virtual ICollection<Cmassign> Cmassigns { get; set; }
        public virtual ICollection<Cm> Cms { get; set; }
        public virtual ICollection<Costcodelist> Costcodelists { get; set; }
        public virtual ICollection<Costpgmlist> Costpgmlists { get; set; }
        public virtual ICollection<CuesheetEx> Cuesheetices { get; set; }
        public virtual ICollection<Cuesheet> Cuesheets { get; set; }
        public virtual ICollection<Editing> Editings { get; set; }
        public virtual ICollection<Itemfile> Itemfiles { get; set; }
        public virtual ICollection<MpsAlbumLoan> MpsAlbumLoans { get; set; }
        public virtual ICollection<Program> Programs { get; set; }
        public virtual ICollection<Recprogram> Recprograms { get; set; }
        public virtual ICollection<Schedulebase> Schedulebases { get; set; }
        public virtual ICollection<Scheduleday> Scheduledays { get; set; }
        public virtual ICollection<Songartistcode> Songartistcodes { get; set; }
        public virtual ICollection<Songmusistcode> Songmusistcodes { get; set; }
        public virtual ICollection<Song> Songs { get; set; }
    }
}
