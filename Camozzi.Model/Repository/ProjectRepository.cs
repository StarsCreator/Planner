using Camozzi.Model.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Camozzi.Model.Repository
{
    public class ProjectRepository: RepositoryBase<Project>,IProjectRepository
    {
        public override Project FindByName(string name)
        {
            return _context.Projects.First(x => x.Name == name);
        }

        public List<Project> GetByDateAndDept(DateTime start, DateTime finish, int deptid)
        {
            var proj = (from pr in _context.Projects 
                    //where pr.Start>Start 
                       where pr.Finish<finish
                       where pr.DeptId==deptid select pr).ToList();
            return proj;
        }

        public List<Project> GetAllByName(string name)
        {
            var proj = (from pr in _context.Projects
                        where pr.Name.Contains(name)
                        select pr).ToList();
            return proj;
        }

        public List<Project> GetByUser(int id)
        {
            var proj = (from pr in _context.Projects
                        where pr.UserId == id
                        select pr).ToList();
            return proj;
        }

        public List<Project> GetByManager(int id)
        {
            var proj = (from pr in _context.Projects
                        where pr.ManagerId == id
                        select pr).ToList();
            return proj;
        }
        
        public override void Update(Project t)
        {
            _context.Projects.Attach(t);
            var entry = _context.Entry(t);
            entry.Property(e => e.Name).IsModified = true;
            entry.Property(e => e.Start).IsModified = true;
            entry.Property(e => e.Finish).IsModified = true;
            entry.Property(e => e.UserId).IsModified = true;
            entry.Property(e => e.ManagerId).IsModified = true;
            entry.Property(e => e.Comment).IsModified = true;
            entry.Property(e => e.Priority).IsModified = true;
            entry.Property(e => e.State).IsModified = true;
            _context.SaveChanges();
        }

        public int GetCountByState(int state)
        {
            int proj = (from pr in _context.Projects
                        where pr.State == state
                        select pr).Count();
            return proj;
        }

        public int GetCountByStateAndUser(int state,int userId)
        {
            int proj = (from pr in _context.Projects
                        where pr.UserId == userId
                        where pr.State == state
                        select pr).Count();
            return proj;
        }

        public void CreateProject(Project project)
        {
            _context.Projects.Add(project);
            _context.SaveChanges();
        }

        public void DeleteProject(Project project)
        {
            _context.Projects.Remove(project);
            _context.SaveChanges();
        }

        public override void UpdateContext()
        {
            base.UpdateContext();
        }
    }
}
