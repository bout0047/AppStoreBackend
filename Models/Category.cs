using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AppStoreBackend.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public string IconPath { get; set; }

        public ICollection<App> Apps { get; set; }
    }
}
