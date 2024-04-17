namespace HRMngt.Views.Dialogs
{
    partial class IndividualSalaryDialog
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDetailSalaryTable = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnComplain = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnConfirm = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailSalaryTable)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(131, 173);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 16);
            this.lblStatus.TabIndex = 28;
            this.lblStatus.Text = "label9";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(131, 138);
            this.lblMonth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(44, 16);
            this.lblMonth.TabIndex = 27;
            this.lblMonth.Text = "label8";
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(131, 104);
            this.lblUserId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(44, 16);
            this.lblUserId.TabIndex = 26;
            this.lblUserId.Text = "label7";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(131, 71);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(44, 16);
            this.lblUserName.TabIndex = 25;
            this.lblUserName.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(34, 173);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Trạng thái:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(43, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Kỳ lương:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(55, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Mã NV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(34, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nhân viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "BẢNG LƯƠNG NHÂN VIÊN";
            // 
            // dgvDetailSalaryTable
            // 
            this.dgvDetailSalaryTable.AllowUserToAddRows = false;
            this.dgvDetailSalaryTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetailSalaryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailSalaryTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.Item,
            this.Info});
            this.dgvDetailSalaryTable.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Mixed;
            this.dgvDetailSalaryTable.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ContextMenuSeparator;
            this.dgvDetailSalaryTable.HideOuterBorders = true;
            this.dgvDetailSalaryTable.Location = new System.Drawing.Point(26, 219);
            this.dgvDetailSalaryTable.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDetailSalaryTable.Name = "dgvDetailSalaryTable";
            this.dgvDetailSalaryTable.ReadOnly = true;
            this.dgvDetailSalaryTable.RowHeadersVisible = false;
            this.dgvDetailSalaryTable.RowHeadersWidth = 90;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDetailSalaryTable.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetailSalaryTable.RowTemplate.Height = 50;
            this.dgvDetailSalaryTable.RowTemplate.ReadOnly = true;
            this.dgvDetailSalaryTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDetailSalaryTable.ShowCellErrors = false;
            this.dgvDetailSalaryTable.ShowCellToolTips = false;
            this.dgvDetailSalaryTable.ShowEditingIcon = false;
            this.dgvDetailSalaryTable.ShowRowErrors = false;
            this.dgvDetailSalaryTable.Size = new System.Drawing.Size(446, 513);
            this.dgvDetailSalaryTable.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ContextMenuSeparator;
            this.dgvDetailSalaryTable.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.White;
            this.dgvDetailSalaryTable.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgvDetailSalaryTable.StateCommon.DataCell.Content.Padding = new System.Windows.Forms.Padding(1);
            this.dgvDetailSalaryTable.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvDetailSalaryTable.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvDetailSalaryTable.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.White;
            this.dgvDetailSalaryTable.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgvDetailSalaryTable.StateCommon.HeaderColumn.Content.Padding = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.dgvDetailSalaryTable.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.White;
            this.dgvDetailSalaryTable.StateSelected.DataCell.Back.Color2 = System.Drawing.Color.White;
            this.dgvDetailSalaryTable.TabIndex = 19;
            // 
            // no
            // 
            this.no.HeaderText = "STT";
            this.no.MinimumWidth = 10;
            this.no.Name = "no";
            this.no.ReadOnly = true;
            this.no.Width = 200;
            // 
            // Item
            // 
            this.Item.HeaderText = "Danh mục";
            this.Item.MinimumWidth = 10;
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            this.Item.Width = 300;
            // 
            // Info
            // 
            this.Info.HeaderText = "Thông tin";
            this.Info.MinimumWidth = 10;
            this.Info.Name = "Info";
            this.Info.ReadOnly = true;
            this.Info.Width = 200;
            // 
            // btnComplain
            // 
            this.btnComplain.Location = new System.Drawing.Point(256, 676);
            this.btnComplain.Margin = new System.Windows.Forms.Padding(2);
            this.btnComplain.Name = "btnComplain";
            this.btnComplain.Size = new System.Drawing.Size(88, 33);
            this.btnComplain.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnComplain.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnComplain.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnComplain.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnComplain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnComplain.StateCommon.Border.Rounding = 10;
            this.btnComplain.StateCommon.Border.Width = 2;
            this.btnComplain.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnComplain.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnComplain.TabIndex = 30;
            this.btnComplain.Values.Text = "Phản hồi";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(140, 676);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(88, 33);
            this.btnConfirm.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnConfirm.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnConfirm.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(158)))), ((int)(((byte)(26)))));
            this.btnConfirm.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(158)))), ((int)(((byte)(26)))));
            this.btnConfirm.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnConfirm.StateCommon.Border.Rounding = 10;
            this.btnConfirm.StateCommon.Border.Width = 2;
            this.btnConfirm.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(158)))), ((int)(((byte)(26)))));
            this.btnConfirm.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(158)))), ((int)(((byte)(26)))));
            this.btnConfirm.TabIndex = 29;
            this.btnConfirm.Values.Text = "Xác nhận";
            // 
            // IndividualSalaryDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 743);
            this.Controls.Add(this.btnComplain);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDetailSalaryTable);
            this.Name = "IndividualSalaryDialog";
            this.Text = "IndividualSalaryDialog";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailSalaryTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvDetailSalaryTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Info;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnComplain;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnConfirm;
    }
}