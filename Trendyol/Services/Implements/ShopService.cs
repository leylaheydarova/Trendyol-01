using Trendyol.DTOs.Shop;
using Trendyol.Models;
using Trendyol.Services.Interfaces;

namespace Trendyol.Services.Implements
{
    public class ShopService : IShopService
    {
        List<Shop> _shops = new List<Shop>();
        public string Create(ShopCreateDto dto)
        {
            int id = 0;
            if (_shops.Any())
            {
                id = _shops.Last().Id;
            }
            var shop = new Shop()
            {
                Address = dto.Address,
                Name = dto.Name,
                Id = id + 1
            };
            _shops.Add(shop);
            return "Shop created successfully.";
        }
    }
}
