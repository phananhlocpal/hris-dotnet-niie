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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbChooseType = new System.Windows.Forms.ComboBox();
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtpChooseMonth = new System.Windows.Forms.DateTimePicker();
            this.txtChooseUserID = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThumbTicketTable)).BeginInit();
            this.SuspendLayout();
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
            this.cmbChooseType.Location = new System.Drawing.Point(267, 66);
            this.cmbChooseType.Name = "cmbChooseType";
            this.cmbChooseType.Size = new System.Drawing.Size(140, 33);
            this.cmbChooseType.TabIndex = 9;
            // 
            // btnCreateThumbTicket
            // 
            this.btnCreateThumbTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateThumbTicket.Location = new System.Drawing.Point(1126, 57);
            this.btnCreateThumbTicket.Name = "btnCreateThumbTicket";
            this.btnCreateThumbTicket.Size = new System.Drawing.Size(106, 51);
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
            this.dgvThumbTicketTable.Location = new System.Drawing.Point(35, 130);
            this.dgvThumbTicketTable.Name = "dgvThumbTicketTable";
            this.dgvThumbTicketTable.ReadOnly = true;
            this.dgvThumbTicketTable.RowHeadersVisible = false;
            this.dgvThumbTicketTable.RowHeadersWidth = 90;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvThumbTicketTable.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvThumbTicketTable.RowTemplate.Height = 50;
            this.dgvThumbTicketTable.RowTemplate.ReadOnly = true;
            this.dgvThumbTicketTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvThumbTicketTable.ShowCellErrors = false;
            this.dgvThumbTicketTable.ShowCellToolTips = false;
            this.dgvThumbTicketTable.ShowEditingIcon = false;
            this.dgvThumbTicketTable.ShowRowErrors = false;
            this.dgvThumbTicketTable.Size = new System.Drawing.Size(1197, 472);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(30, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tháng";
            // 
            // dtpChooseMonth
            // 
            this.dtpChooseMonth.CustomFormat = "MM - yyyy";
            this.dtpChooseMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpChooseMonth.Location = new System.Drawing.Point(35, 64);
            this.dtpChooseMonth.MinimumSize = new System.Drawing.Size(4, 50);
            this.dtpChooseMonth.Name = "dtpChooseMonth";
            this.dtpChooseMonth.Size = new System.Drawing.Size(200, 50);
            this.dtpChooseMonth.TabIndex = 17;
            // 
            // txtChooseUserID
            // 
            this.txtChooseUserID.Location = new System.Drawing.Point(437, 64);
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
            this.txtChooseUserID.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(262, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Loại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(432, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Mã NV";
            // 
            // ThumbTicketView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1269, 630);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpChooseMonth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtChooseUserID);
            this.Controls.Add(this.cmbChooseType);
            this.Controls.Add(this.btnCreateThumbTicket);
            this.Controls.Add(this.dgvThumbTicketTable);
            this.Name = "ThumbTicketView";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvThumbTicketTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbChooseType;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpChooseMonth;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtChooseUserID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}