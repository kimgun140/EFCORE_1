using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EFCORE_1.Model
{
    public partial class ModelContext : DbContext
    {
        public ModelContext()
        {
        }

        public ModelContext(DbContextOptions<ModelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AatestTablePk> AatestTablePks { get; set; } = null!;
        public virtual DbSet<Adminactivitylog> Adminactivitylogs { get; set; } = null!;
        public virtual DbSet<Album> Albums { get; set; } = null!;
        public virtual DbSet<Albumtrack> Albumtracks { get; set; } = null!;
        public virtual DbSet<Areainfo> Areainfos { get; set; } = null!;
        public virtual DbSet<Autoupdate> Autoupdates { get; set; } = null!;
        public virtual DbSet<BdReport> BdReports { get; set; } = null!;
        public virtual DbSet<Bookmark> Bookmarks { get; set; } = null!;
        public virtual DbSet<Cm> Cms { get; set; } = null!;
        public virtual DbSet<Cmagency> Cmagencies { get; set; } = null!;
        public virtual DbSet<Cmassign> Cmassigns { get; set; } = null!;
        public virtual DbSet<Cmassignday> Cmassigndays { get; set; } = null!;
        public virtual DbSet<Cmassignrev> Cmassignrevs { get; set; } = null!;
        public virtual DbSet<Cmclient> Cmclients { get; set; } = null!;
        public virtual DbSet<Cmconsent> Cmconsents { get; set; } = null!;
        public virtual DbSet<Cmfailcheck> Cmfailchecks { get; set; } = null!;
        public virtual DbSet<Cmgroup> Cmgroups { get; set; } = null!;
        public virtual DbSet<Cmreport> Cmreports { get; set; } = null!;
        public virtual DbSet<Controlinfo> Controlinfos { get; set; } = null!;
        public virtual DbSet<Costcode> Costcodes { get; set; } = null!;
        public virtual DbSet<Costcodelist> Costcodelists { get; set; } = null!;
        public virtual DbSet<Costpgmlist> Costpgmlists { get; set; } = null!;
        public virtual DbSet<Costprogram> Costprograms { get; set; } = null!;
        public virtual DbSet<Cuedetail> Cuedetails { get; set; } = null!;
        public virtual DbSet<CuedetailEx> Cuedetailices { get; set; } = null!;
        public virtual DbSet<Cuesheet> Cuesheets { get; set; } = null!;
        public virtual DbSet<CuesheetEx> Cuesheetices { get; set; } = null!;
        public virtual DbSet<Defaultconf> Defaultconfs { get; set; } = null!;
        public virtual DbSet<Divisionhigh> Divisionhighs { get; set; } = null!;
        public virtual DbSet<Divisionlow> Divisionlows { get; set; } = null!;
        public virtual DbSet<Editing> Editings { get; set; } = null!;
        public virtual DbSet<EtcInfo> EtcInfos { get; set; } = null!;
        public virtual DbSet<Groupinfo> Groupinfos { get; set; } = null!;
        public virtual DbSet<IdxAlbumTitle> IdxAlbumTitles { get; set; } = null!;
        public virtual DbSet<IdxSongArtist> IdxSongArtists { get; set; } = null!;
        public virtual DbSet<IdxSongKeyword> IdxSongKeywords { get; set; } = null!;
        public virtual DbSet<IdxSongTitle> IdxSongTitles { get; set; } = null!;
        public virtual DbSet<Itemask> Itemasks { get; set; } = null!;
        public virtual DbSet<Itemcodehigh> Itemcodehighs { get; set; } = null!;
        public virtual DbSet<Itemcodelow> Itemcodelows { get; set; } = null!;
        public virtual DbSet<Itemfile> Itemfiles { get; set; } = null!;
        public virtual DbSet<Mediainfo> Mediainfos { get; set; } = null!;
        public virtual DbSet<MpsAlbum> MpsAlbums { get; set; } = null!;
        public virtual DbSet<MpsAlbumArtistMap> MpsAlbumArtistMaps { get; set; } = null!;
        public virtual DbSet<MpsAlbumClassIdx> MpsAlbumClassIdxes { get; set; } = null!;
        public virtual DbSet<MpsAlbumIndex> MpsAlbumIndices { get; set; } = null!;
        public virtual DbSet<MpsAlbumLoan> MpsAlbumLoans { get; set; } = null!;
        public virtual DbSet<MpsArtist> MpsArtists { get; set; } = null!;
        public virtual DbSet<MpsBanKeyword> MpsBanKeywords { get; set; } = null!;
        public virtual DbSet<MpsClass> MpsClasses { get; set; } = null!;
        public virtual DbSet<MpsClassic> MpsClassics { get; set; } = null!;
        public virtual DbSet<MpsCommonCode> MpsCommonCodes { get; set; } = null!;
        public virtual DbSet<MpsIdxAlbumTitleSntc> MpsIdxAlbumTitleSntcs { get; set; } = null!;
        public virtual DbSet<MpsIdxSongArtistSntc> MpsIdxSongArtistSntcs { get; set; } = null!;
        public virtual DbSet<MpsIdxSongInfoSntc> MpsIdxSongInfoSntcs { get; set; } = null!;
        public virtual DbSet<MpsIdxSongInfoWord> MpsIdxSongInfoWords { get; set; } = null!;
        public virtual DbSet<MpsIdxSongLyricsSntc> MpsIdxSongLyricsSntcs { get; set; } = null!;
        public virtual DbSet<MpsIdxSongTagWord> MpsIdxSongTagWords { get; set; } = null!;
        public virtual DbSet<MpsIdxSongTitleSntc> MpsIdxSongTitleSntcs { get; set; } = null!;
        public virtual DbSet<MpsIdxSongTitleWord> MpsIdxSongTitleWords { get; set; } = null!;
        public virtual DbSet<MpsIfLbhRainbow> MpsIfLbhRainbows { get; set; } = null!;
        public virtual DbSet<MpsIfSongRainbow> MpsIfSongRainbows { get; set; } = null!;
        public virtual DbSet<MpsInst> MpsInsts { get; set; } = null!;
        public virtual DbSet<MpsRequestSong> MpsRequestSongs { get; set; } = null!;
        public virtual DbSet<MpsSecureBigCode> MpsSecureBigCodes { get; set; } = null!;
        public virtual DbSet<MpsSecureMidCode> MpsSecureMidCodes { get; set; } = null!;
        public virtual DbSet<MpsSong> MpsSongs { get; set; } = null!;
        public virtual DbSet<MpsSongAddInfo> MpsSongAddInfos { get; set; } = null!;
        public virtual DbSet<MpsSongArtistIdx> MpsSongArtistIdxes { get; set; } = null!;
        public virtual DbSet<MpsSongArtistMap> MpsSongArtistMaps { get; set; } = null!;
        public virtual DbSet<MpsSongClassIdx> MpsSongClassIdxes { get; set; } = null!;
        public virtual DbSet<MpsSongHistory> MpsSongHistories { get; set; } = null!;
        public virtual DbSet<MpsSongIndex> MpsSongIndices { get; set; } = null!;
        public virtual DbSet<MpsSongInfo> MpsSongInfos { get; set; } = null!;
        public virtual DbSet<MpsSongInfoIdx> MpsSongInfoIdxes { get; set; } = null!;
        public virtual DbSet<MpsSongInstMap> MpsSongInstMaps { get; set; } = null!;
        public virtual DbSet<MpsVwRootClass> MpsVwRootClasses { get; set; } = null!;
        public virtual DbSet<MpsVwSong> MpsVwSongs { get; set; } = null!;
        public virtual DbSet<MpsVwSongCore> MpsVwSongCores { get; set; } = null!;
        public virtual DbSet<MpsVwSongHistory> MpsVwSongHistories { get; set; } = null!;
        public virtual DbSet<MpsVwSongSearch> MpsVwSongSearches { get; set; } = null!;
        public virtual DbSet<Notice> Notices { get; set; } = null!;
        public virtual DbSet<Permissionchangelog> Permissionchangelogs { get; set; } = null!;
        public virtual DbSet<Program> Programs { get; set; } = null!;
        public virtual DbSet<Programalias> Programaliases { get; set; } = null!;
        public virtual DbSet<RbtSongForSearchEngine> RbtSongForSearchEngines { get; set; } = null!;
        public virtual DbSet<Recprogram> Recprograms { get; set; } = null!;
        public virtual DbSet<Schebasedetail> Schebasedetails { get; set; } = null!;
        public virtual DbSet<Schedaydetail> Schedaydetails { get; set; } = null!;
        public virtual DbSet<Schedulebase> Schedulebases { get; set; } = null!;
        public virtual DbSet<Scheduleday> Scheduledays { get; set; } = null!;
        public virtual DbSet<Scheduledaycheck> Scheduledaychecks { get; set; } = null!;
        public virtual DbSet<Screeninfo> Screeninfos { get; set; } = null!;
        public virtual DbSet<Song> Songs { get; set; } = null!;
        public virtual DbSet<Songartistcode> Songartistcodes { get; set; } = null!;
        public virtual DbSet<Songbigcode> Songbigcodes { get; set; } = null!;
        public virtual DbSet<Songlog> Songlogs { get; set; } = null!;
        public virtual DbSet<Songmiddcode> Songmiddcodes { get; set; } = null!;
        public virtual DbSet<Songmusistcode> Songmusistcodes { get; set; } = null!;
        public virtual DbSet<Songsmallcode> Songsmallcodes { get; set; } = null!;
        public virtual DbSet<Stationinfo> Stationinfos { get; set; } = null!;
        public virtual DbSet<Synchro> Synchros { get; set; } = null!;
        public virtual DbSet<Taglist> Taglists { get; set; } = null!;
        public virtual DbSet<TempMpsArtist> TempMpsArtists { get; set; } = null!;
        public virtual DbSet<TempMpsClass> TempMpsClasses { get; set; } = null!;
        public virtual DbSet<TempMpsSongArtAndInstMap> TempMpsSongArtAndInstMaps { get; set; } = null!;
        public virtual DbSet<TempMpsSongArtistIdx> TempMpsSongArtistIdxes { get; set; } = null!;
        public virtual DbSet<TempMpsSongArtistMap> TempMpsSongArtistMaps { get; set; } = null!;
        public virtual DbSet<TempMpsSongArtistMinOrder> TempMpsSongArtistMinOrders { get; set; } = null!;
        public virtual DbSet<TempMpsSongInstMap> TempMpsSongInstMaps { get; set; } = null!;
        public virtual DbSet<TempMpsSongInstMapFinal> TempMpsSongInstMapFinals { get; set; } = null!;
        public virtual DbSet<TempSongmusistcode> TempSongmusistcodes { get; set; } = null!;
        public virtual DbSet<Usergroup> Usergroups { get; set; } = null!;
        public virtual DbSet<Userinfo> Userinfos { get; set; } = null!;
        public virtual DbSet<Userprogram> Userprograms { get; set; } = null!;
        public virtual DbSet<Worklog> Worklogs { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseOracle("Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=tcp)(HOST=192.168.1.245)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=oras)));User Id=WINNERS;Password=WINNERS009;", OracleOptions => OracleOptions.UseOracleSQLCompatibility("11"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("WINNERS");

            modelBuilder.Entity<AatestTablePk>(entity =>
            {
                entity.ToTable("AATEST_TABLE_PK");

                entity.Property(e => e.Id)
                    .HasPrecision(10)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATED_DATE")
                    .HasDefaultValueSql("SYSDATE -- 생성일, 기본값은 현재 날짜\n");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION")
                    .HasDefaultValueSql("'No description' ");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Url)
                    .HasColumnType("NCLOB")
                    .HasColumnName("url");
            });

            modelBuilder.Entity<Adminactivitylog>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("ADMINACTIVITYLOG");

                entity.Property(e => e.LogId)
                    .HasPrecision(10)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("LOG_ID");

                entity.Property(e => e.AccessIp)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ACCESS_IP");

                entity.Property(e => e.ActivityDatetime)
                    .HasColumnType("DATE")
                    .HasColumnName("ACTIVITY_DATETIME")
                    .HasDefaultValueSql("CURRENT_DATE ");

                entity.Property(e => e.ActivityDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACTIVITY_DESCRIPTION");

                entity.Property(e => e.ActivityId)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ACTIVITY_ID");

                entity.Property(e => e.AdminId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADMIN_ID");

                entity.Property(e => e.SubjectId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SUBJECT_ID");

                entity.Property(e => e.SubjectName)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SUBJECT_NAME");
            });

            modelBuilder.Entity<Album>(entity =>
            {
                entity.HasKey(e => e.AlbmId)
                    .HasName("SYS_C0053503");

                entity.ToTable("ALBUM");

                entity.Property(e => e.AlbmId)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ALBM_ID");

                entity.Property(e => e.AlbmArea)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ALBM_AREA")
                    .IsFixedLength();

                entity.Property(e => e.AlbmArgdate)
                    .HasColumnType("DATE")
                    .HasColumnName("ALBM_ARGDATE");

                entity.Property(e => e.AlbmArtist)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ALBM_ARTIST");

                entity.Property(e => e.AlbmAskno)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ALBM_ASKNO")
                    .IsFixedLength();

                entity.Property(e => e.AlbmBarcode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ALBM_BARCODE");

                entity.Property(e => e.AlbmCopy)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ALBM_COPY");

                entity.Property(e => e.AlbmDistributor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ALBM_DISTRIBUTOR");

                entity.Property(e => e.AlbmDusdate)
                    .HasColumnType("DATE")
                    .HasColumnName("ALBM_DUSDATE");

                entity.Property(e => e.AlbmDuse)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ALBM_DUSE")
                    .IsFixedLength();

                entity.Property(e => e.AlbmDusememo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ALBM_DUSEMEMO");

                entity.Property(e => e.AlbmFom)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ALBM_FOM")
                    .IsFixedLength();

                entity.Property(e => e.AlbmGrpno)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ALBM_GRPNO")
                    .IsFixedLength();

                entity.Property(e => e.AlbmImgpath)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ALBM_IMGPATH");

                entity.Property(e => e.AlbmInputdiv)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ALBM_INPUTDIV")
                    .IsFixedLength();

                entity.Property(e => e.AlbmLang)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("ALBM_LANG");

                entity.Property(e => e.AlbmLend)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ALBM_LEND")
                    .IsFixedLength();

                entity.Property(e => e.AlbmLendpre)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ALBM_LENDPRE")
                    .IsFixedLength();

                entity.Property(e => e.AlbmLendpredat)
                    .HasColumnType("DATE")
                    .HasColumnName("ALBM_LENDPREDAT");

                entity.Property(e => e.AlbmLenduser)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ALBM_LENDUSER");

                entity.Property(e => e.AlbmMemo)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("ALBM_MEMO");

                entity.Property(e => e.AlbmPrdco)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ALBM_PRDCO");

                entity.Property(e => e.AlbmPrdno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ALBM_PRDNO");

                entity.Property(e => e.AlbmRegdate)
                    .HasColumnType("DATE")
                    .HasColumnName("ALBM_REGDATE");

                entity.Property(e => e.AlbmSale)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ALBM_SALE")
                    .IsFixedLength();

                entity.Property(e => e.AlbmSavepic)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ALBM_SAVEPIC")
                    .IsFixedLength();

                entity.Property(e => e.AlbmSbigid)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ALBM_SBIGID")
                    .IsFixedLength();

                entity.Property(e => e.AlbmSmidid)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ALBM_SMIDID")
                    .IsFixedLength();

                entity.Property(e => e.AlbmTitle1)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ALBM_TITLE1");

                entity.Property(e => e.AlbmTitle2)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ALBM_TITLE2");

                entity.Property(e => e.AlbmTitle3)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ALBM_TITLE3");

                entity.Property(e => e.AlbmTitle4)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ALBM_TITLE4");

                entity.Property(e => e.AlbmTypeno)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ALBM_TYPENO")
                    .IsFixedLength();

                entity.Property(e => e.AlbmUsed)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ALBM_USED")
                    .IsFixedLength();

                entity.Property(e => e.AlbmUsernum)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ALBM_USERNUM");

                entity.Property(e => e.AlbumThumbpathCbs)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ALBUM_THUMBPATH_CBS");

                entity.HasOne(d => d.AlbmSbig)
                    .WithMany(p => p.Albums)
                    .HasForeignKey(d => d.AlbmSbigid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C0053972");

                entity.HasOne(d => d.AlbmUsernumNavigation)
                    .WithMany(p => p.Albums)
                    .HasForeignKey(d => d.AlbmUsernum)
                    .HasConstraintName("SYS_C0053996");
            });

            modelBuilder.Entity<Albumtrack>(entity =>
            {
                entity.HasKey(e => new { e.AbtrAlbmid, e.AbtrTrack })
                    .HasName("SYS_C0053506");

                entity.ToTable("ALBUMTRACK");

                entity.Property(e => e.AbtrAlbmid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ABTR_ALBMID");

                entity.Property(e => e.AbtrTrack)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ABTR_TRACK");

                entity.Property(e => e.AbtrArtist)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ABTR_ARTIST");

                entity.Property(e => e.AbtrRuntime)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("ABTR_RUNTIME")
                    .IsFixedLength();

                entity.Property(e => e.AbtrSongid)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("ABTR_SONGID")
                    .IsFixedLength();

                entity.Property(e => e.AbtrSongtitle)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ABTR_SONGTITLE");

                entity.Property(e => e.AbtrTitlesong)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ABTR_TITLESONG")
                    .IsFixedLength();

                entity.HasOne(d => d.AbtrAlbm)
                    .WithMany(p => p.Albumtracks)
                    .HasForeignKey(d => d.AbtrAlbmid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C0053886");

                entity.HasOne(d => d.AbtrSong)
                    .WithMany(p => p.Albumtracks)
                    .HasForeignKey(d => d.AbtrSongid)
                    .HasConstraintName("SYS_C0053969");
            });

            modelBuilder.Entity<Areainfo>(entity =>
            {
                entity.HasKey(e => e.AreaId)
                    .HasName("SYS_C0053509");

                entity.ToTable("AREAINFO");

                entity.Property(e => e.AreaId)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("AREA_ID")
                    .IsFixedLength();

                entity.Property(e => e.AreaName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AREA_NAME");

                entity.Property(e => e.AreaOrder)
                    .HasColumnType("NUMBER")
                    .HasColumnName("AREA_ORDER");
            });

            modelBuilder.Entity<Autoupdate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AUTOUPDATE");

                entity.Property(e => e.AtudVersion)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("ATUD_VERSION");
            });

            modelBuilder.Entity<BdReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BD_REPORT");

                entity.Property(e => e.JournalistId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("JOURNALIST_ID");

                entity.Property(e => e.NewsCd)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("NEWS_CD");

                entity.Property(e => e.RecDatetime)
                    .HasColumnType("DATE")
                    .HasColumnName("REC_DATETIME");

                entity.Property(e => e.ReportFilepath)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("REPORT_FILEPATH");

                entity.Property(e => e.ReportFiletype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REPORT_FILETYPE");

                entity.Property(e => e.ReportLength)
                    .HasColumnType("NUMBER")
                    .HasColumnName("REPORT_LENGTH");

                entity.Property(e => e.Reportname)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("REPORTNAME");
            });

            modelBuilder.Entity<Bookmark>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BOOKMARK");

                entity.Property(e => e.BkmkFileid)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("BKMK_FILEID");

                entity.Property(e => e.BkmkFiletype)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("BKMK_FILETYPE")
                    .IsFixedLength();

                entity.Property(e => e.BkmkUsernum)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("BKMK_USERNUM");

                entity.HasOne(d => d.BkmkUsernumNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.BkmkUsernum)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C0053995");
            });

            modelBuilder.Entity<Cm>(entity =>
            {
                entity.ToTable("CM");

                entity.Property(e => e.CmId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("CM_ID")
                    .IsFixedLength();

                entity.Property(e => e.CmAgencyname)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CM_AGENCYNAME");

                entity.Property(e => e.CmClientname)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CM_CLIENTNAME");

                entity.Property(e => e.CmClipid)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CM_CLIPID");

                entity.Property(e => e.CmCmagid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CM_CMAGID");

                entity.Property(e => e.CmCmclid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CM_CMCLID");

                entity.Property(e => e.CmCmcsid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CM_CMCSID");

                entity.Property(e => e.CmConsentname)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CM_CONSENTNAME");

                entity.Property(e => e.CmDiscusnum)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CM_DISCUSNUM");

                entity.Property(e => e.CmDuration)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CM_DURATION")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.CmFilename)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CM_FILENAME");

                entity.Property(e => e.CmFilepath)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("CM_FILEPATH");

                entity.Property(e => e.CmItchid)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CM_ITCHID")
                    .IsFixedLength();

                entity.Property(e => e.CmItclid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CM_ITCLID");

                entity.Property(e => e.CmLimit)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CM_LIMIT")
                    .IsFixedLength();

                entity.Property(e => e.CmMedia)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CM_MEDIA")
                    .IsFixedLength();

                entity.Property(e => e.CmMemo)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("CM_MEMO");

                entity.Property(e => e.CmRegdate)
                    .HasColumnType("DATE")
                    .HasColumnName("CM_REGDATE");

                entity.Property(e => e.CmReturndate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CM_RETURNDATE")
                    .IsFixedLength();

                entity.Property(e => e.CmRuntime)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("CM_RUNTIME")
                    .IsFixedLength();

                entity.Property(e => e.CmTitle)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CM_TITLE");

                entity.Property(e => e.CmUsed)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CM_USED")
                    .IsFixedLength();

                entity.Property(e => e.CmUsernum)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CM_USERNUM");

                entity.Property(e => e.CmViewtitle)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CM_VIEWTITLE");

                entity.Property(e => e.CmVruntime)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CM_VRUNTIME");

                entity.HasOne(d => d.CmCmag)
                    .WithMany(p => p.Cms)
                    .HasForeignKey(d => d.CmCmagid)
                    .HasConstraintName("SYS_C0053897");

                entity.HasOne(d => d.CmCmcl)
                    .WithMany(p => p.Cms)
                    .HasForeignKey(d => d.CmCmclid)
                    .HasConstraintName("SYS_C0053899");

                entity.HasOne(d => d.CmCmcs)
                    .WithMany(p => p.Cms)
                    .HasForeignKey(d => d.CmCmcsid)
                    .HasConstraintName("SYS_C0053900");

                entity.HasOne(d => d.CmItch)
                    .WithMany(p => p.Cms)
                    .HasForeignKey(d => d.CmItchid)
                    .HasConstraintName("SYS_C0053916");

                entity.HasOne(d => d.CmUsernumNavigation)
                    .WithMany(p => p.Cms)
                    .HasForeignKey(d => d.CmUsernum)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C0053994");
            });

            modelBuilder.Entity<Cmagency>(entity =>
            {
                entity.HasKey(e => e.CmagId)
                    .HasName("SYS_C0053528");

                entity.ToTable("CMAGENCY");

                entity.Property(e => e.CmagId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CMAG_ID");

                entity.Property(e => e.CmagCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CMAG_CODE");

                entity.Property(e => e.CmagName)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CMAG_NAME");

                entity.Property(e => e.CmagUsed)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CMAG_USED")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Cmassign>(entity =>
            {
                entity.HasKey(e => e.CmasnIndex)
                    .HasName("SYS_C0053544");

                entity.ToTable("CMASSIGN");

                entity.Property(e => e.CmasnIndex)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CMASN_INDEX");

                entity.Property(e => e.CmasnAgencyid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CMASN_AGENCYID");

                entity.Property(e => e.CmasnClientid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CMASN_CLIENTID");

                entity.Property(e => e.CmasnCmgrid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CMASN_CMGRID");

                entity.Property(e => e.CmasnCmid)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("CMASN_CMID")
                    .IsFixedLength();

                entity.Property(e => e.CmasnConsid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CMASN_CONSID");

                entity.Property(e => e.CmasnCostsec)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CMASN_COSTSEC");

                entity.Property(e => e.CmasnEdate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CMASN_EDATE");

                entity.Property(e => e.CmasnMemo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("CMASN_MEMO");

                entity.Property(e => e.CmasnNum)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CMASN_NUM");

                entity.Property(e => e.CmasnPgmtype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CMASN_PGMTYPE")
                    .IsFixedLength();

                entity.Property(e => e.CmasnPrgmareaid)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CMASN_PRGMAREAID")
                    .IsFixedLength();

                entity.Property(e => e.CmasnPrgmid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CMASN_PRGMID");

                entity.Property(e => e.CmasnPrgmmedaid)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CMASN_PRGMMEDAID")
                    .IsFixedLength();

                entity.Property(e => e.CmasnPrgmprtid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CMASN_PRGMPRTID");

                entity.Property(e => e.CmasnRegdate)
                    .HasColumnType("DATE")
                    .HasColumnName("CMASN_REGDATE");

                entity.Property(e => e.CmasnSdate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CMASN_SDATE");

                entity.Property(e => e.CmasnSubnum)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CMASN_SUBNUM");

                entity.Property(e => e.CmasnTitle)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CMASN_TITLE");

                entity.Property(e => e.CmasnUsernum)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CMASN_USERNUM");

                entity.Property(e => e.CmasnViewtitle)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CMASN_VIEWTITLE");

                entity.HasOne(d => d.CmasnCmgr)
                    .WithMany(p => p.Cmassigns)
                    .HasForeignKey(d => d.CmasnCmgrid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C0053903");

                entity.HasOne(d => d.CmasnCm)
                    .WithMany(p => p.Cmassigns)
                    .HasForeignKey(d => d.CmasnCmid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C0053896");

                entity.HasOne(d => d.CmasnUsernumNavigation)
                    .WithMany(p => p.Cmassigns)
                    .HasForeignKey(d => d.CmasnUsernum)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C0053993");

                entity.HasOne(d => d.CmasnPrgm)
                    .WithMany(p => p.Cmassigns)
                    .HasForeignKey(d => new { d.CmasnPrgmareaid, d.CmasnPrgmmedaid, d.CmasnPrgmid })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C0053964");
            });

            modelBuilder.Entity<Cmassignday>(entity =>
            {
                entity.HasKey(e => new { e.CmasnBrddate, e.CmasnIndex })
                    .HasName("SYS_C0053547");

                entity.ToTable("CMASSIGNDAY");

                entity.Property(e => e.CmasnBrddate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CMASN_BRDDATE")
                    .IsFixedLength();

                entity.Property(e => e.CmasnIndex)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CMASN_INDEX");

                entity.Property(e => e.CmasnAgencyid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CMASN_AGENCYID");

                entity.Property(e => e.CmasnClientid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CMASN_CLIENTID");

                entity.Property(e => e.CmasnCmgrid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CMASN_CMGRID");

                entity.Property(e => e.CmasnCmid)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("CMASN_CMID")
                    .IsFixedLength();

                entity.Property(e => e.CmasnConsid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CMASN_CONSID");

                entity.Property(e => e.CmasnCostsec)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CMASN_COSTSEC");

                entity.Property(e => e.CmasnEdate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CMASN_EDATE");

                entity.Property(e => e.CmasnMemo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("CMASN_MEMO");

                entity.Property(e => e.CmasnNum)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CMASN_NUM");

                entity.Property(e => e.CmasnOnairchk)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CMASN_ONAIRCHK")
                    .IsFixedLength();

                entity.Property(e => e.CmasnPgmtype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CMASN_PGMTYPE")
                    .IsFixedLength();

                entity.Property(e => e.CmasnPrgmareaid)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CMASN_PRGMAREAID")
                    .IsFixedLength();

                entity.Property(e => e.CmasnPrgmid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CMASN_PRGMID");

                entity.Property(e => e.CmasnPrgmmedaid)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CMASN_PRGMMEDAID")
                    .IsFixedLength();

                entity.Property(e => e.CmasnPrgmprtid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CMASN_PRGMPRTID");

                entity.Property(e => e.CmasnRegdate)
                    .HasColumnType("DATE")
                    .HasColumnName("CMASN_REGDATE");

                entity.Property(e => e.CmasnSdate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CMASN_SDATE");

                entity.Property(e => e.CmasnSubnum)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CMASN_SUBNUM");

                entity.Property(e => e.CmasnTitle)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CMASN_TITLE");

                entity.Property(e => e.CmasnUsernum)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CMASN_USERNUM");

                entity.Property(e => e.CmasnViewtitle)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CMASN_VIEWTITLE");
            });

            modelBuilder.Entity<Cmassignrev>(entity =>
            {
                entity.HasKey(e => new { e.CmasnRevIndex, e.CmasnIndex })
                    .HasName("SYS_C0053564");

                entity.ToTable("CMASSIGNREV");

                entity.Property(e => e.CmasnRevIndex)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CMASN_REV_INDEX");

                entity.Property(e => e.CmasnIndex)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CMASN_INDEX");

                entity.Property(e => e.CmasnAgencyid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CMASN_AGENCYID");

                entity.Property(e => e.CmasnClientid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CMASN_CLIENTID");

                entity.Property(e => e.CmasnCmgrid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CMASN_CMGRID");

                entity.Property(e => e.CmasnCmid)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("CMASN_CMID")
                    .IsFixedLength();

                entity.Property(e => e.CmasnConsid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CMASN_CONSID");

                entity.Property(e => e.CmasnCostsec)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CMASN_COSTSEC");

                entity.Property(e => e.CmasnEdate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CMASN_EDATE");

                entity.Property(e => e.CmasnMemo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("CMASN_MEMO");

                entity.Property(e => e.CmasnNum)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CMASN_NUM");

                entity.Property(e => e.CmasnPgmtype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CMASN_PGMTYPE")
                    .IsFixedLength();

                entity.Property(e => e.CmasnPrgmareaid)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CMASN_PRGMAREAID")
                    .IsFixedLength();

                entity.Property(e => e.CmasnPrgmid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CMASN_PRGMID");

                entity.Property(e => e.CmasnPrgmmedaid)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CMASN_PRGMMEDAID")
                    .IsFixedLength();

                entity.Property(e => e.CmasnPrgmprtid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CMASN_PRGMPRTID");

                entity.Property(e => e.CmasnRegdate)
                    .HasColumnType("DATE")
                    .HasColumnName("CMASN_REGDATE");

                entity.Property(e => e.CmasnSdate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CMASN_SDATE");

                entity.Property(e => e.CmasnSubnum)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CMASN_SUBNUM");

                entity.Property(e => e.CmasnTitle)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CMASN_TITLE");

                entity.Property(e => e.CmasnUsernum)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CMASN_USERNUM");

                entity.Property(e => e.CmasnViewtitle)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CMASN_VIEWTITLE");

                entity.HasOne(d => d.CmasnCmgr)
                    .WithMany(p => p.Cmassignrevs)
                    .HasForeignKey(d => d.CmasnCmgrid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C0053901");

                entity.HasOne(d => d.CmasnCm)
                    .WithMany(p => p.Cmassignrevs)
                    .HasForeignKey(d => d.CmasnCmid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C0053894");

                entity.HasOne(d => d.CmasnUsernumNavigation)
                    .WithMany(p => p.Cmassignrevs)
                    .HasForeignKey(d => d.CmasnUsernum)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C0053979");

                entity.HasOne(d => d.CmasnPrgm)
                    .WithMany(p => p.Cmassignrevs)
                    .HasForeignKey(d => new { d.CmasnPrgmareaid, d.CmasnPrgmmedaid, d.CmasnPrgmid })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C0053960");
            });

            modelBuilder.Entity<Cmclient>(entity =>
            {
                entity.HasKey(e => e.CmclId)
                    .HasName("SYS_C0053568");

                entity.ToTable("CMCLIENT");

                entity.Property(e => e.CmclId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CMCL_ID");

                entity.Property(e => e.CmclName)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CMCL_NAME");

                entity.Property(e => e.CmclUsed)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CMCL_USED")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Cmconsent>(entity =>
            {
                entity.HasKey(e => e.CmcsId)
                    .HasName("SYS_C0053572");

                entity.ToTable("CMCONSENT");

                entity.Property(e => e.CmcsId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CMCS_ID");

                entity.Property(e => e.CmcsName)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CMCS_NAME");

                entity.Property(e => e.CmcsUsed)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CMCS_USED")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Cmfailcheck>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CMFAILCHECK");

                entity.Property(e => e.CmfcCmid)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("CMFC_CMID")
                    .IsFixedLength();

                entity.Property(e => e.CmfcFaildate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CMFC_FAILDATE");

                entity.Property(e => e.CmfcIndex)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CMFC_INDEX");

                entity.Property(e => e.CmfcMemo)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CMFC_MEMO");

                entity.Property(e => e.CmfcPrgmid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CMFC_PRGMID");

                entity.Property(e => e.CmfcRegdate)
                    .HasColumnType("DATE")
                    .HasColumnName("CMFC_REGDATE");

                entity.Property(e => e.CmfcUsernum)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CMFC_USERNUM");

                entity.HasOne(d => d.CmfcCm)
                    .WithMany()
                    .HasForeignKey(d => d.CmfcCmid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C0053895");

                entity.HasOne(d => d.CmfcIndexNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.CmfcIndex)
                    .HasConstraintName("SYS_C0053898");

                entity.HasOne(d => d.CmfcUsernumNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.CmfcUsernum)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C0053992");
            });

            modelBuilder.Entity<Cmgroup>(entity =>
            {
                entity.HasKey(e => e.CmgrId)
                    .HasName("SYS_C0053579");

                entity.ToTable("CMGROUP");

                entity.Property(e => e.CmgrId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CMGR_ID");

                entity.Property(e => e.CmgrName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CMGR_NAME");
            });

            modelBuilder.Entity<Cmreport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CMREPORT");

                entity.Property(e => e.CmroAgencyname)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CMRO_AGENCYNAME");

                entity.Property(e => e.CmroAsnedate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CMRO_ASNEDATE");

                entity.Property(e => e.CmroAsnsdate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CMRO_ASNSDATE");

                entity.Property(e => e.CmroBasesec)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CMRO_BASESEC");

                entity.Property(e => e.CmroBrddate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CMRO_BRDDATE")
                    .IsFixedLength();

                entity.Property(e => e.CmroBrdtime)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CMRO_BRDTIME")
                    .IsFixedLength();

                entity.Property(e => e.CmroClientname)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CMRO_CLIENTNAME");

                entity.Property(e => e.CmroCmasnindex)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CMRO_CMASNINDEX");

                entity.Property(e => e.CmroCmid)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("CMRO_CMID")
                    .IsFixedLength();

                entity.Property(e => e.CmroCmtitle)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CMRO_CMTITLE");

                entity.Property(e => e.CmroCostkey)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CMRO_COSTKEY")
                    .IsFixedLength();

                entity.Property(e => e.CmroCostsec)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CMRO_COSTSEC");

                entity.Property(e => e.CmroCostvalue)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CMRO_COSTVALUE");

                entity.Property(e => e.CmroMedaid)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CMRO_MEDAID")
                    .IsFixedLength();

                entity.Property(e => e.CmroMedaidname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CMRO_MEDAIDNAME");

                entity.Property(e => e.CmroOnair)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CMRO_ONAIR");

                entity.Property(e => e.CmroPrgmid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CMRO_PRGMID");

                entity.Property(e => e.CmroPrgmtitle)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CMRO_PRGMTITLE");

                entity.Property(e => e.CmroPrgmtype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CMRO_PRGMTYPE")
                    .IsFixedLength();

                entity.Property(e => e.CmroRegdate)
                    .HasColumnType("DATE")
                    .HasColumnName("CMRO_REGDATE");

                entity.Property(e => e.CmroWeekkor)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CMRO_WEEKKOR");

                entity.Property(e => e.CmroWeeknum)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("CMRO_WEEKNUM")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Controlinfo>(entity =>
            {
                entity.HasKey(e => e.CtrlId)
                    .HasName("SYS_C0053582");

                entity.ToTable("CONTROLINFO");

                entity.Property(e => e.CtrlId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CTRL_ID");

                entity.Property(e => e.CtrlFilech)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CTRL_FILECH");

                entity.Property(e => e.CtrlLivech)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CTRL_LIVECH");

                entity.Property(e => e.CtrlMedia)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CTRL_MEDIA")
                    .IsFixedLength();

                entity.Property(e => e.CtrlName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CTRL_NAME");

                entity.Property(e => e.CtrlNo)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CTRL_NO");

                entity.Property(e => e.CtrlOrder)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CTRL_ORDER");
            });

            modelBuilder.Entity<Costcode>(entity =>
            {
                entity.HasKey(e => new { e.CocdCopldate, e.CocdType, e.CocdSec, e.CocdCostkey, e.CocdCoplmedaid })
                    .HasName("SYS_C0053589");

                entity.ToTable("COSTCODE");

                entity.Property(e => e.CocdCopldate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("COCD_COPLDATE")
                    .IsFixedLength();

                entity.Property(e => e.CocdType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("COCD_TYPE")
                    .IsFixedLength();

                entity.Property(e => e.CocdSec)
                    .HasColumnType("NUMBER")
                    .HasColumnName("COCD_SEC");

                entity.Property(e => e.CocdCostkey)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("COCD_COSTKEY")
                    .IsFixedLength();

                entity.Property(e => e.CocdCoplmedaid)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("COCD_COPLMEDAID")
                    .IsFixedLength();

                entity.Property(e => e.CocdCost)
                    .HasColumnType("NUMBER")
                    .HasColumnName("COCD_COST");

                entity.HasOne(d => d.CocdCopldateNavigation)
                    .WithMany(p => p.Costcodes)
                    .HasForeignKey(d => d.CocdCopldate)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C0053907");
            });

            modelBuilder.Entity<Costcodelist>(entity =>
            {
                entity.HasKey(e => new { e.CoclDate, e.CoclMedaid })
                    .HasName("SYS_C0053595");

                entity.ToTable("COSTCODELIST");

                entity.Property(e => e.CoclDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("COCL_DATE")
                    .IsFixedLength();

                entity.Property(e => e.CoclMedaid)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("COCL_MEDAID")
                    .IsFixedLength();

                entity.Property(e => e.CoclRegdate)
                    .HasColumnType("DATE")
                    .HasColumnName("COCL_REGDATE");

                entity.Property(e => e.CoclTitle)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("COCL_TITLE");

                entity.Property(e => e.CoclUsernum)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("COCL_USERNUM");

                entity.HasOne(d => d.CoclMeda)
                    .WithMany(p => p.Costcodelists)
                    .HasForeignKey(d => d.CoclMedaid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C0053924");

                entity.HasOne(d => d.CoclUsernumNavigation)
                    .WithMany(p => p.Costcodelists)
                    .HasForeignKey(d => d.CoclUsernum)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C0053991");
            });

            modelBuilder.Entity<Costpgmlist>(entity =>
            {
                entity.HasKey(e => e.CoplDate)
                    .HasName("SYS_C0053600");

                entity.ToTable("COSTPGMLIST");

                entity.Property(e => e.CoplDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("COPL_DATE")
                    .IsFixedLength();

                entity.Property(e => e.CoplMedaid)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("COPL_MEDAID")
                    .IsFixedLength();

                entity.Property(e => e.CoplRegdate)
                    .HasColumnType("DATE")
                    .HasColumnName("COPL_REGDATE");

                entity.Property(e => e.CoplTitle)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("COPL_TITLE");

                entity.Property(e => e.CoplUsernum)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("COPL_USERNUM");

                entity.HasOne(d => d.CoplUsernumNavigation)
                    .WithMany(p => p.Costpgmlists)
                    .HasForeignKey(d => d.CoplUsernum)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C0053990");
            });

            modelBuilder.Entity<Costprogram>(entity =>
            {
                entity.HasKey(e => new { e.CopgCopldate, e.CopgPrgmareaid, e.CopgPrgmid, e.CopgType, e.CopgSec, e.CopgCoplmedaid })
                    .HasName("SYS_C0053609");

                entity.ToTable("COSTPROGRAM");

                entity.Property(e => e.CopgCopldate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("COPG_COPLDATE")
                    .IsFixedLength();

                entity.Property(e => e.CopgPrgmareaid)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("COPG_PRGMAREAID")
                    .IsFixedLength();

                entity.Property(e => e.CopgPrgmid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("COPG_PRGMID");

                entity.Property(e => e.CopgType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("COPG_TYPE")
                    .IsFixedLength();

                entity.Property(e => e.CopgSec)
                    .HasColumnType("NUMBER")
                    .HasColumnName("COPG_SEC");

                entity.Property(e => e.CopgCoplmedaid)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("COPG_COPLMEDAID")
                    .IsFixedLength();

                entity.Property(e => e.CopgCost)
                    .HasColumnType("NUMBER")
                    .HasColumnName("COPG_COST");

                entity.Property(e => e.CopgCostkey)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("COPG_COSTKEY")
                    .IsFixedLength();

                entity.HasOne(d => d.Copg)
                    .WithMany(p => p.Costprograms)
                    .HasForeignKey(d => new { d.CopgPrgmareaid, d.CopgCoplmedaid, d.CopgPrgmid })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C0053963");
            });

            modelBuilder.Entity<Cuedetail>(entity =>
            {
                entity.HasKey(e => new { e.CsdtCustseq, e.CsdtType, e.CsdtNo })
                    .HasName("SYS_C0053620");

                entity.ToTable("CUEDETAIL");

                entity.Property(e => e.CsdtCustseq)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CSDT_CUSTSEQ");

                entity.Property(e => e.CsdtType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CSDT_TYPE")
                    .IsFixedLength();

                entity.Property(e => e.CsdtNo)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CSDT_NO");

                entity.Property(e => e.CsdtBrddate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CSDT_BRDDATE")
                    .IsFixedLength();

                entity.Property(e => e.CsdtBrdtime)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CSDT_BRDTIME")
                    .IsFixedLength();

                entity.Property(e => e.CsdtCmgrid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CSDT_CMGRID");

                entity.Property(e => e.CsdtCustareaid)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CSDT_CUSTAREAID")
                    .IsFixedLength();

                entity.Property(e => e.CsdtCustmedaid)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CSDT_CUSTMEDAID")
                    .IsFixedLength();

                entity.Property(e => e.CsdtCustprgmid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CSDT_CUSTPRGMID");

                entity.Property(e => e.CsdtEdit)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CSDT_EDIT")
                    .IsFixedLength();

                entity.Property(e => e.CsdtEndtype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CSDT_ENDTYPE")
                    .IsFixedLength();

                entity.Property(e => e.CsdtEpos)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("CSDT_EPOS")
                    .IsFixedLength();

                entity.Property(e => e.CsdtFadein)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CSDT_FADEIN");

                entity.Property(e => e.CsdtFadeout)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CSDT_FADEOUT");

                entity.Property(e => e.CsdtFilename)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CSDT_FILENAME");

                entity.Property(e => e.CsdtFilepath)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("CSDT_FILEPATH");

                entity.Property(e => e.CsdtItemid)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("CSDT_ITEMID")
                    .IsFixedLength();

                entity.Property(e => e.CsdtItemtype)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CSDT_ITEMTYPE")
                    .IsFixedLength();

                entity.Property(e => e.CsdtPgmparentid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CSDT_PGMPARENTID");

                entity.Property(e => e.CsdtRuntime)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("CSDT_RUNTIME")
                    .IsFixedLength();

                entity.Property(e => e.CsdtSpos)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("CSDT_SPOS")
                    .IsFixedLength();

                entity.Property(e => e.CsdtSubtitle)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("CSDT_SUBTITLE");

                entity.Property(e => e.CsdtTimed)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CSDT_TIMED")
                    .IsFixedLength();

                entity.Property(e => e.CsdtTitle)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("CSDT_TITLE");

                entity.Property(e => e.CsdtTrtype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CSDT_TRTYPE")
                    .IsFixedLength();

                entity.Property(e => e.CsdtWeek)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CSDT_WEEK")
                    .IsFixedLength();

                entity.HasOne(d => d.CsdtCmgr)
                    .WithMany(p => p.Cuedetails)
                    .HasForeignKey(d => d.CsdtCmgrid)
                    .HasConstraintName("SYS_C0053902");
            });

            modelBuilder.Entity<CuedetailEx>(entity =>
            {
                entity.HasKey(e => new { e.CueCuesheetId, e.CueCartNo, e.CueCartOrder })
                    .HasName("SYS_C0053629");

                entity.ToTable("CUEDETAIL_EX");

                entity.Property(e => e.CueCuesheetId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CUE_CUESHEET_ID");

                entity.Property(e => e.CueCartNo)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CUE_CART_NO");

                entity.Property(e => e.CueCartOrder)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CUE_CART_ORDER");

                entity.Property(e => e.CueChainmode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CUE_CHAINMODE")
                    .IsFixedLength();

                entity.Property(e => e.CueChainreturntrackno)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CUE_CHAINRETURNTRACKNO")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CueCmgroupid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CUE_CMGROUPID")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CueEdited)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CUE_EDITED")
                    .IsFixedLength();

                entity.Property(e => e.CueEom)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CUE_EOM")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CueFademode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CUE_FADEMODE")
                    .IsFixedLength();

                entity.Property(e => e.CueItemid)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("CUE_ITEMID");

                entity.Property(e => e.CueItemtype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CUE_ITEMTYPE")
                    .IsFixedLength();

                entity.Property(e => e.CueProgramid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CUE_PROGRAMID")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CueSom)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CUE_SOM")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CueTrackno)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CUE_TRACKNO")
                    .HasDefaultValueSql("NULL");

                entity.HasOne(d => d.CueCuesheet)
                    .WithMany(p => p.Cuedetailices)
                    .HasForeignKey(d => d.CueCuesheetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C0053908");
            });

            modelBuilder.Entity<Cuesheet>(entity =>
            {
                entity.HasKey(e => new { e.CustSeq, e.CustPrgmareaid, e.CustPrgmmedaid, e.CustPrgmid })
                    .HasName("SYS_C0053636");

                entity.ToTable("CUESHEET");

                entity.Property(e => e.CustSeq)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CUST_SEQ");

                entity.Property(e => e.CustPrgmareaid)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CUST_PRGMAREAID")
                    .IsFixedLength();

                entity.Property(e => e.CustPrgmmedaid)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CUST_PRGMMEDAID")
                    .IsFixedLength();

                entity.Property(e => e.CustPrgmid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CUST_PRGMID");

                entity.Property(e => e.CustBrddate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CUST_BRDDATE")
                    .IsFixedLength();

                entity.Property(e => e.CustPrgmparentid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CUST_PRGMPARENTID");

                entity.Property(e => e.CustRegdate)
                    .HasColumnType("DATE")
                    .HasColumnName("CUST_REGDATE");

                entity.Property(e => e.CustUsernum)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CUST_USERNUM");

                entity.Property(e => e.CustWeek)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CUST_WEEK")
                    .IsFixedLength();

                entity.HasOne(d => d.CustUsernumNavigation)
                    .WithMany(p => p.Cuesheets)
                    .HasForeignKey(d => d.CustUsernum)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C0053989");

                entity.HasOne(d => d.CustPrgm)
                    .WithMany(p => p.Cuesheets)
                    .HasForeignKey(d => new { d.CustPrgmareaid, d.CustPrgmmedaid, d.CustPrgmid })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C0053962");
            });

            modelBuilder.Entity<CuesheetEx>(entity =>
            {
                entity.HasKey(e => e.CuesheetId)
                    .HasName("SYS_C0053639");

                entity.ToTable("CUESHEET_EX");

                entity.Property(e => e.CuesheetId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CUESHEET_ID");

                entity.Property(e => e.CuesheetMemo)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CUESHEET_MEMO");

                entity.Property(e => e.CuesheetSavedate)
                    .HasColumnType("DATE")
                    .HasColumnName("CUESHEET_SAVEDATE");

                entity.Property(e => e.CuesheetTitle)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CUESHEET_TITLE");

                entity.Property(e => e.CuesheetUsernum)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CUESHEET_USERNUM");

                entity.HasOne(d => d.CuesheetUsernumNavigation)
                    .WithMany(p => p.Cuesheetices)
                    .HasForeignKey(d => d.CuesheetUsernum)
                    .HasConstraintName("SYS_C0053988");
            });

            modelBuilder.Entity<Defaultconf>(entity =>
            {
                entity.HasKey(e => e.DftcCode)
                    .HasName("SYS_C0053642");

                entity.ToTable("DEFAULTCONF");

                entity.Property(e => e.DftcCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("DFTC_CODE")
                    .IsFixedLength();

                entity.Property(e => e.DftcMemo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DFTC_MEMO");

                entity.Property(e => e.DftcName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DFTC_NAME");

                entity.Property(e => e.DftcValue)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DFTC_VALUE");
            });

            modelBuilder.Entity<Divisionhigh>(entity =>
            {
                entity.HasKey(e => e.DvshId)
                    .HasName("SYS_C0053645");

                entity.ToTable("DIVISIONHIGH");

                entity.Property(e => e.DvshId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("DVSH_ID")
                    .IsFixedLength();

                entity.Property(e => e.DvshName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DVSH_NAME");

                entity.Property(e => e.DvshOrder)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DVSH_ORDER");
            });

            modelBuilder.Entity<Divisionlow>(entity =>
            {
                entity.HasKey(e => e.DvslId)
                    .HasName("SYS_C0053649");

                entity.ToTable("DIVISIONLOW");

                entity.Property(e => e.DvslId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("DVSL_ID")
                    .IsFixedLength();

                entity.Property(e => e.DvslDvshid)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("DVSL_DVSHID")
                    .IsFixedLength();

                entity.Property(e => e.DvslName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DVSL_NAME");

                entity.Property(e => e.DvslOrder)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DVSL_ORDER");

                entity.HasOne(d => d.DvslDvsh)
                    .WithMany(p => p.Divisionlows)
                    .HasForeignKey(d => d.DvslDvshid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C0053910");
            });

            modelBuilder.Entity<Editing>(entity =>
            {
                entity.HasKey(e => e.EditFileid)
                    .HasName("SYS_C0053655");

                entity.ToTable("EDITING");

                entity.Property(e => e.EditFileid)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_FILEID")
                    .IsFixedLength();

                entity.Property(e => e.EditAudiomode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_AUDIOMODE")
                    .IsFixedLength();

                entity.Property(e => e.EditBitrate)
                    .HasColumnType("NUMBER")
                    .HasColumnName("EDIT_BITRATE");

                entity.Property(e => e.EditDeldate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_DELDATE")
                    .IsFixedLength();

                entity.Property(e => e.EditEditdate)
                    .HasColumnType("DATE")
                    .HasColumnName("EDIT_EDITDATE");

                entity.Property(e => e.EditEom)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_EOM")
                    .IsFixedLength();

                entity.Property(e => e.EditFilelength)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_FILELENGTH")
                    .IsFixedLength();

                entity.Property(e => e.EditFilepath)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_FILEPATH");

                entity.Property(e => e.EditFiletype)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_FILETYPE")
                    .IsFixedLength();

                entity.Property(e => e.EditFreq)
                    .HasColumnType("NUMBER")
                    .HasColumnName("EDIT_FREQ");

                entity.Property(e => e.EditIsaudio)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_ISAUDIO")
                    .IsFixedLength();

                entity.Property(e => e.EditIsedit)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_ISEDIT")
                    .IsFixedLength();

                entity.Property(e => e.EditSom)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_SOM")
                    .IsFixedLength();

                entity.Property(e => e.EditTitle)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_TITLE");

                entity.Property(e => e.EditUpdate)
                    .HasColumnType("DATE")
                    .HasColumnName("EDIT_UPDATE");

                entity.Property(e => e.EditUpusernum)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_UPUSERNUM");

                entity.Property(e => e.EditUsernum)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_USERNUM");

                entity.Property(e => e.EditWorkpath)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("EDIT_WORKPATH");

                entity.HasOne(d => d.EditUsernumNavigation)
                    .WithMany(p => p.Editings)
                    .HasForeignKey(d => d.EditUsernum)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C0053987");
            });

            modelBuilder.Entity<EtcInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ETC_INFO");

                entity.Property(e => e.EcifCodehigh)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ECIF_CODEHIGH");

                entity.Property(e => e.EcifCodelow)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ECIF_CODELOW");

                entity.Property(e => e.EcifMemo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ECIF_MEMO");

                entity.Property(e => e.EcifName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ECIF_NAME");

                entity.Property(e => e.EcifValue)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ECIF_VALUE");
            });

            modelBuilder.Entity<Groupinfo>(entity =>
            {
                entity.HasKey(e => e.GrifId)
                    .HasName("SYS_C0053658");

                entity.ToTable("GROUPINFO");

                entity.Property(e => e.GrifId)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("GRIF_ID")
                    .IsFixedLength();

                entity.Property(e => e.GrifName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("GRIF_NAME");

                entity.Property(e => e.GrifOrder)
                    .HasColumnType("NUMBER")
                    .HasColumnName("GRIF_ORDER");
            });

            modelBuilder.Entity<IdxAlbumTitle>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("IDX_ALBUM_TITLE");

                entity.HasIndex(e => e.IdxKeyword, "ALBUM_TITLE_INDEX");

                entity.Property(e => e.AlbmId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ALBM_ID");

                entity.Property(e => e.IdxKeyword)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("IDX_KEYWORD");
            });

            modelBuilder.Entity<IdxSongArtist>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("IDX_SONG_ARTIST");

                entity.HasIndex(e => e.IdxKeyword, "SONG_ARTIST_INDEX");

                entity.Property(e => e.IdxKeyword)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("IDX_KEYWORD");

                entity.Property(e => e.SongId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("SONG_ID")
                    .IsFixedLength();
            });

            modelBuilder.Entity<IdxSongKeyword>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("IDX_SONG_KEYWORD");

                entity.HasIndex(e => e.IdxKeyword, "SONG_KEYWORD_INDEX");

                entity.Property(e => e.IdxKeyword)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("IDX_KEYWORD");

                entity.Property(e => e.SongId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("SONG_ID")
                    .IsFixedLength();
            });

            modelBuilder.Entity<IdxSongTitle>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("IDX_SONG_TITLE");

                entity.Property(e => e.IdxKeyword)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("IDX_KEYWORD");

                entity.Property(e => e.SongId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("SONG_ID")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Itemask>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ITEMASK");

                entity.Property(e => e.IaskAsktime)
                    .HasColumnType("DATE")
                    .HasColumnName("IASK_ASKTIME");

                entity.Property(e => e.IaskAskuser)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("IASK_ASKUSER");

                entity.Property(e => e.IaskExpfile)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IASK_EXPFILE");

                entity.Property(e => e.IaskExport)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IASK_EXPORT")
                    .IsFixedLength();

                entity.Property(e => e.IaskExppath)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("IASK_EXPPATH");

                entity.Property(e => e.IaskExptime)
                    .HasColumnType("DATE")
                    .HasColumnName("IASK_EXPTIME");

                entity.Property(e => e.IaskFileid)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("IASK_FILEID");

                entity.Property(e => e.IaskItemtype)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("IASK_ITEMTYPE")
                    .IsFixedLength();

                entity.Property(e => e.IaskTake)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IASK_TAKE")
                    .IsFixedLength();

                entity.Property(e => e.IaskTaketime)
                    .HasColumnType("DATE")
                    .HasColumnName("IASK_TAKETIME");

                entity.Property(e => e.IaskTakeuser)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("IASK_TAKEUSER");
            });

            modelBuilder.Entity<Itemcodehigh>(entity =>
            {
                entity.HasKey(e => e.ItchId)
                    .HasName("SYS_C0053662");

                entity.ToTable("ITEMCODEHIGH");

                entity.Property(e => e.ItchId)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ITCH_ID")
                    .IsFixedLength();

                entity.Property(e => e.ItchInfo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ITCH_INFO");

                entity.Property(e => e.ItchName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ITCH_NAME");

                entity.Property(e => e.ItchOrder)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ITCH_ORDER");
            });

            modelBuilder.Entity<Itemcodelow>(entity =>
            {
                entity.HasKey(e => e.ItclId)
                    .HasName("SYS_C0053666");

                entity.ToTable("ITEMCODELOW");

                entity.Property(e => e.ItclId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ITCL_ID");

                entity.Property(e => e.ItclInfo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ITCL_INFO");

                entity.Property(e => e.ItclItchid)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ITCL_ITCHID")
                    .IsFixedLength();

                entity.Property(e => e.ItclName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ITCL_NAME");

                entity.Property(e => e.ItclOrder)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ITCL_ORDER");

                entity.Property(e => e.ItclUsed)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ITCL_USED")
                    .IsFixedLength();

                entity.HasOne(d => d.ItclItch)
                    .WithMany(p => p.Itemcodelows)
                    .HasForeignKey(d => d.ItclItchid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C0053915");
            });

            modelBuilder.Entity<Itemfile>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("SYS_C0053674");

                entity.ToTable("ITEMFILE");

                entity.Property(e => e.ItemId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_ID")
                    .IsFixedLength();

                entity.Property(e => e.ItemArea)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_AREA")
                    .IsFixedLength();

                entity.Property(e => e.ItemClipid)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_CLIPID");

                entity.Property(e => e.ItemDowncnt)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ITEM_DOWNCNT")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemDowndate)
                    .HasColumnType("DATE")
                    .HasColumnName("ITEM_DOWNDATE");

                entity.Property(e => e.ItemDuration)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ITEM_DURATION")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.ItemFilename)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_FILENAME");

                entity.Property(e => e.ItemFilepath)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_FILEPATH");

                entity.Property(e => e.ItemItchid)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_ITCHID")
                    .IsFixedLength();

                entity.Property(e => e.ItemItclid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ITEM_ITCLID");

                entity.Property(e => e.ItemMedaid)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_MEDAID")
                    .IsFixedLength();

                entity.Property(e => e.ItemMemo)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_MEMO");

                entity.Property(e => e.ItemNewsregdate)
                    .HasColumnType("DATE")
                    .HasColumnName("ITEM_NEWSREGDATE");

                entity.Property(e => e.ItemNewsuserid)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_NEWSUSERID");

                entity.Property(e => e.ItemPgmid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ITEM_PGMID");

                entity.Property(e => e.ItemPlace)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_PLACE");

                entity.Property(e => e.ItemRegdate)
                    .HasColumnType("DATE")
                    .HasColumnName("ITEM_REGDATE");

                entity.Property(e => e.ItemRuntime)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_RUNTIME")
                    .IsFixedLength();

                entity.Property(e => e.ItemTag)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_TAG");

                entity.Property(e => e.ItemTitle)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_TITLE");

                entity.Property(e => e.ItemUsed)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_USED")
                    .IsFixedLength();

                entity.Property(e => e.ItemUsernum)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_USERNUM");

                entity.HasOne(d => d.ItemItch)
                    .WithMany(p => p.Itemfiles)
                    .HasForeignKey(d => d.ItemItchid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C0053914");

                entity.HasOne(d => d.ItemMeda)
                    .WithMany(p => p.Itemfiles)
                    .HasForeignKey(d => d.ItemMedaid)
                    .HasConstraintName("SYS_C0053923");

                entity.HasOne(d => d.ItemUsernumNavigation)
                    .WithMany(p => p.Itemfiles)
                    .HasForeignKey(d => d.ItemUsernum)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C0053986");
            });

            modelBuilder.Entity<Mediainfo>(entity =>
            {
                entity.HasKey(e => e.MedaId)
                    .HasName("SYS_C0053677");

                entity.ToTable("MEDIAINFO");

                entity.Property(e => e.MedaId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MEDA_ID")
                    .IsFixedLength();

                entity.Property(e => e.MedaName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MEDA_NAME");

                entity.Property(e => e.MedaOrder)
                    .HasColumnType("NUMBER")
                    .HasColumnName("MEDA_ORDER");
            });

            modelBuilder.Entity<MpsAlbum>(entity =>
            {
                entity.HasKey(e => e.AlbumId)
                    .HasName("ALBUM_PK");

                entity.ToTable("MPS_ALBUM");

                entity.Property(e => e.AlbumId)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ALBUM_ID");

                entity.Property(e => e.AddArtist)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ARTIST");

                entity.Property(e => e.AddTitle)
                    .HasMaxLength(600)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ADD_TITLE");

                entity.Property(e => e.Agency)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("AGENCY");

                entity.Property(e => e.Deldate)
                    .HasColumnType("DATE")
                    .HasColumnName("DELDATE");

                entity.Property(e => e.Editdate)
                    .HasColumnType("DATE")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Form)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FORM");

                entity.Property(e => e.ImagePath)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("IMAGE_PATH");

                entity.Property(e => e.IntlTitle)
                    .HasMaxLength(300)
                    .HasColumnName("INTL_TITLE");

                entity.Property(e => e.Isuse)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ISUSE");

                entity.Property(e => e.LoanStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LOAN_STATUS");

                entity.Property(e => e.Memo)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("MEMO");

                entity.Property(e => e.Receiving)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("RECEIVING");

                entity.Property(e => e.Regdate)
                    .HasColumnType("DATE")
                    .HasColumnName("REGDATE");

                entity.Property(e => e.Relyear)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("RELYEAR")
                    .IsFixedLength();

                entity.Property(e => e.RepTitle)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("REP_TITLE");

                entity.Property(e => e.SecureCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SECURE_CODE")
                    .IsFixedLength();

                entity.Property(e => e.SecureNum)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SECURE_NUM");

                entity.Property(e => e.SecurePcode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SECURE_PCODE")
                    .IsFixedLength();

                entity.HasOne(d => d.FormNavigation)
                    .WithMany(p => p.MpsAlbumFormNavigations)
                    .HasForeignKey(d => d.Form)
                    .HasConstraintName("ALBUM_FORM_FK");

                entity.HasOne(d => d.IsuseNavigation)
                    .WithMany(p => p.MpsAlbumIsuseNavigations)
                    .HasForeignKey(d => d.Isuse)
                    .HasConstraintName("ALBUM_ISUSE_FK");

                entity.HasOne(d => d.LoanStatusNavigation)
                    .WithMany(p => p.MpsAlbumLoanStatusNavigations)
                    .HasForeignKey(d => d.LoanStatus)
                    .HasConstraintName("ALBUM_LOANSTATUS_FK");

                entity.HasOne(d => d.ReceivingNavigation)
                    .WithMany(p => p.MpsAlbumReceivingNavigations)
                    .HasForeignKey(d => d.Receiving)
                    .HasConstraintName("ALBUM_RECEIVING_FK");

                entity.HasOne(d => d.SecurePcodeNavigation)
                    .WithMany(p => p.MpsAlbums)
                    .HasForeignKey(d => d.SecurePcode)
                    .HasConstraintName("ALBUM_SECUREPCODE_FK");

                entity.HasMany(d => d.Codes)
                    .WithMany(p => p.Albums)
                    .UsingEntity<Dictionary<string, object>>(
                        "MpsAlbumClassMap",
                        l => l.HasOne<MpsClass>().WithMany().HasForeignKey("Code").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("ALBUMCLASSIFICATION_CODE_FK"),
                        r => r.HasOne<MpsAlbum>().WithMany().HasForeignKey("AlbumId").HasConstraintName("ALBUMCLASSIFICATION_ALBUMID_FK"),
                        j =>
                        {
                            j.HasKey("AlbumId", "Code").HasName("ALBUMCLASSIFICATION_PK");

                            j.ToTable("MPS_ALBUM_CLASS_MAP");

                            j.IndexerProperty<decimal>("AlbumId").HasColumnType("NUMBER").HasColumnName("ALBUM_ID");

                            j.IndexerProperty<decimal>("Code").HasColumnType("NUMBER").HasColumnName("CODE");
                        });
            });

            modelBuilder.Entity<MpsAlbumArtistMap>(entity =>
            {
                entity.HasKey(e => new { e.ArtistId, e.AlbumId })
                    .HasName("ARTIST_ALBUM_PK");

                entity.ToTable("MPS_ALBUM_ARTIST_MAP");

                entity.Property(e => e.ArtistId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ARTIST_ID");

                entity.Property(e => e.AlbumId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ALBUM_ID");

                entity.Property(e => e.ArtistOrder)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ARTIST_ORDER");

                entity.HasOne(d => d.Album)
                    .WithMany(p => p.MpsAlbumArtistMaps)
                    .HasForeignKey(d => d.AlbumId)
                    .HasConstraintName("ALBUMARTIST_ALBUMID_FK");

                entity.HasOne(d => d.Artist)
                    .WithMany(p => p.MpsAlbumArtistMaps)
                    .HasForeignKey(d => d.ArtistId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ALBUMARTIST_ARTISTID_FK");
            });

            modelBuilder.Entity<MpsAlbumClassIdx>(entity =>
            {
                entity.HasKey(e => e.AlbumId)
                    .HasName("ACI_ALBUMID_PK");

                entity.ToTable("MPS_ALBUM_CLASS_IDX");

                entity.Property(e => e.AlbumId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ALBUM_ID");

                entity.Property(e => e.ClassCode)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CLASS_CODE");

                entity.HasOne(d => d.Album)
                    .WithOne(p => p.MpsAlbumClassIdx)
                    .HasForeignKey<MpsAlbumClassIdx>(d => d.AlbumId)
                    .HasConstraintName("ACI_ALBUMID_FK");
            });

            modelBuilder.Entity<MpsAlbumIndex>(entity =>
            {
                entity.HasKey(e => new { e.AlbumId, e.Keyword })
                    .HasName("ALBUMKEYWORD_PK");

                entity.ToTable("MPS_ALBUM_INDEX");

                entity.Property(e => e.AlbumId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ALBUM_ID");

                entity.Property(e => e.Keyword)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("KEYWORD");

                entity.HasOne(d => d.Album)
                    .WithMany(p => p.MpsAlbumIndices)
                    .HasForeignKey(d => d.AlbumId)
                    .HasConstraintName("ALBUMKEYWORD_ALBUMID_FK");
            });

            modelBuilder.Entity<MpsAlbumLoan>(entity =>
            {
                entity.HasKey(e => new { e.LoanId, e.AlbumId })
                    .HasName("LOAN_PK");

                entity.ToTable("MPS_ALBUM_LOAN");

                entity.Property(e => e.LoanId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LOAN_ID");

                entity.Property(e => e.AlbumId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ALBUM_ID");

                entity.Property(e => e.Bordate)
                    .HasColumnType("DATE")
                    .HasColumnName("BORDATE");

                entity.Property(e => e.Retdate)
                    .HasColumnType("DATE")
                    .HasColumnName("RETDATE");

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");

                entity.Property(e => e.UserId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("USER_ID");

                entity.HasOne(d => d.Album)
                    .WithMany(p => p.MpsAlbumLoans)
                    .HasForeignKey(d => d.AlbumId)
                    .HasConstraintName("LOAN_ALBUMID_FK");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.MpsAlbumLoans)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("LOAN_USERID_FK");
            });

            modelBuilder.Entity<MpsArtist>(entity =>
            {
                entity.HasKey(e => e.ArtistId)
                    .HasName("ARTIST_PK");

                entity.ToTable("MPS_ARTIST");

                entity.Property(e => e.ArtistId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ARTIST_ID");

                entity.Property(e => e.AddName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ADD_NAME");

                entity.Property(e => e.Editdate)
                    .HasColumnType("DATE")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GENDER");

                entity.Property(e => e.Regdate)
                    .HasColumnType("DATE")
                    .HasColumnName("REGDATE");

                entity.Property(e => e.RepName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("REP_NAME");

                entity.HasMany(d => d.Insts)
                    .WithMany(p => p.Artists)
                    .UsingEntity<Dictionary<string, object>>(
                        "MpsArtistInstMap",
                        l => l.HasOne<MpsInst>().WithMany().HasForeignKey("InstId").HasConstraintName("AIS_INSTID_FK"),
                        r => r.HasOne<MpsArtist>().WithMany().HasForeignKey("ArtistId").HasConstraintName("AIS_ARTISTID_FK"),
                        j =>
                        {
                            j.HasKey("ArtistId", "InstId").HasName("ARTIST_INST_PK");

                            j.ToTable("MPS_ARTIST_INST_MAP");

                            j.IndexerProperty<decimal>("ArtistId").HasColumnType("NUMBER").HasColumnName("ARTIST_ID");

                            j.IndexerProperty<decimal>("InstId").HasColumnType("NUMBER").HasColumnName("INST_ID");
                        });
            });

            modelBuilder.Entity<MpsBanKeyword>(entity =>
            {
                entity.HasKey(e => new { e.KeywordId, e.Keyword })
                    .HasName("BANKEYWORD_PK");

                entity.ToTable("MPS_BAN_KEYWORD");

                entity.Property(e => e.KeywordId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("KEYWORD_ID");

                entity.Property(e => e.Keyword)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("KEYWORD");
            });

            modelBuilder.Entity<MpsClass>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("CLA_CODE_PK");

                entity.ToTable("MPS_CLASS");

                entity.Property(e => e.Code)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CODE");

                entity.Property(e => e.CodeName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CODE_NAME");

                entity.Property(e => e.ParentCode)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PARENT_CODE");

                entity.HasOne(d => d.ParentCodeNavigation)
                    .WithMany(p => p.InverseParentCodeNavigation)
                    .HasForeignKey(d => d.ParentCode)
                    .HasConstraintName("CLA_PCODE_FK");
            });

            modelBuilder.Entity<MpsClassic>(entity =>
            {
                entity.HasKey(e => e.SongId)
                    .HasName("CLASSIC_PK");

                entity.ToTable("MPS_CLASSIC");

                entity.Property(e => e.SongId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("SONG_ID")
                    .IsFixedLength();

                entity.Property(e => e.OpusNo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("OPUS_NO");

                entity.HasOne(d => d.Song)
                    .WithOne(p => p.MpsClassic)
                    .HasForeignKey<MpsClassic>(d => d.SongId)
                    .HasConstraintName("CLASSIC_SONGID_FK");
            });

            modelBuilder.Entity<MpsCommonCode>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("COMMONCODE_PK");

                entity.ToTable("MPS_COMMON_CODE");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.CodeName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CODE_NAME");

                entity.Property(e => e.ParentCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PARENT_CODE");
            });

            modelBuilder.Entity<MpsIdxAlbumTitleSntc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MPS_IDX_ALBUM_TITLE_SNTC");

                entity.HasIndex(e => e.AlbumId, "MIATS_INDEX1");

                entity.HasIndex(e => e.IdxKeyword, "MIATS_INDEX2");

                entity.Property(e => e.AlbumId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ALBUM_ID");

                entity.Property(e => e.IdxKeyword)
                    .HasMaxLength(600)
                    .IsUnicode(false)
                    .HasColumnName("IDX_KEYWORD");
            });

            modelBuilder.Entity<MpsIdxSongArtistSntc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MPS_IDX_SONG_ARTIST_SNTC");

                entity.HasIndex(e => e.SongId, "MISAS_INDEX1");

                entity.HasIndex(e => e.IdxKeyword, "MISAS_INDEX2");

                entity.Property(e => e.IdxKeyword)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("IDX_KEYWORD");

                entity.Property(e => e.SongId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("SONG_ID")
                    .IsFixedLength();
            });

            modelBuilder.Entity<MpsIdxSongInfoSntc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MPS_IDX_SONG_INFO_SNTC");

                entity.HasIndex(e => e.SongId, "MISIS_INDEX1");

                entity.HasIndex(e => e.Composer, "MISIS_INDEX2");

                entity.HasIndex(e => e.Lyricist, "MISIS_INDEX3");

                entity.HasIndex(e => e.Arranger, "MISIS_INDEX4");

                entity.Property(e => e.Arranger)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ARRANGER");

                entity.Property(e => e.Composer)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("COMPOSER");

                entity.Property(e => e.Lyricist)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("LYRICIST");

                entity.Property(e => e.SongId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("SONG_ID")
                    .IsFixedLength();
            });

            modelBuilder.Entity<MpsIdxSongInfoWord>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MPS_IDX_SONG_INFO_WORD");

                entity.HasIndex(e => e.SongId, "MPS_IDX_SONG_INFO_WORD_INDEX1");

                entity.HasIndex(e => e.ArtistType, "MPS_IDX_SONG_INFO_WORD_INDEX2");

                entity.HasIndex(e => e.IdxKeyword, "MPS_IDX_SONG_INFO_WORD_INDEX3");

                entity.Property(e => e.ArtistType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ARTIST_TYPE");

                entity.Property(e => e.IdxKeyword)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("IDX_KEYWORD");

                entity.Property(e => e.SongId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("SONG_ID");
            });

            modelBuilder.Entity<MpsIdxSongLyricsSntc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MPS_IDX_SONG_LYRICS_SNTC");

                entity.HasIndex(e => e.SongId, "MISLS_INDEX1");

                entity.HasIndex(e => e.IdxKeyword, "MISLS_INDEX2");

                entity.Property(e => e.IdxKeyword)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("IDX_KEYWORD");

                entity.Property(e => e.SongId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("SONG_ID")
                    .IsFixedLength();
            });

            modelBuilder.Entity<MpsIdxSongTagWord>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MPS_IDX_SONG_TAG_WORD");

                entity.HasIndex(e => e.SongId, "MIST_INDEX1");

                entity.HasIndex(e => e.IdxKeyword, "MIST_INDEX2");

                entity.Property(e => e.IdxKeyword)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("IDX_KEYWORD");

                entity.Property(e => e.SongId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("SONG_ID")
                    .IsFixedLength();
            });

            modelBuilder.Entity<MpsIdxSongTitleSntc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MPS_IDX_SONG_TITLE_SNTC");

                entity.HasIndex(e => e.SongId, "MISTS_INDEX1");

                entity.HasIndex(e => e.IdxKeyword, "MISTS_INDEX2");

                entity.Property(e => e.IdxKeyword)
                    .HasMaxLength(600)
                    .IsUnicode(false)
                    .HasColumnName("IDX_KEYWORD");

                entity.Property(e => e.SongId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("SONG_ID")
                    .IsFixedLength();
            });

            modelBuilder.Entity<MpsIdxSongTitleWord>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MPS_IDX_SONG_TITLE_WORD");

                entity.HasIndex(e => e.SongId, "MISTW_INDEX1");

                entity.HasIndex(e => e.IdxKeyword, "MISTW_INDEX2");

                entity.Property(e => e.IdxKeyword)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("IDX_KEYWORD");

                entity.Property(e => e.SongId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("SONG_ID")
                    .IsFixedLength();
            });

            modelBuilder.Entity<MpsIfLbhRainbow>(entity =>
            {
                entity.HasKey(e => e.Seq)
                    .HasName("MPS_LBH_TO_RAINBOW_PK");

                entity.ToTable("MPS_IF_LBH_RAINBOW");

                entity.Property(e => e.Seq)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SEQ");

                entity.Property(e => e.ActionDtm)
                    .HasColumnType("DATE")
                    .HasColumnName("ACTION_DTM");

                entity.Property(e => e.ActionFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ACTION_FLAG")
                    .IsFixedLength();

                entity.Property(e => e.ArtistName)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("ARTIST_NAME");

                entity.Property(e => e.MediaId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MEDIA_ID")
                    .IsFixedLength();

                entity.Property(e => e.MediaName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MEDIA_NAME");

                entity.Property(e => e.PgmId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PGM_ID");

                entity.Property(e => e.PgmName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PGM_NAME");

                entity.Property(e => e.RegDtm)
                    .HasColumnType("DATE")
                    .HasColumnName("REG_DTM")
                    .HasDefaultValueSql("SYSDATE\n   ");

                entity.Property(e => e.SongId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("SONG_ID");

                entity.Property(e => e.SongLength)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SONG_LENGTH");

                entity.Property(e => e.SongName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SONG_NAME");
            });

            modelBuilder.Entity<MpsIfSongRainbow>(entity =>
            {
                entity.HasKey(e => e.Seq)
                    .HasName("MPS_SONG_TO_RAINBOW_PK");

                entity.ToTable("MPS_IF_SONG_RAINBOW");

                entity.Property(e => e.Seq)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SEQ");

                entity.Property(e => e.ActionFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ACTION_FLAG")
                    .IsFixedLength();

                entity.Property(e => e.RegDtm)
                    .HasColumnType("DATE")
                    .HasColumnName("REG_DTM");

                entity.Property(e => e.SongId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("SONG_ID");
            });

            modelBuilder.Entity<MpsInst>(entity =>
            {
                entity.HasKey(e => e.InstId)
                    .HasName("INST_PK");

                entity.ToTable("MPS_INST");

                entity.Property(e => e.InstId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INST_ID");

                entity.Property(e => e.AddName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ADD_NAME");

                entity.Property(e => e.RepName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("REP_NAME");
            });

            modelBuilder.Entity<MpsRequestSong>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MPS_REQUEST_SONG");

                entity.Property(e => e.Content)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("CONTENT");

                entity.Property(e => e.Reason)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("REASON");

                entity.Property(e => e.Regdate)
                    .HasColumnType("DATE")
                    .HasColumnName("REGDATE");

                entity.Property(e => e.ReqId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("REQ_ID");

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");

                entity.Property(e => e.Title)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("TITLE");

                entity.Property(e => e.UserId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("USER_ID");
            });

            modelBuilder.Entity<MpsSecureBigCode>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("SBC_CODE_PK");

                entity.ToTable("MPS_SECURE_BIG_CODE");

                entity.Property(e => e.Code)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CODE")
                    .IsFixedLength();

                entity.Property(e => e.CodeName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CODE_NAME");
            });

            modelBuilder.Entity<MpsSecureMidCode>(entity =>
            {
                entity.HasKey(e => new { e.Code, e.ParentCode })
                    .HasName("SMC_CODE_PK");

                entity.ToTable("MPS_SECURE_MID_CODE");

                entity.Property(e => e.Code)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CODE")
                    .IsFixedLength();

                entity.Property(e => e.ParentCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PARENT_CODE")
                    .IsFixedLength();

                entity.Property(e => e.CodeName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CODE_NAME");

                entity.HasOne(d => d.ParentCodeNavigation)
                    .WithMany(p => p.MpsSecureMidCodes)
                    .HasForeignKey(d => d.ParentCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SMC_PCODE_FK");
            });

            modelBuilder.Entity<MpsSong>(entity =>
            {
                entity.HasKey(e => e.SongId)
                    .HasName("SONG_PK");

                entity.ToTable("MPS_SONG");

                entity.Property(e => e.SongId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SONG_ID")
                    .IsFixedLength();

                entity.Property(e => e.AddArtist)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ARTIST");

                entity.Property(e => e.AddTitle)
                    .HasMaxLength(600)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ADD_TITLE");

                entity.Property(e => e.AlbumId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ALBUM_ID");

                entity.Property(e => e.Arranger)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ARRANGER");

                entity.Property(e => e.Composer)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("COMPOSER");

                entity.Property(e => e.Duration)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("DURATION")
                    .IsFixedLength();

                entity.Property(e => e.Editdate)
                    .HasColumnType("DATE")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Filename)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("FILENAME");

                entity.Property(e => e.Filepath)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("FILEPATH");

                entity.Property(e => e.Genre)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("GENRE");

                entity.Property(e => e.Grade)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GRADE");

                entity.Property(e => e.IntlTitle)
                    .HasMaxLength(300)
                    .HasColumnName("INTL_TITLE");

                entity.Property(e => e.Istitle)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ISTITLE");

                entity.Property(e => e.Memo)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("MEMO");

                entity.Property(e => e.Receiving)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("RECEIVING");

                entity.Property(e => e.Regdate)
                    .HasColumnType("DATE")
                    .HasColumnName("REGDATE");

                entity.Property(e => e.RepTitle)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("REP_TITLE");

                entity.Property(e => e.SongTag)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SONG_TAG");

                entity.Property(e => e.Track)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TRACK");

                entity.Property(e => e.Type)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("TYPE");

                entity.HasOne(d => d.Album)
                    .WithMany(p => p.MpsSongs)
                    .HasForeignKey(d => d.AlbumId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("SONG_ALBMID_FK");

                entity.HasOne(d => d.GradeNavigation)
                    .WithMany(p => p.MpsSongGradeNavigations)
                    .HasForeignKey(d => d.Grade)
                    .HasConstraintName("SONG_GRADE_FK");

                entity.HasOne(d => d.IstitleNavigation)
                    .WithMany(p => p.MpsSongIstitleNavigations)
                    .HasForeignKey(d => d.Istitle)
                    .HasConstraintName("SONG_ISTITLE_FK");

                entity.HasOne(d => d.ReceivingNavigation)
                    .WithMany(p => p.MpsSongReceivingNavigations)
                    .HasForeignKey(d => d.Receiving)
                    .HasConstraintName("SONG_RECEIVING_FK");

                entity.HasOne(d => d.TypeNavigation)
                    .WithMany(p => p.MpsSongTypeNavigations)
                    .HasForeignKey(d => d.Type)
                    .HasConstraintName("SONG_TYPE_FK");

                entity.HasMany(d => d.Codes)
                    .WithMany(p => p.Songs)
                    .UsingEntity<Dictionary<string, object>>(
                        "MpsSongClassMap",
                        l => l.HasOne<MpsClass>().WithMany().HasForeignKey("Code").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("SONGCLASSIFICATION_CODE_FK"),
                        r => r.HasOne<MpsSong>().WithMany().HasForeignKey("SongId").HasConstraintName("SONGCLASSIFICATION_SONGID_FK"),
                        j =>
                        {
                            j.HasKey("SongId", "Code").HasName("SONGCLASSIFICATION_PK");

                            j.ToTable("MPS_SONG_CLASS_MAP");

                            j.IndexerProperty<string>("SongId").HasMaxLength(12).IsUnicode(false).HasColumnName("SONG_ID").IsFixedLength();

                            j.IndexerProperty<decimal>("Code").HasColumnType("NUMBER").HasColumnName("CODE");
                        });
            });

            modelBuilder.Entity<MpsSongAddInfo>(entity =>
            {
                entity.HasKey(e => e.SongId)
                    .HasName("SONGADDINFO_PK");

                entity.ToTable("MPS_SONG_ADD_INFO");

                entity.Property(e => e.SongId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("SONG_ID")
                    .IsFixedLength();

                entity.Property(e => e.DlCnt)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DL_CNT")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LbhCnt)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LBH_CNT")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LikeCnt)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LIKE_CNT")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MstInfo)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("MST_INFO");

                entity.HasOne(d => d.Song)
                    .WithOne(p => p.MpsSongAddInfo)
                    .HasForeignKey<MpsSongAddInfo>(d => d.SongId)
                    .HasConstraintName("SONGADDINFO_SONGID_FK");
            });

            modelBuilder.Entity<MpsSongArtistIdx>(entity =>
            {
                entity.HasKey(e => e.SongId)
                    .HasName("SAI_SONGID_PK");

                entity.ToTable("MPS_SONG_ARTIST_IDX");

                entity.Property(e => e.SongId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SONG_ID")
                    .IsFixedLength();

                entity.Property(e => e.ArtistAddName)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("ARTIST_ADD_NAME");

                entity.Property(e => e.ArtistId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ARTIST_ID");

                entity.Property(e => e.ArtistRepName)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("ARTIST_REP_NAME");

                entity.Property(e => e.FeatName)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("FEAT_NAME");

                entity.HasOne(d => d.Song)
                    .WithOne(p => p.MpsSongArtistIdx)
                    .HasForeignKey<MpsSongArtistIdx>(d => d.SongId)
                    .HasConstraintName("SAIDX_SONGID_FK");
            });

            modelBuilder.Entity<MpsSongArtistMap>(entity =>
            {
                entity.HasKey(e => new { e.SongId, e.ArtistId })
                    .HasName("SONG_ARTIST_PK");

                entity.ToTable("MPS_SONG_ARTIST_MAP");

                entity.Property(e => e.SongId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("SONG_ID")
                    .IsFixedLength();

                entity.Property(e => e.ArtistId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ARTIST_ID");

                entity.Property(e => e.ArtistOrder)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ARTIST_ORDER");

                entity.HasOne(d => d.Artist)
                    .WithMany(p => p.MpsSongArtistMaps)
                    .HasForeignKey(d => d.ArtistId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SAI_ARTISTID_FK");

                entity.HasOne(d => d.Song)
                    .WithMany(p => p.MpsSongArtistMaps)
                    .HasForeignKey(d => d.SongId)
                    .HasConstraintName("SAI_SONGID_FK");
            });

            modelBuilder.Entity<MpsSongClassIdx>(entity =>
            {
                entity.HasKey(e => e.SongId)
                    .HasName("SCI_SONGID_PK");

                entity.ToTable("MPS_SONG_CLASS_IDX");

                entity.Property(e => e.SongId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("SONG_ID")
                    .IsFixedLength();

                entity.Property(e => e.ClassCode)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CLASS_CODE");

                entity.HasOne(d => d.Song)
                    .WithOne(p => p.MpsSongClassIdx)
                    .HasForeignKey<MpsSongClassIdx>(d => d.SongId)
                    .HasConstraintName("SCI_SONGID_FK");
            });

            modelBuilder.Entity<MpsSongHistory>(entity =>
            {
                entity.HasKey(e => e.Seq)
                    .HasName("MPS_SONG_HISTORY_PK");

                entity.ToTable("MPS_SONG_HISTORY");

                entity.Property(e => e.Seq)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SEQ");

                entity.Property(e => e.AlbumCallNo)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("ALBUM_CALL_NO");

                entity.Property(e => e.AlbumId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ALBUM_ID");

                entity.Property(e => e.AlbumName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ALBUM_NAME");

                entity.Property(e => e.ArtistName)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("ARTIST_NAME");

                entity.Property(e => e.CateName)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("CATE_NAME");

                entity.Property(e => e.EndDtm)
                    .HasColumnType("DATE")
                    .HasColumnName("END_DTM");

                entity.Property(e => e.MediaId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MEDIA_ID")
                    .IsFixedLength();

                entity.Property(e => e.MediaName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MEDIA_NAME");

                entity.Property(e => e.PgmId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PGM_ID");

                entity.Property(e => e.PgmName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PGM_NAME");

                entity.Property(e => e.PlayDuration)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PLAY_DURATION");

                entity.Property(e => e.RegDtm)
                    .HasColumnType("DATE")
                    .HasColumnName("REG_DTM");

                entity.Property(e => e.RegisterName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("REGISTER_NAME");

                entity.Property(e => e.SchDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("SCH_DATE");

                entity.Property(e => e.SongId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SONG_ID");

                entity.Property(e => e.SongLength)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SONG_LENGTH");

                entity.Property(e => e.SongName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SONG_NAME");

                entity.Property(e => e.StartDtm)
                    .HasColumnType("DATE")
                    .HasColumnName("START_DTM");

                entity.Property(e => e.StudioName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("STUDIO_NAME");
            });

            modelBuilder.Entity<MpsSongIndex>(entity =>
            {
                entity.HasKey(e => new { e.SongId, e.Keyword })
                    .HasName("SONGKEYWORD_PK");

                entity.ToTable("MPS_SONG_INDEX");

                entity.Property(e => e.SongId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SONG_ID")
                    .IsFixedLength();

                entity.Property(e => e.Keyword)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("KEYWORD");

                entity.HasOne(d => d.Song)
                    .WithMany(p => p.MpsSongIndices)
                    .HasForeignKey(d => d.SongId)
                    .HasConstraintName("SONGKEYWORD_SONGID_FK");
            });

            modelBuilder.Entity<MpsSongInfo>(entity =>
            {
                entity.HasKey(e => e.SongId)
                    .HasName("SONGINFO_PK");

                entity.ToTable("MPS_SONG_INFO");

                entity.Property(e => e.SongId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SONG_ID")
                    .IsFixedLength();

                entity.Property(e => e.Lyricist)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("LYRICIST");

                entity.Property(e => e.Lyrics1)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("LYRICS1");

                entity.Property(e => e.Lyrics2)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("LYRICS2");

                entity.HasOne(d => d.Song)
                    .WithOne(p => p.MpsSongInfo)
                    .HasForeignKey<MpsSongInfo>(d => d.SongId)
                    .HasConstraintName("SONGINFO_SONGID_FK");
            });

            modelBuilder.Entity<MpsSongInfoIdx>(entity =>
            {
                entity.HasKey(e => e.SongId)
                    .HasName("SYS_C0053707");

                entity.ToTable("MPS_SONG_INFO_IDX");

                entity.Property(e => e.SongId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SONG_ID")
                    .IsFixedLength();

                entity.Property(e => e.Arranger)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ARRANGER");

                entity.Property(e => e.Composer)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("COMPOSER");

                entity.Property(e => e.Lyricist)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("LYRICIST");
            });

            modelBuilder.Entity<MpsSongInstMap>(entity =>
            {
                entity.HasKey(e => new { e.SongId, e.InstId, e.InstOrder })
                    .HasName("MPS_SONG_INST_MAP_PK");

                entity.ToTable("MPS_SONG_INST_MAP");

                entity.Property(e => e.SongId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("SONG_ID")
                    .IsFixedLength();

                entity.Property(e => e.InstId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INST_ID");

                entity.Property(e => e.InstOrder)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INST_ORDER");

                entity.HasOne(d => d.Inst)
                    .WithMany(p => p.MpsSongInstMaps)
                    .HasForeignKey(d => d.InstId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SIM_INSTID_FK");

                entity.HasOne(d => d.Song)
                    .WithMany(p => p.MpsSongInstMaps)
                    .HasForeignKey(d => d.SongId)
                    .HasConstraintName("SIM_SONGID_FK");
            });

            modelBuilder.Entity<MpsVwRootClass>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MPS_VW_ROOT_CLASS");

                entity.Property(e => e.Code)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CODE");

                entity.Property(e => e.CodeName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CODE_NAME");

                entity.Property(e => e.ParentCode)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PARENT_CODE");

                entity.Property(e => e.RootCode)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ROOT_CODE");
            });

            modelBuilder.Entity<MpsVwSong>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MPS_VW_SONG");

                entity.Property(e => e.AddArtist)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ARTIST");

                entity.Property(e => e.AddTitle)
                    .HasMaxLength(600)
                    .IsUnicode(false)
                    .HasColumnName("ADD_TITLE");

                entity.Property(e => e.Agency)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("AGENCY");

                entity.Property(e => e.AlbumAddTitle)
                    .HasMaxLength(600)
                    .IsUnicode(false)
                    .HasColumnName("ALBUM_ADD_TITLE");

                entity.Property(e => e.AlbumAddType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ALBUM_ADD_TYPE");

                entity.Property(e => e.AlbumCallNo)
                    .HasMaxLength(44)
                    .IsUnicode(false)
                    .HasColumnName("ALBUM_CALL_NO");

                entity.Property(e => e.AlbumGlobalTitle)
                    .HasMaxLength(300)
                    .HasColumnName("ALBUM_GLOBAL_TITLE");

                entity.Property(e => e.AlbumId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ALBUM_ID");

                entity.Property(e => e.AlbumImagePath)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("ALBUM_IMAGE_PATH");

                entity.Property(e => e.AlbumMemo)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("ALBUM_MEMO");

                entity.Property(e => e.AlbumReleaseDate)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ALBUM_RELEASE_DATE")
                    .IsFixedLength();

                entity.Property(e => e.AlbumRentalStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ALBUM_RENTAL_STATUS");

                entity.Property(e => e.AlbumSeqNo)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ALBUM_SEQ_NO");

                entity.Property(e => e.AlbumStockLocation)
                    .HasMaxLength(403)
                    .IsUnicode(false)
                    .HasColumnName("ALBUM_STOCK_LOCATION");

                entity.Property(e => e.AlbumStockMainLocation)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ALBUM_STOCK_MAIN_LOCATION");

                entity.Property(e => e.AlbumStockMiddleLocation)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ALBUM_STOCK_MIDDLE_LOCATION");

                entity.Property(e => e.AlbumTitle)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ALBUM_TITLE");

                entity.Property(e => e.AlbumType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ALBUM_TYPE");

                entity.Property(e => e.Arranger)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ARRANGER");

                entity.Property(e => e.ArtistId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ARTIST_ID");

                entity.Property(e => e.ArtistName)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("ARTIST_NAME");

                entity.Property(e => e.CateCode)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CATE_CODE");

                entity.Property(e => e.CateCodeName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CATE_CODE_NAME");

                entity.Property(e => e.CateFullName)
                    .HasMaxLength(403)
                    .IsUnicode(false)
                    .HasColumnName("CATE_FULL_NAME");

                entity.Property(e => e.CateParentCode)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CATE_PARENT_CODE");

                entity.Property(e => e.CateRootCode)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CATE_ROOT_CODE");

                entity.Property(e => e.Composer)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("COMPOSER");

                entity.Property(e => e.DlCnt)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DL_CNT");

                entity.Property(e => e.Duration)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("DURATION")
                    .IsFixedLength();

                entity.Property(e => e.Editdate)
                    .HasColumnType("DATE")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Genre)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("GENRE");

                entity.Property(e => e.Grade)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GRADE");

                entity.Property(e => e.GradeName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("GRADE_NAME");

                entity.Property(e => e.InstId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INST_ID");

                entity.Property(e => e.InstName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("INST_NAME");

                entity.Property(e => e.InstOrder)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INST_ORDER");

                entity.Property(e => e.IntlTitle)
                    .HasMaxLength(300)
                    .HasColumnName("INTL_TITLE");

                entity.Property(e => e.Istitle)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ISTITLE");

                entity.Property(e => e.IstitleName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ISTITLE_NAME");

                entity.Property(e => e.Keyword)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("KEYWORD");

                entity.Property(e => e.LbhCnt)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LBH_CNT");

                entity.Property(e => e.LikeCnt)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LIKE_CNT");

                entity.Property(e => e.Lyricist)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("LYRICIST");

                entity.Property(e => e.Lyrics)
                    .IsUnicode(false)
                    .HasColumnName("LYRICS");

                entity.Property(e => e.Memo)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("MEMO");

                entity.Property(e => e.MstInfo)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("MST_INFO");

                entity.Property(e => e.OpusNo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("OPUS_NO");

                entity.Property(e => e.Receiving)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("RECEIVING");

                entity.Property(e => e.ReceivingName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("RECEIVING_NAME");

                entity.Property(e => e.Regdate)
                    .HasColumnType("DATE")
                    .HasColumnName("REGDATE");

                entity.Property(e => e.RepTitle)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("REP_TITLE");

                entity.Property(e => e.SongId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("SONG_ID")
                    .IsFixedLength();

                entity.Property(e => e.SongPath)
                    .HasMaxLength(1200)
                    .IsUnicode(false)
                    .HasColumnName("SONG_PATH");

                entity.Property(e => e.SongTag)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("SONG_TAG");

                entity.Property(e => e.Track)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TRACK");

                entity.Property(e => e.Type)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TYPE");

                entity.Property(e => e.TypeName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("TYPE_NAME");
            });

            modelBuilder.Entity<MpsVwSongCore>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MPS_VW_SONG_CORE");

                entity.Property(e => e.AddArtist)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ARTIST");

                entity.Property(e => e.AddTitle)
                    .HasMaxLength(600)
                    .IsUnicode(false)
                    .HasColumnName("ADD_TITLE");

                entity.Property(e => e.Agency)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("AGENCY");

                entity.Property(e => e.AlbumAddTitle)
                    .HasMaxLength(600)
                    .IsUnicode(false)
                    .HasColumnName("ALBUM_ADD_TITLE");

                entity.Property(e => e.AlbumAddType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ALBUM_ADD_TYPE");

                entity.Property(e => e.AlbumCallNo)
                    .HasMaxLength(44)
                    .IsUnicode(false)
                    .HasColumnName("ALBUM_CALL_NO");

                entity.Property(e => e.AlbumGlobalTitle)
                    .HasMaxLength(300)
                    .HasColumnName("ALBUM_GLOBAL_TITLE");

                entity.Property(e => e.AlbumId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ALBUM_ID");

                entity.Property(e => e.AlbumImagePath)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("ALBUM_IMAGE_PATH");

                entity.Property(e => e.AlbumMemo)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("ALBUM_MEMO");

                entity.Property(e => e.AlbumReleaseDate)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ALBUM_RELEASE_DATE")
                    .IsFixedLength();

                entity.Property(e => e.AlbumRentalStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ALBUM_RENTAL_STATUS");

                entity.Property(e => e.AlbumSeqNo)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ALBUM_SEQ_NO");

                entity.Property(e => e.AlbumStockLocation)
                    .HasMaxLength(403)
                    .IsUnicode(false)
                    .HasColumnName("ALBUM_STOCK_LOCATION");

                entity.Property(e => e.AlbumStockMainLocation)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ALBUM_STOCK_MAIN_LOCATION");

                entity.Property(e => e.AlbumStockMiddleLocation)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ALBUM_STOCK_MIDDLE_LOCATION");

                entity.Property(e => e.AlbumTitle)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ALBUM_TITLE");

                entity.Property(e => e.AlbumType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ALBUM_TYPE");

                entity.Property(e => e.Arranger)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ARRANGER");

                entity.Property(e => e.ArtistId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ARTIST_ID");

                entity.Property(e => e.ArtistName)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("ARTIST_NAME");

                entity.Property(e => e.CateCode)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CATE_CODE");

                entity.Property(e => e.CateCodeName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CATE_CODE_NAME");

                entity.Property(e => e.CateFullName)
                    .HasMaxLength(403)
                    .IsUnicode(false)
                    .HasColumnName("CATE_FULL_NAME");

                entity.Property(e => e.CateParentCode)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CATE_PARENT_CODE");

                entity.Property(e => e.CateRootCode)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CATE_ROOT_CODE");

                entity.Property(e => e.Composer)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("COMPOSER");

                entity.Property(e => e.DlCnt)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DL_CNT");

                entity.Property(e => e.Duration)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("DURATION")
                    .IsFixedLength();

                entity.Property(e => e.Editdate)
                    .HasColumnType("DATE")
                    .HasColumnName("EDITDATE");

                entity.Property(e => e.Genre)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("GENRE");

                entity.Property(e => e.Grade)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GRADE");

                entity.Property(e => e.GradeName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("GRADE_NAME");

                entity.Property(e => e.InstId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INST_ID");

                entity.Property(e => e.InstName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("INST_NAME");

                entity.Property(e => e.InstOrder)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INST_ORDER");

                entity.Property(e => e.IntlTitle)
                    .HasMaxLength(300)
                    .HasColumnName("INTL_TITLE");

                entity.Property(e => e.Istitle)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ISTITLE");

                entity.Property(e => e.IstitleName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ISTITLE_NAME");

                entity.Property(e => e.LbhCnt)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LBH_CNT");

                entity.Property(e => e.LikeCnt)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LIKE_CNT");

                entity.Property(e => e.Lyricist)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("LYRICIST");

                entity.Property(e => e.Lyrics)
                    .IsUnicode(false)
                    .HasColumnName("LYRICS");

                entity.Property(e => e.Memo)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("MEMO");

                entity.Property(e => e.MstInfo)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("MST_INFO");

                entity.Property(e => e.OpusNo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("OPUS_NO");

                entity.Property(e => e.Receiving)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("RECEIVING");

                entity.Property(e => e.ReceivingName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("RECEIVING_NAME");

                entity.Property(e => e.Regdate)
                    .HasColumnType("DATE")
                    .HasColumnName("REGDATE");

                entity.Property(e => e.RepTitle)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("REP_TITLE");

                entity.Property(e => e.SongId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("SONG_ID")
                    .IsFixedLength();

                entity.Property(e => e.SongPath)
                    .HasMaxLength(1200)
                    .IsUnicode(false)
                    .HasColumnName("SONG_PATH");

                entity.Property(e => e.SongTag)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("SONG_TAG");

                entity.Property(e => e.Track)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TRACK");

                entity.Property(e => e.Type)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TYPE");

                entity.Property(e => e.TypeName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("TYPE_NAME");
            });

            modelBuilder.Entity<MpsVwSongHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MPS_VW_SONG_HISTORY");

                entity.Property(e => e.LbhDay3)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LBH_DAY3");

                entity.Property(e => e.LbhToday)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LBH_TODAY");

                entity.Property(e => e.LbhWeek1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LBH_WEEK1");

                entity.Property(e => e.LbhWeek2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("LBH_WEEK2");

                entity.Property(e => e.SongId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("SONG_ID");
            });

            modelBuilder.Entity<MpsVwSongSearch>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MPS_VW_SONG_SEARCH");

                entity.Property(e => e.AlbumAddTitle)
                    .HasMaxLength(600)
                    .IsUnicode(false)
                    .HasColumnName("ALBUM_ADD_TITLE");

                entity.Property(e => e.AlbumClassCode)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ALBUM_CLASS_CODE");

                entity.Property(e => e.AlbumId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ALBUM_ID");

                entity.Property(e => e.AlbumImagePath)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("ALBUM_IMAGE_PATH");

                entity.Property(e => e.AlbumLoanStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ALBUM_LOAN_STATUS");

                entity.Property(e => e.AlbumMemo)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("ALBUM_MEMO");

                entity.Property(e => e.AlbumRegdate)
                    .HasColumnType("DATE")
                    .HasColumnName("ALBUM_REGDATE");

                entity.Property(e => e.AlbumRelyear)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ALBUM_RELYEAR")
                    .IsFixedLength();

                entity.Property(e => e.AlbumRepTitle)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ALBUM_REP_TITLE");

                entity.Property(e => e.SongAddTitle)
                    .HasMaxLength(600)
                    .IsUnicode(false)
                    .HasColumnName("SONG_ADD_TITLE");

                entity.Property(e => e.SongArranger)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SONG_ARRANGER");

                entity.Property(e => e.SongArtistAddName)
                    .HasMaxLength(3002)
                    .IsUnicode(false)
                    .HasColumnName("SONG_ARTIST_ADD_NAME");

                entity.Property(e => e.SongArtistId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SONG_ARTIST_ID");

                entity.Property(e => e.SongArtistRepName)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("SONG_ARTIST_REP_NAME");

                entity.Property(e => e.SongClassCode)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SONG_CLASS_CODE");

                entity.Property(e => e.SongComposer)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("SONG_COMPOSER");

                entity.Property(e => e.SongDlCnt)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SONG_DL_CNT");

                entity.Property(e => e.SongDuration)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("SONG_DURATION")
                    .IsFixedLength();

                entity.Property(e => e.SongEditdate)
                    .HasColumnType("DATE")
                    .HasColumnName("SONG_EDITDATE");

                entity.Property(e => e.SongFilename)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SONG_FILENAME");

                entity.Property(e => e.SongFilepath)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("SONG_FILEPATH");

                entity.Property(e => e.SongId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("SONG_ID")
                    .IsFixedLength();

                entity.Property(e => e.SongIstitle)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SONG_ISTITLE");

                entity.Property(e => e.SongLikeCnt)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SONG_LIKE_CNT");

                entity.Property(e => e.SongLyricist)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SONG_LYRICIST");

                entity.Property(e => e.SongLyrics)
                    .IsUnicode(false)
                    .HasColumnName("SONG_LYRICS");

                entity.Property(e => e.SongRegdate)
                    .HasColumnType("DATE")
                    .HasColumnName("SONG_REGDATE");

                entity.Property(e => e.SongRepTitle)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SONG_REP_TITLE");

                entity.Property(e => e.SongTrack)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SONG_TRACK");
            });

            modelBuilder.Entity<Notice>(entity =>
            {
                entity.HasKey(e => e.NotcId)
                    .HasName("SYS_C0053717");

                entity.ToTable("NOTICE");

                entity.Property(e => e.NotcId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("NOTC_ID");

                entity.Property(e => e.NotcCheck)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NOTC_CHECK")
                    .IsFixedLength();

                entity.Property(e => e.NotcContent)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("NOTC_CONTENT");

                entity.Property(e => e.NotcEdate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("NOTC_EDATE")
                    .IsFixedLength();

                entity.Property(e => e.NotcReceiver)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("NOTC_RECEIVER");

                entity.Property(e => e.NotcRegdate)
                    .HasColumnType("DATE")
                    .HasColumnName("NOTC_REGDATE");

                entity.Property(e => e.NotcSdate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("NOTC_SDATE")
                    .IsFixedLength();

                entity.Property(e => e.NotcSender)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("NOTC_SENDER");

                entity.Property(e => e.NotcTitle)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NOTC_TITLE");

                entity.Property(e => e.NotcType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NOTC_TYPE")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Permissionchangelog>(entity =>
            {
                entity.HasKey(e => e.PermissionLogId)
                    .HasName("PK_PERMISSION_CHANGE_LOG");

                entity.ToTable("PERMISSIONCHANGELOG");

                entity.Property(e => e.PermissionLogId)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("PERMISSION_LOG_ID");

                entity.Property(e => e.AccessIp)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ACCESS_IP");

                entity.Property(e => e.PermissionChangeDetail)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PERMISSION_CHANGE_DETAIL");

                entity.Property(e => e.ProcessedDatetime)
                    .HasColumnType("DATE")
                    .HasColumnName("PROCESSED_DATETIME")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP ");

                entity.Property(e => e.SubjectId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SUBJECT_ID");

                entity.Property(e => e.SubjectName)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SUBJECT_NAME");

                entity.Property(e => e.UserId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("USER_ID");
            });

            modelBuilder.Entity<Program>(entity =>
            {
                entity.HasKey(e => new { e.PrgmAreaid, e.PrgmMedaid, e.PrgmId })
                    .HasName("SYS_C0053743");

                entity.ToTable("PROGRAM");

                entity.Property(e => e.PrgmAreaid)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("PRGM_AREAID")
                    .IsFixedLength();

                entity.Property(e => e.PrgmMedaid)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PRGM_MEDAID")
                    .IsFixedLength();

                entity.Property(e => e.PrgmId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PRGM_ID");

                entity.Property(e => e.PrgmBrdtime)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("PRGM_BRDTIME")
                    .IsFixedLength();

                entity.Property(e => e.PrgmBrdtype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PRGM_BRDTYPE")
                    .IsFixedLength();

                entity.Property(e => e.PrgmChkdate)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PRGM_CHKDATE")
                    .IsFixedLength();

                entity.Property(e => e.PrgmCtrlid1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PRGM_CTRLID1");

                entity.Property(e => e.PrgmCtrlid2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PRGM_CTRLID2");

                entity.Property(e => e.PrgmEdate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("PRGM_EDATE")
                    .IsFixedLength();

                entity.Property(e => e.PrgmFadein)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PRGM_FADEIN");

                entity.Property(e => e.PrgmFadeout)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PRGM_FADEOUT");

                entity.Property(e => e.PrgmLevel)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PRGM_LEVEL");

                entity.Property(e => e.PrgmMemo)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PRGM_MEMO");

                entity.Property(e => e.PrgmParentid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PRGM_PARENTID");

                entity.Property(e => e.PrgmPgtype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PRGM_PGTYPE")
                    .IsFixedLength();

                entity.Property(e => e.PrgmRegdate)
                    .HasColumnType("DATE")
                    .HasColumnName("PRGM_REGDATE");

                entity.Property(e => e.PrgmRelay)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PRGM_RELAY")
                    .IsFixedLength();

                entity.Property(e => e.PrgmRuntime)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("PRGM_RUNTIME")
                    .IsFixedLength();

                entity.Property(e => e.PrgmSdate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("PRGM_SDATE")
                    .IsFixedLength();

                entity.Property(e => e.PrgmTimed)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PRGM_TIMED")
                    .IsFixedLength();

                entity.Property(e => e.PrgmTitle)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PRGM_TITLE");

                entity.Property(e => e.PrgmTrtype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PRGM_TRTYPE")
                    .IsFixedLength();

                entity.Property(e => e.PrgmUsed)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PRGM_USED")
                    .IsFixedLength();

                entity.Property(e => e.PrgmUsernum)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PRGM_USERNUM");

                entity.Property(e => e.PrgmWeek1)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PRGM_WEEK1")
                    .IsFixedLength();

                entity.Property(e => e.PrgmWeek2)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PRGM_WEEK2")
                    .IsFixedLength();

                entity.Property(e => e.PrgmWeek3)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PRGM_WEEK3")
                    .IsFixedLength();

                entity.Property(e => e.PrgmWeek4)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PRGM_WEEK4")
                    .IsFixedLength();

                entity.Property(e => e.PrgmWeek5)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PRGM_WEEK5")
                    .IsFixedLength();

                entity.Property(e => e.PrgmWeek6)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PRGM_WEEK6")
                    .IsFixedLength();

                entity.Property(e => e.PrgmWeek7)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PRGM_WEEK7")
                    .IsFixedLength();

                entity.HasOne(d => d.PrgmArea)
                    .WithMany(p => p.Programs)
                    .HasForeignKey(d => d.PrgmAreaid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C0053893");

                entity.HasOne(d => d.PrgmCtrlid1Navigation)
                    .WithMany(p => p.Programs)
                    .HasForeignKey(d => d.PrgmCtrlid1)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C0053906");

                entity.HasOne(d => d.PrgmMeda)
                    .WithMany(p => p.Programs)
                    .HasForeignKey(d => d.PrgmMedaid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C0053922");

                entity.HasOne(d => d.PrgmUsernumNavigation)
                    .WithMany(p => p.Programs)
                    .HasForeignKey(d => d.PrgmUsernum)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C0053985");
            });

            modelBuilder.Entity<Programalias>(entity =>
            {
                entity.HasKey(e => new { e.PrgmaliasAreaid, e.PrgmaliasMedaid, e.PrgmaliasId })
                    .HasName("SYS_C0053748");

                entity.ToTable("PROGRAMALIAS");

                entity.Property(e => e.PrgmaliasAreaid)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("PRGMALIAS_AREAID")
                    .IsFixedLength();

                entity.Property(e => e.PrgmaliasMedaid)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PRGMALIAS_MEDAID")
                    .IsFixedLength();

                entity.Property(e => e.PrgmaliasId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PRGMALIAS_ID");

                entity.Property(e => e.PrgmaliasAlias)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PRGMALIAS_ALIAS");

                entity.Property(e => e.PrgmaliasRegdate)
                    .HasColumnType("DATE")
                    .HasColumnName("PRGMALIAS_REGDATE");

                entity.HasOne(d => d.PrgmaliasArea)
                    .WithMany(p => p.Programaliases)
                    .HasForeignKey(d => d.PrgmaliasAreaid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C0053889");

                entity.HasOne(d => d.PrgmaliasMeda)
                    .WithMany(p => p.Programaliases)
                    .HasForeignKey(d => d.PrgmaliasMedaid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C0053919");
            });

            modelBuilder.Entity<RbtSongForSearchEngine>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RBT_Song_For_SearchEngine");

                entity.Property(e => e.SongArtist1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SONG_ARTIST1");

                entity.Property(e => e.SongArtist2)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SONG_ARTIST2");

                entity.Property(e => e.SongArtist3)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SONG_ARTIST3");

                entity.Property(e => e.SongArtist4)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SONG_ARTIST4");

                entity.Property(e => e.SongDowncnt)
                    .HasColumnType("NUMBER(38,38)")
                    .HasColumnName("SONG_DOWNCNT");

                entity.Property(e => e.SongId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("SONG_ID")
                    .IsFixedLength();

                entity.Property(e => e.SongTitle1)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SONG_TITLE1");
            });

            modelBuilder.Entity<Recprogram>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("SYS_C0053762");

                entity.ToTable("RECPROGRAM");

                entity.Property(e => e.RecId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("REC_ID")
                    .IsFixedLength();

                entity.Property(e => e.RecBrddate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("REC_BRDDATE")
                    .IsFixedLength();

                entity.Property(e => e.RecBrdtime)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("REC_BRDTIME")
                    .IsFixedLength();

                entity.Property(e => e.RecClipid)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("REC_CLIPID");

                entity.Property(e => e.RecDuration)
                    .HasColumnType("NUMBER")
                    .HasColumnName("REC_DURATION")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.RecFilename)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("REC_FILENAME");

                entity.Property(e => e.RecFilepath)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("REC_FILEPATH");

                entity.Property(e => e.RecMemo)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("REC_MEMO");

                entity.Property(e => e.RecPrgmareaid)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("REC_PRGMAREAID")
                    .IsFixedLength();

                entity.Property(e => e.RecPrgmid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("REC_PRGMID");

                entity.Property(e => e.RecPrgmmedaid)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REC_PRGMMEDAID")
                    .IsFixedLength();

                entity.Property(e => e.RecRegdate)
                    .HasColumnType("DATE")
                    .HasColumnName("REC_REGDATE");

                entity.Property(e => e.RecRuntime)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("REC_RUNTIME")
                    .IsFixedLength();

                entity.Property(e => e.RecTitle)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("REC_TITLE");

                entity.Property(e => e.RecUsed)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REC_USED")
                    .IsFixedLength();

                entity.Property(e => e.RecUsernum)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("REC_USERNUM");

                entity.HasOne(d => d.RecUsernumNavigation)
                    .WithMany(p => p.Recprograms)
                    .HasForeignKey(d => d.RecUsernum)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C0053984");

                entity.HasOne(d => d.RecPrgm)
                    .WithMany(p => p.Recprograms)
                    .HasForeignKey(d => new { d.RecPrgmareaid, d.RecPrgmmedaid, d.RecPrgmid })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C0053961");
            });

            modelBuilder.Entity<Schebasedetail>(entity =>
            {
                entity.HasKey(e => new { e.SbdtScbsseq, e.SbdtScbsareaid, e.SbdtScbsmedaid, e.SbdtScbsweek, e.SbdtNum })
                    .HasName("SYS_C0053781");

                entity.ToTable("SCHEBASEDETAIL");

                entity.Property(e => e.SbdtScbsseq)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SBDT_SCBSSEQ");

                entity.Property(e => e.SbdtScbsareaid)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SBDT_SCBSAREAID")
                    .IsFixedLength();

                entity.Property(e => e.SbdtScbsmedaid)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SBDT_SCBSMEDAID")
                    .IsFixedLength();

                entity.Property(e => e.SbdtScbsweek)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SBDT_SCBSWEEK")
                    .IsFixedLength();

                entity.Property(e => e.SbdtNum)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SBDT_NUM");

                entity.Property(e => e.SbdtBrdtime)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("SBDT_BRDTIME")
                    .IsFixedLength();

                entity.Property(e => e.SbdtBrdtype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SBDT_BRDTYPE")
                    .IsFixedLength();

                entity.Property(e => e.SbdtCmcount)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SBDT_CMCOUNT");

                entity.Property(e => e.SbdtCtrlid1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SBDT_CTRLID1");

                entity.Property(e => e.SbdtCtrlid2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SBDT_CTRLID2");

                entity.Property(e => e.SbdtDiff)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("SBDT_DIFF")
                    .IsFixedLength();

                entity.Property(e => e.SbdtFadein)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SBDT_FADEIN");

                entity.Property(e => e.SbdtFadeout)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SBDT_FADEOUT");

                entity.Property(e => e.SbdtFilename)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SBDT_FILENAME");

                entity.Property(e => e.SbdtFilepath)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("SBDT_FILEPATH");

                entity.Property(e => e.SbdtLevel)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SBDT_LEVEL");

                entity.Property(e => e.SbdtMemo)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SBDT_MEMO");

                entity.Property(e => e.SbdtPgtype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SBDT_PGTYPE")
                    .IsFixedLength();

                entity.Property(e => e.SbdtPrgmid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SBDT_PRGMID");

                entity.Property(e => e.SbdtPrgmprtid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SBDT_PRGMPRTID");

                entity.Property(e => e.SbdtRecord)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SBDT_RECORD");

                entity.Property(e => e.SbdtRuntime)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("SBDT_RUNTIME")
                    .IsFixedLength();

                entity.Property(e => e.SbdtTimed)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SBDT_TIMED")
                    .IsFixedLength();

                entity.Property(e => e.SbdtTitle)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SBDT_TITLE");

                entity.Property(e => e.SbdtToneover)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SBDT_TONEOVER");

                entity.Property(e => e.SbdtToneunder)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SBDT_TONEUNDER");

                entity.Property(e => e.SbdtTrtype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SBDT_TRTYPE")
                    .IsFixedLength();

                entity.HasOne(d => d.SbdtCtrlid1Navigation)
                    .WithMany(p => p.Schebasedetails)
                    .HasForeignKey(d => d.SbdtCtrlid1)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C0053905");

                entity.HasOne(d => d.SbdtScbs)
                    .WithMany(p => p.Schebasedetails)
                    .HasForeignKey(d => new { d.SbdtScbsseq, d.SbdtScbsareaid, d.SbdtScbsmedaid, d.SbdtScbsweek })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C0053965");
            });

            modelBuilder.Entity<Schedaydetail>(entity =>
            {
                entity.HasKey(e => new { e.SddtScdyareaid, e.SddtScdymedaid, e.SddtScdydate, e.SddtNum })
                    .HasName("SYS_C0053800");

                entity.ToTable("SCHEDAYDETAIL");

                entity.Property(e => e.SddtScdyareaid)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SDDT_SCDYAREAID")
                    .IsFixedLength();

                entity.Property(e => e.SddtScdymedaid)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SDDT_SCDYMEDAID")
                    .IsFixedLength();

                entity.Property(e => e.SddtScdydate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("SDDT_SCDYDATE")
                    .IsFixedLength();

                entity.Property(e => e.SddtNum)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SDDT_NUM");

                entity.Property(e => e.SddtBrddate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("SDDT_BRDDATE")
                    .IsFixedLength();

                entity.Property(e => e.SddtBrdtime)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("SDDT_BRDTIME")
                    .IsFixedLength();

                entity.Property(e => e.SddtBrdtype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SDDT_BRDTYPE")
                    .IsFixedLength();

                entity.Property(e => e.SddtCmcount)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SDDT_CMCOUNT");

                entity.Property(e => e.SddtCtrlid1)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SDDT_CTRLID1");

                entity.Property(e => e.SddtCtrlid2)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SDDT_CTRLID2");

                entity.Property(e => e.SddtDiff)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("SDDT_DIFF")
                    .IsFixedLength();

                entity.Property(e => e.SddtFadein)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SDDT_FADEIN");

                entity.Property(e => e.SddtFadeout)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SDDT_FADEOUT");

                entity.Property(e => e.SddtFilename)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SDDT_FILENAME");

                entity.Property(e => e.SddtFilepath)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("SDDT_FILEPATH");

                entity.Property(e => e.SddtLevel)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SDDT_LEVEL");

                entity.Property(e => e.SddtMemo)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SDDT_MEMO");

                entity.Property(e => e.SddtPgtype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SDDT_PGTYPE")
                    .IsFixedLength();

                entity.Property(e => e.SddtPrgmid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SDDT_PRGMID");

                entity.Property(e => e.SddtPrgmprtid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SDDT_PRGMPRTID");

                entity.Property(e => e.SddtRecord)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SDDT_RECORD");

                entity.Property(e => e.SddtRuntime)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("SDDT_RUNTIME")
                    .IsFixedLength();

                entity.Property(e => e.SddtTimed)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SDDT_TIMED")
                    .IsFixedLength();

                entity.Property(e => e.SddtTitle)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SDDT_TITLE");

                entity.Property(e => e.SddtToneover)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SDDT_TONEOVER");

                entity.Property(e => e.SddtToneunder)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SDDT_TONEUNDER");

                entity.Property(e => e.SddtTrtype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SDDT_TRTYPE")
                    .IsFixedLength();

                entity.HasOne(d => d.SddtCtrlid1Navigation)
                    .WithMany(p => p.Schedaydetails)
                    .HasForeignKey(d => d.SddtCtrlid1)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C0053904");

                entity.HasOne(d => d.SddtScdy)
                    .WithMany(p => p.Schedaydetails)
                    .HasForeignKey(d => new { d.SddtScdyareaid, d.SddtScdymedaid, d.SddtScdydate })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C0053966");
            });

            modelBuilder.Entity<Schedulebase>(entity =>
            {
                entity.HasKey(e => new { e.ScbsSeq, e.ScbsAreaid, e.ScbsMedaid, e.ScbsWeek })
                    .HasName("SYS_C0053810");

                entity.ToTable("SCHEDULEBASE");

                entity.Property(e => e.ScbsSeq)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SCBS_SEQ");

                entity.Property(e => e.ScbsAreaid)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SCBS_AREAID")
                    .IsFixedLength();

                entity.Property(e => e.ScbsMedaid)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SCBS_MEDAID")
                    .IsFixedLength();

                entity.Property(e => e.ScbsWeek)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SCBS_WEEK")
                    .IsFixedLength();

                entity.Property(e => e.ScbsEdate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("SCBS_EDATE")
                    .IsFixedLength();

                entity.Property(e => e.ScbsMemo)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SCBS_MEMO");

                entity.Property(e => e.ScbsRegdate)
                    .HasColumnType("DATE")
                    .HasColumnName("SCBS_REGDATE");

                entity.Property(e => e.ScbsSdate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("SCBS_SDATE")
                    .IsFixedLength();

                entity.Property(e => e.ScbsTitle)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SCBS_TITLE");

                entity.Property(e => e.ScbsType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SCBS_TYPE")
                    .IsFixedLength();

                entity.Property(e => e.ScbsUsernum)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SCBS_USERNUM");

                entity.Property(e => e.ScbsWritable)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SCBS_WRITABLE");

                entity.HasOne(d => d.ScbsArea)
                    .WithMany(p => p.Schedulebases)
                    .HasForeignKey(d => d.ScbsAreaid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C0053892");

                entity.HasOne(d => d.ScbsMeda)
                    .WithMany(p => p.Schedulebases)
                    .HasForeignKey(d => d.ScbsMedaid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C0053921");

                entity.HasOne(d => d.ScbsUsernumNavigation)
                    .WithMany(p => p.Schedulebases)
                    .HasForeignKey(d => d.ScbsUsernum)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C0053983");
            });

            modelBuilder.Entity<Scheduleday>(entity =>
            {
                entity.HasKey(e => new { e.ScdyAreaid, e.ScdyMedaid, e.ScdyDate })
                    .HasName("SYS_C0053817");

                entity.ToTable("SCHEDULEDAY");

                entity.Property(e => e.ScdyAreaid)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SCDY_AREAID")
                    .IsFixedLength();

                entity.Property(e => e.ScdyMedaid)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SCDY_MEDAID")
                    .IsFixedLength();

                entity.Property(e => e.ScdyDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("SCDY_DATE")
                    .IsFixedLength();

                entity.Property(e => e.ScdyRegdate)
                    .HasColumnType("DATE")
                    .HasColumnName("SCDY_REGDATE");

                entity.Property(e => e.ScdyType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SCDY_TYPE")
                    .IsFixedLength();

                entity.Property(e => e.ScdyUsernum)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SCDY_USERNUM");

                entity.Property(e => e.ScdyWritable)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SCDY_WRITABLE");

                entity.HasOne(d => d.ScdyArea)
                    .WithMany(p => p.Scheduledays)
                    .HasForeignKey(d => d.ScdyAreaid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C0053891");

                entity.HasOne(d => d.ScdyMeda)
                    .WithMany(p => p.Scheduledays)
                    .HasForeignKey(d => d.ScdyMedaid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C0053920");

                entity.HasOne(d => d.ScdyUsernumNavigation)
                    .WithMany(p => p.Scheduledays)
                    .HasForeignKey(d => d.ScdyUsernum)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C0053982");
            });

            modelBuilder.Entity<Scheduledaycheck>(entity =>
            {
                entity.HasKey(e => e.ScdycheckId)
                    .HasName("SYS_C0053822");

                entity.ToTable("SCHEDULEDAYCHECK");

                entity.Property(e => e.ScdycheckId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SCDYCHECK_ID");

                entity.Property(e => e.ScdycheckAreaid)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SCDYCHECK_AREAID")
                    .IsFixedLength();

                entity.Property(e => e.ScdycheckChecked)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SCDYCHECK_CHECKED")
                    .IsFixedLength();

                entity.Property(e => e.ScdycheckDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("SCDYCHECK_DATE")
                    .IsFixedLength();

                entity.Property(e => e.ScdycheckMedaid)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SCDYCHECK_MEDAID")
                    .IsFixedLength();

                entity.Property(e => e.ScdycheckRegdate)
                    .HasColumnType("DATE")
                    .HasColumnName("SCDYCHECK_REGDATE");

                entity.HasOne(d => d.ScdycheckArea)
                    .WithMany(p => p.Scheduledaychecks)
                    .HasForeignKey(d => d.ScdycheckAreaid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C0053888");

                entity.HasOne(d => d.ScdycheckMeda)
                    .WithMany(p => p.Scheduledaychecks)
                    .HasForeignKey(d => d.ScdycheckMedaid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C0053918");
            });

            modelBuilder.Entity<Screeninfo>(entity =>
            {
                entity.HasKey(e => e.ScrnId)
                    .HasName("SYS_C0053825");

                entity.ToTable("SCREENINFO");

                entity.Property(e => e.ScrnId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SCRN_ID");

                entity.Property(e => e.ScrnName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SCRN_NAME");

                entity.Property(e => e.ScrnOrder)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SCRN_ORDER");
            });

            modelBuilder.Entity<Song>(entity =>
            {
                entity.ToTable("SONG");

                entity.Property(e => e.SongId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SONG_ID")
                    .IsFixedLength();

                entity.Property(e => e.SongAlbmid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SONG_ALBMID");

                entity.Property(e => e.SongAlbmtrack)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SONG_ALBMTRACK");

                entity.Property(e => e.SongAreaid)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SONG_AREAID")
                    .IsFixedLength();

                entity.Property(e => e.SongArranger)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SONG_ARRANGER");

                entity.Property(e => e.SongArtist1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SONG_ARTIST1");

                entity.Property(e => e.SongArtist10)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SONG_ARTIST10");

                entity.Property(e => e.SongArtist2)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SONG_ARTIST2");

                entity.Property(e => e.SongArtist3)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SONG_ARTIST3");

                entity.Property(e => e.SongArtist4)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SONG_ARTIST4");

                entity.Property(e => e.SongArtist5)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SONG_ARTIST5");

                entity.Property(e => e.SongArtist6)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SONG_ARTIST6");

                entity.Property(e => e.SongArtist7)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SONG_ARTIST7");

                entity.Property(e => e.SongArtist8)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SONG_ARTIST8");

                entity.Property(e => e.SongArtist9)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SONG_ARTIST9");

                entity.Property(e => e.SongBitrate)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SONG_BITRATE");

                entity.Property(e => e.SongClipid)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SONG_CLIPID");

                entity.Property(e => e.SongComposer)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SONG_COMPOSER");

                entity.Property(e => e.SongDowncnt)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SONG_DOWNCNT")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SongDowndate)
                    .HasColumnType("DATE")
                    .HasColumnName("SONG_DOWNDATE");

                entity.Property(e => e.SongDuration)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SONG_DURATION")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.SongFilename)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SONG_FILENAME");

                entity.Property(e => e.SongFilepath)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("SONG_FILEPATH");

                entity.Property(e => e.SongForbidden)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SONG_FORBIDDEN")
                    .IsFixedLength();

                entity.Property(e => e.SongFormat)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SONG_FORMAT");

                entity.Property(e => e.SongFreq)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SONG_FREQ");

                entity.Property(e => e.SongHityear)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SONG_HITYEAR")
                    .IsFixedLength();

                entity.Property(e => e.SongImgpath)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("SONG_IMGPATH");

                entity.Property(e => e.SongKeyword1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SONG_KEYWORD1");

                entity.Property(e => e.SongKeyword2)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SONG_KEYWORD2");

                entity.Property(e => e.SongKeyword3)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SONG_KEYWORD3");

                entity.Property(e => e.SongKeyword4)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SONG_KEYWORD4");

                entity.Property(e => e.SongLang)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("SONG_LANG");

                entity.Property(e => e.SongLyrics)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("SONG_LYRICS");

                entity.Property(e => e.SongLyricslobCbs)
                    .HasColumnType("BLOB")
                    .HasColumnName("SONG_LYRICSLOB_CBS");

                entity.Property(e => e.SongMemo)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("SONG_MEMO");

                entity.Property(e => e.SongMode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SONG_MODE")
                    .IsFixedLength();

                entity.Property(e => e.SongMusist1)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SONG_MUSIST1")
                    .IsFixedLength();

                entity.Property(e => e.SongMusist10)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SONG_MUSIST10")
                    .IsFixedLength();

                entity.Property(e => e.SongMusist2)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SONG_MUSIST2")
                    .IsFixedLength();

                entity.Property(e => e.SongMusist3)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SONG_MUSIST3")
                    .IsFixedLength();

                entity.Property(e => e.SongMusist4)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SONG_MUSIST4")
                    .IsFixedLength();

                entity.Property(e => e.SongMusist5)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SONG_MUSIST5")
                    .IsFixedLength();

                entity.Property(e => e.SongMusist6)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SONG_MUSIST6")
                    .IsFixedLength();

                entity.Property(e => e.SongMusist7)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SONG_MUSIST7")
                    .IsFixedLength();

                entity.Property(e => e.SongMusist8)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SONG_MUSIST8")
                    .IsFixedLength();

                entity.Property(e => e.SongMusist9)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SONG_MUSIST9")
                    .IsFixedLength();

                entity.Property(e => e.SongOmnidiv)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SONG_OMNIDIV")
                    .IsFixedLength();

                entity.Property(e => e.SongPlaytype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SONG_PLAYTYPE")
                    .IsFixedLength();

                entity.Property(e => e.SongRecdate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("SONG_RECDATE")
                    .IsFixedLength();

                entity.Property(e => e.SongRegdate)
                    .HasColumnType("DATE")
                    .HasColumnName("SONG_REGDATE");

                entity.Property(e => e.SongRuntime)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("SONG_RUNTIME")
                    .IsFixedLength();

                entity.Property(e => e.SongSbigid)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SONG_SBIGID")
                    .IsFixedLength();

                entity.Property(e => e.SongSerno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SONG_SERNO");

                entity.Property(e => e.SongServicetitleCbs)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SONG_SERVICETITLE_CBS");

                entity.Property(e => e.SongSmidid)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SONG_SMIDID")
                    .IsFixedLength();

                entity.Property(e => e.SongSsmlid)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SONG_SSMLID")
                    .IsFixedLength();

                entity.Property(e => e.SongTag)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("SONG_TAG");

                entity.Property(e => e.SongTitle1)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SONG_TITLE1");

                entity.Property(e => e.SongTitle2)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SONG_TITLE2");

                entity.Property(e => e.SongTitle3)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SONG_TITLE3");

                entity.Property(e => e.SongTitle4)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SONG_TITLE4");

                entity.Property(e => e.SongTitlesong)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SONG_TITLESONG")
                    .IsFixedLength();

                entity.Property(e => e.SongUsed)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SONG_USED")
                    .IsFixedLength();

                entity.Property(e => e.SongUsernum)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SONG_USERNUM");

                entity.Property(e => e.SongWriter)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SONG_WRITER");

                entity.HasOne(d => d.SongArea)
                    .WithMany(p => p.Songs)
                    .HasForeignKey(d => d.SongAreaid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C0053890");

                entity.HasOne(d => d.SongSbig)
                    .WithMany(p => p.Songs)
                    .HasForeignKey(d => d.SongSbigid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C0053971");

                entity.HasOne(d => d.SongUsernumNavigation)
                    .WithMany(p => p.Songs)
                    .HasForeignKey(d => d.SongUsernum)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C0053981");
            });

            modelBuilder.Entity<Songartistcode>(entity =>
            {
                entity.HasKey(e => e.SatcCode)
                    .HasName("SYS_C0053836");

                entity.ToTable("SONGARTISTCODE");

                entity.Property(e => e.SatcCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("SATC_CODE")
                    .IsFixedLength();

                entity.Property(e => e.SatcDiv)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SATC_DIV")
                    .IsFixedLength();

                entity.Property(e => e.SatcEngname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SATC_ENGNAME");

                entity.Property(e => e.SatcKorname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SATC_KORNAME");

                entity.Property(e => e.SatcRegdate)
                    .HasColumnType("DATE")
                    .HasColumnName("SATC_REGDATE");

                entity.Property(e => e.SatcUsernum)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SATC_USERNUM");

                entity.HasOne(d => d.SatcUsernumNavigation)
                    .WithMany(p => p.Songartistcodes)
                    .HasForeignKey(d => d.SatcUsernum)
                    .HasConstraintName("SYS_C0053978");
            });

            modelBuilder.Entity<Songbigcode>(entity =>
            {
                entity.HasKey(e => e.SbigId)
                    .HasName("SYS_C0053839");

                entity.ToTable("SONGBIGCODE");

                entity.Property(e => e.SbigId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SBIG_ID")
                    .IsFixedLength();

                entity.Property(e => e.SbigName)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("SBIG_NAME");

                entity.Property(e => e.SbigOrder)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SBIG_ORDER");

                entity.Property(e => e.SbigUsed)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SBIG_USED")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Songlog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SONGLOG");

                entity.Property(e => e.SlogDate)
                    .HasColumnType("DATE")
                    .HasColumnName("SLOG_DATE");

                entity.Property(e => e.SlogPrgmareaid)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SLOG_PRGMAREAID")
                    .IsFixedLength();

                entity.Property(e => e.SlogPrgmid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SLOG_PRGMID");

                entity.Property(e => e.SlogPrgmmedaid)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SLOG_PRGMMEDAID")
                    .IsFixedLength();

                entity.Property(e => e.SlogSongid)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("SLOG_SONGID")
                    .IsFixedLength();

                entity.Property(e => e.SlogUsernum)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SLOG_USERNUM");

                entity.HasOne(d => d.SlogSong)
                    .WithMany()
                    .HasForeignKey(d => d.SlogSongid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C0053968");

                entity.HasOne(d => d.SlogUsernumNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.SlogUsernum)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C0053977");

                entity.HasOne(d => d.SlogPrgm)
                    .WithMany()
                    .HasForeignKey(d => new { d.SlogPrgmareaid, d.SlogPrgmmedaid, d.SlogPrgmid })
                    .HasConstraintName("SYS_C0053959");
            });

            modelBuilder.Entity<Songmiddcode>(entity =>
            {
                entity.HasKey(e => new { e.SmidSbigid, e.SmidId })
                    .HasName("SYS_C0053846");

                entity.ToTable("SONGMIDDCODE");

                entity.Property(e => e.SmidSbigid)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SMID_SBIGID")
                    .IsFixedLength();

                entity.Property(e => e.SmidId)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SMID_ID")
                    .IsFixedLength();

                entity.Property(e => e.SmidName)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("SMID_NAME");

                entity.Property(e => e.SmidOrder)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SMID_ORDER");

                entity.Property(e => e.SmidUsed)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SMID_USED")
                    .IsFixedLength();

                entity.HasOne(d => d.SmidSbig)
                    .WithMany(p => p.Songmiddcodes)
                    .HasForeignKey(d => d.SmidSbigid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C0053970");
            });

            modelBuilder.Entity<Songmusistcode>(entity =>
            {
                entity.HasKey(e => e.SmstCode)
                    .HasName("SYS_C0053849");

                entity.ToTable("SONGMUSISTCODE");

                entity.Property(e => e.SmstCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SMST_CODE")
                    .IsFixedLength();

                entity.Property(e => e.SmstName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SMST_NAME");

                entity.Property(e => e.SmstRegdate)
                    .HasColumnType("DATE")
                    .HasColumnName("SMST_REGDATE");

                entity.Property(e => e.SmstUsernum)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SMST_USERNUM");

                entity.HasOne(d => d.SmstUsernumNavigation)
                    .WithMany(p => p.Songmusistcodes)
                    .HasForeignKey(d => d.SmstUsernum)
                    .HasConstraintName("SYS_C0053976");
            });

            modelBuilder.Entity<Songsmallcode>(entity =>
            {
                entity.HasKey(e => new { e.SsmlSmidid, e.SsmlId })
                    .HasName("SYS_C0053853");

                entity.ToTable("SONGSMALLCODE");

                entity.Property(e => e.SsmlSmidid)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SSML_SMIDID")
                    .IsFixedLength();

                entity.Property(e => e.SsmlId)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SSML_ID")
                    .IsFixedLength();

                entity.Property(e => e.SsmlName)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("SSML_NAME");

                entity.Property(e => e.SsmlOrder)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SSML_ORDER");

                entity.Property(e => e.SsmlSbigid)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SSML_SBIGID")
                    .IsFixedLength();

                entity.Property(e => e.SsmlUsed)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SSML_USED")
                    .IsFixedLength();

                entity.HasOne(d => d.SsmlS)
                    .WithMany(p => p.Songsmallcodes)
                    .HasForeignKey(d => new { d.SsmlSbigid, d.SsmlSmidid })
                    .HasConstraintName("SYS_C0053973");
            });

            modelBuilder.Entity<Stationinfo>(entity =>
            {
                entity.HasKey(e => e.StifIp)
                    .HasName("SYS_C0053857");

                entity.ToTable("STATIONINFO");

                entity.Property(e => e.StifIp)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("STIF_IP");

                entity.Property(e => e.StifLogin)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STIF_LOGIN")
                    .IsFixedLength();

                entity.Property(e => e.StifName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STIF_NAME");

                entity.Property(e => e.StifUsernum)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("STIF_USERNUM")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Synchro>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SYNCHRO");

                entity.Property(e => e.SyncItemid)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("SYNC_ITEMID")
                    .IsFixedLength();

                entity.Property(e => e.SyncRegdate)
                    .HasColumnType("DATE")
                    .HasColumnName("SYNC_REGDATE");

                entity.Property(e => e.SyncTblname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SYNC_TBLNAME");

                entity.Property(e => e.SyncType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SYNC_TYPE")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Taglist>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TAGLIST");

                entity.Property(e => e.TgltFileid)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("TGLT_FILEID");

                entity.Property(e => e.TgltFiletype)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TGLT_FILETYPE")
                    .IsFixedLength();

                entity.Property(e => e.TgltRegdate)
                    .HasColumnType("DATE")
                    .HasColumnName("TGLT_REGDATE");

                entity.Property(e => e.TgltSearchdate)
                    .HasColumnType("DATE")
                    .HasColumnName("TGLT_SEARCHDATE");

                entity.Property(e => e.TgltTitle)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TGLT_TITLE");

                entity.Property(e => e.TgltUsernum)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("TGLT_USERNUM");

                entity.HasOne(d => d.TgltUsernumNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.TgltUsernum)
                    .HasConstraintName("SYS_C0053975");
            });

            modelBuilder.Entity<TempMpsArtist>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_MPS_ARTIST");

                entity.Property(e => e.AddName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ADD_NAME");

                entity.Property(e => e.ArtistId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ARTIST_ID");

                entity.Property(e => e.OldCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("OLD_CODE");

                entity.Property(e => e.OldType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("OLD_TYPE");

                entity.Property(e => e.RepName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("REP_NAME");
            });

            modelBuilder.Entity<TempMpsClass>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_MPS_CLASS");

                entity.Property(e => e.BigCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BIG_CODE")
                    .IsFixedLength();

                entity.Property(e => e.Code)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CODE");

                entity.Property(e => e.CodeName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CODE_NAME");

                entity.Property(e => e.MidCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("MID_CODE")
                    .IsFixedLength();

                entity.Property(e => e.ParentCode)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PARENT_CODE");
            });

            modelBuilder.Entity<TempMpsSongArtAndInstMap>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_MPS_SONG_ART_AND_INST_MAP");

                entity.Property(e => e.ArtistId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ARTIST_ID");

                entity.Property(e => e.InstId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INST_ID");

                entity.Property(e => e.InstOrder)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INST_ORDER");

                entity.Property(e => e.SongId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("SONG_ID")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TempMpsSongArtistIdx>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_MPS_SONG_ARTIST_IDX");

                entity.Property(e => e.ArtistAddName)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("ARTIST_ADD_NAME");

                entity.Property(e => e.ArtistId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ARTIST_ID");

                entity.Property(e => e.ArtistRepName)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("ARTIST_REP_NAME");

                entity.Property(e => e.FeatName)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("FEAT_NAME");

                entity.Property(e => e.SongId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("SONG_ID")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TempMpsSongArtistMap>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_MPS_SONG_ARTIST_MAP");

                entity.Property(e => e.ArtistId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ARTIST_ID");

                entity.Property(e => e.ArtistOrder)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ARTIST_ORDER");

                entity.Property(e => e.SongId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("SONG_ID")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TempMpsSongArtistMinOrder>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_MPS_SONG_ARTIST_MIN_ORDER");

                entity.Property(e => e.ArtistId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ARTIST_ID");

                entity.Property(e => e.ArtistMinOrder)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ARTIST_MIN_ORDER");

                entity.Property(e => e.SongId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("SONG_ID")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TempMpsSongInstMap>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_MPS_SONG_INST_MAP");

                entity.Property(e => e.InstId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INST_ID");

                entity.Property(e => e.InstOrder)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INST_ORDER");

                entity.Property(e => e.SongId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("SONG_ID")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TempMpsSongInstMapFinal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_MPS_SONG_INST_MAP_FINAL");

                entity.Property(e => e.InstId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INST_ID");

                entity.Property(e => e.InstOrder)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INST_ORDER");

                entity.Property(e => e.SongId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("SONG_ID")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TempSongmusistcode>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_SONGMUSISTCODE");

                entity.Property(e => e.SmstCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SMST_CODE")
                    .IsFixedLength();

                entity.Property(e => e.SmstMpscode)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SMST_MPSCODE");

                entity.Property(e => e.SmstName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SMST_NAME");

                entity.Property(e => e.SmstRegdate)
                    .HasColumnType("DATE")
                    .HasColumnName("SMST_REGDATE");

                entity.Property(e => e.SmstUsernum)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SMST_USERNUM");
            });

            modelBuilder.Entity<Usergroup>(entity =>
            {
                entity.HasKey(e => new { e.GrupGrifid, e.GrupScrnid })
                    .HasName("SYS_C0053869");

                entity.ToTable("USERGROUP");

                entity.Property(e => e.GrupGrifid)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("GRUP_GRIFID")
                    .IsFixedLength();

                entity.Property(e => e.GrupScrnid)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("GRUP_SCRNID");

                entity.Property(e => e.GrupDel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GRUP_DEL")
                    .IsFixedLength();

                entity.Property(e => e.GrupRead)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GRUP_READ")
                    .IsFixedLength();

                entity.Property(e => e.GrupWrite)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GRUP_WRITE")
                    .IsFixedLength();

                entity.HasOne(d => d.GrupGrif)
                    .WithMany(p => p.Usergroups)
                    .HasForeignKey(d => d.GrupGrifid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C0053913");

                entity.HasOne(d => d.GrupScrn)
                    .WithMany(p => p.Usergroups)
                    .HasForeignKey(d => d.GrupScrnid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C0053967");
            });

            modelBuilder.Entity<Userinfo>(entity =>
            {
                entity.HasKey(e => e.UserNum)
                    .HasName("SYS_C0053879");

                entity.ToTable("USERINFO");

                entity.Property(e => e.UserNum)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("USER_NUM");

                entity.Property(e => e.UserAreaid)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("USER_AREAID")
                    .IsFixedLength();

                entity.Property(e => e.UserDvshid)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("USER_DVSHID")
                    .IsFixedLength();

                entity.Property(e => e.UserDvslid)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("USER_DVSLID")
                    .IsFixedLength();

                entity.Property(e => e.UserEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USER_EMAIL");

                entity.Property(e => e.UserGrifid)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("USER_GRIFID")
                    .IsFixedLength();

                entity.Property(e => e.UserId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("USER_ID");

                entity.Property(e => e.UserIndate)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("USER_INDATE");

                entity.Property(e => e.UserLogin)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("USER_LOGIN")
                    .IsFixedLength();

                entity.Property(e => e.UserMemo)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("USER_MEMO");

                entity.Property(e => e.UserName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USER_NAME");

                entity.Property(e => e.UserPhon)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("USER_PHON");

                entity.Property(e => e.UserPw)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("USER_PW");

                entity.Property(e => e.UserTel)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("USER_TEL");

                entity.Property(e => e.UserUsed)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("USER_USED")
                    .IsFixedLength();

                entity.HasOne(d => d.UserArea)
                    .WithMany(p => p.Userinfos)
                    .HasForeignKey(d => d.UserAreaid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C0053887");

                entity.HasOne(d => d.UserDvsh)
                    .WithMany(p => p.Userinfos)
                    .HasForeignKey(d => d.UserDvshid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C0053909");

                entity.HasOne(d => d.UserDvsl)
                    .WithMany(p => p.Userinfos)
                    .HasForeignKey(d => d.UserDvslid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C0053911");

                entity.HasOne(d => d.UserGrif)
                    .WithMany(p => p.Userinfos)
                    .HasForeignKey(d => d.UserGrifid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C0053912");
            });

            modelBuilder.Entity<Userprogram>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("USERPROGRAM");

                entity.Property(e => e.UpgmItclhid)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("UPGM_ITCLHID")
                    .IsFixedLength();

                entity.Property(e => e.UpgmItcllid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("UPGM_ITCLLID");

                entity.Property(e => e.UpgmPrgmareaid)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("UPGM_PRGMAREAID")
                    .IsFixedLength();

                entity.Property(e => e.UpgmPrgmid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("UPGM_PRGMID");

                entity.Property(e => e.UpgmPrgmmedaid)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("UPGM_PRGMMEDAID")
                    .IsFixedLength();

                entity.Property(e => e.UpgmUsernum)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("UPGM_USERNUM");

                entity.HasOne(d => d.UpgmItcll)
                    .WithMany()
                    .HasForeignKey(d => d.UpgmItcllid)
                    .HasConstraintName("SYS_C0053917");

                entity.HasOne(d => d.UpgmUsernumNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.UpgmUsernum)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C0053974");

                entity.HasOne(d => d.UpgmPrgm)
                    .WithMany()
                    .HasForeignKey(d => new { d.UpgmPrgmareaid, d.UpgmPrgmmedaid, d.UpgmPrgmid })
                    .HasConstraintName("SYS_C0053958");
            });

            modelBuilder.Entity<Worklog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WORKLOG");

                entity.Property(e => e.WlogDate)
                    .HasColumnType("DATE")
                    .HasColumnName("WLOG_DATE");

                entity.Property(e => e.WlogExefile)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("WLOG_EXEFILE");

                entity.Property(e => e.WlogMedia)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("WLOG_MEDIA")
                    .IsFixedLength();

                entity.Property(e => e.WlogMemo)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("WLOG_MEMO");

                entity.Property(e => e.WlogStifip)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("WLOG_STIFIP");

                entity.Property(e => e.WlogType)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("WLOG_TYPE");

                entity.Property(e => e.WlogUsernum)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("WLOG_USERNUM");
            });

            modelBuilder.HasSequence("CUESHEET_ID_SEQ");

            modelBuilder.HasSequence("SEQ_ALBUM_ID");

            modelBuilder.HasSequence("SEQ_ARTIST_ID");

            modelBuilder.HasSequence("SEQ_CLASS_ID");

            modelBuilder.HasSequence("SEQ_IF_LBH_RAINBOW");

            modelBuilder.HasSequence("SEQ_IF_SONG_RAINBOW");

            modelBuilder.HasSequence("SEQ_INST_ID");

            modelBuilder.HasSequence("SEQ_LOAN_ID");

            modelBuilder.HasSequence("SEQ_REQ_ID");

            modelBuilder.HasSequence("SEQ_SONG_HISTORY");

            modelBuilder.HasSequence("SEQ_SONG_ID");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
