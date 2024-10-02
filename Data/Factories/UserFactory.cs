using AppStoreBackend.Models;

namespace AppStoreBackend.Data.Factories
{
    public static class UserFactory
    {
        public static User CreateNewUser(string username, string email, string name, string password)
        {
            return new User
            {
                Username = username,
                Email = email,
                Name = name, // Correct usage of Name property
                Password = password // Correct usage of Password property
            };
        }
    }
}
