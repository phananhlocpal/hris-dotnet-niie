using HRMngt._Repository;
using HRMngt.Models;
using HRMngt.popup;
using HRMngt.View;
using HRMngt.View.Popup;
using HRMngt.Views;
using HRMngt.Views.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMngt.Presenters
{
    public class DepartmentPresenter
    {
        private IDepartmentView view;

        private IDepartmentRepository repository;
        private DepartmentDiaglog dialog;
        private IEnumerable<DepartmentModel> departments;
        private IEnumerable<DepartmentModel> departmentFilter;
        private UserModel userModel;


        public DepartmentPresenter(IDepartmentView view, IDepartmentRepository repository, UserModel userModel)
        {
            this.view = view;
            this.userModel = userModel;
            this.repository = repository;
            this.view.DeleteEvent += DeleteDepartment;
            this.view.LoadDepartmentDialogToAddEvent += LoadDepartmentDialogToAddEvent;
            this.view.LoadDepartmentDialogToEditEvent += LoadDepartmentDialogToEditEvent;
            this.view.FiterDepartment += FilterDepartment;
            LoadAllDepartmentList();
            SetRole(userModel);
            this.view.ShowDepartmentList(departments);
            this.view.Show();
            
        }

        private void FilterDepartment(object sender, EventArgs e)
        {
            string manager = ExtractIdFromName(view.cbManager.Text);
            string location = view.cbAddress.Text;
            if (view.dgvDepartmentList == null)
            {
                departmentFilter = repository.LINQ_Filter(departments, manager, location);
                this.view.ShowDepartmentList(departmentFilter);
            }
            else
            {
                departmentFilter = repository.LINQ_Filter(departments, manager, location);
                this.view.ShowDepartmentList(departmentFilter);
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
        private void DeleteDepartment(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = view.dgvDepartmentList.CurrentRow;
            string id = selectedRow.Cells[0].Value.ToString();

            // Delete thumbticket by repository
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Bạn có muốn xóa phòng ban này không?", "Xóa phòng ban", buttons);
            if (result == DialogResult.Yes)
            {
                repository.Delete(id);
                SucessPopUp.ShowPopUp();
                LoadAllDepartmentList();
                view.ShowDepartmentList(departments);
            }
        }

        private void LoadDepartmentDialogToEditEvent(object sender, EventArgs e)
        {
            dialog = view.ShowDepartmentDialogToEdit(null);
            DataGridViewRow selectedRow = view.dgvDepartmentList.CurrentRow;
            string id = selectedRow.Cells[0].Value.ToString();
            DepartmentModel department = new DepartmentModel();
            department = repository.LINQ_GetById(departments, id);
            dialog.DepartmentID = department.Id;
            dialog.DepartmentName = department.Name;
            dialog.Phone = department.Phone;
            dialog.Manager = department.Manager;
            dialog.Address = department.Location;
            dialog.EditDepartmentDialog += EditDepartmentDialog;
            dialog.ShowDialog();
        }

        private void LoadDepartmentDialogToAddEvent(object sender, EventArgs e)
        {
            dialog = this.view.ShowDepartmentDialogToAdd();
            dialog.AddNewDepartmentDialog += AddNewDepartmentDialog;
            dialog.ShowDialog();
        }

        private void EditDepartmentDialog(object sender, EventArgs e)
        {
            DepartmentModel department = new DepartmentModel();
            department.Id = dialog.DepartmentID;
            department.Name = dialog.DepartmentName;
            department.Phone = dialog.Phone;
            department.Location = dialog.Address;
            department.Manager = dialog.Manager;
            repository.Edit(department);
            this.dialog.Close();
            LoadAllDepartmentList();
            view.ShowDepartmentList(departments);
            SucessPopUp.ShowPopUp();
        }

        private void LoadAllDepartmentList()
        {
            departments = repository.GetAll();
        }

        private void AddNewDepartmentDialog(object sender, EventArgs e)
        {
            DepartmentModel department = new DepartmentModel();
            /*department.Id = dialog.DepartmentID;*/
            department.Name = dialog.DepartmentName;
            department.Phone = dialog.Phone;
            department.Location = dialog.Address;
            department.Manager = dialog.Manager;
            repository.Add(department);
            this.dialog.Close();
            LoadAllDepartmentList();
            view.ShowDepartmentList(departments);
            SucessPopUp.ShowPopUp();
        }

        private void SetRole(UserModel user)
        {
            if(user.Roles != "Admin")
            {
                view.buttonAdd.Enabled = false;
                view.buttonEdit.Visible = false;
                view.buttonDelete.Visible = false;
            }
        }
    }
}
