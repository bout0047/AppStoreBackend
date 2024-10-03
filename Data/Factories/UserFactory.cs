using AppStoreBackend.Models;

namespace AppStoreBackend.Data.Factories
{
    public static class UserFactory
    {
        public static User CreateUser(string username, string email, string name, string password)
        {
            return new User
            {
                Username = username,
                Email = email,
                Name = name,
                Password = password
            };
        }
    }
}
