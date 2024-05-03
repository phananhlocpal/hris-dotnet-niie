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
        
        private void FilterRecruitment(object sender, EventArgs e)
        {
            string department = view.cbDepartment.Text.Split('-')[0].Trim();
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
            IEnumerable<UserModel> userList;
            List<string> departmentIDNameList = new List<string>();
            var repo = new UserRepository();
            userList = repository.GetAll();
            departmentIDNameList = repo.GetDepartmentIDName();
            this.dialog.ShowDepartmentIdNName(departmentIDNameList);
            dialog.ShowUserIDName(userList);
            DataGridViewRow selectedRow = view.dgvHRList.CurrentRow;
            string id = selectedRow.Cells[0].Value.ToString();
            UserModel recruit = new UserModel();
            recruit = repository.LINQ_GetModelById(recruitmentList, id);
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
            dialog.ManagerName = $"{recruit.ManagerID} - {repo.GetNameById(recruit.ManagerID)}";
            dialog.DepartmentName = $"{recruit.DepartmentID} - {repo.GetNameDepartmentById(recruit.DepartmentID)}";

            dialog.EditNewDialog += EditRecruitDialog;
            /*dialog.CancleEvent += CancleEvent;*/
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

            List<string> userIdNNameList = new List<string>();
            List<string> departmentIDNameList = new List<string>();
            var repo = new UserRepository();
            DepartmentModel departmentModel = new DepartmentModel();
            UserModel userModel = new UserModel();
            userIdNNameList = repo.GetUserIdNName();
            departmentIDNameList = repo.GetDepartmentIDName();
            dialog.ManagerName = $"{userModel.Id} - {userModel.Name}";
            dialog.DepartmentName = $"{departmentModel.Id} - {departmentModel.Name}";
            // Add user to sender and receiver
            dialog.ShowUserIdNName(userIdNNameList);
            dialog.ShowDepartmentIdNName(departmentIDNameList);

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
                
                view.ButtonAdd.Enabled = false;
                view.ButtonEdit.Visible = false;
                view.ButtonDelete.Visible = false;
                recruitmentList = userRepository.LINQ_GetAllManager(recruitmentList, userModel.Id);
                this.view.ShowHRList(recruitmentList);
            }
            else if (userModel.Roles == "Employee")
            {
                
                view.ButtonAdd.Enabled = false;
                view.ButtonEdit.Visible = false;
                view.ButtonDelete.Visible = false;
            }
            else
            {
                recruitmentList = repository.GetAll();
                this.view.ShowHRList(recruitmentList);
            }
        }
    }
}
