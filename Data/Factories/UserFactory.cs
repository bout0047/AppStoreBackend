using AppStoreBackend.Models;

namespace AppStoreBackend.Data.Factories
{
    public static class UserFactory
    {
        public static User CreateUser(string username, string password, string email)
        {
            return new User
            {
                Username = username,
                Password = password,
                Email = email
            };
        }
    }
}
