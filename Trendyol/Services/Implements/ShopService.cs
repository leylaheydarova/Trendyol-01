using Trendyol.DTOs.Shop;
using Trendyol.Models;
using Trendyol.Repositories.Implements;
using Trendyol.Repositories.Interfaces;
using Trendyol.Services.Interfaces;

namespace Trendyol.Services.Implements
{
    public class ShopService : IShopService
    {
        IShopRepository _repository = new ShopRepository();
        public string Create(ShopCreateDto dto)
        {
            var shops = _repository.GetAll();
            int id = 0;
            if (shops.Any())
            {
                id = shops.Last().Id;
            }
            var shop = new Shop()
            {
                Address = dto.Address,
                Name = dto.Name,
                Id = id + 1
            };
            _repository.Add(shop);
            return "Shop created successfully.";
        }

        public string Delete(int categoryId)
        {
            throw new NotImplementedException();
        }

        public List<ShopGetDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public ShopGetDto GetSingle(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
