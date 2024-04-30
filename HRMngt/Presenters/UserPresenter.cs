using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
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
        private IEnumerable<UserModel> filterUser;
        private UserModel userModel;


        public UserPresenter(IUserView view, IUserRepository repository, UserModel userModel)
        {
            this.view = view;
            this.repository = repository;
            this.userModel = userModel;
            userList = repository.GetAll();
            this.view.LoadUserDialogToAddEvent += LoadUserDialogToAddEvent;
            this.view.LoadUserDialogToEditEvent += LoadUserDialogToEditEvent;
            this.view.FilterUser += FilterUser;
            this.view.DeleteEvent += DeleteUser;


            SetRole(userModel);
            this.view.Show();
        }

        private void FilterUser(object sender, EventArgs e)
        {
            string department = ExtractIdFromName(view.cbDepartment.Text);
            string status = view.cbStatus.Text;
            filterUser = repository.Filter(userList, department, status);
            view.ShowUserList(filterUser);
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


        private void DeleteUser(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = view.dgvUserList.CurrentRow;
            string id = selectedRow.Cells[1].Value.ToString();
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Bạn có muốn xóa nhân viên này không?", "Xóa nhân viên", buttons);
            if (result == DialogResult.Yes)
            {
                repository.Delete(id);
                SucessPopUp.ShowPopUp();
                /*LoadAllUserList();*/
                SetRole(userModel);
                view.ShowUserList(userList);
            }
        }

        private void LoadUserDialogToEditEvent(object sender, EventArgs e)
        {
            dialog = view.ShowUserDialogToEdit(null);
            IEnumerable<UserModel> userList;
            List<string> departmentIDNameList = new List<string>();
            userList = repository.GetAll();

            // Show Department Id - Name
            IDepartmentRepository departmentRepository = new DepartmentRepository();
            IEnumerable<DepartmentModel> departmentList = departmentRepository.GetAll();
            this.dialog.ShowDepartmentIdNName(departmentList);
            dialog.ShowUserIDName(userList);

            DataGridViewRow selectedRow = view.dgvUserList.CurrentRow;
            string id = selectedRow.Cells[1].Value.ToString();
            UserModel user = repository.LINQ_GetModelById(userList, id);
            UserModel manager = repository.LINQ_GetModelById(userList, user.ManagerID);
            DepartmentModel department = departmentRepository.LINQ_GetModelById(departmentList, user.DepartmentID);

            dialog.ID = user.Id;
            dialog.Fullname = user.Name;
            dialog.Email = user.Email;
            dialog.Phone = user.Phone;
            dialog.Address = user.Address;
            dialog.Birthday = user.Birthday;
            dialog.Salary = user.Salary;
            dialog.Username = user.Username;
            dialog.Password = user.Password;
            if (manager != null)
                dialog.ManagerID = $"{manager.Id} - {manager.Name}";
            dialog.DepartmentID = $"{department.Id} - {department.Name}";
            dialog.On_boarding = user.On_boarding;
            if (user.Close_date != null)
            {
                dialog.Close_date = user.Close_date.Value;
            }
            dialog.Scan_contract = user.Scan_contract;
            dialog.Note = user.Note;
            dialog.Sex = user.Sex;
            dialog.Status = user.Status;
            dialog.Position = user.Position;
            dialog.Contract_type = user.Contract_type;

            // Kiểm tra nếu trường Photo là null, thì sử dụng hình ảnh mặc định
            if (user.Photo == null || user.Photo.Length == 0)
            {
                // Đường dẫn đến tệp hình ảnh mặc định
                string defaultImagePath = @"C:\Users\Surface\source\repos\hris-dotnet-niie\HRMngt\Resources\no-image.jpg";
                byte[] defaultImageBytes = File.ReadAllBytes(defaultImagePath);
                dialog.Photo = ByteArrayToImage(defaultImageBytes);
            }
            else
            {
                dialog.Photo = ByteArrayToImage(user.Photo);
            }

            dialog.Roles = user.Roles;
            dialog.EditUserDialog += EditUserDialog;
            dialog.CancleEvent += CancleEvent;
            dialog.ShowDialog();
        }

        private Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image image = Image.FromStream(ms);
                return image;
            }
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
            user.Photo = getPhoto();
            user.Roles = dialog.Roles;
            repository.Update(user);
            this.dialog.Close();
            /*LoadAllUserList();*/
            SetRole(userModel);
            view.ShowUserList(userList);
            SucessPopUp.ShowPopUp();
        }

        private void LoadUserDialogToAddEvent(object sender, EventArgs e)
        {
            dialog = this.view.ShowUserDialogToAdd();

            // Add user to sender and receiver
            IDepartmentRepository departmentRepository = new DepartmentRepository();
            IEnumerable<UserModel> userList = repository.GetAll();
            IEnumerable<DepartmentModel> departmentList = departmentRepository.GetAll();
            dialog.ShowUserIdNName(userList);
            dialog.ShowDepartmentIdNName(departmentList);


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
            dialog.Salary = 0;
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
            if (currentYear - birthDay < 18)
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
                if (dialog.Salary < 0)
                {
                    MessageBox.Show("Vui lòng nhập lương lớn hơn 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
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
            user.Photo = getPhoto();
            user.Roles = dialog.Roles;
            repository.Add(user);
            this.dialog.Close();
            /*LoadAllUserList();*/
            SetRole(userModel);
            view.ShowUserList(userList);
            dialog.SendPasswordToMail += SendPassToMail;
            SucessPopUp.ShowPopUp();
        }
        public byte[] getPhoto()
        {
            MemoryStream stream = new MemoryStream();
            dialog.Photo.Save(stream, dialog.Photo.RawFormat);
            return stream.GetBuffer();
        }

        private void SendPassToMail(object sender, EventArgs e)
        {
            string email = dialog.Email;
            string password = dialog.Password;
            repository.SendMail(password, email);
        }

        private void LoadAllUserList()
        {
            userList = repository.GetAll();
        }

        private void SetRole(UserModel userModel)
        {
            if(userModel.Roles == "Manager")
            {
                MessageBox.Show(userModel.Roles);
                view.ButtonAdd.Enabled = false;
                view.ButtonEdit.Visible = false;
                view.ButtonDelete.Visible = false;
                userList = repository.LINQ_GetAllManager(userList, userModel.Id);
                this.view.ShowUserList(userList);
            }
            else if(userModel.Roles == "Employee")
            {
                MessageBox.Show(userModel.Roles);
                view.ButtonAdd.Enabled = false;
                view.ButtonEdit.Visible = false;
                view.ButtonDelete.Visible = false;
                userList = repository.LINQ_GetAllUser(userList,userModel.DepartmentID);
                this.view.ShowUserList(userList);
            }
            else
            {
                MessageBox.Show(userModel.Roles);
                userList = repository.GetAll();
                this.view.ShowUserList(userList);
            }
        }
    }
}
