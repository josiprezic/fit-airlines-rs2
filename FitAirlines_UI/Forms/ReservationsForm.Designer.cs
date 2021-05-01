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
            this.dgvReservations = new FitAirlines.UI.BaseDataGridView(this.components);
            this.ClientType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlightOffer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeatDeparture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeatReturn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TicketPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReservations
            // 
            this.dgvReservations.AllowUserToAddRows = false;
            this.dgvReservations.AllowUserToResizeColumns = false;
            this.dgvReservations.AllowUserToResizeRows = false;
            this.dgvReservations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReservations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReservations.BackgroundColor = System.Drawing.Color.White;
            this.dgvReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientType,
            this.FlightOffer,
            this.Date,
            this.SeatDeparture,
            this.SeatReturn,
            this.Discount,
            this.Active,
            this.TicketPrice,
            this.Action});
            this.dgvReservations.Location = new System.Drawing.Point(12, 91);
            this.dgvReservations.MultiSelect = false;
            this.dgvReservations.Name = "dgvReservations";
            this.dgvReservations.ReadOnly = true;
            this.dgvReservations.RowTemplate.Height = 35;
            this.dgvReservations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservations.Size = new System.Drawing.Size(853, 407);
            this.dgvReservations.TabIndex = 0;
            // 
            // ClientType
            // 
            this.ClientType.DataPropertyName = "ClientType";
            this.ClientType.HeaderText = "Client (Type)";
            this.ClientType.Name = "ClientType";
            this.ClientType.ReadOnly = true;
            // 
            // FlightOffer
            // 
            this.FlightOffer.DataPropertyName = "FlightOffer";
            this.FlightOffer.HeaderText = "Flight (Offer)";
            this.FlightOffer.Name = "FlightOffer";
            this.FlightOffer.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "ReservationDate";
            this.Date.HeaderText = "Reservation Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // SeatDeparture
            // 
            this.SeatDeparture.DataPropertyName = "SeatDeparture";
            this.SeatDeparture.HeaderText = "Seat (Departure)";
            this.SeatDeparture.Name = "SeatDeparture";
            this.SeatDeparture.ReadOnly = true;
            // 
            // SeatReturn
            // 
            this.SeatReturn.DataPropertyName = "SeatReturn";
            this.SeatReturn.HeaderText = "Seat (Return)";
            this.SeatReturn.Name = "SeatReturn";
            this.SeatReturn.ReadOnly = true;
            // 
            // Discount
            // 
            this.Discount.DataPropertyName = "Discount";
            this.Discount.HeaderText = "Discount";
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            // 
            // Active
            // 
            this.Active.DataPropertyName = "IsValid";
            this.Active.HeaderText = "Active";
            this.Active.Name = "Active";
            this.Active.ReadOnly = true;
            this.Active.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Active.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // TicketPrice
            // 
            this.TicketPrice.DataPropertyName = "TicketPrice";
            this.TicketPrice.HeaderText = "Ticket Price";
            this.TicketPrice.Name = "TicketPrice";
            this.TicketPrice.ReadOnly = true;
            // 
            // Action
            // 
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            this.Action.Text = "Report";
            this.Action.UseColumnTextForButtonValue = true;
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
            this.reservationDateTimePicker.Checked = false;
            this.reservationDateTimePicker.Location = new System.Drawing.Point(218, 25);
            this.reservationDateTimePicker.Name = "reservationDateTimePicker";
            this.reservationDateTimePicker.ShowCheckBox = true;
            this.reservationDateTimePicker.Size = new System.Drawing.Size(221, 20);
            this.reservationDateTimePicker.TabIndex = 17;
            this.reservationDateTimePicker.ValueChanged += new System.EventHandler(this.reservationDateTimePicker_ValueChanged);
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
            this.isActiveCheckBox.Location = new System.Drawing.Point(458, 27);
            this.isActiveCheckBox.Name = "isActiveCheckBox";
            this.isActiveCheckBox.Size = new System.Drawing.Size(80, 17);
            this.isActiveCheckBox.TabIndex = 15;
            this.isActiveCheckBox.Text = "checkBox1";
            this.isActiveCheckBox.UseVisualStyleBackColor = true;
            this.isActiveCheckBox.CheckedChanged += new System.EventHandler(this.isActiveCheckBox_CheckedChanged);
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
            this.clientNameTextBox.TextChanged += new System.EventHandler(this.clientNameTextBox_TextChanged);
            // 
            // flightComboBox
            // 
            this.flightComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.flightComboBox.FormattingEnabled = true;
            this.flightComboBox.Location = new System.Drawing.Point(15, 64);
            this.flightComboBox.Name = "flightComboBox";
            this.flightComboBox.Size = new System.Drawing.Size(178, 21);
            this.flightComboBox.TabIndex = 21;
            this.flightComboBox.SelectedIndexChanged += new System.EventHandler(this.flightComboBox_SelectedIndexChanged);
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
            // ReservationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 510);
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
            this.Controls.Add(this.dgvReservations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReservationsForm";
            this.Text = "ReservationsForm";
            this.Load += new System.EventHandler(this.ReservationsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BaseDataGridView dgvReservations;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientType;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightOffer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeatDeparture;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeatReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Active;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketPrice;
        private System.Windows.Forms.DataGridViewButtonColumn Action;
    }
}