using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace CamozziClient
{
    public partial class ProjectEdit : Form
    {
        public ProjectEdit(Project _proj, int Access, List<User> users)
        {
            InitializeComponent();
            switch (Access)
            {
                case 0:
                    {
                        txtName.ReadOnly = true;
                        tpFinish.Enabled = false;
                        tpStart.Enabled = false;
                        //rtbCom.Enabled = false;
                        cbPriority.Enabled = false;
                        cbState.Enabled = false;
                        cbUser.Enabled = false;
                        break;
                    }
                case 1:
                    {
                        txtName.ReadOnly = false;
                        tpFinish.Enabled = true;
                        tpStart.Enabled = true;
                        cbPriority.Enabled = true;
                        cbState.Enabled = true;
                        cbUser.Enabled = false;
                        break;
                    }
                case 2:
                    {
                        txtName.ReadOnly = false;
                        tpFinish.Enabled = true;
                        tpStart.Enabled = true;
                        cbPriority.Enabled = true;
                        cbState.Enabled = true;
                        cbUser.Enabled = true;
                        break; 
                    }
                case 3:
                    {
                        txtName.ReadOnly = false;
                        tpFinish.Enabled = true;
                        tpStart.Enabled = true;
                        cbPriority.Enabled = true;
                        cbState.Enabled = true;
                        cbUser.Enabled = true;
                        break; 
                    }
            }
            this.Text = _proj.Name;
            txtNo.Text = _proj.Id.ToString();
            txtName.Text = _proj.Name;
            tpStart.Value = _proj.Start;
            tpFinish.Value = _proj.Finish;
            rtbCom.Text = _proj.Comment;
            cbUser.DataSource = users;
            cbUser.DisplayMember = "Name";
            //Исполнитель
            cbUser.SelectedItem = _proj.Users;
            //приоритет
            cbPriority.SelectedIndex = _proj.Priority;
            //состояние
            cbState.SelectedIndex = _proj.State;
            DataTrav.ch = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (txtName.Text == "")
            {
                errorProvider1.SetError(txtName, "Имя проекта не может быть пустым!");
                return;
            }
            if (tpStart.Value > tpFinish.Value)
            {
                errorProvider1.SetError(tpStart, "Дата окончания раньше даты начала!");
                return;
            }
            User owner = (User)cbUser.SelectedItem;
            Project ret = new Project { Name = txtName.Text, Comment = rtbCom.Text, Priority = cbPriority.SelectedIndex, State = cbState.SelectedIndex, Start = tpStart.Value, Finish = tpFinish.Value, Users = owner,UserId=owner.Id };
            DataTrav.proj = ret;
            DataTrav.ch = true;
            this.Close();
        }

        private void tpFinish_ValueChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (tpFinish.Value < tpStart.Value)
            {
                tpFinish.Value = tpStart.Value;
                errorProvider1.SetError(tpFinish, "Некорректная дата");
            }
        }

        private void ProjectEdit_Load(object sender, EventArgs e)
        {

        }

        private void ProjectEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DataTrav.ch) e.Cancel = false;
            else
            {
                DialogResult res = new DialogResult();
                res = MessageBox.Show("Закрыть форму ввода без сохранения?", "Закрыть",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else
                    e.Cancel = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbState_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbState.SelectedIndex == 2)
            {
                cbPriority.SelectedIndex = 0;
            }
        }
    }
}
