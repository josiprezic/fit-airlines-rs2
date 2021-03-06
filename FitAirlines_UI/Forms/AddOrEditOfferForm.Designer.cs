﻿namespace FitAirlines.UI
{
    partial class AddOrEditOfferForm
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cancelButton = new FitAirlines.UI.BaseButton();
            this.saveOfferButton = new FitAirlines.UI.BaseButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.personalInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.offerMemberTypeComboBox = new FitAirlines.UI.BaseComboBox();
            this.isActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.offerDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.offerDescriptionLabel = new System.Windows.Forms.Label();
            this.requiredMemberLevelLabel = new System.Windows.Forms.Label();
            this.offerNameTextBox = new System.Windows.Forms.TextBox();
            this.offerNameLabel = new System.Windows.Forms.Label();
            this.imageGroupBox = new System.Windows.Forms.GroupBox();
            this.offerPictureBox = new FitAirlines.UI.BasePictureBox();
            this.uploadofferPictureButton = new FitAirlines.UI.BaseButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.personalInfoGroupBox.SuspendLayout();
            this.imageGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.offerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.cancelButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.saveOfferButton, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(439, 329);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(321, 48);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // cancelButton
            // 
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelButton.Location = new System.Drawing.Point(3, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(154, 42);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "baseButton2";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveOfferButton
            // 
            this.saveOfferButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveOfferButton.Location = new System.Drawing.Point(163, 3);
            this.saveOfferButton.Name = "saveOfferButton";
            this.saveOfferButton.Size = new System.Drawing.Size(155, 42);
            this.saveOfferButton.TabIndex = 8;
            this.saveOfferButton.Text = "baseButton3";
            this.saveOfferButton.UseVisualStyleBackColor = true;
            this.saveOfferButton.Click += new System.EventHandler(this.saveOfferButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.personalInfoGroupBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.imageGroupBox, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(752, 311);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // personalInfoGroupBox
            // 
            this.personalInfoGroupBox.Controls.Add(this.endDateLabel);
            this.personalInfoGroupBox.Controls.Add(this.startDateLabel);
            this.personalInfoGroupBox.Controls.Add(this.endDateTimePicker);
            this.personalInfoGroupBox.Controls.Add(this.startDateTimePicker);
            this.personalInfoGroupBox.Controls.Add(this.offerMemberTypeComboBox);
            this.personalInfoGroupBox.Controls.Add(this.isActiveCheckBox);
            this.personalInfoGroupBox.Controls.Add(this.offerDescriptionTextBox);
            this.personalInfoGroupBox.Controls.Add(this.offerDescriptionLabel);
            this.personalInfoGroupBox.Controls.Add(this.requiredMemberLevelLabel);
            this.personalInfoGroupBox.Controls.Add(this.offerNameTextBox);
            this.personalInfoGroupBox.Controls.Add(this.offerNameLabel);
            this.personalInfoGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personalInfoGroupBox.Location = new System.Drawing.Point(3, 3);
            this.personalInfoGroupBox.Name = "personalInfoGroupBox";
            this.personalInfoGroupBox.Size = new System.Drawing.Size(370, 305);
            this.personalInfoGroupBox.TabIndex = 2;
            this.personalInfoGroupBox.TabStop = false;
            this.personalInfoGroupBox.Text = "groupBox1";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(6, 241);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(53, 13);
            this.endDateLabel.TabIndex = 11;
            this.endDateLabel.Text = "End date:";
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(6, 215);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(56, 13);
            this.startDateLabel.TabIndex = 10;
            this.startDateLabel.Text = "Start date:";
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Location = new System.Drawing.Point(130, 235);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.endDateTimePicker.TabIndex = 4;
            this.endDateTimePicker.Validating += new System.ComponentModel.CancelEventHandler(this.endDateTimePicker_Validating);
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Location = new System.Drawing.Point(130, 209);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.startDateTimePicker.TabIndex = 3;
            // 
            // offerMemberTypeComboBox
            // 
            this.offerMemberTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.offerMemberTypeComboBox.FormattingEnabled = true;
            this.offerMemberTypeComboBox.Location = new System.Drawing.Point(130, 45);
            this.offerMemberTypeComboBox.Name = "offerMemberTypeComboBox";
            this.offerMemberTypeComboBox.Size = new System.Drawing.Size(200, 21);
            this.offerMemberTypeComboBox.TabIndex = 1;
            // 
            // isActiveCheckBox
            // 
            this.isActiveCheckBox.AutoSize = true;
            this.isActiveCheckBox.Location = new System.Drawing.Point(130, 261);
            this.isActiveCheckBox.Name = "isActiveCheckBox";
            this.isActiveCheckBox.Size = new System.Drawing.Size(80, 17);
            this.isActiveCheckBox.TabIndex = 5;
            this.isActiveCheckBox.Text = "checkBox1";
            this.isActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // offerDescriptionTextBox
            // 
            this.offerDescriptionTextBox.Location = new System.Drawing.Point(130, 69);
            this.offerDescriptionTextBox.Multiline = true;
            this.offerDescriptionTextBox.Name = "offerDescriptionTextBox";
            this.offerDescriptionTextBox.Size = new System.Drawing.Size(200, 133);
            this.offerDescriptionTextBox.TabIndex = 2;
            this.offerDescriptionTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.offerDescriptionTextBox_Validating);
            // 
            // offerDescriptionLabel
            // 
            this.offerDescriptionLabel.AutoSize = true;
            this.offerDescriptionLabel.Location = new System.Drawing.Point(6, 72);
            this.offerDescriptionLabel.Name = "offerDescriptionLabel";
            this.offerDescriptionLabel.Size = new System.Drawing.Size(35, 13);
            this.offerDescriptionLabel.TabIndex = 4;
            this.offerDescriptionLabel.Text = "label3";
            // 
            // requiredMemberLevelLabel
            // 
            this.requiredMemberLevelLabel.AutoSize = true;
            this.requiredMemberLevelLabel.Location = new System.Drawing.Point(6, 50);
            this.requiredMemberLevelLabel.Name = "requiredMemberLevelLabel";
            this.requiredMemberLevelLabel.Size = new System.Drawing.Size(35, 13);
            this.requiredMemberLevelLabel.TabIndex = 2;
            this.requiredMemberLevelLabel.Text = "label2";
            // 
            // offerNameTextBox
            // 
            this.offerNameTextBox.Location = new System.Drawing.Point(130, 22);
            this.offerNameTextBox.Name = "offerNameTextBox";
            this.offerNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.offerNameTextBox.TabIndex = 0;
            this.offerNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.offerNameTextBox_Validating);
            // 
            // offerNameLabel
            // 
            this.offerNameLabel.AutoSize = true;
            this.offerNameLabel.Location = new System.Drawing.Point(6, 28);
            this.offerNameLabel.Name = "offerNameLabel";
            this.offerNameLabel.Size = new System.Drawing.Size(35, 13);
            this.offerNameLabel.TabIndex = 0;
            this.offerNameLabel.Text = "label1";
            // 
            // imageGroupBox
            // 
            this.imageGroupBox.Controls.Add(this.offerPictureBox);
            this.imageGroupBox.Controls.Add(this.uploadofferPictureButton);
            this.imageGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageGroupBox.Location = new System.Drawing.Point(379, 3);
            this.imageGroupBox.Name = "imageGroupBox";
            this.imageGroupBox.Size = new System.Drawing.Size(370, 305);
            this.imageGroupBox.TabIndex = 0;
            this.imageGroupBox.TabStop = false;
            this.imageGroupBox.Text = "groupBox2";
            // 
            // offerPictureBox
            // 
            this.offerPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.offerPictureBox.BackColor = System.Drawing.Color.Gray;
            this.offerPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.offerPictureBox.Location = new System.Drawing.Point(6, 25);
            this.offerPictureBox.Name = "offerPictureBox";
            this.offerPictureBox.Size = new System.Drawing.Size(358, 230);
            this.offerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.offerPictureBox.TabIndex = 10;
            this.offerPictureBox.TabStop = false;
            // 
            // uploadofferPictureButton
            // 
            this.uploadofferPictureButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uploadofferPictureButton.Location = new System.Drawing.Point(6, 261);
            this.uploadofferPictureButton.Name = "uploadofferPictureButton";
            this.uploadofferPictureButton.Size = new System.Drawing.Size(358, 40);
            this.uploadofferPictureButton.TabIndex = 6;
            this.uploadofferPictureButton.Text = "baseButton1";
            this.uploadofferPictureButton.UseVisualStyleBackColor = true;
            this.uploadofferPictureButton.Click += new System.EventHandler(this.uploadofferPictureButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddOrEditOfferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 382);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddOrEditOfferForm";
            this.Text = "AddOrEditOfferForm";
            this.Load += new System.EventHandler(this.AddOrEditOfferForm_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.personalInfoGroupBox.ResumeLayout(false);
            this.personalInfoGroupBox.PerformLayout();
            this.imageGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.offerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox imageGroupBox;
        private BasePictureBox offerPictureBox;
        private BaseButton uploadofferPictureButton;
        private BaseButton saveOfferButton;
        private BaseButton cancelButton;
        private System.Windows.Forms.Label offerNameLabel;
        private System.Windows.Forms.TextBox offerNameTextBox;
        private System.Windows.Forms.Label requiredMemberLevelLabel;
        private System.Windows.Forms.Label offerDescriptionLabel;
        private System.Windows.Forms.TextBox offerDescriptionTextBox;
        private System.Windows.Forms.CheckBox isActiveCheckBox;
        private System.Windows.Forms.GroupBox personalInfoGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private BaseComboBox offerMemberTypeComboBox;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}