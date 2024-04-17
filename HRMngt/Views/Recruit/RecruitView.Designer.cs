﻿namespace HRMngt.Views.HR
{
    partial class RecruitView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecruitView));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.dgvHRList = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.btnAdd = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.btnExcel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.btnRefuseAll = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.btnAcceptAll = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRead = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHRList)).BeginInit();
            this.SuspendLayout();
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(157, 24);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(142, 24);
            this.cbStatus.TabIndex = 12;
            // 
            // cbDepartment
            // 
            this.cbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartment.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(12, 24);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(139, 24);
            this.cbDepartment.TabIndex = 11;
            // 
            // dgvHRList
            // 
            this.dgvHRList.AllowUserToAddRows = false;
            this.dgvHRList.AllowUserToDeleteRows = false;
            this.dgvHRList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHRList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHRList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.name,
            this.phone,
            this.roles,
            this.position,
            this.status,
            this.btnRead,
            this.btnEdit,
            this.btnDelete});
            this.dgvHRList.Location = new System.Drawing.Point(12, 63);
            this.dgvHRList.Name = "dgvHRList";
            this.dgvHRList.RowHeadersVisible = false;
            this.dgvHRList.RowHeadersWidth = 51;
            this.dgvHRList.RowTemplate.Height = 24;
            this.dgvHRList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvHRList.ShowCellErrors = false;
            this.dgvHRList.ShowCellToolTips = false;
            this.dgvHRList.ShowEditingIcon = false;
            this.dgvHRList.ShowRowErrors = false;
            this.dgvHRList.Size = new System.Drawing.Size(1104, 546);
            this.dgvHRList.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgvHRList.StateCommon.Background.Color2 = System.Drawing.Color.White;
            this.dgvHRList.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvHRList.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.White;
            this.dgvHRList.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.White;
            this.dgvHRList.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.White;
            this.dgvHRList.StateCommon.DataCell.Border.Color2 = System.Drawing.Color.White;
            this.dgvHRList.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgvHRList.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.Black;
            this.dgvHRList.StateCommon.DataCell.Content.Color2 = System.Drawing.Color.Black;
            this.dgvHRList.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvHRList.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvHRList.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvHRList.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvHRList.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgvHRList.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.White;
            this.dgvHRList.StateCommon.HeaderRow.Back.Color2 = System.Drawing.Color.White;
            this.dgvHRList.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.AllowAnimations = true;
            this.btnAdd.AllowMouseEffects = true;
            this.btnAdd.AllowToggling = false;
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
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.btnAdd.CustomizableEdges = borderEdges5;
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
            this.btnAdd.Location = new System.Drawing.Point(926, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAdd.OnDisabledState.BorderRadius = 1;
            this.btnAdd.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAdd.OnDisabledState.BorderThickness = 1;
            this.btnAdd.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAdd.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAdd.OnDisabledState.IconLeftImage = null;
            this.btnAdd.OnDisabledState.IconRightImage = null;
            this.btnAdd.onHoverState.BorderColor = System.Drawing.Color.White;
            this.btnAdd.onHoverState.BorderRadius = 1;
            this.btnAdd.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAdd.onHoverState.BorderThickness = 1;
            this.btnAdd.onHoverState.FillColor = System.Drawing.Color.White;
            this.btnAdd.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
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
            this.btnAdd.Size = new System.Drawing.Size(93, 44);
            this.btnAdd.TabIndex = 16;
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
            this.btnExcel.AnimationSpeed = 200;
            this.btnExcel.AutoGenerateColors = false;
            this.btnExcel.AutoRoundBorders = false;
            this.btnExcel.AutoSizeLeftIcon = true;
            this.btnExcel.AutoSizeRightIcon = true;
            this.btnExcel.BackColor = System.Drawing.Color.Transparent;
            this.btnExcel.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcel.BackgroundImage")));
            this.btnExcel.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnExcel.ButtonText = "Xuất Excel";
            this.btnExcel.ButtonTextMarginLeft = 0;
            this.btnExcel.ColorContrastOnClick = 45;
            this.btnExcel.ColorContrastOnHover = 45;
            this.btnExcel.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.btnExcel.CustomizableEdges = borderEdges6;
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
            this.btnExcel.Location = new System.Drawing.Point(807, 13);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnExcel.OnDisabledState.BorderRadius = 1;
            this.btnExcel.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnExcel.OnDisabledState.BorderThickness = 1;
            this.btnExcel.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnExcel.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnExcel.OnDisabledState.IconLeftImage = null;
            this.btnExcel.OnDisabledState.IconRightImage = null;
            this.btnExcel.onHoverState.BorderColor = System.Drawing.Color.White;
            this.btnExcel.onHoverState.BorderRadius = 1;
            this.btnExcel.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnExcel.onHoverState.BorderThickness = 1;
            this.btnExcel.onHoverState.FillColor = System.Drawing.Color.White;
            this.btnExcel.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
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
            this.btnExcel.Size = new System.Drawing.Size(93, 44);
            this.btnExcel.TabIndex = 17;
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExcel.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExcel.TextMarginLeft = 0;
            this.btnExcel.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnExcel.UseDefaultRadiusAndThickness = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnRefuseAll
            // 
            this.btnRefuseAll.AllowAnimations = true;
            this.btnRefuseAll.AllowMouseEffects = true;
            this.btnRefuseAll.AllowToggling = false;
            this.btnRefuseAll.AnimationSpeed = 200;
            this.btnRefuseAll.AutoGenerateColors = false;
            this.btnRefuseAll.AutoRoundBorders = false;
            this.btnRefuseAll.AutoSizeLeftIcon = true;
            this.btnRefuseAll.AutoSizeRightIcon = true;
            this.btnRefuseAll.BackColor = System.Drawing.Color.Transparent;
            this.btnRefuseAll.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnRefuseAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefuseAll.BackgroundImage")));
            this.btnRefuseAll.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnRefuseAll.ButtonText = "Từ chối toàn bộ";
            this.btnRefuseAll.ButtonTextMarginLeft = 0;
            this.btnRefuseAll.ColorContrastOnClick = 45;
            this.btnRefuseAll.ColorContrastOnHover = 45;
            this.btnRefuseAll.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges7.BottomLeft = true;
            borderEdges7.BottomRight = true;
            borderEdges7.TopLeft = true;
            borderEdges7.TopRight = true;
            this.btnRefuseAll.CustomizableEdges = borderEdges7;
            this.btnRefuseAll.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRefuseAll.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnRefuseAll.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnRefuseAll.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnRefuseAll.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnRefuseAll.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefuseAll.ForeColor = System.Drawing.Color.White;
            this.btnRefuseAll.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefuseAll.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnRefuseAll.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnRefuseAll.IconMarginLeft = 11;
            this.btnRefuseAll.IconPadding = 10;
            this.btnRefuseAll.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefuseAll.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnRefuseAll.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnRefuseAll.IconSize = 25;
            this.btnRefuseAll.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnRefuseAll.IdleBorderRadius = 1;
            this.btnRefuseAll.IdleBorderThickness = 1;
            this.btnRefuseAll.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnRefuseAll.IdleIconLeftImage = null;
            this.btnRefuseAll.IdleIconRightImage = null;
            this.btnRefuseAll.IndicateFocus = false;
            this.btnRefuseAll.Location = new System.Drawing.Point(650, 13);
            this.btnRefuseAll.Name = "btnRefuseAll";
            this.btnRefuseAll.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnRefuseAll.OnDisabledState.BorderRadius = 1;
            this.btnRefuseAll.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnRefuseAll.OnDisabledState.BorderThickness = 1;
            this.btnRefuseAll.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnRefuseAll.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnRefuseAll.OnDisabledState.IconLeftImage = null;
            this.btnRefuseAll.OnDisabledState.IconRightImage = null;
            this.btnRefuseAll.onHoverState.BorderColor = System.Drawing.Color.White;
            this.btnRefuseAll.onHoverState.BorderRadius = 1;
            this.btnRefuseAll.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnRefuseAll.onHoverState.BorderThickness = 1;
            this.btnRefuseAll.onHoverState.FillColor = System.Drawing.Color.White;
            this.btnRefuseAll.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnRefuseAll.onHoverState.IconLeftImage = null;
            this.btnRefuseAll.onHoverState.IconRightImage = null;
            this.btnRefuseAll.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnRefuseAll.OnIdleState.BorderRadius = 1;
            this.btnRefuseAll.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnRefuseAll.OnIdleState.BorderThickness = 1;
            this.btnRefuseAll.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnRefuseAll.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnRefuseAll.OnIdleState.IconLeftImage = null;
            this.btnRefuseAll.OnIdleState.IconRightImage = null;
            this.btnRefuseAll.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnRefuseAll.OnPressedState.BorderRadius = 1;
            this.btnRefuseAll.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnRefuseAll.OnPressedState.BorderThickness = 1;
            this.btnRefuseAll.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnRefuseAll.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnRefuseAll.OnPressedState.IconLeftImage = null;
            this.btnRefuseAll.OnPressedState.IconRightImage = null;
            this.btnRefuseAll.Size = new System.Drawing.Size(136, 44);
            this.btnRefuseAll.TabIndex = 18;
            this.btnRefuseAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRefuseAll.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRefuseAll.TextMarginLeft = 0;
            this.btnRefuseAll.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnRefuseAll.UseDefaultRadiusAndThickness = true;
            // 
            // btnAcceptAll
            // 
            this.btnAcceptAll.AllowAnimations = true;
            this.btnAcceptAll.AllowMouseEffects = true;
            this.btnAcceptAll.AllowToggling = false;
            this.btnAcceptAll.AnimationSpeed = 200;
            this.btnAcceptAll.AutoGenerateColors = false;
            this.btnAcceptAll.AutoRoundBorders = false;
            this.btnAcceptAll.AutoSizeLeftIcon = true;
            this.btnAcceptAll.AutoSizeRightIcon = true;
            this.btnAcceptAll.BackColor = System.Drawing.Color.Transparent;
            this.btnAcceptAll.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnAcceptAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAcceptAll.BackgroundImage")));
            this.btnAcceptAll.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAcceptAll.ButtonText = "Duyệt toàn bộ";
            this.btnAcceptAll.ButtonTextMarginLeft = 0;
            this.btnAcceptAll.ColorContrastOnClick = 45;
            this.btnAcceptAll.ColorContrastOnHover = 45;
            this.btnAcceptAll.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges8.BottomLeft = true;
            borderEdges8.BottomRight = true;
            borderEdges8.TopLeft = true;
            borderEdges8.TopRight = true;
            this.btnAcceptAll.CustomizableEdges = borderEdges8;
            this.btnAcceptAll.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAcceptAll.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAcceptAll.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAcceptAll.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAcceptAll.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnAcceptAll.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAcceptAll.ForeColor = System.Drawing.Color.White;
            this.btnAcceptAll.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcceptAll.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAcceptAll.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAcceptAll.IconMarginLeft = 11;
            this.btnAcceptAll.IconPadding = 10;
            this.btnAcceptAll.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAcceptAll.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAcceptAll.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAcceptAll.IconSize = 25;
            this.btnAcceptAll.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAcceptAll.IdleBorderRadius = 1;
            this.btnAcceptAll.IdleBorderThickness = 1;
            this.btnAcceptAll.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnAcceptAll.IdleIconLeftImage = null;
            this.btnAcceptAll.IdleIconRightImage = null;
            this.btnAcceptAll.IndicateFocus = false;
            this.btnAcceptAll.Location = new System.Drawing.Point(490, 13);
            this.btnAcceptAll.Name = "btnAcceptAll";
            this.btnAcceptAll.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAcceptAll.OnDisabledState.BorderRadius = 1;
            this.btnAcceptAll.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAcceptAll.OnDisabledState.BorderThickness = 1;
            this.btnAcceptAll.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAcceptAll.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAcceptAll.OnDisabledState.IconLeftImage = null;
            this.btnAcceptAll.OnDisabledState.IconRightImage = null;
            this.btnAcceptAll.onHoverState.BorderColor = System.Drawing.Color.White;
            this.btnAcceptAll.onHoverState.BorderRadius = 1;
            this.btnAcceptAll.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAcceptAll.onHoverState.BorderThickness = 1;
            this.btnAcceptAll.onHoverState.FillColor = System.Drawing.Color.White;
            this.btnAcceptAll.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnAcceptAll.onHoverState.IconLeftImage = null;
            this.btnAcceptAll.onHoverState.IconRightImage = null;
            this.btnAcceptAll.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAcceptAll.OnIdleState.BorderRadius = 1;
            this.btnAcceptAll.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAcceptAll.OnIdleState.BorderThickness = 1;
            this.btnAcceptAll.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnAcceptAll.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAcceptAll.OnIdleState.IconLeftImage = null;
            this.btnAcceptAll.OnIdleState.IconRightImage = null;
            this.btnAcceptAll.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAcceptAll.OnPressedState.BorderRadius = 1;
            this.btnAcceptAll.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAcceptAll.OnPressedState.BorderThickness = 1;
            this.btnAcceptAll.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAcceptAll.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAcceptAll.OnPressedState.IconLeftImage = null;
            this.btnAcceptAll.OnPressedState.IconRightImage = null;
            this.btnAcceptAll.Size = new System.Drawing.Size(136, 44);
            this.btnAcceptAll.TabIndex = 19;
            this.btnAcceptAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAcceptAll.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAcceptAll.TextMarginLeft = 0;
            this.btnAcceptAll.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAcceptAll.UseDefaultRadiusAndThickness = true;
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
            this.name.HeaderText = "Tên nhân viên";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phone.HeaderText = "Chế độ";
            this.phone.MinimumWidth = 6;
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // roles
            // 
            this.roles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.roles.HeaderText = "Vị trí";
            this.roles.MinimumWidth = 6;
            this.roles.Name = "roles";
            this.roles.ReadOnly = true;
            // 
            // position
            // 
            this.position.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.position.HeaderText = "Chức vụ";
            this.position.MinimumWidth = 6;
            this.position.Name = "position";
            this.position.ReadOnly = true;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.status.HeaderText = "Trạng thái";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // btnRead
            // 
            this.btnRead.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.btnRead.HeaderText = "";
            this.btnRead.Image = global::HRMngt.Properties.Resources.read;
            this.btnRead.MinimumWidth = 6;
            this.btnRead.Name = "btnRead";
            this.btnRead.ReadOnly = true;
            this.btnRead.Width = 7;
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.btnEdit.HeaderText = "";
            this.btnEdit.Image = global::HRMngt.Properties.Resources.update;
            this.btnEdit.MinimumWidth = 6;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ReadOnly = true;
            this.btnEdit.Width = 7;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.btnDelete.HeaderText = "";
            this.btnDelete.Image = global::HRMngt.Properties.Resources.delete;
            this.btnDelete.MinimumWidth = 6;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ReadOnly = true;
            this.btnDelete.Width = 7;
            // 
            // RecruitView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1128, 624);
            this.Controls.Add(this.btnAcceptAll);
            this.Controls.Add(this.btnRefuseAll);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.cbDepartment);
            this.Controls.Add(this.dgvHRList);
            this.Name = "RecruitView";
            this.Text = "Tuyển dụng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHRList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbDepartment;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvHRList;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnAdd;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnExcel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnRefuseAll;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnAcceptAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn roles;
        private System.Windows.Forms.DataGridViewTextBoxColumn position;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewImageColumn btnRead;
        private System.Windows.Forms.DataGridViewImageColumn btnEdit;
        private System.Windows.Forms.DataGridViewImageColumn btnDelete;
    }
}