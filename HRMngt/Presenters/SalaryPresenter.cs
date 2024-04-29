using HRMngt._Repository;
using HRMngt._Repository.Calendar;
using HRMngt._Repository.Salary;
using HRMngt.Models;
using HRMngt.Views.Salary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMngt.Presenters
{
    public class SalaryPresenter
    {
        private ISalaryView view;
        private ISalaryRepository repository;
        private UserModel userModel;
        private IEnumerable<SalaryModel> salaryList;

        public SalaryPresenter(ISalaryView view, ISalaryRepository repository, UserModel userModel)
        {
            this.view = view;
            this.repository = repository;
            this.userModel = userModel;

            this.view.FilterEvent += Filter;
            this.view.ShowSalaryTableEvent += ShowSalaryTable;
            this.view.ExportSalaryEvent += ExportSalary;
            this.view.ApproveAllEvent += ApproveAll;
            this.view.ExportExcelEvent += ExportExcel;
            this.view.LoadSalaryDialogToEditEvent += LoadSalaryDialogToEdit;
            this.view.DeleteEvent += Delete;



            LoadAllSalaryList();
            this.view.ShowSalaryList(salaryList);
            this.view.Show();
        }

        private void Delete(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadSalaryDialogToEdit(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ExportExcel(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ApproveAll(object sender, EventArgs e)
        {
            DateTime month = view.dtpChooseMonth.Value;

        }

        private void ExportSalary(object sender, EventArgs e)
        {
            int month = view.dtpChooseMonth.Value.Month;
            int year = view.dtpChooseMonth.Value.Year;
            IEnumerable<UserModel> userList = new List<UserModel>();
            IUserRepository userRepository = new UserRepository();
            userList = userRepository.GetAll();

            foreach (var userModel in userList)
            {
                SalaryModel salaryModel = new SalaryModel();
                // Get Total of thumb and ticket
                IThumbTicketRepository thumbTicketRepository = new ThumbTicketRepository();
                int thumb_total = thumbTicketRepository.GetThumbTotalByMonthNYear(userModel.Id, month, year);
                int ticket_total = thumbTicketRepository.GetTicketTotalByMonthNYear(userModel.Id, month, year);

                // Get total of working date 
                // Số 
                ICalendarRepository calendarRepository = new CalendarRepository();
                int real_workday = calendarRepository.GetRealWorkdayByMonthNYear(userModel.Id, month, year);

                // Calculate tax. If tax > 2 million, minus 10% 
                double total = (real_workday / 22 + thumb_total - ticket_total) * userModel.Salary;
                double tax = 0;
                if (total >= 2000000) tax = 0.1 *total;

                // Calculate total Salary
                double totalSalary = total - tax;

                // insert information salary
                salaryModel.UserId = userModel.Id;
                salaryModel.Month = month;
                salaryModel.Year = year;
                salaryModel.Workday = 22;
                salaryModel.RealWorkday = real_workday;
                salaryModel.ThumbTotal = thumb_total;
                salaryModel.TicketTotal = ticket_total;
                salaryModel.Tax = tax;
                salaryModel.TotalSalary = totalSalary;
                salaryModel.Status = "Created";

                // insert Salary
                repository.Add(salaryModel);
            }
            LoadAllSalaryList();
            this.view.ShowSalaryList(salaryList);
        }

        private void ShowSalaryTable(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Filter(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadAllSalaryList()
        {
            salaryList = repository.GetAll();
        }
    }
}
