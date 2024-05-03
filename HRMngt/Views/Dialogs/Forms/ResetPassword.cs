using HRMngt._Repository;
using HRMngt.Models;
using HRMngt.Presenters;
using HRMngt.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMngt.Views.Dialogs
{
    public partial class ResetPassword : Form
    {
        
        public ResetPassword()
        {
            InitializeComponent();
        }

        

        private void btnBack_Click(object sender, EventArgs e)
        {
            ForgotPassword forgot = new ForgotPassword();
            this.Hide();
            forgot.Show();
        }

        private void btnSuccess_Click(object sender, EventArgs e)
        {
            string email = ForgotPassword.to;
            string password = txtComfirmPassword.Text;
            string salt = BCrypt.Net.BCrypt.GenerateSalt();
            string hash = BCrypt.Net.BCrypt.HashPassword(password, salt);
            if (txtNewPassword.Text == password)
            {
                SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=hris;Integrated Security=True;Encrypt=False");
                
                string query = "UPDATE users SET password = @NewPassword WHERE email = @Email";
                using (SqlConnection connection = conn)
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@NewPassword", hash);
                        cmd.Parameters.AddWithValue("@Email", email);

                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        
                    }
                }
                MessageBox.Show("Mật khẩu cập nhật thành công -_-");
                ILoginView view = new LoginView();
                IUserRepository repository = new UserRepository();
                new LoginPresenter(view, repository);
                this.Close();



            }
            else
            {
                MessageBox.Show("Bạn nhập sai mật khẩu -_-");
            }
            
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
