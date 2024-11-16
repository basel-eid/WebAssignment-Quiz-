using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAssignment_Quiz_.Data;
using WebAssignment_Quiz_.Data.Model;

namespace WebAssignment_Quiz_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookAuthorController : ControllerBase
    {
        private readonly DataContext _context;
        public BookAuthorController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetAllBookAuthor()
        {
            return Ok(_context.BookAuthors.Include(x=> x.authors).Include(x=> x.books).ToList());
        }
        [HttpPost]
        public IActionResult AddBookAuthor(int A_Id,int B_Id)
        {
            var v = new BookAuthor
            {
                AuthorsId = A_Id,
                BookId = B_Id
            };
            _context.BookAuthors.Add(v);
            _context.SaveChanges();
            return Created();
        }
    }
}
