﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Camozzi.GUI.Properties;
using MetroFramework.Forms;
using Camozzi.Presentation.Views;

namespace Camozzi.GUI
{
    public partial class Login : MetroForm,ILoginView
    {
        private readonly ApplicationContext _context;
        public new void Show()
        {
            _context.MainForm = this;
            Application.Run(_context);
        }
        public Login(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
            LogBtn.Click += (sender, args) => Invoke(Ok);
        }

        void Invoke (Action action)
        {
            if (action != null) action();
        }

        #region ILoginView
        public event Action Ok;

        public object Users
        {
            set
            {
                UsR.DataSource = value;
            }
        }
        public object UserName 
        {
            get
            {
                return UsR.SelectedItem;
            }
        }
        public string Password 
        {
            get
            {
                return Psw.Text;
            }
        }

        public void ClearPswFld()
        {
            Psw.Text = "";
        }
        #endregion
    }
}
