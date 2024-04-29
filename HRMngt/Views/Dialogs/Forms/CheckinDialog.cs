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
    public partial class CheckinDialog : Form
    {
        public CheckinDialog()
        {
            InitializeComponent();
            lbDate.Text = DateTime.Now.Day.ToString();
            lbMonth.Text = DateTime.Now.Month.ToString();
            lbYear.Text = DateTime.Now.Year.ToString();
            lbTime.Text = $"{DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}";
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
