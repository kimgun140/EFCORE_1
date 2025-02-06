using System;
using System.Collections.Generic;

namespace EFCORE_1.Model
{
    public partial class MpsSongHistory
    {
        public decimal Seq { get; set; }
        public string? SchDate { get; set; }
        public string? MediaId { get; set; }
        public string? MediaName { get; set; }
        public decimal? PgmId { get; set; }
        public string? PgmName { get; set; }
        public string? SongId { get; set; }
        public string? SongName { get; set; }
        public string? ArtistName { get; set; }
        public string? CateName { get; set; }
        public string? AlbumCallNo { get; set; }
        public decimal? AlbumId { get; set; }
        public string? AlbumName { get; set; }
        public DateTime? StartDtm { get; set; }
        public DateTime? EndDtm { get; set; }
        public string? StudioName { get; set; }
        public string? RegisterName { get; set; }
        public decimal? PlayDuration { get; set; }
        public decimal? SongLength { get; set; }
        public DateTime? RegDtm { get; set; }
    }
}
