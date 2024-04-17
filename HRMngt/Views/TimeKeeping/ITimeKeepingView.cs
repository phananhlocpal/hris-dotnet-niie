using HRMngt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMngt.Views.Dialogs
{
    public interface ITimeKeepingView
    {
        event EventHandler FilterEvent;
        event EventHandler LoadTCalendarDialogToEditEvent;
        event EventHandler DeleteEvent;
        event EventHandler ApproveEvent;
        event EventHandler NotApproveEvent;

        // Methods
        IndividualCalendarDialogForEditting ShowCalendarDialogToEdit(string id);
        void ShowCalendarList(IEnumerable<CalendarModel> calendarList);
        void Show();
    }
}
