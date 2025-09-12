using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MovieCatalog.Api.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required, StringLength(180)]
        public string Title { get; set; } = string.Empty;

        [Range(1888, 3000)]
        public int ReleaseYear { get; set; }

        // Foreign key to Director
        [Required]
        public int DirectorId { get; set; }

        // Navigation property
        public Director? Director { get; set; }
    }

}

