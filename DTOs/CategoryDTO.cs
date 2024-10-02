﻿namespace AppStoreBackend.DTOs
{
    public class CategoryDTO
    {
        public int Id { get; set; }
        public required string Name { get; set; }  // Added 'required' modifier
        public required string Description { get; set; }  // Added 'required' modifier
    }
}
