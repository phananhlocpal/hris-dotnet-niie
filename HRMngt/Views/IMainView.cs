using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMngt.Views
{
    public interface IMainView
    {
        event EventHandler ShowDepartmentView;
        event EventHandler ShowThumbTicketView;
        event EventHandler ShowHomeView;
        event EventHandler ShowUserView;
        event EventHandler ShowSupportView;
        event EventHandler ShowSalaryView;
        event EventHandler ShowLoginEvent;
        event EventHandler ShowRecuitView;
        event EventHandler ShowTimeKeepingView;
        event EventHandler ShowIndividualSalaryView;
        event EventHandler ShowMainIndividualView;
        event EventHandler ShowCommunicateView;
        void Show();
    }
}
