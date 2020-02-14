using BlazorTutorial.DAL;
using BlazorTutorial.DAL.Models.Profiles;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTutorial.Core.Services.Books
{
    public interface IProfileService
    {
        Task<List<Profile>> GetAllProfilesAsync();
    }

    public class ProfileService : IProfileService
    {
        private readonly LibraryContext _context;

        public ProfileService(LibraryContext context)
        {
            _context = context;
        }

        public Task<List<Profile>> GetAllProfilesAsync()
        {
            return _context.Profiles.ToListAsync();
        }
    }
}
