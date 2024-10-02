using AppStoreBackend.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppStoreBackend.Services
{
    public interface IUserService
    {
        Task<User?> GetUserByIdAsync(int userId);
        Task<User> CreateUserAsync(User user); // Returning the created User
        Task UpdateUserAsync(User user); // Method to update a user
        Task<IEnumerable<User>> GetAllUsersAsync(); // Method to get all users
        Task<bool> DeleteUserAsync(int userId); // Returning boolean if deletion was successful
    }
}
