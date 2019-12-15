using BlazorTutorial.DAL.Models.Books;
using Microsoft.AspNetCore.Components;

namespace BlazorTutorial.Core.Web.Books
{
    public partial class BookViewComponent : ComponentBase
    {
        [Parameter]
        public Book Book { get; set; }
    }
}
