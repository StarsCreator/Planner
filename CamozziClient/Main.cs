using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;
using WeekPlanner;

namespace CamozziClient
{
    public partial class Main : Form
    {
        static string connString = "Data Source=CSRV\\SQLEXPRESS;User ID=CamozziClient;Password=1232; Connection Timeout=10";
        SqlConnection con = new SqlConnection(connString);

        List<User> Users = new List<User>();
        List<Project> Projects = new List<Project>();

        //DataTable Use;
        //DataTable Proj;

        User _loginUser = new User();
        String Password;

        bool refresh = false;

        public Main()
        {
            InitializeComponent();

            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today.AddDays(9);
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;

            Plan.CurrentDate = DateTime.Today;
            UserPlan.CurrentDate = DateTime.Today;

            Plan.Columns.Add("q1", "Сотрудник", 60);
            UserPlan.Columns.Add("q1", "Сотрудник", 60);

            Plan.ItemDoubleClick += new CalendarPlanner.CalendarItemEventHandler(Plan_ItemDoubleClick);
            UserPlan.ItemDoubleClick += new CalendarPlanner.CalendarItemEventHandler(UserPlan_ItemDoubleClick);

            notifyIcon1.Visible = false;
        }
        void Plan_ItemDoubleClick(object sender, WeekPlannerItemEventArgs e)
        {
            timer1.Stop();
            int access = 0;
            if (_loginUser.Access == 1) { access = 0; }
            else access = _loginUser.Access;
            Project EditProj = Projects[e.Item.Tag];
            ProjectEdit q = new ProjectEdit(EditProj,access,cds.Users);

            q.ShowDialog();
            if (DataTrav.ch)
            {
                int UsID=0;
                foreach (User tmp in Users)
                {
                    if (DataTrav.Name == tmp.Name)
                    {
                        UsID = tmp.Id;
                        break;
                    }

                }
                //string query;
                //con = new SqlConnection(connString);
                if (_loginUser.Access >= 2)
                {
                          /*query = @"UPDATE [Camozzi].[dbo].[Projects] Set Name='"+DataTrav.ProjectName+"'"+
                                    ",UserId="+UsID+
                                    ",Start='"+DataTrav.Start.ToString("yyyyMMdd")+
                                    "',Finish='"+DataTrav.End.ToString("yyyyMMdd")+
                                    "',Priority="+DataTrav.Priority+
                                    ",State=" + DataTrav.State +
                                    ",Comment='"+DataTrav.Comments+"'"+
                                    "Where Id="+EditProj.Id+";";*/
                    //EditProj.datarow.ItemArray[0] = 
                    EditProj.datarow.BeginEdit();
                    EditProj.datarow["Name"] = DataTrav.ProjectName;
                    EditProj.datarow["Start"] = DataTrav.Start;
                    EditProj.datarow["Finish"] = DataTrav.End;
                    EditProj.datarow["UserID"] = UsID;
                    EditProj.datarow["Priority"] = DataTrav.Priority;
                    EditProj.datarow["State"] = DataTrav.State;
                    EditProj.datarow["Comment"] = DataTrav.Comments;
                    EditProj.datarow.EndEdit();
                    //cds.Projects.AcceptChanges();
                }                   
                else
                {
                    EditProj.datarow.BeginEdit();
                    EditProj.datarow["Comment"] = DataTrav.Comments;
                    EditProj.datarow.EndEdit();
                    //cds.Projects.AcceptChanges();
                }
                LocalSync();
                ReCreate();
            }
            timer1.Start();
        }
        void UserPlan_ItemDoubleClick(object sender, WeekPlannerItemEventArgs e)
        {
            timer1.Stop();
            Project EditProj = Projects[e.Item.Tag];
            ProjectEdit q = new ProjectEdit(EditProj, _loginUser.Access,cds.Users);

            q.ShowDialog();
            if (DataTrav.ch)
            {
                int UsID = 0;
                foreach (User tmp in Users)
                {
                    if (DataTrav.Name == tmp.Name)
                    {
                        UsID = tmp.Id;
                        break;
                    }

                }
                    con = new SqlConnection(connString);
                    string query = @"UPDATE [Camozzi].[dbo].[Projects] Set Name='" + DataTrav.ProjectName + "'" +
                          ",UserId=" + UsID +
                          ",Start='" + DataTrav.Start.ToString("yyyyMMdd") +
                          "',Finish='" + DataTrav.End.ToString("yyyyMMdd") +
                          "',Priority=" + DataTrav.Priority +
                          ",State=" + DataTrav.State +
                          ",Comment='" + DataTrav.Comments + "'" +
                       "Where Id=" + EditProj.Id + ";";

                    SqlCommand comm = new SqlCommand(query, con);
                    con.Open();
                    comm.ExecuteNonQuery();
                    con.Close();
                    //Thread bgd = new Thread(ReCreate);
                    //bgd.Start();
                    ReCreate();
            }
            timer1.Start();
        }

        void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            if (dateTimePicker2.Value < dateTimePicker1.Value)
            {
                dateTimePicker2.Value = dateTimePicker1.Value.AddDays(2);
            }
        }
        

        private void Main_Load(object sender, EventArgs e)
        {
            this.Hide();
            try
            {
                // TODO: This line of code loads data into the 'cds.Users' table. You can move, or remove it, as needed.
                this.usersTableAdapter.Fill(this.cds.Users);
                /*string query = @"SELECT * FROM Camozzi.dbo.Users Order By Name";
                SqlCommand comm = new SqlCommand(query, con);

                con.Open();
                con.Close();*/

                //ReCreate();
                //UserReCreate(_loginUser);

                Login q = new Login(cds.Users);
                q.ShowDialog();
                if (DataTrav.quit)
                {
                    this.Close();
                } 

                _loginUser.Id = DataTrav.ID;
                _loginUser.Name = DataTrav.UserName;
                Password = DataTrav.pwd;
                _loginUser.Access = DataTrav.AccTyp;
                
                // TODO: This line of code loads data into the 'cds.Projects' table. You can move, or remove it, as needed.
                this.projectsTableAdapter.Fill(cds.Projects);

                ReCreate();
                UserInitialization();
                notifyIcon1.Visible = false;
                timer1.Start();
                this.Show();
                this.WindowState = FormWindowState.Maximized;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message +"\n\n Обратитесь к разработчику программы. \n\nПриложение будет закрыто!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

        void UserInitialization()
        {
            this.Text = _loginUser.Name;
            UserReCreate(_loginUser);
            Plan.ItemDatesChanged += new CalendarPlanner.CalendarItemEventHandler(Plan_ItemDatesChanged);
            switch (_loginUser.Access)
            {
                case 0:
                    {
                        //Plan.
                        Plan.IsAllowedStretchAndDrag = false;
                        break;
                    }
                case 1:
                    {
                        Plan.IsAllowedStretchAndDrag = false;
                        break;
                    }
                case 2:
                    {
                        Plan.ContextMenuStrip = contextMenuStrip1;
                        Plan.IsAllowedStretchAndDrag = true;
                        break;
                    }
                case 3:
                    {
                        Plan.ContextMenuStrip = contextMenuStrip1;
                        Plan.IsAllowedStretchAndDrag = true;
                        break;
                    }
            }
        }

        void Plan_ItemDatesChanged(object sender, WeekPlannerItemEventArgs e)
        {
            //throw new NotImplementedException();
        }

        void UserSync()
        {
            foreach (WeekPlannerItem _item in UserPlan.Rows[0].Items)
            {
                Project SyncProj = Projects[_item.Tag];
                con = new SqlConnection(connString);
                string query = @"UPDATE [Camozzi].[dbo].[Projects] Set Name='" + SyncProj.Name + "'" +
                      ",Start='" + SyncProj.Start.ToString("yyyyMMdd") +
                      "',Finish='" + SyncProj.Finish.ToString("yyyyMMdd") +
                      "',Priority=" + SyncProj.Priority +
                      ",State=" + SyncProj.State +
                      ",Comment='" + SyncProj.Comment + "'" +
                   "Where Id=" + SyncProj.Id + ";";

                SqlCommand comm = new SqlCommand(query, con);
                con.Open();
                comm.ExecuteNonQuery();
            }
        }

        void ReCreate()
        {
            //try
            {
                refresh = true;
                Users.Clear();
                Projects.Clear();
                foreach (WeekPlannerRow _row in Plan.Rows)
                {
                    _row.Items.Clear();
                }
                Plan.Rows.Clear();

                /*con = new SqlConnection(connString);
                string query = @"SELECT * FROM Camozzi.dbo.Users Order By Name";
                SqlCommand comm = new SqlCommand(query, con);
                cds.Users
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(comm);
                DataSet ds = new DataSet();
                da.Fill(ds);*/
                for (int w = 0; w < cds.Users.Rows.Count; w++)
                {
                    User _user = new User();
                    _user.Id = Convert.ToInt32(cds.Users.Rows[w].ItemArray[0]);
                    _user.Name = cds.Users.Rows[w].ItemArray[1].ToString();
                    _user.Access = Convert.ToInt32(cds.Users.Rows[w].ItemArray[3]);
                    Users.Add(_user);
                    ///

                    if (_user.Access < 3)
                    {
                        var ColumnRows = new DataColumns(Plan.Calendar);
                        ColumnRows["q1"].Data.Add(_user.Name);
                        var PlannerRow = new WeekPlannerRow();
                        PlannerRow.Columns = ColumnRows;
                        PlannerRow.Name = "R" + w.ToString();
                        PlannerRow.LeftMarginBackColor = Color.FromArgb(255, 225, 225, 255);
                        PlannerRow.LeftMarginOldBackColor = Color.WhiteSmoke;
                        _user.CalendarRow = PlannerRow;
                        Plan.Rows.Add(PlannerRow);
                    }
                }
                /*query = @"SELECT * FROM [Camozzi].[dbo].[Projects]";
                comm = new SqlCommand(query, con);
                con.Open();
                da = new SqlDataAdapter(comm);
                ds = new DataSet();
                
                da.Fill(ds);*/
                //con.Close();
                //Proj = cds.Projects;
                for (int q = 0; q < cds.Projects.Rows.Count; q++)
                {
                    Project _proj = new Project();
                    DateTime temp;
                    _proj.Id = Convert.ToInt32(cds.Projects.Rows[q].ItemArray[0]);
                    _proj.Name = cds.Projects.Rows[q].ItemArray[1].ToString();

                    DateTime.TryParse(cds.Projects.Rows[q].ItemArray[2].ToString(), out temp);
                    _proj.Start = temp;
                    DateTime.TryParse(cds.Projects.Rows[q].ItemArray[3].ToString(), out temp);
                    _proj.Finish = temp;
                    _proj.UserId = Convert.ToInt32(cds.Projects.Rows[q].ItemArray[4]);
                    _proj.Priority = Convert.ToInt32(cds.Projects.Rows[q].ItemArray[5]);
                    _proj.State = Convert.ToInt32(cds.Projects.Rows[q].ItemArray[6]);
                    _proj.Comment = cds.Projects.Rows[q].ItemArray[7].ToString();
                    Projects.Add(_proj);
                    _proj.Owner = findOwner(_proj);
                    _proj.datarow = cds.Projects.Rows[q];


                    //ToolTip tt = new ToolTip();

                    var Item = new WeekPlannerItem();
                    Item.StartDate = _proj.Start;
                    Item.EndDate = _proj.Finish;
                    Item.Subject = _proj.Name;
                    Item.Name = _proj.Name;
                    Item.Tag = Projects.IndexOf(_proj);
                    //tt.SetToolTip(Item, _proj.Name);
                    switch (_proj.State)
                    {
                        case 0:
                            {
                                Item.BackColor = Color.Yellow;
                                break;
                            }
                        case 1:
                            {
                                Item.BackColor = Color.LightGreen;
                                break;
                            }
                        case 2:
                            {
                                Item.BackColor = Color.WhiteSmoke;
                                break;
                            }
                    }
                    if (_proj.Priority == 1) Item.BackColor = Color.LightCoral;
                    _proj.Owner.CalendarRow.Items.Add(Item);
                    if (_proj.State == 1) Item.BackColor = Color.LightGreen;
                    if (_loginUser.Name != "" && _loginUser.Name != null)
                    {
                        UserReCreate(_loginUser);
                    }
                    refresh = false;
                }
            }
           // catch (Exception ex)
          //  {
       //         refresh = false;
       //         MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      //      }
        }

        void UserReCreate(User _user)
        {
            if (UserPlan.Rows.Count != 0)
            {
                UserPlan.Rows[0].Items.Clear();
            }
            UserPlan.Rows.Clear();

            if (dataGridView1.Rows.Count != 0)
            {
                //int k = dataGridView1.CurrentRow.Index;
                dataGridView1.Rows.Clear();
            }
            var ColumnRows = new DataColumns(UserPlan.Calendar);
            ColumnRows["q1"].Data.Add(_user.Name);
            var PlannerRow = new WeekPlannerRow();
            PlannerRow.Columns = ColumnRows;
            PlannerRow.Name = "R";
            PlannerRow.LeftMarginBackColor = Color.FromArgb(255,225, 225, 255);
            PlannerRow.LeftMarginOldBackColor = Color.WhiteSmoke;
            _loginUser.CalendarRow = PlannerRow;
            UserPlan.Rows.Add(PlannerRow);

            foreach (Project _proj in Projects)
            {
                if (_proj.UserId == _user.Id)
                {
                    var Item = new WeekPlannerItem();
                    Item.StartDate = _proj.Start;
                    Item.EndDate = _proj.Finish;
                    Item.Subject = _proj.Name;
                    Item.Name = _proj.Name;
                    Item.Tag = Projects.IndexOf(_proj);
                    switch (_proj.State)
                    {
                        case 0:
                            {
                                Item.BackColor = Color.Yellow;
                                break;
                            }
                        case 2:
                            {
                                Item.BackColor = Color.DarkGray;
                                break;
                            }
                        case 3:
                            {
                                Item.BackColor = Color.GhostWhite;
                                break;
                            }
                        default:
                            {
                                Item.BackColor = Color.GhostWhite;
                                break;
                            }
                    }
                    if (_proj.Priority == 1) Item.BackColor = Color.LightCoral;
                    UserPlan.Rows[0].Items.Add(Item);
                    if (_proj.State == 1) Item.BackColor = Color.LightGreen;

                    DataGridViewRow newRow = new DataGridViewRow();
                    newRow.ContextMenuStrip = contextMenuStrip1;
                    DataGridViewCell id = new DataGridViewTextBoxCell();
                    id.Value = _proj.Id;
                    DataGridViewCell Name = new DataGridViewTextBoxCell();
                    Name.Value = _proj.Name;
                    DataGridViewCell Start = new DataGridViewTextBoxCell();
                    Start.Value = _proj.Start.ToString("dd.MM.yyyy");
                    DataGridViewCell Finish = new DataGridViewTextBoxCell();
                    Finish.Value = _proj.Finish.ToString("dd.MM.yyyy");                  
                    newRow.Tag = _proj;
                    newRow.Cells.Add(id);
                    newRow.Cells.Add(Name);
                    newRow.Cells.Add(Start);
                    newRow.Cells.Add(Finish);
                    dataGridView1.Rows.Add(newRow);
                }
            }
            GC.Collect();
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
            timer1.Stop();
            Project _NewProj = new Project();
            _NewProj.Start = DateTime.Today;
            _NewProj.Finish = DateTime.Today;
            _NewProj.Owner = _loginUser;
            _NewProj.Priority = 0;
            _NewProj.State = 0;
            _NewProj.UserId = _loginUser.Id;
            ProjectEdit q = new ProjectEdit(_NewProj, _loginUser.Access,cds.Users);

            q.ShowDialog();
            if (DataTrav.ch)
            {
                int UsID = 0;
                foreach (User tmp in Users)
                {
                    if (DataTrav.Name == tmp.Name)
                    {
                        UsID = tmp.Id;
                        break;
                    }

                }
                //создание строки
                DataRow n = cds.Projects.NewRow();
                //заполнение
                //n["Id"] = cds.Projects.Count;
                n["Name"] = DataTrav.ProjectName;
                n["Start"] = DataTrav.Start;//.ToString("yyyy-MM-dd");
                n["Finish"] = DataTrav.End;//.ToString("yyyy-MM-dd");
                n["UserID"] = UsID;
                n["Priority"] = DataTrav.Priority;
                n["State"] = DataTrav.State;
                n["Comment"] = DataTrav.Comments;
                //Добавление и обновление
                cds.Projects.Rows.Add(n);
                
               /* string query = @"INSERT INTO [Camozzi].[dbo].[Projects]
           ([Name]
           ,[Start]
           ,[Finish]
           ,[UserId]
           ,[Priority]
           ,[State]
           ,[Comment])
     VALUES
           ('" + DataTrav.ProjectName + "','" + DataTrav.Start.ToString("yyyMMdd") + "','" + DataTrav.End.ToString("yyyMMdd") + "'," + UsID + "," + DataTrav.Priority + "," + DataTrav.State + ",'" + DataTrav.Comments + "')";
                SqlCommand comm = new SqlCommand(query, con);
                con.Open();
                comm.ExecuteNonQuery();
                con.Close();*/
                LocalSync();
                ReCreate();
            }
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!refresh)
            {
                ReCreate();
            }
            GC.Collect();
        }

        private void LocalSync()
        {
            try
            {
                this.Validate();

                this.usersBindingSource.EndEdit();
                this.projectsBindingSource.EndEdit();

                this.usersTableAdapter.Update(this.cds.Users);
                this.projectsTableAdapter.Update(this.cds.Projects);

                //MessageBox.Show("Update successful");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed: " + ex.Message);
            }
        }

        private void дниToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Plan.DatesIntervalMode == WeekPlannerMode.Weekly)
            {
                Plan.DatesIntervalMode = WeekPlannerMode.Daily;
                UserPlan.DatesIntervalMode = WeekPlannerMode.Daily;
                дниToolStripMenuItem.Checked = true;
                неделиToolStripMenuItem.Checked = false;
            }
        }

        private void неделиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Plan.DatesIntervalMode == WeekPlannerMode.Daily)
            {
                Plan.DatesIntervalMode = WeekPlannerMode.Weekly;
                UserPlan.DatesIntervalMode = WeekPlannerMode.Weekly;
                дниToolStripMenuItem.Checked = false;
                неделиToolStripMenuItem.Checked = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Plan.CurrentDate = dateTimePicker1.Value;
            UserPlan.CurrentDate = dateTimePicker1.Value;
            if (dateTimePicker1.Value > dateTimePicker2.Value)
            {
                dateTimePicker2.Value = dateTimePicker1.Value.AddDays(9);
            }
            TimeSpan Tmp = dateTimePicker2.Value - dateTimePicker1.Value;
            Plan.DayCount = Tmp.Days + 1;
            UserPlan.DayCount = Tmp.Days + 1;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            timer1.Stop();
            Project EditProj = (Project)dataGridView1.CurrentRow.Tag;
            ProjectEdit q = new ProjectEdit(EditProj, _loginUser.Access,cds.Users);

            q.ShowDialog();
            if (DataTrav.ch)
            {
                con = new SqlConnection(connString);
                string query = @"UPDATE [Camozzi].[dbo].[Projects] Set Name='" + DataTrav.ProjectName + "'" +
                      ",Start='" + DataTrav.Start.ToString("yyyyMMdd") +
                      "',Finish='" + DataTrav.End.ToString("yyyyMMdd") +
                      "',Priority=" + DataTrav.Priority +
                      ",State=" + DataTrav.State +
                      ",Comment='" + DataTrav.Comments + "'" +
                   "Where Id=" + EditProj.Id + ";";

                SqlCommand comm = new SqlCommand(query, con);
                con.Open();
                comm.ExecuteNonQuery();
                con.Close();

                ReCreate();
            }
            timer1.Start();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Plan.CurrentDate = Plan.CurrentDate.AddDays(-7);
            UserPlan.CurrentDate = Plan.CurrentDate.AddDays(-7);
        }

        private void btnFrwd_Click(object sender, EventArgs e)
        {
            UserPlan.CurrentDate = UserPlan.CurrentDate.AddDays(7);
            Plan.CurrentDate = Plan.CurrentDate.AddDays(7);
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Maximized;
            notifyIcon1.Visible = false;

        }

        private void градиентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (градиентToolStripMenuItem.Checked)
            {
                Plan.HeaderStyleMode = HeaderStyle.Simple;
                UserPlan.HeaderStyleMode = HeaderStyle.Simple;
                градиентToolStripMenuItem.Checked = false;
            }
            else
            {
                Plan.HeaderStyleMode = HeaderStyle.Aqua;
                UserPlan.HeaderStyleMode = HeaderStyle.Aqua;
                градиентToolStripMenuItem.Checked = true;
            }
        }

        private void меньшеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Plan.ItemHeight > 20)
            {
                Plan.ItemHeight = Plan.ItemHeight - 10;
                UserPlan.ItemHeight = UserPlan.ItemHeight - 10;
            }
        }

        private void большеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Plan.ItemHeight <100)
            {
                Plan.ItemHeight = Plan.ItemHeight + 10;
                UserPlan.ItemHeight = UserPlan.ItemHeight + 10;
            }
        }

        private void Plan_ItemMouseHover(object sender, WeekPlannerItemEventArgs e)
        {
            DownLabel.Text = e.Item.Name;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (refresh)
            {
                while (!refresh)
                {
                    Thread.Sleep(10);
                }
            }
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.Graphics.DrawString("x", e.Font, Brushes.Black, e.Bounds.Right - 15, e.Bounds.Top + 4);
            e.Graphics.DrawString(this.tabControl1.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + 12, e.Bounds.Top + 4);
            e.DrawFocusRectangle();
        }

        private void tabControl1_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < this.tabControl1.TabPages.Count; i++)
            {
                Rectangle r = tabControl1.GetTabRect(i);
                //Getting the position of the "x" mark.
                Rectangle closeButton = new Rectangle(r.Right - 15, r.Top + 4, 9, 7);
                if (closeButton.Contains(e.Location))
                {
                    if (MessageBox.Show("Would you like to Close this Tab?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.tabControl1.TabPages.RemoveAt(i);
                        break;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ldcSyncAgent syncAgent = new ldcSyncAgent();
                Microsoft.Synchronization.Data.SyncStatistics syncStats = syncAgent.Synchronize();
                MessageBox.Show("Changes downloaded: " + syncStats.TotalChangesDownloaded.ToString() + Environment.NewLine + "Changes uploaded: " + syncStats.TotalChangesUploaded.ToString());
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
    public static class DataTrav
    {
        //Changes flag
        public static bool ch;
        //Login User
        public static int ID;
        public static string UserName;
        public static string pwd;
        public static int AccTyp;

        public static string ProjectName;
        public static DateTime Start;
        public static DateTime End;
        public static string Comments;
        public static int State;
        public static int Priority;
        public static string Name;

        public static bool quit;
    }
}

public class User
{
    public int Id { get; set;}
    public string Name { get; set;}
    //public string Password { get; set; }
    public int Access { get; set; }
    public WeekPlannerRow CalendarRow { get; set; }
}

public class Project
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime Start { get; set; }
    public DateTime Finish { get; set; } 
    public int UserId { get; set; }
    public User Owner { get; set; }
    public int Priority { get; set; }
    public int State { get; set; }
    public string Comment { get; set; }
    public DataRow datarow {get;set; }

}