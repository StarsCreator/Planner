using Camozzi.Model.Repository;
using Camozzi.Model.Services;
using Camozzi.Presentation.Injection;
using Camozzi.Presentation.Views;
using System;
using System.Linq;
using System.Timers;
using Camozzi.Model.DataService;
using WeekPlanner;

namespace Camozzi.Presentation.Presenters
{
    public class MainPresenter : BasePresenter<IMainView, UserDto>
    {
        private UserDto _mainUser; //пользователь
        private ProjectDto _updatedProject;
        private ReclamationDto _updatedReclamation;

        private readonly Timer _timer = new Timer(10000);

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
            View.CreateReclamation += View_CreateReclamation;
            View.DeleteReclamation += View_DeleteReclamation;

            _projects.ProjectUpdated += _projects_ProjectUpdated;
            _reclamations.ReclamationUpdated += _reclamations_ReclamationUpdated;

            _timer.Elapsed += _timer_Elapsed;
        }

        private void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            _timer.Stop();
            //_users.UpdateContext();
            //_projects.UpdateContext();
            //if (_mainUser.AccountDto.AllowReclamation)
            //{
            //    _reclamations.UpdateContext();
            //}

            GC.Collect();
            _timer.Start();
        }

        private void _reclamations_ReclamationUpdated()
        {
            _timer.Stop();
            ReCreateReclamations(DateTime.Today, DateTime.Today.AddDays(10));
            ReCreateSelfReclamation(DateTime.Today, DateTime.Today);
            View.TableReclamation = _tableService.GetReclamationTable(_reclamations.GetByUser(_mainUser.Id));
            _timer.Start();
        }

        private void _projects_ProjectUpdated()
        {
            _timer.Stop();
            ReCreateProjects(DateTime.Today, DateTime.Today.AddDays(10));
            ReCreateSelfProjects(DateTime.Today, DateTime.Today);
            View.TableProject = _tableService.GetProjectTable(_projects.GetByUser(_mainUser.Id));
            View.allProj = _projects.GetCount();
            View.comProj = _projects.GetCountByState(States.Complete);
            View.stopProj = _projects.GetCountByState(States.Suspended);
            View.workProj = _projects.GetCountByState(States.Work);
            View.waitProj = _projects.GetCountByState(States.Queue);
            _timer.Start();
        }

        private void View_CreateReclamation()
        {
            try
            {
                _timer.Stop();
                _updatedReclamation = new ReclamationDto()
                {
                    Start = DateTime.Today,
                    Finish = DateTime.Today.AddDays(3),
                    Send = DateTime.Today,
                    Worker = _mainUser,
                    UserId = _mainUser.Id,
                    Manager = _users.FindByDept(3).First(),
                    ManagerId = _users.FindByDept(3).First().Id,
                    Creator = _mainUser,
                    CreatorId = _mainUser.Id,
                    Client = "Тут может быть любая информация, касающаяся клиента...",
                    Comment = "Тут может быть любая информация, касающаяся рекламации/задачи/деятельности..."
                };
                Controller.Run<ReclamationPresenter, ReclamationDto, UserDto>(_updatedReclamation, _mainUser);
                _timer.Start();
                if (!_updatedReclamation.AllowChanges) return;
                _reclamations.Add(_updatedReclamation);
            }
            catch (Exception ex)
            {
                lock (View)
                {
                    _log.Error("View_CreateReclamation", ex.Message);
                }
            }
        }

        private void View_CreateProject()
        {
            try
            {
                _timer.Stop();
                _updatedProject = new ProjectDto()

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
                    DeptsDto = _mainUser.DeptDto,
                    DeptId = _mainUser.DeptId,
                    Comment = "Тут может быть любая информация, касающаяся проекта/задачи/деятельности...",
                };
                Controller.Run<ProjectPresenter, ProjectDto, UserDto>(_updatedProject, _mainUser);
                _timer.Start();
                if (!_updatedProject.AllowChanges) return;
                _projects.Add(_updatedProject);
            }
            catch (Exception ex)
            {
                lock (View)
                {
                    _log.Error("View_CreateProject", ex.Message);
                }
            }
        }

        private void View_TableProjectClick(int obj)
        {
            try
            {
                _timer.Stop();
                _updatedProject = _projects.FindById(obj);
                Controller.Run<ProjectPresenter, ProjectDto, UserDto>(_updatedProject, _mainUser);
                _timer.Start();
                if (!_updatedProject.AllowChanges) return;
                _projects.Update(_updatedProject);
            }
            catch (Exception ex)
            {
                lock (View)
                {
                    _log.Error("View_TableProjectClick", ex.Message);
                }
            }
        }

        private void View_TableReclamationClick(int obj)
        {
            try
            {
                _timer.Stop();
                _updatedReclamation = _reclamations.FindById(obj);
                Controller.Run<ReclamationPresenter, ReclamationDto, UserDto>(_updatedReclamation, _mainUser);
                _timer.Start();
                if (!_updatedReclamation.AllowChanges) return;
                _reclamations.Update(_updatedReclamation);
            }
            catch (Exception ex)
            {
                lock (View)
                {
                    _log.Error("View_TableReclamationClick", ex.Message);
                }
            }
        }

        private void View_DeleteProject(int obj)
        {
            try
            {
                _timer.Stop();
                _projects.Delete(_projects.FindById(obj));
                View.TableProject = _tableService.GetProjectTable(_projects.GetByUser(_mainUser.Id));
                //ReCreateSelfProjects(DateTime.Today, DateTime.Today);
                //ReCreateProjects(DateTime.Today, DateTime.Today.AddDays(10));
                _timer.Start();
            }
            catch (Exception ex)
            {
                lock (View)
                {
                    _log.Error("View_DeleteProject", ex.Message);
                }
            }
        }

        private void View_DeleteReclamation(int obj)
        {
            try
            {
                _timer.Stop();
                _reclamations.Delete(_reclamations.FindById(obj));
                View.TableReclamation = _tableService.GetReclamationTable(_reclamations.GetByUser(_mainUser.Id));
                _timer.Start();
            }
            catch (Exception ex)
            {
                lock (View)
                {
                    _log.Error("View_DeleteProject", ex.Message);
                }
            }
        }

        private void View_SelfReclamationsItemDoubleClick(object sender, WeekPlannerItemEventArgs e)
        {
            try
            {
                _timer.Stop();
                _updatedReclamation = _reclamations.FindById(Int32.Parse(e.Item.Name));
                Controller.Run<ReclamationPresenter, ReclamationDto, UserDto>(_updatedReclamation, _mainUser);
                _timer.Start();
                if (!_updatedReclamation.AllowChanges) return;
                _reclamations.Update(_updatedReclamation);
            }
            catch (Exception ex)
            {
                lock (View)
                {
                    _log.Error("View_SelfReclamationsItemDoubleClick", ex.Message);
                }
            }
        }

        private void View_SelfProjectsItemDoubleClick(object sender, WeekPlannerItemEventArgs e)
        {
            try
            {
                _timer.Stop();
                _updatedProject = _projects.FindById(Int32.Parse(e.Item.Name));
                Controller.Run<ProjectPresenter, ProjectDto, UserDto>(_updatedProject, _mainUser);
                _timer.Start();
                if (!_updatedProject.AllowChanges) return;
                _projects.Update(_updatedProject);
                //ReCreateSelfProjects(DateTime.Today, DateTime.Today);
                //TODO: add date
                //ReCreateProjects(DateTime.Today, DateTime.Today.AddDays(10));
            }
            catch (Exception ex)
            {
                lock (View)
                {
                    _log.Error("View_SelfProjectsItemDoubleClick", ex.Message);
                }
            }
        }

        private void View_AllReclamationsItemDoubleClick(object sender, WeekPlannerItemEventArgs e)
        {
            try
            {
                _timer.Stop();
                _updatedReclamation = _reclamations.FindById(Int32.Parse(e.Item.Name));
                Controller.Run<ReclamationPresenter, ReclamationDto, UserDto>(_updatedReclamation, _mainUser);
                _timer.Start();
                if (!_updatedReclamation.AllowChanges) return;
                _reclamations.Update(_updatedReclamation);
            }
            catch (Exception ex)
            {
                lock (View)
                {
                    _log.Error("View_AllReclamationsItemDoubleClick", ex.Message);
                }
            }
        }

        private void View_AllProjectsItemDoubleClick(object sender, WeekPlannerItemEventArgs e)
        {
            try
            {
                _timer.Stop();
                _updatedProject = _projects.FindById(Int32.Parse(e.Item.Name));
                Controller.Run<ProjectPresenter, ProjectDto, UserDto>(_updatedProject, _mainUser);
                _timer.Start();
                if (!_updatedProject.AllowChanges) return;
                _projects.Update(_updatedProject);
                //ReCreateSelfProjects(DateTime.Today, DateTime.Today);
                //TODO: add date
                //ReCreateProjects(DateTime.Today, DateTime.Today.AddDays(10));
            }
            catch (Exception ex)
            {
                lock (View)
                {
                    _log.Error("View_AllProjectsItemDoubleClick", ex.Message);
                }
            }
        }

        private void ReCreateSelfProjects(DateTime start, DateTime finish)
        {
            lock (View)
            {
                try
                {
                    View.ClearSelfProjects();
                    View.SelfProjectsRows.Add(View.GetNewRowAllProjects(_mainUser.Name));
                    //TODO something wrong
                    var list = _projects.GetByUser(_mainUser.Id);

                    foreach (var item in list.Select(proj => new WeekPlannerItem
                    {
                        StartDate = proj.Start,
                        EndDate = proj.Finish,
                        Subject = proj.Name,
                        Name = proj.Id.ToString(),
                        Tag = proj,
                        State = (States) proj.State,
                        Priority = Convert.ToBoolean(proj.Priority)
                    }))
                    {
                        View.SelfProjectsRows.First().Items.Add(item);
                    }
                    View.ChartSelfProject = _chartService.GetTable(_projects.GetByUser(_mainUser.Id), _mainUser);
                }
                catch (Exception ex)
                {
                    _log.Error("RecreateSelfProjects", ex.Message);
                }
            }
        }

        private void ReCreateSelfReclamation(DateTime start, DateTime finish)
        {
            lock (View)
            {
                try
                {
                    View.ClearSelfReclamations();
                    View.SelfReclamationsRows.Add(View.GetNewRowAllReclamations(_mainUser.Name));
                    //TODO something wrong
                    var reclamationDtos = _reclamations.GetByUser(_mainUser.Id);

                    foreach (var item in reclamationDtos.Select(proj => new WeekPlannerItem
                    {
                        StartDate = proj.Start,
                        EndDate = proj.Finish,
                        Subject = proj.Nomenclature,
                        Name = proj.Id.ToString(),
                        Tag = proj,
                        State = (States) proj.State
                    }))
                    {
                        View.SelfReclamationsRows.First().Items.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    _log.Error("RecreateSelfReclamations", ex.Message);
                }
            }
        }

        private void ReCreateProjects(DateTime start, DateTime finish)
        {
            try
            {
                View.ClearAllProjects();

                var users = _users.FindByDept(_mainUser.DeptId); //////!!!!!!!

                foreach (var user in users.Where(user => user.AccountDto.AllowRow))
                {
                    user.AllProjectsRow = View.GetNewRowAllProjects(user.Name);
                    View.AllProjectsRows.Add((WeekPlannerRow) user.AllProjectsRow);
                }

                var projs = _projects.GetByDateAndDept(start, finish, _mainUser.DeptId); ///////!!!!!!!


                foreach (var proj in projs)
                {

                    {
                        var item = new WeekPlannerItem
                        {
                            StartDate = proj.Start,
                            EndDate = proj.Finish,
                            Subject = proj.Name,
                            Name = proj.Id.ToString(),
                            Tag = proj,
                            State = (States) proj.State,
                            Priority = Convert.ToBoolean(proj.Priority)
                        };
                        try
                        {
                            var row = (WeekPlannerRow) (_users.FindById(proj.Worker.Id)).AllProjectsRow;
                            row.Items.Add(item);
                        }
                        catch (Exception)
                        {
                            
                            _projects.Delete(proj);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                lock (View)
                {
                    _log.Error("RecreateProjects", ex.Message);
                }
            }
        }

        private void ReCreateReclamations(DateTime start, DateTime finish)
        {
            lock (View)
            {
                try
                {
                    View.ClearAllReclamations();

                    var users = _users.FindByDept(2); //////!!!!!!!
                    foreach (var user in users.Where(user => user.AccountDto.AllowRow))
                    {
                        user.AllReclamationRow = View.GetNewRowAllReclamations(user.Name);
                        View.AllReclamationsRows.Add((WeekPlannerRow) user.AllReclamationRow);
                    }

                    var recs = _reclamations.GetByDateAndDept(start, finish); ///////!!!!!!!


                    foreach (var reclamation in recs)
                    {
                        var item = new WeekPlannerItem
                        {
                            StartDate = reclamation.Start,
                            EndDate = reclamation.Finish,
                            Subject = reclamation.Nomenclature,
                            Name = reclamation.Id.ToString(),
                            Tag = reclamation,
                            State = (States) reclamation.State
                        };

                        var row = (WeekPlannerRow) (_users.FindById(reclamation.Worker.Id)).AllReclamationRow;
                        row.Items.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    _log.Error("RecreateReclamations", ex.Message);
                }
            }
        }

        public override void Run(UserDto argument)
        {
            _mainUser = argument;
            View.AllowReclamation = _mainUser.AccountDto.AllowReclamation;
            View.Show();

            View.ChartProject = _chartService.GetTable(_projects.GetAll().ToList());
            View.ChartSelfProject = _chartService.GetTable(_projects.GetByUser(_mainUser.Id), _mainUser);

            View.TableProject = _tableService.GetProjectTable(_projects.GetByUser(_mainUser.Id));
            View.TableReclamation = _tableService.GetReclamationTable(_reclamations.GetByUser(_mainUser.Id));

            //TODO: add dates from settings
            ReCreateSelfProjects(DateTime.Today, DateTime.Today);
            ReCreateProjects(DateTime.Today, DateTime.Today.AddDays(10));
            ReCreateSelfReclamation(DateTime.Today, DateTime.Today);
            ReCreateReclamations(DateTime.Today.AddDays(-50), DateTime.Today.AddDays(10));

            View.allProj = _projects.GetCount();
            View.comProj = _projects.GetCountByState(States.Complete);
            View.stopProj = _projects.GetCountByState(States.Suspended);
            View.workProj = _projects.GetCountByState(States.Work);
            View.waitProj = _projects.GetCountByState(States.Queue);

            _timer.Start();
        }
    }
}