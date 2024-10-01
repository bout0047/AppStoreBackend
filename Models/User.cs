using System.Text.Json.Serialization;

namespace AppStoreBackend.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        // A collection of Purchases by this user
        [JsonIgnore] // Prevent infinite loop during serialization
        public ICollection<Purchase> Purchases { get; set; } = new List<Purchase>();
    }
}
