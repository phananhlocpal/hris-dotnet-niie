using HRMngt.Model;
using HRMngt.View.Popup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMngt.View
{
    public interface IThumbTicketDialog
    {
        string Id { get; set; }
        string Type { get; set; }
        DateTime Date { get; set; }
        string Sender { get; set; }
        string Receiver { get; set; }
        string Reason { get; set; }
        int Money { get; set; }
        string Complain { get; set; }
        string Response { get; set; }
        string Status { get; set; }

        // Events
        event EventHandler SaveAddEvent;
        event EventHandler SaveUpdateEvent;
        event EventHandler ShowUserList;
        event EventHandler ComplainEvent;
        event EventHandler ResponseEvent;

        void ShowUserIdNName(List<string> userIdNNameList);
    }
}
