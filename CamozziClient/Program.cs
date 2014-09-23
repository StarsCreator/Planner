using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace CamozziClient
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
            Mutex q = new Mutex(true,"CamozziClient", out onlyInstance);
            if (onlyInstance)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Main());
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
