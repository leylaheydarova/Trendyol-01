namespace Trendyol.DTOs.Product
{
    public class ProductCreateDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int DiscountPersentage { get; set; }
        public int CategoryId { get; set; }
        public ICollection<ProductImageCreateDto> ImageDtos { get; set; } = new List<ProductImageCreateDto>();
    }
}
