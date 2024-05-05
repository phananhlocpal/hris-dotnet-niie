using HRMngt._Repository.Calendar;
using HRMngt._Repository.Salary;
using HRMngt.Models;
using HRMngt.popup;
using HRMngt.Views.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMngt.Presenters
{
    public class IndividualSalaryPresenter
    {
        private UserModel userModel;
        private IIndividualSalaryView salaryView;
        private ISalaryRepository salaryRepository;
        private IIndividualSalaryDialog salaryDialog;
        private IEnumerable<CalendarModel> calendarList;
        private IEnumerable<SalaryModel> salaryList;
        private SalaryModel viewSalaryModel;

        public IndividualSalaryPresenter(IIndividualSalaryView salaryView, ISalaryRepository salaryRepository, UserModel userModel)
        {
            this.salaryView = salaryView;
            this.salaryRepository = salaryRepository;
            this.userModel = userModel;
            ICalendarRepository calendarRepository = new CalendarRepository();
            this.calendarList = calendarRepository.GetAll();
            this.salaryList = salaryRepository.GetAll();

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
            viewSalaryModel = salaryRepository.LINQ_GetModelByPK(salaryList, userModel.Id, month, year);
            salaryDialog = new IndividualSalaryDialog("user");
            salaryDialog.ShowSalaryInfo(viewSalaryModel, this.userModel);

            // Event Handler
            salaryDialog.ConfirmEvent += Dialog_ConfirmEvent;
            salaryDialog.ResponseEvent += Dialog_ComplainEvent;
        }

        private void Dialog_ComplainEvent(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Mời bạn nhập phản hồi:", "Nhập phản hồi", "") + " - " + DateTime.Now.ToString() + " " + userModel.Id + " " + userModel.Name;

            if (!string.IsNullOrEmpty(input))
            {
                viewSalaryModel.Res += "\n" + input;
                salaryRepository.Update(viewSalaryModel);
                salaryList = salaryRepository.GetAll();
                salaryDialog.rtbRes.Text = viewSalaryModel.Res;
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập dữ liệu!");
            }
        }

        private void Dialog_ConfirmEvent(object sender, EventArgs e)
        {
            viewSalaryModel.Status = "Confirmed";
            salaryRepository.Update(viewSalaryModel);
            salaryList = salaryRepository.GetAll();

            SucessPopUp.ShowPopUp();
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
