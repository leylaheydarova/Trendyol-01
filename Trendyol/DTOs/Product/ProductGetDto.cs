namespace Trendyol.DTOs.Product
{
    public class ProductGetDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int DiscountPersentage { get; set; }
        public int CategoryId { get; set; }
        public ICollection<ProductImageGetDto> ImageDtos { get; set; } = new List<ProductImageGetDto>();
    }
}
