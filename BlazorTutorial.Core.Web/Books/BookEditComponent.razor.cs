using BlazorTutorial.Core.Services.Books;
using BlazorTutorial.DAL.Models.Books;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace BlazorTutorial.Core.Web.Books
{
    public partial class BookEditComponent : ComponentBase
    {
        [Inject]
        public IBookService BookService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Parameter]
        public Book Book { get; set; }

        private async Task DeleteBookAsync()
        {
            await BookService.DeleteBookAsync(Book);

            NavigationManager.NavigateTo("/books");
        }

        private async Task HandleValidSubmitAsync()
        {
            await BookService.UpdateBookAsync(Book);
        }
    }
}
