namespace FitAirlines_UI
{
    partial class FlightsForm
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
            this.dataGridView = new FitAirlines_UI.BaseDataGridView(this.components);
            this.searchImageButton = new FitAirlines_UI.ImageButton(this.components);
            this.editImageButton = new FitAirlines_UI.ImageButton(this.components);
            this.addImageButton = new FitAirlines_UI.ImageButton(this.components);
            this.startDateTimePicker = new FitAirlines_UI.BaseDateTimePicker(this.components);
            this.startDateTimePickerLabel = new System.Windows.Forms.Label();
            this.isActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.flightNameLabel = new System.Windows.Forms.Label();
            this.flightNameTextBox = new System.Windows.Forms.TextBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.endDateTimePicker = new FitAirlines_UI.BaseDateTimePicker(this.components);
            this.endDateTimePickerLabel = new System.Windows.Forms.Label();
            this.offerLabel = new System.Windows.Forms.Label();
            this.minMembershipTypeLabel = new System.Windows.Forms.Label();
            this.offerComboBox = new FitAirlines_UI.BaseComboBox();
            this.minMembershipComboBox = new FitAirlines_UI.BaseComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 144);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(853, 354);
            this.dataGridView.TabIndex = 0;
            // 
            // searchImageButton
            // 
            this.searchImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchImageButton.Location = new System.Drawing.Point(592, 12);
            this.searchImageButton.Name = "searchImageButton";
            this.searchImageButton.Size = new System.Drawing.Size(95, 51);
            this.searchImageButton.TabIndex = 20;
            this.searchImageButton.Text = "imageButton3";
            this.searchImageButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.searchImageButton.UseVisualStyleBackColor = true;
            this.searchImageButton.Click += new System.EventHandler(this.searchImageButton_Click);
            // 
            // editImageButton
            // 
            this.editImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editImageButton.Location = new System.Drawing.Point(689, 12);
            this.editImageButton.Name = "editImageButton";
            this.editImageButton.Size = new System.Drawing.Size(85, 51);
            this.editImageButton.TabIndex = 19;
            this.editImageButton.Text = "imageButton2";
            this.editImageButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editImageButton.UseVisualStyleBackColor = true;
            this.editImageButton.Click += new System.EventHandler(this.editImageButton_Click);
            // 
            // addImageButton
            // 
            this.addImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addImageButton.Location = new System.Drawing.Point(776, 12);
            this.addImageButton.Name = "addImageButton";
            this.addImageButton.Size = new System.Drawing.Size(89, 52);
            this.addImageButton.TabIndex = 18;
            this.addImageButton.Text = "imageButton1";
            this.addImageButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addImageButton.UseVisualStyleBackColor = true;
            this.addImageButton.Click += new System.EventHandler(this.addImageButton_Click);
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Location = new System.Drawing.Point(212, 28);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(183, 20);
            this.startDateTimePicker.TabIndex = 17;
            // 
            // startDateTimePickerLabel
            // 
            this.startDateTimePickerLabel.AutoSize = true;
            this.startDateTimePickerLabel.Location = new System.Drawing.Point(209, 12);
            this.startDateTimePickerLabel.Name = "startDateTimePickerLabel";
            this.startDateTimePickerLabel.Size = new System.Drawing.Size(35, 13);
            this.startDateTimePickerLabel.TabIndex = 16;
            this.startDateTimePickerLabel.Text = "label1";
            // 
            // isActiveCheckBox
            // 
            this.isActiveCheckBox.AutoSize = true;
            this.isActiveCheckBox.Location = new System.Drawing.Point(497, 108);
            this.isActiveCheckBox.Name = "isActiveCheckBox";
            this.isActiveCheckBox.Size = new System.Drawing.Size(80, 17);
            this.isActiveCheckBox.TabIndex = 15;
            this.isActiveCheckBox.Text = "checkBox1";
            this.isActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // flightNameLabel
            // 
            this.flightNameLabel.AutoSize = true;
            this.flightNameLabel.Location = new System.Drawing.Point(12, 12);
            this.flightNameLabel.Name = "flightNameLabel";
            this.flightNameLabel.Size = new System.Drawing.Size(35, 13);
            this.flightNameLabel.TabIndex = 14;
            this.flightNameLabel.Text = "label1";
            // 
            // flightNameTextBox
            // 
            this.flightNameTextBox.Location = new System.Drawing.Point(15, 28);
            this.flightNameTextBox.Name = "flightNameTextBox";
            this.flightNameTextBox.Size = new System.Drawing.Size(178, 20);
            this.flightNameTextBox.TabIndex = 13;
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(12, 51);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(35, 13);
            this.countryLabel.TabIndex = 22;
            this.countryLabel.Text = "label1";
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(15, 67);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(178, 20);
            this.countryTextBox.TabIndex = 21;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(12, 90);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(35, 13);
            this.cityLabel.TabIndex = 24;
            this.cityLabel.Text = "label1";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(15, 106);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(178, 20);
            this.cityTextBox.TabIndex = 23;
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Location = new System.Drawing.Point(212, 66);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(183, 20);
            this.endDateTimePicker.TabIndex = 26;
            // 
            // endDateTimePickerLabel
            // 
            this.endDateTimePickerLabel.AutoSize = true;
            this.endDateTimePickerLabel.Location = new System.Drawing.Point(209, 50);
            this.endDateTimePickerLabel.Name = "endDateTimePickerLabel";
            this.endDateTimePickerLabel.Size = new System.Drawing.Size(35, 13);
            this.endDateTimePickerLabel.TabIndex = 25;
            this.endDateTimePickerLabel.Text = "label1";
            // 
            // offerLabel
            // 
            this.offerLabel.AutoSize = true;
            this.offerLabel.Location = new System.Drawing.Point(409, 12);
            this.offerLabel.Name = "offerLabel";
            this.offerLabel.Size = new System.Drawing.Size(35, 13);
            this.offerLabel.TabIndex = 28;
            this.offerLabel.Text = "label1";
            // 
            // minMembershipTypeLabel
            // 
            this.minMembershipTypeLabel.AutoSize = true;
            this.minMembershipTypeLabel.Location = new System.Drawing.Point(409, 50);
            this.minMembershipTypeLabel.Name = "minMembershipTypeLabel";
            this.minMembershipTypeLabel.Size = new System.Drawing.Size(35, 13);
            this.minMembershipTypeLabel.TabIndex = 30;
            this.minMembershipTypeLabel.Text = "label1";
            // 
            // offerComboBox
            // 
            this.offerComboBox.FormattingEnabled = true;
            this.offerComboBox.Location = new System.Drawing.Point(412, 28);
            this.offerComboBox.Name = "offerComboBox";
            this.offerComboBox.Size = new System.Drawing.Size(165, 21);
            this.offerComboBox.TabIndex = 31;
            // 
            // minMembershipComboBox
            // 
            this.minMembershipComboBox.FormattingEnabled = true;
            this.minMembershipComboBox.Location = new System.Drawing.Point(412, 67);
            this.minMembershipComboBox.Name = "minMembershipComboBox";
            this.minMembershipComboBox.Size = new System.Drawing.Size(165, 21);
            this.minMembershipComboBox.TabIndex = 32;
            // 
            // FlightsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 510);
            this.Controls.Add(this.minMembershipComboBox);
            this.Controls.Add(this.offerComboBox);
            this.Controls.Add(this.minMembershipTypeLabel);
            this.Controls.Add(this.offerLabel);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.endDateTimePickerLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(this.searchImageButton);
            this.Controls.Add(this.editImageButton);
            this.Controls.Add(this.addImageButton);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.startDateTimePickerLabel);
            this.Controls.Add(this.isActiveCheckBox);
            this.Controls.Add(this.flightNameLabel);
            this.Controls.Add(this.flightNameTextBox);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FlightsForm";
            this.Text = "FlightsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BaseDataGridView dataGridView;
        private ImageButton searchImageButton;
        private ImageButton editImageButton;
        private ImageButton addImageButton;
        private BaseDateTimePicker startDateTimePicker;
        private System.Windows.Forms.Label startDateTimePickerLabel;
        private System.Windows.Forms.CheckBox isActiveCheckBox;
        private System.Windows.Forms.Label flightNameLabel;
        private System.Windows.Forms.TextBox flightNameTextBox;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox cityTextBox;
        private BaseDateTimePicker endDateTimePicker;
        private System.Windows.Forms.Label endDateTimePickerLabel;
        private System.Windows.Forms.Label offerLabel;
        private System.Windows.Forms.Label minMembershipTypeLabel;
        private BaseComboBox offerComboBox;
        private BaseComboBox minMembershipComboBox;
    }
}