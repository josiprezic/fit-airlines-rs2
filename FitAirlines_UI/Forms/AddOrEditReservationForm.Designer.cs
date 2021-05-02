namespace FitAirlines.UI
{
    partial class AddOrEditReservationForm
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
            this.clientLabel = new System.Windows.Forms.Label();
            this.clientComboBox = new FitAirlines.UI.BaseComboBox();
            this.offerComboBox = new FitAirlines.UI.BaseComboBox();
            this.offerLabel = new System.Windows.Forms.Label();
            this.flightComboBox = new FitAirlines.UI.BaseComboBox();
            this.flightLabel = new System.Windows.Forms.Label();
            this.seatStartLabel = new System.Windows.Forms.Label();
            this.seatReturnLabel = new System.Windows.Forms.Label();
            this.isActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.priceTitleLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.cancelButton = new FitAirlines.UI.BaseButton();
            this.saveButton = new FitAirlines.UI.BaseButton();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.notesLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.returnSeatComboBox = new FitAirlines.UI.BaseComboBox();
            this.departureSeatComboBox = new FitAirlines.UI.BaseComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.Location = new System.Drawing.Point(6, 20);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(33, 13);
            this.clientLabel.TabIndex = 0;
            this.clientLabel.Text = "Client";
            // 
            // clientComboBox
            // 
            this.clientComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientComboBox.FormattingEnabled = true;
            this.clientComboBox.Location = new System.Drawing.Point(9, 37);
            this.clientComboBox.Name = "clientComboBox";
            this.clientComboBox.Size = new System.Drawing.Size(231, 21);
            this.clientComboBox.TabIndex = 1;
            this.clientComboBox.SelectedIndexChanged += new System.EventHandler(this.clientComboBox_SelectedIndexChanged);
            // 
            // offerComboBox
            // 
            this.offerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.offerComboBox.FormattingEnabled = true;
            this.offerComboBox.Location = new System.Drawing.Point(9, 85);
            this.offerComboBox.Name = "offerComboBox";
            this.offerComboBox.Size = new System.Drawing.Size(231, 21);
            this.offerComboBox.TabIndex = 3;
            this.offerComboBox.SelectedIndexChanged += new System.EventHandler(this.offerComboBox_SelectedIndexChanged);
            // 
            // offerLabel
            // 
            this.offerLabel.AutoSize = true;
            this.offerLabel.Location = new System.Drawing.Point(6, 68);
            this.offerLabel.Name = "offerLabel";
            this.offerLabel.Size = new System.Drawing.Size(30, 13);
            this.offerLabel.TabIndex = 2;
            this.offerLabel.Text = "Offer";
            // 
            // flightComboBox
            // 
            this.flightComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.flightComboBox.FormattingEnabled = true;
            this.flightComboBox.Location = new System.Drawing.Point(9, 133);
            this.flightComboBox.Name = "flightComboBox";
            this.flightComboBox.Size = new System.Drawing.Size(231, 21);
            this.flightComboBox.TabIndex = 5;
            this.flightComboBox.SelectedIndexChanged += new System.EventHandler(this.flightComboBox_SelectedIndexChanged);
            // 
            // flightLabel
            // 
            this.flightLabel.AutoSize = true;
            this.flightLabel.Location = new System.Drawing.Point(6, 116);
            this.flightLabel.Name = "flightLabel";
            this.flightLabel.Size = new System.Drawing.Size(32, 13);
            this.flightLabel.TabIndex = 4;
            this.flightLabel.Text = "Flight";
            // 
            // seatStartLabel
            // 
            this.seatStartLabel.AutoSize = true;
            this.seatStartLabel.Location = new System.Drawing.Point(6, 170);
            this.seatStartLabel.Name = "seatStartLabel";
            this.seatStartLabel.Size = new System.Drawing.Size(77, 13);
            this.seatStartLabel.TabIndex = 7;
            this.seatStartLabel.Text = "Departure seat";
            // 
            // seatReturnLabel
            // 
            this.seatReturnLabel.AutoSize = true;
            this.seatReturnLabel.Location = new System.Drawing.Point(6, 216);
            this.seatReturnLabel.Name = "seatReturnLabel";
            this.seatReturnLabel.Size = new System.Drawing.Size(62, 13);
            this.seatReturnLabel.TabIndex = 9;
            this.seatReturnLabel.Text = "Return seat";
            // 
            // isActiveCheckBox
            // 
            this.isActiveCheckBox.AutoSize = true;
            this.isActiveCheckBox.Checked = true;
            this.isActiveCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isActiveCheckBox.Location = new System.Drawing.Point(12, 170);
            this.isActiveCheckBox.Name = "isActiveCheckBox";
            this.isActiveCheckBox.Size = new System.Drawing.Size(56, 17);
            this.isActiveCheckBox.TabIndex = 13;
            this.isActiveCheckBox.Text = "Active";
            this.isActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // priceTitleLabel
            // 
            this.priceTitleLabel.AutoSize = true;
            this.priceTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTitleLabel.Location = new System.Drawing.Point(6, 20);
            this.priceTitleLabel.Name = "priceTitleLabel";
            this.priceTitleLabel.Size = new System.Drawing.Size(119, 25);
            this.priceTitleLabel.TabIndex = 14;
            this.priceTitleLabel.Text = "Total price:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(6, 45);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(112, 31);
            this.priceLabel.TabIndex = 15;
            this.priceLabel.Text = "9999.99";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(6, 192);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(188, 37);
            this.cancelButton.TabIndex = 16;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(6, 235);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(188, 37);
            this.saveButton.TabIndex = 17;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // notesTextBox
            // 
            this.notesTextBox.Location = new System.Drawing.Point(9, 101);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(185, 63);
            this.notesTextBox.TabIndex = 20;
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Location = new System.Drawing.Point(6, 85);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(35, 13);
            this.notesLabel.TabIndex = 21;
            this.notesLabel.Text = "Notes";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.returnSeatComboBox);
            this.groupBox1.Controls.Add(this.departureSeatComboBox);
            this.groupBox1.Controls.Add(this.clientLabel);
            this.groupBox1.Controls.Add(this.clientComboBox);
            this.groupBox1.Controls.Add(this.offerLabel);
            this.groupBox1.Controls.Add(this.offerComboBox);
            this.groupBox1.Controls.Add(this.flightLabel);
            this.groupBox1.Controls.Add(this.flightComboBox);
            this.groupBox1.Controls.Add(this.seatStartLabel);
            this.groupBox1.Controls.Add(this.seatReturnLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 280);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic information";
            // 
            // returnSeatComboBox
            // 
            this.returnSeatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.returnSeatComboBox.FormattingEnabled = true;
            this.returnSeatComboBox.Location = new System.Drawing.Point(6, 232);
            this.returnSeatComboBox.Name = "returnSeatComboBox";
            this.returnSeatComboBox.Size = new System.Drawing.Size(234, 21);
            this.returnSeatComboBox.TabIndex = 21;
            // 
            // departureSeatComboBox
            // 
            this.departureSeatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departureSeatComboBox.FormattingEnabled = true;
            this.departureSeatComboBox.Location = new System.Drawing.Point(6, 186);
            this.departureSeatComboBox.Name = "departureSeatComboBox";
            this.departureSeatComboBox.Size = new System.Drawing.Size(234, 21);
            this.departureSeatComboBox.TabIndex = 20;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.priceTitleLabel);
            this.groupBox2.Controls.Add(this.notesLabel);
            this.groupBox2.Controls.Add(this.isActiveCheckBox);
            this.groupBox2.Controls.Add(this.notesTextBox);
            this.groupBox2.Controls.Add(this.saveButton);
            this.groupBox2.Controls.Add(this.priceLabel);
            this.groupBox2.Controls.Add(this.cancelButton);
            this.groupBox2.Location = new System.Drawing.Point(270, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 280);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment information";
            // 
            // AddOrEditReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 300);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddOrEditReservationForm";
            this.Text = "Reservation Details";
            this.Load += new System.EventHandler(this.AddOrEditReservationForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label clientLabel;
        private BaseComboBox clientComboBox;
        private BaseComboBox offerComboBox;
        private System.Windows.Forms.Label offerLabel;
        private BaseComboBox flightComboBox;
        private System.Windows.Forms.Label flightLabel;
        private System.Windows.Forms.Label seatStartLabel;
        private System.Windows.Forms.Label seatReturnLabel;
        private System.Windows.Forms.CheckBox isActiveCheckBox;
        private System.Windows.Forms.Label priceTitleLabel;
        private System.Windows.Forms.Label priceLabel;
        private BaseButton cancelButton;
        private BaseButton saveButton;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private BaseComboBox returnSeatComboBox;
        private BaseComboBox departureSeatComboBox;
    }
}