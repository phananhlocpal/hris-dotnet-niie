﻿namespace HRMngt.Views.Dialogs
{
    partial class IndividualCalendarView
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.dtpChoosePeriod = new System.Windows.Forms.DateTimePicker();
            this.btnCurrentDate = new System.Windows.Forms.Button();
            this.dgvCalendarTable = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.realCheckIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RealCheckOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalendarTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.Location = new System.Drawing.Point(649, 11);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(85, 32);
            this.btnCreate.TabIndex = 26;
            this.btnCreate.Text = "Tạo";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // dtpChoosePeriod
            // 
            this.dtpChoosePeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpChoosePeriod.Location = new System.Drawing.Point(273, 11);
            this.dtpChoosePeriod.Margin = new System.Windows.Forms.Padding(2);
            this.dtpChoosePeriod.MinimumSize = new System.Drawing.Size(4, 50);
            this.dtpChoosePeriod.Name = "dtpChoosePeriod";
            this.dtpChoosePeriod.Size = new System.Drawing.Size(265, 50);
            this.dtpChoosePeriod.TabIndex = 25;
            // 
            // btnCurrentDate
            // 
            this.btnCurrentDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCurrentDate.Location = new System.Drawing.Point(551, 11);
            this.btnCurrentDate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCurrentDate.Name = "btnCurrentDate";
            this.btnCurrentDate.Size = new System.Drawing.Size(85, 32);
            this.btnCurrentDate.TabIndex = 24;
            this.btnCurrentDate.Text = "Hiện tại";
            this.btnCurrentDate.UseVisualStyleBackColor = true;
            // 
            // dgvCalendarTable
            // 
            this.dgvCalendarTable.AllowUserToAddRows = false;
            this.dgvCalendarTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCalendarTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalendarTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.checkin,
            this.checkout,
            this.realCheckIn,
            this.RealCheckOut,
            this.status,
            this.btnEdit,
            this.btnDelete});
            this.dgvCalendarTable.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Mixed;
            this.dgvCalendarTable.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ContextMenuSeparator;
            this.dgvCalendarTable.HideOuterBorders = true;
            this.dgvCalendarTable.Location = new System.Drawing.Point(-2, 53);
            this.dgvCalendarTable.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCalendarTable.Name = "dgvCalendarTable";
            this.dgvCalendarTable.ReadOnly = true;
            this.dgvCalendarTable.RowHeadersVisible = false;
            this.dgvCalendarTable.RowHeadersWidth = 90;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCalendarTable.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCalendarTable.RowTemplate.Height = 50;
            this.dgvCalendarTable.RowTemplate.ReadOnly = true;
            this.dgvCalendarTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCalendarTable.ShowCellErrors = false;
            this.dgvCalendarTable.ShowCellToolTips = false;
            this.dgvCalendarTable.ShowEditingIcon = false;
            this.dgvCalendarTable.ShowRowErrors = false;
            this.dgvCalendarTable.Size = new System.Drawing.Size(736, 515);
            this.dgvCalendarTable.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ContextMenuSeparator;
            this.dgvCalendarTable.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.White;
            this.dgvCalendarTable.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgvCalendarTable.StateCommon.DataCell.Content.Padding = new System.Windows.Forms.Padding(1);
            this.dgvCalendarTable.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvCalendarTable.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvCalendarTable.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.White;
            this.dgvCalendarTable.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgvCalendarTable.StateCommon.HeaderColumn.Content.Padding = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.dgvCalendarTable.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.White;
            this.dgvCalendarTable.StateSelected.DataCell.Back.Color2 = System.Drawing.Color.White;
            this.dgvCalendarTable.TabIndex = 23;
            // 
            // date
            // 
            this.date.HeaderText = "Ngày";
            this.date.MinimumWidth = 10;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 200;
            // 
            // checkin
            // 
            this.checkin.HeaderText = "Checkin";
            this.checkin.MinimumWidth = 10;
            this.checkin.Name = "checkin";
            this.checkin.ReadOnly = true;
            this.checkin.Width = 200;
            // 
            // checkout
            // 
            this.checkout.HeaderText = "Checkout";
            this.checkout.MinimumWidth = 10;
            this.checkout.Name = "checkout";
            this.checkout.ReadOnly = true;
            this.checkout.Width = 200;
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
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::HRMngt.Properties.Resources.update;
            this.dataGridViewImageColumn1.MinimumWidth = 10;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::HRMngt.Properties.Resources.delete;
            this.dataGridViewImageColumn2.MinimumWidth = 10;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 125;
            // 
            // btnEdit
            // 
            this.btnEdit.HeaderText = "";
            this.btnEdit.Image = global::HRMngt.Properties.Resources.update;
            this.btnEdit.MinimumWidth = 10;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ReadOnly = true;
            this.btnEdit.Width = 125;
            // 
            // btnDelete
            // 
            this.btnDelete.HeaderText = "";
            this.btnDelete.Image = global::HRMngt.Properties.Resources.delete;
            this.btnDelete.MinimumWidth = 10;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ReadOnly = true;
            this.btnDelete.Width = 125;
            // 
            // IndividualCalendarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 578);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dtpChoosePeriod);
            this.Controls.Add(this.btnCurrentDate);
            this.Controls.Add(this.dgvCalendarTable);
            this.Name = "IndividualCalendarView";
            this.Text = "IndividualCalendarView";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalendarTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DateTimePicker dtpChoosePeriod;
        private System.Windows.Forms.Button btnCurrentDate;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvCalendarTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkin;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkout;
        private System.Windows.Forms.DataGridViewTextBoxColumn realCheckIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RealCheckOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewImageColumn btnEdit;
        private System.Windows.Forms.DataGridViewImageColumn btnDelete;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
    }
}