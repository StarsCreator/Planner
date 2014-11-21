using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CamozziClient.Properties;

namespace CamozziClient
{
    public partial class Login : Form
    {
        //DbSet users;
        public Login(List<User> users)
        {
            InitializeComponent();

            comboBox1.DataSource = users;
            comboBox1.DisplayMember = "Name";
            if (Settings.Default.LastUser == "" || Settings.Default.LastUser == null)
            {
                comboBox1.SelectedItem = comboBox1.Items[0];
            }
            else
            {
                comboBox1.SelectedItem = users.Find(delegate(User b)
                {
                    return b.Name == Settings.Default.LastUser;
                });
            }
            textBox1.Select();
            DataTrav.quit = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            settlers();
        }
        void settlers()
        {
            User k = (User)comboBox1.SelectedItem;
            if (textBox1.Text == k.Password)
            {
                DataTrav.user = k;
                DataTrav.quit = false;
                //MessageBox.Show("Luck!");
                this.Close();
            }
            else
            {
                errorProvider1.SetError(textBox1, "Неверный пароль!");
                textBox1.Text = "";
            } 
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Return)
            {
                settlers();
            }
        }
    }
}
