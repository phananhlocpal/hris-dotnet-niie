using HRMngt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMngt.Views.Dialogs.Forms
{
    public interface IRequestDialog
    {
        event EventHandler approveEvent;
        event EventHandler NotApproveEvent;

        // Methods
        void ShowRequestDetail(RequestModel requestModel);
    }
}
