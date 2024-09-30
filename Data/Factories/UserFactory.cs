using System.Collections.Generic;
using AppStoreBackend.Models;

namespace AppStoreBackend.Data.Factories
{
    public static class UserFactory
    {
        public static List<User> CreateUsers()
        {
            return new List<User>
            {
                new User { Username = "User1", Password = "password1", Email = "user1@example.com" },
                new User { Username = "User2", Password = "password2", Email = "user2@example.com" }
            };
        }
    }
}
