using ComponentFactory.Krypton.Toolkit;
using HRMngt.Models;
using HRMngt.Views;
using Microsoft.VisualBasic.ApplicationServices;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace HRMngt.View
{
    public partial class MainView : Form, IMainView
    {       
        
        public MainView()
        {
            InitializeComponent();
            RunEvent();
           

        }
        public event EventHandler ShowDepartmentView;
        public event EventHandler ShowThumbTicketView;
        public event EventHandler ShowHomeView;
        public event EventHandler ShowUserView;
        public event EventHandler ShowSupportView;
        public event EventHandler ShowSalaryView;
        public event EventHandler ShowLoginEvent;
        public event EventHandler ShowRecuitView;
        public event EventHandler ShowTimeKeepingView;
        public event EventHandler ShowIndividualSalaryView;
        public event EventHandler ShowMainIndividualView;
        public event EventHandler ShowCommunicateView;
        public event EventHandler ShowRequestView;

        public void RunEvent()
        {
            picNavAva.Click += delegate { ShowMainIndividualView?.Invoke(this, EventArgs.Empty); };
            btnDepartment.Click += delegate { ShowDepartmentView?.Invoke(this, EventArgs.Empty); };
            btnEmployee.Click += delegate { ShowUserView?.Invoke(this, EventArgs.Empty); };
            btnHome.Click += delegate { ShowHomeView?.Invoke(this, EventArgs.Empty); };
            btnHelp.Click += delegate { ShowSupportView?.Invoke(this, EventArgs.Empty); };
            btnSalary.Click += delegate { ShowSalaryView?.Invoke(this, EventArgs.Empty); };
            btnHiring.Click += delegate { ShowRecuitView?.Invoke(this, EventArgs.Empty); };
            btnTimeKeeping.Click += delegate { ShowTimeKeepingView?.Invoke(this, EventArgs.Empty); };
            btnMessage.Click += delegate { ShowCommunicateView?.Invoke(this, EventArgs.Empty); };
            btnRequest.Click += delegate { ShowRequestView?.Invoke(this, EventArgs.Empty); };
        }
        private void MainView_Load(object sender, EventArgs e)
        {
            ShowHomeView?.Invoke(this, EventArgs.Empty);
        }

 
        // Phân quyền
        public void ShowUserInformation(UserModel userModel)
        {
            if (userModel.Roles == "Admin" || userModel.Roles == "HR")
            {

            }
            else if (userModel.Roles == "Manager")
            {
                pnlSalary.Hide();
                pnlHire.Hide();
                pnlTimeKeeping.Hide();
            }   
            else
            {

            }
            lblNavName.Text = userModel.Name;
        }


        private void txtNavSearch_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtNavSearch.Text == "Nhập tìm kiếm của bạn ...")
            {
                txtNavSearch.Text = "";
                txtNavSearch.ForeColor = Color.Black;
            }

        }
        private void txtNavSearch_Leave(object sender, EventArgs e)
        {
            if (txtNavSearch.Text == "")
            {
                txtNavSearch.Text = "Nhập tìm kiếm của bạn ...";
                txtNavSearch.ForeColor = Color.Black;
            }
        }

    }
}
