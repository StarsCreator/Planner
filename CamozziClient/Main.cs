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
using WeekPlanner;

namespace CamozziClient
{
    public partial class Main : Form
    {
        static string connString = "Data Source=Camozzi\\SQLEXPRESS;User ID=CamozziClient;Password=1232; Connection Timeout=200";
        SqlConnection con = new SqlConnection(connString);

        List<User> Users = new List<User>();
        List<Project> Projects = new List<Project>();

        DataTable Use = new DataTable();
        DataTable Proj = new DataTable();

        public Main()
        {
            InitializeComponent();
            Plan.CurrentDate = DateTime.Today;
            Plan.Columns.Add("q1", "Сотрудник", 70);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.Hide();
            ReCreate();
            Login q = new Login(Use);
            q.ShowDialog();
            LoginUser _loginUser = new LoginUser();
            _loginUser.Id = DataTrav.ID;
            _loginUser.Name = DataTrav.username;
            _loginUser.Password = DataTrav.pwd;
            _loginUser.Access = DataTrav.AccTyp;
            timer1.Start();
        }      

        void ReCreate()
        {
            try
            {
                Users.Clear();
                Projects.Clear();
                Plan.Rows.Clear();

                con = new SqlConnection(connString);
                string query = @"SELECT * FROM Camozzi.dbo.Users";
                SqlCommand comm = new SqlCommand(query, con);

                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(comm);
                DataSet ds = new DataSet();
                da.Fill(ds);
                Use = ds.Tables[0];

                for (int w = 0; w < Use.Rows.Count; w++)
                {
                    User _user = new User();
                    _user.Id = Convert.ToInt32(Use.Rows[w].ItemArray[0]);
                    _user.Name = Use.Rows[w].ItemArray[1].ToString();
                    _user.Access = Convert.ToInt32(Use.Rows[w].ItemArray[3]);
                    Users.Add(_user);
                    ///
                    /// 
                    /// 
                    /// 
                    ///
                    var ColumnRows = new DataColumns(Plan.Calendar);
                    ColumnRows["q1"].Data.Add(_user.Name);
                    var PlannerRow = new WeekPlannerRow();
                    PlannerRow.Columns = ColumnRows;
                    PlannerRow.Name = "R"+w.ToString();
                    _user.CalendarRow = PlannerRow;
                    Plan.Rows.Add(PlannerRow);
                }

                query = @"SELECT * FROM [Camozzi].[dbo].[Projects]";
                comm = new SqlCommand(query, con);
                da = new SqlDataAdapter(comm);
                ds = new DataSet();
                
                da.Fill(ds);
                Proj = ds.Tables[0];

                for (int q = 0; q < Proj.Rows.Count; q++)
                {
                    Project _proj = new Project();
                    DateTime temp;
                    _proj.Id = Convert.ToInt32(Proj.Rows[q].ItemArray[0]);
                    _proj.Name = Proj.Rows[q].ItemArray[1].ToString();
                    DateTime.TryParse(Proj.Rows[q].ItemArray[2].ToString(), out temp);
                    _proj.Start = temp;
                    DateTime.TryParse(Proj.Rows[q].ItemArray[3].ToString(), out temp);
                    _proj.Finish = temp;
                    _proj.UserId = Convert.ToInt32(Proj.Rows[q].ItemArray[4]);
                    _proj.Priority = Convert.ToInt32(Proj.Rows[q].ItemArray[5]);
                    _proj.State = Convert.ToInt32(Proj.Rows[q].ItemArray[6]);
                    _proj.Finished = Convert.ToBoolean(Proj.Rows[q].ItemArray[7]);
                    _proj.Owner = findOwner(_proj);

                    var Item = new WeekPlannerItem();
                    Item.StartDate = _proj.Start;
                    Item.EndDate = _proj.Finish;
                    Item.Subject = _proj.Name;
                    Item.Name = _proj.Name;
                    _proj.Owner.CalendarRow.Items.Add(Item);

                }
                con.Dispose();
                GC.Collect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        User findOwner(Project Proj)
        {
            foreach (User Owner in Users)
            {
                if (Proj.UserId == Owner.Id)
                {
                    return Owner; 
                }
            }
            return null;
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
                //SqlCommand comm = new SqlCommand(query, con);
                //comm.ExecuteNonQuery();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ReCreate();
            GC.Collect();
        }

        private void mnuViewWeekOfYear_Click(object sender, EventArgs e)
        {
        }

        private void mnuViewDayOfWeek_Click(object sender, EventArgs e)
        {

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
                //SqlCommand comm = new SqlCommand(query, con);
                //comm.ExecuteNonQuery();

     //           var _task = new MyTask(mManager2) { Name = DataTrav.ProjectName };
                var str = (DataTrav.start - DateTime.Today);
                var fns = (DataTrav.end - DateTime.Today);


            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //mChart.Invalidate();
        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //mChart2.Invalidate();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            messageBoxCS.AppendFormat("{0} = {1}", "TabPage", e.TabPage);
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} = {1}", "TabPageIndex", e.TabPageIndex);
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} = {1}", "Action", e.Action);
            messageBoxCS.AppendLine();
            MessageBox.Show(messageBoxCS.ToString(), "Selected Event");
        }


    }
    public static class DataTrav
    {
        //Login User
        public static int ID;
        public static string username;
        public static string pwd;
        public static int AccTyp;


        public static string Start;
        public static string End;
        public static string ProjectName;
        public static bool ch;

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

class User
{
    public int Id { get; set;}
    public string Name { get; set;}
    //public string Password { get; set; }
    public int Access { get; set; }
    public WeekPlannerRow CalendarRow { get; set; }
}

class LoginUser
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Password { get; set; }
    public int Access { get; set; }
}

class Project
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime Start { get; set; }
    public DateTime Finish { get; set; } 
    public int UserId { get; set; }
    public User Owner { get; set; }
    public int Priority { get; set; }
    public int State { get; set; }
    public bool Finished { get; set; }

}