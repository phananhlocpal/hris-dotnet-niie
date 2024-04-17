﻿using ComponentFactory.Krypton.Toolkit;
using HRMngt.Model;
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

        event EventHandler DeleteHR;
        event EventHandler LoadHRToAdd;
        event EventHandler LoadHRToEdit;
        
        void Show();
        void ShowHRList(IEnumerable<RecruitModel> recuitList);
        RecruitDialog ShowDialogToAdd();
        RecruitDialog ShowDialogToEdit(string id);
    }
}