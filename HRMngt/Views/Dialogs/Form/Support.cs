using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace HRMngt.Views.Dialogs
{
    public partial class Support : Form, ISupport
    {
        public Support()
        {
            InitializeComponent();
            RunEvent();
        }

        KryptonButton ISupport.btnSend { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        KryptonButton ISupport.btnBack { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string content { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void RunEvent()
        {
            btnSend.Click += delegate { Send?.Invoke(this, EventArgs.Empty); };
            btnOut.Click += delegate { Back?.Invoke(this, EventArgs.Empty); };
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private static Support instance;

        public event EventHandler Send;
        public event EventHandler Back;

        public static Support GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new Support();
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

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();

                message.From = new MailAddress("h2ltcdeveloper@gmail.com");
                message.To.Add(new MailAddress(txtEmail.Text)); // Email người nhận

                message.Subject = "Đơn khiếu nại";
                message.Body = txtContent.Text;

                smtp.Port = 587; // Port của SMTP server (thường là 587 hoặc 465)
                smtp.Host = "smtp.gmail.com"; // Địa chỉ SMTP server (ví dụ: smtp.gmail.com)
                smtp.EnableSsl = true; // Sử dụng SSL/TLS để bảo mật kết nối
                smtp.UseDefaultCredentials = false; // Không sử dụng thông tin đăng nhập mặc định
                smtp.Credentials = new System.Net.NetworkCredential("h2ltcdeveloper@gmail.com", "jrww zlwq mggj mney"); // Thông tin đăng nhập vào Email

                smtp.Send(message);
                MessageBox.Show("Email đã được gửi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
