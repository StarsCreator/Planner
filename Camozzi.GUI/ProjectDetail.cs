using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework;
using Camozzi.Presentation.Injection;
using Camozzi.Presentation.Views;

namespace Camozzi.GUI
{
    public partial class ProjectDetail : MetroForm, IProjectView
    {
        public ProjectDetail()
        {
            InitializeComponent();
            butOk.Click += (sender, args) => Invoke(Ok);
            butCancel.Click += (sender, args) => Invoke(Cancel);
            btnMng.Click += (sender, args) => Invoke(Mgr);
            btnUsr.Click += (sender, args) => Invoke(Usr);
        }

        public new void Show()
        {
            ShowDialog();
        }

        void Invoke(Action action)
        {
            if (action != null) action();
        }

        #region IProjectView

        public event Action Ok;
        public event Action Cancel;
        public event Action Mgr;
        public event Action Usr;

        public void SetNameErr()
        {
            errorProvider1.SetError(NameTb, "Некорректное имя");
        }
        public void SetDateErr()
        {
            errorProvider1.SetError(StartMdt, "Некоректная дата");
        }   
        public int Id
        {
            set
            {
                IdTB.Text = value.ToString();
            }
        }
        public string ProjectName
        {
            get
            {
                return NameTb.Text;
            }
            set
            {
                NameTb.Text = value;
                this.Text = value;
            }
        }
        public DateTime Start
        {
            get
            {
                return StartMdt.Value;
            }
            set
            {
                StartMdt.Value = value;
            }
        }
        public DateTime Finish
        {
            get
            {
                return FinishMdt.Value;
            }
            set
            {
                FinishMdt.Value = value;
            }
        }
        public object SelectedUser
        {
            get
            {
                return userCb.SelectedItem;
            }
            set
            {
                userCb.SelectedItem = value;
            }
        }
        public object Users
        {
            set
            {
                userCb.DataSource = value;
            }
        }
        public object SelectedManager
        {
            get
            {
                return managerCb.SelectedItem;
            }
            set
            {
                managerCb.SelectedItem = value;
            }
        }
        public object Managers
        {
            set
            {
                managerCb.DataSource = value;
            }
        }
        public int State
        {
            get
            {
                return StateCb.SelectedIndex;
            }
            set
            {
                StateCb.SelectedIndex = value;
            }
        }
        public int Priority
        {
            get
            {
                return PriorityCb.SelectedIndex;
            }
            set
            {
                PriorityCb.SelectedIndex = value;
            }
        }
        public string Comment
        {
            get
            {
                return CommentTb.Text;
            }
            set
            {
                CommentTb.Text = value;
            }
        }

        public bool AllowChange
        {
            set
            {
                NameTb.Enabled = value;
                StartMdt.Enabled = value;
                FinishMdt.Enabled = value;
                managerCb.Enabled = value;
                userCb.Enabled = value;
                StateCb.Enabled = value;
                PriorityCb.Enabled = value;
            }
        }
        public bool AllowComment 
        {
            set
            {
                CommentTb.Enabled = value;
            } 
        }
         
        #endregion
    }
}
