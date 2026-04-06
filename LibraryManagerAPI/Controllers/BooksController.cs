using Microsoft.AspNetCore.Mvc;
using LibraryManagerAPI.Services;
using LibraryManagerAPI.DTos;

namespace LibraryManagerAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _service;

        public BooksController(IBookService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var books = _service.GetAll();

            return Ok(books);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var book = _service.GetById(id);

            if (book == null)
                return NotFound();

            return Ok(book);
        }

        [HttpPost]
        public IActionResult Create(BookDto bookDto)
        {
            _service.Create(bookDto);

            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, BookDto bookDto)
        {
            _service.Update(id, bookDto);

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);

            return Ok();
        }
    }
}