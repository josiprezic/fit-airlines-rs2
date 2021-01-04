namespace FitAirlines.UI
{
    partial class OffersForm
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
            this.editImageButton = new FitAirlines.UI.ImageButton(this.components);
            this.addImageButton = new FitAirlines.UI.ImageButton(this.components);
            this.baseDataGridView1 = new FitAirlines.UI.BaseDataGridView(this.components);
            this.dateTimePickerLabel = new System.Windows.Forms.Label();
            this.isActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.offerNameLabel = new System.Windows.Forms.Label();
            this.offerNameTextBox = new System.Windows.Forms.TextBox();
            this.OfferName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShortInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.OfferTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offerDateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.baseDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // editImageButton
            // 
            this.editImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editImageButton.Location = new System.Drawing.Point(689, 15);
            this.editImageButton.Name = "editImageButton";
            this.editImageButton.Size = new System.Drawing.Size(85, 51);
            this.editImageButton.TabIndex = 11;
            this.editImageButton.Text = "imageButton2";
            this.editImageButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editImageButton.UseVisualStyleBackColor = true;
            this.editImageButton.Click += new System.EventHandler(this.editImageButton_Click);
            // 
            // addImageButton
            // 
            this.addImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addImageButton.Location = new System.Drawing.Point(776, 15);
            this.addImageButton.Name = "addImageButton";
            this.addImageButton.Size = new System.Drawing.Size(89, 52);
            this.addImageButton.TabIndex = 10;
            this.addImageButton.Text = "imageButton1";
            this.addImageButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addImageButton.UseVisualStyleBackColor = true;
            this.addImageButton.Click += new System.EventHandler(this.addImageButton_Click);
            // 
            // baseDataGridView1
            // 
            this.baseDataGridView1.AllowUserToAddRows = false;
            this.baseDataGridView1.AllowUserToResizeColumns = false;
            this.baseDataGridView1.AllowUserToResizeRows = false;
            this.baseDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.baseDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.baseDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.baseDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.baseDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OfferName,
            this.ShortInfo,
            this.StartDate,
            this.EndDate,
            this.isActive,
            this.OfferTypeId});
            this.baseDataGridView1.Location = new System.Drawing.Point(12, 77);
            this.baseDataGridView1.MultiSelect = false;
            this.baseDataGridView1.Name = "baseDataGridView1";
            this.baseDataGridView1.ReadOnly = true;
            this.baseDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.baseDataGridView1.Size = new System.Drawing.Size(853, 421);
            this.baseDataGridView1.TabIndex = 7;
            // 
            // dateTimePickerLabel
            // 
            this.dateTimePickerLabel.AutoSize = true;
            this.dateTimePickerLabel.Location = new System.Drawing.Point(215, 15);
            this.dateTimePickerLabel.Name = "dateTimePickerLabel";
            this.dateTimePickerLabel.Size = new System.Drawing.Size(107, 13);
            this.dateTimePickerLabel.TabIndex = 6;
            this.dateTimePickerLabel.Text = "dateTimePickerLabel";
            // 
            // isActiveCheckBox
            // 
            this.isActiveCheckBox.AutoSize = true;
            this.isActiveCheckBox.Location = new System.Drawing.Point(465, 33);
            this.isActiveCheckBox.Name = "isActiveCheckBox";
            this.isActiveCheckBox.Size = new System.Drawing.Size(112, 17);
            this.isActiveCheckBox.TabIndex = 4;
            this.isActiveCheckBox.Text = "isActiveCheckBox";
            this.isActiveCheckBox.UseVisualStyleBackColor = true;
            this.isActiveCheckBox.CheckedChanged += new System.EventHandler(this.isActiveCheckBox_CheckedChanged);
            // 
            // offerNameLabel
            // 
            this.offerNameLabel.AutoSize = true;
            this.offerNameLabel.Location = new System.Drawing.Point(12, 15);
            this.offerNameLabel.Name = "offerNameLabel";
            this.offerNameLabel.Size = new System.Drawing.Size(82, 13);
            this.offerNameLabel.TabIndex = 3;
            this.offerNameLabel.Text = "offerNameLabel";
            // 
            // offerNameTextBox
            // 
            this.offerNameTextBox.Location = new System.Drawing.Point(15, 31);
            this.offerNameTextBox.Name = "offerNameTextBox";
            this.offerNameTextBox.Size = new System.Drawing.Size(178, 20);
            this.offerNameTextBox.TabIndex = 2;
            this.offerNameTextBox.TextChanged += new System.EventHandler(this.offerNameTextBox_TextChanged);
            // 
            // OfferName
            // 
            this.OfferName.DataPropertyName = "OfferName";
            this.OfferName.HeaderText = "OfferName";
            this.OfferName.Name = "OfferName";
            this.OfferName.ReadOnly = true;
            // 
            // ShortInfo
            // 
            this.ShortInfo.DataPropertyName = "ShortInfo";
            this.ShortInfo.HeaderText = "Short Info";
            this.ShortInfo.Name = "ShortInfo";
            this.ShortInfo.ReadOnly = true;
            // 
            // StartDate
            // 
            this.StartDate.DataPropertyName = "StartDate";
            this.StartDate.HeaderText = "Start Date";
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            // 
            // EndDate
            // 
            this.EndDate.DataPropertyName = "EndDate";
            this.EndDate.HeaderText = "End Date";
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            // 
            // isActive
            // 
            this.isActive.DataPropertyName = "isActive";
            this.isActive.HeaderText = "Active";
            this.isActive.Name = "isActive";
            this.isActive.ReadOnly = true;
            this.isActive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // OfferTypeId
            // 
            this.OfferTypeId.DataPropertyName = "OfferType";
            this.OfferTypeId.HeaderText = "Offer Type";
            this.OfferTypeId.Name = "OfferTypeId";
            this.OfferTypeId.ReadOnly = true;
            // 
            // offerDateTimePicker
            // 
            this.offerDateTimePicker.Checked = false;
            this.offerDateTimePicker.Location = new System.Drawing.Point(218, 33);
            this.offerDateTimePicker.Name = "offerDateTimePicker";
            this.offerDateTimePicker.ShowCheckBox = true;
            this.offerDateTimePicker.Size = new System.Drawing.Size(223, 20);
            this.offerDateTimePicker.TabIndex = 12;
            this.offerDateTimePicker.ValueChanged += new System.EventHandler(this.offerDateTimePicker_ValueChanged_1);
            // 
            // OffersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 510);
            this.Controls.Add(this.offerDateTimePicker);
            this.Controls.Add(this.editImageButton);
            this.Controls.Add(this.addImageButton);
            this.Controls.Add(this.baseDataGridView1);
            this.Controls.Add(this.dateTimePickerLabel);
            this.Controls.Add(this.isActiveCheckBox);
            this.Controls.Add(this.offerNameLabel);
            this.Controls.Add(this.offerNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OffersForm";
            this.Text = "OffersForm";
            this.Load += new System.EventHandler(this.OffersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baseDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dateTimePickerLabel;
        private System.Windows.Forms.CheckBox isActiveCheckBox;
        private System.Windows.Forms.Label offerNameLabel;
        private System.Windows.Forms.TextBox offerNameTextBox;
        private BaseDataGridView baseDataGridView1;
        private ImageButton addImageButton;
        private ImageButton editImageButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn OfferName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShortInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn OfferTypeId;
        private System.Windows.Forms.DateTimePicker offerDateTimePicker;
    }
}