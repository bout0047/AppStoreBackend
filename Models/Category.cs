using System.Collections.Generic;

namespace AppStoreBackend.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; } = string.Empty; // Ensure non-null value
        public string IconPath { get; set; } = string.Empty; // Ensure non-null value

        public ICollection<App> Apps { get; set; } = new List<App>(); // Initialize collection
    }
}
