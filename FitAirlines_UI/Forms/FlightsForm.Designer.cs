namespace FitAirlines.UI
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
            this.dataGridView = new FitAirlines.UI.BaseDataGridView(this.components);
            this.editImageButton = new FitAirlines.UI.ImageButton(this.components);
            this.addImageButton = new FitAirlines.UI.ImageButton(this.components);
            this.startDateTimePickerLabel = new System.Windows.Forms.Label();
            this.isActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.endDateTimePickerLabel = new System.Windows.Forms.Label();
            this.offerLabel = new System.Windows.Forms.Label();
            this.minMembershipTypeLabel = new System.Windows.Forms.Label();
            this.offerComboBox = new FitAirlines.UI.BaseComboBox();
            this.minMembershipComboBox = new FitAirlines.UI.BaseComboBox();
            this.countryComboBox = new FitAirlines.UI.BaseComboBox();
            this.cityComboBox = new FitAirlines.UI.BaseComboBox();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Offer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MembershipType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Country,
            this.City,
            this.StartDate,
            this.EndDate,
            this.Offer,
            this.MembershipType,
            this.Capacity,
            this.isActive});
            this.dataGridView.Location = new System.Drawing.Point(12, 94);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(853, 404);
            this.dataGridView.TabIndex = 0;
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
            // startDateTimePickerLabel
            // 
            this.startDateTimePickerLabel.AutoSize = true;
            this.startDateTimePickerLabel.Location = new System.Drawing.Point(189, 13);
            this.startDateTimePickerLabel.Name = "startDateTimePickerLabel";
            this.startDateTimePickerLabel.Size = new System.Drawing.Size(35, 13);
            this.startDateTimePickerLabel.TabIndex = 16;
            this.startDateTimePickerLabel.Text = "label1";
            // 
            // isActiveCheckBox
            // 
            this.isActiveCheckBox.AutoSize = true;
            this.isActiveCheckBox.Location = new System.Drawing.Point(593, 30);
            this.isActiveCheckBox.Name = "isActiveCheckBox";
            this.isActiveCheckBox.Size = new System.Drawing.Size(80, 17);
            this.isActiveCheckBox.TabIndex = 15;
            this.isActiveCheckBox.Text = "checkBox1";
            this.isActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(12, 11);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(35, 13);
            this.countryLabel.TabIndex = 22;
            this.countryLabel.Text = "label1";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(12, 50);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(35, 13);
            this.cityLabel.TabIndex = 24;
            this.cityLabel.Text = "label1";
            // 
            // endDateTimePickerLabel
            // 
            this.endDateTimePickerLabel.AutoSize = true;
            this.endDateTimePickerLabel.Location = new System.Drawing.Point(189, 51);
            this.endDateTimePickerLabel.Name = "endDateTimePickerLabel";
            this.endDateTimePickerLabel.Size = new System.Drawing.Size(35, 13);
            this.endDateTimePickerLabel.TabIndex = 25;
            this.endDateTimePickerLabel.Text = "label1";
            // 
            // offerLabel
            // 
            this.offerLabel.AutoSize = true;
            this.offerLabel.Location = new System.Drawing.Point(407, 12);
            this.offerLabel.Name = "offerLabel";
            this.offerLabel.Size = new System.Drawing.Size(35, 13);
            this.offerLabel.TabIndex = 28;
            this.offerLabel.Text = "label1";
            // 
            // minMembershipTypeLabel
            // 
            this.minMembershipTypeLabel.AutoSize = true;
            this.minMembershipTypeLabel.Location = new System.Drawing.Point(407, 50);
            this.minMembershipTypeLabel.Name = "minMembershipTypeLabel";
            this.minMembershipTypeLabel.Size = new System.Drawing.Size(35, 13);
            this.minMembershipTypeLabel.TabIndex = 30;
            this.minMembershipTypeLabel.Text = "label1";
            // 
            // offerComboBox
            // 
            this.offerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.offerComboBox.FormattingEnabled = true;
            this.offerComboBox.Location = new System.Drawing.Point(410, 28);
            this.offerComboBox.Name = "offerComboBox";
            this.offerComboBox.Size = new System.Drawing.Size(165, 21);
            this.offerComboBox.TabIndex = 31;
            // 
            // minMembershipComboBox
            // 
            this.minMembershipComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.minMembershipComboBox.FormattingEnabled = true;
            this.minMembershipComboBox.Location = new System.Drawing.Point(410, 67);
            this.minMembershipComboBox.Name = "minMembershipComboBox";
            this.minMembershipComboBox.Size = new System.Drawing.Size(165, 21);
            this.minMembershipComboBox.TabIndex = 32;
            // 
            // countryComboBox
            // 
            this.countryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Location = new System.Drawing.Point(15, 26);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(162, 21);
            this.countryComboBox.TabIndex = 33;
            // 
            // cityComboBox
            // 
            this.cityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Location = new System.Drawing.Point(12, 66);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(165, 21);
            this.cityComboBox.TabIndex = 34;
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Checked = false;
            this.startDateTimePicker.Location = new System.Drawing.Point(192, 27);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.ShowCheckBox = true;
            this.startDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.startDateTimePicker.TabIndex = 35;
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Checked = false;
            this.endDateTimePicker.Location = new System.Drawing.Point(192, 67);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.ShowCheckBox = true;
            this.endDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.endDateTimePicker.TabIndex = 36;
            // 
            // Country
            // 
            this.Country.DataPropertyName = "CountryId";
            this.Country.HeaderText = "Country";
            this.Country.Name = "Country";
            this.Country.ReadOnly = true;
            // 
            // City
            // 
            this.City.DataPropertyName = "City";
            this.City.HeaderText = "City";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            // 
            // StartDate
            // 
            this.StartDate.DataPropertyName = "StartDate";
            this.StartDate.HeaderText = "StartDate";
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            // 
            // EndDate
            // 
            this.EndDate.DataPropertyName = "EndDate";
            this.EndDate.HeaderText = "EndDate";
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            // 
            // Offer
            // 
            this.Offer.DataPropertyName = "Offer";
            this.Offer.HeaderText = "Offer";
            this.Offer.Name = "Offer";
            this.Offer.ReadOnly = true;
            // 
            // MembershipType
            // 
            this.MembershipType.DataPropertyName = "AvailableToMemberType";
            this.MembershipType.HeaderText = "Availability";
            this.MembershipType.Name = "MembershipType";
            this.MembershipType.ReadOnly = true;
            // 
            // Capacity
            // 
            this.Capacity.DataPropertyName = "Capacity";
            this.Capacity.HeaderText = "Capacity";
            this.Capacity.Name = "Capacity";
            this.Capacity.ReadOnly = true;
            // 
            // isActive
            // 
            this.isActive.DataPropertyName = "isActive";
            this.isActive.HeaderText = "isActive";
            this.isActive.Name = "isActive";
            this.isActive.ReadOnly = true;
            // 
            // FlightsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 510);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.cityComboBox);
            this.Controls.Add(this.countryComboBox);
            this.Controls.Add(this.minMembershipComboBox);
            this.Controls.Add(this.offerComboBox);
            this.Controls.Add(this.minMembershipTypeLabel);
            this.Controls.Add(this.offerLabel);
            this.Controls.Add(this.endDateTimePickerLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.editImageButton);
            this.Controls.Add(this.addImageButton);
            this.Controls.Add(this.startDateTimePickerLabel);
            this.Controls.Add(this.isActiveCheckBox);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FlightsForm";
            this.Text = "FlightsForm";
            this.Load += new System.EventHandler(this.FlightsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BaseDataGridView dataGridView;
        private ImageButton editImageButton;
        private ImageButton addImageButton;
        private System.Windows.Forms.Label startDateTimePickerLabel;
        private System.Windows.Forms.CheckBox isActiveCheckBox;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label endDateTimePickerLabel;
        private System.Windows.Forms.Label offerLabel;
        private System.Windows.Forms.Label minMembershipTypeLabel;
        private BaseComboBox offerComboBox;
        private BaseComboBox minMembershipComboBox;
        private BaseComboBox countryComboBox;
        private BaseComboBox cityComboBox;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Offer;
        private System.Windows.Forms.DataGridViewTextBoxColumn MembershipType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacity;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActive;
    }
}