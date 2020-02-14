using BlazorTutorial.DAL.Models.Profiles;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorTutorial.DAL.Models.Books
{
    public class Book : Entity
    {
        public int? AuthorId { get; set; }
        [ForeignKey("AuthorId")]
        public Profile Author { get; set; }
        public string Title { get; set; }
        public string Overview { get; set; }
        public int Price { get; set; }
    }
}
