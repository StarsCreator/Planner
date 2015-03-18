using Camozzi.Presentation.Injection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camozzi.Presentation.Views
{
    public interface IUserView : IView
    {
        event Action Ok;

        string UserName
        {
            set;
        }

        string Phone
        {
            set;
        }

        string Mail
        {
            set;
        }

        string Dept
        {
            set;
        }

        string Comment
        {
            set;
        }
    }
}
