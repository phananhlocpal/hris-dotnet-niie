﻿namespace HRMngt.Views
{
    partial class DepartmentView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentView));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.cbManager = new System.Windows.Forms.ComboBox();
            this.dgvDepartmentList = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRead = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.saveExcel = new System.Windows.Forms.SaveFileDialog();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnAdd = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.btnExcel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartmentList)).BeginInit();
            this.SuspendLayout();
            // 
            // cbManager
            // 
            this.cbManager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbManager.ForeColor = System.Drawing.Color.Black;
            this.cbManager.FormattingEnabled = true;
            this.cbManager.Location = new System.Drawing.Point(38, 73);
            this.cbManager.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbManager.Name = "cbManager";
            this.cbManager.Size = new System.Drawing.Size(206, 33);
            this.cbManager.TabIndex = 6;
            // 
            // dgvDepartmentList
            // 
            this.dgvDepartmentList.AllowUserToAddRows = false;
            this.dgvDepartmentList.AllowUserToDeleteRows = false;
            this.dgvDepartmentList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDepartmentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartmentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.name,
            this.phone,
            this.manager,
            this.address,
            this.btnRead,
            this.btnEdit,
            this.btnDelete});
            this.dgvDepartmentList.HideOuterBorders = true;
            this.dgvDepartmentList.Location = new System.Drawing.Point(38, 132);
            this.dgvDepartmentList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDepartmentList.Name = "dgvDepartmentList";
            this.dgvDepartmentList.ReadOnly = true;
            this.dgvDepartmentList.RowHeadersVisible = false;
            this.dgvDepartmentList.RowHeadersWidth = 90;
            this.dgvDepartmentList.RowTemplate.Height = 60;
            this.dgvDepartmentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDepartmentList.ShowCellErrors = false;
            this.dgvDepartmentList.ShowCellToolTips = false;
            this.dgvDepartmentList.ShowEditingIcon = false;
            this.dgvDepartmentList.ShowRowErrors = false;
            this.dgvDepartmentList.Size = new System.Drawing.Size(1602, 813);
            this.dgvDepartmentList.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgvDepartmentList.StateCommon.Background.Color2 = System.Drawing.Color.White;
            this.dgvDepartmentList.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvDepartmentList.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.White;
            this.dgvDepartmentList.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.White;
            this.dgvDepartmentList.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.White;
            this.dgvDepartmentList.StateCommon.DataCell.Border.Color2 = System.Drawing.Color.White;
            this.dgvDepartmentList.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgvDepartmentList.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.Black;
            this.dgvDepartmentList.StateCommon.DataCell.Content.Color2 = System.Drawing.Color.Black;
            this.dgvDepartmentList.StateCommon.DataCell.Content.Padding = new System.Windows.Forms.Padding(3);
            this.dgvDepartmentList.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvDepartmentList.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvDepartmentList.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvDepartmentList.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvDepartmentList.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgvDepartmentList.StateCommon.HeaderColumn.Content.Padding = new System.Windows.Forms.Padding(10);
            this.dgvDepartmentList.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.White;
            this.dgvDepartmentList.StateCommon.HeaderRow.Back.Color2 = System.Drawing.Color.White;
            this.dgvDepartmentList.StateCommon.HeaderRow.Content.Padding = new System.Windows.Forms.Padding(10);
            this.dgvDepartmentList.TabIndex = 4;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Tên phòng ban";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phone.HeaderText = "Số điện thoại";
            this.phone.MinimumWidth = 6;
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // manager
            // 
            this.manager.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.manager.HeaderText = "Quản lí";
            this.manager.MinimumWidth = 6;
            this.manager.Name = "manager";
            this.manager.ReadOnly = true;
            // 
            // address
            // 
            this.address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.address.HeaderText = "Địa chỉ";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // btnRead
            // 
            this.btnRead.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.btnRead.HeaderText = "";
            this.btnRead.Image = global::HRMngt.Properties.Resources.read;
            this.btnRead.MinimumWidth = 6;
            this.btnRead.Name = "btnRead";
            this.btnRead.ReadOnly = true;
            this.btnRead.Width = 23;
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.btnEdit.HeaderText = "";
            this.btnEdit.Image = global::HRMngt.Properties.Resources.update;
            this.btnEdit.MinimumWidth = 6;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ReadOnly = true;
            this.btnEdit.Width = 23;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.btnDelete.HeaderText = "";
            this.btnDelete.Image = global::HRMngt.Properties.Resources.delete;
            this.btnDelete.MinimumWidth = 6;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ReadOnly = true;
            this.btnDelete.Width = 23;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::HRMngt.Properties.Resources.read;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 200;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::HRMngt.Properties.Resources.update;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 200;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::HRMngt.Properties.Resources.delete;
            this.dataGridViewImageColumn3.MinimumWidth = 6;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            this.dataGridViewImageColumn3.Width = 200;
            // 
            // btnAdd
            // 
            this.btnAdd.AllowAnimations = true;
            this.btnAdd.AllowMouseEffects = true;
            this.btnAdd.AllowToggling = false;
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.AnimationSpeed = 200;
            this.btnAdd.AutoGenerateColors = false;
            this.btnAdd.AutoRoundBorders = false;
            this.btnAdd.AutoSizeLeftIcon = true;
            this.btnAdd.AutoSizeRightIcon = true;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAdd.ButtonText = "Tạo";
            this.btnAdd.ButtonTextMarginLeft = 0;
            this.btnAdd.ColorContrastOnClick = 45;
            this.btnAdd.ColorContrastOnHover = 45;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnAdd.CustomizableEdges = borderEdges3;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAdd.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAdd.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAdd.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAdd.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAdd.IconMarginLeft = 11;
            this.btnAdd.IconPadding = 10;
            this.btnAdd.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAdd.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAdd.IconSize = 25;
            this.btnAdd.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.IdleBorderRadius = 1;
            this.btnAdd.IdleBorderThickness = 1;
            this.btnAdd.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.IdleIconLeftImage = null;
            this.btnAdd.IdleIconRightImage = null;
            this.btnAdd.IndicateFocus = false;
            this.btnAdd.Location = new System.Drawing.Point(1498, 56);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAdd.OnDisabledState.BorderRadius = 1;
            this.btnAdd.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAdd.OnDisabledState.BorderThickness = 1;
            this.btnAdd.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAdd.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAdd.OnDisabledState.IconLeftImage = null;
            this.btnAdd.OnDisabledState.IconRightImage = null;
            this.btnAdd.onHoverState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.onHoverState.BorderRadius = 1;
            this.btnAdd.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAdd.onHoverState.BorderThickness = 1;
            this.btnAdd.onHoverState.FillColor = System.Drawing.Color.White;
            this.btnAdd.onHoverState.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.onHoverState.IconLeftImage = null;
            this.btnAdd.onHoverState.IconRightImage = null;
            this.btnAdd.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.OnIdleState.BorderRadius = 1;
            this.btnAdd.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAdd.OnIdleState.BorderThickness = 1;
            this.btnAdd.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAdd.OnIdleState.IconLeftImage = null;
            this.btnAdd.OnIdleState.IconRightImage = null;
            this.btnAdd.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAdd.OnPressedState.BorderRadius = 1;
            this.btnAdd.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAdd.OnPressedState.BorderThickness = 1;
            this.btnAdd.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAdd.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAdd.OnPressedState.IconLeftImage = null;
            this.btnAdd.OnPressedState.IconRightImage = null;
            this.btnAdd.Size = new System.Drawing.Size(142, 50);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.TextMarginLeft = 0;
            this.btnAdd.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAdd.UseDefaultRadiusAndThickness = true;
            // 
            // btnExcel
            // 
            this.btnExcel.AllowAnimations = true;
            this.btnExcel.AllowMouseEffects = true;
            this.btnExcel.AllowToggling = false;
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel.AnimationSpeed = 200;
            this.btnExcel.AutoGenerateColors = false;
            this.btnExcel.AutoRoundBorders = false;
            this.btnExcel.AutoSizeLeftIcon = true;
            this.btnExcel.AutoSizeRightIcon = true;
            this.btnExcel.BackColor = System.Drawing.Color.Transparent;
            this.btnExcel.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcel.BackgroundImage")));
            this.btnExcel.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnExcel.ButtonText = "Xuất excel";
            this.btnExcel.ButtonTextMarginLeft = 0;
            this.btnExcel.ColorContrastOnClick = 45;
            this.btnExcel.ColorContrastOnHover = 45;
            this.btnExcel.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnExcel.CustomizableEdges = borderEdges4;
            this.btnExcel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExcel.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnExcel.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnExcel.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnExcel.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnExcel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExcel.ForeColor = System.Drawing.Color.White;
            this.btnExcel.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnExcel.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnExcel.IconMarginLeft = 11;
            this.btnExcel.IconPadding = 10;
            this.btnExcel.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcel.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnExcel.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnExcel.IconSize = 25;
            this.btnExcel.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnExcel.IdleBorderRadius = 1;
            this.btnExcel.IdleBorderThickness = 1;
            this.btnExcel.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnExcel.IdleIconLeftImage = null;
            this.btnExcel.IdleIconRightImage = null;
            this.btnExcel.IndicateFocus = false;
            this.btnExcel.Location = new System.Drawing.Point(1316, 56);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnExcel.OnDisabledState.BorderRadius = 1;
            this.btnExcel.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnExcel.OnDisabledState.BorderThickness = 1;
            this.btnExcel.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnExcel.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnExcel.OnDisabledState.IconLeftImage = null;
            this.btnExcel.OnDisabledState.IconRightImage = null;
            this.btnExcel.onHoverState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnExcel.onHoverState.BorderRadius = 1;
            this.btnExcel.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnExcel.onHoverState.BorderThickness = 1;
            this.btnExcel.onHoverState.FillColor = System.Drawing.Color.White;
            this.btnExcel.onHoverState.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnExcel.onHoverState.IconLeftImage = null;
            this.btnExcel.onHoverState.IconRightImage = null;
            this.btnExcel.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnExcel.OnIdleState.BorderRadius = 1;
            this.btnExcel.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnExcel.OnIdleState.BorderThickness = 1;
            this.btnExcel.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnExcel.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnExcel.OnIdleState.IconLeftImage = null;
            this.btnExcel.OnIdleState.IconRightImage = null;
            this.btnExcel.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnExcel.OnPressedState.BorderRadius = 1;
            this.btnExcel.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnExcel.OnPressedState.BorderThickness = 1;
            this.btnExcel.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnExcel.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnExcel.OnPressedState.IconLeftImage = null;
            this.btnExcel.OnPressedState.IconRightImage = null;
            this.btnExcel.Size = new System.Drawing.Size(142, 50);
            this.btnExcel.TabIndex = 20;
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExcel.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExcel.TextMarginLeft = 0;
            this.btnExcel.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnExcel.UseDefaultRadiusAndThickness = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(38, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Quản lý";
            // 
            // DepartmentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1676, 975);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbManager);
            this.Controls.Add(this.dgvDepartmentList);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DepartmentView";
            this.Text = "Quản lí phòng ban";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartmentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbManager;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvDepartmentList;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn manager;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewImageColumn btnRead;
        private System.Windows.Forms.DataGridViewImageColumn btnEdit;
        private System.Windows.Forms.DataGridViewImageColumn btnDelete;
        private System.Windows.Forms.SaveFileDialog saveExcel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnAdd;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnExcel;
        private System.Windows.Forms.Label label1;
    }
}