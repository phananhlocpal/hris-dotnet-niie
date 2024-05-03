namespace HRMngt.Views.Dialogs
{
    partial class IndividualSalaryView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IndividualSalaryView));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.dtpChooseMonth = new System.Windows.Forms.DateTimePicker();
            this.dgvSalaryTable = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registerCheckInCheckOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.realCheckIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RealCheckOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReadSalaryTable = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaryTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(450, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Chọn tháng:";
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportExcel.Location = new System.Drawing.Point(963, 16);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(128, 50);
            this.btnExportExcel.TabIndex = 18;
            this.btnExportExcel.Text = "Xuất Excel";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            // 
            // btnView
            // 
            this.btnView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnView.Location = new System.Drawing.Point(837, 17);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(98, 50);
            this.btnView.TabIndex = 17;
            this.btnView.Text = "Xem";
            this.btnView.UseVisualStyleBackColor = true;
            // 
            // dtpChooseMonth
            // 
            this.dtpChooseMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpChooseMonth.CustomFormat = "";
            this.dtpChooseMonth.Location = new System.Drawing.Point(596, 17);
            this.dtpChooseMonth.MinimumSize = new System.Drawing.Size(4, 50);
            this.dtpChooseMonth.Name = "dtpChooseMonth";
            this.dtpChooseMonth.Size = new System.Drawing.Size(200, 50);
            this.dtpChooseMonth.TabIndex = 16;
            // 
            // dgvSalaryTable
            // 
            this.dgvSalaryTable.AllowUserToAddRows = false;
            this.dgvSalaryTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSalaryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalaryTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.registerCheckInCheckOut,
            this.realCheckIn,
            this.RealCheckOut,
            this.status});
            this.dgvSalaryTable.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Mixed;
            this.dgvSalaryTable.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ContextMenuSeparator;
            this.dgvSalaryTable.HideOuterBorders = true;
            this.dgvSalaryTable.Location = new System.Drawing.Point(30, 81);
            this.dgvSalaryTable.Name = "dgvSalaryTable";
            this.dgvSalaryTable.ReadOnly = true;
            this.dgvSalaryTable.RowHeadersVisible = false;
            this.dgvSalaryTable.RowHeadersWidth = 90;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvSalaryTable.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSalaryTable.RowTemplate.Height = 50;
            this.dgvSalaryTable.RowTemplate.ReadOnly = true;
            this.dgvSalaryTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvSalaryTable.ShowCellErrors = false;
            this.dgvSalaryTable.ShowCellToolTips = false;
            this.dgvSalaryTable.ShowEditingIcon = false;
            this.dgvSalaryTable.ShowRowErrors = false;
            this.dgvSalaryTable.Size = new System.Drawing.Size(1060, 528);
            this.dgvSalaryTable.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ContextMenuSeparator;
            this.dgvSalaryTable.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.White;
            this.dgvSalaryTable.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgvSalaryTable.StateCommon.DataCell.Content.Padding = new System.Windows.Forms.Padding(1);
            this.dgvSalaryTable.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvSalaryTable.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvSalaryTable.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.White;
            this.dgvSalaryTable.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgvSalaryTable.StateCommon.HeaderColumn.Content.Padding = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.dgvSalaryTable.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.White;
            this.dgvSalaryTable.StateSelected.DataCell.Back.Color2 = System.Drawing.Color.White;
            this.dgvSalaryTable.TabIndex = 15;
            // 
            // date
            // 
            this.date.HeaderText = "Ngày";
            this.date.MinimumWidth = 10;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 300;
            // 
            // registerCheckInCheckOut
            // 
            this.registerCheckInCheckOut.HeaderText = "Thời gian";
            this.registerCheckInCheckOut.MinimumWidth = 10;
            this.registerCheckInCheckOut.Name = "registerCheckInCheckOut";
            this.registerCheckInCheckOut.ReadOnly = true;
            this.registerCheckInCheckOut.Width = 400;
            // 
            // realCheckIn
            // 
            this.realCheckIn.HeaderText = "Checkin thực tế";
            this.realCheckIn.MinimumWidth = 10;
            this.realCheckIn.Name = "realCheckIn";
            this.realCheckIn.ReadOnly = true;
            this.realCheckIn.Width = 200;
            // 
            // RealCheckOut
            // 
            this.RealCheckOut.HeaderText = "Checkout thực tế";
            this.RealCheckOut.MinimumWidth = 10;
            this.RealCheckOut.Name = "RealCheckOut";
            this.RealCheckOut.ReadOnly = true;
            this.RealCheckOut.Width = 200;
            // 
            // status
            // 
            this.status.HeaderText = "Trạng thái";
            this.status.MinimumWidth = 10;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 200;
            // 
            // btnReadSalaryTable
            // 
            this.btnReadSalaryTable.AllowAnimations = true;
            this.btnReadSalaryTable.AllowMouseEffects = true;
            this.btnReadSalaryTable.AllowToggling = false;
            this.btnReadSalaryTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReadSalaryTable.AnimationSpeed = 200;
            this.btnReadSalaryTable.AutoGenerateColors = false;
            this.btnReadSalaryTable.AutoRoundBorders = false;
            this.btnReadSalaryTable.AutoSizeLeftIcon = true;
            this.btnReadSalaryTable.AutoSizeRightIcon = true;
            this.btnReadSalaryTable.BackColor = System.Drawing.Color.Transparent;
            this.btnReadSalaryTable.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnReadSalaryTable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReadSalaryTable.BackgroundImage")));
            this.btnReadSalaryTable.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReadSalaryTable.ButtonText = "Xem";
            this.btnReadSalaryTable.ButtonTextMarginLeft = 0;
            this.btnReadSalaryTable.ColorContrastOnClick = 45;
            this.btnReadSalaryTable.ColorContrastOnHover = 45;
            this.btnReadSalaryTable.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnReadSalaryTable.CustomizableEdges = borderEdges1;
            this.btnReadSalaryTable.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReadSalaryTable.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnReadSalaryTable.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnReadSalaryTable.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnReadSalaryTable.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnReadSalaryTable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReadSalaryTable.ForeColor = System.Drawing.Color.White;
            this.btnReadSalaryTable.IconLeft = null;
            this.btnReadSalaryTable.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReadSalaryTable.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnReadSalaryTable.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnReadSalaryTable.IconMarginLeft = 11;
            this.btnReadSalaryTable.IconPadding = 10;
            this.btnReadSalaryTable.IconRight = null;
            this.btnReadSalaryTable.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReadSalaryTable.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnReadSalaryTable.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnReadSalaryTable.IconSize = 25;
            this.btnReadSalaryTable.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnReadSalaryTable.IdleBorderRadius = 0;
            this.btnReadSalaryTable.IdleBorderThickness = 0;
            this.btnReadSalaryTable.IdleFillColor = System.Drawing.Color.Empty;
            this.btnReadSalaryTable.IdleIconLeftImage = null;
            this.btnReadSalaryTable.IdleIconRightImage = null;
            this.btnReadSalaryTable.IndicateFocus = false;
            this.btnReadSalaryTable.Location = new System.Drawing.Point(925, 627);
            this.btnReadSalaryTable.Name = "btnReadSalaryTable";
            this.btnReadSalaryTable.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnReadSalaryTable.OnDisabledState.BorderRadius = 1;
            this.btnReadSalaryTable.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReadSalaryTable.OnDisabledState.BorderThickness = 1;
            this.btnReadSalaryTable.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnReadSalaryTable.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnReadSalaryTable.OnDisabledState.IconLeftImage = null;
            this.btnReadSalaryTable.OnDisabledState.IconRightImage = null;
            this.btnReadSalaryTable.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnReadSalaryTable.onHoverState.BorderRadius = 1;
            this.btnReadSalaryTable.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReadSalaryTable.onHoverState.BorderThickness = 1;
            this.btnReadSalaryTable.onHoverState.FillColor = System.Drawing.Color.White;
            this.btnReadSalaryTable.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnReadSalaryTable.onHoverState.IconLeftImage = null;
            this.btnReadSalaryTable.onHoverState.IconRightImage = null;
            this.btnReadSalaryTable.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnReadSalaryTable.OnIdleState.BorderRadius = 1;
            this.btnReadSalaryTable.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReadSalaryTable.OnIdleState.BorderThickness = 1;
            this.btnReadSalaryTable.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnReadSalaryTable.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnReadSalaryTable.OnIdleState.IconLeftImage = null;
            this.btnReadSalaryTable.OnIdleState.IconRightImage = null;
            this.btnReadSalaryTable.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnReadSalaryTable.OnPressedState.BorderRadius = 1;
            this.btnReadSalaryTable.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReadSalaryTable.OnPressedState.BorderThickness = 1;
            this.btnReadSalaryTable.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnReadSalaryTable.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnReadSalaryTable.OnPressedState.IconLeftImage = null;
            this.btnReadSalaryTable.OnPressedState.IconRightImage = null;
            this.btnReadSalaryTable.Size = new System.Drawing.Size(166, 62);
            this.btnReadSalaryTable.TabIndex = 20;
            this.btnReadSalaryTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReadSalaryTable.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReadSalaryTable.TextMarginLeft = 0;
            this.btnReadSalaryTable.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnReadSalaryTable.UseDefaultRadiusAndThickness = true;
            // 
            // IndividualSalaryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1120, 704);
            this.Controls.Add(this.btnReadSalaryTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.dtpChooseMonth);
            this.Controls.Add(this.dgvSalaryTable);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "IndividualSalaryView";
            this.Text = "IndividualSalaryView";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaryTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DateTimePicker dtpChooseMonth;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvSalaryTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn registerCheckInCheckOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn realCheckIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RealCheckOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnReadSalaryTable;
    }
}