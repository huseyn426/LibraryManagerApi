using LibraryManagerAPI.DTos;
using LibraryManagerAPI.Models;
using LibraryManagerAPI.Repositories;

namespace LibraryManagerAPI.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _repository;

        public BookService(IBookRepository repository)
        {
            _repository = repository;
        }

        public List<BookDto> GetAll()
        {
            var books = _repository.GetAll();

            return books.Select(b => new BookDto
            {
                Title = b.Title,
                Author = b.Author,
                Year = b.Year
            }).ToList();
        }

        public BookDto GetById(int id)
        {
            var book = _repository.GetById(id);

            if (book == null)
                return null;

            return new BookDto
            {
                Title = book.Title,
                Author = book.Author,
                Year = book.Year
            };
        }

        public void Create(BookDto bookDto)
        {
            var book = new Book
            {
                Title = bookDto.Title,
                Author = bookDto.Author,
                Year = bookDto.Year,
                IsAvailable = true
            };

            _repository.Add(book);
        }

        public void Update(int id, BookDto bookDto)
        {
            var book = _repository.GetById(id);

            if (book == null)
                return;

            book.Title = bookDto.Title;
            book.Author = bookDto.Author;
            book.Year = bookDto.Year;

            _repository.Update(book);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}