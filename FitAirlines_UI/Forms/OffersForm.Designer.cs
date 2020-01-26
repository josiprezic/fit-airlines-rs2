namespace FitAirlines_UI
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
            this.dateTimePickerLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.isActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.offerNameLabel = new System.Windows.Forms.Label();
            this.offerNameTextBox = new System.Windows.Forms.TextBox();
            this.baseDataGridView1 = new FitAirlines_UI.BaseDataGridView(this.components);
            this.searchNewEditControl1 = new FitAirlines_UI.SearchNewEditControl();
            ((System.ComponentModel.ISupportInitialize)(this.baseDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerLabel
            // 
            this.dateTimePickerLabel.AutoSize = true;
            this.dateTimePickerLabel.Location = new System.Drawing.Point(215, 15);
            this.dateTimePickerLabel.Name = "dateTimePickerLabel";
            this.dateTimePickerLabel.Size = new System.Drawing.Size(35, 13);
            this.dateTimePickerLabel.TabIndex = 6;
            this.dateTimePickerLabel.Text = "label1";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(218, 31);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 5;
            // 
            // isActiveCheckBox
            // 
            this.isActiveCheckBox.AutoSize = true;
            this.isActiveCheckBox.Location = new System.Drawing.Point(439, 33);
            this.isActiveCheckBox.Name = "isActiveCheckBox";
            this.isActiveCheckBox.Size = new System.Drawing.Size(80, 17);
            this.isActiveCheckBox.TabIndex = 4;
            this.isActiveCheckBox.Text = "checkBox1";
            this.isActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // offerNameLabel
            // 
            this.offerNameLabel.AutoSize = true;
            this.offerNameLabel.Location = new System.Drawing.Point(12, 15);
            this.offerNameLabel.Name = "offerNameLabel";
            this.offerNameLabel.Size = new System.Drawing.Size(35, 13);
            this.offerNameLabel.TabIndex = 3;
            this.offerNameLabel.Text = "label1";
            // 
            // offerNameTextBox
            // 
            this.offerNameTextBox.Location = new System.Drawing.Point(15, 31);
            this.offerNameTextBox.Name = "offerNameTextBox";
            this.offerNameTextBox.Size = new System.Drawing.Size(178, 20);
            this.offerNameTextBox.TabIndex = 2;
            // 
            // baseDataGridView1
            // 
            this.baseDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.baseDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.baseDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.baseDataGridView1.Location = new System.Drawing.Point(12, 77);
            this.baseDataGridView1.Name = "baseDataGridView1";
            this.baseDataGridView1.Size = new System.Drawing.Size(853, 421);
            this.baseDataGridView1.TabIndex = 7;
            // 
            // searchNewEditControl1
            // 
            this.searchNewEditControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchNewEditControl1.Location = new System.Drawing.Point(561, 17);
            this.searchNewEditControl1.Margin = new System.Windows.Forms.Padding(2);
            this.searchNewEditControl1.Name = "searchNewEditControl1";
            this.searchNewEditControl1.Size = new System.Drawing.Size(308, 44);
            this.searchNewEditControl1.TabIndex = 8;
            // 
            // OffersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 510);
            this.Controls.Add(this.searchNewEditControl1);
            this.Controls.Add(this.baseDataGridView1);
            this.Controls.Add(this.dateTimePickerLabel);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.isActiveCheckBox);
            this.Controls.Add(this.offerNameLabel);
            this.Controls.Add(this.offerNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "OffersForm";
            this.Text = "OffersForm";
            ((System.ComponentModel.ISupportInitialize)(this.baseDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dateTimePickerLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.CheckBox isActiveCheckBox;
        private System.Windows.Forms.Label offerNameLabel;
        private System.Windows.Forms.TextBox offerNameTextBox;
        private BaseDataGridView baseDataGridView1;
        private SearchNewEditControl searchNewEditControl1;
    }
}