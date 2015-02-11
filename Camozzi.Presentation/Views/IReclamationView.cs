using Camozzi.Presentation.Injection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        System.DateTime Start { get; set; }
        System.DateTime Finish { get; set; }
        System.DateTime Send { get; set; }
        string Production { get; set; }
        string Nomenclature { get; set; }
        object SelectedUser { get; set; }
        object Users { set; }
        object SelectedManager { get; set; }
        object Managers { set; }
        string Act { get; set; }
        int Count { get; set; }
        int State { get; set; }
        string Comment { get; set; }
        bool Solution { get; set; }
        string Client { get; set; }
        string ReclamationAct { get; set; }
    }
}
