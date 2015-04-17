using Camozzi.Model.Repository;
using Camozzi.Model.Services;
using Camozzi.Presentation.Injection;
using Camozzi.Presentation.Views;
using System;
using System.Linq;
using Camozzi.Model.DataService;
using WeekPlanner;

namespace Camozzi.Presentation.Presenters
{
    public class MainPresenter : BasePresenter<IMainView, User>
    {
        private User _mainUser; //пользователь
        private Project _updatedProject;
        private Reclamation _updatedReclamation;

        private readonly IChartService _chartService;
        private readonly ITableService _tableService;
        private readonly IReclamationRepository _reclamations;
        private readonly IProjectRepository _projects;
        private readonly IUserRepository _users;
        private readonly ILog _log;

        public MainPresenter(IApplicationController controller, IMainView view, ILog log, IProjectRepository projects,
            IUserRepository users, IReclamationRepository reclamations, ITableService tableService,
            IChartService chartService) : base(controller, view)
        {
            _reclamations = reclamations;
            _tableService = tableService;
            _chartService = chartService;
            _projects = projects;
            _users = users;
            _log = log;

            View.AllProjectsItemDoubleClick += View_AllProjectsItemDoubleClick;
            View.AllReclamationsItemDoubleClick += View_AllReclamationsItemDoubleClick;
            View.SelfProjectsItemDoubleClick += View_SelfProjectsItemDoubleClick;
            View.SelfReclamationsItemDoubleClick += View_SelfReclamationsItemDoubleClick;
            View.TableProjectClick += View_TableProjectClick;
            View.TableReclamationClick += View_TableReclamationClick;
            View.CreateProject += View_CreateProject;
            View.DeleteProject += View_DeleteProject;
        }

        private void View_TableProjectClick(int obj)
        {
            try
            {
                _updatedProject = _projects.FindById(obj);
                Controller.Run<ProjectPresenter, Project, User>(_updatedProject, _mainUser);
                if (!_updatedProject.AllowChanges) return;
                _projects.Update(_updatedProject);
            }
            catch (Exception ex)
            {
                _log.Error("View_TableProjectClick", ex.Message);
            }
        }

        private void View_DeleteProject(int obj)
        {
            try
            {
                _projects.Delete(_projects.FindById(obj));
                View.TableProject = _tableService.GetProjectTable(_projects.GetByUser(_mainUser.Id));
                ReCreateSelfProjects(DateTime.Today, DateTime.Today);
                ReCreateProjects(DateTime.Today, DateTime.Today.AddDays(10));
            }
            catch (Exception ex)
            {
                _log.Error("View_DeleteProject", ex.Message);
            }
        }

        private void View_CreateProject()
        {
            try
            {
                _updatedProject = new Project()

                {
                    Start = DateTime.Today,
                    Finish = DateTime.Today.AddDays(3),
                    Worker = _mainUser,
                    UserId = _mainUser.Id,
                    Manager = _users.FindByDept(3).First(),
                    ManagerId = _users.FindByDept(3).First().Id,
                    Creator = _mainUser,
                    CreatorId = _mainUser.Id,
                    CreationDate = DateTime.Today,
                    Depts = _mainUser.Dept,
                    DeptId = _mainUser.DeptId,
                    Comment = "Тут может быть любая информация, касающаяся проекта/задачи/деятельности...",
                };
                Controller.Run<ProjectPresenter, Project, User>(_updatedProject, _mainUser);
                if (_updatedProject.Name == null) return;
                _projects.Add(_updatedProject);
                View.TableProject = _tableService.GetProjectTable(_projects.GetByUser(_mainUser.Id));
                ReCreateSelfProjects(DateTime.Today, DateTime.Today);
                ReCreateProjects(DateTime.Today, DateTime.Today.AddDays(10));
            }
            catch (Exception ex)
            {
                _log.Error("View_CreateProject", ex.Message);
            }
        }

        private void View_TableReclamationClick(int obj)
        {
            try
            {
                _updatedReclamation = _reclamations.FindById(obj);
                if (_updatedReclamation.Nomenclature != "null")
                {
                    _reclamations.Update(_updatedReclamation);
                }
            }
            catch (Exception ex)
            {
                _log.Error("View_TableReclamationClick", ex.Message);
            }
        }

        private void View_SelfReclamationsItemDoubleClick(object sender, WeekPlannerItemEventArgs e)
        {
            try
            {
                _updatedReclamation = _reclamations.FindByName(e.Item.Subject);
                Controller.Run<ReclamationPresenter, Reclamation, User>(_updatedReclamation, _mainUser);
                if (_updatedReclamation.Nomenclature != "null")
                {
                    _reclamations.Update(_updatedReclamation);
                }
            }
            catch (Exception ex)
            {
                _log.Error("View_SelfReclamationsItemDoubleClick", ex.Message);
            }
        }

        private void View_SelfProjectsItemDoubleClick(object sender, WeekPlannerItemEventArgs e)
        {
            try
            {
                _updatedProject = _projects.FindById(Int32.Parse(e.Item.Name));
                Controller.Run<ProjectPresenter, Project, User>(_updatedProject, _mainUser);
                if (!_updatedProject.AllowChanges) return;
                _projects.Update(_updatedProject);
                ReCreateSelfProjects(DateTime.Today, DateTime.Today);
                //TODO: add date
                ReCreateProjects(DateTime.Today, DateTime.Today.AddDays(10));
            }
            catch (Exception ex)
            {
                _log.Error("View_SelfProjectsItemDoubleClick", ex.Message);
            }
        }

        private void View_AllReclamationsItemDoubleClick(object sender, WeekPlannerItemEventArgs e)
        {
            try
            {
                _updatedReclamation = _reclamations.FindByName(e.Item.Subject);
                if (_updatedReclamation.Nomenclature != "null")
                {
                    _reclamations.Update(_updatedReclamation);
                }
            }
            catch (Exception ex)
            {
                _log.Error("View_AllReclamationsItemDoubleClick", ex.Message);
            }
        }

        private void View_AllProjectsItemDoubleClick(object sender, WeekPlannerItemEventArgs e)
        {
            try
            {
                _updatedProject = _projects.FindById(Int32.Parse(e.Item.Name));
                Controller.Run<ProjectPresenter, Project, User>(_updatedProject, _mainUser);
                if (!_updatedProject.AllowChanges) return;
                _projects.Update(_updatedProject);
                ReCreateSelfProjects(DateTime.Today, DateTime.Today);
                //TODO: add date
                ReCreateProjects(DateTime.Today, DateTime.Today.AddDays(10));
            }
            catch (Exception ex)
            {
                _log.Error("View_AllProjectsItemDoubleClick", ex.Message);
            }
        }

        public override void Run(User argument)
        {
            _mainUser = argument;
            View.AllowReclamation = _mainUser.Account.AllowReclamation;
            View.Show();

            View.ChartProject = _chartService.GetTable(_projects.GetAll().ToList());
            View.ChartSelfProject = _chartService.GetTable(_projects.GetByUser(_mainUser.Id), _mainUser);
            View.TableProject = _tableService.GetProjectTable(_projects.GetByUser(_mainUser.Id));

            //TODO: add dates from settings
            ReCreateSelfProjects(DateTime.Today, DateTime.Today);
            ReCreateProjects(DateTime.Today, DateTime.Today.AddDays(10));
            ReCreateReclamations(DateTime.Today.AddDays(-50), DateTime.Today.AddDays(10));
        }

        private void ReCreateSelfProjects(DateTime start, DateTime finish)
        {
            try
            {
                View.ClearSelfProjects();
                View.SelfProjectsRows.Add(View.GetNewRowAllProjects(_mainUser.Name));

                var proj = _projects.GetByUser(_mainUser.Id);

                foreach (var item in proj.Select(_proj => new WeekPlannerItem
                {
                    StartDate = _proj.Start,
                    EndDate = _proj.Finish,
                    Subject = _proj.Name,
                    Name = _proj.Id.ToString(),
                    Tag = _proj,
                    State = (States) _proj.State
                }))
                {
                    View.SelfProjectsRows.First().Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                _log.Error("RecreateProjects", ex.Message);
            }
        }

        private void ReCreateProjects(DateTime start, DateTime finish)
        {
            try
            {
                View.ClearAllProjects();

                var users = _users.FindByDept(_mainUser.DeptId); //////!!!!!!!

                foreach (var user in users.Where(user => user.Account.AllowRow))
                {
                    user.AllProjectsRow = View.GetNewRowAllProjects(user.Name);
                    View.AllProjectsRows.Add((WeekPlannerRow) user.AllProjectsRow);
                }

                var proj = _projects.GetByDateAndDept(start, finish, _mainUser.DeptId); ///////!!!!!!!


                foreach (var _proj in proj)
                {
                    var item = new WeekPlannerItem
                    {
                        StartDate = _proj.Start,
                        EndDate = _proj.Finish,
                        Subject = _proj.Name,
                        Name = _proj.Id.ToString(),
                        Tag = _proj,
                        State = (States) _proj.State
                    };

                    var row = (WeekPlannerRow) (_users.FindById(_proj.Worker.Id)).AllProjectsRow;
                    row.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                _log.Error("RecreateProjects", ex.Message);
            }
        }

        private void ReCreateReclamations(DateTime start, DateTime finish)
        {
            try
            {
                View.ClearAllReclamations();

                var users = _users.FindByDept(2); //////!!!!!!!
                foreach (var user in users.Where(user => user.Account.AllowRow))
                {
                    user.AllReclamationRow = View.GetNewRowAllProjects(user.Name);
                    View.AllReclamationsRows.Add((WeekPlannerRow) user.AllReclamationRow);
                }

                var proj = _reclamations.GetByDateAndDept(start, finish); ///////!!!!!!!


                foreach (var _proj in proj)
                {
                    var item = new WeekPlannerItem
                    {
                        StartDate = _proj.Start,
                        EndDate = _proj.Finish,
                        Subject = _proj.Nomenclature,
                        Name = _proj.Nomenclature,
                        Tag = _proj,
                        State = (States) _proj.State
                    };

                    var row = (WeekPlannerRow) _proj.Worker.AllReclamationRow;
                    row.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                _log.Error("RecreateProjects", ex.Message);
            }
        }
    }
}