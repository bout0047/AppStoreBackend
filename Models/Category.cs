using System.Text.Json.Serialization;

namespace AppStoreBackend.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public string IconPath { get; set; } = string.Empty;

        // A collection of Apps in this category
        [JsonIgnore] // Prevent infinite loop during serialization
        public ICollection<App> Apps { get; set; } = new List<App>();
    }
}
