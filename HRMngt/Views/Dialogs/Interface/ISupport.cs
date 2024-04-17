using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace HRMngt.Views.Dialogs
{
    public interface ISupport
    {
        string content { get; set; }
        KryptonButton btnSend { get; set; }
        KryptonButton btnBack { get; set; }

        event EventHandler Send;
        event EventHandler Back;

        void Show();
    }
}
