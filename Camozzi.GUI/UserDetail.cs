using Camozzi.Presentation.Views;
using MetroFramework.Forms;
using System;

namespace Camozzi.GUI
{
    public partial class UserDetail : MetroForm,IUserView
    {
        public UserDetail()
        {
            InitializeComponent();

            OkBtn.Click += (sender, args) => Invoke(Ok);
        }

        void Invoke(Action action)
        {
            if (action != null) action();
        }

        public new void Show()
        {
            ShowDialog();
        }

        #region IUserView

        public event Action Ok;

        public string UserName
        {
            set
            {
                this.Text = value;
            }
        }

        public string Phone
        {
            set
            {
                fieldPhone.Text = value;
            }
        }

        public string Mail
        {
            set
            {
                fieldMail.Text = value;
            }
        }

        public string Dept
        {
            set
            {
                fieldDept.Text = value;
            }
        }

        public string Comment
        {
            set
            {
                fieldComment.Text = value;
            }
        }

        #endregion
    }
}
