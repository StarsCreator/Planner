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
using System.Data.Entity;
using CamozziClient.Properties;
using WeekPlanner;

namespace CamozziClient
{
    public partial class Main : Form
    {
        CamozziEntities db = new CamozziEntities();
        User _loginUser = new User();
        bool refresh = false;

        DateTime LeftB = new DateTime();
        DateTime RightB = new DateTime();

        public Main()
        {
            InitializeComponent();
            SetSettings();
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;

            //Plan.CurrentDate = DateTime.Today;
            //UserPlan.CurrentDate = DateTime.Today;

            Plan.Columns.Add("q1", "Сотрудник", 60);
            UserPlan.Columns.Add("q1", "Сотрудник", 60);

            Plan.ItemDoubleClick += new CalendarPlanner.CalendarItemEventHandler(Plan_ItemDoubleClick);
            UserPlan.ItemDoubleClick += new CalendarPlanner.CalendarItemEventHandler(UserPlan_ItemDoubleClick);

            LeftB = Plan.CurrentDate.AddDays(-21);
            RightB = Plan.CurrentDate.AddDays(Plan.DayCount + 21);

            //MessageBox.Show(Left.Date.ToString() + " " + Right.Date.ToString());

            notifyIcon1.Visible = false;
        }
        void SetSettings()
        {
            //временные рамки
            if (Settings.Default.CurrentDate < new DateTime(2014,1,1))
            {
                Plan.CurrentDate = DateTime.Today;
                UserPlan.CurrentDate = DateTime.Today;
                Plan.DayCount = 9;
                UserPlan.DayCount = 9;
                Settings.Default.DayCount = 9;
                dateTimePicker1.Value = DateTime.Today;
                dateTimePicker2.Value = DateTime.Today.AddDays(9);
            }
            else
            {
                Plan.CurrentDate = Settings.Default.CurrentDate;
                UserPlan.CurrentDate = Settings.Default.CurrentDate;
                Plan.DayCount = Settings.Default.DayCount;
                UserPlan.DayCount = Settings.Default.DayCount;
                dateTimePicker1.Value = Settings.Default.CurrentDate;
                dateTimePicker2.Value = Settings.Default.CurrentDate.AddDays(Plan.DayCount);
            }

            
        }
        void SavSettings()
        {
            Settings.Default.CurrentDate = Plan.CurrentDate;
            Settings.Default.DayCount = Plan.DayCount;
            Settings.Default.LastUser = _loginUser.Name;

            Settings.Default.Save();
 
        }
        void Plan_ItemDoubleClick(object sender, WeekPlannerItemEventArgs e)
        {
            timer1.Stop();
            int access = 0;
            if (_loginUser.AccType == 1) { access = 0; }
            else access = _loginUser.AccType;
            Project EditProj = (Project)e.Item.Tag;
            ProjectEdit q = new ProjectEdit(EditProj, access, db.Users.ToList());

            q.ShowDialog();
            if (DataTrav.ch)
            {
                if (_loginUser.AccType >=2 || EditProj.Comment != DataTrav.proj.Comment)
                {
                    try
                    {
                        int UsID = 0;
                        foreach (User tmp in db.Users)
                        {
                            if (DataTrav.user.Name == tmp.Name)
                            {
                                UsID = tmp.Id;
                                break;
                            }

                        }

                        EditProj.Name = DataTrav.proj.Name;
                        EditProj.Priority = DataTrav.proj.Priority;
                        EditProj.Start = DataTrav.proj.Start;
                        EditProj.State = DataTrav.proj.State;
                        EditProj.Finish = DataTrav.proj.Finish;
                        EditProj.UserId = DataTrav.proj.UserId;
                        EditProj.Users = DataTrav.proj.Users;
                        EditProj.Comment = DataTrav.proj.Comment;
                        db.Entry(EditProj).State = EntityState.Modified;
                        db.SaveChanges();
                        ReCreate(LeftB,RightB);
                        //LocalItemChange(EditProj);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            timer1.Start();
        }
        void UserPlan_ItemDoubleClick(object sender, WeekPlannerItemEventArgs e)
        {
            timer1.Stop();
            Project EditProj = (Project)e.Item.Tag;
            ProjectEdit q = new ProjectEdit(EditProj, 1, db.Users.ToList());

            q.ShowDialog();
            if (DataTrav.ch)
            {
                try
                {
                    int UsID = 0;
                    foreach (User tmp in db.Users)
                    {
                        if (DataTrav.user.Name == tmp.Name)
                        {
                            UsID = tmp.Id;
                            break;
                        }

                    }

                    EditProj.Name = DataTrav.proj.Name;
                    EditProj.Priority = DataTrav.proj.Priority;
                    EditProj.Start = DataTrav.proj.Start;
                    EditProj.State = DataTrav.proj.State;
                    EditProj.Finish = DataTrav.proj.Finish;
                    EditProj.UserId = DataTrav.proj.UserId;
                    EditProj.Users = DataTrav.proj.Users;
                    EditProj.Comment = DataTrav.proj.Comment;
                    db.Entry(EditProj).State = EntityState.Modified;
                    db.SaveChanges();
                    ReCreate(LeftB,RightB);
                    //LocalItemChange(EditProj);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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

                db.Users.Load();
                Login q = new Login(db.Users.ToList());
                q.ShowDialog();
                if (DataTrav.quit)
                {
                    this.Close();
                }

                _loginUser = DataTrav.user;
                
                db.Projects.Load();
                UserInitialization();
                ReCreate(LeftB,RightB);
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
            //UserReCreate(_loginUser);
            var ColumnRows = new DataColumns(UserPlan.Calendar);
            ColumnRows["q1"].Data.Add(_loginUser.Name);
            var PlannerRow = new WeekPlannerRow();
            PlannerRow.Columns = ColumnRows;
            PlannerRow.Name = "R";
            PlannerRow.LeftMarginBackColor = Color.FromArgb(255, 225, 225, 255);
            PlannerRow.LeftMarginOldBackColor = Color.WhiteSmoke;
            //_loginUser.CalendarRow = PlannerRow;
            UserPlan.Rows.Add(PlannerRow);

            switch (_loginUser.AccType)
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
                        Plan.IsAllowedStretchAndDrag = false;
                        break;
                    }
                case 3:
                    {
                        Plan.ContextMenuStrip = contextMenuStrip1;
                        Plan.IsAllowedStretchAndDrag = false;
                        break;
                    }
            }
        }

        void ReCreate(DateTime Start,DateTime Finish)
        {
            try
            {
                refresh = true;
                foreach (WeekPlannerRow _row in Plan.Rows)
                {
                    _row.Items.Clear();
                }
                UserPlan.Rows[0].Items.Clear();
                Plan.Rows.Clear();
                foreach (User _user in db.Users)
                {

                    if (_user.AccType < 3)
                    {
                        var ColumnRows = new DataColumns(Plan.Calendar);
                        ColumnRows["q1"].Data.Add(_user.Name);
                        var PlannerRow = new WeekPlannerRow();
                        PlannerRow.Columns = ColumnRows;
                        PlannerRow.Name = "R" + _user.Name.ToString();
                        PlannerRow.LeftMarginBackColor = Color.FromArgb(255, 225, 225, 255);
                        PlannerRow.LeftMarginOldBackColor = Color.WhiteSmoke;
                        PlannerRow.Tag = _user;
                        _user.Tag = PlannerRow;
                        Plan.Rows.Add(PlannerRow);
                    }
                }
                var buf = Plan.Rows[3];
                Plan.Rows[3] = Plan.Rows[7];
                Plan.Rows[7] = buf;

                var _projs = from p in db.Projects
                             where (p.Start >= Start && p.Start <= Finish) || (p.Finish >= Start && p.Finish <= Finish)
                             select p;
                             
                                    
                foreach(Project _proj in _projs)
                {
                    WeekPlannerItem Item = new WeekPlannerItem();
                    Item.StartDate = _proj.Start;
                    Item.EndDate = _proj.Finish;
                    Item.Subject = _proj.Name;
                    Item.Name = _proj.Name;
                    Item.Tag = _proj;
                    //Item.Context = contextMenuStrip2;
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
                                Item.BackColor = Color.DarkGray;
                                break;
                            }
                        case 3:
                            {
                                Item.BackColor = Color.GhostWhite;
                                break;
                            }
                        case 4:
                            {
                                Item.BackColor = Color.LightSkyBlue;
                                break;
                            }
                        case 5:
                            {
                                Item.BackColor = Color.Violet;
                                break;
                            }
                        default:
                            {
                                Item.BackColor = Color.GhostWhite;
                                break;
                            }
                    }
                    if (_proj.Priority == 1) Item.BackColor = Color.LightCoral;
                    if (_proj.State == 1) Item.BackColor = Color.LightGreen;
                    WeekPlannerRow row = (WeekPlannerRow)_proj.Users.Tag;
                    row.Items.Add(Item);
                    if (_proj.UserId == _loginUser.Id)
                    {
                        UserPlan.Rows[0].Items.Add(Item);
                    }
                }
                if (_loginUser.Name != "" && _loginUser.Name != null)
                    {
                        UserReCreate(_loginUser);
                    }
                refresh = false;
            }
            catch (Exception ex)
            {
                refresh = false;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void UserReCreate(User _user)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                dataGridView1.Rows.Clear();
            }

            var _projs = from p in db.Projects
                         where p.UserId == _loginUser.Id
                         select p;

            foreach (Project _proj in _projs)
            {
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
            GC.Collect();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Project _NewProj = new Project();
            _NewProj.Start = DateTime.Today;
            _NewProj.Finish = DateTime.Today;
            _NewProj.Users = _loginUser;
            _NewProj.Priority = 0;
            _NewProj.State = 0;
            _NewProj.UserId = _loginUser.Id;
            ProjectEdit q = new ProjectEdit(_NewProj, _loginUser.AccType,db.Users.ToList());

            q.ShowDialog();
            if (DataTrav.ch)
            {
                int UsID = 0;
                foreach (User tmp in db.Users)
                {
                    if (DataTrav.user.Name == tmp.Name)
                    {
                        UsID = tmp.Id;
                        break;
                    }

                }
                db.Projects.Add(DataTrav.proj);
                db.SaveChanges();
                //MessageBox.Show("Новый объект добавлен");
               ReCreate(LeftB,RightB);
            }
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!notifyIcon1.Visible)
            {
                using (db = new CamozziEntities())
                {
                    db.Users.Load();
                    db.Projects.Load();
                    ReCreate(LeftB, RightB);
                }
            }
            GC.Collect();
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
            //ReCreate(dateTimePicker1.Value, dateTimePicker2.Value);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            timer1.Stop();
            Project EditProj = (Project)dataGridView1.CurrentRow.Tag;
            ProjectEdit q = new ProjectEdit(EditProj, 1, db.Users.ToList());

            q.ShowDialog();
            if (DataTrav.ch)
            {
                try
                {
                    int UsID = 0;
                    foreach (User tmp in db.Users)
                    {
                        if (DataTrav.user.Name == tmp.Name)
                        {
                            UsID = tmp.Id;
                            break;
                        }

                    }

                    EditProj.Name = DataTrav.proj.Name;
                    EditProj.Priority = DataTrav.proj.Priority;
                    EditProj.Start = DataTrav.proj.Start;
                    EditProj.State = DataTrav.proj.State;
                    EditProj.Finish = DataTrav.proj.Finish;
                    EditProj.UserId = DataTrav.proj.UserId;
                    EditProj.Users = DataTrav.proj.Users;
                    EditProj.Comment = DataTrav.proj.Comment;
                    db.Entry(EditProj).State = EntityState.Modified;
                    db.SaveChanges();
                   ReCreate(LeftB,RightB);
                    //LocalItemChange(EditProj);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            timer1.Start();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Plan.CurrentDate = Plan.CurrentDate.AddDays(-7);
            UserPlan.CurrentDate = Plan.CurrentDate.AddDays(-7);
            //ReCreate(dateTimePicker1.Value, dateTimePicker2.Value);
        }

        private void btnFrwd_Click(object sender, EventArgs e)
        {
            UserPlan.CurrentDate = UserPlan.CurrentDate.AddDays(7);
            Plan.CurrentDate = Plan.CurrentDate.AddDays(7);
            //ReCreate(dateTimePicker1.Value, dateTimePicker2.Value);
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                //timer1.Stop();
                this.Hide();
                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Maximized;
            //timer1.Start();
            notifyIcon1.Visible = false;

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
            SavSettings();
            if (refresh)
            {
                while (!refresh)
                {
                    Thread.Sleep(10);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            db = new CamozziEntities();
            db.Users.Load();
            db.Projects.Load();
           ReCreate(LeftB,RightB);
        }

        private void Plan_CurrentDateChanged(object sender)
        {
            if (Plan.CurrentDate <= LeftB || (Plan.CurrentDate.AddDays(Plan.DayCount-5))>= RightB)
            {
                LeftB = Plan.CurrentDate.AddDays(-21);
                RightB = Plan.CurrentDate.AddDays(Plan.DayCount + 21);
                db = new CamozziEntities();
                db.Users.Load();
                db.Projects.Load();
                ReCreate(LeftB,RightB);
            }
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Options opt = new Options();
            opt.ShowDialog();
        }
    }

    public static class DataTrav
    {
        //Changes flag
        public static bool ch;
        //Login User
        public static User user;
        //Temp Project
        public static Project proj;

        public static bool quit;
    }
}