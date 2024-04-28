using HRMngt.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMngt.Views
{
    public interface IMainView
    {
        Image pictureAvatar { set; }
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
        void ShowUserInformation(UserModel userModel);
        void Hide();
    }
}
