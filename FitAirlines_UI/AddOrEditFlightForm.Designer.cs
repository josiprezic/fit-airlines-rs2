namespace FitAirlines_UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrEditFlightForm));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cancelButton = new FitAirlines_UI.BaseButton();
            this.saveButton = new FitAirlines_UI.BaseButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.basicInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.capacityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.capacityLabel = new System.Windows.Forms.Label();
            this.offerComboBox = new System.Windows.Forms.ComboBox();
            this.offerLabel = new System.Windows.Forms.Label();
            this.endDateTimePicker = new FitAirlines_UI.BaseDateTimePicker(this.components);
            this.endDateLabel = new System.Windows.Forms.Label();
            this.startDateTimePicker = new FitAirlines_UI.BaseDateTimePicker(this.components);
            this.startDateLabel = new System.Windows.Forms.Label();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.isActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.offerNameTextBox = new System.Windows.Forms.TextBox();
            this.flightNameLabel = new System.Windows.Forms.Label();
            this.imageGroupBox = new System.Windows.Forms.GroupBox();
            this.flightPictureBox = new FitAirlines_UI.BasePictureBox();
            this.uploadFlightPictureButton = new FitAirlines_UI.BaseButton();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.basicInfoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.capacityNumericUpDown)).BeginInit();
            this.imageGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightPictureBox)).BeginInit();
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(355, 304);
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
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "baseButton2";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveButton.Location = new System.Drawing.Point(163, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(155, 42);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "baseButton3";
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(678, 305);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // basicInfoGroupBox
            // 
            this.basicInfoGroupBox.Controls.Add(this.descriptionLabel);
            this.basicInfoGroupBox.Controls.Add(this.capacityNumericUpDown);
            this.basicInfoGroupBox.Controls.Add(this.capacityLabel);
            this.basicInfoGroupBox.Controls.Add(this.offerComboBox);
            this.basicInfoGroupBox.Controls.Add(this.offerLabel);
            this.basicInfoGroupBox.Controls.Add(this.endDateTimePicker);
            this.basicInfoGroupBox.Controls.Add(this.endDateLabel);
            this.basicInfoGroupBox.Controls.Add(this.startDateTimePicker);
            this.basicInfoGroupBox.Controls.Add(this.startDateLabel);
            this.basicInfoGroupBox.Controls.Add(this.cityComboBox);
            this.basicInfoGroupBox.Controls.Add(this.countryComboBox);
            this.basicInfoGroupBox.Controls.Add(this.isActiveCheckBox);
            this.basicInfoGroupBox.Controls.Add(this.descriptionTextBox);
            this.basicInfoGroupBox.Controls.Add(this.cityLabel);
            this.basicInfoGroupBox.Controls.Add(this.countryLabel);
            this.basicInfoGroupBox.Controls.Add(this.offerNameTextBox);
            this.basicInfoGroupBox.Controls.Add(this.flightNameLabel);
            this.basicInfoGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.basicInfoGroupBox.Location = new System.Drawing.Point(3, 3);
            this.basicInfoGroupBox.Name = "basicInfoGroupBox";
            this.basicInfoGroupBox.Size = new System.Drawing.Size(333, 299);
            this.basicInfoGroupBox.TabIndex = 2;
            this.basicInfoGroupBox.TabStop = false;
            this.basicInfoGroupBox.Text = "groupBox1";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(5, 213);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(35, 13);
            this.descriptionLabel.TabIndex = 17;
            this.descriptionLabel.Text = "label3";
            // 
            // capacityNumericUpDown
            // 
            this.capacityNumericUpDown.Location = new System.Drawing.Point(130, 184);
            this.capacityNumericUpDown.Name = "capacityNumericUpDown";
            this.capacityNumericUpDown.Size = new System.Drawing.Size(191, 20);
            this.capacityNumericUpDown.TabIndex = 16;
            // 
            // capacityLabel
            // 
            this.capacityLabel.AutoSize = true;
            this.capacityLabel.Location = new System.Drawing.Point(6, 186);
            this.capacityLabel.Name = "capacityLabel";
            this.capacityLabel.Size = new System.Drawing.Size(35, 13);
            this.capacityLabel.TabIndex = 15;
            this.capacityLabel.Text = "label3";
            // 
            // offerComboBox
            // 
            this.offerComboBox.FormattingEnabled = true;
            this.offerComboBox.Location = new System.Drawing.Point(130, 48);
            this.offerComboBox.Name = "offerComboBox";
            this.offerComboBox.Size = new System.Drawing.Size(191, 21);
            this.offerComboBox.TabIndex = 14;
            // 
            // offerLabel
            // 
            this.offerLabel.AutoSize = true;
            this.offerLabel.Location = new System.Drawing.Point(6, 54);
            this.offerLabel.Name = "offerLabel";
            this.offerLabel.Size = new System.Drawing.Size(35, 13);
            this.offerLabel.TabIndex = 13;
            this.offerLabel.Text = "label1";
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Location = new System.Drawing.Point(130, 157);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(191, 20);
            this.endDateTimePicker.TabIndex = 12;
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(6, 163);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(35, 13);
            this.endDateLabel.TabIndex = 11;
            this.endDateLabel.Text = "label3";
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Location = new System.Drawing.Point(130, 131);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(191, 20);
            this.startDateTimePicker.TabIndex = 10;
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(5, 137);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(35, 13);
            this.startDateLabel.TabIndex = 9;
            this.startDateLabel.Text = "label3";
            // 
            // cityComboBox
            // 
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Location = new System.Drawing.Point(130, 102);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(191, 21);
            this.cityComboBox.TabIndex = 8;
            // 
            // countryComboBox
            // 
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Location = new System.Drawing.Point(130, 76);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(191, 21);
            this.countryComboBox.TabIndex = 7;
            // 
            // isActiveCheckBox
            // 
            this.isActiveCheckBox.AutoSize = true;
            this.isActiveCheckBox.Location = new System.Drawing.Point(130, 262);
            this.isActiveCheckBox.Name = "isActiveCheckBox";
            this.isActiveCheckBox.Size = new System.Drawing.Size(80, 17);
            this.isActiveCheckBox.TabIndex = 6;
            this.isActiveCheckBox.Text = "checkBox1";
            this.isActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(130, 210);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(191, 46);
            this.descriptionTextBox.TabIndex = 5;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(5, 105);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(35, 13);
            this.cityLabel.TabIndex = 4;
            this.cityLabel.Text = "label3";
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(6, 79);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(35, 13);
            this.countryLabel.TabIndex = 2;
            this.countryLabel.Text = "label2";
            // 
            // offerNameTextBox
            // 
            this.offerNameTextBox.Location = new System.Drawing.Point(130, 22);
            this.offerNameTextBox.Name = "offerNameTextBox";
            this.offerNameTextBox.Size = new System.Drawing.Size(191, 20);
            this.offerNameTextBox.TabIndex = 1;
            // 
            // flightNameLabel
            // 
            this.flightNameLabel.AutoSize = true;
            this.flightNameLabel.Location = new System.Drawing.Point(6, 28);
            this.flightNameLabel.Name = "flightNameLabel";
            this.flightNameLabel.Size = new System.Drawing.Size(35, 13);
            this.flightNameLabel.TabIndex = 0;
            this.flightNameLabel.Text = "label1";
            // 
            // imageGroupBox
            // 
            this.imageGroupBox.Controls.Add(this.flightPictureBox);
            this.imageGroupBox.Controls.Add(this.uploadFlightPictureButton);
            this.imageGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageGroupBox.Location = new System.Drawing.Point(342, 3);
            this.imageGroupBox.Name = "imageGroupBox";
            this.imageGroupBox.Size = new System.Drawing.Size(333, 299);
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
            this.flightPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("flightPictureBox.Image")));
            this.flightPictureBox.Location = new System.Drawing.Point(6, 25);
            this.flightPictureBox.Name = "flightPictureBox";
            this.flightPictureBox.Size = new System.Drawing.Size(321, 212);
            this.flightPictureBox.TabIndex = 10;
            this.flightPictureBox.TabStop = false;
            // 
            // uploadFlightPictureButton
            // 
            this.uploadFlightPictureButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uploadFlightPictureButton.Location = new System.Drawing.Point(6, 245);
            this.uploadFlightPictureButton.Name = "uploadFlightPictureButton";
            this.uploadFlightPictureButton.Size = new System.Drawing.Size(321, 40);
            this.uploadFlightPictureButton.TabIndex = 7;
            this.uploadFlightPictureButton.Text = "baseButton1";
            this.uploadFlightPictureButton.UseVisualStyleBackColor = true;
            this.uploadFlightPictureButton.Click += new System.EventHandler(this.uploadFlightPictureButton_Click);
            // 
            // AddOrEditFlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 355);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddOrEditFlightForm";
            this.Text = "AddOrEditFlightForm";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.basicInfoGroupBox.ResumeLayout(false);
            this.basicInfoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.capacityNumericUpDown)).EndInit();
            this.imageGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flightPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private BaseButton cancelButton;
        private BaseButton saveButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox basicInfoGroupBox;
        private System.Windows.Forms.ComboBox countryComboBox;
        private System.Windows.Forms.CheckBox isActiveCheckBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.TextBox offerNameTextBox;
        private System.Windows.Forms.Label flightNameLabel;
        private System.Windows.Forms.GroupBox imageGroupBox;
        private BasePictureBox flightPictureBox;
        private BaseButton uploadFlightPictureButton;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.NumericUpDown capacityNumericUpDown;
        private System.Windows.Forms.Label capacityLabel;
        private System.Windows.Forms.ComboBox offerComboBox;
        private System.Windows.Forms.Label offerLabel;
        private BaseDateTimePicker endDateTimePicker;
        private System.Windows.Forms.Label endDateLabel;
        private BaseDateTimePicker startDateTimePicker;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.ComboBox cityComboBox;
    }
}