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

        public async Task CreateBookAsync(Book book)
        {
            await _context.Books.AddAsync(book).ConfigureAwait(false);
            await _context.SaveChangesAsync().ConfigureAwait(false);
        }

        public async Task DeleteBookAsync(Book book)
        {
            _context.Books.Remove(book);
            await _context.SaveChangesAsync().ConfigureAwait(false);
        }

        public async Task<List<Book>> GetAllBooksAsync()
        {
            return await _context.Books
                .ToListAsync().ConfigureAwait(false);
        }

        public async Task<Book> GetBookByIdAsync(int id)
        {
            return await _context.Books
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task UpdateBookAsync(Book book)
        {
            _context.Books.Update(book);
            await _context.SaveChangesAsync().ConfigureAwait(false);
        }
    }
}
