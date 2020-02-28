using BlazorTutorial.Core.Services.Profiles;
using BlazorTutorial.DAL.Models.Profiles;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace BlazorTutorial.Web.Pages
{
    public partial class ProfilePage : OwningComponentBase<IProfileService>
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Parameter]
        public int ProfileId { get; set; }

        private Profile profile;

        protected override async Task OnInitializedAsync()
        {
            profile = await Service.GetProfileAsync(ProfileId);

            if (profile == null)
            {
                NavigationManager.NavigateTo("/");
                return;
            }
        }
    }
}
