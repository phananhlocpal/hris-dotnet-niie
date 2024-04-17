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
        ComboBox cbDepartment { get; }
        ComboBox cbStatus { get; }
        DataGridView dgvSalaryList { get; }

        event EventHandler CheckSalary;
        event EventHandler LoadSalaryToEdit;
        event EventHandler LoadSalaryToDelete;
        

        //ThumbTicketDialog ShowThumbTicketDialogToAdd();
        //ThumbTicketDialog ShowThumbTicketDialogToUpdate(string id);
        DepartmentDiaglog ShowSalaryDialogToAdd();
        DepartmentDiaglog ShowSalaryDialogToEdit(string id);
        void ShowSalaryList(IEnumerable<SalaryListModel> salaryList);
        void Show();
    }
}
