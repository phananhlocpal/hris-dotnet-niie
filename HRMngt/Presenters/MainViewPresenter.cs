﻿using HRMngt._Repository;
using HRMngt._Repository.Calendar;
using HRMngt._Repository.Communicate;
<<<<<<< HEAD
using HRMngt._Repository.Request;
=======
using HRMngt._Repository.Recruitment;
>>>>>>> hieu-new
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
<<<<<<< HEAD
using System.Web.UI.WebControls;
using System.Windows.Forms;
=======
>>>>>>> hieu-new

namespace HRMngt.Presenters
{
    public class MainViewPresenter
    {
        IMainView mainView;
        private UserModel userModel;

        public MainViewPresenter(IMainView main, UserModel userModel)
        {
            this.mainView = main;
            this.userModel = userModel;
            this.mainView.ShowDepartmentView += ShowDepartmentView;
            mainView.ShowThumbTicketView += ShowThumbTicketView;
            mainView.ShowUserView += ShowUserView;
            mainView.ShowHomeView += ShowHomeView;
            mainView.ShowSupportView += ShowSupportView;
            mainView.ShowSalaryView += ShowSalaryView;
            mainView.ShowLoginEvent += ShowLoginView;
            mainView.ShowRecuitView += ShowRecuitView;
            mainView.ShowTimeKeepingView += ShowTimeKeepingView;
            mainView.ShowMainIndividualView += ShowMainIndividualView;
            mainView.ShowCommunicateView += ShowCommunicateView;
            mainView.ShowRequestView += ShowRequestView;
            mainView.ShowUserInformation(userModel);
            mainView.Show();
        }
<<<<<<< HEAD

        private void ShowRequestView(object sender, EventArgs e)
        {
            
            IRequestView requestView = RequestView.GetInstance((MainView)mainView);
            IRequestRepository requestRepository = new RequestRepository();

            new RequestPresenter(requestView, requestRepository, userModel);
        }

=======
        
>>>>>>> hieu-new
        private void ShowCommunicateView(object sender, EventArgs e)
        {
            IClientView view = ClientView.GetInstance((MainView)mainView);
            ICommunicateRepository repository = new CommunicateRepository();

            new CommunicatePresenter(view, repository);
        }

        private void ShowMainIndividualView(object sender, EventArgs e)
        {
            IMainIndividualView view = new MainInvidiualView(userModel);
            new MainIndividualPresenter(view, userModel);
            mainView.Hide();
            
        }

        private void ShowTimeKeepingView(object sender, EventArgs e)
        {
            ITimeKeepingView view = TimeKeepingView.GetInstance((MainView)mainView);
            ICalendarRepository repository = new CalendarRepository();

            new TimeKeepingPresenter(view, repository, userModel);

        }
        private void ShowRecuitView(object sender, EventArgs e)
        {
            IRecruitView view = RecruitView.GetInstance((MainView)mainView);
            IRecruitmentRepository repository = new RecruitmentRepository();
            new RecruitmentPresenter(view, repository, userModel);
        }

        private void ShowLoginView(object sender, EventArgs e)
        {
            ILoginView view = new Views.LoginView();
            IUserRepository repository = new UserRepository();
            new LoginPresenter(view, repository);
        }

        private void ShowSalaryView(object sender, EventArgs e)
        {
            ISalaryView view = SalaryView.GetInstance((MainView)mainView);
            ISalaryRepository repository = new SalaryRepository();

            new SalaryPresenter(view, repository, userModel);
        }

        private void ShowSupportView(object sender, EventArgs e)
        {
            ISupport view = Support.GetInstance((MainView)mainView);
            ISupportRepository repository = new SupportRepository();
            new SupportPresenter(view, repository);
        }

        private void ShowHomeView(object sender, EventArgs e)
        {
            IHomeView view = Home.GetInstance((MainView)mainView);
            ICalendarRepository repository = new CalendarRepository();
            new HomePresenter(view, repository, userModel);
        }

        private void ShowUserView(object sender, EventArgs e)
        {
            IUserView view = UserView.GetInstance((MainView)mainView);
            IUserRepository repository = new UserRepository();
            new UserPresenter(view, repository, userModel);
        }

        private void ShowDepartmentView(object sender, EventArgs e)
        {
            IDepartmentView view = DepartmentView.GetInstance((MainView) mainView);

            IDepartmentRepository repository = new DepartmentRepository();
            new DepartmentPresenter(view, repository, userModel);
        }
        private void ShowThumbTicketView(object sender, EventArgs e)
        {
            IThumbTicketView view = ThumbTicketView.GetInstance((MainView) mainView);

            IThumbTicketRepository repository = new ThumbTicketRepository();
            new ThumbTicketPresenter(view, repository, userModel);
        }
        
    }
}
