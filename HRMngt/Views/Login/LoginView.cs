using HRMngt.Model;
using HRMngt.Presenters;
using HRMngt.View;
using HRMngt.Views.Dialogs;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HRMngt.Views
{
    public partial class LoginView : Form, ILoginView
    {
        SqlCommand cmd;
        SqlConnection conn;
        SqlDataReader dr;
        public event EventHandler LoginEvent;

        public string username { get => txtUserName.Text; set => txtUserName.Text = value; }
        public string password { get => txtPassword.Text; set => txtPassword.Text = value; }

        public LoginView()
        {
            InitializeComponent();
            RunEvent();
        }
        public void RunEvent()
        {
            btnLogin.Click += delegate {LoginEvent?.Invoke(this, EventArgs.Empty); };
        }
        private void lbForgotPass_Click(object sender, EventArgs e)
        {
            ForgotPassword forgot = new ForgotPassword();
            this.Hide();
            forgot.ShowDialog();
        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxShowPass.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            if(!checkBoxShowPass.Checked) {
                txtPassword.UseSystemPasswordChar = false;
            }
        }
    }
}
