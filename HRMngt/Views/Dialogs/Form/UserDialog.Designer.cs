namespace HRMngt.Views.Dialogs
{
    partial class UserDialog
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
            this.btnCancle = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cbManagerId = new System.Windows.Forms.ComboBox();
            this.cbDepartmentId = new System.Windows.Forms.ComboBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbContractType = new System.Windows.Forms.ComboBox();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.birthday = new System.Windows.Forms.DateTimePicker();
            this.dtOnBoarding = new System.Windows.Forms.DateTimePicker();
            this.dtClosedate = new System.Windows.Forms.DateTimePicker();
            this.txtScanContract = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.btnPicture = new System.Windows.Forms.Button();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.cbRoles = new System.Windows.Forms.ComboBox();
            this.txtAvatar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(972, 659);
            this.btnCancle.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(90, 43);
            this.btnCancle.TabIndex = 73;
            this.btnCancle.Text = "Hủy";
            this.btnCancle.UseVisualStyleBackColor = true;
            // 
            // txtAddress
            // 
            this.txtAddress.ForeColor = System.Drawing.Color.Gray;
            this.txtAddress.Location = new System.Drawing.Point(208, 382);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(343, 26);
            this.txtAddress.TabIndex = 72;
            this.txtAddress.Click += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.ForeColor = System.Drawing.Color.Gray;
            this.txtEmail.Location = new System.Drawing.Point(208, 305);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(343, 26);
            this.txtEmail.TabIndex = 71;
            this.txtEmail.Click += new System.EventHandler(this.EmailUser);
            // 
            // txtName
            // 
            this.txtName.ForeColor = System.Drawing.Color.Gray;
            this.txtName.Location = new System.Drawing.Point(208, 264);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(343, 26);
            this.txtName.TabIndex = 70;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(122, 659);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 43);
            this.btnAdd.TabIndex = 69;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 382);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 67;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 345);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 66;
            this.label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 305);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 65;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 267);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 64;
            this.label2.Text = "Tên nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 231);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 63;
            this.label1.Text = "ID";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(485, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(207, 25);
            this.lblTitle.TabIndex = 62;
            this.lblTitle.Text = "Thêm mới nhân viên";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUsername
            // 
            this.txtUsername.ForeColor = System.Drawing.Color.Gray;
            this.txtUsername.Location = new System.Drawing.Point(208, 503);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(343, 26);
            this.txtUsername.TabIndex = 82;
            this.txtUsername.Click += new System.EventHandler(this.UserName);
            // 
            // txtSalary
            // 
            this.txtSalary.ForeColor = System.Drawing.Color.Gray;
            this.txtSalary.Location = new System.Drawing.Point(208, 462);
            this.txtSalary.Multiline = true;
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(343, 26);
            this.txtSalary.TabIndex = 81;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(132, 580);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 79;
            this.label6.Text = "Quản lý";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(126, 543);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 78;
            this.label7.Text = "Mật khẩu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(96, 503);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 16);
            this.label8.TabIndex = 77;
            this.label8.Text = "Tên đăng nhập";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(119, 465);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 16);
            this.label9.TabIndex = 76;
            this.label9.Text = "Mức lương";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(120, 429);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 16);
            this.label10.TabIndex = 75;
            this.label10.Text = "Ngày sinh";
            // 
            // cbPosition
            // 
            this.cbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPosition.ForeColor = System.Drawing.Color.Gray;
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Items.AddRange(new object[] {
            "Nghiên cứu dữ liệu",
            "Nhân viên Marketing",
            "Phát triển phần mềm",
            "Quản trị hệ thống",
            "Chuyên viên tài chính"});
            this.cbPosition.Location = new System.Drawing.Point(719, 384);
            this.cbPosition.Margin = new System.Windows.Forms.Padding(2);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(343, 24);
            this.cbPosition.TabIndex = 100;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(616, 580);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 16);
            this.label11.TabIndex = 99;
            this.label11.Text = "Loại hợp đồng";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(674, 381);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 16);
            this.label12.TabIndex = 98;
            this.label12.Text = "Vị trí";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(647, 506);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 16);
            this.label13.TabIndex = 97;
            this.label13.Text = "Trạng thái";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(650, 465);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 16);
            this.label14.TabIndex = 96;
            this.label14.Text = "Giới tính";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(674, 426);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 16);
            this.label15.TabIndex = 95;
            this.label15.Text = "Ảnh";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(653, 542);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 16);
            this.label16.TabIndex = 89;
            this.label16.Text = "Chức vụ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(630, 348);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 16);
            this.label17.TabIndex = 88;
            this.label17.Text = "Điều khoản";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(616, 308);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(88, 16);
            this.label18.TabIndex = 87;
            this.label18.Text = "Ngày kết thúc";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(616, 270);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(88, 16);
            this.label19.TabIndex = 86;
            this.label19.Text = "Ngày bắt đầu";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(630, 231);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(72, 16);
            this.label20.TabIndex = 85;
            this.label20.Text = "Phòng ban";
            // 
            // txtPhone
            // 
            this.txtPhone.ForeColor = System.Drawing.Color.Gray;
            this.txtPhone.Location = new System.Drawing.Point(208, 342);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(343, 26);
            this.txtPhone.TabIndex = 105;
            // 
            // txtPassword
            // 
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.Location = new System.Drawing.Point(208, 540);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(343, 26);
            this.txtPassword.TabIndex = 106;
            // 
            // cbManagerId
            // 
            this.cbManagerId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbManagerId.ForeColor = System.Drawing.Color.DarkGray;
            this.cbManagerId.FormattingEnabled = true;
            this.cbManagerId.Location = new System.Drawing.Point(208, 583);
            this.cbManagerId.Margin = new System.Windows.Forms.Padding(2);
            this.cbManagerId.Name = "cbManagerId";
            this.cbManagerId.Size = new System.Drawing.Size(343, 24);
            this.cbManagerId.TabIndex = 107;
            // 
            // cbDepartmentId
            // 
            this.cbDepartmentId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartmentId.ForeColor = System.Drawing.Color.DarkGray;
            this.cbDepartmentId.FormattingEnabled = true;
            this.cbDepartmentId.Location = new System.Drawing.Point(719, 228);
            this.cbDepartmentId.Margin = new System.Windows.Forms.Padding(2);
            this.cbDepartmentId.Name = "cbDepartmentId";
            this.cbDepartmentId.Size = new System.Drawing.Size(343, 24);
            this.cbDepartmentId.TabIndex = 108;
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.ForeColor = System.Drawing.Color.Gray;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Thử việc",
            "Đang làm"});
            this.cbStatus.Location = new System.Drawing.Point(719, 506);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(343, 24);
            this.cbStatus.TabIndex = 109;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // cbContractType
            // 
            this.cbContractType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContractType.ForeColor = System.Drawing.Color.Gray;
            this.cbContractType.FormattingEnabled = true;
            this.cbContractType.Items.AddRange(new object[] {
            "Toàn thời gian",
            "Thời vụ"});
            this.cbContractType.Location = new System.Drawing.Point(719, 580);
            this.cbContractType.Margin = new System.Windows.Forms.Padding(2);
            this.cbContractType.Name = "cbContractType";
            this.cbContractType.Size = new System.Drawing.Size(343, 24);
            this.cbContractType.TabIndex = 110;
            // 
            // cbSex
            // 
            this.cbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSex.ForeColor = System.Drawing.Color.Gray;
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbSex.Location = new System.Drawing.Point(719, 465);
            this.cbSex.Margin = new System.Windows.Forms.Padding(2);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(343, 24);
            this.cbSex.TabIndex = 111;
            // 
            // birthday
            // 
            this.birthday.CalendarForeColor = System.Drawing.Color.Gray;
            this.birthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthday.Location = new System.Drawing.Point(208, 427);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(343, 22);
            this.birthday.TabIndex = 112;
            // 
            // dtOnBoarding
            // 
            this.dtOnBoarding.CalendarForeColor = System.Drawing.Color.Gray;
            this.dtOnBoarding.CalendarMonthBackground = System.Drawing.Color.Gray;
            this.dtOnBoarding.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtOnBoarding.Location = new System.Drawing.Point(719, 270);
            this.dtOnBoarding.Name = "dtOnBoarding";
            this.dtOnBoarding.Size = new System.Drawing.Size(343, 22);
            this.dtOnBoarding.TabIndex = 113;
            // 
            // dtClosedate
            // 
            this.dtClosedate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtClosedate.Location = new System.Drawing.Point(719, 303);
            this.dtClosedate.Name = "dtClosedate";
            this.dtClosedate.Size = new System.Drawing.Size(343, 22);
            this.dtClosedate.TabIndex = 114;
            // 
            // txtScanContract
            // 
            this.txtScanContract.ForeColor = System.Drawing.Color.Gray;
            this.txtScanContract.Location = new System.Drawing.Point(719, 342);
            this.txtScanContract.Multiline = true;
            this.txtScanContract.Name = "txtScanContract";
            this.txtScanContract.Size = new System.Drawing.Size(343, 26);
            this.txtScanContract.TabIndex = 115;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.ForeColor = System.Drawing.Color.Gray;
            this.lbID.Location = new System.Drawing.Point(205, 231);
            this.lbID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(52, 16);
            this.lbID.TabIndex = 116;
            this.lbID.Text = "Content";
            // 
            // btnPicture
            // 
            this.btnPicture.Location = new System.Drawing.Point(543, 193);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.Size = new System.Drawing.Size(104, 24);
            this.btnPicture.TabIndex = 118;
            this.btnPicture.Text = "Thêm ảnh";
            this.btnPicture.UseVisualStyleBackColor = true;
            this.btnPicture.Click += new System.EventHandler(this.btnPicture_Click);
            // 
            // pbAvatar
            // 
            this.pbAvatar.BackColor = System.Drawing.Color.White;
            this.pbAvatar.Image = global::HRMngt.Properties.Resources.no_image;
            this.pbAvatar.Location = new System.Drawing.Point(501, 37);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(178, 150);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAvatar.TabIndex = 117;
            this.pbAvatar.TabStop = false;
            // 
            // cbRoles
            // 
            this.cbRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoles.ForeColor = System.Drawing.Color.Gray;
            this.cbRoles.FormattingEnabled = true;
            this.cbRoles.Items.AddRange(new object[] {
            "Thực tập sinh",
            "Admin",
            "Nhân viên",
            "Quản lý"});
            this.cbRoles.Location = new System.Drawing.Point(719, 542);
            this.cbRoles.Margin = new System.Windows.Forms.Padding(2);
            this.cbRoles.Name = "cbRoles";
            this.cbRoles.Size = new System.Drawing.Size(343, 24);
            this.cbRoles.TabIndex = 119;
            // 
            // txtAvatar
            // 
            this.txtAvatar.ForeColor = System.Drawing.Color.Gray;
            this.txtAvatar.Location = new System.Drawing.Point(719, 423);
            this.txtAvatar.Multiline = true;
            this.txtAvatar.Name = "txtAvatar";
            this.txtAvatar.Size = new System.Drawing.Size(343, 26);
            this.txtAvatar.TabIndex = 104;
            // 
            // UserDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1169, 734);
            this.Controls.Add(this.cbRoles);
            this.Controls.Add(this.btnPicture);
            this.Controls.Add(this.pbAvatar);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.txtScanContract);
            this.Controls.Add(this.dtClosedate);
            this.Controls.Add(this.dtOnBoarding);
            this.Controls.Add(this.birthday);
            this.Controls.Add(this.cbSex);
            this.Controls.Add(this.cbContractType);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.cbDepartmentId);
            this.Controls.Add(this.cbManagerId);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAvatar);
            this.Controls.Add(this.cbPosition);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Name = "UserDialog";
            this.Text = "Thêm/Sửa nhân viên";
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cbManagerId;
        private System.Windows.Forms.ComboBox cbDepartmentId;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbContractType;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.DateTimePicker birthday;
        private System.Windows.Forms.DateTimePicker dtOnBoarding;
        private System.Windows.Forms.DateTimePicker dtClosedate;
        private System.Windows.Forms.TextBox txtScanContract;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.Button btnPicture;
        private System.Windows.Forms.ComboBox cbRoles;
        private System.Windows.Forms.TextBox txtAvatar;
    }
}