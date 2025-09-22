using Trendyol.DTOs.Product;
using Trendyol.Exceptions.NotFound;
using Trendyol.Extensions;
using Trendyol.Models;
using Trendyol.Repositories.Implements;
using Trendyol.Repositories.Interfaces;
using Trendyol.Services.Interfaces;

namespace Trendyol.Services.Implements
{
    public class ProductService : IProductService
    {
        IProductRepository _repository = new ProductRepository();
        public string Create(ProductCreateDto dto)
        {
            var id = 0; //deyisen
            var products = _repository.GetAll(); //bazada producrt cedvelim bos deyilse
            if (products.Any())
            {
                id = products.Last().Id; //sonuncu productin id-sini gotururem. Cunki 1 vahid artirmaliyam
            }
            var product = new Product()
            {
                Id = id + 1,
                CategoryId = dto.CategoryId,
                Description = dto.Description,
                DiscountPersentage = dto.DiscountPersentage,
                Price = dto.Price,
                Title = dto.Title //mapping
            };

            foreach (var imageDto in dto.ImageDtos)
            {
                var imageId = 0;
                var images = product.ProductImages;
                if (images.Any())
                {
                    imageId = images.Last().Id;
                }
                var image = new ProductImage()
                {
                    Id = imageId + 1,
                    ImageName = imageDto.ImageName,
                    ImageUrl = imageDto.ImageUrl,
                    ProductId = product.Id //sen yuxaridaki product - in sekillerisen. Bu elaqelendirmedir.
                };

                product.ProductImages.Add(image);
            }
            _repository.Add(product);
            return "Product was created successfully!";
        }

        public string Delete(int id)
        {
            var produt = _repository.GetSingle(id);
            if (produt == null) throw new ProductNotFoundException();

            _repository.Remove(produt);
            return "Product was removed successfully!";
        }

        public List<ProductGetDto> GetAll()
        {
            var products = _repository.GetAll();
            var dtos = new List<ProductGetDto>();
            dtos = products.Select(product => product.ToProductGetDto()).ToList();
            return dtos;
        }

        public ProductGetDto GetSingle(int id)
        {
            var product = _repository.GetSingle(id);
            if (product == null) throw new ProductNotFoundException();
            var dto = product.ToProductGetDto();
            return dto;
        }
    }
}
