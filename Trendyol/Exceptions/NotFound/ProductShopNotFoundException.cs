namespace Trendyol.Exceptions.NotFound
{
    public class ProductShopNotFoundException : Exception
    {
        public ProductShopNotFoundException() : base("ProductShop was not found")
        {
        }
    }
}
