using Camozzi.Presentation.Injection;
using System;
using System.Collections.Generic;

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
        DateTime Start { get; set; }
        DateTime Finish { get; set; }
        string SelectedUser { get; set; }
        List<string> Users { set; }
        string SelectedManager { get; set; }
        List<string> Managers { set; }
        int State { get; set; }
        int Priority { get; set; }
        string Comment { get; set; }

        bool AllowUser { set; }
        bool AllowChange { set; }
        bool AllowComment { set; }
    }
}
