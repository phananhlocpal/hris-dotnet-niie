using HRMngt.Models;
using HRMngt.View.Popup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMngt.Views
{
    public interface IThumbTicketView
    {
        DataGridView DataGridView { get; }
        TextBox txtChooseUserId { get; }
        DateTimePicker dtpchooseMonth { get; }
        ComboBox cmbChooseType { get; }
        Button btnCreate { get; set; }


        // Events
        event EventHandler FilterEvent;
        event EventHandler LoadThumbTicketDialogToAddEvent;
        event EventHandler LoadThumbTicketDialogToEditEvent;
        event EventHandler DeleteEvent;

        // Methods
        ThumbTicketDialog ShowThumbTicketDialogToAdd();
        ThumbTicketDialog ShowThumbTicketDialogToUpdate(string id);
        void ShowAllThumbTicketList(IEnumerable<ThumbTicketModel> thumbTicketList);
        void ShowIndividualThumbTicketList(IEnumerable<ThumbTicketModel> thumbTicketList);
        void Show();
    }
}
