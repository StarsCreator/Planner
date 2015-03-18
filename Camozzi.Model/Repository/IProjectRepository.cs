using Camozzi.Model.Services;
using System;
using System.Collections.Generic;

namespace Camozzi.Model.Repository
{
    public interface IProjectRepository
    {
        List<Project> GetAll();
        List<Project> GetByDateAndDept(DateTime start, DateTime finish, int deptid);
        List<Project> GetByUser(int id);
        List<Project> GetByManager(int id);
        List<Project> GetAllByName(string name);

        int GetCountByState(int state);
        int GetCountByStateAndUser(int state, int userId);

        Project FindById(int id);
        Project FindByName(string name);

        void CreateProject(Project project);
        void Update(Project t);
        void DeleteProject(Project project);

        void UpdateContext();
    }
}
