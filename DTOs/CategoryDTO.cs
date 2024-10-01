using AppStoreBackend.Data;

namespace AppStoreBackend.DTOs
{
    public class CategoryDTO
    {
        public string CategoryName { get; set; } = string.Empty; // Added default value
        public string IconPath { get; set; } = string.Empty; // Added default value
        public List<ApplicationData> Apps { get; set; } = new List<ApplicationData>(); // Added default value
    }
}
