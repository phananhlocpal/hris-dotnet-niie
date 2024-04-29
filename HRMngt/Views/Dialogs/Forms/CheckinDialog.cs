using HRMngt.Views.Dialogs.Interface;
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
    public partial class CheckinDialog : Form, ICheckinDialog
    {
        public string label1 { get => lb1.Text; set => lb1.Text = value; }
        public string label2 { get => lb2.Text; set => lb2.Text = value; }
        public string label3 { get => lb3.Text; set => lb3.Text = value; }

        public CheckinDialog()
        {
            InitializeComponent();
            RunEvent();
           
        }
        private void RunEvent()
        {
            btnAccept.Click += delegate { AddToCalculator?.Invoke(this, EventArgs.Empty); };
        }
        public event EventHandler AddToCalculator;

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
