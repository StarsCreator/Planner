using Camozzi.Model.Services;
using Camozzi.Presentation.Injection;
using Camozzi.Presentation.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Camozzi.Model.DataService;

namespace Camozzi.Presentation.Presenters
{
    public class UserPresenter : BasePresenter<IUserView, UserDto>, IPresenter<UserDto>
    {
        UserDto user;
        public UserPresenter(IApplicationController controller, IUserView view)
            : base(controller, view)
        {
            View.Ok += View_Ok;
        }

        void View_Ok()
        {
            View.Close();
        }

        public override void Run(UserDto argument)
        {
            user = argument;
            View.Comment = user.Comment;
            View.Dept = user.DeptDto.Description;
            View.Mail = user.Mail;
            View.UserName = user.Name;
            View.Show();
        }
    }
}
