using Camozzi.Model.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camozzi.Model.Repository
{
    public interface IUserRepository
    {
        List<User> GetAll();
        List<User> FindByDept(int id);
        User FindById(int id);
        User FindByName(string name);
        void Update(User t);
        void Dispose();
    }
}
