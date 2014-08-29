using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Braincase.GanttChart;

namespace CamozziClient
{
    public partial class Main : Form
    {
        ProjectManager mManager = new ProjectManager();
        ProjectManager mManager2 = new ProjectManager();
        static string connString = "Data Source=localhost\\SQLEXPRESS;Integrated Security=SSPI; Connection Timeout=260";
        SqlConnection con = new SqlConnection(connString);

        public Main()
        {
            InitializeComponent();
        }

        DataTable UserPass = new DataTable();
        DataTable Projects = new DataTable();

        private void Main_Load(object sender, EventArgs e)
        {
            this.Hide();
            try
            {               
                string query = @"SELECT [UserId],[UserName],[Password],[AccessType]
                            FROM [Camozzi].[dbo].[Users]";
                SqlCommand comm = new SqlCommand(query, con);

                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(comm);
                DataSet ds = new DataSet();
                da.Fill(ds);
                UserPass = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Login q = new Login(UserPass);
            q.ShowDialog();
            GlobalInitialization();
            UserInitialization(DataTrav.ID);
            mChart.TaskMouseDoubleClick += new EventHandler<TaskMouseEventArgs>(mChart_TaskMouseDoubleClick);
            mChart2.TaskMouseDoubleClick += new EventHandler<TaskMouseEventArgs>(mChart2_TaskMouseDoubleClick);
            //timer1.Start();
            //
        }

        void mChart2_TaskMouseDoubleClick(object sender, TaskMouseEventArgs e)
        {
            if (DataTrav.AccTyp >= 1)
            {
                DateTime start = DateTime.Now;
                DateTime end = DateTime.Now;
                end = end.AddDays(e.Task.End);
                start = start.AddDays(e.Task.Start);
                ProjectEdit q = new ProjectEdit(e.Task.Name.ToString(), start, end);
                q.ShowDialog();
                if (DataTrav.ch)
                {
                    var str = (DataTrav.start - DateTime.Today);
                    mManager.SetStart(e.Task, str.Days);
                    mManager2.SetStart(e.Task, str.Days);
                    var fns = (DataTrav.end - DateTime.Today);
                    mManager.SetEnd(e.Task, fns.Days);
                    mManager2.SetEnd(e.Task, fns.Days);
                    e.Task.Name = DataTrav.ProjectName;
                }
            }
        }

        void mChart_TaskMouseDoubleClick(object sender, TaskMouseEventArgs e)
        {
            if (DataTrav.AccTyp == 2)
            {
                DateTime start = DateTime.Now;
                DateTime end = DateTime.Now;
                end = end.AddDays(e.Task.End);
                start = start.AddDays(e.Task.Start);
                ProjectEdit q = new ProjectEdit(e.Task.Name.ToString(), start, end);
                q.ShowDialog();
                if (DataTrav.ch)
                {
                    var str = (DataTrav.start - DateTime.Today);
                    mManager.SetStart(e.Task, str.Days);
                    mManager2.SetStart(e.Task, str.Days);
                    var fns = (DataTrav.end - DateTime.Today);
                    mManager.SetEnd(e.Task, fns.Days);
                    mManager2.SetEnd(e.Task, fns.Days);
                    e.Task.Name = DataTrav.ProjectName;
                }
            }
        }       

        void GlobalInitialization()
        {
            try
            {
                string query = @"SELECT [ProjectId],[ProjectName],[CreatorID],[DateStart],[DateEnd],[Priority],[State],[Finished]
                            FROM [Camozzi].[dbo].[Projects]";
                SqlCommand comm = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(comm);
                DataSet ds = new DataSet();
                
                da.Fill(ds);
                Projects = ds.Tables[0];
                for (int q = 0; q < Projects.Rows.Count; q++)
                {
                    var Start = DateTime.Parse(Projects.Rows[q].ItemArray[3].ToString()) - DateTime.Today;
                    var End = DateTime.Parse(Projects.Rows[q].ItemArray[4].ToString()) - DateTime.Today;
                    var _task = new MyTask(mManager) { Name = Projects.Rows[q].ItemArray[1].ToString() };
                    mManager.Add(_task);
                    mManager.SetStart(_task, (int)Start.Days);
                    mManager.SetEnd(_task, (int)End.Days);
                    //mChart.SelectedTask.;
                }

                mChart.Init(mManager);
                mChart.CreateTaskDelegate = delegate() { return new MyTask(mManager); };
                mManager.TimeScale = TimeScale.Day;
                var span = DateTime.Today - mManager.Start;
                mManager.Now = (int)Math.Round(span.TotalDays); // set the "Now" marker at the correct date
                mChart.TimeScaleDisplay = TimeScaleDisplay.DayOfWeek;
                if (DataTrav.AccTyp < 1)
                {
                    contextMenuStrip1.Enabled = false;
                }
                else mChart2.AllowTaskDragDrop = true;
                if (DataTrav.AccTyp < 2)
                {
                    contextMenuStrip2.Enabled = false;
                    dataGridView1.ReadOnly = true;
                }
                else mChart.AllowTaskDragDrop = true;
                
                
                dataGridView1.DataSource = new BindingSource(mManager.Tasks, null);
                dataGridView1.Columns[0].HeaderText = "Начало";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void UserInitialization(int id)
        {
           
            try
            {
                for (int q = 0; q < Projects.Rows.Count; q++)
                {
                    if (Projects.Rows[q].ItemArray[2].ToString() == id.ToString())
                    {
                        var Start = DateTime.Parse(Projects.Rows[q].ItemArray[3].ToString()) - DateTime.Today;
                        var End = DateTime.Parse(Projects.Rows[q].ItemArray[4].ToString()) - DateTime.Today;
                        var _task = new MyTask(mManager2) { Name = Projects.Rows[q].ItemArray[1].ToString() };
                        mManager2.Add(_task);
                        mManager2.SetStart(_task, (int)Start.Days);
                        mManager2.SetEnd(_task, (int)End.Days);
                    }
                }

                mChart2.Init(mManager2);
                mChart2.CreateTaskDelegate = delegate() { return new MyTask(mManager2); };
                mManager2.TimeScale = TimeScale.Day;
                var span = DateTime.Today - mManager2.Start;
                mManager2.Now = (int)Math.Round(span.TotalDays); // set the "Now" marker at the correct date
                mChart2.TimeScaleDisplay = TimeScaleDisplay.DayOfWeek;
                dataGridView2.DataSource = new BindingSource(mManager2.Tasks, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
 
        }

        private void mChart_Load(object sender, EventArgs e)
        {

        }

        private void mChart2_Load(object sender, EventArgs e)
        {

        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add q = new Add();
            q.ShowDialog();
            if (DataTrav.ch)
            {
                string query = @"INSERT INTO [Camozzi].[dbo].[Projects]
           ([ProjectName]
           ,[CreatorId]
           ,[DateStart]
           ,[DateEnd]
           ,[Priority]
           ,[State]
           ,[Finished])
     VALUES
           ('"+DataTrav.ProjectName+"',"+DataTrav.ID+",'"+DataTrav.Start+"','"+DataTrav.End+"', 1 ,0,0)";
                SqlCommand comm = new SqlCommand(query, con);
                comm.ExecuteNonQuery();

                var _task = new MyTask(mManager2) { Name = DataTrav.ProjectName };
                var str = (DataTrav.start - DateTime.Today);            
                var fns = (DataTrav.end - DateTime.Today);
                mManager2.Add(_task);
                mManager.Add(_task);
                mManager.SetStart(_task, str.Days);
                mManager.SetEnd(_task, fns.Days);
                mManager2.SetStart(_task, str.Days);
                mManager2.SetEnd(_task, fns.Days);
                mChart.Invalidate();
                mChart2.Invalidate();
                dataGridView1.Update();
                dataGridView2.Update();

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GlobalInitialization();
            UserInitialization(DataTrav.ID);
        }

        private void mnuViewDayOfMonth_Click(object sender, EventArgs e)
        {
            mChart.TimeScaleDisplay = TimeScaleDisplay.DayOfMonth;
            mnuViewDayOfWeek.Checked = false;
            mnuViewDayOfMonth.Checked = true;
            mnuViewWeekOfYear.Checked = false;
            mChart.Invalidate();
        }

        private void mnuViewWeekOfYear_Click(object sender, EventArgs e)
        {
            mChart.TimeScaleDisplay = TimeScaleDisplay.WeekOfYear;
            mnuViewDayOfWeek.Checked = false;
            mnuViewDayOfMonth.Checked = false;
            mnuViewWeekOfYear.Checked = true;
            mChart.Invalidate();
        }

        private void mnuViewDayOfWeek_Click(object sender, EventArgs e)
        {
            mChart.TimeScaleDisplay = TimeScaleDisplay.DayOfWeek;
            mnuViewDayOfWeek.Checked = true;
            mnuViewDayOfMonth.Checked = false;
            mnuViewWeekOfYear.Checked = false;
            mChart.Invalidate();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ProjectEdit q = new ProjectEdit("",DateTime.Now,DateTime.Now);
            q.ShowDialog();
            if (DataTrav.ch)
            {
                string query = @"INSERT INTO [Camozzi].[dbo].[Projects]
           ([ProjectName]
           ,[CreatorId]
           ,[DateStart]
           ,[DateEnd]
           ,[Priority]
           ,[State]
           ,[Finished])
     VALUES
           ('" + DataTrav.ProjectName + "'," + DataTrav.ID + ",'" + DataTrav.Start + "','" + DataTrav.End + "', 1 ,0,0)";
                SqlCommand comm = new SqlCommand(query, con);
                comm.ExecuteNonQuery();

                var _task = new MyTask(mManager2) { Name = DataTrav.ProjectName };
                var str = (DataTrav.start - DateTime.Today);
                var fns = (DataTrav.end - DateTime.Today);
                mManager2.Add(_task);
                mManager.Add(_task);
                mManager.SetStart(_task, str.Days);
                mManager.SetEnd(_task, fns.Days);
                mManager2.SetStart(_task, str.Days);
                mManager2.SetEnd(_task, fns.Days);
                mChart.Invalidate();
                mChart2.Invalidate();
                dataGridView1.Update();
                dataGridView2.Update();
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            mChart.Invalidate();
        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            mChart2.Invalidate();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var task = dataGridView1.SelectedRows[0].DataBoundItem as Task;
                mChart.ScrollTo(task);
            }
        }



    }
    public static class DataTrav
    {
        public static int ID;
        public static int AccTyp;
        public static string Start;
        public static string End;
        public static string ProjectName;
        public static bool ch;
        public static string username;
        public static DateTime start;
        public static DateTime end;
    }

    [Serializable]
    public class MyTask : Task
    {
        public MyTask(ProjectManager manager)
            : base()
        {
            Manager = manager;
        }

        private ProjectManager Manager { get; set; }

        public new int Start { get { return base.Start; } set { Manager.SetStart(this, value); } }
        public new int End { get { return base.End; } set { Manager.SetEnd(this, value); } }
        public new int Duration { get { return base.Duration; } set { Manager.SetDuration(this, value); } }
        public new float Complete { get { return base.Complete; } set { Manager.SetComplete(this, value); } }
    }
}
