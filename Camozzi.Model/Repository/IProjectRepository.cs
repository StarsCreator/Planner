using System;
using System.Collections.Generic;
using Camozzi.Model.DataService;
using WeekPlanner;

namespace Camozzi.Model.Repository
{
    public interface IProjectRepository:IRepository<Project>
    {
        IEnumerable<Project> GetByDateAndDept(DateTime start, DateTime finish, int deptid);
        List<Project> GetByUser(int id);
        List<Project> GetByManager(int id);
        List<Project> GetAllByName(string name);

        int GetCountByState(States state);
        int GetCount();
        int GetCountByStateAndUser(States state, int userId);
        int GetCountByStateAndMounth(States state, int mounth);

        event Action ProjectUpdated;
    }
}
