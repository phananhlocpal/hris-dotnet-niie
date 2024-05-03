using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRMngt._Repository;
using HRMngt.Models;
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
        private UserModel userModel;
        private IThumbTicketRepository thumbTicketRepository;

        private ThumbTicketDialog dialog;
        private IEnumerable<ThumbTicketModel> thumbTicketList;

        public ThumbTicketPresenter(IThumbTicketView view, IThumbTicketRepository repository, UserModel userModel)
        {
            // Contructor
            this.view = view;
            this.thumbTicketRepository = repository;
            this.userModel = userModel;
            // Subscribe event handler methods to view events
            this.view.LoadThumbTicketDialogToAddEvent += LoadThumbTicketDialogToAdd;
            this.view.LoadThumbTicketDialogToEditEvent += LoadThumbTicketDialogToEdit;
            this.view.DeleteEvent += DeleteSelectedThumbTicket;
            this.view.FilterEvent += Filter;

            // Enable button
            if (userModel.Roles == "HR" || userModel.Roles == "Employee")
                view.btnCreate.Enabled = false;

            // Show thumbticket list when starting
            ReadPermit();

            //Show view
            this.view.Show();
        }

        private void Filter(object sender, EventArgs e)
        {
            thumbTicketList = thumbTicketRepository.GetAll();
            int month = view.dtpchooseMonth.Value.Month;
            int year = view.dtpchooseMonth.Value.Year;
            string type = view.cmbChooseType.Text;
            string userId = "";
            if (view.txtChooseUserId != null) userId = view.txtChooseUserId.Text;

            IEnumerable<ThumbTicketModel> thumbTicketTempList = this.thumbTicketRepository.LINQ_Filter(thumbTicketList, userId, month, year, type);

            this.view.ShowAllThumbTicketList(thumbTicketTempList);
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
            IEnumerable<UserModel> userList = new List<UserModel>();
            IUserRepository userRepository = new UserRepository();
            userList = userRepository.GetAll();

            // Add user to sender and receiver
            this.dialog.ShowUserIdNName(userList);

            // Get thumb/ticket ID from row 
            DataGridViewRow selectedRow = view.DataGridView.CurrentRow;
            string id = selectedRow.Cells[0].Value.ToString();

            // Get thumb/ticket model by id
            ThumbTicketModel thumbTicketModel = new ThumbTicketModel();
            thumbTicketModel = thumbTicketRepository.LINQ_GetModelById(thumbTicketList, id);
            UserModel senderModel = new UserModel();
            senderModel = userRepository.LINQ_GetModelById(userList, thumbTicketModel.Sender);
            UserModel receierModel = new UserModel();
            receierModel = userRepository.LINQ_GetModelById(userList, thumbTicketModel.Receiver);

            dialog.Id = thumbTicketModel.Id;
            dialog.Type = thumbTicketModel.Type;
            dialog.Date = thumbTicketModel.Date;
            dialog.Sender = $"{thumbTicketModel.Sender} - {senderModel.Name}";
            dialog.Receiver = $"{thumbTicketModel.Receiver} - {receierModel.Name}";
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
            IEnumerable<UserModel> userList = new List<UserModel>();
            IUserRepository userRepository = new UserRepository();
            userList = userRepository.GetAll();

            // Add user to sender and receiver
            if (userModel.Roles == "Manager")
            {
                IEnumerable<UserModel> managerUserList = userRepository.LINQ_GetListByManager(userList, userModel.Id);
                dialog.ShowUserIdNName(managerUserList);
            }
            else dialog.ShowUserIdNName(userList);

            dialog.Sender = $"{this.userModel.Id} - {this.userModel.Name}";

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
                AddPermit(thumbTicketModel);
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
            if (userModel.Roles == "Admin" || userModel.Roles == "HR")
            {
                thumbTicketList = thumbTicketRepository.GetAll();
                this.view.ShowAllThumbTicketList(thumbTicketList);
            }
            else if (userModel.Roles == "User")
            {
                string id = userModel.Id;
                IEnumerable<ThumbTicketModel> filterList = thumbTicketRepository.LINQ_GetListById(thumbTicketList, id);
                this.view.ShowAllThumbTicketList(filterList);
            }
            else if (userModel.Roles == "Manager")
            {
                IEnumerable<ThumbTicketModel> filterList = thumbTicketRepository.LINQ_GetListByManager(thumbTicketList, userModel.Id);
                this.view.ShowAllThumbTicketList(filterList);
            }
        }
        // Delete
        private void DeletePermit()
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
        // Edit
        private void UpdatePermit()
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
        // Add
        private void AddPermit(ThumbTicketModel thumbTicketModel)
        {
            if (userModel.Roles == "Admin")
            {
                if (thumbTicketModel.Id != userModel.Id)
                    thumbTicketRepository.Add(thumbTicketModel);
                else MessageBox.Show("Không được tạo cho bản thân nhéeee!");

            }
            else if (userModel.Roles == "HR")
            {
                
            }

            else if (userModel.Roles == "User")
            {

            }
            else if (userModel.Roles == "Manager")
            {
                if (thumbTicketModel.Id != userModel.Id)
                    thumbTicketRepository.Add(thumbTicketModel);
                else MessageBox.Show("Không được tạo cho bản thân nhéeee!");
                
            }
        }
    }
}
