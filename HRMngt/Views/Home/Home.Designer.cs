namespace HRMngt.Views
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lbClick = new System.Windows.Forms.Label();
            this.btnCheckin = new System.Windows.Forms.PictureBox();
            this.btnCheckout = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnCheckin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCheckout)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblWelcome.Location = new System.Drawing.Point(662, 28);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(248, 61);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbClick
            // 
            this.lbClick.AutoSize = true;
            this.lbClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClick.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbClick.Location = new System.Drawing.Point(479, 264);
            this.lbClick.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbClick.Name = "lbClick";
            this.lbClick.Size = new System.Drawing.Size(630, 61);
            this.lbClick.TabIndex = 4;
            this.lbClick.Text = "Click to check attandance";
            // 
            // btnCheckin
            // 
            this.btnCheckin.Image = global::HRMngt.Properties.Resources.check_in;
            this.btnCheckin.Location = new System.Drawing.Point(536, 359);
            this.btnCheckin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCheckin.Name = "btnCheckin";
            this.btnCheckin.Size = new System.Drawing.Size(495, 413);
            this.btnCheckin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCheckin.TabIndex = 5;
            this.btnCheckin.TabStop = false;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Image = global::HRMngt.Properties.Resources.check_out;
            this.btnCheckout.Location = new System.Drawing.Point(536, 359);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(495, 413);
            this.btnCheckout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCheckout.TabIndex = 3;
            this.btnCheckout.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Location = new System.Drawing.Point(384, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(848, 42);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rất vui được gặp bạn! Chúc bạn một ngày tốt lành";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1545, 942);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCheckin);
            this.Controls.Add(this.lbClick);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.lblWelcome);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Home";
            this.Text = "Trang chủ";
            ((System.ComponentModel.ISupportInitialize)(this.btnCheckin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCheckout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox btnCheckout;
        private System.Windows.Forms.Label lbClick;
        private System.Windows.Forms.PictureBox btnCheckin;
        private System.Windows.Forms.Label label4;
    }
}