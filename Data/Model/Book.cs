using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace WebAssignment_Quiz_.Data.Model
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Title is required")]
        public string? Title { get; set; }
        [Required(ErrorMessage = "Published Year is required")]
        public DateTime? PublishedYear { get; set; }
        [JsonIgnore]
        public IList<BookAuthor>? BooksAuthors { get; set; }
        [JsonIgnore]
        public IList<BookGenre>? BooksGenre { get; set; }
    }
}
