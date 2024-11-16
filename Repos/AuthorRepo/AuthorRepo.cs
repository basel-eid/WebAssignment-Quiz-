using WebAssignment_Quiz_.Data;
using WebAssignment_Quiz_.Data.Model;
using WebAssignment_Quiz_.Dtos;

namespace WebAssignment_Quiz_.Repos.AuthorRepo
{
    public class AuthorRepo : IAuthorRepo
    {
        private readonly DataContext _context;
        public AuthorRepo(DataContext context)
        {
            _context = context;
        }
        public void AddAuthor(AuthorDto authorDto)
        {
            var a = new Author
            {
                Name = authorDto.Name,
                PhoneNumber = authorDto.PhoneNumber,
                Email = authorDto.Email,
            };
            _context.Authors.Add(a);
            _context.SaveChanges();
        }

        public void DeleteAuthor(int id)
        {
            var a = _context.Authors.FirstOrDefault(x=> x.Id == id);
            if(a != null)
            {
                _context.Authors.Remove(a);
                _context.SaveChanges();
            }
            return;
        }

        public List<Author> GetAll()
        {
            return _context.Authors.ToList();
        }

        public Author GetById(int id)
        {
            var a = _context.Authors.FirstOrDefault(x => x.Id == id);
            if (a != null)
            {
                return a;
            }
            return null;
        }

        public void UpdateAuthor(AuthorDto authorDto, int id)
        {
            var a = _context.Authors.FirstOrDefault(x => x.Id == id);
            if ( a != null )
            {
                a.Name = authorDto.Name;
                a.PhoneNumber = authorDto.PhoneNumber;
                a.Email = authorDto.Email;
                _context.Authors.Add(a);
                _context.SaveChanges();
            }
            return;
        }
    }
}
