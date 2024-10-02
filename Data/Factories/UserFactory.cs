using AppStoreBackend.Models;

namespace AppStoreBackend.Data.Factories
{
    public static class UserFactory
    {
        public static User CreateDefaultUser()
        {
            return new User
            {
                Name = "Default Name",
                Email = "default@example.com",
                Password = "defaultpassword" // Adding the Password property
            };
        }
    }
}
