using HRMngt.Models;
using HRMngt.View;
using HRMngt.View.Popup;
using HRMngt.Views.Dialogs.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMngt.Views.Request
{
    public partial class RequestView : Form, IRequestView
    {
        public DataGridView DataGridViewRequest => dgvRequestTable;

        DateTimePicker IRequestView.dtpChooseMonth => dtpChooseMonth;

        ComboBox IRequestView.cmbChooseType => cmbChooseType;

        TextBox IRequestView.txtChooseUserId => txtChooseUserID;

        ComboBox IRequestView.cmbChooseStatus => cmbChooseStatus;

        public RequestView()
        {
            InitializeComponent();
            RunEvent();
        }

        private void RunEvent()
        {
            dgvRequestTable.CellContentClick += (sender, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == dgvRequestTable.Columns[5].Index)
                {
                    ShowRequestDialog?.Invoke(this, EventArgs.Empty);
                }
            };
            dtpChooseMonth.ValueChanged += delegate { Filter?.Invoke(this, EventArgs.Empty); };
            cmbChooseType.SelectedIndexChanged += delegate { Filter?.Invoke(this, EventArgs.Empty); };
            txtChooseUserID.TextChanged += delegate { Filter?.Invoke(this, EventArgs.Empty); };
            cmbChooseStatus.SelectedIndexChanged += delegate { Filter?.Invoke(this, EventArgs.Empty); };

        }

        public event EventHandler ShowRequestDialog;
        public event EventHandler Filter;



        public RequestDialog ShowRequestDialogToUpdate()
        {
            RequestDialog requestDialog = new RequestDialog();
            return requestDialog;
        }

        public void ShowAllRequestList(IEnumerable<RequestModel> requestList)
        {
            dgvRequestTable.Rows.Clear();
            foreach (RequestModel request in requestList)
            {
                int rowIndex = dgvRequestTable.Rows.Add();
                dgvRequestTable.Rows[rowIndex].Cells[0].Value = request.Id;
                dgvRequestTable.Rows[rowIndex].Cells[1].Value = request.Type;
                dgvRequestTable.Rows[rowIndex].Cells[2].Value = request.Time;
                dgvRequestTable.Rows[rowIndex].Cells[3].Value = request.Sender;
                if (request.Status == 0)
                       dgvRequestTable.Rows[rowIndex].Cells[4].Value = "Chưa xử lý";
                else dgvRequestTable.Rows[rowIndex].Cells[4].Value = "Đã xử lý";
            }

        }

        private static RequestView instance;
        public static RequestView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new RequestView();
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
    }
}
