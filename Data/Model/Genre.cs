using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace WebAssignment_Quiz_.Data.Model
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="name is required")]
        public string? Name { get; set; }
        [JsonIgnore]
        public IList<BookGenre> bookGenres { get; set; }
    }
}
