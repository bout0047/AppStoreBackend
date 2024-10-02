using AppStoreBackend.Data;
using AppStoreBackend.DTOs;
using AppStoreBackend.Models;
using AppStoreBackend.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
                Name = category.Name,
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

        public async Task<CategoryDTO> CreateCategoryAsync(CategoryDTO categoryDTO)
        {
            var category = new Category
            {
                Name = categoryDTO.Name,
                Description = categoryDTO.Description
            };

            _context.Categories.Add(category);
            await _context.SaveChangesAsync();

            categoryDTO.Id = category.Id;
            return categoryDTO;
        }

        public async Task<CategoryDTO> UpdateCategoryAsync(int id, CategoryDTO categoryDTO)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                return null;
            }

            category.Name = categoryDTO.Name;
            category.Description = categoryDTO.Description;

            _context.Categories.Update(category);
            await _context.SaveChangesAsync();

            return categoryDTO;
        }

        public async Task<bool> DeleteCategoryAsync(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                return false;
            }

            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
