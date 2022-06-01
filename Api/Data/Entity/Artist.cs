using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Data.Entity
{
    public class Artist
    {
        [Column("Artist_Id"), Key]
        public int ArtistId { get; set; }

        [Required]
        [MaxLength(50)]
        [Column("Artist_Name")]
        public string ArtName { get; set; }
        public List<Album> Albums { get; set; }
    }
    public class ArtistJoin
    {
        public int ArtistId { get; set; }
        public string? ArtistName { get; set; }
        public int AlbumId { get; set; }
        public string? AlbumName { get; set; }
    }
}
