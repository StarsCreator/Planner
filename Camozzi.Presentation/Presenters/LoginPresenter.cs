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

            View.Users = Users.GetAll(); ;
        }

        void View_Ok()
        {
            if (View.Password == ((User)View.UserName).Password)
            {
                Controller.Run<MainPresenter, User>((User)View.UserName);
                View.Close();
            }
            else
            {
                View.ClearPswFld();
            }
        }
    }
}
