using System.Collections.Generic;

namespace AppStoreBackend.Models
{
    public class App
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // Ensure non-null value
        public string Description { get; set; } = string.Empty; // Ensure non-null value
        public decimal Price { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!; // Non-null reference

        public ICollection<Purchase> Purchases { get; set; } = new List<Purchase>(); // Initialize collection
    }
}
