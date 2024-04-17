namespace HRMngt.Views.Dialogs
{
    partial class ResetPassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewPassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtComfirmPassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnSuccess = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnBack = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐẶT LẠI MẬT KHẨU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập lại mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mật khẩu mới";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(221, 111);
            this.txtNewPassword.Multiline = true;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '•';
            this.txtNewPassword.Size = new System.Drawing.Size(341, 33);
            this.txtNewPassword.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtNewPassword.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.txtNewPassword.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.txtNewPassword.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtNewPassword.TabIndex = 2;
            // 
            // txtComfirmPassword
            // 
            this.txtComfirmPassword.Location = new System.Drawing.Point(221, 170);
            this.txtComfirmPassword.Multiline = true;
            this.txtComfirmPassword.Name = "txtComfirmPassword";
            this.txtComfirmPassword.PasswordChar = '•';
            this.txtComfirmPassword.Size = new System.Drawing.Size(341, 33);
            this.txtComfirmPassword.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtComfirmPassword.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.txtComfirmPassword.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.txtComfirmPassword.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtComfirmPassword.TabIndex = 3;
            // 
            // btnSuccess
            // 
            this.btnSuccess.Location = new System.Drawing.Point(458, 250);
            this.btnSuccess.Name = "btnSuccess";
            this.btnSuccess.Size = new System.Drawing.Size(134, 47);
            this.btnSuccess.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnSuccess.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnSuccess.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.btnSuccess.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.btnSuccess.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSuccess.TabIndex = 4;
            this.btnSuccess.Values.Text = "Hoàn tất";
            this.btnSuccess.Click += new System.EventHandler(this.btnSuccess_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(123, 250);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(134, 47);
            this.btnBack.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnBack.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnBack.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.btnBack.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.btnBack.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnBack.TabIndex = 5;
            this.btnBack.Values.Text = "Quay lại";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 350);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSuccess);
            this.Controls.Add(this.txtComfirmPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ResetPassword";
            this.Text = "Đặt lại mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtNewPassword;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtComfirmPassword;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSuccess;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnBack;
    }
}