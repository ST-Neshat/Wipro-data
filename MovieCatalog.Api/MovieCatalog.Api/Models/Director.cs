using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace MovieCatalog.Api.Models
{
    public class Director
    {
        public int Id { get; set; }
        [Required, StringLength(120)]
        public string Name { get; set; } = string.Empty;

        [StringLength(240)]
        public string? Bio { get; set; }

        // Navigation: one director → many movies
        public List<Movie> Movies { get; set; } = new();
    }

}

