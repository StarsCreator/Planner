using Camozzi.Presentation.Injection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camozzi.Presentation.Views
{
    public interface IProjectView : IView
    {
        event Action Ok;
        event Action Cancel;
        event Action Mgr;
        event Action Usr;

        void SetNameErr();
        void SetDateErr();

        int Id { set; }
        string ProjectName { get; set; }
        System.DateTime Start { get; set; }
        System.DateTime Finish { get; set; }
        object SelectedUser { get; set; }
        object Users { set; }
        object SelectedManager { get; set; }
        object Managers { set; }
        int State { get; set; }
        int Priority { get; set; }
        string Comment { get; set; }
    }
}
