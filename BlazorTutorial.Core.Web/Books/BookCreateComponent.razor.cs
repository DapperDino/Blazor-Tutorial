using BlazorTutorial.Core.Services.Books;
using BlazorTutorial.DAL.Models.Books;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace BlazorTutorial.Core.Web.Books
{
    public partial class BookCreateComponent : ComponentBase
    {
        [Inject]
        public IBookService BookService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        private readonly Book book = new Book();

        private async Task HandleValidSubmitAsync()
        {
            await BookService.CreateBookAsync(book);

            NavigationManager.NavigateTo($"/book/edit/{book.Id}");
        }
    }
}
