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
    public partial class IndividualSalaryView : Form, IIndividualSalaryView
    {
        public IndividualSalaryView()
        {
            InitializeComponent();
            dtpChooseMonth.Format = DateTimePickerFormat.Custom;
            dtpChooseMonth.CustomFormat = "MM - yyyy";
            dtpChooseMonth.ShowUpDown = true;
            RunEvent();
        }
        private void RunEvent()
        {
            btnExportExcel.Click += delegate { ExportExcelEvent?.Invoke(this, EventArgs.Empty); };
            btnView.Click += delegate { SearchByMonthEvent?.Invoke(this, EventArgs.Empty); };
            //btnReadSalaryTable.Click += delegate { LoadSalaryDialogToViewEvent?.Invoke(this, EventArgs.Empty); };
            btnReadSalaryTable.Click += delegate { ViewResumeEvent?.Invoke(this, EventArgs.Empty); };
        }

        KryptonDataGridView IIndividualSalaryView.dgvSalaryTable => dgvSalaryTable;
        DateTimePicker IIndividualSalaryView.dtpChooseMonth => dtpChooseMonth;


        public event EventHandler SearchByMonthEvent;
        public event EventHandler LoadSalaryDialogToViewEvent;
        public event EventHandler ExportExcelEvent;
        public event EventHandler ViewResumeEvent;

        public IndividualSalaryDialog ShowSalaryDialogToView()
        {
            IndividualSalaryDialog individualSalaryDialog = new IndividualSalaryDialog();
            return individualSalaryDialog;

        }

        public void ShowSalaryList(IEnumerable<CalendarModel> SalaryList)
        {
            if (SalaryList != null)
            {
                dgvSalaryTable.Rows.Clear();

                foreach (var calendarModel in SalaryList)
                {
                    int rowIndex = dgvSalaryTable.Rows.Add();
                    dgvSalaryTable.Rows[rowIndex].Cells[0].Value = calendarModel.Date.Date.ToString("dd/MM/yyyy");
                    TimeSpan DTTimeIn = calendarModel.CheckIn;
                    string StrTimeIn = DTTimeIn.ToString();
                    TimeSpan DTTimeOut = calendarModel.CheckOut;
                    string StrTimeOut = DTTimeOut.ToString();
                    string time = $"{StrTimeIn} - {StrTimeOut}";
                    dgvSalaryTable.Rows[rowIndex].Cells[1].Value = time;
                    if (calendarModel.RealCheckIn != null)
                        dgvSalaryTable.Rows[rowIndex].Cells[2].Value = calendarModel.RealCheckIn.Value.ToString();
                    if (calendarModel.RealCheckOut != null)
                        dgvSalaryTable.Rows[rowIndex].Cells[3].Value = calendarModel.RealCheckOut.Value.ToString();
                    dgvSalaryTable.Rows[rowIndex].Cells[4].Value = calendarModel.Status;
                }
            }
            else
            {
                dgvSalaryTable.Rows.Clear();
            }
        }

        private static IndividualSalaryView instance;
        public static IndividualSalaryView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new IndividualSalaryView();
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
