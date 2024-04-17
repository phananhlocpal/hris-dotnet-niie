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

namespace HRMngt.Views.Dialogs
{
    public partial class IndividualCalendarDialogForAdding : Form, IIndividualCalendarDialogForAdding
    {
        public IndividualCalendarDialogForAdding()
        {
            InitializeComponent();
            DateTime date = dtpDate.Value.Date;
            DateTime startDateTime = date.AddHours(8);
            dtpStart.Value = startDateTime;

            btnCreate.Click += delegate { CreateEvent?.Invoke(this, EventArgs.Empty); };
        }
        public event EventHandler CreateEvent;

        public CalendarModel getCalendarInfo()
        {
            CalendarModel calendarModel = new CalendarModel();

            // Lấy ngày từ dtpDate, giữ nguyên giờ
            calendarModel.Date = dtpDate.Value.Date + dtpStart.Value.TimeOfDay;

            // Lấy giờ từ dtpStart và gán vào CheckIn
            calendarModel.CheckIn = dtpStart.Value.TimeOfDay;

            // Lấy giờ từ dtpEnd và gán vào CheckOut
            calendarModel.CheckOut = dtpEnd.Value.TimeOfDay;

            return calendarModel;
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            dtpEnd.Value = dtpStart.Value.AddHours(8);
        }
    }
}
