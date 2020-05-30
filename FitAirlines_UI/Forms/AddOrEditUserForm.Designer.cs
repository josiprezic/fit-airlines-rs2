namespace FitAirlines_UI
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
            this.profilePictureBox = new FitAirlines_UI.BasePictureBox();
            this.changePasswordButton = new FitAirlines_UI.BaseButton();
            this.changeProfileImageButton = new FitAirlines_UI.BaseButton();
            this.personalDataGroupBox = new System.Windows.Forms.GroupBox();
            this.accountBalanceValueLabel = new System.Windows.Forms.Label();
            this.isActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.fitMembershipComboBox = new FitAirlines_UI.BaseComboBox();
            this.genderComboBox = new FitAirlines_UI.BaseComboBox();
            this.birthDateTimePicker = new FitAirlines_UI.BaseDateTimePicker(this.components);
            this.accountBalanceTextLabel = new System.Windows.Forms.Label();
            this.fitMembershipLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.birthDateLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.actionsGroupBox = new System.Windows.Forms.GroupBox();
            this.saveButton = new FitAirlines_UI.BaseButton();
            this.cancelButton = new FitAirlines_UI.BaseButton();
            this.addCreditButton = new FitAirlines_UI.BaseButton();
            this.profilePictureGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.personalDataGroupBox.SuspendLayout();
            this.actionsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // profilePictureGroupBox
            // 
            this.profilePictureGroupBox.Controls.Add(this.profilePictureBox);
            this.profilePictureGroupBox.Controls.Add(this.changePasswordButton);
            this.profilePictureGroupBox.Controls.Add(this.changeProfileImageButton);
            this.profilePictureGroupBox.Location = new System.Drawing.Point(12, 12);
            this.profilePictureGroupBox.Name = "profilePictureGroupBox";
            this.profilePictureGroupBox.Size = new System.Drawing.Size(149, 217);
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
            // changePasswordButton
            // 
            this.changePasswordButton.Location = new System.Drawing.Point(6, 189);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(137, 23);
            this.changePasswordButton.TabIndex = 18;
            this.changePasswordButton.Text = "baseButton2";
            this.changePasswordButton.UseVisualStyleBackColor = true;
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // changeProfileImageButton
            // 
            this.changeProfileImageButton.Location = new System.Drawing.Point(6, 160);
            this.changeProfileImageButton.Name = "changeProfileImageButton";
            this.changeProfileImageButton.Size = new System.Drawing.Size(137, 23);
            this.changeProfileImageButton.TabIndex = 17;
            this.changeProfileImageButton.Text = "baseButton1";
            this.changeProfileImageButton.UseVisualStyleBackColor = true;
            this.changeProfileImageButton.Click += new System.EventHandler(this.changeProfileImageButton_Click);
            // 
            // personalDataGroupBox
            // 
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
            this.personalDataGroupBox.Size = new System.Drawing.Size(304, 217);
            this.personalDataGroupBox.TabIndex = 20;
            this.personalDataGroupBox.TabStop = false;
            this.personalDataGroupBox.Text = "groupBox2";
            // 
            // accountBalanceValueLabel
            // 
            this.accountBalanceValueLabel.AutoSize = true;
            this.accountBalanceValueLabel.Location = new System.Drawing.Point(81, 160);
            this.accountBalanceValueLabel.Name = "accountBalanceValueLabel";
            this.accountBalanceValueLabel.Size = new System.Drawing.Size(35, 13);
            this.accountBalanceValueLabel.TabIndex = 25;
            this.accountBalanceValueLabel.Text = "label6";
            // 
            // isActiveCheckBox
            // 
            this.isActiveCheckBox.AutoSize = true;
            this.isActiveCheckBox.Location = new System.Drawing.Point(194, 159);
            this.isActiveCheckBox.Name = "isActiveCheckBox";
            this.isActiveCheckBox.Size = new System.Drawing.Size(80, 17);
            this.isActiveCheckBox.TabIndex = 24;
            this.isActiveCheckBox.Text = "checkBox1";
            this.isActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // fitMembershipComboBox
            // 
            this.fitMembershipComboBox.FormattingEnabled = true;
            this.fitMembershipComboBox.Location = new System.Drawing.Point(84, 127);
            this.fitMembershipComboBox.Name = "fitMembershipComboBox";
            this.fitMembershipComboBox.Size = new System.Drawing.Size(190, 21);
            this.fitMembershipComboBox.TabIndex = 23;
            // 
            // genderComboBox
            // 
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new System.Drawing.Point(84, 100);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(190, 21);
            this.genderComboBox.TabIndex = 22;
            // 
            // birthDateTimePicker
            // 
            this.birthDateTimePicker.Location = new System.Drawing.Point(84, 75);
            this.birthDateTimePicker.Name = "birthDateTimePicker";
            this.birthDateTimePicker.Size = new System.Drawing.Size(190, 20);
            this.birthDateTimePicker.TabIndex = 21;
            // 
            // accountBalanceTextLabel
            // 
            this.accountBalanceTextLabel.AutoSize = true;
            this.accountBalanceTextLabel.Location = new System.Drawing.Point(12, 160);
            this.accountBalanceTextLabel.Name = "accountBalanceTextLabel";
            this.accountBalanceTextLabel.Size = new System.Drawing.Size(35, 13);
            this.accountBalanceTextLabel.TabIndex = 12;
            this.accountBalanceTextLabel.Text = "label7";
            // 
            // fitMembershipLabel
            // 
            this.fitMembershipLabel.AutoSize = true;
            this.fitMembershipLabel.Location = new System.Drawing.Point(12, 130);
            this.fitMembershipLabel.Name = "fitMembershipLabel";
            this.fitMembershipLabel.Size = new System.Drawing.Size(35, 13);
            this.fitMembershipLabel.TabIndex = 8;
            this.fitMembershipLabel.Text = "label5";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(12, 104);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(35, 13);
            this.genderLabel.TabIndex = 6;
            this.genderLabel.Text = "label4";
            // 
            // birthDateLabel
            // 
            this.birthDateLabel.AutoSize = true;
            this.birthDateLabel.Location = new System.Drawing.Point(12, 78);
            this.birthDateLabel.Name = "birthDateLabel";
            this.birthDateLabel.Size = new System.Drawing.Size(35, 13);
            this.birthDateLabel.TabIndex = 4;
            this.birthDateLabel.Text = "label3";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(84, 49);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(190, 20);
            this.lastNameTextBox.TabIndex = 3;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(12, 52);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(35, 13);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "label2";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(84, 23);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(190, 20);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(12, 26);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(35, 13);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "label1";
            // 
            // actionsGroupBox
            // 
            this.actionsGroupBox.Controls.Add(this.saveButton);
            this.actionsGroupBox.Controls.Add(this.cancelButton);
            this.actionsGroupBox.Controls.Add(this.addCreditButton);
            this.actionsGroupBox.Location = new System.Drawing.Point(477, 12);
            this.actionsGroupBox.Name = "actionsGroupBox";
            this.actionsGroupBox.Size = new System.Drawing.Size(113, 217);
            this.actionsGroupBox.TabIndex = 21;
            this.actionsGroupBox.TabStop = false;
            this.actionsGroupBox.Text = "groupBox3";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(6, 171);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(101, 40);
            this.saveButton.TabIndex = 28;
            this.saveButton.Text = "baseButton5";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(6, 125);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(101, 40);
            this.cancelButton.TabIndex = 27;
            this.cancelButton.Text = "baseButton4";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addCreditButton
            // 
            this.addCreditButton.Location = new System.Drawing.Point(6, 23);
            this.addCreditButton.Name = "addCreditButton";
            this.addCreditButton.Size = new System.Drawing.Size(101, 40);
            this.addCreditButton.TabIndex = 26;
            this.addCreditButton.Text = "baseButton3";
            this.addCreditButton.UseVisualStyleBackColor = true;
            this.addCreditButton.Click += new System.EventHandler(this.addCreditButton_Click);
            // 
            // AddOrEditUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 240);
            this.Controls.Add(this.actionsGroupBox);
            this.Controls.Add(this.personalDataGroupBox);
            this.Controls.Add(this.profilePictureGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddOrEditUserForm";
            this.Text = "AddOrEditUserForm";
            this.profilePictureGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.personalDataGroupBox.ResumeLayout(false);
            this.personalDataGroupBox.PerformLayout();
            this.actionsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox profilePictureGroupBox;
        private BasePictureBox profilePictureBox;
        private BaseButton changePasswordButton;
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
    }
}