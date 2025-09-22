using Trendyol.Models.BaseModels;

namespace Trendyol.Models
{
    public class ProductImage : BaseEntity
    {
        public string ImageName { get; set; }
        public string ImageUrl { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
