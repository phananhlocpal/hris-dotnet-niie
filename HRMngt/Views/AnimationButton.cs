using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace HRMngt.Views
{
    public class AnimationButton : Button
    {
        Stopwatch sw = new Stopwatch();
        System.Windows.Forms.Timer Animation { get; set; } = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer AnimationBack { get; set; } = new System.Windows.Forms.Timer();

        public int AniamtionInvertal { get; set; } = 1;
        public string CustomButtonText { get; set; } = "Hover Here";
        public Color backHoverColor { get; set; } = Color.PaleGreen;
        public int backgroundSpeed { get; set; } = 40;
        public double smoothCorrectFactor { get; set; } = 1.5F;
        public bool useSmoothSpeedIncrement { get; set; } = true;
        public int incremental_x = 1;
        private bool drawString = false;
        public AnimationButton()
        {
            this.SetStyle(System.Windows.Forms.ControlStyles.UserPaint | System.Windows.Forms.ControlStyles.AllPaintingInWmPaint | System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer, true);
            Animation.Interval = AniamtionInvertal;
            Animation.Tick += ButtonAnimation;
            AnimationBack.Tick += ButtonAnimationBack;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.BackColor = Color.FromArgb(240, 240, 240);
            this.ForeColor = Color.FromArgb(100, 100, 100);
            this.Text = ""; // có thể override

        }

        private void ButtonAnimationBack(object sender, EventArgs e)
        {
            if (useSmoothSpeedIncrement)
            {
                incremental_x -= Convert.ToInt32(backgroundSpeed * sw.Elapsed.TotalSeconds * smoothCorrectFactor);
            }
            else
            {
                incremental_x -= backgroundSpeed;

            }
            if(incremental_x <= 0)
            {
                AnimationBack.Stop();
                incremental_x = 1;
                drawString = true;
            }
            this.Invalidate();
        }

        private void ButtonAnimation(object sender, EventArgs e)
        {
            if (useSmoothSpeedIncrement)
            {
                incremental_x += Convert.ToInt32(backgroundSpeed * sw.Elapsed.TotalSeconds * smoothCorrectFactor);
            }
            else
            {
                incremental_x += backgroundSpeed;

            }
            if (incremental_x > this.Width * 3)
            {
                Animation.Stop();
            }
            this.Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            this.Text = "";
            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            if(incremental_x  != 1)
            {
                Rectangle r = new Rectangle(new Point(0 - incremental_x / 2, 0 - incremental_x / 2), new Size(incremental_x, this.Height + incremental_x));
                g.FillPie(new SolidBrush(backHoverColor), r, 0, 360);
            }
            StringFormat sf = new StringFormat(); 
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            SolidBrush textColor;
            if (drawString)
            {
                textColor = new SolidBrush(Color.White);
            }
            else
            {
                textColor = new SolidBrush(this.ForeColor);
            }
            g.DrawString(CustomButtonText, this.Font, textColor, new Rectangle(new Point(0, 0), new Size(this.Width, this.Height)), sf);
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            drawString = true;
            Animation.Start();
            sw.Reset();
            sw.Stop();
            sw.Start();
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            Animation.Stop();
            AnimationBack.Start();
            sw.Reset();
            sw.Stop();
            sw.Start();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }
    }
}
