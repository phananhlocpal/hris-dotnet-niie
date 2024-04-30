using HRMngt._Repository;
using HRMngt._Repository.Recruitment;
using HRMngt.Models;
using HRMngt.popup;
using HRMngt.Views.Dialogs;
using HRMngt.Views.HR;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMngt.Presenters
{
    public class RecruitmentPresenter

    {
        private IRecruitView view;
        private IRecruitmentRepository repository;
        private IUserRepository userRepository;
        private RecruitDialog dialog;
        private IEnumerable<UserModel> recruitmentList;
        private UserModel userModel;

        public RecruitmentPresenter(IRecruitView view, IRecruitmentRepository repository, UserModel userModel)
        {
            this.view = view;
            this.repository = repository;
            this.userModel = userModel;
            this.view.LoadHRToAdd += LoadHRToAdd;
            this.view.LoadHRToEdit += LoadHRToEdit;
            this.view.DeleteHR += DeleteRecruitment;
            this.view.FilterRecruitment += FilterRecruitment;
            SetRole(userModel);
            this.view.Show();


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
        private void FilterRecruitment(object sender, EventArgs e)
        {
            string department = ExtractIdFromName(view.cbDepartment.Text);
            string status = view.cbStatus.Text;
            recruitmentList = repository.Filter(recruitmentList, department, status);
            view.ShowHRList(recruitmentList);
        }

        private void DeleteRecruitment(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = view.dgvHRList.CurrentRow;
            string id = selectedRow.Cells[0].Value.ToString();
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Bạn có muốn xóa đơn này không?", "Xóa đơn", buttons);
            if (result == DialogResult.Yes)
            {
                repository.Delete(id);
                SucessPopUp.ShowPopUp();
                SetRole(userModel);
                SucessPopUp.ShowPopUp();
            }
        }

        private void LoadHRToEdit(object sender, EventArgs e)
        {
            dialog = view.ShowDialogToEdit(null);

            // Show Department List
            IDepartmentRepository departmentRepository = new DepartmentRepository();
            IEnumerable<DepartmentModel> departmentList = departmentRepository.GetAll();
            this.dialog.ShowDepartmentIdNName(departmentList);

            // Show UserList
            IUserRepository userRepository = new UserRepository();
            IEnumerable<UserModel> userList = userRepository.GetAll();
            dialog.ShowUserIDName(userList);

            // Get user id from datagridview
            DataGridViewRow selectedRow = view.dgvHRList.CurrentRow;
            string id = selectedRow.Cells[0].Value.ToString();
            UserModel recruit = new UserModel();
            recruit = repository.LINQ_GetModelById(recruitmentList, id);

            // Load data to form
            UserModel manager = userRepository.LINQ_GetModelById(userList, recruit.ManagerID);
            DepartmentModel department = departmentRepository.LINQ_GetModelById(departmentList, recruit.DepartmentID);
            dialog.ID = recruit.Id;
            dialog.NameCadidate = recruit.Name;
            dialog.Email = recruit.Email;
            dialog.Phone = recruit.Phone;
            dialog.Address = recruit.Address;
            dialog.Sex = recruit.Sex;
            dialog.Birthday = recruit.Birthday;
            dialog.Position = recruit.Position;
            dialog.Roles = recruit.Roles;
            dialog.Note = recruit.Note;
            dialog.Status = recruit.Status;
            dialog.Contract_type = recruit.Contract_type;
            dialog.ManagerName = $"{manager.Id} - {manager.Name}";
            dialog.DepartmentName = $"{department.Id} - {department.Name}";

            dialog.EditNewDialog += EditRecruitDialog;
            dialog.ShowDialog();
        }

        private void EditRecruitDialog(object sender, EventArgs e)
        {
            UserModel recruit = new UserModel();
            recruit.Id = dialog.ID;
            recruit.Name = dialog.NameCadidate;
            recruit.Email = dialog.Email;
            recruit.Phone = dialog.Phone;
            recruit.Address = dialog.Address;
            recruit.Sex = dialog.Sex;
            recruit.Birthday = dialog.Birthday;
            recruit.Position = dialog.Position;
            recruit.Roles = dialog.Roles;
            recruit.Note = dialog.Note;
            recruit.Status = dialog.Status;
            recruit.Contract_type = dialog.Contract_type;
            recruit.DepartmentID = dialog.DepartmentName;
            recruit.ManagerID = dialog.ManagerName;

            repository.Edit(recruit);

            if (recruit.Status == "On-boarding")
            {
                repository.SendMail(repository.LINQ_GetPassword(recruitmentList, recruit.Id), recruit.Email, repository.LINQ_GetUsername(recruitmentList, recruit.Id), recruit.Name);
                recruit.On_boarding = DateTime.Now;
                recruit.Close_date = DateTime.Now.AddYears(3);
            }
            this.dialog.Close();
            SetRole(userModel);
            SucessPopUp.ShowPopUp();
        }

        private void LoadRecruitment()
        {
            recruitmentList = repository.GetAll();
        }

        private void LoadHRToAdd(object sender, EventArgs e)
        {
            dialog = this.view.ShowDialogToAdd();

            // Return department id and name
            IDepartmentRepository departmentRepository = new DepartmentRepository();
            IEnumerable<DepartmentModel> departmentList = departmentRepository.GetAll();
            dialog.ShowDepartmentIdNName(departmentList);


            // Return user id and name
            IUserRepository userRepository = new UserRepository();
            IEnumerable<UserModel> userList = userRepository.GetAll();
            dialog.ShowUserIdNName(userList);

            dialog.AddNewDialog += AddRecuit;
            dialog.ShowDialog();
        }

        private void AddRecuit(object sender, EventArgs e)
        {
            UserModel recruit = new UserModel();
            recruit.Name = dialog.NameCadidate;
            recruit.Email = dialog.Email;
            recruit.Phone = dialog.Phone;
            recruit.Address = dialog.Address;
            recruit.Sex = dialog.Sex;
            recruit.Birthday = dialog.Birthday;
            recruit.Position = dialog.Position;
            recruit.Roles = dialog.Roles;
            recruit.Note = dialog.Note;
            recruit.Status = dialog.Status;
            recruit.Contract_type = dialog.Contract_type;
            recruit.DepartmentID = dialog.DepartmentName;
            recruit.ManagerID = dialog.ManagerName;

            repository.Add(recruit);
            SetRole(userModel);
            SucessPopUp.ShowPopUp();
        }
        private void SetRole(UserModel userModel)
        {
            if (userModel.Roles == "Manager")
            {
                MessageBox.Show(userModel.Roles);
                view.ButtonAdd.Enabled = false;
                view.ButtonEdit.Visible = false;
                view.ButtonDelete.Visible = false;
                recruitmentList = userRepository.LINQ_GetAllManager(recruitmentList, userModel.Id);
                this.view.ShowHRList(recruitmentList);
            }
            else if (userModel.Roles == "Employee")
            {
                MessageBox.Show(userModel.Roles);
                view.ButtonAdd.Enabled = false;
                view.ButtonEdit.Visible = false;
                view.ButtonDelete.Visible = false;
            }
            else
            {
                MessageBox.Show(userModel.Roles);
                recruitmentList = repository.GetAll();
                this.view.ShowHRList(recruitmentList);
            }
        }
    }
}
