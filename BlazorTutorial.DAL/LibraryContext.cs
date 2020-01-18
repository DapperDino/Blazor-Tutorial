using BlazorTutorial.DAL.Models;
using BlazorTutorial.DAL.Models.Books;
using BlazorTutorial.DAL.Models.Profiles;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorTutorial.DAL
{
    public class LibraryContext : IdentityDbContext<AppUser>
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options) { }

        public override DbSet<AppUser> Users { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
