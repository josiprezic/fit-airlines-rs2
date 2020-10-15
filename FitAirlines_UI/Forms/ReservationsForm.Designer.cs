namespace FitAirlines.UI
{
    partial class ReservationsForm
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
            this.searchImageButton = new FitAirlines.UI.ImageButton(this.components);
            this.editImageButton = new FitAirlines.UI.ImageButton(this.components);
            this.addImageButton = new FitAirlines.UI.ImageButton(this.components);
            this.reservationDateTimePicker = new FitAirlines.UI.BaseDateTimePicker(this.components);
            this.reservationDateTimePickerLabel = new System.Windows.Forms.Label();
            this.isActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.clientNameLabel = new System.Windows.Forms.Label();
            this.clientNameTextBox = new System.Windows.Forms.TextBox();
            this.flightComboBox = new FitAirlines.UI.BaseComboBox();
            this.flightLabel = new System.Windows.Forms.Label();
            this.flightDateTimePicker = new FitAirlines.UI.BaseDateTimePicker(this.components);
            this.flightDateTimePickerLabel = new System.Windows.Forms.Label();
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
            this.dataGridView.Location = new System.Drawing.Point(12, 91);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(853, 407);
            this.dataGridView.TabIndex = 0;
            // 
            // searchImageButton
            // 
            this.searchImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchImageButton.Location = new System.Drawing.Point(592, 9);
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
            this.editImageButton.Location = new System.Drawing.Point(689, 9);
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
            this.addImageButton.Location = new System.Drawing.Point(776, 9);
            this.addImageButton.Name = "addImageButton";
            this.addImageButton.Size = new System.Drawing.Size(89, 51);
            this.addImageButton.TabIndex = 18;
            this.addImageButton.Text = "imageButton1";
            this.addImageButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addImageButton.UseVisualStyleBackColor = true;
            this.addImageButton.Click += new System.EventHandler(this.addImageButton_Click);
            // 
            // reservationDateTimePicker
            // 
            this.reservationDateTimePicker.Location = new System.Drawing.Point(218, 25);
            this.reservationDateTimePicker.Name = "reservationDateTimePicker";
            this.reservationDateTimePicker.Size = new System.Drawing.Size(183, 20);
            this.reservationDateTimePicker.TabIndex = 17;
            // 
            // reservationDateTimePickerLabel
            // 
            this.reservationDateTimePickerLabel.AutoSize = true;
            this.reservationDateTimePickerLabel.Location = new System.Drawing.Point(215, 9);
            this.reservationDateTimePickerLabel.Name = "reservationDateTimePickerLabel";
            this.reservationDateTimePickerLabel.Size = new System.Drawing.Size(35, 13);
            this.reservationDateTimePickerLabel.TabIndex = 16;
            this.reservationDateTimePickerLabel.Text = "label1";
            // 
            // isActiveCheckBox
            // 
            this.isActiveCheckBox.AutoSize = true;
            this.isActiveCheckBox.Location = new System.Drawing.Point(420, 27);
            this.isActiveCheckBox.Name = "isActiveCheckBox";
            this.isActiveCheckBox.Size = new System.Drawing.Size(80, 17);
            this.isActiveCheckBox.TabIndex = 15;
            this.isActiveCheckBox.Text = "checkBox1";
            this.isActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // clientNameLabel
            // 
            this.clientNameLabel.AutoSize = true;
            this.clientNameLabel.Location = new System.Drawing.Point(12, 9);
            this.clientNameLabel.Name = "clientNameLabel";
            this.clientNameLabel.Size = new System.Drawing.Size(35, 13);
            this.clientNameLabel.TabIndex = 14;
            this.clientNameLabel.Text = "label1";
            // 
            // clientNameTextBox
            // 
            this.clientNameTextBox.Location = new System.Drawing.Point(15, 25);
            this.clientNameTextBox.Name = "clientNameTextBox";
            this.clientNameTextBox.Size = new System.Drawing.Size(178, 20);
            this.clientNameTextBox.TabIndex = 13;
            // 
            // flightComboBox
            // 
            this.flightComboBox.FormattingEnabled = true;
            this.flightComboBox.Location = new System.Drawing.Point(15, 64);
            this.flightComboBox.Name = "flightComboBox";
            this.flightComboBox.Size = new System.Drawing.Size(178, 21);
            this.flightComboBox.TabIndex = 21;
            // 
            // flightLabel
            // 
            this.flightLabel.AutoSize = true;
            this.flightLabel.Location = new System.Drawing.Point(12, 48);
            this.flightLabel.Name = "flightLabel";
            this.flightLabel.Size = new System.Drawing.Size(35, 13);
            this.flightLabel.TabIndex = 22;
            this.flightLabel.Text = "label1";
            // 
            // flightDateTimePicker
            // 
            this.flightDateTimePicker.Location = new System.Drawing.Point(218, 64);
            this.flightDateTimePicker.Name = "flightDateTimePicker";
            this.flightDateTimePicker.Size = new System.Drawing.Size(183, 20);
            this.flightDateTimePicker.TabIndex = 24;
            // 
            // flightDateTimePickerLabel
            // 
            this.flightDateTimePickerLabel.AutoSize = true;
            this.flightDateTimePickerLabel.Location = new System.Drawing.Point(215, 48);
            this.flightDateTimePickerLabel.Name = "flightDateTimePickerLabel";
            this.flightDateTimePickerLabel.Size = new System.Drawing.Size(35, 13);
            this.flightDateTimePickerLabel.TabIndex = 23;
            this.flightDateTimePickerLabel.Text = "label1";
            // 
            // ReservationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 510);
            this.Controls.Add(this.flightDateTimePicker);
            this.Controls.Add(this.flightDateTimePickerLabel);
            this.Controls.Add(this.flightLabel);
            this.Controls.Add(this.flightComboBox);
            this.Controls.Add(this.searchImageButton);
            this.Controls.Add(this.editImageButton);
            this.Controls.Add(this.addImageButton);
            this.Controls.Add(this.reservationDateTimePicker);
            this.Controls.Add(this.reservationDateTimePickerLabel);
            this.Controls.Add(this.isActiveCheckBox);
            this.Controls.Add(this.clientNameLabel);
            this.Controls.Add(this.clientNameTextBox);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReservationsForm";
            this.Text = "ReservationsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BaseDataGridView dataGridView;
        private ImageButton searchImageButton;
        private ImageButton editImageButton;
        private ImageButton addImageButton;
        private BaseDateTimePicker reservationDateTimePicker;
        private System.Windows.Forms.Label reservationDateTimePickerLabel;
        private System.Windows.Forms.CheckBox isActiveCheckBox;
        private System.Windows.Forms.Label clientNameLabel;
        private System.Windows.Forms.TextBox clientNameTextBox;
        private BaseComboBox flightComboBox;
        private System.Windows.Forms.Label flightLabel;
        private BaseDateTimePicker flightDateTimePicker;
        private System.Windows.Forms.Label flightDateTimePickerLabel;
    }
}