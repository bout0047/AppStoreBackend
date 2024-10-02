using AppStoreBackend.Models;

namespace AppStoreBackend.Data.Factories
{
    public static class UserFactory
    {
        public static User CreateUser(string name, string email, string username, string password)
        {
            return new User
            {
                Name = name,
                Email = email,
                Username = username, // Correctly using Username
                Password = password  // Correctly using Password
            };
        }
    }
}
