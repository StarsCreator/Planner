using System.Linq;
using Camozzi.Model.DataService;
using Camozzi.Model.Repository;
using Camozzi.Model.Services;
using Camozzi.Presentation.Injection;
using Camozzi.Presentation.Views;

namespace Camozzi.Presentation.Presenters
{
    public class ReclamationPresenter : BasePresenter<IReclamationView, Reclamation,User>
    {
        Reclamation _rec;
        User _senderUser;
        private readonly IUserRepository _users;

        public ReclamationPresenter(IApplicationController controller, IReclamationView view, IUserRepository users)
            : base(controller, view)
        {
            _users = users;

            View.Ok += View_Ok;
            View.Cancel += View_Cancel;
            View.Usr += View_Usr;
            View.Mgr += View_Mgr;
        }

        void View_Mgr()
        {
            Controller.Run<UserPresenter, User>(_users.FindByName(View.SelectedManager));
        }

        void View_Usr()
        {
            Controller.Run<UserPresenter, User>(_users.FindByName(View.SelectedUser));
        }

        void View_Cancel()
        {
            _rec.AllowChanges = false;
            View.Close();
        }

        void View_Ok()
        {
            _rec.Start = View.Start;
            _rec.Finish = View.Finish;
            _rec.Send = View.Send;
            _rec.Production = View.Production;
            _rec.Nomenclature = View.Nomenclature;
            _rec.Manager = _users.FindByName(View.SelectedManager);
            _rec.Worker = _users.FindByName(View.SelectedUser);
            _rec.UserId = _rec.Worker.Id;
            _rec.ManagerId = _rec.Manager.Id;
            _rec.Act = View.Act;
            _rec.Count = View.Count;
            _rec.State = View.State;
            _rec.Comment = View.Comment;
            _rec.Solution = View.Solution;
            _rec.Client = View.Client;
            _rec.ReclamationAct = View.ReclamationAct;
            _rec.AllowChanges = true;
            View.Close();
        }

        public override void Run(Reclamation argument,User senderUser)
        {
            _rec = argument;
            _senderUser = senderUser;
            if (_senderUser == _rec.Creator || _senderUser == _rec.Worker || _senderUser.Account.AllowCreateAll)
            {
                View.AllowComment = true;
                View.AllowChange = true;
            }
            else
            {
                View.AllowComment = _senderUser.Account.AllowCommment;
                View.AllowChange = false;
            }
            View.Start = _rec.Start;
            View.Finish = _rec.Finish;
            View.Send = _rec.Send;
            View.Production = _rec.Production;
            View.Nomenclature = _rec.Nomenclature;
            View.Managers = _users.GetAll().Where(user => user.DeptId == 3).Select(user => user.Name).ToList();
            View.SelectedManager = _users.FindById(_rec.Manager.Id).Name;
            View.Users = _users.GetAll().Where(user => user.DeptId == _senderUser.DeptId).Select(user => user.Name).ToList();
            View.SelectedUser = _users.FindById(_rec.Worker.Id).Name;
            View.Act = _rec.Act;
            View.Count = _rec.Count;
            View.State = _rec.State;
            View.Comment = _rec.Comment;
            View.Solution = _rec.Solution;
            View.Client = _rec.Client;
            View.ReclamationAct = _rec.ReclamationAct;
            View.Show();
        }
    }
}
