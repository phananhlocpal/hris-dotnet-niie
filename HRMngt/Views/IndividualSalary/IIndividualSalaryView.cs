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
    public interface IIndividualSalaryView
    {
        KryptonDataGridView dgvSalaryTable { get; }
        DateTimePicker dtpChooseMonth { get; }
        // Events
        event EventHandler SearchByMonthEvent;
        event EventHandler LoadSalaryDialogToViewEvent;
        event EventHandler ExportExcelEvent;
        event EventHandler ViewResumeEvent;

        // Methods
        IndividualSalaryDialog ShowSalaryDialogToView();
        void ShowSalaryList(IEnumerable<CalendarModel> SalaryList);
        void Show();
    }
}
