using System.ComponentModel.DataAnnotations;

namespace BookStoreAPI.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Title is required")]
        [StringLength(100, ErrorMessage = "Title cannot be longer than 100 characters")]
        public string Title { get; set; } = string.Empty;
        [Required(ErrorMessage = "Publication Year is required")]
        [Range(1000, 2025, ErrorMessage = "Publication year must be between 1000 and 2023")]

        public int PublicationYear { get; set; }
        [Required(ErrorMessage = "Author ID is required")]
        public int AuthorId { get; set; }
        public Author Author { get; set; } = null!;
    }
}
