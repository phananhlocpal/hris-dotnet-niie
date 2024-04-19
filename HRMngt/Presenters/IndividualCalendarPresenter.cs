using HRMngt._Repository.Calendar;
using HRMngt.Model;
using HRMngt.Models;
using HRMngt.popup;
using HRMngt.Views.Dialogs;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public int Dialog_SaveAddEvent { get; private set; }

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

            view.dtpChoosePeriod.Value = DateTime.Now;
            ReadPermit();
            this.view.Show();
        }

        private void LoadCalendarDialogToAdd(object sender, EventArgs e)
        {
            // Create calendar dialog
            addDialog = this.view.ShowCalendarDialogToAdd();

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
                CalendarModel calendarModel = new CalendarModel();
                calendarModel = dialog.getCalendarInfo();
                calendarModel.UserId = userModel.Id;

                if (repository.LINQ_checkExistDate(calendarList, calendarModel.Date) == true)
                {
                    MessageBox.Show($"Ngày {calendarModel.Date.ToString("dd/MM/yyyy")} đã được đăng ký!");
                    FailPopUp.ShowPopUp();
                }
                else
                {
                    repository.Add(calendarModel);
                    calendarList = repository.GetAll();

                    // Close dialog and refresh list
                    this.addDialog.Close();
                    ReadPermit();
                    SucessPopUp.ShowPopUp();
                }
            }
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
                calendarList = repository.GetAll();

                // Close dialog and refresh list
                this.editDialog.Close();
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
                calendarList = repository.GetAll();
                SucessPopUp.ShowPopUp();
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
