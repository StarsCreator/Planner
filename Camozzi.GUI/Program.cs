using Camozzi.Model.Repository;
using Camozzi.Presentation.Injection;
using Camozzi.Presentation.Presenters;
using Camozzi.Presentation.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Camozzi.GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool onlyInstance;
            Mutex q = new Mutex(true, "CamozziClient", out onlyInstance);
            if (onlyInstance)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);


                var controller = new ApplicationController(new InjectAdapter())
                .RegisterView<ILoginView, Login>()
                .RegisterView<IMainView, Main>()
                .RegisterService<IUserRepository,UserRepository>()
                .RegisterInstance(new ApplicationContext());
                controller.Run<LoginPresenter>();
            }
            else
            {
                MessageBox.Show(
                   "Приложение уже запущено",
                   "CamozziClient",
                   MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
