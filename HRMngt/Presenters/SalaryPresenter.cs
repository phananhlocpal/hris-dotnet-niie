using HRMngt._Repository;
using HRMngt._Repository.Calendar;
using HRMngt._Repository.Salary;
using HRMngt.Models;
using HRMngt.popup;
using HRMngt.Views.Dialogs;
using HRMngt.Views;
using HRMngt.Views.Salary;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace HRMngt.Presenters
{
    public class SalaryPresenter
    {
        private ISalaryView view;
        private ISalaryRepository repository;
        private UserModel userModel;
        private IEnumerable<SalaryModel> salaryList;
        private SaveFileDialog saveExcel = new SaveFileDialog();
        private IEnumerable<SalaryModel> salaryFilterList;
        private IIndividualSalaryDialog salaryDialog;
        private SalaryModel editSalaryModel;

        public SalaryPresenter(ISalaryView view, ISalaryRepository repository, UserModel userModel)
        {
            this.view = view;
            this.repository = repository;
            this.userModel = userModel;

            LoadAllSalaryList();

            // Đổ dữ liệu vào cmbDepartment
            IDepartmentRepository departmentRepository = new DepartmentRepository();
            IEnumerable<DepartmentModel> departmentList = departmentRepository.GetAll();
            this.view.LoadDepartmentCmb(departmentList);
            this.view.cmbDepartment.SelectedIndex = 0;
            this.view.cmbStatus.SelectedIndex = 0;

            this.view.FilterEvent += Filter;
            this.view.ExportSalaryEvent += ExportSalary;
            this.view.ApproveAllEvent += ApproveAll;
            this.view.ExportExcelEvent += ExportExcel;
            this.view.LoadSalaryDialogToEditEvent += LoadSalaryDialogToEdit;
            this.view.DeleteEvent += Delete;

            Filter();
            this.view.Show();

            saveExcel.Filter = "Excel Files|*.xlsx;*.xls";
            saveExcel.Title = "Save an Excel File";
        }


        private void Filter(object sender, EventArgs e)
        {
            salaryFilterList = salaryList;
            string departmentId = "All";
            string status = "All";
            int month = view.dtpChooseMonth.Value.Month;
            int year = view.dtpChooseMonth.Value.Year;
            if (this.view.cmbDepartment.SelectedItem != null && this.view.cmbDepartment.SelectedItem.ToString() != "All")
            {
                string selectedItem = this.view.cmbDepartment.SelectedItem.ToString();
                departmentId = selectedItem.Split(new string[] { " - " }, StringSplitOptions.None)[0];
            } 
            if (this.view.cmbStatus.SelectedItem != null) status = this.view.cmbStatus.SelectedItem.ToString();
            salaryFilterList = repository.LINQ_Filter(salaryList, departmentId, status, month, year);
            this.view.ShowSalaryList(salaryFilterList);
        }

        private void Delete(object sender, EventArgs e)
        {
            // Get month and year
            DateTime selectedDate = view.dtpChooseMonth.Value;
            int month = selectedDate.Month;
            int year = selectedDate.Year;

            // Get id from row
            string userId = view.dgvSalaryTable.CurrentRow.Cells[0].Value.ToString();

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa bảng lương này không?", "Xác nhận xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                try
                {
                    repository.Delete(userId, month, year);

                    MessageBox.Show("Bảng lương đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SucessPopUp.ShowPopUp();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi xóa bảng lương: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadSalaryDialogToEdit(object sender, EventArgs e)
        {
            // Get month and year
            DateTime selectedDate = view.dtpChooseMonth.Value;
            int month = selectedDate.Month;
            int year = selectedDate.Year;

            // Get id from row
            string userId = view.dgvSalaryTable.CurrentRow.Cells[0].Value.ToString();

            // Show dialog
            editSalaryModel = repository.LINQ_GetModelByPK(salaryList, userId, month, year);
            salaryDialog = new IndividualSalaryDialog(userModel.Roles);

            IUserRepository userRepository = new UserRepository();
            IEnumerable<UserModel> userList = userRepository.GetAll();
            UserModel userTemp = userRepository.LINQ_GetModelById(userList, userId);
            salaryDialog.ShowSalaryInfo(editSalaryModel, userTemp);

            // Event Handler
            salaryDialog.ResponseEvent += Dialog_ResponseEvent;
            salaryDialog.UpdateEvent += Dialog_UpdateEvent;
            salaryDialog.ApproveEvent += Dialog_ApproveEvent;

            salaryDialog.rtbRes.Text = editSalaryModel.Res;

            salaryDialog.ShowDialog();
        }

        private void Dialog_ApproveEvent(object sender, EventArgs e)
        {
            editSalaryModel.Status = "Approved";
            repository.Update(editSalaryModel);
            salaryList = repository.GetAll();
            Filter();

            salaryDialog.Close();
        }

        private void Dialog_UpdateEvent(object sender, EventArgs e)
        {
            editSalaryModel.Welfare = int.Parse(salaryDialog.txtWelfare.Text.ToString());
            repository.Update(editSalaryModel);
            salaryList = repository.GetAll();
            Filter();

            SucessPopUp.ShowPopUp();
        }

        private void Dialog_ResponseEvent(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Mời bạn nhập phản hồi:", "Nhập phản hồi", "") + " - " + DateTime.Now.ToString() + " " + userModel.Id + " " + userModel.Name;

            if (!string.IsNullOrEmpty(input))
            {
                editSalaryModel.Res += "\n" + input;
                repository.Update(editSalaryModel);
                salaryList = repository.GetAll();
                salaryDialog.rtbRes.Text = editSalaryModel.Res;
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập dữ liệu!");
            }
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
                    excel = new Microsoft.Office.Interop.Excel.Application();
                    excel.Visible = false;
                    excel.DisplayAlerts = false;
                    workbook = excel.Workbooks.Add(Type.Missing);

                    // Work sheet bảng lương
                    salaryWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                    salaryWorksheet.Name = "Bảng lương";
                    ISalaryRepository salaryRepository = new SalaryRepository();
                    IEnumerable<SalaryModel> salaryList = salaryRepository.GetAll();
                    salaryList = salaryRepository.LINQ_GetListByMonthNYear(salaryList, view.dtpChooseMonth.Value.Month, view.dtpChooseMonth.Value.Year);

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
                    foreach (var salary in salaryList)
                    {
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

                        i++;
                    }

                    // Work sheet bảng lương
                    // Tạo một Sheet mới cho bảng công
                    calendarWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets.Add(Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                    calendarWorksheet.Name = "Bảng công";

                    ICalendarRepository calendarRepository = new CalendarRepository();
                    IEnumerable<CalendarModel> calendarList = calendarRepository.GetAll();
                    calendarList = calendarRepository.LINQ_GetListByMonthNYear(calendarList, view.dtpChooseMonth.Value.Month, view.dtpChooseMonth.Value.Year);

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
                        calendarWorksheet.Cells[i + 2, 5] = (calendar.CheckIn != null) ? string.Format("{0:hh\\:mm\\:ss}", calendar.CheckIn) : "";
                        calendarWorksheet.Cells[i + 2, 6] = (calendar.CheckOut != null) ? string.Format("{0:hh\\:mm\\:ss}", calendar.CheckOut) : "";
                        calendarWorksheet.Cells[i + 2, 5] = (calendar.RealCheckIn != null) ? string.Format("{0:hh\\:mm\\:ss}", calendar.RealCheckIn) : "";
                        calendarWorksheet.Cells[i + 2, 6] = (calendar.RealCheckOut != null) ? string.Format("{0:hh\\:mm\\:ss}", calendar.RealCheckOut) : "";
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
                }
                finally
                {
                    workbook = null;
                    salaryWorksheet = null;
                    calendarWorksheet = null;
                }
            }
        }

        private void ApproveAll(object sender, EventArgs e)
        {
            try
            {
                if (salaryFilterList != null && salaryFilterList.Any())
                {
                    foreach (var model in salaryFilterList)
                    {
                        model.Status = "Approved";
                        repository.Update(model);
                    }
                    salaryList = repository.GetAll();
                    this.view.ShowSalaryList(salaryFilterList);

                    SucessPopUp.ShowPopUp();
                }
                else
                {
                    MessageBox.Show("Không có bảng lương nào cần duyệt!");
                    FailPopUp.ShowPopUp();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex}");
                FailPopUp.ShowPopUp();
            } 
        }

        private void ExportSalary(object sender, EventArgs e)
        {
            int month = view.dtpChooseMonth.Value.Month;
            int year = view.dtpChooseMonth.Value.Year;
            IUserRepository userRepository = new UserRepository();
            IEnumerable<UserModel> userList = userRepository.GetAll();

            foreach (var user in userList)
            {
                SalaryModel salaryModel = new SalaryModel();
                // Get Total of thumb and ticket
                IThumbTicketRepository thumbTicketRepository = new ThumbTicketRepository();
                int thumb_total = thumbTicketRepository.GetThumbTotalByMonthNYear(user.Id, month, year);
                int ticket_total = thumbTicketRepository.GetTicketTotalByMonthNYear(user.Id, month, year);

                // Get total of working date 
                ICalendarRepository calendarRepository = new CalendarRepository();
                int real_workday = calendarRepository.GetRealWorkdayByMonthNYear(user.Id, month, year);

                // Calculate tax. If tax > 2 million, minus 10% 
                double total = (real_workday / 22) * user.Salary + thumb_total - ticket_total;
                double tax = 0;
                if (total >= 2000000) tax = 0.1 *total;

                // Calculate total Salary
                double totalSalary = total - tax;

                // insert information salary
                salaryModel.UserId = user.Id;
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
                if (repository.LINQ_CheckExistSalary(salaryList, user.Id, month, year))
                {
                    repository.Delete(user.Id,month,year);
                }    
                repository.Add(salaryModel);
            }
            LoadAllSalaryList();
            this.view.ShowSalaryList(salaryList);
            SucessPopUp.ShowPopUp();
        }

        private void LoadAllSalaryList()
        {
            salaryList = repository.GetAll();
        }

        private void Filter()
        {
            salaryFilterList = salaryList;
            string departmentId = "All";
            string status = "All";
            int month = view.dtpChooseMonth.Value.Month;
            int year = view.dtpChooseMonth.Value.Year;
            if (this.view.cmbDepartment.SelectedItem != null && this.view.cmbDepartment.SelectedItem.ToString() != "All")
            {
                string selectedItem = this.view.cmbDepartment.SelectedItem.ToString();
                departmentId = selectedItem.Split(new string[] { " - " }, StringSplitOptions.None)[0];
            }
            if (this.view.cmbStatus.SelectedItem != null) status = this.view.cmbStatus.SelectedItem.ToString();
            salaryFilterList = repository.LINQ_Filter(salaryList, departmentId, status, month, year);
            this.view.ShowSalaryList(salaryFilterList);
        }
    }

}
