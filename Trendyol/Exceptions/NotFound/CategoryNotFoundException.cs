namespace Trendyol.Exceptions.NotFound
{
    public class CategoryNotFoundException : Exception
    {
        public CategoryNotFoundException() : base("Category was not found")
        {
        }
    }
}
