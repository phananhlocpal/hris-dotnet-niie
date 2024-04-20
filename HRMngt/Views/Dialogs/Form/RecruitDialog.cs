using HRMngt.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMngt.Views.Dialogs
{
    public partial class RecruitDialog : Form, IRecruitViewDialog
    {
        private string type;
        public RecruitDialog(string type)
        {
            this.type = type;
            InitializeComponent();
            
            if(type == "Add")
            {
                btnAdd.Text = "Thêm";
            }else if(type == "Edit")
            {
                btnAdd.Text = "Sửa";
            }
            RunEvent();
            
        }
        private void RunEvent()
        {
            if (btnAdd.Text == "Add")
            {
                btnAdd.Click += delegate
                {
                    AddNewDialog?.Invoke(this, EventArgs.Empty);
                };
            }
            else if (btnAdd.Text == "Update")
            {
                btnAdd.Click += delegate { EditNewDialog?.Invoke(this, EventArgs.Empty); };
            }
            btnClose.Click += delegate { CloseEvent?.Invoke(this, EventArgs.Empty); };
            txtEmail.Click += delegate { CheckConditionBirthday?.Invoke(this, EventArgs.Empty); };
            txtPhone.Click += delegate { CheckConditionEmail?.Invoke(this, EventArgs.Empty); };
            cbRoles.Click += delegate { CheckConditionPhone?.Invoke(this, EventArgs.Empty); };
            btnClear.Click += delegate { ClearTextForm?.Invoke(this, EventArgs.Empty); };
        }
        
        // Get, set method
        public string ID { get => lbID.Text; set => lbID.Text = value; }
        public string NameCadidate { get => txtName.Text; set => txtName.Text = value; }
        public string Email { get => txtEmail.Text; set => txtEmail.Text = value; }
        public string Address { get => txtAddress.Text; set => txtAddress.Text = value; }
        public string Phone { get => txtPhone.Text; set => txtPhone.Text = value; }
        public string Position { get => cbPosition.Text; set => cbPosition.Text = value; }
        public string Roles { get => cbRoles.Text; set => cbRoles.Text = value; }
        public string Note { get => txtNote.Text; set => txtNote.Text = value; }
        public DateTime Birthday { get => birthday.Value; set => birthday.Value=value; }
        public string Sex { get => cbSex.Text; set => cbSex.Text = value; }
        public string Contract_type { get => cbContractType.Text; set => cbContractType.Text = value; }
        public string Status { get => cbStatus.Text; set => cbStatus.Text = value; }
        public string DepartmentName {

            get
            {
                if (cbDepartment.SelectedItem == null || cbDepartment.SelectedItem.ToString() == "")
                    return "";
                else return ExtractIdFromName(cbDepartment.SelectedItem.ToString());
            }
            set
            {
                int index = cbDepartment.FindStringExact(value);
                if (index != -1)
                    cbDepartment.SelectedIndex = index;
            }
        }
        public string ManagerName {
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

        // Event Handler
        public event EventHandler AddNewDialog;
        public event EventHandler EditNewDialog;
        public event EventHandler CheckConditionBirthday;
        public event EventHandler CheckConditionPhone;
        public event EventHandler CheckConditionEmail;
        public event EventHandler ClearTextForm;
        public event EventHandler CloseForm;
        public event EventHandler CloseEvent;

        public void ShowRecruitList(IEnumerable<UserModel> recruits)
        {
            throw new NotImplementedException();
        }

        public void ShowUserIDName(IEnumerable<UserModel> users)
        {
            cbManager.Items.Clear();
            foreach (var user in users)
            {
                if (user.Roles == "Admin" && users != null)
                {
                    cbManager.Items.Add($"{user.Id} - {user.Name}");
                }
            }
        }
        public void ShowUserIdNName(List<string> userIdNNameList)
        {
            cbManager.Items.Clear();

            foreach (string item in userIdNNameList)
            {
                cbManager.Items.Add(item);
            }
        }
        public void ShowDepartmentIdNName(IEnumerable<DepartmentModel> departmentList)
        {
           cbDepartment.Items.Clear();

            foreach (var departmentModel in departmentList)
            {
                cbDepartment.Items.Add($"{departmentModel.Id} - {department.Name}");

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
    }
}
