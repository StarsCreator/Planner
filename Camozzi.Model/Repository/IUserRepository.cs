using System;
using System.Collections.Generic;
using Camozzi.Model.DataService;

namespace Camozzi.Model.Repository
{
    public interface IUserRepository:IRepository<User>
    {
        List<User> FindByDept(int id);

        event Action UserUpdated;
    }
}
