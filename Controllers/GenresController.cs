using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAssignment_Quiz_.Dtos;
using WebAssignment_Quiz_.Repos.GenreRepo;

namespace WebAssignment_Quiz_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        private readonly IGenreRepo _repo;
        public GenresController(IGenreRepo repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var genres = _repo.GetAll();
            if (genres == null)
            {
                return NotFound();
            }
            return Ok(genres);
        }
        [HttpGet("ID")]
        public IActionResult GetById(int id)
        {
            var genre = _repo.GetById(id);
            if (genre == null)
            {
                return NotFound();
            }
            return Ok(genre);
        }
        [HttpPost]
        public IActionResult AddGenre(GenreDto genre)
        {
            if (genre == null)
            {
                return BadRequest();
            }
            _repo.AddGenre(genre);
            return Created();
        }
        [HttpPut]
        public IActionResult UpdateGenre(GenreDto genre, int id)
        {
            _repo.UpdateGenre(genre, id);
            return Accepted();
        }
        [HttpDelete]
        public IActionResult DeleteGenre(int id)
        {
            _repo.DeleteGenre(id);
            return Accepted();
        }
    }
}
