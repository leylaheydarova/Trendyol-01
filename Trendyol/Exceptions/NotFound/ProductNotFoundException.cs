namespace Trendyol.Exceptions.NotFound
{
    public class ProductNotFoundException : Exception
    {
        public ProductNotFoundException() : base("Product was not found")
        {
        }
    }
}
