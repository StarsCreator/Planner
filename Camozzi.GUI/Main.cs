using System;
using System.Drawing;
using System.Windows.Forms;
using Camozzi.GUI.Properties;
using Camozzi.Presentation.Views;
using WeekPlanner;
using Brush = System.Drawing.Brush;
using Color = System.Drawing.Color;

namespace Camozzi.GUI
{
    public partial class Main : Form, IMainView
    {
        private readonly ApplicationContext _context;

        public Main(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();

            //AllProjectPlan
            AllProjectPlan.Columns.Add("q1", "Сотрудник", 30);
            AllProjectPlan.CurrentDate = DateTime.Today;
            AllProjectPlan.ItemDoubleClick += AllProjectPlan_ItemDoubleClick;
            AllProjectLeft.Click += AllProjectLeft_Click;
            AllProjectRight.Click += AllProjectRight_Click;
            AllProjectSetDate.Click += AllProjectSetDate_Click;

            //SelfProjectPlan
            SelfProjectPlan.Columns.Add("q1", "Сотрудник", 30);
            SelfProjectPlan.CurrentDate = DateTime.Today;
            SelfProjectPlan.ItemDoubleClick += SelfProjectPlan_ItemDoubleClick;
            SelfProjectRight.Click += SelfProjectRight_Click;
            SelfProjectLeft.Click += SelfProjectLeft_Click;
            SelfProjectSetDate.Click += SelfProjectSetDate_Click;

            //MetroTableProject
            MetroTableProject.CellDoubleClick += MetroTableProject_CellDoubleClick;
            MetroTableProject.CellMouseDown += MetroTableProject_CellMouseDown;
            MetroTableProject.RowsAdded += MetroTableProject_RowsAdded;

            //ContextProj
            AddProj.Click += (sender, args) => Invoke(CreateProject);
            addNewProj.Click += (sender, args) => Invoke(CreateProject);
            EditProj.Click += EditProj_Click;
            DeleteProj.Click += DeleteProj_Click;

            //mainChart
            //mainProjChart.Series[0].Points.AddXY("Январь", 10);
            //mainProjChart.Series[0].Points.AddXY("Февраль", 15);
            //mainProjChart.Series[1].Points.AddXY("Jan", 15);
            //mainProjChart.Series[1].Points.AddXY("Feb", 40);

            //tabs
            tabControl1.DrawItem += tabControl1_DrawItem;
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            var g = e.Graphics;

            var tabPage = tabControl1.TabPages[e.Index];
            var tabBounds = tabControl1.GetTabRect(e.Index);

            var newBounds = new Rectangle()
            {
                X = tabBounds.X + 16,
                Y = tabBounds.Y + 7,
                Height = 32,
                Width = 32
            };

            Bitmap img;

            switch (e.Index)
            {
                case 0:
                {
                    img = new Bitmap(Resources.main);
                    break;
                }

                case 1:
                {
                    img = new Bitmap(Resources.allChart);
                    break;
                }
                case 2:
                {
                    img = new Bitmap(Resources.selfChart);
                    break;
                }
                case 3:
                {
                    img = new Bitmap(Resources.report);
                    break;
                }
                case 4:
                {
                    img = new Bitmap(Resources.settings48);
                    break;
                }
                default:
                {
                    img = new Bitmap(Resources.main);
                    break;
                }
            }

            g.DrawImage(img, newBounds);

            Brush textBrush = e.State == DrawItemState.Selected
                ? new SolidBrush(Color.Black)
                : new SolidBrush(Color.Gray);

            // Use our own font.
            var tabFont = new Font("Segoe UI", 9.75F);
            var stringFlags = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Far
            };
            g.DrawString(tabPage.Text, tabFont, textBrush, tabBounds, new StringFormat(stringFlags));
        }

        private void DeleteProj_Click(object sender, EventArgs e)
        {
            if (DeleteProject != null)
                DeleteProject((int) MetroTableProject.SelectedRows[0].Cells[0].Value);
        }

        private void EditProj_Click(object sender, EventArgs e)
        {
            if (TableProjectClick != null)
                TableProjectClick((int) MetroTableProject.SelectedRows[0].Cells[0].Value);
        }

        private void MetroTableProject_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            if (e.RowIndex == -1) return;
            MetroTableProject.ClearSelection();
            MetroTableProject.Rows[e.RowIndex].Selected = true;
            MetroTableProject.CurrentCell = MetroTableProject[0, e.RowIndex];
        }

        private void MetroTableProject_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            MetroTableProject.Rows[e.RowIndex].ContextMenuStrip = ContextProj;
        }

        private void MetroTableProject_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if (TableProjectClick != null) TableProjectClick((int) MetroTableProject.SelectedRows[0].Cells[0].Value);
        }

        private void SelfProjectSetDate_Click(object sender, EventArgs e)
        {
            SelfProjectsStart = SelfProjectStartSet.Value;
            if (SelfProjectStartSet.Value > SelfProjectEndSet.Value)
            {
                SelfProjectEndSet.Value = SelfProjectStartSet.Value.AddDays(9);
            }
            TimeSpan tmp = SelfProjectEndSet.Value - SelfProjectStartSet.Value;
            SelfProjectPlan.DayCount = tmp.Days + 1;
        }

        private void SelfProjectLeft_Click(object sender, EventArgs e)
        {
            SelfProjectsStart = SelfProjectsStart.AddDays(-7);
            SelfProjectEndSet.Value = SelfProjectStartSet.Value.AddDays(SelfProjectPlan.DayCount - 1);
        }

        private void SelfProjectRight_Click(object sender, EventArgs e)
        {
            SelfProjectsStart = SelfProjectsStart.AddDays(7);
            SelfProjectEndSet.Value = SelfProjectStartSet.Value.AddDays(SelfProjectPlan.DayCount - 1);
        }

        private void AllProjectSetDate_Click(object sender, EventArgs e)
        {
            AllProjectsStart = AllProjectStartTimeSet.Value;
            if (AllProjectStartTimeSet.Value > AllProjectsEndTimeSet.Value)
            {
                AllProjectsEndTimeSet.Value = AllProjectStartTimeSet.Value.AddDays(9);
            }
            TimeSpan tmp = AllProjectsEndTimeSet.Value - AllProjectStartTimeSet.Value;
            AllProjectPlan.DayCount = tmp.Days + 1;
        }

        private void AllProjectRight_Click(object sender, EventArgs e)
        {
            AllProjectsStart = AllProjectsStart.AddDays(7);
            AllProjectsEndTimeSet.Value = AllProjectStartTimeSet.Value.AddDays(AllProjectPlan.DayCount - 1);
        }

        private void AllProjectLeft_Click(object sender, EventArgs e)
        {
            AllProjectsStart = AllProjectsStart.AddDays(-7);
            AllProjectsEndTimeSet.Value = AllProjectStartTimeSet.Value.AddDays(AllProjectPlan.DayCount - 1);
        }

        private void AllProjectPlan_ItemDoubleClick(object sender, WeekPlannerItemEventArgs e)
        {
            if (AllProjectsItemDoubleClick != null) AllProjectsItemDoubleClick(this, e);
        }

        private void SelfProjectPlan_ItemDoubleClick(object sender, WeekPlannerItemEventArgs e)
        {
            if (SelfProjectsItemDoubleClick != null) SelfProjectsItemDoubleClick(this, e);
        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }

        private static void Invoke(Action action)
        {
            if (action != null) action();
        }

        #region IMainView

        public WeekPlannerRow GetNewRowAllProjects(string name)
        {
            var datacolumn = new DataColumns(AllProjectPlan.Calendar);
            datacolumn["q1"].Data.Add(name);
            var row = new WeekPlannerRow {Columns = datacolumn};
            return row;
        }

        public WeekPlannerRowCollection AllProjectsRows
        {
            get { return AllProjectPlan.Rows; }
        }

        public DateTime AllProjectStart
        {
            get { return AllProjectPlan.CurrentDate; }
            set { AllProjectPlan.CurrentDate = value; }
        }

        public int AllProjectDuration
        {
            get { return AllProjectPlan.DayCount; }
            set { AllProjectPlan.DayCount = value; }
        }

        public event EventHandler<WeekPlannerItemEventArgs> AllProjectsItemDoubleClick; //вызов состояния

        public void ClearAllProjects()
        {
            foreach (var row in AllProjectPlan.Rows)
            {
                row.Items.Clear();
            }
            lock (AllProjectPlan)
            {
                AllProjectPlan.Rows.Clear();
            }
        } //очистка всего планнера

//строки и элементы


        public WeekPlannerRow GetNewRowSelfProjects(string name)
        {
            var datacolumn = new DataColumns(SelfProjectPlan.Calendar);
            datacolumn["q1"].Data.Add(name);
            var row = new WeekPlannerRow {Columns = datacolumn};
            return row;
        }

        public WeekPlannerRowCollection SelfProjectsRows
        {
            get { return SelfProjectPlan.Rows; }
        }

        public DateTime SelfProjectStart
        {
            get { return SelfProjectPlan.CurrentDate; }
            set { SelfProjectPlan.CurrentDate = value; }
        }

        public int SelfProjectDuration
        {
            get { return SelfProjectPlan.DayCount; }
            set { SelfProjectPlan.DayCount = value; }
        }

        public event EventHandler<WeekPlannerItemEventArgs> SelfProjectsItemDoubleClick; //вызов состояния

        public void ClearSelfProjects()
        {
            foreach (var row in SelfProjectPlan.Rows)
            {
                row.Items.Clear();
            }
            SelfProjectPlan.Rows.Clear();
        } //очистка всего планнера

//строки и элементы

        public object TableProject
        {
            set
            {
                if (MetroTableProject.InvokeRequired)
                {
                    Action<object> d = SetProjectTable;
                    Invoke(d, value);
                }
                else
                {
                    MetroTableProject.DataSource = value;
                }
            }
        }

        private void SetProjectTable(object o)
        {
            MetroTableProject.DataSource = o;
        }

        public event Action<int> TableProjectClick;
        public event Action<int> DeleteProject;

        public int waitProj
        {
            set { lblWaitProj.Text = value.ToString(); }
        }

        public int allProj
        {
            set { lblAllProj.Text = value.ToString(); }
        }

        public int comProj
        {
            set { lblCompProj.Text = value.ToString(); }
        }

        public int workProj
        {
            set { lblWorkProj.Text = value.ToString(); }
        }

        public int stopProj
        {
            set { lblStopProj.Text = value.ToString(); }
        }

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
                //ProjectStat.DataSource = value;
                //ProjectStat.Series[0].YValueMembers = "Value";
                //ProjectStat.Series[0].XValueMember = "State";
            }
        }

        public event Action CreateProject;
        public event Action FormClose;

        public bool HideEndProject
        {
            get { return HideAllEndProjectCh.Checked; }
            set { HideAllEndProjectCh.Checked = value; }
        }

        public bool AddManagerName
        {
            get { return AddManagerNameChx.Checked; }
            set { AddManagerNameChx.Checked = value; }
        }

        #endregion

        public DateTime AllProjectsStart
        {
            get { return AllProjectPlan.CurrentDate; }
            set
            {
                AllProjectPlan.CurrentDate = value;
                AllProjectStartTimeSet.Value = value;
            }
        }

        public DateTime AllProjectsEnd
        {
            get { return AllProjectPlan.CurrentDate.AddDays(AllProjectPlan.DayCount - 1); }
            set
            {
                AllProjectsEndTimeSet.Value = value;
                AllProjectPlan.DayCount = (value - AllProjectPlan.CurrentDate).Days;
            }
        }

        public DateTime SelfProjectsStart
        {
            get { return SelfProjectPlan.CurrentDate; }
            set
            {
                SelfProjectPlan.CurrentDate = value;
                SelfProjectStartSet.Value = value;
                //SelfProjectsEndTimeSet.Value = value.AddDays(SelfProjectPlan.DayCount-1);
            }
        }

        public DateTime SelfProjectsEnd
        {
            get { return SelfProjectPlan.CurrentDate.AddDays(SelfProjectPlan.DayCount - 1); }
            set
            {
                SelfProjectEndSet.Value = value;
                SelfProjectPlan.DayCount = (value - SelfProjectPlan.CurrentDate).Days;
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FormClose != null) FormClose();
        }
    }
}