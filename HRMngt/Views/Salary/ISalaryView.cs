using HRMngt.Models;
using HRMngt.Views.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMngt.Views.Salary
{
    public interface ISalaryView
    {
        ComboBox cmbDepartment { get; }
        ComboBox cmbStatus { get; }
        DataGridView dgvSalaryTable { get; }
        DateTimePicker dtpChooseMonth { get; }

        event EventHandler FilterEvent;
        event EventHandler ShowSalaryTableEvent;
        event EventHandler ExportSalaryEvent;
        event EventHandler ApproveAllEvent;
        event EventHandler ExportExcelEvent;
        event EventHandler LoadSalaryDialogToEditEvent;
        event EventHandler DeleteEvent;
        

        DepartmentDiaglog ShowSalaryDialogToAdd();
        DepartmentDiaglog ShowSalaryDialogToEdit(string id);
        void ShowSalaryList(IEnumerable<SalaryModel> salaryList);
        void LoadDepartmentCmb(IEnumerable<DepartmentModel> departmentList);
        void Show();
    }
}
