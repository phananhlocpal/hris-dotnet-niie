namespace HRMngt.View
{
    partial class ThumbTicketView
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
            this.txtChooseUserID = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cmbChooseType = new System.Windows.Forms.ComboBox();
            this.cmbChooseMonth = new System.Windows.Forms.ComboBox();
            this.btnCreateThumbTicket = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dgvThumbTicketTable = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContentCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoneyCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRead = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnUpdate = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThumbTicketTable)).BeginInit();
            this.SuspendLayout();
            // 
            // txtChooseUserID
            // 
            this.txtChooseUserID.Location = new System.Drawing.Point(233, 29);
            this.txtChooseUserID.Margin = new System.Windows.Forms.Padding(2);
            this.txtChooseUserID.Name = "txtChooseUserID";
            this.txtChooseUserID.Size = new System.Drawing.Size(88, 24);
            this.txtChooseUserID.StateCommon.Border.Color1 = System.Drawing.SystemColors.ControlDarkDark;
            this.txtChooseUserID.StateCommon.Border.Color2 = System.Drawing.SystemColors.ControlDarkDark;
            this.txtChooseUserID.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtChooseUserID.StateCommon.Content.Color1 = System.Drawing.SystemColors.ControlDarkDark;
            this.txtChooseUserID.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChooseUserID.TabIndex = 10;
            this.txtChooseUserID.Text = "Mã NV";
            // 
            // cmbChooseType
            // 
            this.cmbChooseType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChooseType.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmbChooseType.FormattingEnabled = true;
            this.cmbChooseType.Items.AddRange(new object[] {
            "Thumb Up",
            "Ticket"});
            this.cmbChooseType.Location = new System.Drawing.Point(128, 27);
            this.cmbChooseType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbChooseType.Name = "cmbChooseType";
            this.cmbChooseType.Size = new System.Drawing.Size(89, 24);
            this.cmbChooseType.TabIndex = 9;
            this.cmbChooseType.Text = "Loại";
            // 
            // cmbChooseMonth
            // 
            this.cmbChooseMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChooseMonth.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmbChooseMonth.FormattingEnabled = true;
            this.cmbChooseMonth.Items.AddRange(new object[] {
            "Tháng 1",
            "Tháng 2",
            "Tháng 3",
            "Tháng 4",
            "Tháng 5",
            "Tháng 6",
            "Tháng 7",
            "Tháng 8",
            "Tháng 9",
            "Tháng 10",
            "Tháng 11",
            "Tháng 12"});
            this.cmbChooseMonth.Location = new System.Drawing.Point(22, 27);
            this.cmbChooseMonth.Margin = new System.Windows.Forms.Padding(2);
            this.cmbChooseMonth.Name = "cmbChooseMonth";
            this.cmbChooseMonth.Size = new System.Drawing.Size(89, 24);
            this.cmbChooseMonth.TabIndex = 8;
            this.cmbChooseMonth.Text = "Tháng 1";
            // 
            // btnCreateThumbTicket
            // 
            this.btnCreateThumbTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateThumbTicket.Location = new System.Drawing.Point(704, 18);
            this.btnCreateThumbTicket.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateThumbTicket.Name = "btnCreateThumbTicket";
            this.btnCreateThumbTicket.Size = new System.Drawing.Size(66, 32);
            this.btnCreateThumbTicket.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnCreateThumbTicket.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnCreateThumbTicket.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(158)))), ((int)(((byte)(26)))));
            this.btnCreateThumbTicket.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(158)))), ((int)(((byte)(26)))));
            this.btnCreateThumbTicket.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCreateThumbTicket.StateCommon.Border.Rounding = 10;
            this.btnCreateThumbTicket.StateCommon.Border.Width = 1;
            this.btnCreateThumbTicket.StateCommon.Content.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(158)))), ((int)(((byte)(26)))));
            this.btnCreateThumbTicket.StateCommon.Content.LongText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(158)))), ((int)(((byte)(26)))));
            this.btnCreateThumbTicket.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateThumbTicket.StateCommon.Content.Padding = new System.Windows.Forms.Padding(0);
            this.btnCreateThumbTicket.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(158)))), ((int)(((byte)(26)))));
            this.btnCreateThumbTicket.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(158)))), ((int)(((byte)(26)))));
            this.btnCreateThumbTicket.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.btnCreateThumbTicket.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.btnCreateThumbTicket.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(158)))), ((int)(((byte)(26)))));
            this.btnCreateThumbTicket.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(158)))), ((int)(((byte)(26)))));
            this.btnCreateThumbTicket.StateTracking.Content.LongText.Color1 = System.Drawing.Color.White;
            this.btnCreateThumbTicket.StateTracking.Content.LongText.Color2 = System.Drawing.Color.White;
            this.btnCreateThumbTicket.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnCreateThumbTicket.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnCreateThumbTicket.TabIndex = 7;
            this.btnCreateThumbTicket.Values.Text = "Tạo";
            // 
            // dgvThumbTicketTable
            // 
            this.dgvThumbTicketTable.AllowUserToAddRows = false;
            this.dgvThumbTicketTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvThumbTicketTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThumbTicketTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.TypeCol,
            this.TimeCol,
            this.UserIDCol,
            this.ContentCol,
            this.MoneyCol,
            this.StateCol,
            this.btnRead,
            this.btnUpdate,
            this.btnDelete});
            this.dgvThumbTicketTable.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Mixed;
            this.dgvThumbTicketTable.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ContextMenuSeparator;
            this.dgvThumbTicketTable.HideOuterBorders = true;
            this.dgvThumbTicketTable.Location = new System.Drawing.Point(22, 63);
            this.dgvThumbTicketTable.Margin = new System.Windows.Forms.Padding(2);
            this.dgvThumbTicketTable.Name = "dgvThumbTicketTable";
            this.dgvThumbTicketTable.ReadOnly = true;
            this.dgvThumbTicketTable.RowHeadersVisible = false;
            this.dgvThumbTicketTable.RowHeadersWidth = 90;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvThumbTicketTable.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThumbTicketTable.RowTemplate.Height = 50;
            this.dgvThumbTicketTable.RowTemplate.ReadOnly = true;
            this.dgvThumbTicketTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvThumbTicketTable.ShowCellErrors = false;
            this.dgvThumbTicketTable.ShowCellToolTips = false;
            this.dgvThumbTicketTable.ShowEditingIcon = false;
            this.dgvThumbTicketTable.ShowRowErrors = false;
            this.dgvThumbTicketTable.Size = new System.Drawing.Size(748, 313);
            this.dgvThumbTicketTable.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ContextMenuSeparator;
            this.dgvThumbTicketTable.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.White;
            this.dgvThumbTicketTable.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgvThumbTicketTable.StateCommon.DataCell.Content.Padding = new System.Windows.Forms.Padding(1);
            this.dgvThumbTicketTable.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvThumbTicketTable.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvThumbTicketTable.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.White;
            this.dgvThumbTicketTable.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgvThumbTicketTable.StateCommon.HeaderColumn.Content.Padding = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.dgvThumbTicketTable.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.White;
            this.dgvThumbTicketTable.StateSelected.DataCell.Back.Color2 = System.Drawing.Color.White;
            this.dgvThumbTicketTable.TabIndex = 6;
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
            // TimeCol
            // 
            this.TimeCol.FillWeight = 194.8644F;
            this.TimeCol.HeaderText = "Thời gian";
            this.TimeCol.MinimumWidth = 10;
            this.TimeCol.Name = "TimeCol";
            this.TimeCol.ReadOnly = true;
            this.TimeCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TimeCol.Width = 200;
            // 
            // UserIDCol
            // 
            this.UserIDCol.FillWeight = 97.99445F;
            this.UserIDCol.HeaderText = "Mã NV";
            this.UserIDCol.MinimumWidth = 10;
            this.UserIDCol.Name = "UserIDCol";
            this.UserIDCol.ReadOnly = true;
            this.UserIDCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.UserIDCol.Width = 200;
            // 
            // ContentCol
            // 
            this.ContentCol.FillWeight = 83.93552F;
            this.ContentCol.HeaderText = "Lý do";
            this.ContentCol.MinimumWidth = 10;
            this.ContentCol.Name = "ContentCol";
            this.ContentCol.ReadOnly = true;
            this.ContentCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ContentCol.Width = 250;
            // 
            // MoneyCol
            // 
            this.MoneyCol.FillWeight = 72.4681F;
            this.MoneyCol.HeaderText = "Số tiền";
            this.MoneyCol.MinimumWidth = 10;
            this.MoneyCol.Name = "MoneyCol";
            this.MoneyCol.ReadOnly = true;
            this.MoneyCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MoneyCol.Width = 200;
            // 
            // StateCol
            // 
            this.StateCol.FillWeight = 63.1145F;
            this.StateCol.HeaderText = "Trạng thái";
            this.StateCol.MinimumWidth = 10;
            this.StateCol.Name = "StateCol";
            this.StateCol.ReadOnly = true;
            this.StateCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.StateCol.Width = 200;
            // 
            // btnRead
            // 
            this.btnRead.FillWeight = 55.48507F;
            this.btnRead.HeaderText = "";
            this.btnRead.Image = global::HRMngt.Properties.Resources.read;
            this.btnRead.MinimumWidth = 10;
            this.btnRead.Name = "btnRead";
            this.btnRead.ReadOnly = true;
            this.btnRead.Width = 80;
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
            // ThumbTicketView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(793, 394);
            this.Controls.Add(this.txtChooseUserID);
            this.Controls.Add(this.cmbChooseType);
            this.Controls.Add(this.cmbChooseMonth);
            this.Controls.Add(this.btnCreateThumbTicket);
            this.Controls.Add(this.dgvThumbTicketTable);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ThumbTicketView";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvThumbTicketTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtChooseUserID;
        private System.Windows.Forms.ComboBox cmbChooseType;
        private System.Windows.Forms.ComboBox cmbChooseMonth;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCreateThumbTicket;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvThumbTicketTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserIDCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContentCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoneyCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn StateCol;
        private System.Windows.Forms.DataGridViewImageColumn btnRead;
        private System.Windows.Forms.DataGridViewImageColumn btnUpdate;
        private System.Windows.Forms.DataGridViewImageColumn btnDelete;
    }
}