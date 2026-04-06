using LibraryManagerAPI.DTos;

namespace LibraryManagerAPI.Services
{
    public interface IBookService
    {
        List<BookDto> GetAll();

        BookDto GetById(int id);

        void Create(BookDto bookDto);

        void Update(int id, BookDto bookDto);

        void Delete(int id);
    }
}