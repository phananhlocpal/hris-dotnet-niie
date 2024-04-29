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
        public string userId 
        {
            get => lblUserId.Text.ToString();
            set => lblUserId.Text = value; 
        }
        public string userName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string userDepartment { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        private DateTime _date; // Biến tạm để lưu trữ giá trị DateTime
        private TimeSpan _checkin;
        private TimeSpan _checkout;
        private TimeSpan? _realCheckin;
        private TimeSpan? _realCheckout;
        public DateTime date
        {
            get => _date;
            set
            {
                _date = value;
                lblDateDetail.Text = _date.ToString();
            }
        }

        public TimeSpan checkIn 
        {
            get => _checkin;
            set
            {
                _checkin = value;
                DateTime dateTime = new DateTime(_date.Year, _date.Month, _date.Day, _checkin.Hours, _checkin.Minutes, _checkin.Seconds);
                dtpStart.Value = dateTime;
            }
        }
        public TimeSpan checkOut 
        {
            get => _checkout;
            set
            {
                _checkout = value;
                DateTime dateTime = new DateTime(_date.Year, _date.Month, _date.Day, _checkout.Hours, _checkout.Minutes, _checkout.Seconds);
                dtpStart.Value = dateTime;
            }
        }
        public TimeSpan? realCheckIn
        {
            get
            {
                if (dtpCheckIn.Enabled == true)
                    return _realCheckin;
                else
                    return null;
            }
            set
            {
                if (value != null)
                {
                    _realCheckin = value.Value; // Lấy giá trị thực sự từ nullable TimeSpan
                    DateTime dateTime = new DateTime(_date.Year, _date.Month, _date.Day, _realCheckin.Value.Hours, _realCheckin.Value.Minutes, _realCheckin.Value.Seconds);
                    dtpCheckIn.Value = dateTime;
                }
                else dtpCheckIn.Enabled = false;
            }
        }

        public TimeSpan? realCheckOut 
        {
            get
            {
                if (dtpCheckOut.Enabled == true)
                    return _realCheckout;
                else
                    return null;
            }
            set
            {
                if (value != null)
                {
                    _realCheckout = value.Value; // Lấy giá trị thực sự từ nullable TimeSpan
                    DateTime dateTime = new DateTime(_date.Year, _date.Month, _date.Day, _realCheckout.Value.Hours, _realCheckout.Value.Minutes, _realCheckout.Value.Seconds);
                    dtpCheckOut.Value = dateTime;
                }
                else dtpCheckOut.Enabled = false;
            }
        }
        public string status 
        {
            get => lblStatusDetail.Text.ToString(); 
            set => lblStatusDetail.Text = value;
        }

        public IndividualCalendarDialogForEditting()
        {
            InitializeComponent();
            btnCreateUpdate.Click += delegate { UpdateEvent?.Invoke(this, EventArgs.Empty); };
        }
        public event EventHandler UpdateEvent;

        public void ShowCalendarInfo(CalendarModel calendarModel)
        {
            lblUserId.Text = calendarModel.UserId;
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
