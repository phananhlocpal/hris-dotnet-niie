using HRMngt._Repository;
using HRMngt._Repository.HR;
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
        private IRecruitView view;
        private IRecruitRepository repository;
        private IEnumerable<RecruitModel> recuitList;
        private RecruitDialog dialog;

        public RecruitPresenter(IRecruitView view, IRecruitRepository repository)
        {
            this.view = view;
            this.repository = repository;


            this.view.LoadHRToAdd += LoadHRToAddRecuit;
            this.view.LoadHRToEdit += LoadRecruitToEdit;
            this.view.DeleteHR += DeleteHR;
           
            LoadAllRecuit();
            this.view.ShowHRList(recuitList);
            this.view.Show();
        }

       

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
                LoadAllRecuit();
                view.ShowHRList(recuitList);
                SucessPopUp.ShowPopUp();
            }
        }

        private void LoadRecruitToEdit(object sender, EventArgs e)
        {
            dialog = view.ShowDialogToEdit(null);
            IEnumerable<UserModel> userList;
            List<string> departmentIDNameList = new List<string>();
            var repo = new UserRepository();
            userList = repo.GetAll();
            departmentIDNameList = repo.GetDepartmentIDName();
            this.dialog.ShowDepartmentIdNName(departmentIDNameList);
            dialog.ShowUserIDName(userList);
            DataGridViewRow selectedRow = view.dgvHRList.CurrentRow;
            string id = selectedRow.Cells[0].Value.ToString();
            RecruitModel recruit = new RecruitModel();
            recruit = repository.GetById(id);
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
            dialog.DepartmentName = recruit.DepartmentName;
            dialog.ManagerName = recruit.ManagerName;
            
            dialog.EditNewDialog += EditRecruitDialog;
            /*dialog.CancleEvent += CancleEvent;*/
            dialog.ShowDialog();
        }

        private void EditRecruitDialog(object sender, EventArgs e)
        {
            RecruitModel recruit = new RecruitModel();
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
            recruit.DepartmentName = dialog.DepartmentName;
            recruit.ManagerName = dialog.ManagerName;

            repository.Edit(recruit);
            UpdateUserIfOnboarding(recruit);
            this.dialog.Close();
            LoadAllRecuit();
            view.ShowHRList(recuitList);
            SucessPopUp.ShowPopUp();
        }
        private void UpdateUserIfOnboarding(RecruitModel recruit)
        {
            if (recruit.Status == "On-boarding")
            {
                repository.UpdateRecruitToUser(recruit);
            }
        }
        private void LoadAllRecuit()
        {
            recuitList = repository.GetAll();
        }

        private void LoadHRToAddRecuit(object sender, EventArgs e)
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
            RecruitModel recruit = new RecruitModel();
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
            recruit.DepartmentName = dialog.DepartmentName;
            recruit.ManagerName = dialog.ManagerName;
            
            repository.Add(recruit);
            this.dialog.Close();
            LoadAllRecuit();
            view.ShowHRList(recuitList);
            SucessPopUp.ShowPopUp();
        }
    }
}
