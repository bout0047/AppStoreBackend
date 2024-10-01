using System.Collections.Generic;
using AppStoreBackend.Models;

namespace AppStoreBackend.Models
    

{
    public class AppDetails
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }

        // Foreign key reference to Category
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;

        // A collection of Purchases associated with this App
        public ICollection<Purchase> Purchases { get; set; } = new List<Purchase>();
    }
}
