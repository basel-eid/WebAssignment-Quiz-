using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace WebAssignment_Quiz_.Data.Model
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string? Name { get; set; }
        [Required]
        public int? PhoneNumber { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Must be valid email")]
        public string? Email { get; set; }
        [JsonIgnore]
        public IList<BookAuthor>? BooksAuthors { get; set; }
    }
}
