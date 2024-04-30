using HRMngt.Models;
using HRMngt.Views.Dialogs;
using HRMngt.Views.User;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMngt.Views
{
    public partial class Home : Form, IHomeView
    {
        
        public Home()
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
                btnCheckin.Visible = true;
                btnCheckout.Visible = false;
            }
            else if (now >= checkOutStart && now <= checkOutEnd)
            {
                btnCheckin.Visible = false;
                btnCheckout.Visible = true;
            }
            else
            {
                btnCheckin.Visible = false;
                btnCheckout.Visible = false;
            }
            RunEvent();
        }
        private void RunEvent()
        {
            btnCheckout.Click += delegate { 
                LoadToAddCalandar?.Invoke(this, EventArgs.Empty);
                lbClick.Text = "Click to leave";
            };
            btnCheckin.Click += delegate { 
                LoadToAddCalandar?.Invoke(this, EventArgs.Empty);
                lbClick.Text = "Click to check attendance";
            };
        }
        private static Home instance;

        public event EventHandler LoadToAddCalandar;

        public static Home GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new Home();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }

        public void ShowNavName(string navName)
        {
            lblWelcome.Text = "Welcome " + navName + "!";
        }
        public AttendanceDialog ShowAttendanceDialog()
        {
            AttendanceDialog checkin = new AttendanceDialog();
            return checkin;
        }
    }
}
