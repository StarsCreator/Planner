using System;
using System.Windows.Forms;
using Camozzi.Presentation.Views;
using NeoTabControlLibrary;
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


            neoTabWindow1.Renderer = AddInRendererManager.LoadRenderer("CamozziRenderer");
            neoTabWindow2.Renderer = AddInRendererManager.LoadRenderer("CCleanerRendererVS4");
            neoTabWindow3.Renderer = AddInRendererManager.LoadRenderer("CCleanerRendererVS4");

            //AllProjectPlan
            AllProjectPlan.Columns.Add("q1", "Сотрудник", 30);
            AllProjectPlan.CurrentDate = DateTime.Today;
            AllProjectPlan.ItemDoubleClick += AllProjectPlan_ItemDoubleClick;
            AllProjectLeft.Click += AllProjectLeft_Click;
            AllProjectRight.Click += AllProjectRight_Click;
            AllProjectSetDate.Click += AllProjectSetDate_Click;

            //AllReclamationPlan
            AllReclamationPlan.Columns.Add("q1", "Сотрудник", 30);
            AllReclamationPlan.CurrentDate = DateTime.Today;
            AllReclamationPlan.ItemDoubleClick += AllReclamationPlan_ItemDoubleClick;
            AllReclamationLeft.Click += AllReclamationLeft_Click;
            AllReclamationRight.Click += AllReclamationRight_Click;
            AllReclamationDateSet.Click += AllReclamationDateSet_Click;

            //SelfProjectPlan
            SelfProjectPlan.Columns.Add("q1", "Сотрудник", 30);
            SelfProjectPlan.CurrentDate = DateTime.Today;
            SelfProjectPlan.ItemDoubleClick += SelfProjectPlan_ItemDoubleClick;
            SelfProjectRight.Click += SelfProjectRight_Click;
            SelfProjectLeft.Click += SelfProjectLeft_Click;
            SelfProjectSetDate.Click += SelfProjectSetDate_Click;

            //SelfReclamationPlan
            SelfReclamationPlan.Columns.Add("q1", "Сотрудник", 30);
            SelfReclamationPlan.CurrentDate = DateTime.Today;
            SelfReclamationPlan.ItemDoubleClick += SelfReclamationPlan_ItemDoubleClick;
            SelfReclamationRight.Click += SelfReclamationRight_Click;
            SelfReclamationLeft.Click += SelfReclamationLeft_Click;
            SelfReclamationDateSet.Click += SelfReclamationDateSet_Click;

            //MetroTableProject
            MetroTableProject.CellDoubleClick += MetroTableProject_CellDoubleClick;
            MetroTableProject.CellMouseDown += MetroTableProject_CellMouseDown;
            MetroTableProject.RowsAdded += MetroTableProject_RowsAdded;

            //MetroTableReclamation
            MetroTableReclamation.CellDoubleClick += MetroTableReclamation_CellDoubleClick;

            //ContextProj
            AddProj.Click += (sender, args) => Invoke(CreateProject);
            addNewProj.Click += (sender, args) => Invoke(CreateProject);
            EditProj.Click += EditProj_Click;
            DeleteProj.Click += DeleteProj_Click;

        }

        void DeleteProj_Click(object sender, EventArgs e)
        {
            if (DeleteProject != null) DeleteProject((int)MetroTableProject.SelectedRows[0].Cells[0].Value);
        }

        void EditProj_Click(object sender, EventArgs e)
        {
            if (TableProjectClick != null) TableProjectClick((int)MetroTableProject.SelectedRows[0].Cells[0].Value);
        }

        void MetroTableProject_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            if (e.RowIndex == -1) return;
            MetroTableProject.ClearSelection();
            MetroTableProject.Rows[e.RowIndex].Selected = true;
            MetroTableProject.CurrentCell = MetroTableProject[0, e.RowIndex];
        }

        void MetroTableProject_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            foreach (DataGridViewRow row in MetroTableProject.Rows)
            {
                row.ContextMenuStrip = ContextProj;
            }
        }

        void MetroTableReclamation_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if (TableProjectClick != null) TableProjectClick((int)MetroTableProject.SelectedRows[0].Cells[0].Value);
        }

        void MetroTableProject_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if (TableProjectClick != null) TableProjectClick((int)MetroTableProject.SelectedRows[0].Cells[0].Value);
        }

        void SelfReclamationDateSet_Click(object sender, EventArgs e)
        {
            SelfReclamationsStart = SelfReclamationStartSet.Value;
            if (SelfReclamationStartSet.Value > SelfReclamationEndSet.Value)
            {
                SelfReclamationEndSet.Value = SelfReclamationStartSet.Value.AddDays(9);
            }
            TimeSpan tmp = SelfReclamationEndSet.Value - SelfReclamationStartSet.Value;
            SelfReclamationPlan.DayCount = tmp.Days + 1;
        }

        void SelfReclamationLeft_Click(object sender, EventArgs e)
        {
            SelfReclamationsStart = SelfReclamationsStart.AddDays(-7);
            SelfReclamationEndSet.Value = SelfReclamationStartSet.Value.AddDays(SelfReclamationPlan.DayCount - 1);
        }

        void SelfReclamationRight_Click(object sender, EventArgs e)
        {
            SelfReclamationsStart = SelfReclamationsStart.AddDays(7);
            SelfReclamationEndSet.Value = SelfReclamationStartSet.Value.AddDays(SelfReclamationPlan.DayCount - 1);
        }

        void SelfProjectSetDate_Click(object sender, EventArgs e)
        {
            SelfProjectsStart = SelfProjectStartSet.Value;
            if (SelfProjectStartSet.Value > SelfProjectEndSet.Value)
            {
                SelfProjectEndSet.Value = SelfProjectStartSet.Value.AddDays(9);
            }
            TimeSpan tmp = SelfProjectEndSet.Value - SelfProjectStartSet.Value;
            SelfProjectPlan.DayCount = tmp.Days + 1;
        }

        void SelfProjectLeft_Click(object sender, EventArgs e)
        {
            SelfProjectsStart = SelfProjectsStart.AddDays(-7);
            SelfProjectEndSet.Value = SelfProjectStartSet.Value.AddDays(SelfProjectPlan.DayCount - 1);
        }

        void SelfProjectRight_Click(object sender, EventArgs e)
        {
            SelfProjectsStart = SelfProjectsStart.AddDays(7);
            SelfProjectEndSet.Value = SelfProjectStartSet.Value.AddDays(SelfProjectPlan.DayCount - 1);
        }

        void AllReclamationDateSet_Click(object sender, EventArgs e)
        {
            AllReclamationsStart = AllReclamationStartSet.Value;
            if (AllReclamationStartSet.Value > AllReclamationEndSet.Value)
            {
                AllReclamationEndSet.Value = AllReclamationStartSet.Value.AddDays(9);
            }
            TimeSpan tmp = AllReclamationEndSet.Value - AllReclamationStartSet.Value;
            AllReclamationPlan.DayCount = tmp.Days + 1;
        }

        void AllReclamationRight_Click(object sender, EventArgs e)
        {
            AllReclamationsStart = AllReclamationsStart.AddDays(7);
            AllReclamationEndSet.Value = AllReclamationStartSet.Value.AddDays(AllReclamationPlan.DayCount - 1);
        }

        void AllReclamationLeft_Click(object sender, EventArgs e)
        {
            AllReclamationsStart = AllReclamationsStart.AddDays(-7);
            AllReclamationEndSet.Value = AllReclamationStartSet.Value.AddDays(AllReclamationPlan.DayCount - 1);
        }

        void AllProjectSetDate_Click(object sender, EventArgs e)
        {
            AllProjectsStart = AllProjectStartTimeSet.Value;
            if (AllProjectStartTimeSet.Value > AllProjectsEndTimeSet.Value)
            {
                AllProjectsEndTimeSet.Value = AllProjectStartTimeSet.Value.AddDays(9);
            }
            TimeSpan tmp = AllProjectsEndTimeSet.Value - AllProjectStartTimeSet.Value;
            AllProjectPlan.DayCount = tmp.Days + 1;
        }

        void AllProjectRight_Click(object sender, EventArgs e)
        {
            AllProjectsStart = AllProjectsStart.AddDays(7);
            AllProjectsEndTimeSet.Value = AllProjectStartTimeSet.Value.AddDays(AllProjectPlan.DayCount - 1);
        }

        void AllProjectLeft_Click(object sender, EventArgs e)
        {
            AllProjectsStart = AllProjectsStart.AddDays(-7);
            AllProjectsEndTimeSet.Value = AllProjectStartTimeSet.Value.AddDays(AllProjectPlan.DayCount - 1);
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

        private void Invoke(Action action)
        {
            if (action != null) action();
        }

        #region IMainView

        public WeekPlannerRow GetNewRowAllProjects(string name)
        {
            DataColumns datacolumn = new DataColumns(AllProjectPlan.Calendar);
            datacolumn["q1"].Data.Add(name);
            WeekPlannerRow row = new WeekPlannerRow {Columns = datacolumn};
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
            foreach (WeekPlannerRow row in AllProjectPlan.Rows)
            {
                row.Items.Clear();
            }
            AllProjectPlan.Rows.Clear();
        }//очистка всего планнера

        public WeekPlannerRow GetNewRowAllReclamations(string name)
        {
            var datacolumn = new DataColumns(AllReclamationPlan.Calendar);
            datacolumn["q1"].Data.Add(name);
            var row = new WeekPlannerRow {Columns = datacolumn};
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
            foreach (var row in AllReclamationPlan.Rows)
            {
                row.Items.Clear();
            }
            AllReclamationPlan.Rows.Clear();
        }

        public WeekPlannerRow GetNewRowSelfProjects(string name)
        {
            var datacolumn = new DataColumns(SelfProjectPlan.Calendar);
            datacolumn["q1"].Data.Add(name);
            var row = new WeekPlannerRow {Columns = datacolumn};
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
            foreach (var row in SelfProjectPlan.Rows)
            {
                row.Items.Clear();
            }
            SelfProjectPlan.Rows.Clear();
        }//очистка всего планнера

        public WeekPlannerRow GetNewRowSelfReclamations(string name)
        {
            DataColumns datacolumn = new DataColumns(SelfReclamationPlan.Calendar);
            datacolumn["q1"].Data.Add(name);
            WeekPlannerRow row = new WeekPlannerRow {Columns = datacolumn};
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
            foreach (WeekPlannerRow row in SelfReclamationPlan.Rows)
            {
                row.Items.Clear();
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

        public object TableProject
        {
            set
            {
                MetroTableProject.DataSource = value;
            }
        }
        public object TableReclamation
        {
            set
            {
                MetroTableReclamation.DataSource = value;
            }
        }

        public event Action<int> TableProjectClick;
        public event Action<int> TableReclamationClick;
        public event Action<int> DeleteProject;
        public event Action<int> DeleteReclamation;

        public object ChartSelfProject
        {
            set
            {
                //MetroChartProject.Series[0].YValueType = ChartValueType.Int32;
                //MetroChartProject.Series[0].XValueType = ChartValueType.String; 
                MetroChartProject.DataSource = value;
                MetroChartProject.Series[0].AxisLabel = "Value";
                MetroChartProject.Series[0].YValueMembers = "Value";
                MetroChartProject.Series[0].XValueMember = "State";

            }
        }
        public object ChartProject
        {
            set
            {
                ProjectStat.DataSource = value;
                ProjectStat.Series[0].YValueMembers = "Value";
                ProjectStat.Series[0].XValueMember = "State";
            }
        }

        public event Action CreateProject;
        public event Action CreateReclamation;

        #endregion

        public DateTime AllProjectsStart
        {
            get
            {
                return AllProjectPlan.CurrentDate;
            }
            set
            {
                AllProjectPlan.CurrentDate = value;
                AllProjectStartTimeSet.Value = value;
            }
        }
        public DateTime AllProjectsEnd
        {
            get
            {
                return AllProjectPlan.CurrentDate.AddDays(AllProjectPlan.DayCount - 1);
            }
            set
            {
                AllProjectsEndTimeSet.Value = value;
                AllProjectPlan.DayCount = (value - AllProjectPlan.CurrentDate).Days;
            }
        }
        public DateTime AllReclamationsStart
        {
            get
            {
                return AllReclamationPlan.CurrentDate;
            }
            set
            {
                AllReclamationPlan.CurrentDate = value;
                AllReclamationStartSet.Value = value;
                //AllReclamationsEndTimeSet.Value = value.AddDays(AllReclamationPlan.DayCount-1);
            }
        }
        public DateTime AllReclamationEnd
        {
            get
            {
                return AllReclamationPlan.CurrentDate.AddDays(AllReclamationPlan.DayCount - 1);
            }
            set
            {
                AllReclamationEndSet.Value = value;
                AllReclamationPlan.DayCount = (value - AllReclamationPlan.CurrentDate).Days;
            }
        }
        public DateTime SelfProjectsStart
        {
            get
            {
                return SelfProjectPlan.CurrentDate;
            }
            set
            {
                SelfProjectPlan.CurrentDate = value;
                SelfProjectStartSet.Value = value;
                //SelfProjectsEndTimeSet.Value = value.AddDays(SelfProjectPlan.DayCount-1);
            }
        }
        public DateTime SelfProjectsEnd
        {
            get
            {
                return SelfProjectPlan.CurrentDate.AddDays(SelfProjectPlan.DayCount - 1);
            }
            set
            {
                SelfProjectEndSet.Value = value;
                SelfProjectPlan.DayCount = (value - SelfProjectPlan.CurrentDate).Days;
            }
        }
        public DateTime SelfReclamationsStart
        {
            get
            {
                return SelfReclamationPlan.CurrentDate;
            }
            set
            {
                SelfReclamationPlan.CurrentDate = value;
                SelfReclamationStartSet.Value = value;
                //SelfReclamationsEndTimeSet.Value = value.AddDays(SelfReclamationPlan.DayCount-1);
            }
        }
        public DateTime SelfReclamationEnd
        {
            get
            {
                return SelfReclamationPlan.CurrentDate.AddDays(SelfReclamationPlan.DayCount - 1);
            }
            set
            {
                SelfReclamationEndSet.Value = value;
                SelfReclamationPlan.DayCount = (value - SelfReclamationPlan.CurrentDate).Days;
            }
        }
    }
}