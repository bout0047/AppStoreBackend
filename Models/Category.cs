using System.Collections.Generic;

namespace AppStoreBackend.Models
{
    public class Category
    {
        public int Id { get; set; }
        public required string CategoryName { get; set; }
        public required string IconPath { get; set; }

        // Apps associated with this Category
        public ICollection<App> Apps { get; set; } = new List<App>();
    }
}
