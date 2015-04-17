using System.Linq;
using Camozzi.Model.DataService;
using Camozzi.Model.Repository;
using Camozzi.Presentation.Injection;
using Camozzi.Presentation.Views;

namespace Camozzi.Presentation.Presenters
{
    public class ProjectPresenter : BasePresenter<IProjectView,Project,User>
    {
        Project _proj;
        User _senderUser;
        private readonly IUserRepository _users;

        public ProjectPresenter(IApplicationController controller, IProjectView view, IUserRepository users)
            : base(controller, view)
        {
             _users = users;

             View.Ok += View_Ok;
             View.Cancel += View_Cancel;
             View.Mgr += View_Mgr;
             View.Usr += View_Usr;
        }

        void View_Usr()
        {
            Controller.Run<UserPresenter, User>(_users.FindByName(View.SelectedUser));
        }

        void View_Mgr()
        {
            Controller.Run<UserPresenter, User>(_users.FindByName(View.SelectedManager));
        }

        void View_Cancel()
        {
            _proj.AllowChanges = false;            
            View.Close();
        }

        void View_Ok()
        {
            _proj.Name = View.ProjectName;
            _proj.Priority = View.Priority;
            _proj.Start = View.Start;
            _proj.Finish = View.Finish;
            _proj.Manager = _users.FindByName(View.SelectedManager);
            _proj.Worker = _users.FindByName(View.SelectedUser);
            _proj.UserId = _proj.Worker.Id;
            _proj.ManagerId = _proj.Manager.Id;
            _proj.State = View.State;
            _proj.Comment = View.Comment;
            _proj.AllowChanges = true;
            View.Close();
        }

        public override void Run(Project argument,User senderUser)
        {
            _proj = argument;
            _senderUser = senderUser;
            View.AllowUser = false;

            if (_senderUser.Id == _proj.Creator.Id || _senderUser.Id == _proj.Worker.Id || _senderUser.Account.AllowCreateAll)
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
            View.Managers = _users.GetAll().Where(user=>user.DeptId == 3 ).Select(user => user.Name).ToList();
            View.SelectedManager = _users.FindById(_proj.Manager.Id).Name;
            View.Users = _users.GetAll().Where(user=>user.DeptId == _senderUser.DeptId ).Select(user => user.Name).ToList();
            View.SelectedUser =_users.FindById(_proj.Worker.Id).Name;
            View.Show();
        }
    }
}
