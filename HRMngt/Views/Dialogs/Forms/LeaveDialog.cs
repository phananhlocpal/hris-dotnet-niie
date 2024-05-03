using HRMngt.Models;
using HRMngt.Views.Dialogs.Interfaces;
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
    public partial class LeaveDialog : Form, ILeaveDialog
    {
        ComboBox ILeaveDialog.cmbLeaveType => cmbLeaveType;

        public string leaveDesription
        {
            get => rtbLeaveDescription.Text; set
            {
                rtbLeaveDescription.Text = value;
            }
        }

        public LeaveDialog()
        {
            InitializeComponent();
            lblDays.Text = "1";
            RunEvent();
        }

        private void RunEvent()
        {
            btnSubmit.Click += delegate { SubmitEvent?.Invoke(this, EventArgs.Empty); };
            cmbLeaveType.SelectedIndexChanged += delegate { ShowLeaveDescription?.Invoke(this, EventArgs.Empty); };
        }

        void ILeaveDialog.ShowDialog()
        {
            this.ShowDialog();
        }

        public event EventHandler SubmitEvent;
        public event EventHandler ShowLeaveDescription;

        private void CalculateDays(object sender, EventArgs e)
        {
            DateTime startDate = dtpStart.Value;
            DateTime endDate = dtpEnd.Value;

            int days = (endDate - startDate).Days + 1;
            lblDays.Text = days.ToString();
        }

        public IEnumerable<CalendarModel> GetLeaveInfo(UserModel userModel)
        {
            List<CalendarModel> leaveRegisterList = new List<CalendarModel>();
            DateTime startDate = dtpStart.Value;
            DateTime endDate = dtpEnd.Value;

            // Tạo các đối tượng CalendarModel cho mỗi ngày từ startDate đến endDate
            for (DateTime date = startDate.Date; date <= endDate.Date; date = date.AddDays(1))
            {
                CalendarModel calendarModel = new CalendarModel
                {
                    UserId = userModel.Id,
                    CheckIn = new TimeSpan(8, 0, 0), // 8:00:00
                    CheckOut = new TimeSpan(17, 0, 0), // 17:00:00
                    Date = date,
                };
                leaveRegisterList.Add(calendarModel);
            }

            return leaveRegisterList;
        }

    }
}
