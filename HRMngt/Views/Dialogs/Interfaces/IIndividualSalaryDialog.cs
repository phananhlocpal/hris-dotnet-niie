using HRMngt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMngt.Views.Dialogs
{
    public interface IIndividualSalaryDialog
    {
        RichTextBox rtbRes { get; }
        TextBox txtWelfare { get; }

        event EventHandler ConfirmEvent;
        event EventHandler ResponseEvent;
        event EventHandler ComplainEvent;
        event EventHandler UpdateEvent;
        event EventHandler ApproveEvent;

        // Methods
        void ShowSalaryInfo(SalaryModel salaryModel, UserModel userModel);

        void ShowDialog();
        void Close();
    }
}
