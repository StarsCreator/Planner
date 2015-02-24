using Camozzi.Model.Repository;
using Camozzi.Model.Services;
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
        }

        void View_TableReclamationClick(object sender, Model.Args.TableClickArgs e)
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
                Log.Error("View_TableReclamationClick", ex);
            }
        }

        void View_TableProjectClick(object sender, Model.Args.TableClickArgs e)
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
                Log.Error("View_TableProjectClick", ex);
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
                Log.Error("View_AllReclamationsItemDoubleClick", ex);
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
                }
            }
            catch (Exception ex)
            {
                Log.Error("View_AllProjectsItemDoubleClick", ex);
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
                Log.Error("View_AllReclamationsItemDoubleClick", ex);
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
                }
            }
            catch(Exception ex)
            {
                Log.Error("View_AllProjectsItemDoubleClick", ex);
            }
        }

        public override void Run(User argument)
        {
            _mainUser = argument;
            View.AllowReclamation = _mainUser.Account.AllowReclamation;
            View.Show();

            View.ChartProject = ChartService.GetTable(Projects.GetAll());
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
                Log.Error("RecreateProjects", ex);
            }
        }
        void ReCreateProjects(DateTime start, DateTime finish)
        {
            try
            {
                View.ClearAllProjects();
                
                var users = Users.FindByDept(_mainUser.DeptId);                        //////!!!!!!!
                foreach (User _user in users)
                {

                    if (_user.Account.AllowRow)
                    {
                        _user.AllProjectsRow = View.GetNewRowAllProjects(_user.Name);
                        View.AllProjectsRows.Add((WeekPlannerRow)_user.AllProjectsRow);
                    }
                }

                var proj = Projects.GetByDateAndDept(start, finish, _mainUser.DeptId);///////!!!!!!!
                
                

                foreach (Project _proj in proj)
                {
                    WeekPlannerItem Item = new WeekPlannerItem();
                    Item.StartDate = _proj.Start;
                    Item.EndDate = _proj.Finish;
                    Item.Subject = _proj.Name;
                    Item.Name = _proj.Name;
                    Item.Tag = _proj;
                    Item.State = (States)_proj.State;                  
                    WeekPlannerRow row = (WeekPlannerRow)_proj.User.AllProjectsRow;
                    row.Items.Add(Item);
                }
            }
            catch (Exception ex)
            {
                Log.Error("RecreateProjects", ex);
            }
        }
        void ReCreateReclamations(DateTime start, DateTime finish)
        {
            try
            {
                View.ClearAllReclamations();

                var users = Users.FindByDept(2);                        //////!!!!!!!
                foreach (User _user in users)
                {

                    if (_user.Account.AllowRow)
                    {
                        _user.AllReclamationsRow = View.GetNewRowAllProjects(_user.Name);
                        View.AllReclamationsRows.Add((WeekPlannerRow)_user.AllReclamationsRow);
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
                    /*/Item.Context = contextMenuStrip2;
                    switch (_proj.State)
                    {
                        case 0:
                            {
                                Item.BackColor = Color.Yellow;
                                break;
                            }
                        case 1:
                            {
                                Item.BackColor = Color.LightGreen;
                                break;
                            }
                        case 2:
                            {
                                Item.BackColor = Color.DarkGray;
                                break;
                            }
                        case 3:
                            {
                                Item.BackColor = Color.GhostWhite;
                                break;
                            }
                        case 4:
                            {
                                Item.BackColor = Color.LightSkyBlue;
                                break;
                            }
                        case 5:
                            {
                                Item.BackColor = Color.Violet;
                                break;
                            }
                        default:
                            {
                                Item.BackColor = Color.GhostWhite;
                                break;
                            }
                    }
                    if (_proj.Priority == 1) Item.BackColor = Color.LightCoral;
                    if (_proj.State == 1) Item.BackColor = Color.LightGreen;*/
                    WeekPlannerRow row = (WeekPlannerRow)_proj.User.AllReclamationsRow;
                    row.Items.Add(Item);
                }
            }
            catch (Exception ex)
            {
                Log.Error("RecreateProjects", ex);
            }
        }
    }
}
