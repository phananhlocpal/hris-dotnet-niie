using HRMngt.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMngt.Views.Dialogs
{
    public partial class IndividualCalendarDialogForEditting : Form, IIndividualCalendarDialogForEditting
    {
        public IndividualCalendarDialogForEditting()
        {
            InitializeComponent();
            btnCreateUpdate.Click += delegate { UpdateEvent?.Invoke(this, EventArgs.Empty); };
        }
        public event EventHandler UpdateEvent;

        public void ShowCalendarInfo(CalendarModel calendarModel)
        {
            lblDateDetail.Text = calendarModel.Date.ToString("dd/MM/yyyy");
            dtpStart.Value = dtpStart.Value.Date + calendarModel.CheckIn;
            dtpEnd.Value = dtpStart.Value.Date + calendarModel.CheckOut;
            if (calendarModel.RealCheckIn.HasValue && calendarModel.RealCheckIn != null)
                dtpCheckIn.Value = (DateTime)(dtpStart.Value.Date + calendarModel.RealCheckIn);
            else dtpCheckIn.Hide();
            if (calendarModel.RealCheckOut != null)
                dtpCheckOut.Value = (DateTime)(dtpStart.Value.Date + calendarModel.RealCheckOut);
            else dtpCheckOut.Hide();
            lblStatusDetail.Text = calendarModel.Status.ToString();
        }

        public CalendarModel GetUpdatedInfo()
        {
            CalendarModel calendarModel = new CalendarModel();
            DateTime date;
            if (DateTime.TryParseExact(lblDateDetail.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            {
                calendarModel.Date = date;
            }
            else
            {
                // Handle the case where lblDateDetail.Text is not in the expected format
            }
            calendarModel.CheckIn = dtpStart.Value.TimeOfDay;
            calendarModel.CheckOut = dtpEnd.Value.TimeOfDay;
            calendarModel.RealCheckIn = dtpCheckIn.Value.TimeOfDay;
            calendarModel.RealCheckOut = dtpCheckOut.Value.TimeOfDay;
            calendarModel.Status = lblStatusDetail.Text;
            return calendarModel;
        }
    }
}
