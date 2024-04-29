namespace HRMngt.Views.Dialogs
{
    partial class IndividualCalendarDialogForAdding
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.dtpChooseWeek = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.clbChooseDate = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(206, 526);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(98, 45);
            this.btnCreate.TabIndex = 72;
            this.btnCreate.Text = "Submit";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // dtpChooseWeek
            // 
            this.dtpChooseWeek.CustomFormat = "dd/MM/yyyy";
            this.dtpChooseWeek.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpChooseWeek.Location = new System.Drawing.Point(206, 114);
            this.dtpChooseWeek.Name = "dtpChooseWeek";
            this.dtpChooseWeek.Size = new System.Drawing.Size(219, 31);
            this.dtpChooseWeek.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(98, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 68;
            this.label1.Text = "Date";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(142, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(266, 37);
            this.lblTitle.TabIndex = 67;
            this.lblTitle.Text = "Create Calendar";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clbChooseDate
            // 
            this.clbChooseDate.FormattingEnabled = true;
            this.clbChooseDate.Location = new System.Drawing.Point(30, 175);
            this.clbChooseDate.Name = "clbChooseDate";
            this.clbChooseDate.Size = new System.Drawing.Size(517, 312);
            this.clbChooseDate.TabIndex = 73;
            // 
            // IndividualCalendarDialogForAdding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(616, 634);
            this.Controls.Add(this.clbChooseDate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dtpChooseWeek);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "IndividualCalendarDialogForAdding";
            this.Text = "IndividualCalendarDialogForAdding";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DateTimePicker dtpChooseWeek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.CheckedListBox clbChooseDate;
    }
}