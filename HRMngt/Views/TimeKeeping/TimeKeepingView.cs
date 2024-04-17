using HRMngt.Models;
using HRMngt.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMngt.Views.Dialogs
{
    public partial class TimeKeepingView : Form, ITimeKeepingView
    {
        public TimeKeepingView()
        {
            InitializeComponent();
            RunEvent();
        }
        private void RunEvent()
        {
            dtpStart.ValueChanged += delegate { FilterEvent?.Invoke(this, EventArgs.Empty); };
            dtpEnd.ValueChanged += delegate { FilterEvent?.Invoke(this, EventArgs.Empty); };
            cmbDepartment.SelectedValueChanged += delegate { FilterEvent?.Invoke(this, EventArgs.Empty); };
            cmbStatus.SelectedValueChanged += delegate { FilterEvent?.Invoke(this, EventArgs.Empty); };
            // Edit Event
            dgvTimeKeepingTable.CellContentClick += (sender, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == dgvTimeKeepingTable.Columns[9].Index)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            // Delete Event
            dgvTimeKeepingTable.CellContentClick += (sender, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == dgvTimeKeepingTable.Columns[9].Index)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            // Approve Event
            dgvTimeKeepingTable.CellContentClick += (sender, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == dgvTimeKeepingTable.Columns[9].Index)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            // Not Approve Event
            dgvTimeKeepingTable.CellContentClick += (sender, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == dgvTimeKeepingTable.Columns[9].Index)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                }
            };
        }

        public event EventHandler FilterEvent;
        public event EventHandler LoadTCalendarDialogToEditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler ApproveEvent;
        public event EventHandler NotApproveEvent;

        public IndividualCalendarDialogForEditting ShowCalendarDialogToEdit(string id)
        {
            IndividualCalendarDialogForEditting calendarDialog = new IndividualCalendarDialogForEditting();
            return calendarDialog;
        }

        public void ShowCalendarList(IEnumerable<CalendarModel> calendarList)
        {
            dgvTimeKeepingTable.Rows.Add();
            DataGridViewCell cell = dgvTimeKeepingTable.Rows[0].Cells[0];
            Panel panel = ShowIndividualInfo("yourId");
            cell.Value = panel;
            //cell.Value = "Hi";
            //if (calendarList != null)
            //{
            //    dgvTimeKeepingTable.Rows.Clear();

            //    foreach (var calendarModel in calendarList)
            //    {
            //        int rowIndex = dgvTimeKeepingTable.Rows.Add();
            //        //DataGridViewCell cell = dgvTimeKeepingTable.Rows[0].Cells[0];
            //        //Panel panel = ShowIndividualInfo("yourId"); 
            //        //cell.Value = panel;
            //        //dgvTimeKeepingTable.Rows[rowIndex].Cells[0].Controls.Add(panel);
            //        //dgvTimeKeepingTable.Rows[rowIndex].Cells[1].Value = "• " + thumbTicketModel.Type;
            //        //dgvTimeKeepingTable.Rows[rowIndex].Cells[2].Value = thumbTicketModel.Date;
            //        //dgvTimeKeepingTable.Rows[rowIndex].Cells[3].Value = thumbTicketModel.Receiver;
            //        //dgvTimeKeepingTable.Rows[rowIndex].Cells[4].Value = thumbTicketModel.Reason;
            //        //dgvTimeKeepingTable.Rows[rowIndex].Cells[5].Value = thumbTicketModel.Money.ToString("#,##0");
            //        //dgvTimeKeepingTable.Rows[rowIndex].Cells[6].Value = "• " + thumbTicketModel.Status;


            //    }
            //}
            //else dgvTimeKeepingTable.Rows.Clear();
        }

        private Panel ShowIndividualInfo(string id)
        {
            // Init control
            Panel panel = new Panel();
            Label ava = new Label();
            Label userId = new Label();
            userId.Size = new Size(200, 100);
            userId.Text = "222";
            Label name = new Label();
            Label role = new Label();

            // Add control to panel
            panel.Controls.Add(ava);
            panel.Controls.Add(userId);
            panel.Controls.Add(name);
            panel.Controls.Add(role);
            panel.Size = new Size(200, 100);


            // Define the position
            ava.Dock = DockStyle.Left;

            return panel;

        }


        private static TimeKeepingView instance;
        public static TimeKeepingView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new TimeKeepingView();
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
