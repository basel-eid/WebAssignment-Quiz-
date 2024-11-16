using WebAssignment_Quiz_.Data.Model;
using WebAssignment_Quiz_.Dtos;

namespace WebAssignment_Quiz_.Repos.AuthorRepo
{
    public interface IAuthorRepo
    {
        List<Author> GetAll();
        Author GetById(int id);
        void AddAuthor(AuthorDto authorDto);
        void UpdateAuthor(AuthorDto authorDto , int id);
        void DeleteAuthor(int id);
    }
}
