using HRMngt._Repository;
using HRMngt._Repository.Calendar;
using HRMngt.Models;
using HRMngt.popup;
using HRMngt.Views.Dialogs;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMngt.Presenters
{
    public class TimeKeepingPresenter
    {
        private ITimeKeepingView view;
        private ICalendarRepository repository;
        private IndividualCalendarDialogForEditting editDialog;
        private UserModel userModel;
        private IEnumerable<CalendarModel> calendarList;
        private IEnumerable<CalendarModel> calendarFilterList;

        public TimeKeepingPresenter(ITimeKeepingView timeKeepingView, ICalendarRepository timeKeepingRepository, UserModel userModel)
        {
            // Contructors
            this.view = timeKeepingView;
            this.repository = timeKeepingRepository;
            this.userModel = userModel;
            calendarList = repository.GetAll();

            // Event Handler
            this.view.LoadTCalendarDialogToEditEvent += LoadCalendarDialogToEdit;
            this.view.DeleteEvent += Delete;
            this.view.ApproveEvent += Approve;
            this.view.NotApproveEvent += NotApprove;
            this.view.FilterEvent += Filter;

            // Show views
            GetNReturnDepartment();
            ReadListPermit();
            this.view.Show();
        }

        private void GetNReturnDepartment()
        {
            IDepartmentRepository departmentRepository = new DepartmentRepository();
            IEnumerable<DepartmentModel> departmentList = new List<DepartmentModel>();
            departmentList = departmentRepository.GetAll();
            this.view.ShowDepartmentList(departmentList);
        }


        // Event Handler
        private void Filter(object sender, EventArgs e)
        {
            DateTime start = view.dtpStart.Value;
            DateTime end = view.dtpEnd.Value;
            string departmentId = "";
            if (view.cmbDepartment.Text == "All")
                departmentId = view.cmbDepartment.Text;
            else departmentId = view.cmbDepartment.Text.Split(new char[] { '-' })[0].Trim();
            string status = view.cmbStatus.Text;
            if (view.txtUserId == null)
            {
                string userId = "";
                calendarFilterList = repository.LINQ_Filter(calendarList, start, end, departmentId, status, userId);
                this.view.ShowCalendarList(calendarFilterList);
            }
            else
            {
                string userId = view.txtUserId.Text;
                calendarFilterList = repository.LINQ_Filter(calendarList, start, end, departmentId, status, userId);
                this.view.ShowCalendarList(calendarFilterList);
            }
        }

        private void NotApprove(object sender, EventArgs e)
        {
            // Get date from row 
            DataGridViewRow selectedRow = view.dgvTimeKeepingTable.CurrentRow;
            string dateString = selectedRow.Cells[3].Value.ToString();
            string userid = selectedRow.Cells[0].Value.ToString();
            DateTime date = DateTime.Parse(dateString);

            // Get calendar model by userID and date
            CalendarModel calendarModel = new CalendarModel();
            calendarModel = repository.LINQ_GetModelByUserIdNDate(calendarList, userid, date);
            calendarModel.Status = "Not Approved";
            UpdatePermit(calendarModel);

            // Enabled button
            selectedRow.Cells[11].ReadOnly = true;
            selectedRow.Cells[12].ReadOnly = true;

        }

        private void Approve(object sender, EventArgs e)
        {
            // Get date from row 
            DataGridViewRow selectedRow = view.dgvTimeKeepingTable.CurrentRow;
            string dateString = selectedRow.Cells[3].Value.ToString();
            string userid = selectedRow.Cells[0].Value.ToString();
            DateTime date = DateTime.Parse(dateString);

            // Get calendar model by userID and date
            CalendarModel calendarModel = new CalendarModel();
            calendarModel = repository.LINQ_GetModelByUserIdNDate(calendarList, userid, date);
            calendarModel.Status = "Approved";
            UpdatePermit(calendarModel);

            // Enabled button
            selectedRow.Cells[11].ReadOnly = true;
            selectedRow.Cells[12].ReadOnly = true;
        }

        private void Delete(object sender, EventArgs e)
        {
            // Get date from row 
            DataGridViewRow selectedRow = view.dgvTimeKeepingTable.CurrentRow;
            string dateString = selectedRow.Cells[3].Value.ToString();
            string userid = selectedRow.Cells[0].Value.ToString();
            DateTime date = DateTime.Parse(dateString);

            // Get calendar model by userID and date
            CalendarModel calendarModel = new CalendarModel();
            calendarModel = repository.LINQ_GetModelByUserIdNDate(calendarList, userid, date);
            DeletePermit(calendarModel);
        }

        private void LoadCalendarDialogToEdit(object sender, EventArgs e)
        {
            // Create calendar dialog
            editDialog = this.view.ShowCalendarDialogToEdit();

            // Get date from row 
            DataGridViewRow selectedRow = view.dgvTimeKeepingTable.CurrentRow;
            string userid = selectedRow.Cells[0].Value.ToString();
            string dateString = selectedRow.Cells[3].Value.ToString();
            DateTime date = DateTime.Parse(dateString);

            // Get calendar model by userID and date
            CalendarModel calendarModel = new CalendarModel();
            calendarModel = repository.LINQ_GetModelByUserIdNDate(calendarList, userid, date);
            editDialog.ShowCalendarInfo(calendarModel);

            // Event Handle for Update ThumbTicket dialog
            editDialog.UpdateEvent += Dialog_Update;

            // Show the dialog
            this.editDialog.ShowDialog();
        }

        private void Dialog_Update(object sender, EventArgs e)
        {
            CalendarModel calendarModel = new CalendarModel();
            calendarModel = editDialog.GetUpdatedInfo();
            UpdatePermit(calendarModel);
        }


        // Decentralized programming
        // Read
        private void ReadListPermit()
        {
            if (userModel.Roles == "Admin" || userModel.Roles == "HR")
            {
                calendarList = repository.GetAll();
                // Xem được tất cả mọi người
                DateTime start = view.dtpStart.Value;
                DateTime end = view.dtpEnd.Value;
                IEnumerable<CalendarModel> FilterList = repository.LINQ_GetListByPeriod(calendarList, start, end);
                this.view.ShowCalendarList(FilterList);
            }
            else if (userModel.Roles == "User")
            {
                // Không xem được  
            }
            else if (userModel.Roles == "Manager")
            {
                calendarList = repository.GetAll();
                calendarList = repository.LINQ_GetListByManagerId(calendarList, userModel.Id);
                // Chỉ xem được những người mà mình quản lý
                DateTime start = view.dtpStart.Value;
                DateTime end = view.dtpEnd.Value;
                IEnumerable<CalendarModel> FilterList = repository.LINQ_GetListByPeriod(calendarList, start, end);
                this.view.ShowCalendarList(FilterList);
            }
        }
        // Delete
        private void DeletePermit(CalendarModel model)
        {
            if (userModel.Roles == "Admin")
            {
                // Xóa ai cũng được
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Do you want to delete this calendar", "Delete calendar", buttons);
                if (result == DialogResult.Yes)
                {
                    this.repository.Delete(model.UserId, model.Date);
                    SucessPopUp.ShowPopUp();
                    calendarList = repository.GetAll();
                    ReadListPermit();
                }
            }
            else if (userModel.Roles == "HR")
            {
                // Không xóa được
            }
            else if (userModel.Roles == "User")
            {
                // Không xóa được
            }
            else if (userModel.Roles == "Manager")
            {
                // Xóa được những người mình quản lý. Vì đã read chỉ những người mình đã quản lý nên không cần điều kiện
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Do you want to delete this calendar", "Delete calendar", buttons);
                if (result == DialogResult.Yes)
                {
                    this.repository.Delete(model.UserId, model.Date);
                    SucessPopUp.ShowPopUp();
                    calendarList = repository.GetAll();
                    ReadListPermit();
                }
            }
        }
        // Edit
        private void UpdatePermit(CalendarModel model)
        {
            if (userModel.Roles == "Admin")
            {
                // Sửa ai cũng được
                this.repository.Update(model);
                ReadListPermit();
                SucessPopUp.ShowPopUp();
            }
            else if (userModel.Roles == "HR")
            {
                // Không sửa được
            }
            else if (userModel.Roles == "User")
            {
                // Không sửa được
            }
            else if (userModel.Roles == "Manager")
            {
                // Sửa được những người mình quản lý. Vì đã read những người mình quản lý nên không cần điều kiện
                this.repository.Update(model);
                ReadListPermit();
                SucessPopUp.ShowPopUp();
            }
        }
        // Add
        private void AddPermit(CalendarModel model)
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
