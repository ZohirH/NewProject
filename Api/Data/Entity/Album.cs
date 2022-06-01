using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Data.Entity
{
    public class Album
    {
        [Column("Album_Id"), Key]
        public int AlbumId { get; set; }

        [Required]
        [MaxLength(50)]
        public string? Title { get; set; }

        [Column("Artist_Id")]
        public int ArtistId { get; set; }

        public List<Track> Traks { get; set; }
    }
}
