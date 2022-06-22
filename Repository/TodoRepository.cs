using AspNet.TODO.Models;
using AspNet.TODO.Repository.Interfaces;

namespace AspNet.TODO.Repository
{
    public class TodoRepository : IRepository<Todo>, ITodoRepository
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Todo> Get()
        {
            return new List<Todo> {
                new Todo {Id = 1, NazivZadatka = "Posao", DatumUnosa = DateTime.Now.AddDays(1).AddHours(-3) } ,
                new Todo {Id = 2, NazivZadatka = "Predavanje", DatumUnosa = DateTime.Now.AddDays(1).AddHours(-5) },
                new Todo {Id = 3, NazivZadatka = "Odmor", DatumUnosa = DateTime.Now.AddHours(-4) },
                new Todo {Id = 4, NazivZadatka = "Tekma", DatumUnosa = DateTime.Now.AddDays(-3).AddHours(8) },
                new Todo {Id = 5, NazivZadatka = "Vježbanje", DatumUnosa = DateTime.Now.AddDays(-5).AddHours(-3) }
            };
        }

        public Todo GetById(int id)
        {
            return Get().FirstOrDefault(i => i.Id == id);
        }

        public void Insert(Todo entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Todo entity)
        {
            throw new NotImplementedException();
        }
    }
}
