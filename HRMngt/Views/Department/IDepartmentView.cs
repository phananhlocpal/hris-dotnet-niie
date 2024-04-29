using Bunifu.UI.WinForms.BunifuButton;
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
        ComboBox cbManager { get; }
        ComboBox cbAddress { get; }
        DataGridView dgvDepartmentList { get; }

        BunifuButton2 buttonAdd { get; }
        DataGridViewImageColumn buttonEdit { get; }
        DataGridViewImageColumn buttonDelete { get; }
        DataGridViewImageColumn buttonRead { get; }

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler DeleteEvent;
        event EventHandler EditEvent;
        event EventHandler ReadEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;
        event EventHandler LoadDepartmentDialogToAddEvent;
        event EventHandler LoadDepartmentDialogToEditEvent;
        event EventHandler AddNewDepartmentDialog;
        event EventHandler FiterDepartment;
        //ThumbTicketDialog ShowThumbTicketDialogToAdd();
        //ThumbTicketDialog ShowThumbTicketDialogToUpdate(string id);
        DepartmentDiaglog ShowDepartmentDialogToAdd();
        DepartmentDiaglog ShowDepartmentDialogToEdit(string id);
        void ShowDepartmentList(IEnumerable<DepartmentModel> departments);
        void Show();

    }
}
