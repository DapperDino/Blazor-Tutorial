using BlazorTutorial.Core.Services.Books;
using BlazorTutorial.DAL.Models.Books;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace BlazorTutorial.Web.Pages
{
    public partial class BookEditPage : ComponentBase
    {
        [Inject]
        public IBookService BookService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Parameter]
        public int BookId { get; set; }

        private Book book;

        protected override async Task OnInitializedAsync()
        {
            book = await BookService.GetBookByIdAsync(BookId);

            if (book == null)
            {
                NavigationManager.NavigateTo("/");
                return;
            }
        }
    }
}
