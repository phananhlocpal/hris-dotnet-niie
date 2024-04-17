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
    public partial class ClockCountdown : Form
    {
        private Timer timer;
        private int totalTime = 5; // 2 phút

        public ClockCountdown()
        {
            InitializeComponent();
            StartCountdown();
        }

        private void StartCountdown()
        {
            timer = new Timer();
            timer.Tick += new EventHandler(time_tick);
            timer.Interval = 1000; // 1 giây
            timer.Start();
        }

        private void time_tick(object sender, EventArgs e)
        {
            totalTime--;

            if (totalTime <= 0)
            {
                timer.Stop();
                MessageBox.Show("Kết thúc hàng chờ, vui lòng nhập lại tài khoản và mật khẩu đúng", "Kết thúc", MessageBoxButtons.OK);
                this.Close();
            }

            // Hiển thị đồng hồ đếm ngược trong format "mm:ss"
            label1.Text = string.Format("{0}:{01:00}", totalTime / 60, totalTime % 60);
        }
    }
}
