using Bunifu.UI.WinForms.BunifuButton;
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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
        private void moveImageBox(object sender)
        {
            BunifuButton2 b = (BunifuButton2)sender;
            imgSlide.Location = new Point(b.Location.X + 121, b.Location.Y - 30);
            imgSlide.SendToBack();

        }
        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            moveImageBox(sender);
        }
    }
}
