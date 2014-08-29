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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTrav.start = dateTimePicker1.Value;
            DataTrav.Start = dateTimePicker1.Value.ToString("yyyyMMdd");
            DataTrav.end = dateTimePicker2.Value;
            DataTrav.End = dateTimePicker2.Value.ToString("yyyyMMdd");
            DataTrav.ProjectName = textBox1.Text;
            DataTrav.ch = true;
            this.Close();
        }
    }
}
