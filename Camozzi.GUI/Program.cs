using Camozzi.Model.Repository;
using Camozzi.Model.Services;
using Camozzi.Presentation.Injection;
using Camozzi.Presentation.Presenters;
using Camozzi.Presentation.Views;
using System;
using System.Threading;
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
            new Mutex(true, "CamozziClient", out onlyInstance);
            if (onlyInstance)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);


                var controller = new ApplicationController(new InjectAdapter())
                .RegisterView<ILoginView, Login>()
                .RegisterView<IMainView, Main>()
                .RegisterView<IProjectView,ProjectDetail>()
                .RegisterView<IUserView,UserDetail>()
                .RegisterSingletoneService<ILog,LogService>()
                .RegisterService<ITableService,TableService>()
                .RegisterService<IChartService,ChartService>()
                .RegisterSingletoneService<IUserRepository, UserRepository>()
                .RegisterSingletoneService<IProjectRepository, ProjectRepository>()
                .RegisterSingletoneService<ISettings,Settings>()
                .RegisterInstance(new ApplicationContext());
                controller.Run<LoginPresenter>();
            }
            else
            {
                MessageBox.Show(@"Приложение уже запущено",@"CamozziClient",MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
