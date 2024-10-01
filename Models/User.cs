using System.Collections.Generic;

namespace AppStoreBackend.Models
{
    public class User
    {
        public int Id { get; set; }
        public required string Username { get; set; }
        public required string Password { get; set; }
        public required string Email { get; set; }

        // Collection of Purchases made by the User
        public ICollection<Purchase> Purchases { get; set; } = new List<Purchase>();
    }
}
