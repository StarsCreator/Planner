using Camozzi.Presentation.Injection;
using System;
using Camozzi.Model.Args;
using WeekPlanner;

namespace Camozzi.Presentation.Views
{
    public interface IMainView: IView
    {
        #region AllProjectsPlan

        WeekPlannerRow GetNewRowAllProjects (string Name);
        WeekPlannerRowCollection AllProjectsRows { get; }//строки и элементы
        event EventHandler<WeekPlannerItemEventArgs> AllProjectsItemDoubleClick;//вызов состояния
        void ClearAllProjects();//очистка всего планнера

        #endregion

        #region AllReclamationsPlan

        WeekPlannerRow GetNewRowAllReclamations(string Name);
        WeekPlannerRowCollection AllReclamationsRows { get; }//строки и элементы
        event EventHandler<WeekPlannerItemEventArgs> AllReclamationsItemDoubleClick;//вызов состояния
        void ClearAllReclamations();//очистка всего планнера

        #endregion

        #region SelfProjectsPlan

        WeekPlannerRow GetNewRowSelfProjects(string Name);
        WeekPlannerRowCollection SelfProjectsRows { get; }//строки и элементы
        event EventHandler<WeekPlannerItemEventArgs> SelfProjectsItemDoubleClick;//вызов состояния
        void ClearSelfProjects();//очистка всего планнера

        #endregion

        #region SelfReclamationsPlan

        WeekPlannerRow GetNewRowSelfReclamations(string Name);
        WeekPlannerRowCollection SelfReclamationsRows { get; }//строки и элементы
        event EventHandler<WeekPlannerItemEventArgs> SelfReclamationsItemDoubleClick;//вызов состояния
        void ClearSelfReclamations();//очистка всего планнера

        #endregion

        #region Tables

        object TableProject { set; }
        object TableReclamation { set; }
        event EventHandler<TableClickArgs> TableProjectClick;
        event EventHandler<TableClickArgs> TableReclamationClick;
        event EventHandler<TableClickArgs> DeleteProject;
        event EventHandler<TableClickArgs> DeleteReclamation;

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
