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
    public partial class AttendanceDialog : Form
    {
        public string label1 { get => lb1.Text; set => lb1.Text = value; }
        public string label2 { get => lb2.Text; set => lb2.Text = value; }
        public string label3 { get => lb3.Text; set => lb3.Text = value; }
        private string type;

        public AttendanceDialog()
        {
            InitializeComponent();

            TimeSpan checkInStart = new TimeSpan(0, 0, 0); // 0:00:00
            TimeSpan checkInEnd = new TimeSpan(8, 15, 0); // 8:15:00
            TimeSpan checkOutStart = new TimeSpan(17, 0, 0); // 17:00:00
            TimeSpan checkOutEnd = new TimeSpan(24, 0, 0); // 24:00:00 (tương đương với 0:00:00 của ngày hôm sau)

            TimeSpan now = DateTime.Now.TimeOfDay;

            string checkType;

            if (now >= checkInStart && now <= checkInEnd)
            {
                type = "checkin";
            }
            else if (now >= checkOutStart && now <= checkOutEnd)
            {
                type = "checkout";
            }

            RunEvent();
        }

        private void RunEvent()
        {
            if (type == "checkin") 
                btnConfirm.Click += delegate { CheckinEvent?.Invoke(this, EventArgs.Empty); };
            else btnConfirm.Click += delegate { CheckoutEvent?.Invoke(this, EventArgs.Empty); };

        }
        public event EventHandler CheckinEvent;
        public event EventHandler CheckoutEvent;

    }
}
