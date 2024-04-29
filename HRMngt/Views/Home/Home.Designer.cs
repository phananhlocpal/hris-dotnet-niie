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
            this.label1 = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbClick = new System.Windows.Forms.Label();
            this.btnCheckin = new System.Windows.Forms.PictureBox();
            this.btnCheckout = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnCheckin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCheckout)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(373, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbName.Location = new System.Drawing.Point(520, 19);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(144, 38);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Xin chào";
            // 
            // lbClick
            // 
            this.lbClick.AutoSize = true;
            this.lbClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClick.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbClick.Location = new System.Drawing.Point(365, 146);
            this.lbClick.Name = "lbClick";
            this.lbClick.Size = new System.Drawing.Size(299, 38);
            this.lbClick.TabIndex = 4;
            this.lbClick.Text = "Click to Attandance";
            // 
            // btnCheckin
            // 
            this.btnCheckin.Image = global::HRMngt.Properties.Resources.check_in;
            this.btnCheckin.Location = new System.Drawing.Point(292, 201);
            this.btnCheckin.Name = "btnCheckin";
            this.btnCheckin.Size = new System.Drawing.Size(411, 316);
            this.btnCheckin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCheckin.TabIndex = 5;
            this.btnCheckin.TabStop = false;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Image = global::HRMngt.Properties.Resources.check_out;
            this.btnCheckout.Location = new System.Drawing.Point(292, 201);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(411, 316);
            this.btnCheckout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCheckout.TabIndex = 3;
            this.btnCheckout.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Location = new System.Drawing.Point(256, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(536, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rất vui được gặp bạn! Chúc bạn một ngày tốt lành";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1030, 603);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCheckin);
            this.Controls.Add(this.lbClick);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.label1);
            this.Name = "Home";
            this.Text = "Trang chủ";
            ((System.ComponentModel.ISupportInitialize)(this.btnCheckin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCheckout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.PictureBox btnCheckout;
        private System.Windows.Forms.Label lbClick;
        private System.Windows.Forms.PictureBox btnCheckin;
        private System.Windows.Forms.Label label4;
    }
}