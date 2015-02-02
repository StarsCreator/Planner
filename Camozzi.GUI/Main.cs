using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Camozzi.GUI.Properties;
using MetroFramework.Forms;
using MetroFramework;
using Camozzi.Presentation.Views;

namespace Camozzi.GUI
{
    public partial class Main : MetroForm,IMainView
    {
        private readonly ApplicationContext _context;
        public Main(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }
    }
}