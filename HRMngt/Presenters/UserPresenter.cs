using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRMngt._Repository;
using HRMngt.Models;
using HRMngt.popup;
using HRMngt.View;
using HRMngt.Views.Dialogs;

namespace HRMngt.Presenter
{
    public class UserPresenter
    {
        // Fields
        private IUserView view;
        private IUserRepository repository;
        private UserDialog dialog;
        private IEnumerable<UserModel> userList;
        private UserModel userModel;
        

        public UserPresenter(IUserView view, IUserRepository repository, UserModel userModel)
        {
            this.view = view;  
            this.repository = repository;
            this.userModel = userModel;
            this.view.LoadUserDialogToAddEvent += LoadUserDialogToAddEvent;
            this.view.LoadUserDialogToEditEvent += LoadUserDialogToEditEvent;
            this.view.DeleteEvent += DeleteUser;

            userList = repository.GetAll();
            this.view.ShowUserList(userList);
            this.view.Show();
        }

        private void DeleteUser(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = view.dgvUserList.CurrentRow;
            string id = selectedRow.Cells[0].Value.ToString();
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Bạn có muốn xóa nhân viên này không?", "Xóa nhân viên", buttons);
            if (result == DialogResult.Yes)
            {
                repository.Delete(id);
                SucessPopUp.ShowPopUp();
                userList = repository.GetAll();
                view.ShowUserList(userList);
            }
        }

        private void LoadUserDialogToEditEvent(object sender, EventArgs e)
        {
            dialog = this.view.ShowUserDialogToEdit();

            // Show Department information
            IDepartmentRepository departmentRepository = new DepartmentRepository();
            IEnumerable<DepartmentModel> departmentList;
            departmentList = departmentRepository.GetAll();
            this.dialog.ShowDepartmentIdNName(departmentList);

            // Show Manager information
            IUserRepository userRepository = new UserRepository();
            IEnumerable<UserModel> userList = userRepository.GetAll();
            userList = userRepository.LINQ_GetManagerList(userList);
            this.dialog.ShowUserIDName(userList);

            // Get id from table
            DataGridViewRow selectedRow = view.dgvUserList.CurrentRow;
            string id = selectedRow.Cells[0].Value.ToString();
            UserModel user = new UserModel();
            user = repository.LINQ_GetModelById(userList, id);

            // Show information into form
            dialog.ID = user.Id;
            dialog.Fullname = user.Name;
            dialog.Email = user.Email;
            dialog.Phone = user.Phone;
            dialog.Address = user.Address;
            dialog.Sex = user.Sex;
            dialog.Birthday = user.Birthday;
            dialog.Position = user.Position;
            dialog.Salary = user.Salary;
            dialog.Username = user.Username;
            dialog.Password = user.Password;
            dialog.ManagerID = user.ManagerID;
            dialog.On_boarding = user.On_boarding;
            dialog.Close_date = user.Close_date;
            dialog.Roles = user.Roles;
            dialog.Scan_contract = user.Scan_contract;
            dialog.Note = user.Note;
            dialog.Sex = user.Sex;
            dialog.Status = user.Status;
            dialog.Contract_type = user.Contract_type;

            // Show dialog and event handler
            dialog.EditUserDialog += EditUserDialog;
            dialog.ShowDialog();
        }

        private void EditUserDialog(object sender, EventArgs e)
        {
            UserModel user = new UserModel();
            user.Id = dialog.ID;
            user.Name = dialog.Fullname;
            user.Email = dialog.Email;
            user.Phone = dialog.Phone;
            user.Address = dialog.Address;
            user.Birthday = dialog.Birthday;
            user.Salary = dialog.Salary;
            user.Username = dialog.Username;
            user.Password = dialog.Password;
            user.ManagerID = dialog.ManagerID;
            user.DepartmentID = dialog.DepartmentID;
            user.On_boarding = dialog.On_boarding;
            user.Close_date = dialog.Close_date;
            user.Scan_contract = dialog.Scan_contract;
            user.Note = dialog.Note;
            user.Sex = dialog.Sex;
            user.Status = dialog.Status;
            user.Position = dialog.Position;
            user.Contract_type = dialog.Contract_type;
            user.Roles = dialog.Roles;
            repository.Update(user);
            this.dialog.Close();
            userList = repository.GetAll();
            view.ShowUserList(userList);
            SucessPopUp.ShowPopUp();
        }

        private void LoadUserDialogToAddEvent(object sender, EventArgs e)
        {
            dialog = this.view.ShowUserDialogToAdd();

            // Show Department information
            IDepartmentRepository departmentRepository = new DepartmentRepository();
            IEnumerable<DepartmentModel> departmentList;
            departmentList = departmentRepository.GetAll();
            this.dialog.ShowDepartmentIdNName(departmentList);

            // Show Manager information
            IUserRepository userRepository = new UserRepository();
            IEnumerable<UserModel> userList = userRepository.GetAll();
            userList = userRepository.LINQ_GetManagerList(userList);
            this.dialog.ShowManagerComboBox(userList);

            dialog.CheckConditionSalary += CheckConditionSalary;
            dialog.CheckConditionEmail += CheckConditionEmail;
            dialog.CheckConditionName += CheckConditionName;
            dialog.CheckConditionDate += CheckConditionDate;
            dialog.CheckConditionPhone += CheckConditionPhone;
            dialog.AddNewUserDialog += AddNewUserDialog;
            dialog.ClearResultEvent += ClearEvent;
            dialog.GenerateRandomPassword += GenerateRandomPassword;
            dialog.CancleEvent += CancleEvent;
            dialog.ShowDialog();
        }

        private void ClearEvent(object sender, EventArgs e)
        {
            dialog.Name = "";
            dialog.Email = "";
            dialog.Phone = "";
            dialog.Address = "";
            dialog.Birthday = DateTime.Now;
            dialog.Salary = "";
            dialog.Username = "";
            dialog.Password = "";
            dialog.On_boarding = DateTime.Now;
            dialog.Close_date = DateTime.Now;
            dialog.Scan_contract = "";
            dialog.Sex = "";
            dialog.Status = "";
            dialog.Position = "";
            dialog.Roles = "";
            dialog.ManagerID = "";
            dialog.DepartmentID = "";
        }

        private void CheckConditionPhone(object sender, EventArgs e)
        {
            int phoneNumber = dialog.Phone.Length;
            if (string.IsNullOrWhiteSpace(dialog.Phone))
            {
                MessageBox.Show("Số điện thoại không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (dialog.Phone.Length > 10 || !dialog.Phone.All(char.IsDigit))
            {
                MessageBox.Show($"Số điện thoại dư {phoneNumber - 10} chữ số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dialog.Phone.Length < 10)
            {
                MessageBox.Show($"Số điện thoại thiếu {10 - phoneNumber} chữ số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckConditionDate(object sender, EventArgs e)
        {
            int currentYear = DateTime.Now.Year;
            int birthDay = dialog.Birthday.Year;
            if(currentYear - birthDay < 18)
            {
                MessageBox.Show("Nhân viên phải trên 18 tuổi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckConditionName(object sender, EventArgs e)
        {
            if (dialog.Name.Length == 0)
            {
                MessageBox.Show("Vui lòng không được để trống tên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dialog.Email = "your_email@gmail.com";
            }
        }

        private void CheckConditionEmail(object sender, EventArgs e)
        {
            if (!dialog.Email.Contains("@gmail.com") && dialog.Email.Length > 0)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng email(@gmail.com)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void CheckConditionSalary(object sender, EventArgs e)
        {
            try
            {
                if(int.Parse(dialog.Salary) < 0)
                {
                    MessageBox.Show("Vui lòng nhập lương lớn hơn 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Vui lòng nhập lương là chữ số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancleEvent(object sender, EventArgs e)
        {
            dialog.Close();
        }

        private void GenerateRandomPassword(object sender, EventArgs e)
        {
            string passwordRandom = repository.RandomPasswords();
            dialog.Password = passwordRandom;
        }

        private void AddNewUserDialog(object sender, EventArgs e)
        {
            UserModel user = new UserModel();
           
            user.Name = dialog.Fullname;
            user.Email = dialog.Email;
            user.Phone = dialog.Phone;
            user.Address = dialog.Address;
            user.Birthday = dialog.Birthday;
            user.Salary = dialog.Salary;
            user.Username = dialog.Username;
            user.Password = dialog.Password;
            user.ManagerID = dialog.ManagerID;
            user.DepartmentID = dialog.DepartmentID;
            user.On_boarding = dialog.On_boarding;
            user.Close_date = dialog.Close_date;
            user.Scan_contract = dialog.Scan_contract;
            user.Note = dialog.Note;
            user.Sex = dialog.Sex;
            user.Status = dialog.Status;
            user.Position = dialog.Position;
            user.Contract_type = dialog.Contract_type;
            user.Photo = dialog.Photo;
            user.Roles = dialog.Roles;
            repository.Add(user);
            this.dialog.Close();
            userList = repository.GetAll();
            view.ShowUserList(userList);
            dialog.SendPasswordToMail += SendPassToMail;
            SucessPopUp.ShowPopUp();
        }

        private void SendPassToMail(object sender, EventArgs e)
        {
            string email = dialog.Email;
            string password = dialog.Password;
            repository.SendMail(password, email);
        }


    }
}
