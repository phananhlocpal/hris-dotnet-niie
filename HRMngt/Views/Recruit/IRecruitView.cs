using Bunifu.UI.WinForms.BunifuButton;
using ComponentFactory.Krypton.Toolkit;
using HRMngt.Models;
using HRMngt.Views.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMngt.Views.HR
{
    public interface IRecruitView
    {
        ComboBox cbDepartment { get; }
        ComboBox cbStatus { get; }
        KryptonDataGridView dgvHRList { get; }
        SaveFileDialog saveFile { get; }

        BunifuButton2 ButtonAdd { get; }
        DataGridViewImageColumn ButtonEdit { get; }
        DataGridViewImageColumn ButtonDelete { get; }
        DataGridViewImageColumn ButtonRead { get; }

        event EventHandler DeleteHR;
        event EventHandler LoadHRToAdd;
        event EventHandler LoadHRToEdit;
        event EventHandler FilterRecruitment;

        void Show();
        void ShowHRList(IEnumerable<UserModel> recuitList);
        RecruitDialog ShowDialogToAdd();
        RecruitDialog ShowDialogToEdit(string id);
    }
}
