using BlazorTutorial.DAL.Models.Profiles;
using Microsoft.AspNetCore.Components;

namespace BlazorTutorial.Core.Web.Profiles
{
    public partial class ProfileViewComponent : ComponentBase
    {
        [Parameter]
        public Profile Profile { get; set; }
    }
}
