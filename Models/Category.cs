using System.Collections.Generic;

namespace AppStoreBackend.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; } = null!;
        public string IconPath { get; set; } = null!;

        // A collection of Apps that belong to this category
        public ICollection<App> Apps { get; set; } = new List<App>();
    }
}
