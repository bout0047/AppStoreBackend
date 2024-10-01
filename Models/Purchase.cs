﻿using System;

namespace AppStoreBackend.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal Price { get; set; }

        // Foreign key reference to User and App
        public int UserId { get; set; }
        public User User { get; set; } = null!;

        public int AppId { get; set; }
        public App App { get; set; } = null!;
    }
}
