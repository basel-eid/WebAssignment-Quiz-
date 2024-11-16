using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAssignment_Quiz_.Dtos;
using WebAssignment_Quiz_.Repos.BookRepo;

namespace WebAssignment_Quiz_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookRepo _repo;
        public BooksController(IBookRepo repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var books = _repo.GetBooks();
            if(books == null)
            {
                return NotFound();
            }
            return Ok(books);
        }
        [HttpGet("ID")]
        public IActionResult GetById(int id) 
        {
            var book = _repo.GetBook(id);
            if(book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }
        [HttpPost]
        public IActionResult AddBook(BookDto book)
        {
            if(book == null)
            {
                return BadRequest();
            }
            _repo.AddBook(book);
            return Created();
        }
        [HttpPut]
        public IActionResult UpdateBook(BookDto book ,int id)
        {
            _repo.UpdateBook(book, id);
            return Accepted();
        }
        [HttpDelete]
        public IActionResult DeleteBook(int id)
        {
            _repo.DeleteBook(id);
            return Accepted();
        }
    }
}
