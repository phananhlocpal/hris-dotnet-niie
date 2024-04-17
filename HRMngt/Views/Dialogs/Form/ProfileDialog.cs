using HRMngt.Model;
using HRMngt.View;
using Microsoft.VisualBasic.ApplicationServices;
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

namespace HRMngt.Views
{
    public partial class ProfileDialog : Form, IProfileView
    {
        private UserModel currentUser;
        public ProfileDialog(UserModel user)
        {
            currentUser = user;
            InitializeComponent();
            ShowProfile();
        }
        public string userID { get => lbID.Text; set => lbID.Text = value; }
        public string name { get => txtFullname.Text; set => txtFullname.Text = value; }
        public string email { get => txtEmail.Text; set => txtEmail.Text = value; }
        public string phone { get => txtPhone.Text; set => txtPhone.Text = value; }
        public string address { get => txtAddress.Text; set => txtAddress.Text = value; }
        public string sex { get => txtSex.Text; set => txtSex.Text = value; }
        public string position { get => txtPosition.Text; set => txtPosition.Text = value; }


        public void ShowUserList(IEnumerable<UserModel> userList)
        {
            if (userList != null)
            {
                foreach (var user in userList)
                {
                    lbID.Text = user.Id;
                    txtFullname.Text = user.Name;
                    txtEmail.Text = user.Email;
                    txtPhone.Text = user.Phone;
                    txtAddress.Text = user.Address;
                    txtSex.Text = user.Sex;
                    txtPosition.Text = user.Position;
                }
            }
        }
        public void ShowProfile()
        {
            string connectionString = "Data Source=localhost;Initial Catalog=HR;Integrated Security=True;Encrypt=False;";
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from users where userID = @Id";
                command.Parameters.Add("@Id", SqlDbType.Char).Value = currentUser.Id;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lbID.Text = reader[0].ToString();
                        txtFullname.Text = reader[1].ToString();
                        txtEmail.Text = reader[2].ToString();
                        txtPhone.Text = reader[3].ToString();
                        txtAddress.Text = reader[4].ToString();
                        txtSex.Text = reader[17].ToString();
                        txtPosition.Text = reader[19].ToString();
                    }
                }
                connection.Close();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginView login = new LoginView();
            this.Close();
            login.ShowDialog();
             
        }
    }
}
