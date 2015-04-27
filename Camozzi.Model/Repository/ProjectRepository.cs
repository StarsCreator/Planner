using System;
using System.Collections.Generic;
using System.Linq;
using Camozzi.Model.DataService;
using WeekPlanner;

namespace Camozzi.Model.Repository
{
    public class ProjectRepository:IProjectRepository
    {


        public event Action ProjectUpdated;
        public ProjectRepository()
        {
            UpdateProjects();
        }

        private List<Project> _projects = new List<Project>(); 

        public List<Project> GetAll()
        {
            return _projects;
        }

        public IEnumerable<Project> GetByDateAndDept(DateTime start, DateTime finish, int deptid)
        {
            //TODO: update query
            return (from pr in _projects
                    //where pr.Start>Start 
                    where pr.Finish < finish
                    where pr.DeptId == deptid
                    select pr).ToList();
        }

        public List<Project> GetByUser(int id)
        {
            return (from pr in _projects
                    where pr.UserId == id
                    select pr).ToList();
        }

        public List<Project> GetByManager(int id)
        {
            return (from pr in _projects
                    where pr.ManagerId == id
                    select pr).ToList();
        }

        public List<Project> GetAllByName(string name)
        {
            return (from pr in _projects
                    where pr.Name.Contains(name)
                    select pr).ToList();
        }

        public int GetCountByState(States state)
        {
            return (from pr in _projects
                    where pr.State == (int)state
                    select pr).Count();
        }

        public int GetCount()
        {
            return _projects.Count();
        }

        public int GetCountByStateAndUser(States state, int userId)
        {
            return (from pr in _projects
                    where pr.UserId == userId
                    where pr.State == (int)state
                    select pr).Count();
        }

        public int GetCountByStateAndMounth(States state, int mounth)
        {
            //TODO add creation Time
            return (from pr in _projects
                where pr.Start.Month == mounth
                where pr.State == (int) state
                select pr).Count();
        }

        public Project FindById(int id)
        {
            return _projects.Find(x => x.Id == id);
        }

        public Project FindByName(string name)
        {
            return _projects.Find(x => x.Name == name);
        }

        public void Add(Project t)
        {
            using (var client = new CServiceClient("NetTcpBinding_ICService"))
            {
                client.AddProject(t);
                UpdateProjects();
            }
        }

        public void Delete(Project t)
        {
            using (var client = new CServiceClient("NetTcpBinding_ICService"))
            {
                client.DeleteProject(t);
                UpdateProjects();
            }
        }

        public void Update(Project t)
        {
            using (var client = new CServiceClient("NetTcpBinding_ICService"))
            {
                client.UpdateProject(t);
                UpdateProjects();
            }
        }

        private void UpdateProjects()
        {
            using (var client = new CServiceClient("NetTcpBinding_ICService"))
            {
                _projects = client.GetProjects().ToList();
            }
            if (ProjectUpdated != null) ProjectUpdated();
        }
    }
}
