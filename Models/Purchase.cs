using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppStoreBackend.Models
{
    public class Purchase
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }

        [ForeignKey("App")]
        public int AppId { get; set; }
        public App App { get; set; }

        [Required]
        public DateTime PurchaseDate { get; set; }
    }
}
