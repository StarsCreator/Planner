using System;
using System.Deployment.Application;
using System.Windows.Forms;
using Camozzi.Presentation.Views;
using MetroFramework.Forms;

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
            LogBtn.Focus();
            Focus();
            //var ver = ApplicationDeployment.CurrentDeployment.CurrentVersion;
            //Console.WriteLine(@"ClickOnce Publish Version: {0}", ver);
        }

        static void Invoke (Action action)
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
            set { UsR.SelectedItem = value; }
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

        private void Psw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Return)
            {
                Invoke(Ok);
            }
        }
    }
}
