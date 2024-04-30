using ComponentFactory.Krypton.Toolkit;
using HRMngt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMngt.Views.Dialogs
{
    public interface IIndividualCalendarView
    {
        KryptonDataGridView dgvCalendarTable { get; set; }
        DateTimePicker dtpChoosePeriod { get; set; }
        // Events
        event EventHandler SearchByPeriodEvent;
        event EventHandler ViewCurrentCalendarEvent;
        event EventHandler LoadCalendarDialogToUpdateEvent;
        event EventHandler DeleteCalendarEvent;
        event EventHandler LoadCalendarDialogToCreateEvent;
        event EventHandler LoadLeaveDialogEvent;
        event EventHandler Filter;
        event EventHandler LeaveEvent;

        // Methods
        IndividualCalendarDialogForEditting ShowCalendarDialogToEdit();
        IndividualCalendarDialogForAdding ShowCalendarDialogToAdd();


        void ShowCalendarList(IEnumerable<CalendarModel> CalendarList);
        void Show();
    }
}
