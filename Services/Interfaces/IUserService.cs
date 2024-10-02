using System.Threading.Tasks;
using AppStoreBackend.Models;

namespace AppStoreBackend.Services.Interfaces
{
    public interface IUserService
    {
        Task<User?> GetUserByIdAsync(int userId);
        Task<User> CreateUserAsync(User user);
        Task<User?> UpdateUserAsync(User user);
        Task<bool> DeleteUserAsync(int userId);
    }
}
