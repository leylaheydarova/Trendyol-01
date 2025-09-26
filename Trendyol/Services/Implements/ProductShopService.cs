using Trendyol.DTOs.ProductShop;
using Trendyol.Exceptions.NotFound;
using Trendyol.Extensions;
using Trendyol.Models;
using Trendyol.Repositories.Implements;
using Trendyol.Repositories.Interfaces;
using Trendyol.Services.Interfaces;

namespace Trendyol.Services.Implements
{
    public class ProductShopService : IProductShopService
    {
        IProductShopRepository _repository = new ProductShopRepository();
        public string Create(ProductShopCreateDto dto)
        {
            var id = 0;
            var productShops = _repository.GetAll();
            if (productShops.Any())
            {
                id = productShops.Last().Id;
            }
            var productShop = new ProductShop()
            {
                Id = id + 1,
                ProductId = dto.ProductId,
                ShopId = dto.ShopId
            };
            _repository.Add(productShop);
            return "Product was added to shop successfuly!";
        }

        public string Delete(int id)
        {
            var productShop = _repository.GetSingle(id);
            if (productShop == null) throw new ProductShopNotFoundException();
            _repository.Remove(productShop);
            return "Product was removed from shop successfully!";
        }

        public List<ProductShopGetDto> GetAll()
        {
            var productShops = _repository.GetAll();
            var dtos = new List<ProductShopGetDto>();
            dtos = productShops.Select(productShop => productShop.ToProductGetDto()).ToList();
            return dtos;
        }

        public ProductShopGetDto GetSingle(int id)
        {
            var productShop = _repository.GetSingle(id);
            if (productShop == null) throw new ProductShopNotFoundException();

            var dto = productShop.ToProductGetDto();
            return dto;
        }
    }
}
