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
        public static int count = 0;
        public event EventHandler LoginEvent;
        List<Image> images = new List<Image>();
        string[] location = new string[25];
        private string firstString = "C:\\Users\\Surface\\source\\repos\\hris-dotnet-niie";

        public string username { get => txtUserName.Text; set => txtUserName.Text = value; }
        public string password { get => txtPassword.Text; set => txtPassword.Text = value; }

        

        public LoginView()
        {
            InitializeComponent();
            
            location[0] = @"\animation\textbox_user_1.jpg";
            location[1] = @"\animation\textbox_user_2.jpg";
            location[2] = @"\animation\textbox_user_4.jpg";
            location[3] = @"\animation\textbox_user_5.jpg";
            location[4] = @"\animation\textbox_user_6.jpg";
            location[5] = @"\animation\textbox_user_7.jpg";
            location[6] = @"\animation\textbox_user_8.jpg";
            location[7] = @"\animation\textbox_user_9.jpg";
            location[8] = @"\animation\textbox_user_10.jpg";
            location[9] = @"\animation\textbox_user_11.jpg";
            location[10] = @"\animation\textbox_user_12.jpg";
            location[11] = @"\animation\textbox_user_13.jpg";
            location[12] = @"\animation\textbox_user_14.jpg";
            location[13] = @"\animation\textbox_user_15.jpg";
            location[14] = @"\animation\textbox_user_16.jpg";
            location[15] = @"\animation\textbox_user_17.jpg";
            location[16] = @"\animation\textbox_user_18.jpg";
            location[17] = @"\animation\textbox_user_19.jpg";
            location[18] = @"\animation\textbox_user_20.jpg";
            location[19] = @"\animation\textbox_user_21.jpg";
            location[20] = @"\animation\textbox_user_22.jpg";
            location[21] = @"\animation\textbox_user_23.jpg";
            location[22] = @"\animation\textbox_user_24.jpg";
            tounage();
            RunEvent();

        }
        public void RunEvent()
        {
            btnLogin.Click += delegate {
                LoginEvent?.Invoke(this, EventArgs.Empty);
                count++;
            };
        }
        private void lbForgotPass_Click(object sender, EventArgs e)
        {
            ForgotPassword forgot = new ForgotPassword();
            this.Hide();
            forgot.ShowDialog();
        }

        public void EnableLogin(bool type = true)
        {
            txtUserName.Enabled = type;
            txtPassword.Enabled = type;
            btnLogin.Enabled = type;
        }
         

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void hidePassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '•')
            {
                showPassword.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }
        private void showPassword_Click(object sender, EventArgs e)
        {
            
            if (txtPassword.PasswordChar == '\0')
            {
                hidePassword.BringToFront();
                txtPassword.PasswordChar = '•';
            }
        }
        private void tounage()
        {
            for (int i = 0; i < 23; i++)
            {
                Bitmap bitmap = new Bitmap(firstString + location[i]);
                images.Add(bitmap);
            }
            images.Add(Properties.Resources.textbox_user_24);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtUserName.Text.Length > 0 && txtUserName.Text.Length <= 15)
            {
                picture.Image = images[txtUserName.Text.Length - 1];
                picture.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else if (txtUserName.Text.Length <= 0)
                picture.Image = Properties.Resources.debut;
            else
                picture.Image = images[22];
        }
        private void textBox2_Click(object sender, EventArgs e)
        {
            Bitmap bmpass = new Bitmap(firstString + @"\animation\textbox_password.png");
            picture.Image = bmpass;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Length > 0)
                picture.Image = images[txtUserName.Text.Length - 1];
            else
                picture.Image = Properties.Resources.debut;

        }
        private void bunifuPictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
