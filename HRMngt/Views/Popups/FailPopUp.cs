using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMngt.popup
{
    public partial class FailPopUp : Form
    {
        int popupX, popupY;
        public FailPopUp()
        {
            InitializeComponent();
        }

        public static void ShowPopUp()
        {
            SucessPopUp popup = new SucessPopUp();
            popup.Show();

        }

        
        private void FailPopUp_Load(object sender, EventArgs e)
        {
            Position();
            fadeTimer.Start();
        }

        int time = 2000;
        private void fadeTimer_Tick(object sender, EventArgs e)
        {
            time -= 1000;
            if (time == 0)
            {
                this.Close();
            }
        }

        private void Position()
        {
            int ScreenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int ScreenHeight = Screen.PrimaryScreen.WorkingArea.Height;

            popupX = ScreenWidth - this.Width - 10;
            popupY = ScreenHeight - this.Height - 20;

            this.Location = new Point(popupX, popupY);

        }
    }


}
