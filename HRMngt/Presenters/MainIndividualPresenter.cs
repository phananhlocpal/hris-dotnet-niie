using HRMngt._Repository.Calendar;
using HRMngt._Repository;
using HRMngt.Models;
using HRMngt.Presenter;
using HRMngt.View;
using HRMngt.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMngt.Views.Dialogs;
using HRMngt._Repository;
using HRMngt._Repository.Salary;
using HRMngt.Views.Request;
using HRMngt._Repository.Request;
using HRMngt.Views.HR;
using HRMngt.Views.Salary;
using HRMngt.Views.User;
using HRMngt._Repository.Support;
using HRMngt._Repository.Recruitment;

namespace HRMngt.Presenters
{
    public class MainIndividualPresenter
    {
        private UserModel userModel;
        private IMainView mainView;
        private IMainIndividualView mainIndividual;

        private IHomeView homeView = new Home();
        private IDepartmentView departmentView = new DepartmentView();
        private ILoginView loginView = new LoginView();
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

        public MainIndividualPresenter(IMainIndividualView mainIndividual, UserModel userModel, IMainView mainView)
        {
            this.mainIndividual = mainIndividual;
            this.userModel = userModel;
            this.mainView = mainView;

            // Individual Event
            this.mainIndividual.ShowThumbTicketView += ShowThumbTicketView;
            this.mainIndividual.ShowIndividualSalaryView += ShowIndividualSalaryView;
            this.mainIndividual.ShowIndividualCalendarView += ShowIndividualCalendarView;

            // Main Event
            this.mainIndividual.ShowHomeView += ShowHomeView;
            this.mainIndividual.ShowUserView += ShowUserView;
            this.mainIndividual.ShowSalaryView += ShowSalaryView; this.mainIndividual.ShowRecuitView += ShowRecruitView;
            this.mainIndividual.ShowTimeKeepingView += ShowTimeKeepingView;
            this.mainIndividual.ShowDepartmentView += ShowDepartmentView;
            this.mainIndividual.ShowRequestView += ShowRequestView;
            this.mainIndividual.ShowSalaryView += ShowSupportView;

            ShowDefautView();
            mainIndividual.ShowIndividualInfo(userModel);
            mainIndividual.Show();
        }

        public void ShowDefautView()
        {
            individualCalendarView = IndividualCalendarView.GetInstance((MainInvidiualView)mainIndividual);
            new IndividualCalendarPresenter(individualCalendarView, calendarRepository, userModel);
        }

        private void ShowIndividualCalendarView(object sender, EventArgs e)
        {
            individualCalendarView = IndividualCalendarView.GetInstance((MainInvidiualView)mainIndividual);
            new IndividualCalendarPresenter(individualCalendarView, calendarRepository, userModel);
        }

        private void ShowIndividualSalaryView(object sender, EventArgs e)
        {
            individualSalaryView = IndividualSalaryView.GetInstance((MainInvidiualView)mainIndividual);
            new IndividualSalaryPresenter(individualSalaryView, salaryRepository, userModel);
        }

        private void ShowThumbTicketView(object sender, EventArgs e)
        {
            thumbTicketView = ThumbTicketView.GetInstance((MainInvidiualView)mainIndividual);
            new ThumbTicketPresenter(thumbTicketView, thumbTicketRepository, userModel);
        }

        // Main View Showing
        private void ShowHomeView(object sender, EventArgs e)
        {
            homeView = Home.GetInstance((MainView)mainView);
            new HomePresenter(homeView, calendarRepository, userModel);

            mainView.Show();
            mainIndividual.Hide();
        }

        private void ShowUserView(object sender, EventArgs e)
        {
            userView = UserView.GetInstance((MainView)mainView);
            new UserPresenter(userView, userRepository, userModel);

            mainView.Show();
            mainIndividual.Hide();
        }

        private void ShowSalaryView(object sender, EventArgs e)
        {
            salaryView = SalaryView.GetInstance((MainView)mainView);
            new SalaryPresenter(salaryView, salaryRepository, userModel);

            mainView.Show();
            mainIndividual.Hide();
        }

        private void ShowRecruitView(object sender, EventArgs e)
        {
            recruitView = RecruitView.GetInstance((MainView)mainView);
            new RecruitmentPresenter(recruitView, recruitmentRepository, userModel);

            mainView.Show();
            mainIndividual.Hide();
        }

        private void ShowTimeKeepingView(object sender, EventArgs e)
        {
            timeKeepingView = TimeKeepingView.GetInstance((MainView)mainView);
            new TimeKeepingPresenter(timeKeepingView, calendarRepository, userModel);

            mainView.Show();
            mainIndividual.Hide();
        }
        private void ShowDepartmentView(object sender, EventArgs e)
        {
            departmentView = DepartmentView.GetInstance((MainView)mainView);
            new DepartmentPresenter(departmentView, departmentRepository, userModel);

            mainView.Show();
            mainIndividual.Hide();
        }

        private void ShowRequestView(object sender, EventArgs e)
        {
            requestView = RequestView.GetInstance((MainView)mainView);
            new RequestPresenter(requestView, requestRepository, userModel);

            mainView.Show();
            mainIndividual.Hide();
        }

        private void ShowSupportView(object sender, EventArgs e)
        {
            supportView = Support.GetInstance((MainView)mainView);
            new SupportPresenter(supportView, supportRepository);

            mainView.Show();
            mainIndividual.Hide();
        }
    }
}