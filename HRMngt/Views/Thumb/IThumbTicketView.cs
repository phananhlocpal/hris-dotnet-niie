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
        ComboBox cmbChooseMonth { get; }
        ComboBox cmbChooseType { get; }


        // Events
        event EventHandler SearchByMonthEvent;
        event EventHandler SearchByTypeEvent;
        event EventHandler SearchByUserId;
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
