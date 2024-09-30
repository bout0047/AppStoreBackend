using System.Collections.Generic;

namespace AppStoreBackend.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // Ensure Name property exists
        public string Description { get; set; } = string.Empty; // Ensure Description property exists
        public ICollection<App> Apps { get; set; } = new List<App>(); // Navigation property
    }
}
