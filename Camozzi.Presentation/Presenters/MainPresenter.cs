using Camozzi.Model.Repository;
using Camozzi.Model.Services;
using Camozzi.Presentation.Injection;
using Camozzi.Presentation.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeekPlanner;

namespace Camozzi.Presentation.Presenters
{
    public class MainPresenter: BasePresenter<IMainView,User>
    {
        User MainUser;  //пользователь
        Project UpdatedProject;
        Reclamation UpdatedReclamation;

        protected readonly IReclamationRepository Reclamations;
        protected readonly IProjectRepository Projects;
        protected readonly IUserRepository Users;
        protected readonly ILog Log;

        public MainPresenter(IApplicationController controller, IMainView view,ILog log,IProjectRepository projects,IUserRepository users,IReclamationRepository reclamations):base(controller,view)
        {
            Reclamations = reclamations;
            Projects = projects;
            Users = users;
            Log = log;

            View.AllProjectsItemDoubleClick += View_AllProjectsItemDoubleClick;
            View.AllReclamationsItemDoubleClick += View_AllReclamationsItemDoubleClick;
            View.SelfProjectsItemDoubleClick += View_SelfProjectsItemDoubleClick;
            View.SelfReclamationsItemDoubleClick += View_SelfReclamationsItemDoubleClick;
        }

        void View_SelfReclamationsItemDoubleClick(object sender, WeekPlannerItemEventArgs e)
        {
            try
            {
                UpdatedReclamation = Reclamations.FindByName(e.Item.Subject);
                Controller.Run<ReclamationPresenter, Reclamation>(UpdatedReclamation);
                if (UpdatedReclamation.Nomenclature != "null")
                {
                    Reclamations.Update(UpdatedReclamation);

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
                UpdatedProject = Projects.FindByName(e.Item.Subject);
                Controller.Run<ProjectPresenter, Project>(UpdatedProject);
                if (UpdatedProject.Name != "null")
                {
                    Projects.Update(UpdatedProject);
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
                UpdatedReclamation = Reclamations.FindByName(e.Item.Subject);
                Controller.Run<ReclamationPresenter,Reclamation>(UpdatedReclamation);
                if (UpdatedReclamation.Nomenclature != "null")
                {
                    Reclamations.Update(UpdatedReclamation);

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
                UpdatedProject = Projects.FindByName(e.Item.Subject);
                Controller.Run<ProjectPresenter, Project>(UpdatedProject);
                if (UpdatedProject.Name != "null")
                {
                    Projects.Update(UpdatedProject);
                }
            }
            catch(Exception ex)
            {
                Log.Error("View_AllProjectsItemDoubleClick", ex);
            }
        }

        public override void Run(User argument)
        {
            MainUser = argument;
            View.AllowReclamation = MainUser.Account.AllowReclamation;
            View.Show();

            ReCreateSelfProjects(DateTime.Today, DateTime.Today);
            ReCreateProjects(DateTime.Today, DateTime.Today.AddDays(10));
            ReCreateReclamations(DateTime.Today.AddDays(-50), DateTime.Today.AddDays(10));
        }


        void ReCreateSelfProjects(DateTime Start,DateTime Finish)
        {
            try
            {
                View.ClearSelfProjects();
                View.SelfProjectsRows.Add(View.GetNewRowAllProjects(MainUser.Name));

                var proj = Projects.GetByUser(MainUser.Id);///////!!!!!!!

                foreach (Project _proj in proj)
                {
                    WeekPlannerItem Item = new WeekPlannerItem();
                    Item.StartDate = _proj.Start;
                    Item.EndDate = _proj.Finish;
                    Item.Subject = _proj.Name;
                    Item.Name = _proj.Name;
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
                    View.SelfProjectsRows.First().Items.Add(Item);
                    //_proj.
                }
            }
            catch (Exception ex)
            {
                Log.Error("RecreateProjects", ex);
            }
        }

        void ReCreateProjects(DateTime Start, DateTime Finish)
        {
            try
            {
                View.ClearAllProjects();
                
                var users = Users.FindByDept(MainUser.DeptId);                        //////!!!!!!!
                foreach (User _user in users)
                {

                    if (_user.Account.AllowRow)
                    {
                        _user.AllProjectsRow = View.GetNewRowAllProjects(_user.Name);
                        View.AllProjectsRows.Add((WeekPlannerRow)_user.AllProjectsRow);
                    }
                }

                var proj = Projects.GetByDateAndDept(Start, Finish, MainUser.DeptId);///////!!!!!!!
                
                

                foreach (Project _proj in proj)
                {
                    WeekPlannerItem Item = new WeekPlannerItem();
                    Item.StartDate = _proj.Start;
                    Item.EndDate = _proj.Finish;
                    Item.Subject = _proj.Name;
                    Item.Name = _proj.Name;
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
                    WeekPlannerRow row = (WeekPlannerRow)_proj.User.AllProjectsRow;
                    row.Items.Add(Item);
                    //_proj.
                }
            }
            catch (Exception ex)
            {
                Log.Error("RecreateProjects", ex);
            }
        }
        void ReCreateReclamations(DateTime Start, DateTime Finish)
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

                var proj = Reclamations.GetByDateAndDept(Start, Finish);///////!!!!!!!



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
