using System;
using System.Collections.Generic;
using Camozzi.Model.DataService;
using WeekPlanner;

namespace Camozzi.Model.Repository
{
    public interface IProjectRepository:IRepository<ProjectDto>
    {
        IEnumerable<ProjectDto> GetByDateAndDept(DateTime start, DateTime finish, int deptid);
        List<ProjectDto> GetByUser(int id);
        List<ProjectDto> GetByManager(int id);
        List<ProjectDto> GetAllByName(string name);

        int GetCountByState(States state);
        int GetCount();
        int GetCountByStateAndUser(States state, int userId);
        int GetCountByStateAndMounth(States state, int mounth);

        event Action ProjectUpdated;
    }
}
