using BlazorTutorial.DAL.Models.Books;
using System.Collections.Generic;

namespace BlazorTutorial.DAL.Models.Profiles
{
    public class Profile : Entity
    {
        public string DisplayName { get; set; }
        public List<Book> Books { get; set; } = new List<Book>();
    }
}
