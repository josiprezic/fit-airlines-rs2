namespace FitAirlines.UI
{
    partial class AddOrEditUserForm
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
            this.components = new System.ComponentModel.Container();
            this.profilePictureGroupBox = new System.Windows.Forms.GroupBox();
            this.profilePictureBox = new FitAirlines.UI.BasePictureBox();
            this.changeProfileImageButton = new FitAirlines.UI.BaseButton();
            this.personalDataGroupBox = new System.Windows.Forms.GroupBox();
            this.ContactNumberTextBox = new System.Windows.Forms.MaskedTextBox();
            this.userRoleComboBox = new FitAirlines.UI.BaseComboBox();
            this.userRoleLabel = new System.Windows.Forms.Label();
            this.contactNumberLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.accountBalanceValueLabel = new System.Windows.Forms.Label();
            this.isActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.fitMembershipComboBox = new FitAirlines.UI.BaseComboBox();
            this.genderComboBox = new FitAirlines.UI.BaseComboBox();
            this.birthDateTimePicker = new FitAirlines.UI.BaseDateTimePicker(this.components);
            this.accountBalanceTextLabel = new System.Windows.Forms.Label();
            this.fitMembershipLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.birthDateLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.actionsGroupBox = new System.Windows.Forms.GroupBox();
            this.saveButton = new FitAirlines.UI.BaseButton();
            this.cancelButton = new FitAirlines.UI.BaseButton();
            this.addCreditButton = new FitAirlines.UI.BaseButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.profilePictureGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.personalDataGroupBox.SuspendLayout();
            this.actionsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // profilePictureGroupBox
            // 
            this.profilePictureGroupBox.Controls.Add(this.profilePictureBox);
            this.profilePictureGroupBox.Controls.Add(this.changeProfileImageButton);
            this.profilePictureGroupBox.Location = new System.Drawing.Point(12, 12);
            this.profilePictureGroupBox.Name = "profilePictureGroupBox";
            this.profilePictureGroupBox.Size = new System.Drawing.Size(149, 186);
            this.profilePictureGroupBox.TabIndex = 16;
            this.profilePictureGroupBox.TabStop = false;
            this.profilePictureGroupBox.Text = "groupBox1";
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.BackColor = System.Drawing.Color.Gray;
            this.profilePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profilePictureBox.Location = new System.Drawing.Point(6, 19);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(137, 135);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilePictureBox.TabIndex = 19;
            this.profilePictureBox.TabStop = false;
            // 
            // changeProfileImageButton
            // 
            this.changeProfileImageButton.Location = new System.Drawing.Point(6, 160);
            this.changeProfileImageButton.Name = "changeProfileImageButton";
            this.changeProfileImageButton.Size = new System.Drawing.Size(137, 23);
            this.changeProfileImageButton.TabIndex = 0;
            this.changeProfileImageButton.Text = "changeProfileImageButton";
            this.changeProfileImageButton.UseVisualStyleBackColor = true;
            this.changeProfileImageButton.Click += new System.EventHandler(this.changeProfileImageButton_Click);
            // 
            // personalDataGroupBox
            // 
            this.personalDataGroupBox.Controls.Add(this.ContactNumberTextBox);
            this.personalDataGroupBox.Controls.Add(this.userRoleComboBox);
            this.personalDataGroupBox.Controls.Add(this.userRoleLabel);
            this.personalDataGroupBox.Controls.Add(this.contactNumberLabel);
            this.personalDataGroupBox.Controls.Add(this.emailTextBox);
            this.personalDataGroupBox.Controls.Add(this.emailLabel);
            this.personalDataGroupBox.Controls.Add(this.accountBalanceValueLabel);
            this.personalDataGroupBox.Controls.Add(this.isActiveCheckBox);
            this.personalDataGroupBox.Controls.Add(this.fitMembershipComboBox);
            this.personalDataGroupBox.Controls.Add(this.genderComboBox);
            this.personalDataGroupBox.Controls.Add(this.birthDateTimePicker);
            this.personalDataGroupBox.Controls.Add(this.accountBalanceTextLabel);
            this.personalDataGroupBox.Controls.Add(this.fitMembershipLabel);
            this.personalDataGroupBox.Controls.Add(this.genderLabel);
            this.personalDataGroupBox.Controls.Add(this.birthDateLabel);
            this.personalDataGroupBox.Controls.Add(this.lastNameTextBox);
            this.personalDataGroupBox.Controls.Add(this.lastNameLabel);
            this.personalDataGroupBox.Controls.Add(this.firstNameTextBox);
            this.personalDataGroupBox.Controls.Add(this.firstNameLabel);
            this.personalDataGroupBox.Location = new System.Drawing.Point(167, 12);
            this.personalDataGroupBox.Name = "personalDataGroupBox";
            this.personalDataGroupBox.Size = new System.Drawing.Size(304, 271);
            this.personalDataGroupBox.TabIndex = 20;
            this.personalDataGroupBox.TabStop = false;
            this.personalDataGroupBox.Text = "groupBox2";
            // 
            // ContactNumberTextBox
            // 
            this.ContactNumberTextBox.Location = new System.Drawing.Point(84, 182);
            this.ContactNumberTextBox.Mask = "999-000-000";
            this.ContactNumberTextBox.Name = "ContactNumberTextBox";
            this.ContactNumberTextBox.Size = new System.Drawing.Size(190, 20);
            this.ContactNumberTextBox.TabIndex = 6;
            this.ContactNumberTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.ContactNumberTextBox_Validating_1);
            // 
            // userRoleComboBox
            // 
            this.userRoleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userRoleComboBox.FormattingEnabled = true;
            this.userRoleComboBox.Location = new System.Drawing.Point(84, 209);
            this.userRoleComboBox.Name = "userRoleComboBox";
            this.userRoleComboBox.Size = new System.Drawing.Size(190, 21);
            this.userRoleComboBox.TabIndex = 7;
            // 
            // userRoleLabel
            // 
            this.userRoleLabel.AutoSize = true;
            this.userRoleLabel.Location = new System.Drawing.Point(12, 212);
            this.userRoleLabel.Name = "userRoleLabel";
            this.userRoleLabel.Size = new System.Drawing.Size(75, 13);
            this.userRoleLabel.TabIndex = 101;
            this.userRoleLabel.Text = "userRoleLabel";
            // 
            // contactNumberLabel
            // 
            this.contactNumberLabel.AutoSize = true;
            this.contactNumberLabel.Location = new System.Drawing.Point(12, 185);
            this.contactNumberLabel.Name = "contactNumberLabel";
            this.contactNumberLabel.Size = new System.Drawing.Size(106, 13);
            this.contactNumberLabel.TabIndex = 28;
            this.contactNumberLabel.Text = "contactNumberLabel";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(84, 75);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(190, 20);
            this.emailTextBox.TabIndex = 2;
            this.emailTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.emailTextBox_Validating);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(12, 78);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(57, 13);
            this.emailLabel.TabIndex = 26;
            this.emailLabel.Text = "emailLabel";
            // 
            // accountBalanceValueLabel
            // 
            this.accountBalanceValueLabel.AutoSize = true;
            this.accountBalanceValueLabel.Location = new System.Drawing.Point(81, 240);
            this.accountBalanceValueLabel.Name = "accountBalanceValueLabel";
            this.accountBalanceValueLabel.Size = new System.Drawing.Size(55, 13);
            this.accountBalanceValueLabel.TabIndex = 25;
            this.accountBalanceValueLabel.Text = "accBalVal";
            // 
            // isActiveCheckBox
            // 
            this.isActiveCheckBox.AutoSize = true;
            this.isActiveCheckBox.Location = new System.Drawing.Point(194, 239);
            this.isActiveCheckBox.Name = "isActiveCheckBox";
            this.isActiveCheckBox.Size = new System.Drawing.Size(63, 17);
            this.isActiveCheckBox.TabIndex = 8;
            this.isActiveCheckBox.Text = "isActive";
            this.isActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // fitMembershipComboBox
            // 
            this.fitMembershipComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fitMembershipComboBox.FormattingEnabled = true;
            this.fitMembershipComboBox.Location = new System.Drawing.Point(84, 155);
            this.fitMembershipComboBox.Name = "fitMembershipComboBox";
            this.fitMembershipComboBox.Size = new System.Drawing.Size(190, 21);
            this.fitMembershipComboBox.TabIndex = 5;
            // 
            // genderComboBox
            // 
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "M",
            "Z"});
            this.genderComboBox.Location = new System.Drawing.Point(84, 128);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(190, 21);
            this.genderComboBox.TabIndex = 4;
            this.genderComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.genderComboBox_Validating);
            // 
            // birthDateTimePicker
            // 
            this.birthDateTimePicker.Location = new System.Drawing.Point(84, 103);
            this.birthDateTimePicker.Name = "birthDateTimePicker";
            this.birthDateTimePicker.Size = new System.Drawing.Size(190, 20);
            this.birthDateTimePicker.TabIndex = 3;
            this.birthDateTimePicker.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.birthDateTimePicker.Validating += new System.ComponentModel.CancelEventHandler(this.birthDateTimePicker_Validating);
            // 
            // accountBalanceTextLabel
            // 
            this.accountBalanceTextLabel.AutoSize = true;
            this.accountBalanceTextLabel.Location = new System.Drawing.Point(12, 240);
            this.accountBalanceTextLabel.Name = "accountBalanceTextLabel";
            this.accountBalanceTextLabel.Size = new System.Drawing.Size(40, 13);
            this.accountBalanceTextLabel.TabIndex = 12;
            this.accountBalanceTextLabel.Text = "accBal";
            // 
            // fitMembershipLabel
            // 
            this.fitMembershipLabel.AutoSize = true;
            this.fitMembershipLabel.Location = new System.Drawing.Point(12, 158);
            this.fitMembershipLabel.Name = "fitMembershipLabel";
            this.fitMembershipLabel.Size = new System.Drawing.Size(98, 13);
            this.fitMembershipLabel.TabIndex = 8;
            this.fitMembershipLabel.Text = "fitMembershipLabel";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(12, 132);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(66, 13);
            this.genderLabel.TabIndex = 6;
            this.genderLabel.Text = "genderLabel";
            // 
            // birthDateLabel
            // 
            this.birthDateLabel.AutoSize = true;
            this.birthDateLabel.Location = new System.Drawing.Point(12, 106);
            this.birthDateLabel.Name = "birthDateLabel";
            this.birthDateLabel.Size = new System.Drawing.Size(76, 13);
            this.birthDateLabel.TabIndex = 4;
            this.birthDateLabel.Text = "birthDateLabel";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(84, 49);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(190, 20);
            this.lastNameTextBox.TabIndex = 1;
            this.lastNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.basicTextBox_Validating);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(12, 52);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(77, 13);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "lastNameLabel";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(84, 23);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(190, 20);
            this.firstNameTextBox.TabIndex = 0;
            this.firstNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.basicTextBox_Validating);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(12, 26);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(77, 13);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "firstNameLabel";
            // 
            // actionsGroupBox
            // 
            this.actionsGroupBox.Controls.Add(this.saveButton);
            this.actionsGroupBox.Controls.Add(this.cancelButton);
            this.actionsGroupBox.Controls.Add(this.addCreditButton);
            this.actionsGroupBox.Location = new System.Drawing.Point(477, 12);
            this.actionsGroupBox.Name = "actionsGroupBox";
            this.actionsGroupBox.Size = new System.Drawing.Size(113, 271);
            this.actionsGroupBox.TabIndex = 21;
            this.actionsGroupBox.TabStop = false;
            this.actionsGroupBox.Text = "groupBox3";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(6, 215);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(101, 40);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "saveButton";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(6, 169);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(101, 40);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "cancelButton";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addCreditButton
            // 
            this.addCreditButton.Location = new System.Drawing.Point(6, 23);
            this.addCreditButton.Name = "addCreditButton";
            this.addCreditButton.Size = new System.Drawing.Size(101, 40);
            this.addCreditButton.TabIndex = 0;
            this.addCreditButton.Text = "addCreditButton";
            this.addCreditButton.UseVisualStyleBackColor = true;
            this.addCreditButton.Click += new System.EventHandler(this.addCreditButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddOrEditUserForm
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 294);
            this.Controls.Add(this.actionsGroupBox);
            this.Controls.Add(this.personalDataGroupBox);
            this.Controls.Add(this.profilePictureGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddOrEditUserForm";
            this.Text = "AddOrEditUserForm";
            this.Load += new System.EventHandler(this.AddOrEditUserForm_Load);
            this.profilePictureGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.personalDataGroupBox.ResumeLayout(false);
            this.personalDataGroupBox.PerformLayout();
            this.actionsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox profilePictureGroupBox;
        private BasePictureBox profilePictureBox;
        private BaseButton changeProfileImageButton;
        private System.Windows.Forms.GroupBox personalDataGroupBox;
        private System.Windows.Forms.Label accountBalanceValueLabel;
        private System.Windows.Forms.CheckBox isActiveCheckBox;
        private BaseComboBox fitMembershipComboBox;
        private BaseComboBox genderComboBox;
        private BaseDateTimePicker birthDateTimePicker;
        private System.Windows.Forms.Label accountBalanceTextLabel;
        private System.Windows.Forms.Label fitMembershipLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label birthDateLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.GroupBox actionsGroupBox;
        private BaseButton saveButton;
        private BaseButton cancelButton;
        private BaseButton addCreditButton;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label contactNumberLabel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private BaseComboBox userRoleComboBox;
        private System.Windows.Forms.Label userRoleLabel;
        private System.Windows.Forms.MaskedTextBox ContactNumberTextBox;
    }
}