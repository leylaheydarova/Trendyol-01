using Trendyol.Repositories.Interfaces;

namespace Trendyol.Repositories.Implements
{
    public class Repository<T> : IRepository<T> where T : class
    {
        List<T> _models = new List<T>();
        public void Add(T model)
        {
            _models.Add(model);
        }

        public List<T> GetAll()
        {
            return _models.ToList();
        }

        public T GetSingle(int id)
        {
            return _models[id];
        }

        public void Remove(T model)
        {
            _models.Remove(model);
        }
    }
}
