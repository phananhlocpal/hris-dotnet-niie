using HRMngt._Repository;
using HRMngt.Model;
using HRMngt.Models;
using HRMngt.popup;
using HRMngt.Views.Dialogs;
using HRMngt.Views.HR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMngt.Presenters
{
    public class RecruitPresenter
    {
        // Fields
        private IRecruitView view;
        private IUserRepository repository;
        private IEnumerable<UserModel> candidateList;
        private RecruitDialog dialog;

        public RecruitPresenter(IRecruitView view, IUserRepository repository)
        {
            // Contructors
            this.view = view;
            this.repository = repository;

            // Event Handler
            this.view.LoadHRToAdd += LoadHRToAddRecuit;
            this.view.LoadHRToEdit += LoadRecruitToEdit;
            this.view.DeleteHR += DeleteHR;

            // Show view
            candidateList = repository.GetAll();
            this.view.ShowHRList(candidateList);
            IDepartmentRepository departmentRepository = new DepartmentRepository();
            IEnumerable<DepartmentModel> departmentList = departmentRepository.GetAll();
            this.view.ShowCmbDepartment(departmentList);
            this.view.Show();
        }

        // Event Processing
        private void DeleteHR(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = view.dgvHRList.CurrentRow;
            string id = selectedRow.Cells[0].Value.ToString();
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Bạn có muốn xóa đơn này không?", "Xóa đơn", buttons);
            if (result == DialogResult.Yes)
            {
                repository.Delete(id);
                SucessPopUp.ShowPopUp();
                candidateList = repository.GetAll();
                view.ShowHRList(candidateList);
                SucessPopUp.ShowPopUp();
            }
        }

        private void LoadRecruitToEdit(object sender, EventArgs e)
        {
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
            DataGridViewRow selectedRow = view.dgvHRList.CurrentRow;
            string id = selectedRow.Cells[0].Value.ToString();
            UserModel candidate = repository.LINQ_GetModelById(candidateList, id);

            // Show information into form
            dialog.ID = candidate.Id;
            dialog.NameCadidate = candidate.Name;
            dialog.Email = candidate.Email;
            dialog.Phone = candidate.Phone;
            dialog.Address = candidate.Address;
            dialog.Sex = candidate.Sex;
            dialog.Birthday = candidate.Birthday;
            dialog.Position = candidate.Position;
            dialog.Roles = candidate.Roles;
            dialog.Note = candidate.Note;
            dialog.Status = candidate.Status;
            dialog.Contract_type = candidate.Contract_type;
            //dialog.DepartmentName = candidate.DepartmentName;
            //dialog.ManagerName = candidate.ManagerName;
            
            // Show dialog and event handler
            dialog = view.ShowDialogToEdit();
            dialog.EditNewDialog += EditRecruitDialog;
            dialog.CloseEvent += CloseDialog;
            dialog.ShowDialog();
        }

        private void CloseDialog(object sender, EventArgs e)
        {
            dialog.Close();
        }

        private void EditRecruitDialog(object sender, EventArgs e)
        {
            UserModel candidate = new UserModel();
            candidate.Id = dialog.ID;
            candidate.Name = dialog.NameCadidate;
            candidate.Email = dialog.Email;
            candidate.Phone = dialog.Phone;
            candidate.Address = dialog.Address;
            candidate.Sex = dialog.Sex;
            candidate.Birthday = dialog.Birthday;
            candidate.Position = dialog.Position;
            candidate.Roles = dialog.Roles;
            candidate.Note = dialog.Note;
            candidate.Status = dialog.Status;
            candidate.Contract_type = dialog.Contract_type;

            if (candidate.Status == "On-boarding")
            {
                candidate.On_boarding = DateTime.Now;
            }
            repository.Update(candidate);
            this.dialog.Close();
            candidateList = repository.GetAll();
            view.ShowHRList(candidateList);
            SucessPopUp.ShowPopUp();
        }

        private void LoadHRToAddRecuit(object sender, EventArgs e)
        {
            dialog = this.view.ShowDialogToAdd();

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
            
            dialog.AddNewDialog += AddRecuit;
            dialog.CheckConditionBirthday += CheckConditionBirthday;
            dialog.CheckConditionEmail += CheckConditionEmail;
            dialog.CheckConditionPhone += CheckConditionPhone;
            dialog.ClearTextForm += ClearTextForm;
            dialog.ShowDialog();
        }

        private void ClearTextForm(object sender, EventArgs e)
        {
            dialog.Name = "";
            dialog.Address = "";
            dialog.Sex = "";
            dialog.Birthday = DateTime.Now;
            dialog.Email = "";
            dialog.Phone = "";
            dialog.Roles = "";
            dialog.Position = "";
            dialog.Contract_type = "";
            dialog.Note = "";
        }

        private void CheckConditionPhone(object sender, EventArgs e)
        {
            int currentPhone = dialog.Phone.Length;
            try
            {
                if (dialog.Phone.Length < 10 && currentPhone > 0)
                {
                    MessageBox.Show($"Số điện thoại của bạn hiện tại đang thiếu {10 - currentPhone} số, vui lòng nhập đủ số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dialog.Phone.Length > 10)
                {
                    MessageBox.Show($"Số điện thoại của bạn hiện tại đang dư {currentPhone - 10} số, vui lòng nhập đủ số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Số điện thoại không chứa các kí tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckConditionEmail(object sender, EventArgs e)
        {
            if (!dialog.Email.Contains("@gmail.com"))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng gmail", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void CheckConditionBirthday(object sender, EventArgs e)
        {
            var currentYear = DateTime.Now.Year;
            var birthday = dialog.Birthday.Year;
            if (currentYear - birthday < 18)
            {
                MessageBox.Show("Nhân viên phải trên 18 tuổi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dialog.Email = "your_email@gmail.com";
            }
        }

        private void AddRecuit(object sender, EventArgs e)
        {
            UserModel candidate = new UserModel();
            candidate.Name = dialog.NameCadidate;
            candidate.Email = dialog.Email;
            candidate.Phone = dialog.Phone;
            candidate.Address = dialog.Address;
            candidate.Sex = dialog.Sex;
            candidate.Birthday = dialog.Birthday;
            candidate.Position = dialog.Position;
            candidate.Roles = dialog.Roles;
            candidate.Note = dialog.Note;
            candidate.Status = dialog.Status;
            candidate.Contract_type = dialog.Contract_type;
            
            repository.Add(candidate);
            this.dialog.Close();
            candidateList = repository.GetAll();
            view.ShowHRList(candidateList);
            SucessPopUp.ShowPopUp();
        }
    }
}
