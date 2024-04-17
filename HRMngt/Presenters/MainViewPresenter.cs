using HRMngt._Repository;
using HRMngt._Repository.Home;
using HRMngt._Repository.HR;
using HRMngt._Repository.IndividualSalary;
using HRMngt._Repository.Salary;
using HRMngt._Repository.Support;
using HRMngt._Repository.TimeKeeping;
using HRMngt.Model;
using HRMngt.Presenter;
using HRMngt.View;
using HRMngt.Views;
using HRMngt.Views.Dialogs;
using HRMngt.Views.HR;
using HRMngt.Views.Salary;
using HRMngt.Views.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

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
            mainView.Show();
        }

        private void ShowMainIndividualView(object sender, EventArgs e)
        {
            IMainIndividualView view = new MainInvidiualView(userModel);
            new MainIndividualPresenter(view, userModel);
            
        }

        private void ShowTimeKeepingView(object sender, EventArgs e)
        {
            ITimeKeepingView view = TimeKeepingView.GetInstance((MainView)mainView);
            ITimeKeepingRepository repository = new TimeKeepingRepository();

            new TimeKeepingPresenter(view, repository);

        }
        private void ShowRecuitView(object sender, EventArgs e)
        {
            IRecruitView view = RecruitView.GetInstance((MainView)mainView);
            IRecruitRepository repository = new RecruitRepository();
            new RecruitPresenter(view, repository);
        }

        private void ShowLoginView(object sender, EventArgs e)
        {
            ILoginView view = new Views.LoginView();
            ILoginRepository repository = new LoginRepository();
            new LoginPresenter(view, repository);
        }

        private void ShowSalaryView(object sender, EventArgs e)
        {
            ISalaryView view = SalaryView.GetInstance((MainView)mainView);
            ISalaryRepository repository = new SalaryRepository();

            new SalaryPresenter(view, repository);
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
            IHomeRepository repository = new HomeRepository();
            new HomePresenter(view, repository);
        }

        private void ShowUserView(object sender, EventArgs e)
        {
            IUserView view = UserView.GetInstance((MainView)mainView);
            UserModel userModel = new UserModel();
            IUserRepository repository = new UserRepository();
            new UserPresenter(view, repository, userModel);
        }

        private void ShowDepartmentView(object sender, EventArgs e)
        {
            IDepartmentView view = DepartmentView.GetInstance((MainView) mainView);

            IDepartmentRepository repository = new DepartmentRepository();
            new DepartmentPresenter(view, repository);
        }
        private void ShowThumbTicketView(object sender, EventArgs e)
        {
            IThumbTicketView view = ThumbTicketView.GetInstance((MainView) mainView);

            IThumbTicketRepository repository = new ThumbTicketRepository();
            new ThumbTicketPresenter(view, repository, userModel);
        }
        
    }
}
