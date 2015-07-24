using System.Collections.Generic;

namespace Camozzi.Model.Repository
{
    public interface IRepository<T>
        where T: class
    {
        List<T> GetAll();
        T FindById(int id);
        T FindByName(string name);
        void Add(T t);
        void Delete(T t);
        void Update(T t);
        void UpdateContext();
    }
}
