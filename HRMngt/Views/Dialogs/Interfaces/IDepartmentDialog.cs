using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMngt.Views.Dialogs
{
    public interface IDepartmentDialog
    {
        string DepartmentID { get; set; }
        string DepartmentName { get; set; }
        string Phone { get; set; }
        string Manager { get; set; }
        string Address { get; set; }

        event EventHandler AddNewDepartmentDialog;
        event EventHandler EditDepartmentDialog;
    }
}
