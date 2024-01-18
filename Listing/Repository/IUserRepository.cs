using System.Collections.Generic;
using System.Threading.Tasks;
using Listing.Models;
using Microsoft.EntityFrameworkCore;

namespace Listing.Repository
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task<User> GetUserByIdAsync(int userId);
        Task<User> CreateUserAsync(User user);
        Task<User> UpdateUserAsync(User user);
        Task DeleteUserAsync(int userId);
    }
}
