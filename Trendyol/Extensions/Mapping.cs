using Trendyol.DTOs.Category;
using Trendyol.Models;

namespace Trendyol.Extensions
{
    public static class Mapping
    {
        public static CategoryGetDto ToCategoryGetDto(this Category category)
        {
            var dto = new CategoryGetDto()
            {
                Id = category.Id,
                Name = category.Name,
                ParentId = category.ParentId
            };
            return dto;
        }
    }
}
