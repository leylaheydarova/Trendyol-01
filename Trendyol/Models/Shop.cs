using Trendyol.Models.BaseModels;

namespace Trendyol.Models
{
    public class Shop : BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public ICollection<ProductShop> Products { get; set; } = new List<ProductShop>();
    }
}
