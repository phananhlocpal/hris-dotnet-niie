using ComponentFactory.Krypton.Toolkit;
using HRMngt.Models;
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
    public partial class IndividualCalendarView : Form, IIndividualCalendarView
    {
        public IndividualCalendarView()
        {
            InitializeComponent();
            cmbStatus.SelectedIndex = 0;
            RunEvent();
        }
        private void RunEvent()
        {
            dtpChoosePeriod.ValueChanged += delegate { Filter?.Invoke(this, EventArgs.Empty); };
            btnCurrentDate.Click += delegate { ViewCurrentCalendarEvent?.Invoke(this, EventArgs.Empty); };
            btnCreate.Click += delegate { LoadCalendarDialogToCreateEvent?.Invoke(this, EventArgs.Empty); };
            // Delete Event         
            dgvCalendarTable.CellContentClick += (sender, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == dgvCalendarTable.Columns[7].Index)
                {
                    DeleteCalendarEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            // Update Event
            dgvCalendarTable.CellContentClick += (sender, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == dgvCalendarTable.Columns[6].Index)
                {
                    LoadCalendarDialogToUpdateEvent?.Invoke(this, EventArgs.Empty);
                }
            };

            btnCreateLeave.Click += delegate { LoadLeaveDialogEvent?.Invoke(this, EventArgs.Empty); };
            cmbStatus.SelectedIndexChanged += delegate { Filter?.Invoke(this, EventArgs.Empty); };
        }

        KryptonDataGridView IIndividualCalendarView.dgvCalendarTable { get => dgvCalendarTable; set => throw new NotImplementedException(); }
        DateTimePicker IIndividualCalendarView.dtpChoosePeriod { get => dtpChoosePeriod; set => throw new NotImplementedException(); }
        ComboBox IIndividualCalendarView.cmbStatus { get => cmbStatus; set => throw new NotImplementedException(); }

        public event EventHandler SearchByPeriodEvent;
        public event EventHandler ViewCurrentCalendarEvent;
        public event EventHandler LoadCalendarDialogToUpdateEvent;
        public event EventHandler DeleteCalendarEvent;
        public event EventHandler LoadCalendarDialogToCreateEvent;
        public event EventHandler Filter;
        public event EventHandler LeaveEvent;
        public event EventHandler LoadLeaveDialogEvent;

        public IndividualCalendarDialogForEditting ShowCalendarDialogToEdit()
        {
            IndividualCalendarDialogForEditting calendarDialog = new IndividualCalendarDialogForEditting();
            return calendarDialog;
        }
        public IndividualCalendarDialogForAdding ShowCalendarDialogToAdd()
        {
            IndividualCalendarDialogForAdding calendarDialog = new IndividualCalendarDialogForAdding();
            return calendarDialog;
        }

        public void ShowCalendarList(IEnumerable<CalendarModel> CalendarList)
        {
            dgvCalendarTable.Rows.Clear();
            if (CalendarList != null)
            {
                foreach (var calendarModel in CalendarList)
                {
                    int rowIndex = dgvCalendarTable.Rows.Add();
                    dgvCalendarTable.Rows[rowIndex].Cells[0].Value = calendarModel.Date.ToShortDateString();
                    dgvCalendarTable.Rows[rowIndex].Cells[1].Value = calendarModel.CheckIn.ToString();
                    dgvCalendarTable.Rows[rowIndex].Cells[2].Value = calendarModel.CheckOut.ToString();
                    dgvCalendarTable.Rows[rowIndex].Cells[3].Value = calendarModel.RealCheckIn.HasValue ? calendarModel.RealCheckIn.Value.ToString("HH:mm:ss") : "N/A";
                    dgvCalendarTable.Rows[rowIndex].Cells[4].Value = calendarModel.RealCheckOut.HasValue ? calendarModel.RealCheckOut.Value.ToString("HH: mm:ss") : "N /A";
                    dgvCalendarTable.Rows[rowIndex].Cells[5].Value = calendarModel.Status;

                }
            }
        }

        private static IndividualCalendarView instance;
        public static IndividualCalendarView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new IndividualCalendarView();
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
