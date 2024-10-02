// File: Services/CategoryService.cs

using AppStoreBackend.Data;
using AppStoreBackend.DTOs;
using AppStoreBackend.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AppStoreBackend.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly AppDbContext _context;

        public CategoryService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CategoryDTO>> GetAllCategoriesAsync()
        {
            return await _context.Categories
                .Select(c => new CategoryDTO
                {
                    CategoryName = c.CategoryName,
                    IconPath = c.IconPath
                })
                .ToListAsync();
        }
    }
}
