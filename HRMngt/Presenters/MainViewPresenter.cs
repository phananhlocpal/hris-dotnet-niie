using HRMngt._Repository;
using HRMngt._Repository.Calendar;
using HRMngt._Repository.Communicate;
using HRMngt._Repository.Request;
using HRMngt._Repository.Recruitment;
using HRMngt._Repository.Salary;
using HRMngt._Repository.Support;
using HRMngt.Models;
using HRMngt.Presenter;
using HRMngt.View;
using HRMngt.Views;
using HRMngt.Views.Client;
using HRMngt.Views.Dialogs;
using HRMngt.Views.HR;
using HRMngt.Views.Request;
using HRMngt.Views.Salary;
using HRMngt.Views.User;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace HRMngt.Presenters
{
    public class MainViewPresenter
    {
        private UserModel userModel;
        private IMainView mainView;
        private IMainIndividualView mainIndividual;

        private IHomeView homeView = new Home();
        private IDepartmentView departmentView = new DepartmentView();
        private IRecruitView recruitView = new RecruitView();
        private IRequestView requestView = new RequestView();
        private ISalaryView salaryView = new SalaryView();
        private ITimeKeepingView timeKeepingView = new TimeKeepingView();
        private IUserView userView = new UserView();
        private ISupport supportView = new Support();

        private IThumbTicketView thumbTicketView = new ThumbTicketView();
        private IIndividualCalendarView individualCalendarView = new IndividualCalendarView();
        private IIndividualSalaryView individualSalaryView = new IndividualSalaryView();

        private ICalendarRepository calendarRepository = new CalendarRepository();
        private IDepartmentRepository departmentRepository = new DepartmentRepository();
        private ISupportRepository supportRepository = new SupportRepository();
        private IRecruitmentRepository recruitmentRepository = new RecruitmentRepository();
        private IRequestRepository requestRepository = new RequestRepository();
        private ISalaryRepository salaryRepository = new SalaryRepository();
        private IThumbTicketRepository thumbTicketRepository = new ThumbTicketRepository();
        private IUserRepository userRepository = new UserRepository();

        public MainViewPresenter(IMainView mainView, UserModel userModel, IMainIndividualView individualView)
        {
            this.mainView = mainView;
            this.userModel = userModel;
            this.mainIndividual = individualView;

            mainView.Show();
            individualView.Hide();

            mainView.ShowHomeView += ShowHomeView;
            mainView.ShowDepartmentView += ShowDepartmentView;
            mainView.ShowUserView += ShowUserView;
            mainView.ShowSupportView += ShowSupportView;
            mainView.ShowSalaryView += ShowSalaryView;
            mainView.ShowLoginEvent += ShowLoginView;
            mainView.ShowRecuitView += ShowRecuitView;
            mainView.ShowTimeKeepingView += ShowTimeKeepingView;
            mainView.ShowCommunicateView += ShowCommunicateView;
            mainView.ShowRequestView += ShowRequestView;

            mainView.ShowMainIndividualView += ShowMainIndividualView;

            ShowDefaultView();
            mainView.ShowUserInformation(userModel);
            mainView.Show();
        }

        public void ShowDefaultView()
        {
            homeView = Home.GetInstance((MainView)mainView);
            new HomePresenter(homeView, calendarRepository, userModel);
        }

        // Main view Showing
        private void ShowHomeView(object sender, EventArgs e)
        {
            homeView = Home.GetInstance((MainView)mainView);
            new HomePresenter(homeView, calendarRepository, userModel);
        }

        private void ShowUserView(object sender, EventArgs e)
        {
            userView = UserView.GetInstance((MainView)mainView);
            new UserPresenter(userView, userRepository, userModel);
        }

        private void ShowSalaryView(object sender, EventArgs e)
        {
            salaryView = SalaryView.GetInstance((MainView)mainView);
            new SalaryPresenter(salaryView, salaryRepository, userModel);
        }
        private void ShowRecuitView(object sender, EventArgs e)
        {
            recruitView = RecruitView.GetInstance((MainView)mainView);
            new RecruitmentPresenter(recruitView, recruitmentRepository, userModel);
        }
        private void ShowTimeKeepingView(object sender, EventArgs e)
        {
            timeKeepingView = TimeKeepingView.GetInstance((MainView)mainView);
            new TimeKeepingPresenter(timeKeepingView, calendarRepository, userModel);

        }
        private void ShowDepartmentView(object sender, EventArgs e)
        {
            departmentView = DepartmentView.GetInstance((MainView)mainView);
            new DepartmentPresenter(departmentView, departmentRepository, userModel);
        }

        private void ShowRequestView(object sender, EventArgs e)
        {
            requestView = RequestView.GetInstance((MainView)mainView);
            new RequestPresenter(requestView, requestRepository, userModel);
        }
        private void ShowSupportView(object sender, EventArgs e)
        {
            ISupport view = Support.GetInstance((MainView)mainView);
            ISupportRepository repository = new SupportRepository();
            new SupportPresenter(view, repository);
        }
        private void ShowCommunicateView(object sender, EventArgs e)
        {
            IClientView view = ClientView.GetInstance((MainView)mainView);
            ICommunicateRepository repository = new CommunicateRepository();

            new CommunicatePresenter(view, repository);
        }
        private void ShowLoginView(object sender, EventArgs e)
        {
            ILoginView view = new Views.LoginView();
            IUserRepository repository = new UserRepository();
            new LoginPresenter(view, repository);
        }

        private void ShowMainIndividualView(object sender, EventArgs e)
        {
            mainIndividual.Show();
            mainView.Hide();

            new MainIndividualPresenter(mainIndividual, userModel, mainView);
        }
    }
}
