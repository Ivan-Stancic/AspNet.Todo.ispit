using AspNet.TODO.Models;

namespace AspNet.TODO.Repository.Interfaces
{
    public interface ITodoRepository
    {
        void Delete(int id);
        List<Todo> Get();
        Todo GetById(int id);
        void Insert(Todo entity);
        void Update(Todo entity);
    }
}