using System.Collections.Generic;
using AppStoreBackend.Data; // Ensure you reference the namespace containing ApplicationData

namespace AppStoreBackend.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public string IconPath { get; set; } = string.Empty;

        // Update the reference from 'App' to 'ApplicationData'
        public ICollection<ApplicationData> Apps { get; set; } = new List<ApplicationData>();
    }
}
