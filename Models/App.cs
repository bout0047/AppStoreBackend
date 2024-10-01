using System.Text.Json.Serialization;

namespace AppStoreBackend.Models
{
    public class App
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        // Foreign Key for Category
        public int CategoryId { get; set; }

        // Navigation property for Category
        public Category Category { get; set; } = null!;

        // A collection of Purchases of this app
        [JsonIgnore] // Prevent infinite loop during serialization
        public ICollection<Purchase> Purchases { get; set; } = new List<Purchase>();
    }
}
