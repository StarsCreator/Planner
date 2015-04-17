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
        event EventHandler<WeekPlannerItemEventArgs> AllProjectsItemDoubleClick;//вызов состояния
        void ClearAllProjects();//очистка всего планнера

        #endregion

        #region AllReclamationsPlan

        WeekPlannerRow GetNewRowAllReclamations(string name);
        WeekPlannerRowCollection AllReclamationsRows { get; }//строки и элементы
        event EventHandler<WeekPlannerItemEventArgs> AllReclamationsItemDoubleClick;//вызов состояния
        void ClearAllReclamations();//очистка всего планнера

        #endregion

        #region SelfProjectsPlan

        WeekPlannerRow GetNewRowSelfProjects(string name);
        WeekPlannerRowCollection SelfProjectsRows { get; }//строки и элементы
        event EventHandler<WeekPlannerItemEventArgs> SelfProjectsItemDoubleClick;//вызов состояния
        void ClearSelfProjects();//очистка всего планнера

        #endregion

        #region SelfReclamationsPlan

        WeekPlannerRow GetNewRowSelfReclamations(string name);
        WeekPlannerRowCollection SelfReclamationsRows { get; }//строки и элементы
        event EventHandler<WeekPlannerItemEventArgs> SelfReclamationsItemDoubleClick;//вызов состояния
        void ClearSelfReclamations();//очистка всего планнера

        #endregion

        #region Tables

        object TableProject { set; }
        object TableReclamation { set; }
        event Action<int> TableProjectClick;
        event Action<int> TableReclamationClick;
        event Action<int> DeleteProject;
        event Action<int> DeleteReclamation;

        #endregion

        #region Charts

        object ChartProject { set; }
        object ChartSelfProject { set; }


        #endregion

        #region Common

        bool AllowReclamation { set; }

        event Action CreateProject;
        event Action CreateReclamation;

        #endregion
    }
}
