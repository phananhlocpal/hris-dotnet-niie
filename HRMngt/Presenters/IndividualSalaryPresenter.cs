using HRMngt._Repository.Calendar;
using HRMngt._Repository.Salary;
using HRMngt.Models;
using HRMngt.Views.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMngt.Presenters
{
    public class IndividualSalaryPresenter
    {
        private UserModel userModel;
        private IIndividualSalaryView salaryView;
        private ISalaryRepository salaryRepository;
        private IIndividualSalaryDialog salaryDialog;
        private IEnumerable<CalendarModel> calendarList;

        public IndividualSalaryPresenter(IIndividualSalaryView salaryView, ISalaryRepository salaryRepository, UserModel userModel)
        {
            this.salaryView = salaryView;
            this.salaryRepository = salaryRepository;
            this.userModel = userModel;
            ICalendarRepository calendarRepository = new CalendarRepository();
            this.calendarList = calendarRepository.GetAll();

            // Event handler Processing
            this.salaryView.LoadSalaryDialogToViewEvent += LoadSalaryDialogToView;
            this.salaryView.SearchByMonthEvent += SearchByMonthEvent;
            this.salaryView.ViewResumeEvent += LoadSalaryDialogToView;

            // Show view
            this.salaryView.Show();
            // Show Salary List
            ShowSalaryList();

        }

        private void SearchByMonthEvent(object sender, EventArgs e)
        {
            // Get month and year
            DateTime selectedDate = salaryView.dtpChooseMonth.Value;
            int month = selectedDate.Month;
            int year = selectedDate.Year;
            // get calendar with month, year and id
            ICalendarRepository calendarRepository = new CalendarRepository();
            IEnumerable<CalendarModel> calendarList = LINQ_GetListByUserIDNMonth(month, year);
            this.salaryView.ShowSalaryList(calendarList);
        }

        private void ShowSalaryList()
        {
            // Get month and year
            DateTime selectedDate = salaryView.dtpChooseMonth.Value;
            int month = selectedDate.Month;
            int year = selectedDate.Year;
            // get calendar with month, year and id
            ICalendarRepository calendarRepository = new CalendarRepository();
            IEnumerable<CalendarModel> calendarList = LINQ_GetListByUserIDNMonth(month, year).ToList();
            this.salaryView.ShowSalaryList(calendarList);
        }

        private void LoadSalaryDialogToView(object sender, EventArgs e)
        {
            // Get month and year
            DateTime selectedDate = salaryView.dtpChooseMonth.Value;
            int month = selectedDate.Month;
            int year = selectedDate.Year;

            // Show dialog
            SalaryModel salaryModel = salaryRepository.GetByKey(userModel.Id, month, year);
            salaryDialog = new IndividualSalaryDialog();
            salaryDialog.ShowSalaryInfo(salaryModel, this.userModel);

            // Event Handler
            salaryDialog.ConfirmEvent += Dialog_ConfirmEvent;
            salaryDialog.ResponseEvent += Dialog_ResponseEvent;
        }

        private void Dialog_ResponseEvent(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Dialog_ConfirmEvent(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        // LINQ 
        // ==============================================================
        private IEnumerable<CalendarModel> LINQ_GetListByUserIDNMonth(int month, int year)
        {
            var query = calendarList
                .Where(calendarModel => calendarModel.UserId == userModel.Id && calendarModel.Date.Month == month && calendarModel.Date.Year == year)
                .ToList();
            return query;
        }
    }
}
