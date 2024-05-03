namespace HRMngt.Views
{
    partial class SalaryView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalaryView));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.dgvSalaryTable = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.saveExcel = new System.Windows.Forms.SaveFileDialog();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnExportExcel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpChooseMonth = new System.Windows.Forms.DateTimePicker();
            this.btnApproveAll = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.btnExportSalary = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaryTable)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.ForeColor = System.Drawing.Color.Black;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "All",
            "Created",
            "Approved",
            "Confirmed",
            "Complained",
            "Not Approved"});
            this.cmbStatus.Location = new System.Drawing.Point(254, 60);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(211, 33);
            this.cmbStatus.TabIndex = 7;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.ForeColor = System.Drawing.Color.Black;
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(22, 60);
            this.cmbDepartment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(206, 33);
            this.cmbDepartment.TabIndex = 6;
            // 
            // dgvSalaryTable
            // 
            this.dgvSalaryTable.AllowUserToAddRows = false;
            this.dgvSalaryTable.AllowUserToDeleteRows = false;
            this.dgvSalaryTable.AllowUserToResizeColumns = false;
            this.dgvSalaryTable.AllowUserToResizeRows = false;
            this.dgvSalaryTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSalaryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalaryTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.name,
            this.type,
            this.position,
            this.status,
            this.btnEdit,
            this.btnDelete});
            this.dgvSalaryTable.Location = new System.Drawing.Point(18, 120);
            this.dgvSalaryTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvSalaryTable.Name = "dgvSalaryTable";
            this.dgvSalaryTable.RowHeadersVisible = false;
            this.dgvSalaryTable.RowHeadersWidth = 51;
            this.dgvSalaryTable.RowTemplate.Height = 60;
            this.dgvSalaryTable.Size = new System.Drawing.Size(1640, 836);
            this.dgvSalaryTable.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgvSalaryTable.StateCommon.Background.Color2 = System.Drawing.Color.White;
            this.dgvSalaryTable.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvSalaryTable.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.White;
            this.dgvSalaryTable.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.White;
            this.dgvSalaryTable.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.White;
            this.dgvSalaryTable.StateCommon.DataCell.Border.Color2 = System.Drawing.Color.White;
            this.dgvSalaryTable.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgvSalaryTable.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.Black;
            this.dgvSalaryTable.StateCommon.DataCell.Content.Color2 = System.Drawing.Color.Black;
            this.dgvSalaryTable.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvSalaryTable.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvSalaryTable.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvSalaryTable.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvSalaryTable.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgvSalaryTable.StateCommon.HeaderColumn.Content.Padding = new System.Windows.Forms.Padding(10);
            this.dgvSalaryTable.TabIndex = 4;
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
            // type
            // 
            this.type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.type.HeaderText = "Chế độ";
            this.type.MinimumWidth = 6;
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // position
            // 
            this.position.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.position.HeaderText = "Vị trí";
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
            // btnExportExcel
            // 
            this.btnExportExcel.AllowAnimations = true;
            this.btnExportExcel.AllowMouseEffects = true;
            this.btnExportExcel.AllowToggling = false;
            this.btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportExcel.AnimationSpeed = 200;
            this.btnExportExcel.AutoGenerateColors = false;
            this.btnExportExcel.AutoRoundBorders = false;
            this.btnExportExcel.AutoSizeLeftIcon = true;
            this.btnExportExcel.AutoSizeRightIcon = true;
            this.btnExportExcel.BackColor = System.Drawing.Color.Transparent;
            this.btnExportExcel.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnExportExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExportExcel.BackgroundImage")));
            this.btnExportExcel.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnExportExcel.ButtonText = "Xuất Excel";
            this.btnExportExcel.ButtonTextMarginLeft = 0;
            this.btnExportExcel.ColorContrastOnClick = 45;
            this.btnExportExcel.ColorContrastOnHover = 45;
            this.btnExportExcel.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnExportExcel.CustomizableEdges = borderEdges1;
            this.btnExportExcel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExportExcel.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnExportExcel.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnExportExcel.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnExportExcel.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnExportExcel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExportExcel.ForeColor = System.Drawing.Color.White;
            this.btnExportExcel.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportExcel.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnExportExcel.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnExportExcel.IconMarginLeft = 11;
            this.btnExportExcel.IconPadding = 10;
            this.btnExportExcel.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportExcel.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnExportExcel.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnExportExcel.IconSize = 25;
            this.btnExportExcel.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnExportExcel.IdleBorderRadius = 1;
            this.btnExportExcel.IdleBorderThickness = 1;
            this.btnExportExcel.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnExportExcel.IdleIconLeftImage = null;
            this.btnExportExcel.IdleIconRightImage = null;
            this.btnExportExcel.IndicateFocus = false;
            this.btnExportExcel.Location = new System.Drawing.Point(1518, 24);
            this.btnExportExcel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnExportExcel.OnDisabledState.BorderRadius = 1;
            this.btnExportExcel.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnExportExcel.OnDisabledState.BorderThickness = 1;
            this.btnExportExcel.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnExportExcel.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnExportExcel.OnDisabledState.IconLeftImage = null;
            this.btnExportExcel.OnDisabledState.IconRightImage = null;
            this.btnExportExcel.onHoverState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnExportExcel.onHoverState.BorderRadius = 1;
            this.btnExportExcel.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnExportExcel.onHoverState.BorderThickness = 1;
            this.btnExportExcel.onHoverState.FillColor = System.Drawing.Color.White;
            this.btnExportExcel.onHoverState.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnExportExcel.onHoverState.IconLeftImage = null;
            this.btnExportExcel.onHoverState.IconRightImage = null;
            this.btnExportExcel.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnExportExcel.OnIdleState.BorderRadius = 1;
            this.btnExportExcel.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnExportExcel.OnIdleState.BorderThickness = 1;
            this.btnExportExcel.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnExportExcel.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnExportExcel.OnIdleState.IconLeftImage = null;
            this.btnExportExcel.OnIdleState.IconRightImage = null;
            this.btnExportExcel.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnExportExcel.OnPressedState.BorderRadius = 1;
            this.btnExportExcel.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnExportExcel.OnPressedState.BorderThickness = 1;
            this.btnExportExcel.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnExportExcel.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnExportExcel.OnPressedState.IconLeftImage = null;
            this.btnExportExcel.OnPressedState.IconRightImage = null;
            this.btnExportExcel.Size = new System.Drawing.Size(140, 59);
            this.btnExportExcel.TabIndex = 18;
            this.btnExportExcel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExportExcel.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExportExcel.TextMarginLeft = 0;
            this.btnExportExcel.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnExportExcel.UseDefaultRadiusAndThickness = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(781, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Chọn tháng:";
            // 
            // dtpChooseMonth
            // 
            this.dtpChooseMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpChooseMonth.CustomFormat = "MM - yyyy";
            this.dtpChooseMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpChooseMonth.Location = new System.Drawing.Point(927, 30);
            this.dtpChooseMonth.MinimumSize = new System.Drawing.Size(4, 50);
            this.dtpChooseMonth.Name = "dtpChooseMonth";
            this.dtpChooseMonth.Size = new System.Drawing.Size(200, 50);
            this.dtpChooseMonth.TabIndex = 20;
            // 
            // btnApproveAll
            // 
            this.btnApproveAll.AllowAnimations = true;
            this.btnApproveAll.AllowMouseEffects = true;
            this.btnApproveAll.AllowToggling = false;
            this.btnApproveAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApproveAll.AnimationSpeed = 200;
            this.btnApproveAll.AutoGenerateColors = false;
            this.btnApproveAll.AutoRoundBorders = false;
            this.btnApproveAll.AutoSizeLeftIcon = true;
            this.btnApproveAll.AutoSizeRightIcon = true;
            this.btnApproveAll.BackColor = System.Drawing.Color.Transparent;
            this.btnApproveAll.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnApproveAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnApproveAll.BackgroundImage")));
            this.btnApproveAll.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnApproveAll.ButtonText = "Duyệt toàn bộ";
            this.btnApproveAll.ButtonTextMarginLeft = 0;
            this.btnApproveAll.ColorContrastOnClick = 45;
            this.btnApproveAll.ColorContrastOnHover = 45;
            this.btnApproveAll.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnApproveAll.CustomizableEdges = borderEdges2;
            this.btnApproveAll.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnApproveAll.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnApproveAll.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnApproveAll.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnApproveAll.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnApproveAll.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnApproveAll.ForeColor = System.Drawing.Color.White;
            this.btnApproveAll.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApproveAll.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnApproveAll.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnApproveAll.IconMarginLeft = 11;
            this.btnApproveAll.IconPadding = 10;
            this.btnApproveAll.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnApproveAll.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnApproveAll.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnApproveAll.IconSize = 25;
            this.btnApproveAll.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnApproveAll.IdleBorderRadius = 1;
            this.btnApproveAll.IdleBorderThickness = 1;
            this.btnApproveAll.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnApproveAll.IdleIconLeftImage = null;
            this.btnApproveAll.IdleIconRightImage = null;
            this.btnApproveAll.IndicateFocus = false;
            this.btnApproveAll.Location = new System.Drawing.Point(1306, 23);
            this.btnApproveAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnApproveAll.Name = "btnApproveAll";
            this.btnApproveAll.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnApproveAll.OnDisabledState.BorderRadius = 1;
            this.btnApproveAll.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnApproveAll.OnDisabledState.BorderThickness = 1;
            this.btnApproveAll.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnApproveAll.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnApproveAll.OnDisabledState.IconLeftImage = null;
            this.btnApproveAll.OnDisabledState.IconRightImage = null;
            this.btnApproveAll.onHoverState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnApproveAll.onHoverState.BorderRadius = 1;
            this.btnApproveAll.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnApproveAll.onHoverState.BorderThickness = 1;
            this.btnApproveAll.onHoverState.FillColor = System.Drawing.Color.White;
            this.btnApproveAll.onHoverState.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnApproveAll.onHoverState.IconLeftImage = null;
            this.btnApproveAll.onHoverState.IconRightImage = null;
            this.btnApproveAll.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnApproveAll.OnIdleState.BorderRadius = 1;
            this.btnApproveAll.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnApproveAll.OnIdleState.BorderThickness = 1;
            this.btnApproveAll.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnApproveAll.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnApproveAll.OnIdleState.IconLeftImage = null;
            this.btnApproveAll.OnIdleState.IconRightImage = null;
            this.btnApproveAll.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnApproveAll.OnPressedState.BorderRadius = 1;
            this.btnApproveAll.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnApproveAll.OnPressedState.BorderThickness = 1;
            this.btnApproveAll.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnApproveAll.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnApproveAll.OnPressedState.IconLeftImage = null;
            this.btnApproveAll.OnPressedState.IconRightImage = null;
            this.btnApproveAll.Size = new System.Drawing.Size(195, 60);
            this.btnApproveAll.TabIndex = 17;
            this.btnApproveAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnApproveAll.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnApproveAll.TextMarginLeft = 0;
            this.btnApproveAll.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnApproveAll.UseDefaultRadiusAndThickness = true;
            // 
            // btnExportSalary
            // 
            this.btnExportSalary.AllowAnimations = true;
            this.btnExportSalary.AllowMouseEffects = true;
            this.btnExportSalary.AllowToggling = false;
            this.btnExportSalary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportSalary.AnimationSpeed = 200;
            this.btnExportSalary.AutoGenerateColors = false;
            this.btnExportSalary.AutoRoundBorders = false;
            this.btnExportSalary.AutoSizeLeftIcon = true;
            this.btnExportSalary.AutoSizeRightIcon = true;
            this.btnExportSalary.BackColor = System.Drawing.Color.Transparent;
            this.btnExportSalary.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnExportSalary.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExportSalary.BackgroundImage")));
            this.btnExportSalary.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnExportSalary.ButtonText = "Xuất lương";
            this.btnExportSalary.ButtonTextMarginLeft = 0;
            this.btnExportSalary.ColorContrastOnClick = 45;
            this.btnExportSalary.ColorContrastOnHover = 45;
            this.btnExportSalary.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnExportSalary.CustomizableEdges = borderEdges3;
            this.btnExportSalary.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExportSalary.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnExportSalary.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnExportSalary.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnExportSalary.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnExportSalary.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExportSalary.ForeColor = System.Drawing.Color.White;
            this.btnExportSalary.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportSalary.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnExportSalary.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnExportSalary.IconMarginLeft = 11;
            this.btnExportSalary.IconPadding = 10;
            this.btnExportSalary.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportSalary.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnExportSalary.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnExportSalary.IconSize = 25;
            this.btnExportSalary.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnExportSalary.IdleBorderRadius = 1;
            this.btnExportSalary.IdleBorderThickness = 1;
            this.btnExportSalary.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnExportSalary.IdleIconLeftImage = null;
            this.btnExportSalary.IdleIconRightImage = null;
            this.btnExportSalary.IndicateFocus = false;
            this.btnExportSalary.Location = new System.Drawing.Point(1149, 24);
            this.btnExportSalary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExportSalary.Name = "btnExportSalary";
            this.btnExportSalary.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnExportSalary.OnDisabledState.BorderRadius = 1;
            this.btnExportSalary.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnExportSalary.OnDisabledState.BorderThickness = 1;
            this.btnExportSalary.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnExportSalary.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnExportSalary.OnDisabledState.IconLeftImage = null;
            this.btnExportSalary.OnDisabledState.IconRightImage = null;
            this.btnExportSalary.onHoverState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnExportSalary.onHoverState.BorderRadius = 1;
            this.btnExportSalary.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnExportSalary.onHoverState.BorderThickness = 1;
            this.btnExportSalary.onHoverState.FillColor = System.Drawing.Color.White;
            this.btnExportSalary.onHoverState.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnExportSalary.onHoverState.IconLeftImage = null;
            this.btnExportSalary.onHoverState.IconRightImage = null;
            this.btnExportSalary.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnExportSalary.OnIdleState.BorderRadius = 1;
            this.btnExportSalary.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnExportSalary.OnIdleState.BorderThickness = 1;
            this.btnExportSalary.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnExportSalary.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnExportSalary.OnIdleState.IconLeftImage = null;
            this.btnExportSalary.OnIdleState.IconRightImage = null;
            this.btnExportSalary.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnExportSalary.OnPressedState.BorderRadius = 1;
            this.btnExportSalary.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnExportSalary.OnPressedState.BorderThickness = 1;
            this.btnExportSalary.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnExportSalary.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnExportSalary.OnPressedState.IconLeftImage = null;
            this.btnExportSalary.OnPressedState.IconRightImage = null;
            this.btnExportSalary.Size = new System.Drawing.Size(137, 60);
            this.btnExportSalary.TabIndex = 23;
            this.btnExportSalary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExportSalary.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExportSalary.TextMarginLeft = 0;
            this.btnExportSalary.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnExportSalary.UseDefaultRadiusAndThickness = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(23, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Phòng ban";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(249, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Trạng thái";
            // 
            // SalaryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1676, 975);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExportSalary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpChooseMonth);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.btnApproveAll);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.dgvSalaryTable);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SalaryView";
            this.Text = "Quản lí nhân viên";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaryTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvSalaryTable;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.SaveFileDialog saveExcel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnExportExcel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpChooseMonth;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnApproveAll;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnExportSalary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn position;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewImageColumn btnEdit;
        private System.Windows.Forms.DataGridViewImageColumn btnDelete;
    }
}