using BlazorTutorial.DAL;
using BlazorTutorial.DAL.Models.Books;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorTutorial.Core.Services.Books
{
    public interface IBookService
    {
        Task<List<Book>> GetAllBooksAsync();
    }

    public class BookService : IBookService
    {
        private readonly LibraryContext _context;

        public BookService(LibraryContext context)
        {
            _context = context;
        }

        public async Task<List<Book>> GetAllBooksAsync()
        {
            return await _context.Books.ToListAsync().ConfigureAwait(false);
        }
    }
}
