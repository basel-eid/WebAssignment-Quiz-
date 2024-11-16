using System.ComponentModel.DataAnnotations.Schema;

namespace WebAssignment_Quiz_.Data.Model
{
    public class BookGenre
    {
        public int BookId { get; set; }
        [ForeignKey("BookId")]
        public Book? books { get; set; }
        public int GenreId { get; set; }
        [ForeignKey("GenreId")]
        public Genre? genre { get; set; }
    }
}
