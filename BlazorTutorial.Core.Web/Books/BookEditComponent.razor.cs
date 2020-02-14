using BlazorTutorial.Core.Services.Books;
using BlazorTutorial.DAL.Models.Books;
using BlazorTutorial.DAL.Models.Profiles;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorTutorial.Core.Web.Books
{
    public partial class BookEditComponent : OwningComponentBase
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Parameter]
        public Book Book { get; set; }

        private IBookService bookService;
        private IProfileService profileService;

        private IEnumerable<Profile> profiles;

        protected override async Task OnInitializedAsync()
        {
            bookService = (IBookService)ScopedServices.GetService(typeof(IBookService));
            profileService = (IProfileService)ScopedServices.GetService(typeof(IProfileService));

            profiles = await profileService.GetAllProfilesAsync();
        }

        private async Task DeleteBookAsync()
        {
            await bookService.DeleteBookAsync(Book);

            NavigationManager.NavigateTo("/books");
        }

        private async Task HandleValidSubmitAsync()
        {
            await bookService.UpdateBookAsync(Book);
        }
    }
}
