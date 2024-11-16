using WebAssignment_Quiz_.Data;
using WebAssignment_Quiz_.Data.Model;
using WebAssignment_Quiz_.Dtos;

namespace WebAssignment_Quiz_.Repos.GenreRepo
{
    public class GenreRepo : IGenreRepo
    {
        private readonly DataContext _context;
        public GenreRepo(DataContext context)
        {
            _context = context;
        }
        public void AddGenre(GenreDto genreDto)
        {
            var g = new Genre
            {
                Name = genreDto.Name,
            };
            _context.Genres.Add(g);
            _context.SaveChanges();
        }

        public void DeleteGenre(int id)
        {
            var g = _context.Genres.FirstOrDefault(x=> x.Id == id);
            if(g != null)
            {
                _context.Genres.Remove(g);
                _context.SaveChanges();
            }
            return;
        }

        public List<Genre> GetAll()
        {
            return _context.Genres.ToList();
        }

        public Genre GetById(int id)
        {
            var g = _context.Genres.FirstOrDefault(x=> x.Id==id);
            if(g != null)
            {
                return g;
            }
            return null;
        }

        public void UpdateGenre(GenreDto genreDto, int id)
        {
            var g = _context.Genres.FirstOrDefault(x=> x.Id ==id);
            if(g != null)
            {
                g.Name = genreDto.Name;
                _context.Genres.Update(g);
                _context.SaveChanges();
            }
            return;
        }
    }
}
