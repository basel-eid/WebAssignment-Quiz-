using System.ComponentModel.DataAnnotations;

namespace WebAssignment_Quiz_.Dtos
{
    public class BookDto
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Title is required")]
        public string? Title { get; set; }
        [Required(ErrorMessage = "Published Year is required")]
        public DateTime? PublishedYear { get; set; }
    }
}
