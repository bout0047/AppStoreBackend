using AppStoreBackend.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppStoreBackend.Services.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task<User?> GetUserByIdAsync(int userId);
        Task<User> CreateUserAsync(User user);
        Task<User?> UpdateUserAsync(User updatedUser);
        Task<bool> DeleteUserAsync(int userId);
    }
}
