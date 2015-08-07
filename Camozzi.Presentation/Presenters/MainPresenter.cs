using System;
using System.Linq;
using System.Timers;
using Camozzi.Model.DataService;
using Camozzi.Model.Repository;
using Camozzi.Model.Services;
using Camozzi.Presentation.Injection;
using Camozzi.Presentation.Views;
using WeekPlanner;

namespace Camozzi.Presentation.Presenters
{
    public class MainPresenter : BasePresenter<IMainView, UserDto>
    {
        private UserDto _mainUser; //пользователь
        private ProjectDto _updatedProject;

        private readonly Timer _timer = new Timer(60000);

        private readonly IChartService _chartService;
        private readonly ITableService _tableService;
        private readonly ISettings _settings;
        private readonly IProjectRepository _projects;
        private readonly IUserRepository _users;
        private readonly ILog _log;

        public MainPresenter(IApplicationController controller, IMainView view, ILog log, IProjectRepository projects,
            IUserRepository users, ITableService tableService,
            IChartService chartService,ISettings settings) : base(controller, view)
        {
            _tableService = tableService;
            _chartService = chartService;
            _settings = settings;
            _projects = projects;
            _users = users;
            _log = log;

            View.AllProjectsItemDoubleClick += View_AllProjectsItemDoubleClick;
            View.SelfProjectsItemDoubleClick += View_SelfProjectsItemDoubleClick;
            View.TableProjectClick += View_TableProjectClick;
            View.CreateProject += View_CreateProject;
            View.DeleteProject += View_DeleteProject;
            View.FormClose += View_FormClose;

            _projects.ProjectUpdated += _projects_ProjectUpdated;

            _timer.Elapsed += _timer_Elapsed;
        }

        void View_FormClose()
        {
            _settings.AllProjectStart = View.AllProjectStart;
            _settings.AllProjectDuration = View.AllProjectDuration;
            _settings.SelfProjectStart = View.SelfProjectStart;
            _settings.SelfProjectDuration = View.SelfProjectDuration;
            _settings.AddManagerName = View.AddManagerName;
            _settings.HideEndProject = View.HideEndProject;
            _settings.Save();
        }

        private void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            //_timer.Stop();
            //_users.UpdateContext();
            //_projects.UpdateContext();
            //GC.Collect();
            //_timer.Start();
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

        private void ReCreateProjects(DateTime start, DateTime finish)
        {
            try
            {
                View.ClearAllProjects();

                var users = _users.FindByDept(_mainUser.DeptId); //////!!!!!!!

                foreach (var user in users.Where(user => user.AccountDto.AllowRow).OrderBy(x=>x.QueryId))
                {
                    user.AllProjectsRow = View.GetNewRowAllProjects(user.Name);
                    View.AllProjectsRows.Add((WeekPlannerRow) user.AllProjectsRow);
                }

                var projs = _projects.GetByDateAndDept(start, finish, _mainUser.DeptId); ///////!!!!!!!
                if (_settings.HideEndProject)
                {
                    projs = projs.Where(x => x.State != 2);
                }

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

                        if (_settings.AddManagerName)
                        {
                            //TODO:    
                        }

                        try
                        {
                            var row = (WeekPlannerRow) (_users.FindById(proj.Worker.Id)).AllProjectsRow;
                            row.Items.Add(item);
                        }
                        catch (Exception)
                        {                           
                            //_projects.Delete(proj);
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

        public override void Run(UserDto argument)
        {
            _mainUser = argument;
            _settings.LastUser = _mainUser.Name;
            SetSettings();
            View.Show();

            View.ChartProject = _chartService.GetTable(_projects.GetAll().ToList());
            View.ChartSelfProject = _chartService.GetTable(_projects.GetByUser(_mainUser.Id), _mainUser);

            View.TableProject = _tableService.GetProjectTable(_projects.GetByUser(_mainUser.Id));
            
            //TODO: add dates from settings
            ReCreateSelfProjects(DateTime.Today, DateTime.Today);
            ReCreateProjects(DateTime.Today, DateTime.Today.AddDays(10));
            
            View.allProj = _projects.GetCount();
            View.comProj = _projects.GetCountByState(States.Complete);
            View.stopProj = _projects.GetCountByState(States.Suspended);
            View.workProj = _projects.GetCountByState(States.Work);
            View.waitProj = _projects.GetCountByState(States.Queue);

            _timer.Start();
        }

        private void SetSettings()
        {
            try
            {
                View.AllProjectStart = _settings.AllProjectStart;
                View.AllProjectDuration = _settings.AllProjectDuration;
                View.SelfProjectStart = _settings.SelfProjectStart;
                View.SelfProjectDuration = _settings.SelfProjectDuration;
            }
            catch (Exception)
            {
                
                //throw;
            }

            View.HideEndProject = _settings.HideEndProject;
            View.AddManagerName = _settings.AddManagerName;
        }
    }
}