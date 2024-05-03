using HRMngt._Repository.Calendar;
using HRMngt._Repository.Salary;
using HRMngt.Models;
using HRMngt.popup;
using HRMngt.Views.Dialogs;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
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
        private SalaryModel salaryModel;
        private SaveFileDialog saveExcel = new SaveFileDialog();

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
            this.salaryView.ExportExcelEvent += ExportExcel;

            saveExcel.Filter = "Excel Files|*.xlsx;*.xls";
            saveExcel.Title = "Save an Excel File";

            // Show Salary List
            ShowSalaryList();

            // Show view
            this.salaryView.Show();
        }

        private void ExportExcel(object sender, EventArgs e)
        {
            if (saveExcel.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application excel;
                Microsoft.Office.Interop.Excel.Workbook workbook;
                Microsoft.Office.Interop.Excel.Worksheet salaryWorksheet;
                Microsoft.Office.Interop.Excel.Worksheet calendarWorksheet;
                try
                {
                    int month = salaryView.dtpChooseMonth.Value.Month;
                    int year = salaryView.dtpChooseMonth.Value.Year;
                    excel = new Microsoft.Office.Interop.Excel.Application();
                    excel.Visible = false;
                    excel.DisplayAlerts = false;
                    workbook = excel.Workbooks.Add(Type.Missing);

                    // Work sheet bảng lương
                    salaryWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                    salaryWorksheet.Name = "Bảng lương";
                    ISalaryRepository salaryRepository = new SalaryRepository();
                    IEnumerable<SalaryModel> salaryList = salaryRepository.GetAll();
                    SalaryModel salary = salaryRepository.LINQ_GetModelByPK(salaryList, userModel.Id, month, year);

                    // Header
                    // Thêm header cho bảng lương
                    salaryWorksheet.Cells[1, 1] = "UserID";
                    salaryWorksheet.Cells[1, 2] = "UserName";
                    salaryWorksheet.Cells[1, 3] = "ContractType";
                    salaryWorksheet.Cells[1, 4] = "Position";
                    salaryWorksheet.Cells[1, 5] = "Month";
                    salaryWorksheet.Cells[1, 6] = "Year";
                    salaryWorksheet.Cells[1, 7] = "Workday";
                    salaryWorksheet.Cells[1, 8] = "RealWorkday";
                    salaryWorksheet.Cells[1, 9] = "Welfare";
                    salaryWorksheet.Cells[1, 10] = "ThumbTotal";
                    salaryWorksheet.Cells[1, 11] = "TicketTotal";
                    salaryWorksheet.Cells[1, 12] = "Tax";
                    salaryWorksheet.Cells[1, 13] = "TotalSalary";
                    salaryWorksheet.Cells[1, 14] = "Status";

                    // Contents
                    int i = 0;
                    salaryWorksheet.Cells[i + 2, 1] = salary.UserId;
                    salaryWorksheet.Cells[i + 2, 2] = salary.UserName;
                    salaryWorksheet.Cells[i + 2, 3] = salary.Contract_type;
                    salaryWorksheet.Cells[i + 2, 4] = salary.Position;
                    salaryWorksheet.Cells[i + 2, 5] = salary.Month;
                    salaryWorksheet.Cells[i + 2, 6] = salary.Year;
                    salaryWorksheet.Cells[i + 2, 7] = salary.Workday;
                    salaryWorksheet.Cells[i + 2, 8] = salary.RealWorkday;
                    salaryWorksheet.Cells[i + 2, 9] = salary.Welfare;
                    salaryWorksheet.Cells[i + 2, 10] = salary.ThumbTotal;
                    salaryWorksheet.Cells[i + 2, 11] = salary.TicketTotal;
                    salaryWorksheet.Cells[i + 2, 12] = salary.Tax;
                    salaryWorksheet.Cells[i + 2, 13] = salary.TotalSalary;
                    salaryWorksheet.Cells[i + 2, 14] = salary.Status;

                    // Work sheet bảng lương
                    // Tạo một Sheet mới cho bảng công
                    calendarWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets.Add(Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                    calendarWorksheet.Name = "Bảng công";

                    ICalendarRepository calendarRepository = new CalendarRepository();
                    IEnumerable<CalendarModel> calendarList = calendarRepository.GetAll();

                    DateTime start = new DateTime(year, month, 1);
                    DateTime end = new DateTime(year, month, 1).AddMonths(1).AddDays(-1);
                    calendarList = calendarRepository.LINQ_GetListByUserIDNPeriod(calendarList, userModel.Id, start, end);

                    // Header
                    calendarWorksheet.Cells[1, 1] = "UserID";
                    calendarWorksheet.Cells[1, 2] = "UserName";
                    calendarWorksheet.Cells[1, 3] = "UserDepartment";
                    calendarWorksheet.Cells[1, 4] = "Date";
                    calendarWorksheet.Cells[1, 5] = "CheckIn";
                    calendarWorksheet.Cells[1, 6] = "CheckOut";
                    calendarWorksheet.Cells[1, 7] = "RealCheckIn";
                    calendarWorksheet.Cells[1, 8] = "RealCheckOut";
                    calendarWorksheet.Cells[1, 9] = "Status";

                    // Content
                    i = 0;
                    foreach (var calendar in calendarList)
                    {
                        calendarWorksheet.Cells[i + 2, 1] = calendar.UserId;
                        calendarWorksheet.Cells[i + 2, 2] = calendar.UserName;
                        calendarWorksheet.Cells[i + 2, 3] = calendar.UserDepartment;
                        calendarWorksheet.Cells[i + 2, 4] = calendar.Date.ToString("yyyy/MM/dd");
                        TimeSpan DTTimeIn = calendar.CheckIn;
                        string StrTimeIn = DTTimeIn.ToString();
                        TimeSpan DTTimeOut = calendar.CheckOut;
                        string StrTimeOut = DTTimeOut.ToString();
                        calendarWorksheet.Cells[i + 2, 5] = StrTimeIn;
                        calendarWorksheet.Cells[i + 2, 6] = StrTimeOut;
                        calendarWorksheet.Cells[i + 2, 7] = (calendar.RealCheckIn != null) ? string.Format("{0:hh\\:mm\\:ss}", calendar.RealCheckIn) : "";
                        calendarWorksheet.Cells[i + 2, 8] = (calendar.RealCheckOut != null) ? string.Format("{0:hh\\:mm\\:ss}", calendar.RealCheckOut) : "";
                        calendarWorksheet.Cells[i + 2, 9] = calendar.Status;

                        i++;
                    }

                    workbook.SaveAs(saveExcel.FileName);
                    workbook.Close();
                    excel.Quit();
                    MessageBox.Show("Xuất dữ liệu ra Excel thành công!");
                    SucessPopUp.ShowPopUp();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xuất dữ liệu ra Excel: " + ex.Message);
                    FailPopUp.ShowPopUp();
                }
                finally
                {
                    workbook = null;
                    salaryWorksheet = null;
                    calendarWorksheet = null;
                }
            }
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
            salaryDialog = new IndividualSalaryDialog();

            // Get month and year
            DateTime selectedDate = salaryView.dtpChooseMonth.Value;
            int month = selectedDate.Month;
            int year = selectedDate.Year;

            // Show dialog
            salaryModel = salaryRepository.LINQ_GetModelByPK(salaryList, userModel.Id, month, year);

            if (salaryModel == null || salaryModel.Status == "Created")
            {
                MessageBox.Show("Bảng lương chưa được xuất. Bạn vui lòng quay lại sau!");
                FailPopUp.ShowPopUp();
            }    
            else
            {
                salaryDialog.ShowSalaryInfo(salaryModel, this.userModel);
                // Event Handler
                salaryDialog.ConfirmEvent += Dialog_ConfirmEvent;
                salaryDialog.ResponseEvent += Dialog_ResponseEvent;
                salaryDialog.ShowDialog();
            }
        }

        private void Dialog_ResponseEvent(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại để nhập thông tin
            string complainText = Interaction.InputBox("Nhập nội dung khiếu nại", "Khiếu nại", "");

            if (!string.IsNullOrEmpty(complainText))
            {
                salaryModel.Complain = complainText;
                salaryModel.Status = "Complained";
                salaryRepository.Update(salaryModel);
                SucessPopUp.ShowPopUp();
            }
        }

        private void Dialog_ConfirmEvent(object sender, EventArgs e)
        {
            salaryModel.Status = "Confirmed";
            salaryRepository.Update(salaryModel);
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
