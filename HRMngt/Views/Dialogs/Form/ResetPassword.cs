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

        private void kryptonLabel1_Paint(object sender, PaintEventArgs e)
        {

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
            if(txtNewPassword.Text == password)
            {
                SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=HR;Integrated Security=True;Encrypt=False");
                
                string query = "UPDATE users SET password = @NewPassword WHERE email = @Email";
                using (SqlConnection connection = conn)
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@NewPassword", password);
                        cmd.Parameters.AddWithValue("@Email", email);

                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        
                    }
                }
                MessageBox.Show("Mật khẩu cập nhật thành công -_-");
                LoginView login = new LoginView();
                this.Hide();
                login.ShowDialog();
                

            }
            else
            {
                MessageBox.Show("Bạn nhập sai mật khẩu -_-");
            }
            
        }
    }
}
