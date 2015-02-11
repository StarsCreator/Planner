using Camozzi.Model.Repository;
using Camozzi.Model.Services;
using Camozzi.Presentation.Injection;
using Camozzi.Presentation.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camozzi.Presentation.Presenters
{
    public class ProjectPresenter : BasePresenter<IProjectView,Project>
    {
        Project Proj;
        protected readonly IUserRepository Users;

        public ProjectPresenter(IApplicationController controller, IProjectView view, IUserRepository users)
            : base(controller, view)
        {
             Users = users;

             View.Ok += View_Ok;
             View.Cancel += View_Cancel;
             View.Mgr += View_Mgr;
             View.Usr += View_Usr;
        }

        void View_Usr()
        {
            Controller.Run<UserPresenter, User>((User)View.SelectedUser);
        }

        void View_Mgr()
        {
            Controller.Run<UserPresenter, User>((User)View.SelectedManager);
        }

        void View_Cancel()
        {
            Proj = null;
            View.Close();
        }

        void View_Ok()
        {
            Proj.Name = View.ProjectName;
            Proj.Priority = View.Priority;
            Proj.Start = View.Start;
            Proj.Finish = View.Finish;
            Proj.Manager = (User)View.SelectedManager;
            Proj.User = (User)View.SelectedUser;
            Proj.UserId = Proj.User.Id;
            Proj.ManagerId = Proj.Manager.Id;
            Proj.State = View.State;
            Proj.Comment = View.Comment;
            View.Close();
        }

        public override void Run(Project argument)
        {
            Proj = argument;
            View.Id = Proj.Id;
            View.Priority = Proj.Priority;
            View.ProjectName = Proj.Name;
            View.Start = Proj.Start;
            View.State = Proj.State;
            View.Finish = Proj.Finish;
            View.Comment = Proj.Comment;
            View.Managers = Users.FindByDept(Proj.Manager.DeptId);
            View.SelectedManager = Proj.Manager;
            View.Users = Users.FindByDept(Proj.User.DeptId);
            View.SelectedUser = Proj.User;
            View.Show();
        }
    }
}
