using Trendyol.DTOs.Category;
using Trendyol.DTOs.Product;
using Trendyol.DTOs.ProductShop;
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

        public static ProductGetDto ToProductGetDto(this Product product)
        {
            var dto = new ProductGetDto()
            {
                Id = product.Id,
                CategoryId = product.CategoryId,
                Description = product.Description,
                DiscountPersentage = product.DiscountPersentage,
                Price = product.Price,
                Title = product.Title,
            };

            foreach (var image in product.ProductImages)
            {
                var imageDto = new ProductImageGetDto()
                {
                    Id = image.Id,
                    ImageName = image.ImageName,
                    ImageUrl = image.ImageUrl
                };
                dto.ImageDtos.Add(imageDto);
            }

            return dto;
        }

        public static ProductShopGetDto ToProductGetDto(this ProductShop productShop)
        {
            var dto = new ProductShopGetDto()
            {
                Id = productShop.Id,
                ProductId = productShop.ProductId,
                ShopId = productShop.ShopId
            };
            return dto;
        }
    }
}
