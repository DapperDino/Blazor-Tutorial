using BlazorTutorial.DAL.Models.Books;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace BlazorTutorial.Core.Web.Books
{
    public partial class BookTableComponent : ComponentBase
    {
        [Parameter]
        public IEnumerable<Book> Books { get; set; }
    }
}
