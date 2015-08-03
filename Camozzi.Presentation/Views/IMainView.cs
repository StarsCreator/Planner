using Camozzi.Presentation.Injection;
using System;
using WeekPlanner;

namespace Camozzi.Presentation.Views
{
    public interface IMainView: IView
    {
        #region AllProjectsPlan

        WeekPlannerRow GetNewRowAllProjects (string name);
        WeekPlannerRowCollection AllProjectsRows { get; }//строки и элементы
        DateTime AllProjectStart { get; set; }
        int AllProjectDuration { get; set; }
        event EventHandler<WeekPlannerItemEventArgs> AllProjectsItemDoubleClick;//вызов состояния
        void ClearAllProjects();//очистка всего планнера

        #endregion

        #region SelfProjectsPlan

        WeekPlannerRow GetNewRowSelfProjects(string name);
        WeekPlannerRowCollection SelfProjectsRows { get; }//строки и элементы
        DateTime SelfProjectStart { get; set; }
        int SelfProjectDuration { get; set; }
        event EventHandler<WeekPlannerItemEventArgs> SelfProjectsItemDoubleClick;//вызов состояния
        void ClearSelfProjects();//очистка всего планнера

        #endregion

        #region Tables

        object TableProject { set; }

        event Action<int> TableProjectClick;
        event Action<int> DeleteProject;

        #endregion

        #region Charts

        int waitProj { set; }
        int allProj { set; }
        int comProj { set; }
        int workProj { set; }
        int stopProj { set; }

        object ChartProject { set; }
        object ChartSelfProject { set; }


        #endregion

        #region Common

        event Action CreateProject;
        event Action FormClose;

        bool HideEndProject { get; set; }
        bool AddManagerName { get; set; }

        #endregion
    }
}
