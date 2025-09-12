namespace Trendyol.Exceptions.NotFound
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string message) : base($"{message} was not found")
        {

        }
    }
}
