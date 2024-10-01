using System.Collections.Generic;

namespace AppStoreBackend.Models
{
    public class App
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }

        // Foreign key for Category
        public int CategoryId { get; set; }
        public required Category Category { get; set; }

        // Collection of Purchases associated with this App
        public ICollection<Purchase> Purchases { get; set; } = new List<Purchase>();
    }
}
