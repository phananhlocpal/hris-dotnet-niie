using HRMngt.Models;
using HRMngt.popup;
using HRMngt.View.Popup;
using HRMngt.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMngt.View
{
    public partial class ThumbTicketView : Form, IThumbTicketView
    {
        public ThumbTicketView()
        {
            InitializeComponent();
            RunEvent();
        }
        public DataGridView DataGridView => dgvThumbTicketTable;

        public TextBox txtChooseUserId => txtChooseUserId;

        ComboBox IThumbTicketView.cmbChooseMonth => cmbChooseMonth;

        ComboBox IThumbTicketView.cmbChooseType => cmbChooseType;

        public event EventHandler LoadThumbTicketDialogToAddEvent;
        public event EventHandler LoadThumbTicketDialogToEditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SearchByMonthEvent;
        public event EventHandler SearchByTypeEvent;
        public event EventHandler SearchByUserId;

        private void RunEvent()
        {
            SucessPopUp.ShowPopUp();
            // Add Event
            btnCreateThumbTicket.Click += delegate { LoadThumbTicketDialogToAddEvent?.Invoke(this, EventArgs.Empty); };
            // Delete Event         
            dgvThumbTicketTable.CellContentClick += (sender, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == dgvThumbTicketTable.Columns[9].Index)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            // Update Event
            dgvThumbTicketTable.CellContentClick += (sender, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == dgvThumbTicketTable.Columns[8].Index)
                {
                    LoadThumbTicketDialogToEditEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            // Read Event
            dgvThumbTicketTable.CellContentClick += (sender, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == dgvThumbTicketTable.Columns[7].Index)
                {
                    LoadThumbTicketDialogToEditEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            // Search by month
            cmbChooseMonth.SelectedIndexChanged += delegate { SearchByMonthEvent?.Invoke(this, EventArgs.Empty); };
            // Search by type
            cmbChooseType.SelectedIndexChanged += delegate { SearchByTypeEvent?.Invoke(this, EventArgs.Empty); };
            // Search by user ID
            txtChooseUserID.TextChanged += delegate { SearchByUserId?.Invoke(this, EventArgs.Empty); };
        }

        // (Read) Show all Thumb Ticket 
        public void ShowAllThumbTicketList(IEnumerable<ThumbTicketModel> thumbTicketList)
        {
            if (thumbTicketList != null)
            {
                dgvThumbTicketTable.Rows.Clear();

                foreach (var thumbTicketModel in thumbTicketList)
                {
                    int rowIndex = dgvThumbTicketTable.Rows.Add();
                    dgvThumbTicketTable.Rows[rowIndex].Cells[0].Value = thumbTicketModel.Id;
                    dgvThumbTicketTable.Rows[rowIndex].Cells[1].Value = "• " + thumbTicketModel.Type;
                    dgvThumbTicketTable.Rows[rowIndex].Cells[2].Value = thumbTicketModel.Date;
                    dgvThumbTicketTable.Rows[rowIndex].Cells[3].Value = thumbTicketModel.Receiver;
                    dgvThumbTicketTable.Rows[rowIndex].Cells[4].Value = thumbTicketModel.Reason;
                    dgvThumbTicketTable.Rows[rowIndex].Cells[5].Value = thumbTicketModel.Money.ToString("#,##0");
                    dgvThumbTicketTable.Rows[rowIndex].Cells[6].Value = "• " + thumbTicketModel.Status;
                    if (thumbTicketModel.Type == "Thumb Up")
                    {
                        dgvThumbTicketTable.Rows[rowIndex].Cells[1].Style.ForeColor = Color.FromArgb(69, 158, 26);
                    }
                    else
                    {
                        dgvThumbTicketTable.Rows[rowIndex].Cells[1].Style.ForeColor = Color.Red;
                    }
                }
            }
            else dgvThumbTicketTable.Rows.Clear();
        }

        public void ShowIndividualThumbTicketList(IEnumerable<ThumbTicketModel> thumbTicketList)
        {
            if (thumbTicketList != null)
            {
                dgvThumbTicketTable.Rows.Clear();

                foreach (var thumbTicketModel in thumbTicketList)
                {
                    int rowIndex = dgvThumbTicketTable.Rows.Add();
                    dgvThumbTicketTable.Rows[rowIndex].Cells[0].Value = thumbTicketModel.Id;
                    dgvThumbTicketTable.Rows[rowIndex].Cells[1].Value = "• " + thumbTicketModel.Type;
                    dgvThumbTicketTable.Rows[rowIndex].Cells[2].Value = thumbTicketModel.Date;
                    dgvThumbTicketTable.Rows[rowIndex].Cells[3].Value = thumbTicketModel.Receiver;
                    dgvThumbTicketTable.Rows[rowIndex].Cells[4].Value = thumbTicketModel.Reason;
                    dgvThumbTicketTable.Rows[rowIndex].Cells[5].Value = thumbTicketModel.Money.ToString("#,##0");
                    dgvThumbTicketTable.Rows[rowIndex].Cells[6].Value = "• " + thumbTicketModel.Status;
                    if (thumbTicketModel.Type == "Thumb Up")
                    {
                        dgvThumbTicketTable.Rows[rowIndex].Cells[1].Style.ForeColor = Color.FromArgb(69, 158, 26);
                    }
                    else
                    {
                        dgvThumbTicketTable.Rows[rowIndex].Cells[1].Style.ForeColor = Color.Red;
                    }
                }
            }
            else dgvThumbTicketTable.Rows.Clear();
        }

        // (Create) Add new thumbs or tickets
        public ThumbTicketDialog ShowThumbTicketDialogToAdd()
        {
            ThumbTicketDialog thumbTicketDialog = new ThumbTicketDialog("Create");
            return thumbTicketDialog;
        }
        // (Read) Read thumbs or tickets
        public ThumbTicketDialog ShowThumbTicketDialogToView()
        {
            ThumbTicketDialog thumbTicketDialog = new ThumbTicketDialog("View");
            return thumbTicketDialog;
        }
        // (Update) Update thumbs or tickets
        public ThumbTicketDialog ShowThumbTicketDialogToUpdate(string id)
        {
            ThumbTicketDialog thumbTicketDialog = new ThumbTicketDialog("Update");
            return thumbTicketDialog;
        }

        private static ThumbTicketView instance;
        public static ThumbTicketView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ThumbTicketView();
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
