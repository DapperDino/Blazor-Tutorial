using BlazorTutorial.DAL.Models.Books;
using Microsoft.EntityFrameworkCore;

namespace BlazorTutorial.DAL
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
    }
}
