using HRMngt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace HRMngt.Views.Dialogs
{
    public interface IIndividualCalendarDialogForEditting
    {
        string userId { get; set; }
        string userName { get; set; }
        string userDepartment { get; set; } 
        DateTime date { get; set; }
        TimeSpan checkIn { get; set; }
        TimeSpan checkOut { get; set; }
        TimeSpan? realCheckIn { get; set; }
        TimeSpan? realCheckOut { get; set; }
        string status { get; set; }

        event EventHandler UpdateEvent;

        // Methods
        void ShowCalendarInfo(CalendarModel calendarModel);
    }
}
