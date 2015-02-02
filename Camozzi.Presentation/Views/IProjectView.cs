using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camozzi.Presentation.Views
{
    public interface IProjectView
    {
        event Action Ok;
        event Action Cancel;

        void SetNameErr();
        void SetDateErr();

        int Id { set; }
        string ProjectName { get; set; }
        System.DateTime Start { get; set; }
        System.DateTime Finish { get; set; }
        int UserId { get; set; }
        int ManagerId { get; set; }
        int State { get; set; }
        int Priority { get; set; }
        string Comment { get; set; }
    }
}
