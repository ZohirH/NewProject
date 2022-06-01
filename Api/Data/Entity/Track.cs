using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Data.Entity
{
    public class Track
    {
        [Column("Track_Id"), Key]
        public int TrackId { get; set; }

        [Required]
        [MaxLength(50)]
        [Column("Track_Name")]
        public string? TrackName { get; set; }
        public int AlbumId { get;set; }
        public Album? Album { get; set; }
    }
}
