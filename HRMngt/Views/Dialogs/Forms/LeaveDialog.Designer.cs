namespace HRMngt.Views.Dialogs.Forms
{
    partial class LeaveDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeaveDialog));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbLeaveType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.btnSubmit = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.rtbLeaveDescription = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(102, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Description";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(258, 54);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(771, 31);
            this.txtDescription.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(97, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Leave Type";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbLeaveType
            // 
            this.cmbLeaveType.FormattingEnabled = true;
            this.cmbLeaveType.Items.AddRange(new object[] {
            "Nghỉ phép nguyên lương",
            "Nghỉ việc riêng",
            "Nghỉ lễ/tết",
            "Nghỉ không lương"});
            this.cmbLeaveType.Location = new System.Drawing.Point(258, 137);
            this.cmbLeaveType.Name = "cmbLeaveType";
            this.cmbLeaveType.Size = new System.Drawing.Size(771, 33);
            this.cmbLeaveType.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(37, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Leave Description";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(129, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Duration";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "yyyy-MM-dd";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(258, 377);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(366, 31);
            this.dtpStart.TabIndex = 7;
            this.dtpStart.ValueChanged += new System.EventHandler(this.CalculateDays);
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "yyyy-MM-dd";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(663, 377);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(366, 31);
            this.dtpEnd.TabIndex = 8;
            this.dtpEnd.ValueChanged += new System.EventHandler(this.CalculateDays);
            // 
            // btnSubmit
            // 
            this.btnSubmit.AllowAnimations = true;
            this.btnSubmit.AllowMouseEffects = true;
            this.btnSubmit.AllowToggling = false;
            this.btnSubmit.AnimationSpeed = 200;
            this.btnSubmit.AutoGenerateColors = false;
            this.btnSubmit.AutoRoundBorders = false;
            this.btnSubmit.AutoSizeLeftIcon = true;
            this.btnSubmit.AutoSizeRightIcon = true;
            this.btnSubmit.BackColor = System.Drawing.Color.Transparent;
            this.btnSubmit.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnSubmit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSubmit.BackgroundImage")));
            this.btnSubmit.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSubmit.ButtonText = "Submit";
            this.btnSubmit.ButtonTextMarginLeft = 0;
            this.btnSubmit.ColorContrastOnClick = 45;
            this.btnSubmit.ColorContrastOnHover = 45;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnSubmit.CustomizableEdges = borderEdges1;
            this.btnSubmit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSubmit.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSubmit.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnSubmit.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnSubmit.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.IconLeft = null;
            this.btnSubmit.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubmit.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSubmit.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSubmit.IconMarginLeft = 11;
            this.btnSubmit.IconPadding = 10;
            this.btnSubmit.IconRight = null;
            this.btnSubmit.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSubmit.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSubmit.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSubmit.IconSize = 25;
            this.btnSubmit.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnSubmit.IdleBorderRadius = 0;
            this.btnSubmit.IdleBorderThickness = 0;
            this.btnSubmit.IdleFillColor = System.Drawing.Color.Empty;
            this.btnSubmit.IdleIconLeftImage = null;
            this.btnSubmit.IdleIconRightImage = null;
            this.btnSubmit.IndicateFocus = false;
            this.btnSubmit.Location = new System.Drawing.Point(489, 507);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSubmit.OnDisabledState.BorderRadius = 1;
            this.btnSubmit.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSubmit.OnDisabledState.BorderThickness = 1;
            this.btnSubmit.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSubmit.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSubmit.OnDisabledState.IconLeftImage = null;
            this.btnSubmit.OnDisabledState.IconRightImage = null;
            this.btnSubmit.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnSubmit.onHoverState.BorderRadius = 1;
            this.btnSubmit.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSubmit.onHoverState.BorderThickness = 1;
            this.btnSubmit.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnSubmit.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.onHoverState.IconLeftImage = null;
            this.btnSubmit.onHoverState.IconRightImage = null;
            this.btnSubmit.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSubmit.OnIdleState.BorderRadius = 1;
            this.btnSubmit.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSubmit.OnIdleState.BorderThickness = 1;
            this.btnSubmit.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnSubmit.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.OnIdleState.IconLeftImage = null;
            this.btnSubmit.OnIdleState.IconRightImage = null;
            this.btnSubmit.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSubmit.OnPressedState.BorderRadius = 1;
            this.btnSubmit.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSubmit.OnPressedState.BorderThickness = 1;
            this.btnSubmit.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSubmit.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.OnPressedState.IconLeftImage = null;
            this.btnSubmit.OnPressedState.IconRightImage = null;
            this.btnSubmit.Size = new System.Drawing.Size(126, 54);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSubmit.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSubmit.TextMarginLeft = 0;
            this.btnSubmit.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSubmit.UseDefaultRadiusAndThickness = true;
            // 
            // rtbLeaveDescription
            // 
            this.rtbLeaveDescription.BackColor = System.Drawing.Color.White;
            this.rtbLeaveDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbLeaveDescription.Location = new System.Drawing.Point(258, 221);
            this.rtbLeaveDescription.Name = "rtbLeaveDescription";
            this.rtbLeaveDescription.ReadOnly = true;
            this.rtbLeaveDescription.Size = new System.Drawing.Size(771, 135);
            this.rtbLeaveDescription.TabIndex = 10;
            this.rtbLeaveDescription.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(161, 456);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Days";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(258, 456);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(70, 25);
            this.lblDays.TabIndex = 12;
            this.lblDays.Text = "label6";
            // 
            // LeaveDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1110, 586);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtbLeaveDescription);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbLeaveType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label1);
            this.Name = "LeaveDialog";
            this.Text = "LeaveDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbLeaveType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSubmit;
        private System.Windows.Forms.RichTextBox rtbLeaveDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDays;
    }
}