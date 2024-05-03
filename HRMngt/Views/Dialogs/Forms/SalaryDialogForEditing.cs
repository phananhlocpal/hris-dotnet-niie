using HRMngt.Models;
using HRMngt.Views.Dialogs.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMngt.Views.Dialogs.Forms
{
    public partial class SalaryDialogForEditing : Form, ISalaryDialogForEditing
    {
        public SalaryDialogForEditing()
        {
            InitializeComponent();
            RunEvent();
        }

        private void RunEvent()
        {
            btnUpdate.Click += delegate { updateEvent?.Invoke(this, EventArgs.Empty); };
            btnApprove.Click += delegate { approveEvent?.Invoke(this, EventArgs.Empty); };
        }

        public event EventHandler updateEvent;
        public event EventHandler approveEvent;

        public void ShowSalaryInfo(SalaryModel salaryModel)
        {
            lblUserId.Text = salaryModel.UserId;
            lblUserName.Text = salaryModel.UserName;
            lblWorkday.Text = salaryModel.Workday.ToString();
            lblRealWorkday.Text = salaryModel.RealWorkday.ToString();
            lblMonth.Text = $"Tháng {salaryModel.Month} - {salaryModel.Year}";
            lblThumbUp.Text = salaryModel.ThumbTotal.ToString();
            lblTicket.Text = salaryModel.TicketTotal.ToString();
            lblTax.Text = salaryModel.Tax.ToString();
            txtWelfare.Text = salaryModel.Welfare.ToString();
            lblStatus.Text = salaryModel.Status.ToString();
            if (salaryModel.Complain != null)
                rtbComplain.Text = salaryModel.Complain;
            if (salaryModel.Res != null)
                rtbResponse.Text = salaryModel.Res;

        }

        void ISalaryDialogForEditing.ShowDialog()
        {
            this.ShowDialog();
        }

        public SalaryModel GetChangedInfo()
        {
            SalaryModel salaryModel = new SalaryModel();
            salaryModel.Welfare = int.Parse(txtWelfare.Text.ToString());
            if (rtbComplain.ToString() != "")
                salaryModel.Complain = rtbComplain.ToString();
            if (rtbResponse.ToString() != "")
                salaryModel.Res = rtbResponse.ToString();
            return salaryModel;
        }
    }
}
