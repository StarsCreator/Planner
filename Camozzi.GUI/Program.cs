﻿using Camozzi.Model.Repository;
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
            Mutex q = new Mutex(true, "CamozziClient", out onlyInstance);
            if (onlyInstance)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);


                var controller = new ApplicationController(new InjectAdapter())
                .RegisterView<ILoginView, Login>()
                .RegisterView<IMainView, Main>()
                .RegisterView<IProjectView,ProjectDetail>()
                .RegisterView<IReclamationView,ReclamationDetail>()
                .RegisterView<IUserView,UserDetail>()
                .RegisterSingletoneService<ILog,LogService>()
                .RegisterService<ITableService,TableService>()
                .RegisterService<IChartService,ChartService>()
                .RegisterService<IReclamationRepository,ReclamationRepository>()
                .RegisterService<IUserRepository,UserRepository>()
                .RegisterService<IProjectRepository,ProjectRepository>()
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
