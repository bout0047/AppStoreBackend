using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppStoreBackend.Models;
using AppStoreBackend.Services.Interfaces;

namespace AppStoreBackend.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly List<User> _users = new List<User>();

        // Retrieve a user by ID asynchronously
        public async Task<User?> GetUserByIdAsync(int userId)
        {
            return await Task.FromResult(_users.FirstOrDefault(u => u.Id == userId));
        }

        // Create a new user asynchronously
        public async Task<User> CreateUserAsync(User user)
        {
            _users.Add(user);
            return await Task.FromResult(user);
        }

        // Update an existing user asynchronously
        public async Task<User?> UpdateUserAsync(User updatedUser)
        {
            var existingUser = _users.FirstOrDefault(u => u.Id == updatedUser.Id);
            if (existingUser != null)
            {
                existingUser.Name = updatedUser.Name;
                existingUser.Email = updatedUser.Email;
                return await Task.FromResult(existingUser);
            }
            return null;
        }


        // Delete a user by ID asynchronously
        public async Task<bool> DeleteUserAsync(int userId)
        {
            var user = _users.FirstOrDefault(u => u.Id == userId);
            if (user != null)
            {
                _users.Remove(user);
                return await Task.FromResult(true);
            }
            return await Task.FromResult(false);
        }
    }
}
