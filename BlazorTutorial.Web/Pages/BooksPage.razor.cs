using BlazorTutorial.Core.Services.Books;
using BlazorTutorial.DAL.Models.Books;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorTutorial.Web.Pages
{
    public partial class BooksPage : ComponentBase
    {
        [Inject]
        public IBookService BookService { get; set; }

        private List<Book> books;

        protected override async Task OnInitializedAsync()
        {
            books = await BookService.GetAllBooksAsync();
        }
    }
}
