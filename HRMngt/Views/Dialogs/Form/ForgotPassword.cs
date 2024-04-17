using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMngt.Views.Dialogs
{
    public partial class ForgotPassword : Form
    {
        string randomCode;
        public static string to;
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string from, pass, messageBody;
            Random random = new Random();
            randomCode = (random.Next(10000, 99999)).ToString();
            MailMessage mailMessage = new MailMessage();
            to = (txtEmail.Text).ToString();
            from = "h2ltcdeveloper@gmail.com";
            pass = "uzmf nvjj nntl jnqm";
            messageBody = $"Mã Đặt Lại Mật Khẩu Là {randomCode}";
            mailMessage.To.Add(to);
            mailMessage.From = new MailAddress(from);
            mailMessage.Body = messageBody;
            mailMessage.Subject = "Mã OTP Đặt Lại Mật Khẩu";
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Port = 587;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtpClient.Send(mailMessage);
                MessageBox.Show("Mã OTP đã được gửi thành công -_-");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }

        private void btnComfirm_Click(object sender, EventArgs e)
        {
            if(randomCode == (txtOTP.Text).ToString())
            {
                to = txtEmail.Text;
                ResetPassword reset = new ResetPassword();
                this.Hide();
                reset.ShowDialog();

            }
            else
            {
                MessageBox.Show("Mã OTP không đúng! Vui lòng nhập lại -_-");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LoginView login = new LoginView();
            this.Hide();
            login.ShowDialog();
        }
    }       
}
