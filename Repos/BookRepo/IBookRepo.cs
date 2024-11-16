using WebAssignment_Quiz_.Data.Model;
using WebAssignment_Quiz_.Dtos;

namespace WebAssignment_Quiz_.Repos.BookRepo
{
    public interface IBookRepo
    {
        List<Book> GetBooks();
        Book GetBook(int id);
        void AddBook(BookDto bookDto);
        void UpdateBook(BookDto bookDto,int id);
        void DeleteBook(int id);
    }
}
