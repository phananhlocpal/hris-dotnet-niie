using ComponentFactory.Krypton.Toolkit;
using HRMngt._Repository;
using HRMngt._Repository.Calendar;
using HRMngt.Model;
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
            dtpStart.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime nextMonth = dtpStart.Value.AddMonths(1);
            DateTime lastDayOfMonth = nextMonth.AddDays(-nextMonth.Day);// Trừ đi số ngày hiện tại để lấy ngày cuối của tháng
            dtpEnd.Value = lastDayOfMonth;
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
                    LoadTCalendarDialogToEditEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            // Delete Event
            dgvTimeKeepingTable.CellContentClick += (sender, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == dgvTimeKeepingTable.Columns[10].Index)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            // Approve Event
            dgvTimeKeepingTable.CellContentClick += (sender, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == dgvTimeKeepingTable.Columns[11].Index)
                {
                    ApproveEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            // Not Approve Event
            dgvTimeKeepingTable.CellContentClick += (sender, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == dgvTimeKeepingTable.Columns[12].Index)
                {
                    NotApproveEvent?.Invoke(this, EventArgs.Empty);
                }
            };
        }

        public event EventHandler FilterEvent;
        public event EventHandler LoadTCalendarDialogToEditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler ApproveEvent;
        public event EventHandler NotApproveEvent;

        public IndividualCalendarDialogForEditting ShowCalendarDialogToEdit()
        {
            IndividualCalendarDialogForEditting calendarDialog = new IndividualCalendarDialogForEditting();
            return calendarDialog;
        }

        public void ShowCalendarList(IEnumerable<CalendarModel> calendarList)
        {
            if (calendarList != null)
            {
                dgvTimeKeepingTable.Rows.Clear();

                foreach (var calendarModel in calendarList)
                {
                    int rowIndex = dgvTimeKeepingTable.Rows.Add();
                    dgvTimeKeepingTable.Rows[rowIndex].Cells[0].Value = calendarModel.UserId;
                    dgvTimeKeepingTable.Rows[rowIndex].Cells[1].Value = calendarModel.UserName;
                    dgvTimeKeepingTable.Rows[rowIndex].Cells[2].Value = calendarModel.UserDepartment;
                    dgvTimeKeepingTable.Rows[rowIndex].Cells[3].Value = calendarModel.Date.ToShortDateString();
                    dgvTimeKeepingTable.Rows[rowIndex].Cells[4].Value = calendarModel.CheckIn;
                    dgvTimeKeepingTable.Rows[rowIndex].Cells[5].Value = calendarModel.CheckOut;
                    dgvTimeKeepingTable.Rows[rowIndex].Cells[6].Value = calendarModel.RealCheckIn;
                    dgvTimeKeepingTable.Rows[rowIndex].Cells[7].Value = calendarModel.RealCheckOut;
                    dgvTimeKeepingTable.Rows[rowIndex].Cells[8].Value = calendarModel.Status;
                }
            }
            else dgvTimeKeepingTable.Rows.Clear();
        }

        public void ShowDepartmentList(IEnumerable<DepartmentModel> departmentList)
        {
            cmbDepartment.Items.Clear();
            cmbDepartment.Items.Add("All");
            if (departmentList != null)
            {
                foreach (var departmentModel in  departmentList)
                {
                    cmbDepartment.Items.Add($"{departmentModel.Id} - {departmentModel.Name}");
                }
            }
            cmbDepartment.SelectedIndex = 0;
            cmbStatus.SelectedIndex = 0;
        }

        private static TimeKeepingView instance;

        DateTimePicker ITimeKeepingView.dtpStart 
        {
            get => dtpStart;
            set => throw new NotImplementedException(); 
        }
        DateTimePicker ITimeKeepingView.dtpEnd
        {
            get => dtpEnd; 
            set => throw new NotImplementedException(); 
        }
        ComboBox ITimeKeepingView.cmbStatus 
        {
            get => cmbStatus; 
            set => throw new NotImplementedException(); 
        }
        ComboBox ITimeKeepingView.cmbDepartment 
        {
            get => cmbDepartment;
            set => throw new NotImplementedException(); 
        }
        TextBox ITimeKeepingView.txtUserId
        {
            get
            {
                if (txtUserId.Text == "")
                    return null;    
                else return txtUserId;
            }
            set => throw new NotImplementedException(); 
        }
        DataGridView ITimeKeepingView.dgvTimeKeepingTable 
        {
            get => dgvTimeKeepingTable;
            set => throw new NotImplementedException(); 
        }

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
