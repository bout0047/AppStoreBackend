using AppStoreBackend.Models;

namespace AppStoreBackend.DTOs
{
    public class CategoryDTO
    {
        public string CategoryName { get; set; } = string.Empty;
        public string IconPath { get; set; } = string.Empty;
        public List<ApplicationData> Apps { get; set; } = new List<ApplicationData>();
    }
}
