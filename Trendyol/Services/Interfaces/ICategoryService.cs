using Trendyol.DTOs.Category;

namespace Trendyol.Services.Interfaces
{
    public interface ICategoryService
    {
        public string Create(CategoryCreateDto dto);
        public string Delete(int categoryId);
        public string Update(int categoryId, CategoryUpdateDto dto);
        public List<CategoryGetDto> GetAll();
        public CategoryGetDto GetSingle(int categoryId);
    }
}
