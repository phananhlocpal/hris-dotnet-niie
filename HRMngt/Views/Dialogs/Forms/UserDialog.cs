using HRMngt.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMngt.Views.Dialogs
{
    public partial class UserDialog : Form, IUserDialog
    {
        private string type;
        public UserDialog(string type)
        {
            this.type = type;
            InitializeComponent();
            if (type == "Thêm")
            {
                lblTitle.Text = "Thêm mới nhân viên";
                btnAdd.Text = "Thêm";
                txtPassword.ReadOnly = true;
            }
            else if (type == "Sửa")
            {
                lblTitle.Text = "Cập nhật nhân viên";
                btnAdd.Text = "Sửa";
                txtPassword.ReadOnly = false;
            }
            RunEvent();
        }

        public void RunEvent()
        {
            if (btnAdd.Text == "Thêm")
            {
                btnAdd.Click += delegate
                {
                    AddNewUserDialog?.Invoke(this, EventArgs.Empty);
                    SendPasswordToMail?.Invoke(this, EventArgs.Empty);
                };

            }
            else if (btnAdd.Text == "Sửa")
            {
                btnAdd.Click += delegate { EditUserDialog?.Invoke(this, EventArgs.Empty); };
            }
            txtPassword.Click += delegate { GenerateRandomPassword?.Invoke(this, EventArgs.Empty); };
            btnCancle.Click += delegate { CancleEvent?.Invoke(this, EventArgs.Empty); };
            txtUsername.Click += delegate { CheckConditionSalary?.Invoke(this, EventArgs.Empty); };
            txtPhone.Click += delegate { CheckConditionEmail?.Invoke(this, EventArgs.Empty); };
            txtEmail.Click += delegate { CheckConditionName?.Invoke(this, EventArgs.Empty); };
            txtSalary.Click += delegate { CheckConditionDate?.Invoke(this, EventArgs.Empty); };
            txtAddress.Click += delegate { CheckConditionPhone?.Invoke(this, EventArgs.Empty); };
            btnClear.Click += delegate { ClearResultEvent?.Invoke(this, EventArgs.Empty); };
        }

        public string ID { get => lbID.Text; set => lbID.Text = value; }
        public string Fullname { get => txtName.Text; set => txtName.Text = value; }
        public string Email { get => txtEmail.Text; set => txtEmail.Text = value; }
        public string Phone
        {
            get
            { return txtPhone.Text; }
            set
            {
                txtPhone.Text = value;
            }
        }
        public string Address { get => txtAddress.Text; set => txtAddress.Text = value; }
        public DateTime Birthday { get => birthday.Value; set => birthday.Value = value; }
        public string Sex { get => cbSex.Text; set => cbSex.Text = value; }
        public string Position { get => cbPosition.Text; set => cbPosition.Text = value; }
        public int Salary { get => int.Parse(txtSalary.Text); set => txtSalary.Text = value.ToString(); }
        public string Username { get => txtUsername.Text; set => txtUsername.Text = value; }
        public string Password { get => txtPassword.Text; set => txtPassword.Text = value; }
        public string ManagerID
        {
            get
            {
                if (cbManagerId.SelectedItem == null || cbManagerId.SelectedItem.ToString() == "")
                    return "";
                else return ExtractIdFromName(cbManagerId.SelectedItem.ToString());
            }
            set
            {
                int index = cbManagerId.FindStringExact(value);
                if (index != -1)
                    cbManagerId.SelectedIndex = index;
            }
        }
        public string DepartmentID
        {
            get
            {
                if (cbDepartmentId.SelectedItem == null || cbDepartmentId.SelectedItem.ToString() == "")
                    return "";
                else return ExtractIdFromName(cbDepartmentId.SelectedItem.ToString());
            }
            set
            {
                int index = cbDepartmentId.FindStringExact(value);
                if (index != -1)
                    cbDepartmentId.SelectedIndex = index;
            }
        }
        public string Contract_type { get => cbContractType.Text; set => cbContractType.Text = value; }
        public DateTime On_boarding { get => dtOnBoarding.Value; set => dtOnBoarding.Value = value; }
        public DateTime Close_date { get => dtClosedate.Value; set => dtClosedate.Value = value; }
        public string Scan_contract { get => txtScanContract.Text; set => txtScanContract.Text = value; }

        public string Note { get => txtNote.Text; set => txtNote.Text = value; }
       


        public string Roles { get => cbRoles.Text; set => cbRoles.Text = value; }
        public Image Photo { get => pbAvatar.Image; set => pbAvatar.Image = value; }

        public event EventHandler AddNewUserDialog;
        public event EventHandler EditUserDialog;
        public event EventHandler GeneratedEventLoadEmail;
        public event EventHandler GenerateRandomPassword;
        public event EventHandler SendPasswordToMail;
        public event EventHandler CancleEvent;
        public event EventHandler CheckConditionSalary;
        public event EventHandler CheckConditionEmail;
        public event EventHandler CheckConditionName;
        public event EventHandler CheckConditionDate;
        public event EventHandler CheckConditionPhone;
        public event EventHandler ClearResultEvent;

        private void UserName(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Length > 0)
            {
                txtUsername.Text = GenerateDepartmentID(txtName.Text);
            }
        }
        private string RemoveVietnameseSigns(string text)
        {
            text = text.ToLower();
            string signs = "áàảãạăắằẳẵặâấầẩẫậđéèẻẽẹêếềểễệíìỉĩịóòỏõọôốồổỗộơớờởỡợúùủũụưứừửữựýỳỷỹỵ";
            string replacements = "aaaaaaaaaaaaaaaaadeeeeeeeeeeeeeiiiiiooooooooooooooooouuuuuuuuuuuyyyyy";
            for (int i = 0; i < signs.Length; i++)
            {
                text = text.Replace(signs[i], replacements[i]);
            }

            return text;
        }


        private string GenerateDepartmentID(string fullName)
        {
            // Loại bỏ dấu và chuyển đổi thành chữ thường
            fullName = RemoveVietnameseSigns(fullName);

            // Chia chuỗi họ tên thành các phần tách bởi khoảng trắng
            string[] parts = fullName.Split(' ');

            // Tạo một StringBuilder để xây dựng chuỗi kết quả
            StringBuilder result = new StringBuilder();

            // Lấy phần đầu tiên là tên
            result.Append(parts[parts.Length - 1]); // Thêm tên vào

            // Nếu có họ và tên lót, thêm chữ cái đầu của họ vào
            if (parts.Length > 1)
            {
                for (int i = 0; i < parts.Length - 1; i++)
                {
                    result.Append(parts[i][0]); // Thêm chữ cái đầu của họ vào
                }
            }
            // Chuyển đổi kết quả thành chuỗi và trả về
            return result.ToString();
        }

<<<<<<< HEAD:HRMngt/Views/Dialogs/Forms/UserDialog.cs
        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStatus.SelectedIndex == 0)
            {
                cbRoles.SelectedIndex = 0;
                cbRoles.Enabled = false;
            }
            else
            {
                cbRoles.Enabled = true;
            }
        }

        public void ShowUserIdNName(IEnumerable<UserModel> userList)
=======
        
        public void ShowUserIdNName(List<string> userIdNNameList)
>>>>>>> new-mhieu:HRMngt/Views/Dialogs/Form/UserDialog.cs
        {
            cbManagerId.Items.Clear();

            foreach (var item in userList)
            {
                cbManagerId.Items.Add($"{item.Id} - {item.Name}");
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

        public void ShowDepartmentIdNName(IEnumerable<DepartmentModel> departmentList)
        {
            cbDepartmentId.Items.Clear();
            foreach (var item in departmentList)
            {
                cbDepartmentId.Items.Add($"{item.Id} - {item.Name}");
            }
        }
        private void btnPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                pbAvatar.Image = new Bitmap(open.FileName);

            }
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ShowUserIDName(IEnumerable<UserModel> users)
        {
            foreach (var user in users)
            {
                if (user.Roles == "Admin" && users != null)
                {
                    cbManagerId.Items.Add($"{user.Id} - {user.Name}");
                }
            }
        }

        public void DisplayUserPhotoForEditing(byte[] photoData)
        {
            if (photoData != null && photoData.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(photoData))
                {
                    pbAvatar.Image = Image.FromStream(ms);
                }
            }
            else
            {
                // Handle case where photo data is null or empty
                pbAvatar.Image = null; // Clear the PictureBox
            }
        }

        private void UserDialog_Load(object sender, EventArgs e)
        {

        }
    }
}
