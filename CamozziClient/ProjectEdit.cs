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
    public partial class ProjectEdit : Form
    {
        public ProjectEdit(string name, DateTime start, DateTime finish)
        {
            InitializeComponent();
            textBox1.Text = name;
            dateTimePicker1.Value = start;
            dateTimePicker2.Value = finish;
            DataTrav.ch = false;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTrav.ch = true;
            DataTrav.start = dateTimePicker1.Value;
            DataTrav.Start = dateTimePicker1.Value.ToString("yyyyMMdd");
            DataTrav.end = dateTimePicker2.Value;
            DataTrav.End = dateTimePicker2.Value.ToString("yyyyMMdd");
            DataTrav.ProjectName = textBox1.Text;
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
