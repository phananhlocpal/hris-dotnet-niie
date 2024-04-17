using HRMngt.Models;
using HRMngt.View.Popup;
using HRMngt.Views.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMngt.Views
{
    public interface IDepartmentView
    {
        ComboBox cbDepartment { get; }
        ComboBox cbStatus { get; }
        DataGridView dgvDepartmentList { get; }

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler DeleteEvent;
        event EventHandler EditEvent;
        event EventHandler ReadEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;
        event EventHandler SearchByUserId;
        event EventHandler LoadDepartmentDialogToAddEvent;
        event EventHandler LoadDepartmentDialogToEditEvent;
        event EventHandler AddNewDepartmentDialog;

        //ThumbTicketDialog ShowThumbTicketDialogToAdd();
        //ThumbTicketDialog ShowThumbTicketDialogToUpdate(string id);
        DepartmentDiaglog ShowDepartmentDialogToAdd();
        DepartmentDiaglog ShowDepartmentDialogToEdit(string id);
        void ShowDepartmentList(IEnumerable<DepartmentModel> departments);
        void Show();
        
    }
}
