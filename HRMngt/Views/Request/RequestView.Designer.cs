namespace HRMngt.Views.Request
{
    partial class RequestView
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpChooseMonth = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtChooseUserID = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cmbChooseType = new System.Windows.Forms.ComboBox();
            this.dgvRequestTable = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRead = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(419, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 27;
            this.label3.Text = "Người gửi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(249, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Loại";
            // 
            // dtpChooseMonth
            // 
            this.dtpChooseMonth.CustomFormat = "MM - yyyy";
            this.dtpChooseMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpChooseMonth.Location = new System.Drawing.Point(22, 53);
            this.dtpChooseMonth.MinimumSize = new System.Drawing.Size(4, 50);
            this.dtpChooseMonth.Name = "dtpChooseMonth";
            this.dtpChooseMonth.Size = new System.Drawing.Size(200, 50);
            this.dtpChooseMonth.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Tháng";
            // 
            // txtChooseUserID
            // 
            this.txtChooseUserID.Location = new System.Drawing.Point(424, 53);
            this.txtChooseUserID.MinimumSize = new System.Drawing.Size(0, 50);
            this.txtChooseUserID.Name = "txtChooseUserID";
            this.txtChooseUserID.Size = new System.Drawing.Size(141, 50);
            this.txtChooseUserID.StateCommon.Border.Color1 = System.Drawing.SystemColors.ControlDarkDark;
            this.txtChooseUserID.StateCommon.Border.Color2 = System.Drawing.SystemColors.ControlDarkDark;
            this.txtChooseUserID.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtChooseUserID.StateCommon.Content.Color1 = System.Drawing.SystemColors.ControlDarkDark;
            this.txtChooseUserID.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChooseUserID.TabIndex = 23;
            // 
            // cmbChooseType
            // 
            this.cmbChooseType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChooseType.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmbChooseType.FormattingEnabled = true;
            this.cmbChooseType.ItemHeight = 25;
            this.cmbChooseType.Items.AddRange(new object[] {
            "All",
            "Thumb Up",
            "Ticket"});
            this.cmbChooseType.Location = new System.Drawing.Point(254, 55);
            this.cmbChooseType.Name = "cmbChooseType";
            this.cmbChooseType.Size = new System.Drawing.Size(140, 33);
            this.cmbChooseType.TabIndex = 22;
            // 
            // dgvRequestTable
            // 
            this.dgvRequestTable.AllowUserToAddRows = false;
            this.dgvRequestTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRequestTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequestTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.TypeCol,
            this.time,
            this.TimeCol,
            this.UserIDCol,
            this.btnRead});
            this.dgvRequestTable.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Mixed;
            this.dgvRequestTable.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ContextMenuSeparator;
            this.dgvRequestTable.HideOuterBorders = true;
            this.dgvRequestTable.Location = new System.Drawing.Point(22, 119);
            this.dgvRequestTable.Name = "dgvRequestTable";
            this.dgvRequestTable.ReadOnly = true;
            this.dgvRequestTable.RowHeadersVisible = false;
            this.dgvRequestTable.RowHeadersWidth = 90;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvRequestTable.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRequestTable.RowTemplate.Height = 50;
            this.dgvRequestTable.RowTemplate.ReadOnly = true;
            this.dgvRequestTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvRequestTable.ShowCellErrors = false;
            this.dgvRequestTable.ShowCellToolTips = false;
            this.dgvRequestTable.ShowEditingIcon = false;
            this.dgvRequestTable.ShowRowErrors = false;
            this.dgvRequestTable.Size = new System.Drawing.Size(1197, 472);
            this.dgvRequestTable.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ContextMenuSeparator;
            this.dgvRequestTable.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.White;
            this.dgvRequestTable.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgvRequestTable.StateCommon.DataCell.Content.Padding = new System.Windows.Forms.Padding(1);
            this.dgvRequestTable.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvRequestTable.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvRequestTable.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.White;
            this.dgvRequestTable.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgvRequestTable.StateCommon.HeaderColumn.Content.Padding = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.dgvRequestTable.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.White;
            this.dgvRequestTable.StateSelected.DataCell.Back.Color2 = System.Drawing.Color.White;
            this.dgvRequestTable.TabIndex = 20;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 55.48507F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::HRMngt.Properties.Resources.read;
            this.dataGridViewImageColumn1.MinimumWidth = 10;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 80;
            // 
            // id
            // 
            this.id.FillWeight = 184.3318F;
            this.id.HeaderText = "Mã";
            this.id.MinimumWidth = 10;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 200;
            // 
            // TypeCol
            // 
            this.TypeCol.FillWeight = 154.3581F;
            this.TypeCol.HeaderText = "Loại";
            this.TypeCol.MinimumWidth = 10;
            this.TypeCol.Name = "TypeCol";
            this.TypeCol.ReadOnly = true;
            this.TypeCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TypeCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TypeCol.Width = 200;
            // 
            // time
            // 
            this.time.HeaderText = "Thời gian";
            this.time.MinimumWidth = 10;
            this.time.Name = "time";
            this.time.ReadOnly = true;
            this.time.Width = 300;
            // 
            // TimeCol
            // 
            this.TimeCol.FillWeight = 194.8644F;
            this.TimeCol.HeaderText = "Người gửi";
            this.TimeCol.MinimumWidth = 10;
            this.TimeCol.Name = "TimeCol";
            this.TimeCol.ReadOnly = true;
            this.TimeCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TimeCol.Width = 200;
            // 
            // UserIDCol
            // 
            this.UserIDCol.FillWeight = 97.99445F;
            this.UserIDCol.HeaderText = "Trạng thái";
            this.UserIDCol.MinimumWidth = 10;
            this.UserIDCol.Name = "UserIDCol";
            this.UserIDCol.ReadOnly = true;
            this.UserIDCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.UserIDCol.Width = 200;
            // 
            // btnRead
            // 
            this.btnRead.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.btnRead.FillWeight = 55.48507F;
            this.btnRead.HeaderText = "";
            this.btnRead.Image = global::HRMngt.Properties.Resources.read;
            this.btnRead.MinimumWidth = 10;
            this.btnRead.Name = "btnRead";
            this.btnRead.ReadOnly = true;
            // 
            // RequestView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1246, 620);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpChooseMonth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtChooseUserID);
            this.Controls.Add(this.cmbChooseType);
            this.Controls.Add(this.dgvRequestTable);
            this.Name = "RequestView";
            this.Text = "Request";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpChooseMonth;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtChooseUserID;
        private System.Windows.Forms.ComboBox cmbChooseType;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvRequestTable;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserIDCol;
        private System.Windows.Forms.DataGridViewImageColumn btnRead;
    }
}