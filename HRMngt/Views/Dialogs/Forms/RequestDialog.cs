﻿using HRMngt._Repository;
using HRMngt._Repository.Calendar;
using HRMngt.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMngt.Views.Dialogs.Forms
{
    public partial class RequestDialog : Form, IRequestDialog
    {

        public RequestDialog()
        {
            InitializeComponent();
            RunEvent();
        }

        private void RunEvent()
        {
            btnApprove.Click += delegate { approveEvent?.Invoke(this, EventArgs.Empty); };
            btnNotApprove.Click += delegate { NotApproveEvent?.Invoke(this, EventArgs.Empty); };
        }

        public event EventHandler approveEvent;
        public event EventHandler NotApproveEvent;

        public void ShowRequestDetail(RequestModel requestModel)
        {
            // Get receiver and sender information 
            IUserRepository userRepository = new UserRepository();
            IEnumerable<UserModel> userList = userRepository.GetAll();
            UserModel receiver = userRepository.LINQ_GetModelById(userList, requestModel.Approver);
            UserModel sender = userRepository.LINQ_GetModelById(userList, requestModel.Sender);

            DataTable requestInfo = new DataTable(); // Create a DataTable to hold request information

            ICalendarRepository calendarRepository = new CalendarRepository();
            IEnumerable<CalendarModel> calendarList = calendarRepository.GetAll();
            IEnumerable<CalendarModel> calendarRequestList = calendarRepository.LINQ_GetListByRequestId(calendarList, requestModel.Id);

            // Get request information
            if (requestModel.Type == "Calendar")
            {
                // Add columns to the DataTable
                requestInfo.Columns.Add("Date");
                requestInfo.Columns.Add("CheckIn");
                requestInfo.Columns.Add("CheckOut");
                requestInfo.Columns.Add("Status");

                // Populate DataTable with calendar request information
                foreach (var calendarRequest in calendarRequestList)
                {
                    DataRow row = requestInfo.NewRow();
                    row["Date"] = calendarRequest.Date.ToString("yyyy-MM-dd");
                    row["CheckIn"] = calendarRequest.CheckIn.ToString();
                    row["CheckOut"] = calendarRequest.CheckOut.ToString();
                    row["Status"] = calendarRequest.Status;
                    requestInfo.Rows.Add(row);
                }
            }
            else if (requestModel.Type == "Leave 1" || requestModel.Type == "Leave 2" || requestModel.Type == "Leave 3" || requestModel.Type == "Leave 4")
            {
                // Add columns to the DataTable
                requestInfo.Columns.Add("Date");
                requestInfo.Columns.Add("Type");
                requestInfo.Columns.Add("Status");

                // Populate DataTable with calendar request information
                foreach (var calendarRequest in calendarRequestList)
                {
                    DataRow row = requestInfo.NewRow();
                    row["Date"] = calendarRequest.Date.ToString("yyyy-MM-dd");
                    if (requestModel.Type == "Leave 1") row["Type"] = "Nghỉ phép nguyên lương";
                    if (requestModel.Type == "Leave 2") row["Type"] = "Nghỉ việc riêng";
                    if (requestModel.Type == "Leave 3") row["Type"] = "Nghỉ lễ/tết";
                    if (requestModel.Type == "Leave 4") row["Type"] = "Nghỉ không lương";
                    row["Status"] = calendarRequest.Status;
                    requestInfo.Rows.Add(row);
                }
            }   
            
            // Display information
            lblType.Text = requestModel.Type;
            lblReceiver.Text = $"{receiver.Id} - {receiver.Name}";
            lblSender.Text = $"{sender.Id} - {sender.Name}";
            dgvDetailRequestTable.DataSource = requestInfo;
        }


    }
}