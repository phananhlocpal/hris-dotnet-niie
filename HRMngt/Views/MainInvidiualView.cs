using HRMngt.Models;
using HRMngt.Views;
using ReaLTaiizor.Controls;
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
using System.Web.UI;
using System.Windows.Forms;


namespace HRMngt.View
{
    public partial class MainInvidiualView : Form, IMainIndividualView
    {
        private UserModel currentUser;
        public string ID { get => lblUserId.Text; set => lblUserId.Text = value; }
        public string NameIndividual { get => lblIndividualName.Text; set => lblIndividualName.Text = value; }
        public string Status { get => lblStatus.Text; set => lblStatus.Text = value; }
        public string Email { get => lblEmailInfo.Text; set => lblEmailInfo.Text = value; }
        public string Phone { get => lblPhoneInfo.Text; set => lblPhoneInfo.Text = value; }
        public string Department { get => lblDepartmentInfo.Text; set => lblDepartmentInfo.Text = value; }
        public string Sex { get => lblGender.Text; set => lblGender.Text = value; }

        public MainInvidiualView(UserModel user)
        {
            currentUser = user;
            InitializeComponent();
            lblNavName.Text = currentUser.Name;
            btnThumbTicket.Click += delegate
            {
                ShowThumbTicketView?.Invoke(this, EventArgs.Empty);
                btnThumbTicket.ForeColor = Color.FromArgb(69, 158, 26);
                panel4.BackColor = Color.FromArgb(69, 158, 26);
                btnCalendar.ForeColor = Color.FromArgb(111, 111, 111);
                panel2.BackColor = Color.White;
                btnSalaryDetail.ForeColor = Color.FromArgb(111, 111, 111);
                panel3.BackColor = Color.White;
            };
            btnSalaryDetail.Click += delegate
            {
                ShowIndividualSalaryView?.Invoke(this, EventArgs.Empty);
                btnThumbTicket.ForeColor = Color.FromArgb(111, 111, 111);
                panel4.BackColor = Color.White;
                btnCalendar.ForeColor = Color.FromArgb(111, 111, 111);
                panel2.BackColor = Color.White;
                btnSalaryDetail.ForeColor = Color.FromArgb(69, 158, 26);
                panel3.BackColor = Color.FromArgb(69, 158, 26); ;
            };
            btnCalendar.Click += delegate
            {
                ShowIndividualCalendarView?.Invoke(this, EventArgs.Empty);
                btnThumbTicket.ForeColor = Color.FromArgb(111, 111, 111);
                panel4.BackColor = Color.White;
                btnCalendar.ForeColor = Color.FromArgb(69, 158, 26);
                panel2.BackColor = Color.FromArgb(69, 158, 26);
                btnSalaryDetail.ForeColor = Color.FromArgb(111, 111, 111);
                panel3.BackColor = Color.White;
            };

            btnTimeKeeping.Click += delegate
            {
                ShowTimeKeepingView?.Invoke(this, EventArgs.Empty);
            };
            //ShowProfile();
        }

        private void MainIndividualView_Load(object sender, EventArgs e)
        {
            ShowIndividualCalendarView?.Invoke(this, EventArgs.Empty);
            btnThumbTicket.ForeColor = Color.FromArgb(111, 111, 111);
            panel4.BackColor = Color.White;
            btnCalendar.ForeColor = Color.FromArgb(69, 158, 26);
            panel2.BackColor = Color.FromArgb(69, 158, 26);
            btnSalaryDetail.ForeColor = Color.FromArgb(111, 111, 111);
            panel3.BackColor = Color.White;
        }

        

        public event EventHandler ShowThumbTicketView;
        public event EventHandler ShowIndividualSalaryView;
        public event EventHandler ShowIndividualCalendarView;
        public event EventHandler ShowTimeKeepingView;

        private void txtNavSearch_Leave(object sender, EventArgs e)
        {
            if (txtNavSearch.Text == "")
            {
                txtNavSearch.Text = "Nhập tìm kiếm của bạn ...";
                txtNavSearch.ForeColor = Color.DimGray;
            }
        }

        private void txtNavSearch_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (txtNavSearch.Text == "Nhập tìm kiếm của bạn ...")
            {
                txtNavSearch.Text = "";
                txtNavSearch.ForeColor = Color.Black;
            }
        }

        private void picLogo_Click(object sender, EventArgs e)
        {
            

        }

        public void ShowUserList(IEnumerable<UserModel> userList)
        {
            if (userList != null)
            {
                foreach (var user in userList)
                {
                    lblIndividualName.Text = currentUser.Name;
                    lblUserId.Text = "Mã NV:" + currentUser.Id;
                    lblStatus.Text = "• " + currentUser.Status;
                    lblEmailInfo.Text = currentUser.Email;
                    lblPhoneInfo.Text = currentUser.Phone;
                    lblDepartmentInfo.Text = currentUser.DepartmentID;
                    lblGender.Text = currentUser.Sex;
                    if (currentUser.Status == "Đang làm")
                    {
                        lblStatus.ForeColor = Color.FromArgb(69, 158, 26);
                    }
                    else
                    {
                        lblStatus.ForeColor = Color.Red;
                    }
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
                        lblUserId.Text = "Mã NV:" + reader[0].ToString();
                        lblIndividualName.Text =  reader[1].ToString();
                        lblEmailInfo.Text = reader[2].ToString();
                        lblPhoneInfo.Text = reader[3].ToString();
                        lblGender.Text = reader[16].ToString();
                        lblStatus.Text = "• " + reader[17].ToString();
                        lblDepartmentInfo.Text = reader[10].ToString();
                        if (currentUser.Status == "Đang làm")
                        {
                            lblStatus.ForeColor = Color.FromArgb(69, 158, 26);
                        }
                        else
                        {
                            lblStatus.ForeColor = Color.Red;
                        }
                    }
                }
                connection.Close();
            }
        }
    }
}
