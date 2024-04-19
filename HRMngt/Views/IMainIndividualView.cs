using HRMngt.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMngt.Views
{
    public interface IMainIndividualView
    {
        string ID { get; set; }
        string NameIndividual { get; set; }
        string Status { get; set; }
        string Email { get; set; }
        string Phone { get; set; }
        string Department { get; set; }
        string Sex { get;set; }
        event EventHandler ShowThumbTicketView;
        event EventHandler ShowIndividualSalaryView;
        event EventHandler ShowIndividualCalendarView;

        event EventHandler ShowTimeKeepingView;

        void ShowUserList(IEnumerable<UserModel> userList);

        void Show();
    }
}
