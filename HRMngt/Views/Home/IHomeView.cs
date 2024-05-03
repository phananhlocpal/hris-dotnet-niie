using HRMngt.Views.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace HRMngt.Views
{
    public interface IHomeView
    {
        event EventHandler LoadToAddCalandar;
        

        AttendanceDialog ShowAttendanceDialog();

        void Show();
        void ShowNavName(string navName);

    }
}
