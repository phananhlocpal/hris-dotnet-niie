namespace HRMngt.Views.Dialogs.Forms
{
    partial class RequestDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestDialog));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDetailRequestTable = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.btnApprove = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnNotApprove = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.lblSender = new System.Windows.Forms.Label();
            this.lblReceiver = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailRequestTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sender:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Receiver:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type:";
            // 
            // dgvDetailRequestTable
            // 
            this.dgvDetailRequestTable.AllowUserToAddRows = false;
            this.dgvDetailRequestTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetailRequestTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailRequestTable.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Mixed;
            this.dgvDetailRequestTable.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ContextMenuSeparator;
            this.dgvDetailRequestTable.HideOuterBorders = true;
            this.dgvDetailRequestTable.Location = new System.Drawing.Point(56, 224);
            this.dgvDetailRequestTable.Name = "dgvDetailRequestTable";
            this.dgvDetailRequestTable.ReadOnly = true;
            this.dgvDetailRequestTable.RowHeadersVisible = false;
            this.dgvDetailRequestTable.RowHeadersWidth = 90;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDetailRequestTable.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetailRequestTable.RowTemplate.Height = 50;
            this.dgvDetailRequestTable.RowTemplate.ReadOnly = true;
            this.dgvDetailRequestTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDetailRequestTable.ShowCellErrors = false;
            this.dgvDetailRequestTable.ShowCellToolTips = false;
            this.dgvDetailRequestTable.ShowEditingIcon = false;
            this.dgvDetailRequestTable.ShowRowErrors = false;
            this.dgvDetailRequestTable.Size = new System.Drawing.Size(798, 472);
            this.dgvDetailRequestTable.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ContextMenuSeparator;
            this.dgvDetailRequestTable.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.White;
            this.dgvDetailRequestTable.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgvDetailRequestTable.StateCommon.DataCell.Content.Padding = new System.Windows.Forms.Padding(1);
            this.dgvDetailRequestTable.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvDetailRequestTable.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvDetailRequestTable.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.White;
            this.dgvDetailRequestTable.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgvDetailRequestTable.StateCommon.HeaderColumn.Content.Padding = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.dgvDetailRequestTable.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.White;
            this.dgvDetailRequestTable.StateSelected.DataCell.Back.Color2 = System.Drawing.Color.White;
            this.dgvDetailRequestTable.TabIndex = 21;
            // 
            // btnApprove
            // 
            this.btnApprove.AllowAnimations = true;
            this.btnApprove.AllowMouseEffects = true;
            this.btnApprove.AllowToggling = false;
            this.btnApprove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnApprove.AnimationSpeed = 200;
            this.btnApprove.AutoGenerateColors = false;
            this.btnApprove.AutoRoundBorders = false;
            this.btnApprove.AutoSizeLeftIcon = true;
            this.btnApprove.AutoSizeRightIcon = true;
            this.btnApprove.BackColor = System.Drawing.Color.Transparent;
            this.btnApprove.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnApprove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnApprove.BackgroundImage")));
            this.btnApprove.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnApprove.ButtonText = "Approve";
            this.btnApprove.ButtonTextMarginLeft = 0;
            this.btnApprove.ColorContrastOnClick = 45;
            this.btnApprove.ColorContrastOnHover = 45;
            this.btnApprove.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnApprove.CustomizableEdges = borderEdges1;
            this.btnApprove.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnApprove.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnApprove.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnApprove.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnApprove.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnApprove.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnApprove.ForeColor = System.Drawing.Color.White;
            this.btnApprove.IconLeft = null;
            this.btnApprove.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApprove.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnApprove.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnApprove.IconMarginLeft = 11;
            this.btnApprove.IconPadding = 10;
            this.btnApprove.IconRight = null;
            this.btnApprove.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnApprove.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnApprove.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnApprove.IconSize = 25;
            this.btnApprove.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnApprove.IdleBorderRadius = 0;
            this.btnApprove.IdleBorderThickness = 0;
            this.btnApprove.IdleFillColor = System.Drawing.Color.Empty;
            this.btnApprove.IdleIconLeftImage = null;
            this.btnApprove.IdleIconRightImage = null;
            this.btnApprove.IndicateFocus = false;
            this.btnApprove.Location = new System.Drawing.Point(207, 726);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnApprove.OnDisabledState.BorderRadius = 1;
            this.btnApprove.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnApprove.OnDisabledState.BorderThickness = 1;
            this.btnApprove.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnApprove.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnApprove.OnDisabledState.IconLeftImage = null;
            this.btnApprove.OnDisabledState.IconRightImage = null;
            this.btnApprove.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnApprove.onHoverState.BorderRadius = 1;
            this.btnApprove.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnApprove.onHoverState.BorderThickness = 1;
            this.btnApprove.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnApprove.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnApprove.onHoverState.IconLeftImage = null;
            this.btnApprove.onHoverState.IconRightImage = null;
            this.btnApprove.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnApprove.OnIdleState.BorderRadius = 1;
            this.btnApprove.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnApprove.OnIdleState.BorderThickness = 1;
            this.btnApprove.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnApprove.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnApprove.OnIdleState.IconLeftImage = null;
            this.btnApprove.OnIdleState.IconRightImage = null;
            this.btnApprove.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnApprove.OnPressedState.BorderRadius = 1;
            this.btnApprove.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnApprove.OnPressedState.BorderThickness = 1;
            this.btnApprove.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnApprove.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnApprove.OnPressedState.IconLeftImage = null;
            this.btnApprove.OnPressedState.IconRightImage = null;
            this.btnApprove.Size = new System.Drawing.Size(174, 60);
            this.btnApprove.TabIndex = 22;
            this.btnApprove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnApprove.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnApprove.TextMarginLeft = 0;
            this.btnApprove.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnApprove.UseDefaultRadiusAndThickness = true;
            // 
            // btnNotApprove
            // 
            this.btnNotApprove.AllowAnimations = true;
            this.btnNotApprove.AllowMouseEffects = true;
            this.btnNotApprove.AllowToggling = false;
            this.btnNotApprove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNotApprove.AnimationSpeed = 200;
            this.btnNotApprove.AutoGenerateColors = false;
            this.btnNotApprove.AutoRoundBorders = false;
            this.btnNotApprove.AutoSizeLeftIcon = true;
            this.btnNotApprove.AutoSizeRightIcon = true;
            this.btnNotApprove.BackColor = System.Drawing.Color.Transparent;
            this.btnNotApprove.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnNotApprove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNotApprove.BackgroundImage")));
            this.btnNotApprove.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNotApprove.ButtonText = "Not Approve";
            this.btnNotApprove.ButtonTextMarginLeft = 0;
            this.btnNotApprove.ColorContrastOnClick = 45;
            this.btnNotApprove.ColorContrastOnHover = 45;
            this.btnNotApprove.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnNotApprove.CustomizableEdges = borderEdges2;
            this.btnNotApprove.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNotApprove.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnNotApprove.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnNotApprove.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnNotApprove.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnNotApprove.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNotApprove.ForeColor = System.Drawing.Color.White;
            this.btnNotApprove.IconLeft = null;
            this.btnNotApprove.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotApprove.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnNotApprove.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnNotApprove.IconMarginLeft = 11;
            this.btnNotApprove.IconPadding = 10;
            this.btnNotApprove.IconRight = null;
            this.btnNotApprove.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNotApprove.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnNotApprove.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnNotApprove.IconSize = 25;
            this.btnNotApprove.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnNotApprove.IdleBorderRadius = 0;
            this.btnNotApprove.IdleBorderThickness = 0;
            this.btnNotApprove.IdleFillColor = System.Drawing.Color.Empty;
            this.btnNotApprove.IdleIconLeftImage = null;
            this.btnNotApprove.IdleIconRightImage = null;
            this.btnNotApprove.IndicateFocus = false;
            this.btnNotApprove.Location = new System.Drawing.Point(478, 726);
            this.btnNotApprove.Name = "btnNotApprove";
            this.btnNotApprove.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnNotApprove.OnDisabledState.BorderRadius = 1;
            this.btnNotApprove.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNotApprove.OnDisabledState.BorderThickness = 1;
            this.btnNotApprove.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnNotApprove.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnNotApprove.OnDisabledState.IconLeftImage = null;
            this.btnNotApprove.OnDisabledState.IconRightImage = null;
            this.btnNotApprove.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnNotApprove.onHoverState.BorderRadius = 1;
            this.btnNotApprove.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNotApprove.onHoverState.BorderThickness = 1;
            this.btnNotApprove.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnNotApprove.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnNotApprove.onHoverState.IconLeftImage = null;
            this.btnNotApprove.onHoverState.IconRightImage = null;
            this.btnNotApprove.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnNotApprove.OnIdleState.BorderRadius = 1;
            this.btnNotApprove.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNotApprove.OnIdleState.BorderThickness = 1;
            this.btnNotApprove.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnNotApprove.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnNotApprove.OnIdleState.IconLeftImage = null;
            this.btnNotApprove.OnIdleState.IconRightImage = null;
            this.btnNotApprove.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnNotApprove.OnPressedState.BorderRadius = 1;
            this.btnNotApprove.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNotApprove.OnPressedState.BorderThickness = 1;
            this.btnNotApprove.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnNotApprove.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnNotApprove.OnPressedState.IconLeftImage = null;
            this.btnNotApprove.OnPressedState.IconRightImage = null;
            this.btnNotApprove.Size = new System.Drawing.Size(174, 60);
            this.btnNotApprove.TabIndex = 23;
            this.btnNotApprove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNotApprove.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNotApprove.TextMarginLeft = 0;
            this.btnNotApprove.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnNotApprove.UseDefaultRadiusAndThickness = true;
            // 
            // lblSender
            // 
            this.lblSender.AutoSize = true;
            this.lblSender.Location = new System.Drawing.Point(262, 55);
            this.lblSender.Name = "lblSender";
            this.lblSender.Size = new System.Drawing.Size(70, 25);
            this.lblSender.TabIndex = 24;
            this.lblSender.Text = "label4";
            // 
            // lblReceiver
            // 
            this.lblReceiver.AutoSize = true;
            this.lblReceiver.Location = new System.Drawing.Point(262, 109);
            this.lblReceiver.Name = "lblReceiver";
            this.lblReceiver.Size = new System.Drawing.Size(70, 25);
            this.lblReceiver.TabIndex = 25;
            this.lblReceiver.Text = "label5";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(267, 161);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(70, 25);
            this.lblType.TabIndex = 26;
            this.lblType.Text = "label6";
            // 
            // RequestDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(914, 855);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblReceiver);
            this.Controls.Add(this.lblSender);
            this.Controls.Add(this.btnNotApprove);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.dgvDetailRequestTable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RequestDialog";
            this.Text = "RequestDialog";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailRequestTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvDetailRequestTable;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnApprove;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnNotApprove;
        private System.Windows.Forms.Label lblSender;
        private System.Windows.Forms.Label lblReceiver;
        private System.Windows.Forms.Label lblType;
    }
}