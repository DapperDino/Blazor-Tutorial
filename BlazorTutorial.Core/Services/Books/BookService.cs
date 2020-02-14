using BlazorTutorial.DAL;
using BlazorTutorial.DAL.Models.Books;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorTutorial.Core.Services.Books
{
    public interface IBookService
    {
        Task<Book> GetBookByIdAsync(int id);
        Task CreateBookAsync(Book book);
        Task UpdateBookAsync(Book book);
        Task DeleteBookAsync(Book book);
        Task<List<Book>> GetAllBooksAsync();
    }

    public class BookService : IBookService
    {
        private readonly LibraryContext _context;

        public BookService(LibraryContext context)
        {
            _context = context;
        }

        public Task CreateBookAsync(Book book)
        {
            _context.Books.Add(book);

            return _context.SaveChangesAsync();
        }

        public Task DeleteBookAsync(Book book)
        {
            _context.Books.Remove(book);

            return _context.SaveChangesAsync();
        }

        public Task<List<Book>> GetAllBooksAsync()
        {
            return _context.Books
                .Include(x => x.Author)
                .ToListAsync();
        }

        public Task<Book> GetBookByIdAsync(int id)
        {
            return _context.Books
                .Include(x => x.Author)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public Task UpdateBookAsync(Book book)
        {
            _context.Books.Update(book);

            return _context.SaveChangesAsync();
        }
    }
}
