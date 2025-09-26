using Trendyol.Models.BaseModels;

namespace Trendyol.Models
{
    public class ProductShop : BaseEntity //hansi mehsulun hansi magazada satildigini ozunde saxlayir
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int ShopId { get; set; }
        public Shop Shop { get; set; }
    }
}
