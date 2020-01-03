using System.ComponentModel.DataAnnotations;

namespace BlazorTutorial.DAL
{
    public abstract class Entity
    {
        [Key]
        public int Id { get; set; }
    }
}
