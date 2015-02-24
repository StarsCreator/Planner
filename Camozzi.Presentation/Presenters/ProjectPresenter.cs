using Camozzi.Model.Repository;
using Camozzi.Model.Services;
using Camozzi.Presentation.Injection;
using Camozzi.Presentation.Views;

namespace Camozzi.Presentation.Presenters
{
    public class ProjectPresenter : BasePresenter<IProjectView,Project,User>
    {
        Project _proj;
        User _senderUser;
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
            _proj = null;            
            View.Close();
        }

        void View_Ok()
        {
            _proj.Name = View.ProjectName;
            _proj.Priority = View.Priority;
            _proj.Start = View.Start;
            _proj.Finish = View.Finish;
            _proj.Manager = (User)View.SelectedManager;
            _proj.User = (User)View.SelectedUser;
            _proj.UserId = _proj.User.Id;
            _proj.ManagerId = _proj.Manager.Id;
            _proj.State = View.State;
            _proj.Comment = View.Comment;
            View.Close();
        }

        public override void Run(Project argument,User senderUser)
        {
            _proj = argument;
            _senderUser = senderUser;
            View.AllowUser = false;

            if (_senderUser == _proj.Creator || _senderUser == _proj.User || _senderUser.Account.AllowCreateAll)
            {
                View.AllowComment = true;
                View.AllowChange = true;
                if (_senderUser.Account.AllowCreateAll)
                {
                    View.AllowUser = true;
                }
            }
            else
            {
                View.AllowComment = _senderUser.Account.AllowCommment;
                View.AllowChange = false;

            }

            View.Id = _proj.Id;
            View.Priority = _proj.Priority;
            View.ProjectName = _proj.Name;
            View.Start = _proj.Start;
            View.State = _proj.State;
            View.Finish = _proj.Finish;
            View.Comment = _proj.Comment;
            View.Managers = Users.FindByDept(_proj.Manager.DeptId);
            View.SelectedManager = _proj.Manager;
            View.Users = Users.FindByDept(_proj.User.DeptId);
            View.SelectedUser = _proj.User;
            View.Show();
        }
    }
}
