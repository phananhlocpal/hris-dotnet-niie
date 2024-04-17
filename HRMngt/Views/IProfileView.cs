using HRMngt.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMngt.Views
{
    public interface IProfileView
    {
        string userID { get; set; }
        string name { get; set; }
        string email { get; set; }
        string phone { get; set; }
        string address { get; set; }
        string sex { get; set; }
        string position { get; set; }

        void ShowUserList(IEnumerable<UserModel> userList);
    }
}
