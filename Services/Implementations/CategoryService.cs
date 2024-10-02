using AppStoreBackend.DTOs;
using AppStoreBackend.Models;
using AppStoreBackend.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppStoreBackend.Services.Implementations
{
    public class CategoryService : ICategoryService
    {
        private readonly List<Category> _categories;

        public CategoryService()
        {
            _categories = new List<Category>
            {
                new Category("Games", "All types of games"),
                new Category("Productivity", "Productivity tools and apps")
            };
        }

        public async Task<CategoryDTO> GetCategoryByIdAsync(int id)
        {
            var category = _categories.Find(c => c.Id == id);
            if (category == null)
            {
                throw new KeyNotFoundException($"Category with ID {id} not found.");
            }

            return new CategoryDTO
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description
            };
        }
    }
}
