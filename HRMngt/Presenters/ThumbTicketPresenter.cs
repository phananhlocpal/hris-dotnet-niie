using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRMngt._Repository;
using HRMngt.Model;
using HRMngt.popup;
using HRMngt.View;
using HRMngt.View.Popup;
using HRMngt.Views;
using Microsoft.VisualBasic;

namespace HRMngt.Presenter
{
    public class ThumbTicketPresenter
    {
        //Fields
        private IThumbTicketView view;
        private ThumbTicketDialog dialog;
        private UserModel userModel;
        private IThumbTicketRepository thumbTicketRepository;
        private IEnumerable<ThumbTicketModel> thumbTicketList;
        private IEnumerable<ThumbTicketModel> thumbTicketFilter;

        public ThumbTicketPresenter(IThumbTicketView view, IThumbTicketRepository repository, UserModel userModel)
        {

            this.thumbTicketList = new List<ThumbTicketModel>();
            this.view = view;
            this.thumbTicketRepository = repository;
            this.userModel = userModel;
            // Subscribe event handler methods to view events
            this.view.SearchByMonthEvent += SearchByMonthEvent;
            this.view.SearchByTypeEvent += SearchByTypeEvent;
            this.view.SearchByUserId += SearchByUserId;
            this.view.LoadThumbTicketDialogToAddEvent += LoadThumbTicketDialogToAdd;
            this.view.LoadThumbTicketDialogToEditEvent += LoadThumbTicketDialogToEdit;
            this.view.DeleteEvent += DeleteSelectedThumbTicket;

            // Show thumbticket list when starting
            ReadPermit();

            //Show view
            this.view.Show();
        }

        private void SearchByUserId(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SearchByTypeEvent(object sender, EventArgs e)
        {

            ComboBox cmbChooseType = view.cmbChooseType;
            string selectedType = cmbChooseType.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedType))
            {
                return;
            }

            IEnumerable<ThumbTicketModel> filteredTickets;

            if (thumbTicketFilter == null)
            {
                thumbTicketFilter = thumbTicketRepository.GetByType(selectedType);
                this.view.ShowAllThumbTicketList(thumbTicketFilter);
            }
            else
            {
                // Create a temp filter
                List<ThumbTicketModel> tempThumbTicketFilter = new List<ThumbTicketModel>(thumbTicketFilter);
                // Tạo một bản sao của bộ lọc trước đó và áp dụng điều kiện mới
                tempThumbTicketFilter = tempThumbTicketFilter.Where(thumbTicketModel => thumbTicketModel.Type == selectedType).ToList();
                this.view.ShowAllThumbTicketList(tempThumbTicketFilter);
            }

        }


        private void SearchByMonthEvent(object sender, EventArgs e)
        {
            ComboBox cmbChooseMonth = view.cmbChooseMonth;
            string selectedMonth = cmbChooseMonth.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedMonth))
            {
                return;
            }

            // Split month value from month string
            string[] parts = selectedMonth.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int monthValue = int.Parse(parts[1]);

            IEnumerable<ThumbTicketModel> filteredTickets;

            if (thumbTicketFilter == null)
            {
                thumbTicketFilter = thumbTicketRepository.GetByMonth(monthValue);
                this.view.ShowAllThumbTicketList(thumbTicketFilter);
            }
            else
            {
                List<ThumbTicketModel> tempThumbTicketFilter = new List<ThumbTicketModel>(thumbTicketFilter);
                // Tạo một bản sao của bộ lọc trước đó và áp dụng điều kiện mới
                tempThumbTicketFilter = tempThumbTicketFilter.Where(thumbTicketModel => thumbTicketModel.Date.Month == monthValue).ToList();
                this.view.ShowAllThumbTicketList(tempThumbTicketFilter);

            }

        }

        private void DeleteSelectedThumbTicket(object sender, EventArgs e)
        {
            // Get id from col 1
            DataGridViewRow selectedRow = view.DataGridView.CurrentRow;
            string id = selectedRow.Cells[0].Value.ToString();

            // Delete thumbticket by repository
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Do you want to delete this thumb/ticket?", "Delete thumb/ticket", buttons);
            if (result == DialogResult.Yes)
            {
                thumbTicketRepository.Delete(id);
                SucessPopUp.ShowPopUp();
                ReadPermit();
            }
        }

        private void LoadThumbTicketDialogToEdit(object sender, EventArgs e)
        {
            // Create thumb/ticket dialog
            dialog = this.view.ShowThumbTicketDialogToUpdate(null);

            // Get id for sender and receiver
            List<string> userIdNNameList = new List<string>();
            IUserRepository userRepository = new UserRepository();
            userIdNNameList = userRepository.GetUserIdNName();

            // Add user to sender and receiver
            this.dialog.ShowUserIdNName(userIdNNameList);

            // Get thumb/ticket ID from row 
            DataGridViewRow selectedRow = view.DataGridView.CurrentRow;
            string id = selectedRow.Cells[0].Value.ToString();

            // Get thumb/ticket model by id
            ThumbTicketModel thumbTicketModel = new ThumbTicketModel();
            thumbTicketModel = thumbTicketRepository.GetById(id);
            dialog.Id = thumbTicketModel.Id;
            dialog.Type = thumbTicketModel.Type;
            dialog.Date = thumbTicketModel.Date;
            dialog.Sender = $"{thumbTicketModel.Sender} - {userRepository.GetNameById(thumbTicketModel.Sender)}";
            dialog.Receiver = $"{thumbTicketModel.Receiver} - {userRepository.GetNameById(thumbTicketModel.Receiver)}";
            dialog.Reason = thumbTicketModel.Reason;
            dialog.Money = thumbTicketModel.Money;
            dialog.Response = thumbTicketModel.Response;
            dialog.Complain = thumbTicketModel.Complain;
            dialog.Status = thumbTicketModel.Status;

            // Event Handle for Update ThumbTicket dialog
            dialog.SaveUpdateEvent += Dialog_SaveUpdateEvent;
            dialog.ComplainEvent += Dialog_ComplainEvent;
            dialog.ResponseEvent += Dialog_ResponseEvent;

            // Show the dialog
            this.dialog.ShowDialog();

        }

        private void Dialog_SaveUpdateEvent(object sender, EventArgs e)
        {
            ThumbTicketDialog dialog = sender as ThumbTicketDialog;
            if (dialog != null)
            {
                // Save the added content to thumbticket model 
                ThumbTicketModel thumbTicketModel = new ThumbTicketModel();
                thumbTicketModel.Id = dialog.Id;
                thumbTicketModel.Type = dialog.Type;
                thumbTicketModel.Date = dialog.Date;
                thumbTicketModel.Sender = dialog.Sender;
                thumbTicketModel.Receiver = dialog.Receiver;
                thumbTicketModel.Reason = dialog.Reason;
                thumbTicketModel.Complain = dialog.Complain;
                thumbTicketModel.Response = dialog.Response;
                thumbTicketModel.Money = dialog.Money;
                thumbTicketModel.Status = dialog.Status;

                thumbTicketRepository.Update(thumbTicketModel);

                // Close dialog and refresh list
                this.dialog.Close();
                ReadPermit();
                SucessPopUp.ShowPopUp();
            }

        }

        private void Dialog_ComplainEvent(object sender, EventArgs e)
        {
            ThumbTicketDialog dialog = sender as ThumbTicketDialog;
            if (dialog != null)
            {
                string complainText = Interaction.InputBox("Nhập nội dung khiếu nại", "Complain Content Box");
                dialog.Complain = complainText;
            }
        }

        private void Dialog_ResponseEvent(object sender, EventArgs e)
        {
            ThumbTicketDialog dialog = sender as ThumbTicketDialog;
            if (dialog != null)
            {
                string response = Interaction.InputBox("Nhập nội dung phản hồi", "Complain Content Box");
                dialog.Response = response;

            }
        }

        private void LoadThumbTicketDialogToAdd(object sender, EventArgs e)
        {
            // Create thumb/ticket dialog
            dialog = this.view.ShowThumbTicketDialogToAdd();

            // Get id for sender and receiver
            List<string> userIdNNameList = new List<string>();
            IUserRepository userRepository = new UserRepository();
            userIdNNameList = userRepository.GetUserIdNName();

            // Add user to sender and receiver
            dialog.ShowUserIdNName(userIdNNameList);
            dialog.Sender = $"{this.userModel.Id} - {this.userModel.Name}";
            MessageBox.Show($"{this.userModel.Id} - {this.userModel.Name}");
            // Event Handle for Add ThumbTicket dialog
            dialog.SaveAddEvent += Dialog_SaveAddEvent;

            // Show the dialog
            this.dialog.ShowDialog();
        }

        private void Dialog_SaveAddEvent(object sender, EventArgs e)
        {
            string stringNoti = "";
            // Save the added content to thumbticket model 
            ThumbTicketModel thumbTicketModel = new ThumbTicketModel();
            thumbTicketModel.Type = dialog.Type;
            thumbTicketModel.Date = dialog.Date;
            thumbTicketModel.Sender = dialog.Sender;
            thumbTicketModel.Receiver = dialog.Receiver;
            thumbTicketModel.Reason = dialog.Reason;
            thumbTicketModel.Money = dialog.Money;

            if (thumbTicketModel.Type == "")
                stringNoti = "Bạn cần nhập Loại";
            else if (thumbTicketModel.Receiver == "")
                stringNoti = "Bạn cần nhập người nhận";
            else if (thumbTicketModel.Reason == "")
                stringNoti = "Bạn cần nhập lý do";
            else if (thumbTicketModel.Money == 0)
                stringNoti = "Bạn cần nhập số tiền";

            if (stringNoti != "")
                MessageBox.Show(stringNoti);
            else
            {
                thumbTicketRepository.Add(thumbTicketModel);
                // Close dialog and refresh list
                ReadPermit();
                SucessPopUp.ShowPopUp();
                this.dialog.Close();
            }
        }

        // Decentralized programming
        // Read
        private void ReadPermit()
        {
            if (userModel.Position == "Admin" || userModel.Position == "HR")
            {
                thumbTicketList = thumbTicketRepository.GetAll();
                this.view.ShowAllThumbTicketList(thumbTicketList);
            }
            else if (userModel.Position == "User")
            {
                string id = userModel.Id;
                thumbTicketList = thumbTicketRepository.GetByUserId(id);
                this.view.ShowAllThumbTicketList(thumbTicketList);
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
