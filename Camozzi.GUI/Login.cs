using System;
using System.Windows.Forms;
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
                //UsR.DisplayMember = 
            }
        }
        public string UserName 
        {
            get
            {
                return UsR.SelectedItem.ToString();
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
            Psw.Text = String.Empty;
        }
        #endregion
    }
}
