using BlazorTutorial.Core.Services.Books;
using BlazorTutorial.DAL.Models.Books;
using Microsoft.AspNetCore.Components;
using System.Linq;

namespace BlazorTutorial.Web.Pages
{
    public partial class BookPage : ComponentBase
    {
        [Inject]
        public IBookService BookService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Parameter]
        public int Id { get; set; }

        private Book book;

        protected override void OnInitialized()
        {
            book = BookService.GetBooks().FirstOrDefault(x => x.Id == Id);

            if (book == null)
            {
                NavigationManager.NavigateTo("/");
                return;
            }
        }
    }
}
