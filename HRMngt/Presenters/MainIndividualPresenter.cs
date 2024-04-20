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

namespace HRMngt.Presenters
{
    public class MainIndividualPresenter
    {
        private IMainIndividualView mainIndividual;
        private UserModel userModel;

        public MainIndividualPresenter(IMainIndividualView mainIndividual, UserModel userModel)
        {
            this.mainIndividual = mainIndividual;
            this.userModel = userModel;
            this.mainIndividual.ShowThumbTicketView += ShowThumbTicketView;
            this.mainIndividual.ShowIndividualSalaryView += ShowIndividualSalaryView;
            this.mainIndividual.ShowIndividualCalendarView += ShowIndividualCalendarView;
            this.mainIndividual.ShowTimeKeepingView += ShowTimeKeepingView;

            mainIndividual.Show();
        }

        private void ShowTimeKeepingView(object sender, EventArgs e)
        {
            ITimeKeepingView view = new TimeKeepingView();
            ICalendarRepository repository = new CalendarRepository();

            new TimeKeepingPresenter(view, repository, userModel);

        }

        private void ShowIndividualCalendarView(object sender, EventArgs e)
        {
            IIndividualCalendarView view = IndividualCalendarView.GetInstance((MainInvidiualView)mainIndividual);
            ICalendarRepository repository = new CalendarRepository();

            new IndividualCalendarPresenter(view, repository, this.userModel);
        }

        private void ShowIndividualSalaryView(object sender, EventArgs e)
        {
            IIndividualSalaryView view = IndividualSalaryView.GetInstance((MainInvidiualView)mainIndividual);
            ISalaryRepository repository = new SalaryRepository();

            new IndividualSalaryPresenter(view, repository, this.userModel);
        }

        private void ShowThumbTicketView(object sender, EventArgs e)
        {
            IThumbTicketView view = ThumbTicketView.GetInstance((MainInvidiualView)mainIndividual);
            IThumbTicketRepository repository = new ThumbTicketRepository();

            new ThumbTicketPresenter(view, repository, this.userModel);
        }

    }
}
