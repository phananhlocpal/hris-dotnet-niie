
using Bunifu.UI.WinForms.BunifuButton;
using HRMngt.Models;
using HRMngt.Views.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMngt.View
{
    public interface IUserView
    {
        ComboBox cbDepartment { get; }
        ComboBox cbStatus { get; }
        DataGridView dgvUserList { get; }

        BunifuButton2 ButtonAdd { get; }
        DataGridViewImageColumn ButtonEdit { get; }
        DataGridViewImageColumn ButtonDelete { get; }
        DataGridViewImageColumn ButtonRead { get; }
        // Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler DeleteEvent;
        event EventHandler EditEvent;
        event EventHandler ReadEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;
        event EventHandler SearchByUserId;
        event EventHandler LoadUserDialogToEditEvent;
        event EventHandler LoadUserDialogToAddEvent;
        event EventHandler AddNewDepartmentDialog;
        event EventHandler ExportExcelEvent;

        event EventHandler DeleteAll;
        event EventHandler FilterUser;


        // Methods
        void ShowUserList(IEnumerable<UserModel> userList, UserModel userModel);
        UserDialog ShowUserDialogToAdd();
        UserDialog ShowUserDialogToEdit(string id);
        void Show();
    }
}
