﻿using Camozzi.Model.Repository;
using Camozzi.Model.Services;
using Camozzi.Model.Args;
using Camozzi.Presentation.Injection;
using Camozzi.Presentation.Views;
using System;
using System.Linq;
using WeekPlanner;

namespace Camozzi.Presentation.Presenters
{
    public class MainPresenter: BasePresenter<IMainView,User>
    {
        User _mainUser;  //пользователь
        Project _updatedProject;
        Reclamation _updatedReclamation;

        protected readonly IChartService ChartService;
        protected readonly ITableService TableService;
        protected readonly IReclamationRepository Reclamations;
        protected readonly IProjectRepository Projects;
        protected readonly IUserRepository Users;
        protected readonly ILog Log;

        public MainPresenter(IApplicationController controller, IMainView view,ILog log,IProjectRepository projects,IUserRepository users,IReclamationRepository reclamations, ITableService tableService, IChartService chartService):base(controller,view)
        {
            Reclamations = reclamations;
            TableService = tableService;
            ChartService = chartService;
            Projects = projects;
            Users = users;
            Log = log;

            View.AllProjectsItemDoubleClick += View_AllProjectsItemDoubleClick;
            View.AllReclamationsItemDoubleClick += View_AllReclamationsItemDoubleClick;
            View.SelfProjectsItemDoubleClick += View_SelfProjectsItemDoubleClick;
            View.SelfReclamationsItemDoubleClick += View_SelfReclamationsItemDoubleClick;
            View.TableProjectClick += View_TableProjectClick;
            View.TableReclamationClick += View_TableReclamationClick;
            View.CreateProject += View_CreateProject;
            View.DeleteProject += View_DeleteProject;
        }

        void View_DeleteProject(object sender, TableClickArgs e)
        {
            try
            {
                Projects.DeleteProject(Projects.FindById(e.Id));
                View.TableProject = TableService.GetProjectTable(Projects.GetByUser(_mainUser.Id));
                ReCreateSelfProjects(DateTime.Today,DateTime.Today);
                ReCreateProjects(DateTime.Today,DateTime.Today.AddDays(10));
            }
            catch (Exception ex)
            {
                Log.Error("View_DeleteProject", ex.Message);
            }
        }

        void View_CreateProject()
        {
            try
            {
                _updatedProject = new Project()

                {
                    Start = DateTime.Today,
                    Finish = DateTime.Today.AddDays(3),
                    User = _mainUser,
                    UserId = _mainUser.Id,
                    Manager = Users.FindByDept(3).First(),
                    ManagerId = Users.FindByDept(3).First().Id,
                    Creator = _mainUser,
                    CreatorId = _mainUser.Id,
                    CreationDate = DateTime.Today,
                    Dept = _mainUser.Dept,
                    DeptId = _mainUser.DeptId,
                    Comment = "Тут может быть любая информация, касающаяся проекта/задачи/деятельности...",                   
                    
                };
                Controller.Run<ProjectPresenter, Project, User>(_updatedProject, _mainUser);
                if (_updatedProject.Name != null)
                {
                    Projects.CreateProject(_updatedProject);
                    View.TableProject = TableService.GetProjectTable(Projects.GetByUser(_mainUser.Id));
                    ReCreateSelfProjects(DateTime.Today, DateTime.Today);
                    ReCreateProjects(DateTime.Today, DateTime.Today.AddDays(10));
                }
            }
            catch (Exception ex)
            {
                Log.Error("View_CreateProject", ex.Message);
            }
        }

        void View_TableReclamationClick(object sender, TableClickArgs e)
        {
            try
            {
                _updatedReclamation = Reclamations.FindById(e.Id);
                if (_updatedReclamation.Nomenclature != "null")
                {
                    Reclamations.Update(_updatedReclamation);

                }
            }
            catch (Exception ex)
            {
                Log.Error("View_TableReclamationClick", ex.Message);
            }
        }

        void View_TableProjectClick(object sender, TableClickArgs e)
        {
            try
            {
                _updatedProject = Projects.FindById(e.Id);
                Controller.Run<ProjectPresenter, Project, User>(_updatedProject, _mainUser);
                if (_updatedProject.Name != "null")
                {
                    Projects.Update(_updatedProject);
                }
            }
            catch (Exception ex)
            {
                Log.Error("View_TableProjectClick", ex.Message);
            }
        }

        void View_SelfReclamationsItemDoubleClick(object sender, WeekPlannerItemEventArgs e)
        {
            try
            {
                _updatedReclamation = Reclamations.FindByName(e.Item.Subject);
                Controller.Run<ReclamationPresenter, Reclamation,User>(_updatedReclamation,_mainUser);
                if (_updatedReclamation.Nomenclature != "null")
                {
                    Reclamations.Update(_updatedReclamation);

                }
            }
            catch (Exception ex)
            {
                Log.Error("View_SelfReclamationsItemDoubleClick", ex.Message);
            }
        }

        void View_SelfProjectsItemDoubleClick(object sender, WeekPlannerItemEventArgs e)
        {
            try
            {
                _updatedProject = Projects.FindByName(e.Item.Subject);
                Controller.Run<ProjectPresenter, Project, User>(_updatedProject,_mainUser);
                if (_updatedProject.Name != "null")
                {
                    Projects.Update(_updatedProject);
                    ReCreateSelfProjects(DateTime.Today, DateTime.Today);
                    ReCreateProjects(DateTime.Today, DateTime.Today.AddDays(10));
                }
            }
            catch (Exception ex)
            {
                Log.Error("View_SelfProjectsItemDoubleClick", ex.Message);
            }
        }

        void View_AllReclamationsItemDoubleClick(object sender, WeekPlannerItemEventArgs e)
        {
            try
            {
                _updatedReclamation = Reclamations.FindByName(e.Item.Subject);
                if (_updatedReclamation.Nomenclature != "null")
                {
                    Reclamations.Update(_updatedReclamation);

                }
            }
            catch (Exception ex)
            {
                Log.Error("View_AllReclamationsItemDoubleClick", ex.Message);
            }

        }

        void View_AllProjectsItemDoubleClick(object sender, WeekPlannerItemEventArgs e)
        {
            try
            {
                _updatedProject = Projects.FindByName(e.Item.Subject);
                Controller.Run<ProjectPresenter, Project, User>(_updatedProject,_mainUser);
                if (_updatedProject.Name != "null")
                {
                    Projects.Update(_updatedProject);
                    ReCreateSelfProjects(DateTime.Today, DateTime.Today);
                    ReCreateProjects(DateTime.Today, DateTime.Today.AddDays(10));
                }
            }
            catch(Exception ex)
            {
                Log.Error("View_AllProjectsItemDoubleClick", ex.Message);
            }
        }

        public override void Run(User argument)
        {
            _mainUser = argument;
            View.AllowReclamation = _mainUser.Account.AllowReclamation;
            View.Show();

            View.ChartProject = ChartService.GetTable(Projects.GetAll().ToList());
            View.ChartSelfProject = ChartService.GetTable(Projects.GetByUser(_mainUser.Id),_mainUser);
            View.TableProject = TableService.GetProjectTable(Projects.GetByUser(_mainUser.Id));

            ReCreateSelfProjects(DateTime.Today, DateTime.Today);
            ReCreateProjects(DateTime.Today, DateTime.Today.AddDays(10));
            ReCreateReclamations(DateTime.Today.AddDays(-50), DateTime.Today.AddDays(10));
        }

        void ReCreateSelfProjects(DateTime start,DateTime finish)
        {
            try
            {
                View.ClearSelfProjects();
                View.SelfProjectsRows.Add(View.GetNewRowAllProjects(_mainUser.Name));

                var proj = Projects.GetByUser(_mainUser.Id);///////!!!!!!!

                foreach (Project _proj in proj)
                {
                    WeekPlannerItem item = new WeekPlannerItem
                    {
                        StartDate = _proj.Start,
                        EndDate = _proj.Finish,
                        Subject = _proj.Name,
                        Name = _proj.Name,
                        Tag = _proj,
                        State = (States) _proj.State
                    };

                    View.SelfProjectsRows.First().Items.Add(item);


                }


            }
            catch (Exception ex)
            {
                Log.Error("RecreateProjects", ex.Message);
            }
        }

        void ReCreateProjects(DateTime start, DateTime finish)
        {
            try
            {
                View.ClearAllProjects();
                
                var users = Users.FindByDept(_mainUser.DeptId);                        //////!!!!!!!
                foreach (User user in users)
                {

                    if (user.Account.AllowRow)
                    {
                        user.AllProjectsRow = View.GetNewRowAllProjects(user.Name);
                        View.AllProjectsRows.Add((WeekPlannerRow)user.AllProjectsRow);
                    }
                }

                var proj = Projects.GetByDateAndDept(start, finish, _mainUser.DeptId);///////!!!!!!!
                
                

                foreach (Project _proj in proj)
                {
                    WeekPlannerItem item = new WeekPlannerItem
                    {
                        StartDate = _proj.Start,
                        EndDate = _proj.Finish,
                        Subject = _proj.Name,
                        Name = _proj.Name,
                        Tag = _proj,
                        State = (States) _proj.State
                    };

                    WeekPlannerRow row = (WeekPlannerRow)_proj.User.AllProjectsRow;
                    row.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Log.Error("RecreateProjects", ex.Message);
            }
        }

        void ReCreateReclamations(DateTime start, DateTime finish)
        {
            try
            {
                View.ClearAllReclamations();

                var users = Users.FindByDept(2);                        //////!!!!!!!
                foreach (User user in users)
                {

                    if (user.Account.AllowRow)
                    {
                        user.AllReclamationsRow = View.GetNewRowAllProjects(user.Name);
                        View.AllReclamationsRows.Add((WeekPlannerRow)user.AllReclamationsRow);
                    }
                }

                var proj = Reclamations.GetByDateAndDept(start, finish);///////!!!!!!!



                foreach (Reclamation _proj in proj)
                {
                    WeekPlannerItem Item = new WeekPlannerItem();
                    Item.StartDate = _proj.Start;
                    Item.EndDate = _proj.Finish;
                    Item.Subject = _proj.Nomenclature;
                    Item.Name = _proj.Nomenclature;
                    Item.Tag = _proj;
                    Item.State = (States)_proj.State;                  
                    WeekPlannerRow row = (WeekPlannerRow)_proj.User.AllReclamationsRow;
                    row.Items.Add(Item);
                }
            }
            catch (Exception ex)
            {
                Log.Error("RecreateProjects", ex.Message);
            }
        }

    }
}
