using HRMngt.Model;
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

        event EventHandler DeleteAll;


        // Methods
        void ShowUserList(IEnumerable<UserModel> userList);
        UserDialog ShowUserDialogToAdd();
        UserDialog ShowUserDialogToEdit();
        void Show();
    }
}
