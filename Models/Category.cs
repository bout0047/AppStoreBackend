using System.ComponentModel.DataAnnotations;
namespace AppStoreBackend.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;        // Provide default value
        public string Description { get; set; } = string.Empty;
    }
}
