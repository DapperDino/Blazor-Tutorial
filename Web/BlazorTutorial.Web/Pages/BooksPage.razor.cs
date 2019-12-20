using BlazorTutorial.Core.Services.Books;
using BlazorTutorial.DAL.Models.Books;
using Microsoft.AspNetCore.Components;

namespace BlazorTutorial.Web.Pages
{
    public partial class BooksPage : ComponentBase
    {
        [Inject]
        public IBookService BookService { get; set; }

        private Book[] books;

        protected override void OnInitialized()
        {
            books = BookService.GetBooks();
        }
    }
}
