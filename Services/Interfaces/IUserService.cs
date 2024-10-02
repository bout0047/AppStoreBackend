using System.Threading.Tasks;
using AppStoreBackend.Models;

public interface IUserService
{
    Task<User> GetUserByIdAsync(int id);
    Task<User> CreateUserAsync(User user);
    Task UpdateUserAsync(User user);
    Task DeleteUserAsync(int id);
}
