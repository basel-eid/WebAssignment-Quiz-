using WebAssignment_Quiz_.Data;
using WebAssignment_Quiz_.Data.Model;
using WebAssignment_Quiz_.Dtos;

namespace WebAssignment_Quiz_.Repos.BookRepo
{
    public class BookRepo : IBookRepo
    {
        private readonly DataContext _context;
        public BookRepo(DataContext context)
        {
            _context = context;
        }
        public void AddBook(BookDto bookDto)
        {
            var b = new Book
            {
                PublishedYear = bookDto.PublishedYear,
                Title = bookDto.Title,
            };
            _context.Books.Add(b);
            _context.SaveChanges();
        }

        public void DeleteBook(int id)
        {
            var b = _context.Books.FirstOrDefault(x=> x.Id == id);
            if(b != null)
            {
                _context.Books.Remove(b);
                _context.SaveChanges();
            }
            return;
        }

        public Book GetBook(int id)
        {
            var b = _context.Books.FirstOrDefault(x=> x.Id==id);
            if(b != null)
            {
                return b;
            }
            return null;
        }

        public List<Book> GetBooks()
        {
           return _context.Books.ToList();
        }

        public void UpdateBook(BookDto bookDto, int id)
        {
            var b = _context.Books.FirstOrDefault(x => x.Id == id);
            if(b != null)
            {
                b.PublishedYear = bookDto.PublishedYear;
                b.Title = bookDto.Title;
                _context.Books.Update(b);
                _context.SaveChanges();
            }
            return;
        }
    }
}
