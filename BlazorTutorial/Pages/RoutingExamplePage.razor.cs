using Microsoft.AspNetCore.Components;

namespace BlazorTutorial.Web.Pages
{
    public partial class RoutingExamplePage : ComponentBase
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Parameter]
        public int Id { get; set; }

        private void GoToNextIndex()
        {
            NavigationManager.NavigateTo($"/routingexample/{Id + 1}");
        }
    }
}
