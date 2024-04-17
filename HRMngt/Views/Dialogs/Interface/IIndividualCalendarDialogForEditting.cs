using HRMngt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMngt.Views.Dialogs
{
    public interface IIndividualCalendarDialogForEditting
    {
        event EventHandler UpdateEvent;

        // Methods
        void ShowCalendarInfo(CalendarModel calendarModel);
    }
}
