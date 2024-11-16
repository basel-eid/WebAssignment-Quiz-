using WebAssignment_Quiz_.Data.Model;
using WebAssignment_Quiz_.Dtos;

namespace WebAssignment_Quiz_.Repos.GenreRepo
{
    public interface IGenreRepo
    {
        List<Genre> GetAll();
        Genre GetById(int id);
        void AddGenre(GenreDto genreDto);
        void UpdateGenre(GenreDto genreDto , int id);
        void DeleteGenre(int id);
    }
}
