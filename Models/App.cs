using System.Collections.Generic;

namespace AppStoreBackend.Models
{
    public class App
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; } // Navigation property
        public ICollection<Purchase> Purchases { get; set; } = new List<Purchase>(); // Navigation property
    }
}
