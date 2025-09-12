using Trendyol.DTOs.Category;
using Trendyol.Exceptions.NotFound;
using Trendyol.Extensions;
using Trendyol.Models;
using Trendyol.Services.Interfaces;

namespace Trendyol.Services.Implements
{
    public class CategoryService : ICategoryService
    {
        List<Category> _categories = new List<Category>();
        public string Create(CategoryCreateDto dto)
        {
            int id = 0;
            if (_categories.Any())
            {
                id = _categories.Last().Id;
            }
            var category = new Category()
            {
                Id = id + 1,
                Name = dto.Name,
                ParentId = dto.ParentId
            };
            _categories.Add(category);
            return "Category was created.";
        }

        public string Delete(int categoryId)
        {
            var category = _categories.FirstOrDefault(c => c.Id == categoryId);
            if (category == null) throw new CategoryNotFoundException();

            _categories.Remove(category);
            return "Category was deleted.";
        }

        public List<CategoryGetDto> GetAll()
        {
            var categories = _categories.ToList();
            var dtos = new List<CategoryGetDto>();
            dtos = categories.Select(category => category.ToCategoryGetDto()).ToList();
            return dtos;
        }

        public CategoryGetDto GetSingle(int categoryId)
        {
            var category = _categories.FirstOrDefault(c => c.Id == categoryId);
            if (category == null) throw new CategoryNotFoundException();
            var dto = category.ToCategoryGetDto();
            return dto;
        }

        public string Update(int categoryId, CategoryUpdateDto dto)
        {
            var category = _categories.FirstOrDefault(c => c.Id == categoryId);
            if (category == null) throw new NotFoundException("Category");
            _categories.Remove(category);

            category.Name = dto.Name;
            category.ParentId = dto.ParentId;

            _categories.Add(category);
            return "Category was updated";
        }
    }
}
