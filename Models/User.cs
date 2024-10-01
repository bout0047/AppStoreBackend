using System.Collections.Generic;

namespace AppStoreBackend.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;

        // A collection of Purchases made by the User
        public ICollection<Purchase> Purchases { get; set; } = new List<Purchase>();
    }
}
