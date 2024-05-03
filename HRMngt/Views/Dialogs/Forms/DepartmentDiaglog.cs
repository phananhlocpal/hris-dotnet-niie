using HRMngt.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMngt.Views.Dialogs
{
    public partial class DepartmentDiaglog : Form, IDepartmentDialog
    {
        private string type;
        public DepartmentDiaglog(string type)
        {
            this.type = type;
            InitializeComponent();
            if (type == "Thêm")
            {
                lblTitle.Text = "Tạo phòng ban";
                btnAdd.Text = "Thêm";
            }
            else if (type == "Sửa")
            {
                lblTitle.Text = "Cập nhật phòng ban";
                btnAdd.Text = "Sửa";

            }
            nameManageer_Selected_Changed();
            RunEvent();
        }

        public string DepartmentID { get => lbID.Text; set => lbID.Text = value; }
        public string DepartmentName { get => txtNameDepartment.Text; set => txtNameDepartment.Text = value; }
        public string Phone { get => txtPhone.Text; set => txtPhone.Text = value; }
        public string Manager
        {
            get
            {
                if (cbManager.SelectedItem == null || cbManager.SelectedItem.ToString() == "")
                    return "";
                else return ExtractIdFromName(cbManager.SelectedItem.ToString());
            }
            set
            {
                int index = cbManager.FindStringExact(value);
                if (index != -1)
                    cbManager.SelectedIndex = index;
            }

        }
        public string Address { get => txtAddress.Text; set => txtAddress.Text = value; }


        public event EventHandler AddNewDepartmentDialog;
        public event EventHandler EditDepartmentDialog;

        public void RunEvent()
        {
            if (btnAdd.Text == "Thêm")
            {
                btnAdd.Click += delegate { AddNewDepartmentDialog?.Invoke(this, EventArgs.Empty); };
            }
            else if (btnAdd.Text == "Sửa")
            {
                btnAdd.Click += delegate { EditDepartmentDialog?.Invoke(this, EventArgs.Empty); };
            }

        }



        private void nameManageer_Selected_Changed()
        {
            string pos = "Admin";
            string connectionString = "Data Source=localhost;Initial Catalog=hris;Integrated Security=True;Encrypt=False";
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();

                command.Connection = connection;
                command.CommandText = "Select userID, name from users where role = @Pos";
                command.Parameters.Add("@Pos", SqlDbType.Char).Value = pos;
                List<string> items = new List<string>();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        items.Add($"{reader[0]} - {reader[1]}");
                    }
                }
                cbManager.DataSource = items;
                cbManager.DisplayMember = "Name";
                cbManager.Refresh();
                connection.Close();
            }
        }

        public string ExtractIdFromName(string nameWithId)
        {
            if (!string.IsNullOrEmpty(nameWithId))
            {
                string[] parts = nameWithId.Split('-');
                string id = parts[0].Trim();
                return id;
            }
            else
            {
                return null;
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
