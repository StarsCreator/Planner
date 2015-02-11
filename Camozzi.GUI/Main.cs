using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Camozzi.GUI.Properties;
using MetroFramework.Forms;
using MetroFramework;
using Camozzi.Presentation.Views;
using WeekPlanner;

namespace Camozzi.GUI
{
    public partial class Main : Form, IMainView
    {
        private readonly ApplicationContext _context;
        public Main(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();

            neoTabWindow1.Renderer = NeoTabControlLibrary.AddInRendererManager.LoadRenderer("CamozziRenderer");
            neoTabWindow2.Renderer = NeoTabControlLibrary.AddInRendererManager.LoadRenderer("CCleanerRendererVS4");
            neoTabWindow3.Renderer = NeoTabControlLibrary.AddInRendererManager.LoadRenderer("CCleanerRendererVS4");
            //AllProjectPlan
            AllProjectPlan.Columns.Add("q1", "Сотрудник", 30);
            AllProjectPlan.CurrentDate = DateTime.Today;
            AllProjectPlan.ItemDoubleClick += AllProjectPlan_ItemDoubleClick;
            //AllReclamationPlan
            AllReclamationPlan.Columns.Add("q1", "Сотрудник", 30);
            AllReclamationPlan.CurrentDate = DateTime.Today;
            AllReclamationPlan.ItemDoubleClick += AllReclamationPlan_ItemDoubleClick;
            //SelfProjectPlan
            SelfProjectPlan.Columns.Add("q1", "Сотрудник", 30);
            SelfProjectPlan.CurrentDate = DateTime.Today;
            SelfProjectPlan.ItemDoubleClick += SelfProjectPlan_ItemDoubleClick;
            //SelfReclamationPlan
            SelfReclamationPlan.Columns.Add("q1", "Сотрудник", 30);
            SelfReclamationPlan.CurrentDate = DateTime.Today;
            SelfReclamationPlan.ItemDoubleClick += SelfReclamationPlan_ItemDoubleClick;

        }

        void AllReclamationPlan_ItemDoubleClick(object sender, WeekPlannerItemEventArgs e)
        {
            if (AllReclamationsItemDoubleClick != null) AllReclamationsItemDoubleClick(this, e);
        }

        void AllProjectPlan_ItemDoubleClick(object sender, WeekPlannerItemEventArgs e)
        {
            if (AllProjectsItemDoubleClick != null) AllProjectsItemDoubleClick(this, e);
        }

        void SelfReclamationPlan_ItemDoubleClick(object sender, WeekPlannerItemEventArgs e)
        {
            if (SelfReclamationsItemDoubleClick != null) SelfReclamationsItemDoubleClick(this, e);
        }

        void SelfProjectPlan_ItemDoubleClick(object sender, WeekPlannerItemEventArgs e)
        {
            if (SelfProjectsItemDoubleClick != null) SelfProjectsItemDoubleClick(this, e);
        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }


        #region IMainView

        public WeekPlannerRow GetNewRowAllProjects(string Name)
        {
            DataColumns datacolumn = new DataColumns(AllProjectPlan.Calendar);
            datacolumn["q1"].Data.Add(Name);
            WeekPlannerRow row = new WeekPlannerRow();
            row.Columns = datacolumn;
            return row;
        }
        public WeekPlannerRowCollection AllProjectsRows
        {
            get
             {
                 return AllProjectPlan.Rows;
             }
        }
        public event EventHandler<WeekPlannerItemEventArgs> AllProjectsItemDoubleClick;//вызов состояния
        public void ClearAllProjects()
        {
            foreach (WeekPlannerRow _row in AllProjectPlan.Rows)
            {
                _row.Items.Clear();
            }
            AllProjectPlan.Rows.Clear();
        }//очистка всего планнера

        public WeekPlannerRow GetNewRowAllReclamations(string Name)
        {
            DataColumns datacolumn = new DataColumns(AllReclamationPlan.Calendar);
            datacolumn["q1"].Data.Add(Name);
            WeekPlannerRow row = new WeekPlannerRow();
            row.Columns = datacolumn;
            return row;
        }
        public WeekPlannerRowCollection AllReclamationsRows
        {
            get
            {
                return AllReclamationPlan.Rows;
            }
        }//строки и элементы
        public event EventHandler<WeekPlannerItemEventArgs> AllReclamationsItemDoubleClick;//вызов состояния
        public void ClearAllReclamations() 
        {
            foreach (WeekPlannerRow _row in AllReclamationPlan.Rows)
            {
                _row.Items.Clear();
            }
            AllReclamationPlan.Rows.Clear();
        }

        public WeekPlannerRow GetNewRowSelfProjects(string Name)
        {
            DataColumns datacolumn = new DataColumns(SelfProjectPlan.Calendar);
            datacolumn["q1"].Data.Add(Name);
            WeekPlannerRow row = new WeekPlannerRow();
            row.Columns = datacolumn;
            return row;
        }
        public WeekPlannerRowCollection SelfProjectsRows
        {
            get
            {
                return SelfProjectPlan.Rows;
            }
        }
        public event EventHandler<WeekPlannerItemEventArgs> SelfProjectsItemDoubleClick;//вызов состояния
        public void ClearSelfProjects()
        {
            foreach (WeekPlannerRow _row in SelfProjectPlan.Rows)
            {
                _row.Items.Clear();
            }
            SelfProjectPlan.Rows.Clear();
        }//очистка всего планнера

        public WeekPlannerRow GetNewRowSelfReclamations(string Name)
        {
            DataColumns datacolumn = new DataColumns(SelfReclamationPlan.Calendar);
            datacolumn["q1"].Data.Add(Name);
            WeekPlannerRow row = new WeekPlannerRow();
            row.Columns = datacolumn;
            return row;
        }
        public WeekPlannerRowCollection SelfReclamationsRows
        {
            get
            {
                return SelfReclamationPlan.Rows;
            }
        }//строки и элементы
        public event EventHandler<WeekPlannerItemEventArgs> SelfReclamationsItemDoubleClick;//вызов состояния
        public void ClearSelfReclamations()
        {
            foreach (WeekPlannerRow _row in SelfReclamationPlan.Rows)
            {
                _row.Items.Clear();
            }
            SelfReclamationPlan.Rows.Clear();
        }

        public bool AllowReclamation 
        {
            set
            {
                AllReclamationTab.IsSelectable = value;
                SelfReclamationTab.IsSelectable = value;

            } 
        }

        public List<Object> TableProject 
        {
            set
            {
                //TableProjects.DataSource = value;
            }        
        }
        public List<Object> Tablereclamation 
        {
            set
            {
                //TableReclamation.DataSource = value;
            } 
        }

        #endregion
    }
}