using System;
using System.Collections.Generic;
using Camozzi.Model.DataService;

namespace Camozzi.Model.Repository
{
    public interface IProjectRepository:IRepository<Project>
    {
        IEnumerable<Project> GetByDateAndDept(DateTime start, DateTime finish, int deptid);
        List<Project> GetByUser(int id);
        List<Project> GetByManager(int id);
        List<Project> GetAllByName(string name);

        int GetCountByState(int state);
        int GetCountByStateAndUser(int state, int userId);
    }
}
