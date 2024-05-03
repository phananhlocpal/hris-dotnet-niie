using HRMngt._Repository;
using HRMngt._Repository.Calendar;
using HRMngt._Repository.Request;
using HRMngt.Models;
using HRMngt.popup;
using HRMngt.Views.Dialogs;
using HRMngt.Views.Dialogs.Forms;
using HRMngt.Views.Dialogs.Interfaces;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HRMngt.Presenters
{
    public class IndividualCalendarPresenter
    {
        private UserModel userModel;
        private IIndividualCalendarView view;
        private ICalendarRepository repository;
        private IndividualCalendarDialogForEditting editDialog;
        private IndividualCalendarDialogForAdding addDialog;
        private IEnumerable<CalendarModel> calendarList;
        private ILeaveDialog leaveDialog;

        public IndividualCalendarPresenter(IIndividualCalendarView view, ICalendarRepository repository, UserModel user)
        {
            this.view = view;
            this.repository = repository;
            this.userModel = user;
            this.calendarList = repository.GetAll();


            this.view.ViewCurrentCalendarEvent += ViewCurrentCalendarEvent;
            this.view.DeleteCalendarEvent += DeleteCalendarEvent;
            this.view.LoadCalendarDialogToUpdateEvent += LoadCalendarDialogToEdit;
            this.view.LoadCalendarDialogToCreateEvent += LoadCalendarDialogToAdd;
            this.view.SearchByPeriodEvent += SearchByPeriod;
            this.view.LoadLeaveDialogEvent += LoadLeaveDialog;
            this.view.Filter += Filter;

            view.dtpChoosePeriod.Value = DateTime.Now;
            ReadPermit();
            this.view.Show();
        }

        private void Filter(object sender, EventArgs e)
        {
            calendarList = repository.GetAll();

            DateTime selectedDate = view.dtpChoosePeriod.Value;
            DateTime monday = selectedDate.AddDays(DayOfWeek.Monday - selectedDate.DayOfWeek);
            DateTime sunday = monday.AddDays(6);

            string status = view.cmbStatus.Text;
            IEnumerable<CalendarModel> calendarFilterList = repository.LINQ_Filter(calendarList, monday, sunday, userModel.DepartmentID, status, userModel.Id);

            if (calendarFilterList.Any())
            {
                this.view.ShowCalendarList(calendarFilterList);
            }
            else
            {
                MessageBox.Show("Không có lịch");
                FailPopUp.ShowPopUp();
            }
        }


        private void LoadLeaveDialog(object sender, EventArgs e)
        {
            // Create Leave dialog
            leaveDialog = new LeaveDialog();

            // Event Handler 
            leaveDialog.ShowLeaveDescription += LeaveDialog_ShowLeaveDescription;
            leaveDialog.SubmitEvent += LeaveDialog_Submit;

            //Show the dialog
            leaveDialog.ShowDialog();
        }

        private void LeaveDialog_Submit(object sender, EventArgs e)
        {
            LeaveDialog dialog = sender as LeaveDialog;
            if (dialog != null)
            {
                // Get leave list from dialog
                IEnumerable<CalendarModel> leaveRegisterList = new List<CalendarModel>();
                leaveRegisterList = dialog.GetLeaveInfo(userModel);

                // Create request'
                RequestModel requestModel = new RequestModel();
                IRequestRepository requestRepository = new RequestRepository();
                string selectedValue = leaveDialog.cmbLeaveType.SelectedItem.ToString();
                switch (selectedValue)
                {
                    case "Nghỉ phép nguyên lương":
                        requestModel.Type = "Leave 1";
                        break;
                    case "Nghỉ việc riêng":
                        requestModel.Type = "Leave 2";
                        break;
                    case "Nghỉ lễ/tết":
                        requestModel.Type = "Leave 3";
                        break;
                    case "Nghỉ không lương":
                        requestModel.Type = "Leave 4";
                        break;
                }
                requestModel.Time = DateTime.Now;
                requestModel.Sender = userModel.Id;
                requestModel.Approver = userModel.ManagerID;
                requestModel.Status = 0;
                requestModel = requestRepository.Add(requestModel);

                foreach (CalendarModel model in leaveRegisterList)
                {
                    // If date exist, add requestId
                    if (repository.LINQ_checkExistDate(calendarList, model.Date))
                    {
                        // Get exist date
                        CalendarModel tempModel = repository.LINQ_GetModelByUserIdNDate(calendarList, userModel.Id, model.Date);
                        tempModel.RequestId = requestModel.Id;
                        repository.Update(tempModel);
                    }
                    // If date does not exist, add new 
                    else
                    {
                        model.Status = "Leave Pending";
                        model.RequestId = requestModel.Id;
                        repository.Add(model);
                    }
                }
                this.calendarList = repository.GetAll();
                ReadPermit();
                dialog.Close();
                SucessPopUp.ShowPopUp();
            }

        }

        private void LeaveDialog_ShowLeaveDescription(object sender, EventArgs e)
        {
            if (leaveDialog != null && leaveDialog.cmbLeaveType.SelectedItem != null)
            {
                string selectedValue = leaveDialog.cmbLeaveType.SelectedItem.ToString();
                switch (selectedValue)
                {
                    case "Nghỉ phép nguyên lương":
                        leaveDialog.leaveDesription = "Mỗi năm người lao động có 12 ngày nghỉ phép nguyên lương. \nLưu ý: Sô ngày nghỉ phép nguyên lương + số ngày nghỉ theo chế độ của công ty + số ngày làm việc không được vượt quá số công chuẩn trong tháng. Nếu vượt quá, sẽ không được tính lương (Max = công/ca chuẩn trên tháng).";
                        break;
                    case "Nghỉ việc riêng":
                        leaveDialog.leaveDesription = "Kết hôn, người lao động được nghỉ 03 ngày. \nCon kết hôn, người lao động được nghỉ 01 ngày.\nNghỉ Tứ thân, phụ mẫu, vợ/chồng/con chết, người lao động được nghỉ 03 ngày.\nÔng nội, bà nội, ông ngoại, bà ngoại, anh, chị, em ruột chết, người lao động được nghỉ 01 ngày.\nLưu ý: Vui lòng nhập đúng số ngày để quản lý duyệt.";
                        break;
                    case "Nghỉ lễ/tết":
                        leaveDialog.leaveDesription = "Người lao động được hưởng nguyên lương theo quy định của Bộ Lao động. Bạn vui lòng điền số ngày nghỉ đúng theo thông báo của công ty.";
                        break;
                    case "Nghỉ không lương":
                        leaveDialog.leaveDesription = "Theo quy định, nghỉ không lương sẽ không được tính vào ngày công của tháng.";
                        break;
                }
            }
        }

        private void LoadCalendarDialogToAdd(object sender, EventArgs e)
        {
            // Create calendar dialog
            addDialog = this.view.ShowCalendarDialogToAdd();
            addDialog.ShowListDate();

            // Event Handle for Update ThumbTicket dialog
            addDialog.CreateEvent += AddDialog_CreateEvent;

            // Show the dialog
            this.addDialog.ShowDialog();
        }

        private void AddDialog_CreateEvent(object sender, EventArgs e)
        {
            IndividualCalendarDialogForAdding dialog = sender as IndividualCalendarDialogForAdding;
            if (dialog != null)
            {
                // Save the added content to thumbticket model 
                IEnumerable<CalendarModel> calendarRegisterList = new List<CalendarModel>();
                calendarRegisterList = dialog.getCalendarInfo();

                // Check exist date
                if (CheckExistDate(calendarRegisterList) == true)
                {
                    MessageBox.Show("Có ngày bạn đã đăng ký");
                    FailPopUp.ShowPopUp();
                }    
                else
                {
                    // Create request
                    RequestModel requestModel = new RequestModel();
                    IRequestRepository requestRepository = new RequestRepository();
                    requestModel.Type = "Calendar";
                    requestModel.Time = DateTime.Now;
                    requestModel.Sender = userModel.Id;
                    requestModel.Approver = userModel.ManagerID;
                    requestModel.Status = 0;
                    requestModel = requestRepository.Add(requestModel);

                    foreach (CalendarModel calendarModel in calendarRegisterList)
                    {
                        calendarModel.UserId = userModel.Id;
                        calendarModel.RequestId = requestModel.Id;
                        calendarModel.Status = "Created";
                        repository.Add(calendarModel);
                    }
                    
                    // Close dialog and refresh list
                    this.addDialog.Close();
                    calendarList = repository.GetAll();
                    ReadPermit();
                    SucessPopUp.ShowPopUp();
                }
            }
        }

        private bool CheckExistDate(IEnumerable<CalendarModel> calendarRegisterList)
        {
            bool result = false;
            // Ensure that calendarList is initialized and contains data
            if (calendarRegisterList == null)
                result =  false;

            foreach (CalendarModel calendarModel in calendarRegisterList)
            {
                // Check if the date already exists in the calendarList
                if (repository.LINQ_CheckIndividualExistDate(calendarList, userModel.Id, calendarModel.Date))
                    result = true;
            }
            return result;
        }


        private void SearchByPeriod(object sender, EventArgs e)
        {
            ReadPermit();
        }

        private void LoadCalendarDialogToEdit(object sender, EventArgs e)
        {
            // Create calendar dialog
            editDialog = this.view.ShowCalendarDialogToEdit();

            // Get date from row 
            DataGridViewRow selectedRow = view.dgvCalendarTable.CurrentRow;
            string dateString = selectedRow.Cells[0].Value.ToString();
            DateTime date = DateTime.Parse(dateString);

            // Get calendar model by userID and date
            CalendarModel calendarModel = new CalendarModel();
            calendarModel = repository.LINQ_GetModelByUserIdNDate(calendarList,userModel.Id, date);
            editDialog.ShowCalendarInfo(calendarModel);

            // Event Handle for Update ThumbTicket dialog
            editDialog.UpdateEvent += Dialog_SaveUpdateEvent;

            // Show the dialog
            this.editDialog.ShowDialog();
        }

       

        private void Dialog_SaveUpdateEvent(object sender, EventArgs e)
        {
            IndividualCalendarDialogForEditting dialog = sender as IndividualCalendarDialogForEditting;
            if (dialog != null)
            {
                // Save the added content to thumbticket model 
                CalendarModel calendarModel = new CalendarModel();
                calendarModel = dialog.GetUpdatedInfo();
                calendarModel.UserId = userModel.Id;
                repository.Update(calendarModel);

                // Close dialog and refresh list
                this.editDialog.Close();
                this.calendarList = repository.GetAll();
                ReadPermit();
                SucessPopUp.ShowPopUp();
            }
        }

        private void DeleteCalendarEvent(object sender, EventArgs e)
        {
            // Get id from col 1
            DataGridViewRow selectedRow = view.dgvCalendarTable.CurrentRow;
            string dateString = selectedRow.Cells[0].Value.ToString();
            DateTime date = DateTime.Parse(dateString);

            // Delete thumbticket by repository
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Do you want to delete this calendar?", "Delete thumb/ticket", buttons);
            if (result == DialogResult.Yes)
            {
                repository.Delete(userModel.Id, date);
                SucessPopUp.ShowPopUp();
                this.calendarList = repository.GetAll();
                ReadPermit();
            }
        }

        private void ViewCurrentCalendarEvent(object sender, EventArgs e)
        {
            // Get Mon and Sun
            view.dtpChoosePeriod.Value = DateTime.Now;
            ReadPermit();
        }

        // ========================================================================================================
        // Decentralized programming
        // Read
        private void ReadPermit()
        {
            if (this.userModel.Roles == "Admin" || userModel.Roles == "HR")
            {
                DateTime selectedDate = view.dtpChoosePeriod.Value;
                DateTime monday = selectedDate.AddDays(DayOfWeek.Monday - selectedDate.DayOfWeek);
                DateTime sunday = monday.AddDays(6);
                // get calendar with period
                IEnumerable<CalendarModel> showedCalendarList = repository.LINQ_GetListByUserIDNPeriod(calendarList, userModel.Id, monday, sunday);
                this.view.ShowCalendarList(showedCalendarList);
            }
            else if (userModel.Roles == "User")
            {

            }
            else if (userModel.Roles == "Manager")
            {

            }
        }


        // Delete
        private void DeletePermit()
        {
            if (userModel.Position == "Admin")
            {

            }
            else if (userModel.Position == "HR")
            {

            }

            else if (userModel.Position == "User")
            {

            }
            else if (userModel.Position == "Manager")
            {

            }
        }
        // Edit
        private void UpdatePermit()
        {
            if (userModel.Position == "Admin")
            {

            }
            else if (userModel.Position == "HR")
            {

            }

            else if (userModel.Position == "User")
            {

            }
            else if (userModel.Position == "Manager")
            {

            }
        }
        // Add
        private void AddPermit()
        {
            if (userModel.Position == "Admin")
            {

            }
            else if (userModel.Position == "HR")
            {

            }

            else if (userModel.Position == "User")
            {

            }
            else if (userModel.Position == "Manager")
            {

            }
        }
    }
}
