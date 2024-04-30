using HRMngt.Models;
using HRMngt.View.Popup;
using HRMngt.Views.Dialogs.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMngt.Views.Request
{
    public interface IRequestView
    {
        DataGridView DataGridViewRequest { get; }
        DateTimePicker dtpChooseMonth { get; }
        ComboBox cmbChooseType { get; }
        TextBox txtChooseUserId { get; }
        ComboBox cmbChooseStatus { get; }
        // Events
        event EventHandler ShowRequestDialog;
        event EventHandler Filter;

        // Methods
        RequestDialog ShowRequestDialogToUpdate();
        void ShowAllRequestList(IEnumerable<RequestModel> requestList);
        void Show();
    }
}
