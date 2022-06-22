using AspNet.TODO.Models;

namespace AspNet.TODO.Repository
{
    public interface IRepository<T> where T : EntityBase
    {
        List<T> Get();
        T GetById(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
