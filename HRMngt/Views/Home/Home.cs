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
            RunEvent();
        }
        private void RunEvent()
        {
            btnCheckout.Click += delegate { 
                LoadToAddCalandar?.Invoke(this, EventArgs.Empty);
                btnCheckin.Visible = true;
                btnCheckout.Visible = false;
                lbClick.Text = "Click To Leave";
            };
            btnCheckin.Click += delegate { 
                LoadToAddCalandar?.Invoke(this, EventArgs.Empty);
                btnCheckout.Visible = true;
                btnCheckin.Visible = false;
                lbClick.Text = "Click To Attendance";
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
            lbName.Text = navName;
        }
        public CheckinDialog ShowCheckInDialog()
        {
            CheckinDialog checkin = new CheckinDialog();
            return checkin;
        }

        public void ShowCheckoutDialog()
        {
            throw new NotImplementedException();
        }
    }
}
