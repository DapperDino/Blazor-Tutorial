using BlazorTutorial.DAL.Models.Profiles;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorTutorial.DAL.Models
{
    public class AppUser : IdentityUser
    {
        public int ProfileId { get; set; }
        [ForeignKey("ProfileId")]
        public Profile Profile { get; set; } = new Profile();
    }
}
