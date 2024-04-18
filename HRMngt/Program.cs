using HRMngt.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Configuration;
using HRMngt.Presenter;
using HRMngt.Model;
using HRMngt.Views;
using HRMngt._Repository;
using HRMngt.Presenters;

namespace HRMngt
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Environment.OSVersion.Version.Major >= 6)
                SetProcessDPIAware();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form chatServerForm = new ChatServer();
            ILoginRepository loginRepository = new LoginRepository();
            ILoginView loginView = new LoginView();
            new LoginPresenter(loginView, loginRepository);
            Application.Run(chatServerForm);
            
            Application.Run((Form)loginView);


        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
