namespace HRMngt.Views.Dialogs
{
    partial class TimeKeepingView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dgvTimeKeepingTable = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tên = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContentCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoneyCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.approve = new System.Windows.Forms.DataGridViewButtonColumn();
            this.notApprove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeKeepingTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(980, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Trạng thái";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "All",
            "Created",
            "Approved",
            "Confirmed",
            "Not Approved"});
            this.cmbStatus.Location = new System.Drawing.Point(986, 70);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(192, 33);
            this.cmbStatus.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(516, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Phòng ban";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(520, 67);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(192, 33);
            this.cmbDepartment.TabIndex = 16;
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "dd/MM/yyyy";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(276, 70);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 31);
            this.dtpEnd.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(272, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ngày kết thúc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(32, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ngày bắt đầu";
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "dd/MM/yyyy";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(36, 70);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 31);
            this.dtpStart.TabIndex = 12;
            // 
            // dgvTimeKeepingTable
            // 
            this.dgvTimeKeepingTable.AllowUserToAddRows = false;
            this.dgvTimeKeepingTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTimeKeepingTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimeKeepingTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.userInfo,
            this.Tên,
            this.TimeCol,
            this.UserIDCol,
            this.ContentCol,
            this.MoneyCol,
            this.StateCol,
            this.status,
            this.btnUpdate,
            this.btnDelete,
            this.approve,
            this.notApprove});
            this.dgvTimeKeepingTable.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Mixed;
            this.dgvTimeKeepingTable.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ContextMenuSeparator;
            this.dgvTimeKeepingTable.HideOuterBorders = true;
            this.dgvTimeKeepingTable.Location = new System.Drawing.Point(36, 127);
            this.dgvTimeKeepingTable.Name = "dgvTimeKeepingTable";
            this.dgvTimeKeepingTable.ReadOnly = true;
            this.dgvTimeKeepingTable.RowHeadersVisible = false;
            this.dgvTimeKeepingTable.RowHeadersWidth = 90;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvTimeKeepingTable.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTimeKeepingTable.RowTemplate.Height = 50;
            this.dgvTimeKeepingTable.RowTemplate.ReadOnly = true;
            this.dgvTimeKeepingTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvTimeKeepingTable.ShowCellErrors = false;
            this.dgvTimeKeepingTable.ShowCellToolTips = false;
            this.dgvTimeKeepingTable.ShowEditingIcon = false;
            this.dgvTimeKeepingTable.ShowRowErrors = false;
            this.dgvTimeKeepingTable.Size = new System.Drawing.Size(1456, 695);
            this.dgvTimeKeepingTable.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ContextMenuSeparator;
            this.dgvTimeKeepingTable.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.White;
            this.dgvTimeKeepingTable.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgvTimeKeepingTable.StateCommon.DataCell.Content.Padding = new System.Windows.Forms.Padding(1);
            this.dgvTimeKeepingTable.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvTimeKeepingTable.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvTimeKeepingTable.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.White;
            this.dgvTimeKeepingTable.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgvTimeKeepingTable.StateCommon.HeaderColumn.Content.Padding = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.dgvTimeKeepingTable.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.White;
            this.dgvTimeKeepingTable.StateSelected.DataCell.Back.Color2 = System.Drawing.Color.White;
            this.dgvTimeKeepingTable.TabIndex = 11;
            // 
            // id
            // 
            this.id.HeaderText = "Mã NV";
            this.id.MinimumWidth = 10;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 200;
            // 
            // userInfo
            // 
            this.userInfo.FillWeight = 184.3318F;
            this.userInfo.HeaderText = "Nhân viên";
            this.userInfo.MinimumWidth = 10;
            this.userInfo.Name = "userInfo";
            this.userInfo.ReadOnly = true;
            this.userInfo.Width = 200;
            // 
            // Tên
            // 
            this.Tên.FillWeight = 154.3581F;
            this.Tên.HeaderText = "Phòng Ban";
            this.Tên.MinimumWidth = 10;
            this.Tên.Name = "Tên";
            this.Tên.ReadOnly = true;
            this.Tên.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Tên.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Tên.Width = 200;
            // 
            // TimeCol
            // 
            this.TimeCol.FillWeight = 194.8644F;
            this.TimeCol.HeaderText = "Ngày";
            this.TimeCol.MinimumWidth = 10;
            this.TimeCol.Name = "TimeCol";
            this.TimeCol.ReadOnly = true;
            this.TimeCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TimeCol.Width = 200;
            // 
            // UserIDCol
            // 
            this.UserIDCol.FillWeight = 97.99445F;
            this.UserIDCol.HeaderText = "Start";
            this.UserIDCol.MinimumWidth = 10;
            this.UserIDCol.Name = "UserIDCol";
            this.UserIDCol.ReadOnly = true;
            this.UserIDCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.UserIDCol.Width = 200;
            // 
            // ContentCol
            // 
            this.ContentCol.FillWeight = 83.93552F;
            this.ContentCol.HeaderText = "End";
            this.ContentCol.MinimumWidth = 10;
            this.ContentCol.Name = "ContentCol";
            this.ContentCol.ReadOnly = true;
            this.ContentCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ContentCol.Width = 250;
            // 
            // MoneyCol
            // 
            this.MoneyCol.FillWeight = 72.4681F;
            this.MoneyCol.HeaderText = "Check in";
            this.MoneyCol.MinimumWidth = 10;
            this.MoneyCol.Name = "MoneyCol";
            this.MoneyCol.ReadOnly = true;
            this.MoneyCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MoneyCol.Width = 200;
            // 
            // StateCol
            // 
            this.StateCol.FillWeight = 63.1145F;
            this.StateCol.HeaderText = "Check out";
            this.StateCol.MinimumWidth = 10;
            this.StateCol.Name = "StateCol";
            this.StateCol.ReadOnly = true;
            this.StateCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.StateCol.Width = 200;
            // 
            // status
            // 
            this.status.HeaderText = "Trạng thái";
            this.status.MinimumWidth = 10;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 200;
            // 
            // btnUpdate
            // 
            this.btnUpdate.FillWeight = 49.26197F;
            this.btnUpdate.HeaderText = "";
            this.btnUpdate.Image = global::HRMngt.Properties.Resources.update;
            this.btnUpdate.MinimumWidth = 10;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ReadOnly = true;
            this.btnUpdate.Width = 80;
            // 
            // btnDelete
            // 
            this.btnDelete.FillWeight = 44.18599F;
            this.btnDelete.HeaderText = "";
            this.btnDelete.Image = global::HRMngt.Properties.Resources.delete;
            this.btnDelete.MinimumWidth = 10;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ReadOnly = true;
            this.btnDelete.Width = 80;
            // 
            // approve
            // 
            this.approve.HeaderText = "";
            this.approve.MinimumWidth = 10;
            this.approve.Name = "approve";
            this.approve.ReadOnly = true;
            this.approve.Width = 200;
            // 
            // notApprove
            // 
            this.notApprove.HeaderText = "";
            this.notApprove.MinimumWidth = 10;
            this.notApprove.Name = "notApprove";
            this.notApprove.ReadOnly = true;
            this.notApprove.Width = 200;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(745, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Nhân viên";
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(750, 67);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(195, 31);
            this.txtUserId.TabIndex = 22;
            // 
            // TimeKeepingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1526, 852);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.dgvTimeKeepingTable);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TimeKeepingView";
            this.Text = "TimeKeepingView";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeKeepingTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvTimeKeepingTable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn userInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tên;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserIDCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContentCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoneyCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn StateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewImageColumn btnUpdate;
        private System.Windows.Forms.DataGridViewImageColumn btnDelete;
        private System.Windows.Forms.DataGridViewButtonColumn approve;
        private System.Windows.Forms.DataGridViewButtonColumn notApprove;
    }
}