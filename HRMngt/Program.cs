using HRMngt.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Configuration;
using HRMngt.Presenter;
using HRMngt.Models;
using HRMngt.Views;
using HRMngt._Repository;
using HRMngt.Presenters;
using HRMngt.Views.Dialogs;
using HRMngt._Repository.Calendar;

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

            UserModel userModel = new UserModel();
            userModel.Id = "NV001";
            userModel.Name = "Phan Anh Loc";
            userModel.Position = "Admin";
            userModel.Roles = "Manager";
            //ITimeKeepingView view = new TimeKeepingView();
            //ICalendarRepository repository = new CalendarRepository();
            //new TimeKeepingPresenter(view, repository, userModel);

            //IMainIndividualView view1 = new MainInvidiualView(userModel);
            //new MainIndividualPresenter(view1,userModel);

            //IMainView view = new MainView();
            //new MainViewPresenter(view, userModel);

            ILoginView view = new LoginView();
            IUserRepository repository = new UserRepository();
            new LoginPresenter(view, repository);

            Application.Run((Form)view);
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
