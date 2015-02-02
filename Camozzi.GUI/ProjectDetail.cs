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

namespace Camozzi.GUI
{
    public partial class ProjectDetail : MetroForm,IView
    {
        public ProjectDetail()
        {
            butOk.Click += (sender, args) => Invoke(Ok);
            butCancel.Click += (sender, args) => Invoke(Cancel);
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
        public int UserId { get; set; }
        int ManagerId { get; set; }
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
        #endregion
    }
}
