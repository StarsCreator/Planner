using Camozzi.Presentation.Injection;
using Camozzi.Presentation.Views;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Camozzi.GUI
{
    public partial class ReclamationDetail : MetroForm, IReclamationView
    {
        public ReclamationDetail()
        {
            InitializeComponent();

            OkBtn.Click += (sender, args) => Invoke(Ok);
            CancelBtn.Click += (sender, args) => Invoke(Cancel);
            btnMng.Click += (sender, args) => Invoke(Mgr);
            btnUsr.Click += (sender, args) => Invoke(Usr);
        }

        public new void Show()
        {
            ShowDialog();
        }

        public void Invoke(Action action)
        {
            if (action != null) action();
        }

        #region IReclamationView

        public event Action Ok;
        public event Action Cancel;
        public event Action Mgr;
        public event Action Usr;

        public void SetNameErr()
        {
            errorProvider1.SetError(NomenclatureTb, "Некорректное поле");
        }
        public void SetDateErr()
        {
            errorProvider1.SetError(CheckedMdt, "Некорректная дата");
        }
        public void SetFinErr()
        {
            errorProvider1.SetError(SendMDt, "Некоректная дата");
        }

        public int Id 
        { 
            set
            {
                fieldId.Text = value.ToString();
            }
        }
        public System.DateTime Start 
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
        public System.DateTime Finish 
        { 
            get
            {
                return CheckedMdt.Value;
            }
            set
            {
                CheckedMdt.Value = value;
            }
        }
        public System.DateTime Send 
        {
            get
            {
                return SendMDt.Value;
            }
            set
            {
                SendMDt.Value = value;
            }
        }
        public string Production 
        {
            get
            {
                return ProductionTb.Text;
            }
            set
            {
                ProductionTb.Text = value;
            }
        }
        public string Nomenclature 
        { 
            get
            {
                return NomenclatureTb.Text;
            }
            set
            {
                NomenclatureTb.Text = value;
            }
        }
        public object SelectedUser 
        { 
            get
            {
                return UserCb.SelectedItem;
            }
            set
            {
                UserCb.SelectedItem = value;
            }
        }
        public object Users
        {
            set
            {
                UserCb.DataSource = value;
            }
        }
        public object SelectedManager 
        { 
            get
            {
                return ManagerCb.SelectedItem;
            }
            set
            {
                ManagerCb.SelectedItem = value;
            }
        }
        public object Managers 
        { 
            set
            {
                ManagerCb.DataSource = value;
            }
        }
        public string Act 
        { 
            get
            {
                return ActTb.Text;
            }
            set
            {
                ActTb.Text = value;
            }
        }
        public int Count 
        { 
            get
            {
                return Convert.ToInt32(CountTb.Text);
            }
            set
            {
                CountTb.Text = value.ToString();
            }
        }
        public int State 
        { 
            get
            {
                return StatusCb.SelectedIndex;
            }
            set
            {
                StatusCb.SelectedIndex = value;
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
        public bool Solution 
        { 
            get
            {
                return SolutionCb.Checked;
            }
            set
            {
                SolutionCb.Checked = value;
            }
        }
        public string Client 
        { 
            get
            {
                return ClientTb.Text;
            }
            set
            {
                ClientTb.Text = value;
            }
        }
        public string ReclamationAct 
        { 
            get
            {
                return ReclamationTb.Text;
            }
            set
            {
                ReclamationTb.Text = value;
            }
        }

        public bool AllowChange
        {
            set
            {
                ReclamationTb.Enabled = value;
                StartMdt.Enabled = value;
                CheckedMdt.Enabled = value;
                SendMDt.Enabled = value;
                NomenclatureTb.Enabled = value;
                ProductionTb.Enabled = value;
                fieldId.Enabled = value;
                CountTb.Enabled = value;
                ManagerCb.Enabled = value;
                ClientTb.Enabled = value;
                ActTb.Enabled = value;
                UserCb.Enabled = value;
                StatusCb.Enabled = value;
                SolutionCb.Enabled = value;
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
