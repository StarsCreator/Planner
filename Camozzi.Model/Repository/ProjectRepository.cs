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
            UpdateContext();
        }

        private List<ProjectDto> _project = new List<ProjectDto>(); 

        public List<ProjectDto> GetAll()
        {
            return _project;
        }

        public IEnumerable<ProjectDto> GetByDateAndDept(DateTime start, DateTime finish, int deptid)
        {
            //TODO: update query
            return GetAll();
        }

        public List<ProjectDto> GetByUser(int id)
        {
            return _project.Where(x=>x.UserId==id).ToList();
        }

        public List<ProjectDto> GetByManager(int id)
        {
            return (from pr in _project
                    where pr.ManagerId == id
                    select pr).ToList();
        }

        public List<ProjectDto> GetAllByName(string name)
        {
            return (from pr in _project
                    where pr.Name.Contains(name)
                    select pr).ToList();
        }

        public int GetCountByState(States state)
        {
            return (from pr in _project
                    where pr.State == (int)state
                    select pr).Count();
        }

        public int GetCount()
        {
            return _project.Count();
        }

        public int GetCountByStateAndUser(States state, int userId)
        {
            return (from pr in _project
                    where pr.UserId == userId
                    where pr.State == (int)state
                    select pr).Count();
        }

        public int GetCountByStateAndMounth(States state, int mounth)
        {
            //TODO add creation Time
            return (from pr in _project
                where pr.Start.Month == mounth
                where pr.State == (int) state
                select pr).Count();
        }

        public ProjectDto FindById(int id)
        {   
            return _project.Find(x => x.Id == id);
        }

        public ProjectDto FindByName(string name)
        {
            return _project.Find(x => x.Name == name);
        }

        public void Add(ProjectDto t)
        {
            using (var client = new CServiceClient("BasicHttpBinding_ICService"))
            {
                client.AddProject(t);
                UpdateContext();
            }   
        }

        public void Delete(ProjectDto t)
        {
            using (var client = new CServiceClient("BasicHttpBinding_ICService"))
            {
                client.DeleteProject(t);
                UpdateContext();
            }
        }

        public void Update(ProjectDto t)
        {
            using (var client = new CServiceClient("BasicHttpBinding_ICService"))
            {
                client.UpdateProject(t);
                UpdateContext();
            }
        }

        public void UpdateContext()     
        {
            using (var client = new CServiceClient("BasicHttpBinding_ICService"))
            {
                _project = client.GetProjects().ToList();
            }
            if (ProjectUpdated != null) ProjectUpdated();
        }
    }
}
