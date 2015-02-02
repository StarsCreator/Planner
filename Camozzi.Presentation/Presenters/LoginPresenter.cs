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
    public class LoginPresenter : BasePresenter<ILoginView>
    {
        private readonly IUserRepository Users;
        public LoginPresenter(IApplicationController controller, ILoginView view, IUserRepository users):base(controller,view)
        {
            Users = users;
            View.Ok += View_Ok;

            var usr = Users.GetAll();
            View.Users = usr;
        }

        void View_Ok()
        {
            var usr = View.UserName;
            Controller.Run<MainPresenter>();
            View.Close();
        }
    }
}
