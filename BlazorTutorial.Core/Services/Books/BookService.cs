using BlazorTutorial.DAL.Models.Books;

namespace BlazorTutorial.Core.Services.Books
{
    public interface IBookService
    {
        Book[] GetBooks();
    }

    public class BookService : IBookService
    {
        public Book[] GetBooks()
        {
            return new Book[]
            {
                new Book { Id = 0, Title = "Test Book", Overview = "Random overview", Price = 10 },
                new Book { Id = 1, Title = "Example Book", Overview = "A very interesting book", Price = 100 },
                new Book { Id = 2, Title = "The Bestest Book", Overview = "Best selling", Price = 1 }
            };
        }
    }
}
