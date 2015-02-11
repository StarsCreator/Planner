using Camozzi.Model.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
