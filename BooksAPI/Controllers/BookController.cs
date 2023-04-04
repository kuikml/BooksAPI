using BooksAPI.Services.BookService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BooksAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Book>>> GetAllBooks()
        { 
            return await _bookService.GetAllBooks();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetBook(int id)
        {

            var result = await _bookService.GetBook(id);
            if (result is null)
                return NotFound("Książka nie została znaleziona.");

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Book>>> AddBook([FromBody] Book book)
        {
            var result = await _bookService.AddBook(book);

            return Ok(result);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<List<Book>>> UpdateBook(int id, Book request)
        {
            var result = await _bookService.UpdateBook(id, request);
            if (result is null)
                return NotFound("Książka nie została znaleziona.");
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Book>>> DeleteBook(int id)
        {
            var result = await _bookService.DeleteBook(id);
            if (result is null)
                return NotFound("Książka nie została znaleziona.");
            return Ok(result);
        }

    }
}
