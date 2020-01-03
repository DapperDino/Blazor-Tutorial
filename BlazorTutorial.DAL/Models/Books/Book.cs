namespace BlazorTutorial.DAL.Models.Books
{
    public class Book : Entity
    {
        public string Title { get; set; }
        public string Overview { get; set; }
        public int Price { get; set; }
    }
}
