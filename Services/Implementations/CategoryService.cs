using AppStoreBackend.Data;
using AppStoreBackend.DTOs;
using AppStoreBackend.Models;

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
            return await _context.Categories.Select(c => new CategoryDTO
            {
                Id = c.Id,
                CategoryName = c.CategoryName,
                IconPath = c.IconPath
            }).ToListAsync();
        }

        public async Task<CategoryDTO> GetCategoryByIdAsync(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                return null; // Consider throwing an exception instead.
            }
            return new CategoryDTO
            {
                Id = category.Id,
                CategoryName = category.CategoryName,
                IconPath = category.IconPath
            };
        }

        public async Task CreateCategoryAsync(CategoryDTO categoryDto)
        {
            var category = new Category
            {
                CategoryName = categoryDto.CategoryName,
                IconPath = categoryDto.IconPath
            };
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCategoryAsync(int id, CategoryDTO categoryDto)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                throw new KeyNotFoundException("Category not found");
            }

            category.CategoryName = categoryDto.CategoryName;
            category.IconPath = categoryDto.IconPath;
            _context.Categories.Update(category);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCategoryAsync(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                throw new KeyNotFoundException("Category not found");
            }

            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
        }
    }
}
