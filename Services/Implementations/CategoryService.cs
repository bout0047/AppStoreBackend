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
        private readonly List<Category> _categories;

        public CategoryService()
        {
            _categories = new List<Category>
            {
                new Category { Id = 1, Name = "Games", Description = "All gaming-related apps" },
                new Category { Id = 2, Name = "Productivity", Description = "Productivity tools and software" }
            };
        }

        public async Task<List<CategoryDTO>> GetAllCategoriesAsync()
        {
            var categoryDtos = _categories.Select(category => new CategoryDTO
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description
            }).ToList();

            return await Task.FromResult(categoryDtos);
        }

        public async Task<CategoryDTO?> GetCategoryByIdAsync(int id)
        {
            var category = _categories.FirstOrDefault(c => c.Id == id);
            if (category == null)
            {
                return null;
            }

            return await Task.FromResult(new CategoryDTO
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description
            });
        }

        public async Task<CategoryDTO> CreateCategoryAsync(CategoryDTO categoryDto)
        {
            var newCategory = new Category
            {
                Id = _categories.Max(c => c.Id) + 1,
                Name = categoryDto.Name,
                Description = categoryDto.Description
            };

            _categories.Add(newCategory);

            return await Task.FromResult(new CategoryDTO
            {
                Id = newCategory.Id,
                Name = newCategory.Name,
                Description = newCategory.Description
            });
        }

        public async Task<CategoryDTO?> UpdateCategoryAsync(int id, CategoryDTO categoryDto)
        {
            var category = _categories.FirstOrDefault(c => c.Id == id);
            if (category == null)
            {
                return null;
            }

            category.Name = categoryDto.Name;
            category.Description = categoryDto.Description;

            return await Task.FromResult(new CategoryDTO
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description
            });
        }

        public async Task<bool> DeleteCategoryAsync(int id)
        {
            var category = _categories.FirstOrDefault(c => c.Id == id);
            if (category == null)
            {
                return false;
            }

            _categories.Remove(category);
            return await Task.FromResult(true);
        }
    }
}
