using System.ComponentModel.DataAnnotations;

namespace AppStoreBackend.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public string Username { get; set; }

        public ICollection<Purchase> Purchases { get; set; }
    }
}







