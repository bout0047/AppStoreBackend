using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppStoreBackend.Data;
using AppStoreBackend.DTOs;
using AppStoreBackend.Models;
using AppStoreBackend.Services.Interfaces;

namespace AppStoreBackend.Services.Implementations
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
            return _context.Categories.Select(category => new CategoryDTO
            {
                Id = category.Id,
                Name = category.Name, // Ensure `Name` exists in `Category` model
                Description = category.Description
            }).ToList();
        }

        public async Task<CategoryDTO> GetCategoryByIdAsync(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                return null;
            }

            return new CategoryDTO
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description
            };
        }

        public async Task CreateCategoryAsync(CategoryDTO categoryDto)
        {
            var category = new Category
            {
                Name = categoryDto.Name,
                Description = categoryDto.Description
            };

            _context.Categories.Add(category);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCategoryAsync(int id, CategoryDTO categoryDto)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category != null)
            {
                category.Name = categoryDto.Name;
                category.Description = categoryDto.Description;

                _context.Categories.Update(category);
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteCategoryAsync(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category != null)
            {
                _context.Categories.Remove(category);
                await _context.SaveChangesAsync();
            }
        }
    }
}
