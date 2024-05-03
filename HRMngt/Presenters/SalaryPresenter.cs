using HRMngt._Repository;
using HRMngt._Repository.Calendar;
using HRMngt._Repository.Salary;
using HRMngt.Models;
using HRMngt.popup;
using HRMngt.Views.Dialogs.Forms;
using HRMngt.Views.Dialogs.Interfaces;
using HRMngt.Views.Salary;
using Microsoft.Office.Interop.Excel;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

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
        private ISalaryDialogForEditing dialog;

        public SalaryPresenter(ISalaryView view, ISalaryRepository repository, UserModel userModel)
        {
            this.view = view;
            this.repository = repository;
            this.userModel = userModel;

            ReadPermit();

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


            this.view.Show();

            saveExcel.Filter = "Excel Files|*.xlsx;*.xls";
            saveExcel.Title = "Save an Excel File";
        }


        private void Filter(object sender, EventArgs e)
        {
            salaryFilterList = salaryList;
            string departmentId = "All";
            string status = "All";
            int month = view.dtpChooseMonth.Value.Date.Month;
            int year = view.dtpChooseMonth.Value.Date.Year;
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
            // Get id from col 1
            DataGridViewRow selectedRow = view.dgvSalaryTable.CurrentRow;
            string userId = selectedRow.Cells[0].Value.ToString();
            int month = view.dtpChooseMonth.Value.Month;
            int year = view.dtpChooseMonth.Value.Year;

            // Delete thumbticket by repository
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Do you want to delete this salary table?", "Delete salary table", buttons);
            if (result == DialogResult.Yes)
            {
                DeletePermit(userId, month, year);
                SucessPopUp.ShowPopUp();
                ReadPermit();
            }
        }

        private void LoadSalaryDialogToEdit(object sender, EventArgs e)
        {
            dialog = new SalaryDialogForEditing();

            // Get primary key from table
            DataGridViewRow selectedRow = view.dgvSalaryTable.CurrentRow;
            string userId = selectedRow.Cells[0].Value.ToString();
            int month = view.dtpChooseMonth.Value.Month;
            int year = view.dtpChooseMonth.Value.Year;

            // Get salary model by userID and month year
            SalaryModel salaryModel = repository.LINQ_GetModelByPK(salaryList, userId, month, year);  
            dialog.ShowSalaryInfo(salaryModel);

            // Event Handle for Update ThumbTicket dialog
            dialog.updateEvent += Dialog_SaveUpdateEvent;
            dialog.approveEvent += Dialog_SaveApproveEvent;

            dialog.ShowDialog();
        }

        private void Dialog_SaveApproveEvent(object sender, EventArgs e)
        {
            // Get primary key from table
            DataGridViewRow selectedRow = view.dgvSalaryTable.CurrentRow;
            string userId = selectedRow.Cells[0].Value.ToString();
            int month = view.dtpChooseMonth.Value.Month;
            int year = view.dtpChooseMonth.Value.Year;

            // Get salary model by userID and month year
            SalaryModel salaryModel = repository.LINQ_GetModelByPK(salaryList, userId, month, year);
            salaryModel.Status = "Approved";

            // Update
            UpdatePermit(salaryModel);
            ReadPermit();
            SucessPopUp.ShowPopUp();
        }

        private void Dialog_SaveUpdateEvent(object sender, EventArgs e)
        {
            // Get primary key from table
            DataGridViewRow selectedRow = view.dgvSalaryTable.CurrentRow;
            string userId = selectedRow.Cells[0].Value.ToString();
            int month = view.dtpChooseMonth.Value.Month;
            int year = view.dtpChooseMonth.Value.Year;

            // Get salary model by userID and month year
            SalaryModel salaryModel = repository.LINQ_GetModelByPK(salaryList, userId, month, year);
            SalaryModel changedModel = dialog.GetChangedInfo();
            salaryModel.Welfare = changedModel.Welfare;

            if (changedModel.Complain != null)
                salaryModel.Complain = changedModel.Complain;
            if (changedModel.Res != null)
                salaryModel.Res = changedModel.Res;

            // Update
            ExportOneSalary(salaryModel);
            ReadPermit();
            SucessPopUp.ShowPopUp();
            dialog.Close();
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
                    DialogResult result = MessageBox.Show("Một khi đã duyệt tất cả, các dữ liệu sẽ được ghi đề về trạng thái mặc định của hệ thống, bạn có đồng ý duyệt tất cả hay không?", "Xác nhận", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
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

        private void ExportOneSalary(SalaryModel salaryModel)
        {
            IUserRepository userRepository = new UserRepository();
            IEnumerable<UserModel> userList = userRepository.GetAll();
            UserModel userModel = userRepository.LINQ_GetModelById(userList, salaryModel.UserId);
            // Calculate tax. If tax > 2 million, minus 10% 
            double total = (salaryModel.RealWorkday / 22 + salaryModel.ThumbTotal - salaryModel.TicketTotal + salaryModel.Welfare) * userModel.Salary;
            double tax = 0;
            if (total >= 2000000) tax = 0.1 * total;

            // Calculate total Salary
            double totalSalary = total - tax;

            // insert information salary
            salaryModel.Tax = tax;
            salaryModel.TotalSalary = totalSalary;

            UpdatePermit(salaryModel);
        }
        private void ExportSalary(object sender, EventArgs e)
        {
            int month = view.dtpChooseMonth.Value.Month;
            int year = view.dtpChooseMonth.Value.Year;
            IUserRepository userRepository = new UserRepository();
            IEnumerable<UserModel> userList = userRepository.GetAll();

            bool isSalaryExisting = repository.LINQ_CheckExistSalary(salaryList, month, year);

            if (isSalaryExisting)
            {
                DialogResult result = MessageBox.Show("Bảng lương cho tháng này đã tồn tại. Bạn có muốn ghi đè lên bảng lương hiện tại không?", "Xác nhận", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
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
                        double total = (real_workday / 22 + thumb_total - ticket_total) * user.Salary;
                        double tax = 0;
                        if (total >= 2000000) tax = 0.1 * total;

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
                        if (repository.LINQ_CheckExistIndividualSalary(salaryList, user.Id, month, year))
                        {
                            repository.Delete(user.Id, month, year);
                        }
                        repository.Add(salaryModel);
                    }
                    ReadPermit();
                    SucessPopUp.ShowPopUp();
                }    
            }
        }

        // ========================================================================================================
        // Decentralized programming
        // Read
        private void ReadPermit()
        {
            salaryList = repository.GetAll();
            int month = view.dtpChooseMonth.Value.Month;
            int year = view.dtpChooseMonth.Value.Year;
            if (this.userModel.Roles == "Admin" || userModel.Roles == "HR")
            {
                // get salary table by month and year
                salaryFilterList = repository.LINQ_GetListByMonthNYear(salaryList, month, year);
                this.view.ShowSalaryList(salaryFilterList);
            }
            else if (userModel.Roles == "User")
            {
                // Không được xem
            }
            else if (userModel.Roles == "Manager")
            {
                // Chỉ xem những người mà mình quản lý
                // get salary table by month and year
                salaryFilterList = repository.LINQ_GetListByManagerNMonthNYear(salaryList, userModel.Id, month, year);
                this.view.ShowSalaryList(salaryFilterList);
            }
        }


        // Delete
        private void DeletePermit(string userId, int month, int year)
        {
            if (userModel.Roles == "Admin" || userModel.Roles == "HR")
            {
                repository.Delete(userId, month, year);

            }
            else if (userModel.Roles == "User")
            {
                MessageBox.Show("Bạn không có quyền xóa! Vui lòng thử lại sau.");
            }
            else if (userModel.Roles == "Manager")
            {
                MessageBox.Show("Bạn không có quyền xóa! Vui lòng thử lại sau.");
            }
        }
        // Edit
        private void UpdatePermit(SalaryModel salaryModel)
        {
            if (userModel.Roles == "Admin" || userModel.Roles == "HR")
            {
                repository.Update(salaryModel);
            }
            else if (userModel.Roles == "User")
            {
                MessageBox.Show("Bạn không có quyền sửa! Vui lòng thử lại sau.");
            }
            else if (userModel.Roles == "Manager")
            {
                MessageBox.Show("Bạn không có quyền sửa! Vui lòng thử lại sau.");
            }
        }
        // Add
        private void AddPermit()
        {
            if (userModel.Roles == "Admin")
            {

            }
            else if (userModel.Roles == "HR")
            {

            }
            else if (userModel.Roles == "User")
            {

            }
            else if (userModel.Roles == "Manager")
            {

            }
        }

    }
}
