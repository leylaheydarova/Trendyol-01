namespace Trendyol.Repositories.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void Add(T model);
        void Remove(T model);
        List<T> GetAll();
        T GetSingle(int id);
    }
}
