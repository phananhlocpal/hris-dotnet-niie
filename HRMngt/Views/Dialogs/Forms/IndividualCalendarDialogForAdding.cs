using HRMngt.Models;
using HRMngt.popup;
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
            DateTime date = dtpChooseWeek.Value.Date;
            DateTime startDateTime = date.AddHours(8);

            dtpChooseWeek.ValueChanged += ChangeListDate;
            btnCreate.Click += delegate { CreateEvent?.Invoke(this, EventArgs.Empty); };
        }

        private void ChangeListDate(object sender, EventArgs e)
        {
            ShowListDate();
        }

        public event EventHandler CreateEvent;

        public void ShowListDate()
        {
            DateTime selectedWeek = dtpChooseWeek.Value;
            DateTime startOfWeek = selectedWeek.AddDays(-(int)selectedWeek.DayOfWeek);
            DateTime endOfWeek = startOfWeek.AddDays(6);

            clbChooseDate.Items.Clear();
            for (DateTime date = startOfWeek; date <= endOfWeek; date = date.AddDays(1))
            {
                string item = date.ToString("ddd dd/MM/yyyy") + " 08:00:00 - 17:00:00";
                clbChooseDate.Items.Add(item);
            }
        }

        public IEnumerable<CalendarModel> getCalendarInfo()
        {
            List<CalendarModel> calendarList = new List<CalendarModel>();

            foreach (object item in clbChooseDate.CheckedItems)
            {
                string[] parts = ((string)item).Split(' ');
                string dateString = parts[1];
                string[] dateParts = dateString.Split('/');

                // Giải phóng không gian cho các biến day, month, year để chứa các phần tử được chia
                string day = dateParts[0];
                string month = dateParts[1];
                string year = dateParts[2];

                // Sử dụng các phần tử chia được để tạo đối tượng DateTime
                DateTime date;
                if (DateTime.TryParse($"{year}-{month}-{day}", out date))
                {
                    TimeSpan checkIn = TimeSpan.Parse(parts[2]);
                    TimeSpan checkOut = TimeSpan.Parse(parts[4]);

                    CalendarModel calendarModel = new CalendarModel
                    {
                        Date = date,
                        CheckIn = checkIn,
                        CheckOut = checkOut
                    };
                    calendarList.Add(calendarModel);
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra!");
                    FailPopUp.ShowPopUp();
                }
            }

            return calendarList;
        }


    }
}
