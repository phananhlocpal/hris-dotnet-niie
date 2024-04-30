using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMngt.Views.Dialogs.Interfaces
{
    public interface ILeaveDialog
    {
        string leaveDesription { get; set;  }
        ComboBox cmbLeaveType { get; }

        event EventHandler SubmitEvent;
        event EventHandler ShowLeaveDescription;

        void ShowDialog();
    }
}
