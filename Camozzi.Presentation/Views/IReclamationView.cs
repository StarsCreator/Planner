using Camozzi.Presentation.Injection;
using System;

namespace Camozzi.Presentation.Views
{
    public interface IReclamationView : IView
    {
        event Action Ok;
        event Action Cancel;
        event Action Mgr;
        event Action Usr;

        void SetNameErr();
        void SetDateErr();
        void SetFinErr();

        int Id { set; }
        DateTime Start { get; set; }
        DateTime Finish { get; set; }
        DateTime Send { get; set; }
        string Production { get; set; }
        string Nomenclature { get; set; }
        string SelectedUser { get; set; }
        object Users { set; }
        string SelectedManager { get; set; }
        object Managers { set; }
        string Act { get; set; }
        int Count { get; set; }
        int State { get; set; }
        string Comment { get; set; }
        bool Solution { get; set; }
        string Client { get; set; }
        string ReclamationAct { get; set; }

        bool AllowChange { set; }
        bool AllowComment { set; }
    }
}
