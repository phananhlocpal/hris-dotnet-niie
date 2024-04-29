using HRMngt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMngt.Views.Dialogs
{
    public interface IIndividualSalaryDialog
    {
        event EventHandler ConfirmEvent;
        event EventHandler ResponseEvent;

        // Methods
        void ShowSalaryInfo(SalaryModel salaryModel, UserModel userModel);
    }
}
