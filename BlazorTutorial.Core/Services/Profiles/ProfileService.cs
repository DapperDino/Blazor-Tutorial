using BlazorTutorial.DAL;
using BlazorTutorial.DAL.Models.Profiles;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorTutorial.Core.Services.Profiles
{
    public interface IProfileService
    {
        Task<Profile> GetProfileAsync(int profileId);
        Task<List<Profile>> GetAllProfilesAsync();
    }

    public class ProfileService : IProfileService
    {
        private readonly LibraryContext _context;

        public ProfileService(LibraryContext context)
        {
            _context = context;
        }

        public Task<Profile> GetProfileAsync(int profileId)
        {
            return _context.Profiles
                .Include(x => x.Books)
                .FirstOrDefaultAsync(x => x.Id == profileId);
        }

        public Task<List<Profile>> GetAllProfilesAsync()
        {
            return _context.Profiles.ToListAsync();
        }
    }
}
