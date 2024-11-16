using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAssignment_Quiz_.Dtos;
using WebAssignment_Quiz_.Repos.AuthorRepo;

namespace WebAssignment_Quiz_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorRepo _repo;
        public AuthorsController(IAuthorRepo repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var authors = _repo.GetAll();
            if (authors == null)
            {
                return NotFound();
            }
            return Ok(authors);
        }
        [HttpGet("ID")]
        public IActionResult GetById(int id)
        {
            var author = _repo.GetById(id);
            if (author == null)
            {
                return NotFound();
            }
            return Ok(author);
        }
        [HttpPost]
        public IActionResult AddAuthor(AuthorDto author)
        {
            if (author == null)
            {
                return BadRequest();
            }
            _repo.AddAuthor(author);
            return Created();
        }
        [HttpPut]
        public IActionResult UpdateAuthor(AuthorDto author, int id)
        {
            _repo.UpdateAuthor(author,id);
            return Accepted();
        }
        [HttpDelete]
        public IActionResult DeleteAuthor(int id)
        {
            _repo.DeleteAuthor(id);
            return Accepted();
        }
    }
}
