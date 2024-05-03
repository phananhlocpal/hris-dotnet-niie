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
    public interface ITimeKeepingView
    {
        DateTimePicker dtpStart {  get; set; }
        DateTimePicker dtpEnd { get; set; }
        ComboBox cmbStatus { get; set; } 
        ComboBox cmbDepartment { get; set; }
        TextBox txtUserId { get; set; }
        DataGridView dgvTimeKeepingTable { get; set; }

        event EventHandler FilterEvent;
        event EventHandler LoadTCalendarDialogToEditEvent;
        event EventHandler DeleteEvent;
        event EventHandler ApproveEvent;
        event EventHandler NotApproveEvent;

        // Methods
        IndividualCalendarDialogForEditting ShowCalendarDialogToEdit();
        void ShowCalendarList(IEnumerable<CalendarModel> calendarList);
        void ShowDepartmentList(IEnumerable<DepartmentModel> departmentList);
        void Show();
    }
}
