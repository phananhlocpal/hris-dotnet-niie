using HRMngt._Repository.Calendar;
using HRMngt.Model;
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
    public class IndividualCalendarPresenter
    {
        private UserModel userModel;
        private IIndividualCalendarView view;
        private ICalendarRepository repository;
        private IndividualCalendarDialogForEditting editDialog;
        private IndividualCalendarDialogForAdding addDialog;

        public int Dialog_SaveAddEvent { get; private set; }

        public IndividualCalendarPresenter(IIndividualCalendarView view, ICalendarRepository repository, UserModel user)
        {
            this.view = view;
            this.repository = repository;
            this.userModel = user;

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

                if (repository.checkDate(calendarModel.Date) == true)
                {
                    MessageBox.Show($"Ngày {calendarModel.Date.ToString("dd/MM/yyyy")} đã được đăng ký!");
                    FailPopUp.ShowPopUp();
                }
                else
                {
                    repository.Add(calendarModel, userModel.Id);

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
            calendarModel = repository.GetByUserIdNDate(userModel.Id, date);
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
                repository.Update(calendarModel, userModel.Id);

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

        // Decentralized programming
        // Read
        private void ReadPermit()
        {
            if (userModel.Position == "Admin" || userModel.Position == "HR")
            {
                DateTime selectedDate = view.dtpChoosePeriod.Value;
                DateTime monday = selectedDate.AddDays(DayOfWeek.Monday - selectedDate.DayOfWeek);
                DateTime sunday = monday.AddDays(6);
                // get calendar with period
                ICalendarRepository calendarRepository = new CalendarRepository();
                IEnumerable<CalendarModel> calendarList = calendarRepository.GetByUserIDNPeriod(userModel.Id, monday, sunday).ToList();
                this.view.ShowCalendarList(calendarList);
            }
            else if (userModel.Position == "User")
            {

            }
            else if (userModel.Position == "Manager")
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
