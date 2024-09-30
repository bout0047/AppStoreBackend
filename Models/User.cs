using System.Collections.Generic;

namespace AppStoreBackend.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public ICollection<Purchase> Purchases { get; set; } = new List<Purchase>(); // Navigation property
    }
}
