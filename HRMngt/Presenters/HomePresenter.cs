using HRMngt._Repository;
using HRMngt._Repository.Calendar;
using HRMngt.Models;
using HRMngt.popup;
using HRMngt.Views;
using HRMngt.Views.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMngt.Presenters
{
    public class HomePresenter
    {
        private IHomeView view;
        private ICalendarRepository repository;
        private CheckinDialog checkinDialog;
        
        private UserModel user;

        public HomePresenter(IHomeView view, ICalendarRepository repository, UserModel user)
        {
            this.user = user;
            this.view = view;
            this.repository = repository;

            this.view.LoadToAddCalandar += LoadToAddCalandar;
            this.view.ShowNavName(user.Name);
            this.view.Show();
        }

        private void LoadToAddCalandar(object sender, EventArgs e)
        {
            checkinDialog = this.view.ShowCheckInDialog();
            checkinDialog.label1 = $"Attendance at {DateTime.Now.DayOfWeek} {DateTime.Now.ToString("MMMM", System.Globalization.CultureInfo.GetCultureInfo("en-US"))} {DateTime.Now.Day} {DateTime.Now.Year}";
            checkinDialog.label2 = $"{DateTime.Now.ToString("HH:mm:ss")}";
            checkinDialog.label3 = $"Good bye {user.Name}";
            checkinDialog.AddToCalculator += AddToCalculator;
            checkinDialog.Show();
        }

        private void AddToCalculator(object sender, EventArgs e)
        {
            CalendarModel calendar = new CalendarModel();
            calendar.UserId = user.Id;
            calendar.Date = DateTime.Now;
            calendar.CheckIn = DateTime.Now.TimeOfDay;
            calendar.RealCheckIn = DateTime.Now.TimeOfDay;
            repository.Add(calendar);
            this.checkinDialog.Close();
            SucessPopUp.ShowPopUp();

        }
    }
}
