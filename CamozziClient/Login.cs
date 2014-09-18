using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamozziClient
{
    public partial class Login : Form
    {
        DataTable z;
        public Login(DataTable UserPass)
        {
            InitializeComponent();
            z = UserPass;
            for(int q=0;q<UserPass.Rows.Count;q++)
            {
                comboBox1.Items.Add(UserPass.Rows[q].ItemArray[1]);
            }
        }
       

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            settlers();
        }
        void settlers()
        {
            string k = z.Rows[comboBox1.SelectedIndex].ItemArray[2].ToString();
            if (textBox1.Text == k)
            {
                int w = Convert.ToInt32(z.Rows[comboBox1.SelectedIndex].ItemArray[0]);
                DataTrav.ID = w;
                string r = z.Rows[comboBox1.SelectedIndex].ItemArray[1].ToString();
                DataTrav.username = r;
                int e = Convert.ToInt16(z.Rows[comboBox1.SelectedIndex].ItemArray[3]);
                DataTrav.AccTyp = e;
                DataTrav.pwd = k;
                this.Close();
            }
            else
            {
                textBox1.Text = "";
            } 
        }
    }
}
