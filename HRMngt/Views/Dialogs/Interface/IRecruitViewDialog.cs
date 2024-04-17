using HRMngt.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMngt.Views.Dialogs
{
    public interface IRecruitViewDialog
    {
        string ID { get;set;}
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
        string DepartmentName { get; set; }
        string ManagerName { get; set; }
        



        event EventHandler AddNewDialog;
        event EventHandler EditNewDialog;
        event EventHandler ClearTextForm;
        event EventHandler CloseForm;
        event EventHandler CheckConditionBirthday;
        event EventHandler CheckConditionPhone;
        event EventHandler CheckConditionEmail;
        void Show();
        void ShowRecruitList(IEnumerable<UserModel> recruits);

        void ShowUserIDName(IEnumerable<UserModel> users);
        void ShowDepartmentIdNName(List<string> departmentIDNameList);




    }
}
