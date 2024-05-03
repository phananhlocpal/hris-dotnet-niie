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
using System.Windows.Forms;

namespace HRMngt.Presenters
{
    public class HomePresenter
    {
        private IHomeView view;
        private ICalendarRepository calendarRepository;
        private UserModel userModel;
        private AttendanceDialog dialog;

        public HomePresenter(IHomeView view, ICalendarRepository repository, UserModel user)
        {
            this.userModel = user;
            this.view = view;
            this.calendarRepository = repository;

            this.view.LoadToAddCalandar += LoadToAddCalandar;
            this.view.ShowNavName(user.Name);
            this.view.Show();
        }

        private void LoadToAddCalandar(object sender, EventArgs e)
        {
            dialog = this.view.ShowAttendanceDialog();
            dialog.label1 = $"Attendance at {DateTime.Now.DayOfWeek} {DateTime.Now.ToString("MMMM", System.Globalization.CultureInfo.GetCultureInfo("en-US"))} {DateTime.Now.Day} {DateTime.Now.Year}";
            dialog.label2 = $"{DateTime.Now.ToString("HH:mm:ss")}";
            dialog.label3 = $"Good bye {userModel.Name}";
            dialog.CheckinEvent += CheckIn;
            dialog.CheckoutEvent += CheckOut;
            dialog.Show();
        }

        private void CheckOut(object sender, EventArgs e)
        {
            ICalendarRepository calendarRepository = new CalendarRepository();
            IEnumerable<CalendarModel> calendarList = calendarRepository.GetAll();
            calendarList = calendarRepository.LINQ_GetListByUserID(calendarList, userModel.Id);
            DateTime today = DateTime.Today;

            if (calendarRepository.LINQ_checkExistDate(calendarList, today))
            {
                CalendarModel calendar = calendarRepository.LINQ_GetModelByUserIdNDate(calendarList, userModel.Id, today);
                calendar.RealCheckOut = DateTime.Now.TimeOfDay;
                calendarRepository.Update(calendar);

                this.dialog.Close();
                SucessPopUp.ShowPopUp();
            }
            else
            {
                MessageBox.Show("Hôm nay bạn chưa đăng ký lịch làm!");
                FailPopUp.ShowPopUp();
            }
        }

        private void CheckIn(object sender, EventArgs e)
        {
            ICalendarRepository calendarRepository = new CalendarRepository();
            IEnumerable<CalendarModel> calendarList = calendarRepository.GetAll();
            calendarList = calendarRepository.LINQ_GetListByUserID(calendarList, userModel.Id);
            DateTime today = DateTime.Today;

            if (calendarRepository.LINQ_checkExistDate(calendarList,today))
            {
                CalendarModel calendar = calendarRepository.LINQ_GetModelByUserIdNDate(calendarList, userModel.Id, today);
                calendar.RealCheckIn = DateTime.Now.TimeOfDay;
                calendarRepository.Update(calendar);

                this.dialog.Close();
                SucessPopUp.ShowPopUp();
            }
            else
            {
                MessageBox.Show("Hôm nay bạn chưa đăng ký lịch làm!");
                FailPopUp.ShowPopUp();
            }
        }
    }
}
