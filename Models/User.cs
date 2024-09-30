using System.Collections.Generic;

namespace AppStoreBackend.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty; // Ensure non-null value
        public string Email { get; set; } = string.Empty; // Ensure non-null value
        public string Password { get; set; } = string.Empty; // Ensure non-null value

        public ICollection<Purchase> Purchases { get; set; } = new List<Purchase>(); // Initialize collection
    }
}
