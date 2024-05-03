using HRMngt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMngt.Views.Dialogs.Interfaces
{
    public interface ISalaryDialogForEditing
    {
        event EventHandler updateEvent;
        event EventHandler approveEvent;

        void ShowSalaryInfo(SalaryModel salaryModel);
        void ShowDialog();
        SalaryModel GetChangedInfo();

        void Close();
    }
}
