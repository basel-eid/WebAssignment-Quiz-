using System.ComponentModel.DataAnnotations.Schema;

namespace WebAssignment_Quiz_.Data.Model
{
    public class BookAuthor
    {
        public int BookId { get; set; }
        [ForeignKey("BookId")]
        public Book? books { get; set; }
        public int AuthorsId { get; set; }
        [ForeignKey("AuthorsId")]
        public Author? authors { get; set; }
    }
}
