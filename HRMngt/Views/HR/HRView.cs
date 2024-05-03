using ComponentFactory.Krypton.Toolkit;
using HRMngt.Model;
using HRMngt.Views.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMngt.Views.HR
{
    public partial class HRView : Form, IHRView
    {
        public HRView()
        {
            InitializeComponent();
            RunEvent();
        }

        public void RunEvent()
        {
            btnAdd.Click += delegate { LoadHRToAdd?.Invoke(this, EventArgs.Empty); };
        }

        ComboBox IHRView.cbDepartment => cbDepartment;

        ComboBox IHRView.cbStatus => cbStatus;

        KryptonDataGridView IHRView.dgvHRList => dgvHRList;

        public event EventHandler AddNewHR;
        public event EventHandler EditNewHR;
        public event EventHandler DeleteHR;
        public event EventHandler LoadHRToAdd;
        public event EventHandler LoadHRToEdit;

        private static HRView instance;
        public static HRView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new HRView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }
        public void ShowHRList()
        {
            throw new NotImplementedException();
        }

        public void ShowHRList(IEnumerable<UserModel> recuitList)
        {
            if (recuitList != null)
            {
                dgvHRList.Rows.Clear();

                foreach (var user in recuitList)
                {
                    int rowIndex = dgvHRList.Rows.Add();
                    dgvHRList.Rows[rowIndex].Cells[0].Value = user.Id;
                    dgvHRList.Rows[rowIndex].Cells[1].Value = user.Name;
                    dgvHRList.Rows[rowIndex].Cells[2].Value = user.Contract_type;
                    dgvHRList.Rows[rowIndex].Cells[3].Value = user.Position;
                    dgvHRList.Rows[rowIndex].Cells[4].Value = user.Roles;
                    dgvHRList.Rows[rowIndex].Cells[5].Value = "• " + user.Status;
                    
                    if (user.Status == "Đang làm")
                    {
                        dgvHRList.Rows[rowIndex].Cells[5].Style.ForeColor = Color.FromArgb(69, 158, 26);
                    }
                    else
                    {
                        dgvHRList.Rows[rowIndex].Cells[5].Style.ForeColor = Color.Red;
                    }
                }
            }
            else dgvHRList.Rows.Clear();
        }

        public HRDialog ShowDialogToAdd()
        {
            HRDialog dialog = new HRDialog();
            return dialog;
        }

        public HRDialog ShowDialogToEdit(string id)
        {
            throw new NotImplementedException();
        }
    }
}
