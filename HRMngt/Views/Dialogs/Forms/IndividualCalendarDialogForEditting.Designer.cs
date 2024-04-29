namespace HRMngt.Views.Dialogs
{
    partial class IndividualCalendarDialogForEditting
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
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.btnCreateUpdate = new System.Windows.Forms.Button();
            this.lblStatusDetail = new System.Windows.Forms.Label();
            this.lblDateDetail = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.CustomFormat = "HH:mm:ss";
            this.dtpCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCheckOut.Location = new System.Drawing.Point(227, 418);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.ShowUpDown = true;
            this.dtpCheckOut.Size = new System.Drawing.Size(522, 31);
            this.dtpCheckOut.TabIndex = 72;
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.CustomFormat = "HH:mm:ss";
            this.dtpCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCheckIn.Location = new System.Drawing.Point(227, 360);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.ShowUpDown = true;
            this.dtpCheckIn.Size = new System.Drawing.Size(522, 31);
            this.dtpCheckIn.TabIndex = 71;
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "HH:mm:ss";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(227, 235);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.ShowUpDown = true;
            this.dtpStart.Size = new System.Drawing.Size(522, 31);
            this.dtpStart.TabIndex = 70;
            // 
            // btnCreateUpdate
            // 
            this.btnCreateUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateUpdate.Location = new System.Drawing.Point(329, 531);
            this.btnCreateUpdate.Name = "btnCreateUpdate";
            this.btnCreateUpdate.Size = new System.Drawing.Size(142, 50);
            this.btnCreateUpdate.TabIndex = 69;
            this.btnCreateUpdate.Text = "Update";
            this.btnCreateUpdate.UseVisualStyleBackColor = true;
            // 
            // lblStatusDetail
            // 
            this.lblStatusDetail.AutoSize = true;
            this.lblStatusDetail.Location = new System.Drawing.Point(222, 480);
            this.lblStatusDetail.Name = "lblStatusDetail";
            this.lblStatusDetail.Size = new System.Drawing.Size(87, 25);
            this.lblStatusDetail.TabIndex = 68;
            this.lblStatusDetail.Text = "Content";
            // 
            // lblDateDetail
            // 
            this.lblDateDetail.AutoSize = true;
            this.lblDateDetail.Location = new System.Drawing.Point(227, 177);
            this.lblDateDetail.Name = "lblDateDetail";
            this.lblDateDetail.Size = new System.Drawing.Size(87, 25);
            this.lblDateDetail.TabIndex = 67;
            this.lblDateDetail.Text = "Content";
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "HH:mm:ss";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(227, 296);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.ShowUpDown = true;
            this.dtpEnd.Size = new System.Drawing.Size(522, 31);
            this.dtpEnd.TabIndex = 66;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(128, 480);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 25);
            this.label6.TabIndex = 65;
            this.label6.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(84, 418);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 64;
            this.label5.Text = "Check out";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(98, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 63;
            this.label4.Text = "Check in";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(143, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 25);
            this.label3.TabIndex = 62;
            this.label3.Text = "End";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(137, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 61;
            this.label2.Text = "Start";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(137, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 60;
            this.label1.Text = "Date";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(261, 47);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(274, 37);
            this.lblTitle.TabIndex = 59;
            this.lblTitle.Text = "Update Calendar";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(226, 124);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(87, 25);
            this.lblUserId.TabIndex = 74;
            this.lblUserId.Text = "Content";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(117, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 25);
            this.label8.TabIndex = 73;
            this.label8.Text = "Mã NV";
            // 
            // IndividualCalendarDialogForEditting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 611);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpCheckOut);
            this.Controls.Add(this.dtpCheckIn);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.btnCreateUpdate);
            this.Controls.Add(this.lblStatusDetail);
            this.Controls.Add(this.lblDateDetail);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "IndividualCalendarDialogForEditting";
            this.Text = "IndividualCalendarDialogForEditting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Button btnCreateUpdate;
        private System.Windows.Forms.Label lblStatusDetail;
        private System.Windows.Forms.Label lblDateDetail;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Label label8;
    }
}