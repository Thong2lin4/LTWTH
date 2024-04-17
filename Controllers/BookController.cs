using LTW_Buoi1.Data;
using LTW_Buoi1.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LTW_Buoi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly AppDbContext _context;

        public BooksController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Books>> GetBooks()
        {
            return _context.books.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Books> GetBook(int id)
        {
            var book = _context.books.Find(id);

            if (book == null)
            {
                return NotFound();
            }

            return book;
        }

        [HttpPost]
        public IActionResult PostBook(Books book)
        {
            _context.books.Add(book);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetBook), new { id = book.Id}, book);
        }

        [HttpPut("{id}")]
        public IActionResult PutBook(int id, Books book)
        {
            if (id != book.Id)
            {
                return BadRequest();
            }

            _context.Entry(book).State = EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            var book = _context.books.Find(id);

            if (book == null)
            {
                return NotFound();
            }

            _context.books.Remove(book);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
