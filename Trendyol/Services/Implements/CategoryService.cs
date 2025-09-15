using Trendyol.DTOs.Category;
using Trendyol.Exceptions.NotFound;
using Trendyol.Extensions;
using Trendyol.Models;
using Trendyol.Repositories.Implements;
using Trendyol.Repositories.Interfaces;
using Trendyol.Services.Interfaces;

namespace Trendyol.Services.Implements
{
    public class CategoryService : ICategoryService
    {
        private ICategoryRepository _repository = new CategoryRepository();
        public string Create(CategoryCreateDto dto)
        {
            int id = 0;
            var categories = _repository.GetAll();
            if (categories.Any())
            {
                id = categories.Last().Id;
            }
            var category = new Category()
            {
                Id = id + 1,
                Name = dto.Name,
                ParentId = dto.ParentId
            };
            _repository.Add(category);
            return "Category was created.";
        }

        public string Delete(int categoryId)
        {
            var category = _repository.GetSingle(categoryId);
            if (category == null) throw new CategoryNotFoundException();

            _repository.Remove(category);
            return "Category was deleted.";
        }

        public List<CategoryGetDto> GetAll()
        {
            var categories = _repository.GetAll();
            var dtos = new List<CategoryGetDto>();
            dtos = categories.Select(category => category.ToCategoryGetDto()).ToList();
            return dtos;
        }

        public CategoryGetDto GetSingle(int categoryId)
        {
            var category = _repository.GetSingle(categoryId);
            if (category == null) throw new CategoryNotFoundException();
            var dto = category.ToCategoryGetDto();
            return dto;
        }
    }
}
