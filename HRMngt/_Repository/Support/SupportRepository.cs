using HRMngt.Views.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRMngt.Models;
using System.Data.SqlClient;

namespace HRMngt._Repository.Support
{
    public class SupportRepository : ISupportRepository
    {
        private string connectionString = BaseRepository.connectionString;

        public SupportRepository()
        {

        }

        public void Back()
        {
            throw new NotImplementedException();
        }

        public void Send(string message, string email)
        {
            string from, pass, messageBody;
            MailMessage mailMessage = new MailMessage();
            string to = "h2ltcdeveloper@gmail.com";
            from = email;
            pass = "uzmf nvjj nntl jnqm";
            messageBody = message;
            mailMessage.To.Add(to);
            mailMessage.From = new MailAddress(from);
            mailMessage.Body = messageBody;
            mailMessage.Subject = "Đơn hỗ trợ";
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Port = 587;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtpClient.Send(mailMessage);
                MessageBox.Show("Đơn đã được gửi thành công -_-");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
