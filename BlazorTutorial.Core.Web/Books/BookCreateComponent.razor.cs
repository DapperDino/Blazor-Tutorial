using BlazorTutorial.Core.Services.Books;
using BlazorTutorial.DAL.Models.Books;
using BlazorTutorial.DAL.Models.Profiles;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorTutorial.Core.Web.Books
{
    public partial class BookCreateComponent : OwningComponentBase
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        private IBookService bookService;
        private IProfileService profileService;

        private IEnumerable<Profile> profiles;

        private readonly Book book = new Book();

        protected override async Task OnInitializedAsync()
        {
            bookService = (IBookService)ScopedServices.GetService(typeof(IBookService));
            profileService = (IProfileService)ScopedServices.GetService(typeof(IProfileService));

            profiles = await profileService.GetAllProfilesAsync();
        }

        private async Task HandleValidSubmitAsync()
        {
            await bookService.CreateBookAsync(book);

            NavigationManager.NavigateTo($"/book/edit/{book.Id}");
        }
    }
}
