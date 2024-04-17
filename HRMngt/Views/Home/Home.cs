using HRMngt.Views.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMngt.Views
{
    public partial class Home : Form, IHomeView

    {
        public Home()
        {
            InitializeComponent();
        }
        private static Home instance;

        System.Web.UI.WebControls.Button IHomeView.btnCheckin => throw new NotImplementedException();

        System.Web.UI.WebControls.Button IHomeView.btnCheckout => throw new NotImplementedException();

        public static Home GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new Home();
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

        private void btnCheckin_Click(object sender, EventArgs e)
        {

        }
    }
}
