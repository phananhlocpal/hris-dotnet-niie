using HRMngt.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMngt.Views.Dialogs
{
    public interface IHRDialog
    {
        string NameCadidate { get; set; }
        string Email { get; set; }
        string Address { get; set; }
        string Sex { get; set; }
        string Phone { get; set; }
        DateTime Birthday { get;set; }
        string Position { get; set; }
        string Roles { get; set; }
        string Note { get; set;}
        string Status { get; set; }
        string Contract_type { get; set; }
        

        
        event EventHandler LoadAddDialogHR;
        event EventHandler LoadEditDialogHR;
        void Show();
        void ShowRecruitList(IEnumerable<UserModel> recruits);



    }
}
