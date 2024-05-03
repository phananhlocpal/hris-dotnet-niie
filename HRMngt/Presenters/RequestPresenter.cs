using HRMngt._Repository.Calendar;
using HRMngt._Repository.Request;
using HRMngt.Models;
using HRMngt.popup;
using HRMngt.Views.Dialogs.Forms;
using HRMngt.Views.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMngt.Presenters
{
    public class RequestPresenter
    {
        private IRequestView view;
        private IRequestRepository repository;
        private UserModel userModel;
        private IEnumerable<RequestModel> requestList;

        public RequestPresenter(IRequestView view, IRequestRepository repository, UserModel userModel)
        {
            this.view = view;
            this.repository = repository;
            this.userModel = userModel;

            requestList = repository.GetAll();
            requestList = repository.LINQ_GetListByApproverId(requestList, userModel.Id);

            view.ShowRequestDialog += ShowRequestDialog;
            view.Filter += Filter;

            view.ShowAllRequestList(requestList);
            this.view.Show();
        }

        private void Filter(object sender, EventArgs e)
        {
            DateTime time = view.dtpChooseMonth.Value.Date;
            string type = view.cmbChooseType.Text;
            string statusString = view.cmbChooseStatus.Text;
            int status = -1;
            switch (statusString)
            {
                case "Chưa xử lý":
                    status = 0;
                    break;
                case "Đã xử lý":
                    status = 1;
                    break;
            }
            string senderString = view.txtChooseUserId.Text;

            IEnumerable<RequestModel> FilterList = repository.LINQ_Filter(requestList, time, status, type, senderString);
            view.ShowAllRequestList(FilterList);

        }

        private void ShowRequestDialog(object sender, EventArgs e)
        {
            // Get thumb/ticket ID from row 
            DataGridViewRow selectedRow = view.DataGridViewRequest.CurrentRow;
            int id = int.Parse(selectedRow.Cells[0].Value.ToString());
            RequestModel requestModel = repository.LINQ_GetModelById(requestList, id);
            // Show Dialog
            RequestDialog dialog = this.view.ShowRequestDialogToUpdate();
            dialog.ShowRequestDetail(requestModel);

            // Event Handler
            dialog.approveEvent += Dialog_Approve;
            dialog.NotApproveEvent += Dialog_NotApprove;
            dialog.ShowDialog();

        }

        private void Dialog_NotApprove(object sender, EventArgs e)
        {
            // Get thumb/ticket ID from row 
            DataGridViewRow selectedRow = view.DataGridViewRequest.CurrentRow;
            int id = int.Parse(selectedRow.Cells[0].Value.ToString());
            RequestModel requestModel = repository.LINQ_GetModelById(requestList, id);
          
            ICalendarRepository calendarRepository = new CalendarRepository();
            IEnumerable<CalendarModel> calendarList = calendarRepository.GetAll();

            IEnumerable<CalendarModel> calendarRequestList = calendarRepository.LINQ_GetListByRequestId(calendarList, requestModel.Id);

            foreach (CalendarModel calendarModel in calendarRequestList)
            {
                if (requestModel.Type == "Calendar")
                {
                    calendarModel.Status = "Not Approved";
                    calendarRepository.Delete(calendarModel.UserId, calendarModel.Date);
                }    
                else
                {
                    // Nếu không aprrove thì xóa các calendar có requestId và status là Leave Pending
                    if (calendarModel.Status == "Leave Pending")
                        calendarRepository.Delete(calendarModel.UserId, calendarModel.Date);
                }    
            }

            requestModel.Status = 1;
            repository.Update(requestModel);

            RequestDialog dialog = sender as RequestDialog;
            dialog.Close();

            // Show table
            SucessPopUp.ShowPopUp();
            requestList = repository.GetAll();
            requestList = repository.LINQ_GetListByApproverId(requestList, userModel.Id);
            view.ShowAllRequestList(requestList);

        }

        private void Dialog_Approve(object sender, EventArgs e)
        {
            // Get thumb/ticket ID from row 
            DataGridViewRow selectedRow = view.DataGridViewRequest.CurrentRow;
            int id = int.Parse(selectedRow.Cells[0].Value.ToString());
            RequestModel requestModel = repository.LINQ_GetModelById(requestList, id);

            ICalendarRepository calendarRepository = new CalendarRepository();
            IEnumerable<CalendarModel> calendarList = calendarRepository.GetAll();

            IEnumerable<CalendarModel> calendarRequestList = calendarRepository.LINQ_GetListByRequestId(calendarList, requestModel.Id);

            foreach (CalendarModel calendarModel in calendarRequestList)
            {
                if (requestModel.Type == "Calendar")
                {
                    calendarModel.Status = "Approved";
                    calendarRepository.Update(calendarModel);
                }
                else
                {
                    calendarModel.Status = requestModel.Type;
                    calendarRepository.Update(calendarModel);
                }      
            }

            requestModel.Status = 1;
            repository.Update(requestModel);

            RequestDialog dialog = sender as RequestDialog;
            dialog.Close();

            // Show table
            SucessPopUp.ShowPopUp();
            requestList = repository.GetAll();
            requestList = repository.LINQ_GetListByApproverId(requestList, userModel.Id);
            view.ShowAllRequestList(requestList);
        }
    }
}
