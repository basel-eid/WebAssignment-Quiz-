using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAssignment_Quiz_.Data.Model;
using WebAssignment_Quiz_.Data;
using Microsoft.EntityFrameworkCore;

namespace WebAssignment_Quiz_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookGenreController : ControllerBase
    {
        private readonly DataContext _context;
        public BookGenreController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetAllBookGenre()
        {
            return Ok(_context.BookGenres.Include(x=> x.genre).Include(x => x.books).ToList());
        }
        [HttpPost]
        public IActionResult AddBookGenre(int G_Id, int B_Id)
        {
            var v = new BookGenre
            {
                GenreId = G_Id,
                BookId = B_Id
            };
            _context.BookGenres.Add(v);
            _context.SaveChanges();
            return Created();
        }
    }
}
