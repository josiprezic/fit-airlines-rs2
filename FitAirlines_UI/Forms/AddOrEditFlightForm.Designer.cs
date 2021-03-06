﻿namespace FitAirlines.UI
{
    partial class AddOrEditFlightForm
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
            this.saveButton = new FitAirlines.UI.BaseButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.basicInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.MinMembershipBaseComboBox = new FitAirlines.UI.BaseComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.priceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.priceLabel = new System.Windows.Forms.Label();
            this.FlightTimeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.flightDurationLabel = new System.Windows.Forms.Label();
            this.pilotNameTextBox = new System.Windows.Forms.TextBox();
            this.pilotNameLabel = new System.Windows.Forms.Label();
            this.discPercentageUpDown = new System.Windows.Forms.NumericUpDown();
            this.voucherDiscPercentageLabel = new System.Windows.Forms.Label();
            this.planeComboBox = new FitAirlines.UI.BaseComboBox();
            this.planeLabel = new System.Windows.Forms.Label();
            this.destinationAirportComboBox = new FitAirlines.UI.BaseComboBox();
            this.destAirportLabel = new System.Windows.Forms.Label();
            this.cityComboBox = new FitAirlines.UI.BaseComboBox();
            this.countryComboBox = new FitAirlines.UI.BaseComboBox();
            this.offerComboBox = new FitAirlines.UI.BaseComboBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.offerLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.imageGroupBox = new System.Windows.Forms.GroupBox();
            this.flightPictureBox = new FitAirlines.UI.BasePictureBox();
            this.uploadFlightPictureButton = new FitAirlines.UI.BaseButton();
            this.isActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.basicInfoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlightTimeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discPercentageUpDown)).BeginInit();
            this.imageGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightPictureBox)).BeginInit();
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
            this.tableLayoutPanel2.Controls.Add(this.saveButton, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(443, 411);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(321, 48);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // cancelButton
            // 
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelButton.Location = new System.Drawing.Point(3, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(154, 42);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "cancelButton";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveButton.Location = new System.Drawing.Point(163, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(155, 42);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "saveButton";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.basicInfoGroupBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.imageGroupBox, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, -2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(766, 412);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // basicInfoGroupBox
            // 
            this.basicInfoGroupBox.Controls.Add(this.endDateTimePicker);
            this.basicInfoGroupBox.Controls.Add(this.startDateTimePicker);
            this.basicInfoGroupBox.Controls.Add(this.MinMembershipBaseComboBox);
            this.basicInfoGroupBox.Controls.Add(this.label2);
            this.basicInfoGroupBox.Controls.Add(this.priceNumericUpDown);
            this.basicInfoGroupBox.Controls.Add(this.priceLabel);
            this.basicInfoGroupBox.Controls.Add(this.FlightTimeNumericUpDown);
            this.basicInfoGroupBox.Controls.Add(this.flightDurationLabel);
            this.basicInfoGroupBox.Controls.Add(this.pilotNameTextBox);
            this.basicInfoGroupBox.Controls.Add(this.pilotNameLabel);
            this.basicInfoGroupBox.Controls.Add(this.discPercentageUpDown);
            this.basicInfoGroupBox.Controls.Add(this.voucherDiscPercentageLabel);
            this.basicInfoGroupBox.Controls.Add(this.planeComboBox);
            this.basicInfoGroupBox.Controls.Add(this.planeLabel);
            this.basicInfoGroupBox.Controls.Add(this.destinationAirportComboBox);
            this.basicInfoGroupBox.Controls.Add(this.destAirportLabel);
            this.basicInfoGroupBox.Controls.Add(this.cityComboBox);
            this.basicInfoGroupBox.Controls.Add(this.countryComboBox);
            this.basicInfoGroupBox.Controls.Add(this.offerComboBox);
            this.basicInfoGroupBox.Controls.Add(this.descriptionLabel);
            this.basicInfoGroupBox.Controls.Add(this.offerLabel);
            this.basicInfoGroupBox.Controls.Add(this.endDateLabel);
            this.basicInfoGroupBox.Controls.Add(this.startDateLabel);
            this.basicInfoGroupBox.Controls.Add(this.descriptionTextBox);
            this.basicInfoGroupBox.Controls.Add(this.cityLabel);
            this.basicInfoGroupBox.Controls.Add(this.countryLabel);
            this.basicInfoGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.basicInfoGroupBox.Location = new System.Drawing.Point(3, 3);
            this.basicInfoGroupBox.Name = "basicInfoGroupBox";
            this.basicInfoGroupBox.Size = new System.Drawing.Size(377, 406);
            this.basicInfoGroupBox.TabIndex = 2;
            this.basicInfoGroupBox.TabStop = false;
            this.basicInfoGroupBox.Text = "groupBox1";
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.CustomFormat = "MMMMdd, yyyy  |  HH:mm";
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDateTimePicker.Location = new System.Drawing.Point(147, 214);
            this.endDateTimePicker.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(190, 20);
            this.endDateTimePicker.TabIndex = 7;
            this.endDateTimePicker.Validating += new System.ComponentModel.CancelEventHandler(this.endDateTimePicker_Validating);
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.CustomFormat = "MMMMdd, yyyy  |  HH:mm";
            this.startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDateTimePicker.Location = new System.Drawing.Point(146, 189);
            this.startDateTimePicker.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(190, 20);
            this.startDateTimePicker.TabIndex = 6;
            // 
            // MinMembershipBaseComboBox
            // 
            this.MinMembershipBaseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MinMembershipBaseComboBox.FormattingEnabled = true;
            this.MinMembershipBaseComboBox.Location = new System.Drawing.Point(148, 316);
            this.MinMembershipBaseComboBox.Name = "MinMembershipBaseComboBox";
            this.MinMembershipBaseComboBox.Size = new System.Drawing.Size(191, 21);
            this.MinMembershipBaseComboBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Available to:";
            // 
            // priceNumericUpDown
            // 
            this.priceNumericUpDown.Location = new System.Drawing.Point(148, 370);
            this.priceNumericUpDown.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.priceNumericUpDown.Name = "priceNumericUpDown";
            this.priceNumericUpDown.Size = new System.Drawing.Size(191, 20);
            this.priceNumericUpDown.TabIndex = 12;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(6, 372);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(98, 13);
            this.priceLabel.TabIndex = 31;
            this.priceLabel.Text = "Ticket price (BAM):";
            // 
            // FlightTimeNumericUpDown
            // 
            this.FlightTimeNumericUpDown.Location = new System.Drawing.Point(147, 343);
            this.FlightTimeNumericUpDown.Maximum = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.FlightTimeNumericUpDown.Name = "FlightTimeNumericUpDown";
            this.FlightTimeNumericUpDown.Size = new System.Drawing.Size(191, 20);
            this.FlightTimeNumericUpDown.TabIndex = 11;
            // 
            // flightDurationLabel
            // 
            this.flightDurationLabel.AutoSize = true;
            this.flightDurationLabel.Location = new System.Drawing.Point(5, 345);
            this.flightDurationLabel.Name = "flightDurationLabel";
            this.flightDurationLabel.Size = new System.Drawing.Size(133, 13);
            this.flightDurationLabel.TabIndex = 29;
            this.flightDurationLabel.Text = "Flight time [min] (One-way):";
            // 
            // pilotNameTextBox
            // 
            this.pilotNameTextBox.Location = new System.Drawing.Point(146, 162);
            this.pilotNameTextBox.Name = "pilotNameTextBox";
            this.pilotNameTextBox.Size = new System.Drawing.Size(191, 20);
            this.pilotNameTextBox.TabIndex = 5;
            this.pilotNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.pilotNameTextBox_Validating);
            // 
            // pilotNameLabel
            // 
            this.pilotNameLabel.AutoSize = true;
            this.pilotNameLabel.Location = new System.Drawing.Point(6, 162);
            this.pilotNameLabel.Name = "pilotNameLabel";
            this.pilotNameLabel.Size = new System.Drawing.Size(61, 13);
            this.pilotNameLabel.TabIndex = 27;
            this.pilotNameLabel.Text = "Pilot Name:";
            // 
            // discPercentageUpDown
            // 
            this.discPercentageUpDown.Location = new System.Drawing.Point(146, 290);
            this.discPercentageUpDown.Name = "discPercentageUpDown";
            this.discPercentageUpDown.Size = new System.Drawing.Size(191, 20);
            this.discPercentageUpDown.TabIndex = 9;
            // 
            // voucherDiscPercentageLabel
            // 
            this.voucherDiscPercentageLabel.AutoSize = true;
            this.voucherDiscPercentageLabel.Location = new System.Drawing.Point(5, 292);
            this.voucherDiscPercentageLabel.Name = "voucherDiscPercentageLabel";
            this.voucherDiscPercentageLabel.Size = new System.Drawing.Size(112, 13);
            this.voucherDiscPercentageLabel.TabIndex = 25;
            this.voucherDiscPercentageLabel.Text = "Voucher Discount (%):";
            // 
            // planeComboBox
            // 
            this.planeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.planeComboBox.FormattingEnabled = true;
            this.planeComboBox.Location = new System.Drawing.Point(147, 135);
            this.planeComboBox.Name = "planeComboBox";
            this.planeComboBox.Size = new System.Drawing.Size(191, 21);
            this.planeComboBox.TabIndex = 4;
            // 
            // planeLabel
            // 
            this.planeLabel.AutoSize = true;
            this.planeLabel.Location = new System.Drawing.Point(5, 136);
            this.planeLabel.Name = "planeLabel";
            this.planeLabel.Size = new System.Drawing.Size(37, 13);
            this.planeLabel.TabIndex = 23;
            this.planeLabel.Text = "Plane:";
            // 
            // destinationAirportComboBox
            // 
            this.destinationAirportComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.destinationAirportComboBox.FormattingEnabled = true;
            this.destinationAirportComboBox.Location = new System.Drawing.Point(148, 109);
            this.destinationAirportComboBox.Name = "destinationAirportComboBox";
            this.destinationAirportComboBox.Size = new System.Drawing.Size(191, 21);
            this.destinationAirportComboBox.TabIndex = 3;
            this.destinationAirportComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.destinationAirportComboBox_Validating);
            // 
            // destAirportLabel
            // 
            this.destAirportLabel.AutoSize = true;
            this.destAirportLabel.Location = new System.Drawing.Point(6, 110);
            this.destAirportLabel.Name = "destAirportLabel";
            this.destAirportLabel.Size = new System.Drawing.Size(67, 13);
            this.destAirportLabel.TabIndex = 21;
            this.destAirportLabel.Text = "Dest. airport:";
            // 
            // cityComboBox
            // 
            this.cityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Location = new System.Drawing.Point(147, 82);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(191, 21);
            this.cityComboBox.TabIndex = 2;
            this.cityComboBox.SelectedIndexChanged += new System.EventHandler(this.cityComboBox_SelectedIndexChanged);
            this.cityComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.cityComboBox_Validating);
            // 
            // countryComboBox
            // 
            this.countryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Location = new System.Drawing.Point(147, 54);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(191, 21);
            this.countryComboBox.TabIndex = 1;
            this.countryComboBox.SelectedIndexChanged += new System.EventHandler(this.countryComboBox_SelectedIndexChanged);
            this.countryComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.countryComboBox_Validating);
            // 
            // offerComboBox
            // 
            this.offerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.offerComboBox.FormattingEnabled = true;
            this.offerComboBox.Location = new System.Drawing.Point(147, 26);
            this.offerComboBox.Name = "offerComboBox";
            this.offerComboBox.Size = new System.Drawing.Size(191, 21);
            this.offerComboBox.TabIndex = 0;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(5, 241);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.descriptionLabel.TabIndex = 17;
            this.descriptionLabel.Text = "Description:";
            // 
            // offerLabel
            // 
            this.offerLabel.AutoSize = true;
            this.offerLabel.Location = new System.Drawing.Point(6, 31);
            this.offerLabel.Name = "offerLabel";
            this.offerLabel.Size = new System.Drawing.Size(33, 13);
            this.offerLabel.TabIndex = 13;
            this.offerLabel.Text = "Offer:";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(6, 218);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(96, 13);
            this.endDateLabel.TabIndex = 11;
            this.endDateLabel.Text = "Return Date/Time:";
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(5, 192);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(111, 13);
            this.startDateLabel.TabIndex = 9;
            this.startDateLabel.Text = "Departure Date/Time:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(147, 238);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(191, 46);
            this.descriptionTextBox.TabIndex = 8;
            this.descriptionTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.descriptionTextBox_Validating);
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(5, 83);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(30, 13);
            this.cityLabel.TabIndex = 4;
            this.cityLabel.Text = "City: ";
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(6, 57);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(46, 13);
            this.countryLabel.TabIndex = 2;
            this.countryLabel.Text = "Country:";
            // 
            // imageGroupBox
            // 
            this.imageGroupBox.Controls.Add(this.flightPictureBox);
            this.imageGroupBox.Controls.Add(this.uploadFlightPictureButton);
            this.imageGroupBox.Controls.Add(this.isActiveCheckBox);
            this.imageGroupBox.Controls.Add(this.notesTextBox);
            this.imageGroupBox.Controls.Add(this.label1);
            this.imageGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageGroupBox.Location = new System.Drawing.Point(386, 3);
            this.imageGroupBox.Name = "imageGroupBox";
            this.imageGroupBox.Size = new System.Drawing.Size(377, 406);
            this.imageGroupBox.TabIndex = 11;
            this.imageGroupBox.TabStop = false;
            this.imageGroupBox.Text = "groupBox2";
            // 
            // flightPictureBox
            // 
            this.flightPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flightPictureBox.BackColor = System.Drawing.Color.Gray;
            this.flightPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flightPictureBox.Location = new System.Drawing.Point(6, 25);
            this.flightPictureBox.Name = "flightPictureBox";
            this.flightPictureBox.Size = new System.Drawing.Size(365, 206);
            this.flightPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.flightPictureBox.TabIndex = 10;
            this.flightPictureBox.TabStop = false;
            // 
            // uploadFlightPictureButton
            // 
            this.uploadFlightPictureButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uploadFlightPictureButton.Location = new System.Drawing.Point(5, 243);
            this.uploadFlightPictureButton.Name = "uploadFlightPictureButton";
            this.uploadFlightPictureButton.Size = new System.Drawing.Size(365, 40);
            this.uploadFlightPictureButton.TabIndex = 0;
            this.uploadFlightPictureButton.Text = "Upload Picture...";
            this.uploadFlightPictureButton.UseVisualStyleBackColor = true;
            this.uploadFlightPictureButton.Click += new System.EventHandler(this.uploadFlightPictureButton_Click);
            // 
            // isActiveCheckBox
            // 
            this.isActiveCheckBox.AutoSize = true;
            this.isActiveCheckBox.Location = new System.Drawing.Point(45, 373);
            this.isActiveCheckBox.Name = "isActiveCheckBox";
            this.isActiveCheckBox.Size = new System.Drawing.Size(56, 17);
            this.isActiveCheckBox.TabIndex = 2;
            this.isActiveCheckBox.Text = "Active";
            this.isActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // notesTextBox
            // 
            this.notesTextBox.Location = new System.Drawing.Point(45, 289);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(325, 74);
            this.notesTextBox.TabIndex = 1;
            this.notesTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.notesTextBox_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Notes:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddOrEditFlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 462);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddOrEditFlightForm";
            this.Text = "AddOrEditFlightForm";
            this.Load += new System.EventHandler(this.AddOrEditFlightForm_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.basicInfoGroupBox.ResumeLayout(false);
            this.basicInfoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlightTimeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discPercentageUpDown)).EndInit();
            this.imageGroupBox.ResumeLayout(false);
            this.imageGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private BaseButton cancelButton;
        private BaseButton saveButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox basicInfoGroupBox;
        private System.Windows.Forms.CheckBox isActiveCheckBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.GroupBox imageGroupBox;
        private BasePictureBox flightPictureBox;
        private BaseButton uploadFlightPictureButton;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label offerLabel;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.Label startDateLabel;
        private BaseComboBox cityComboBox;
        private BaseComboBox countryComboBox;
        private BaseComboBox offerComboBox;
        private BaseComboBox MinMembershipBaseComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown priceNumericUpDown;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.NumericUpDown FlightTimeNumericUpDown;
        private System.Windows.Forms.Label flightDurationLabel;
        private System.Windows.Forms.TextBox pilotNameTextBox;
        private System.Windows.Forms.Label pilotNameLabel;
        private System.Windows.Forms.NumericUpDown discPercentageUpDown;
        private System.Windows.Forms.Label voucherDiscPercentageLabel;
        private BaseComboBox planeComboBox;
        private System.Windows.Forms.Label planeLabel;
        private BaseComboBox destinationAirportComboBox;
        private System.Windows.Forms.Label destAirportLabel;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}