using HRMngt.Model;
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
    public partial class IndividualSalaryDialog : Form, IIndividualSalaryDialog
    {
        public IndividualSalaryDialog()
        {
            InitializeComponent();
            RunEvent();
        }
        private void RunEvent()
        {
            btnConfirm.Click += delegate { ConfirmEvent?.Invoke(this, EventArgs.Empty); };
            btnComplain.Click += delegate { ResponseEvent?.Invoke(this, EventArgs.Empty); };
        }

        public event EventHandler ConfirmEvent;
        public event EventHandler ResponseEvent;

        public void ShowSalaryInfo(SalaryModel salaryModel, UserModel userModel)
        {
            lblMonth.Text = salaryModel.Month.ToString();
            lblStatus.Text = "• " + salaryModel.Status.ToString();
            lblUserId.Text = salaryModel.UserId.ToString();
            lblUserName.Text = userModel.Name;

            dgvDetailSalaryTable.Rows.Clear();
            // Row 1
            dgvDetailSalaryTable.Rows[0].Cells[0].Value = "1";
            dgvDetailSalaryTable.Rows[0].Cells[1].Value = "Tổng ngày công của tháng";
            dgvDetailSalaryTable.Rows[0].Cells[2].Value = salaryModel.Workday.ToString();
            // Row 2
            dgvDetailSalaryTable.Rows[1].Cells[0].Value = "2";
            dgvDetailSalaryTable.Rows[1].Cells[1].Value = "Tổng số ngày làm thực tế";
            dgvDetailSalaryTable.Rows[1].Cells[2].Value = salaryModel.RealWorkday.ToString();
            // Row 3          
            int gross = (salaryModel.RealWorkday / salaryModel.Workday) * 100 * int.Parse(userModel.Salary);
            dgvDetailSalaryTable.Rows[2].Cells[0].Value = "3";
            dgvDetailSalaryTable.Rows[2].Cells[1].Value = "Tổng lương gross";
            dgvDetailSalaryTable.Rows[2].Cells[2].Value = gross.ToString();
            // Row 4
            dgvDetailSalaryTable.Rows[3].Cells[0].Value = "4";
            dgvDetailSalaryTable.Rows[3].Cells[1].Value = "Phụ cấp";
            dgvDetailSalaryTable.Rows[3].Cells[2].Value = salaryModel.Welfare.ToString();
            // Row 5
            dgvDetailSalaryTable.Rows[4].Cells[0].Value = "5";
            dgvDetailSalaryTable.Rows[4].Cells[1].Value = "Thưởng";
            dgvDetailSalaryTable.Rows[4].Cells[2].Value = salaryModel.ThumbTotal.ToString();
            // Row 6
            dgvDetailSalaryTable.Rows[5].Cells[0].Value = "6";
            dgvDetailSalaryTable.Rows[5].Cells[1].Value = "Phạt";
            dgvDetailSalaryTable.Rows[5].Cells[2].Value = salaryModel.TicketTotal.ToString();
            // Row 7
            double total = (gross + salaryModel.Welfare + salaryModel.ThumbTotal - salaryModel.TicketTotal);
            dgvDetailSalaryTable.Rows[6].Cells[0].Value = "7";
            dgvDetailSalaryTable.Rows[6].Cells[1].Value = "Tổng thu nhập";
            dgvDetailSalaryTable.Rows[6].Cells[2].Value = total.ToString();
            // Row 8
            dgvDetailSalaryTable.Rows[7].Cells[0].Value = "8";
            dgvDetailSalaryTable.Rows[7].Cells[1].Value = "Thuế TNCN";
            dgvDetailSalaryTable.Rows[7].Cells[2].Value = salaryModel.Tax.ToString();
            // Row 9
            dgvDetailSalaryTable.Rows[8].Cells[0].Value = "9";
            dgvDetailSalaryTable.Rows[8].Cells[1].Value = "Lương thực lĩnh";
            dgvDetailSalaryTable.Rows[8].Cells[2].Value = salaryModel.TotalSalary.ToString();
        }
    }
}
