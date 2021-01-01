namespace FitAirlines.UI.Forms
{
    partial class UserCreditForm
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
            this.creditNameLabel = new System.Windows.Forms.Label();
            this.creditValueLabel = new System.Windows.Forms.Label();
            this.addCreditLabel = new System.Windows.Forms.Label();
            this.updateCreditLabel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.creditValueNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.creditValueNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // creditNameLabel
            // 
            this.creditNameLabel.AutoSize = true;
            this.creditNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditNameLabel.Location = new System.Drawing.Point(33, 33);
            this.creditNameLabel.Name = "creditNameLabel";
            this.creditNameLabel.Size = new System.Drawing.Size(191, 31);
            this.creditNameLabel.TabIndex = 0;
            this.creditNameLabel.Text = "Credit (BAM):";
            // 
            // creditValueLabel
            // 
            this.creditValueLabel.AutoSize = true;
            this.creditValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditValueLabel.Location = new System.Drawing.Point(263, 33);
            this.creditValueLabel.Name = "creditValueLabel";
            this.creditValueLabel.Size = new System.Drawing.Size(78, 31);
            this.creditValueLabel.TabIndex = 1;
            this.creditValueLabel.Text = "9999";
            // 
            // addCreditLabel
            // 
            this.addCreditLabel.AutoSize = true;
            this.addCreditLabel.Location = new System.Drawing.Point(36, 101);
            this.addCreditLabel.Name = "addCreditLabel";
            this.addCreditLabel.Size = new System.Drawing.Size(58, 13);
            this.addCreditLabel.TabIndex = 2;
            this.addCreditLabel.Text = "Add credit:";
            // 
            // updateCreditLabel
            // 
            this.updateCreditLabel.Location = new System.Drawing.Point(267, 97);
            this.updateCreditLabel.Name = "updateCreditLabel";
            this.updateCreditLabel.Size = new System.Drawing.Size(117, 23);
            this.updateCreditLabel.TabIndex = 6;
            this.updateCreditLabel.Text = "Update Credit";
            this.updateCreditLabel.UseVisualStyleBackColor = true;
            this.updateCreditLabel.Click += new System.EventHandler(this.updateCreditLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 8;
            // 
            // creditValueNumericUpDown
            // 
            this.creditValueNumericUpDown.Location = new System.Drawing.Point(133, 98);
            this.creditValueNumericUpDown.Name = "creditValueNumericUpDown";
            this.creditValueNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.creditValueNumericUpDown.TabIndex = 9;
            // 
            // UserCreditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 149);
            this.Controls.Add(this.creditValueNumericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateCreditLabel);
            this.Controls.Add(this.addCreditLabel);
            this.Controls.Add(this.creditValueLabel);
            this.Controls.Add(this.creditNameLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserCreditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "User Credit";
            ((System.ComponentModel.ISupportInitialize)(this.creditValueNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label creditNameLabel;
        private System.Windows.Forms.Label creditValueLabel;
        private System.Windows.Forms.Label addCreditLabel;
        private System.Windows.Forms.Button updateCreditLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown creditValueNumericUpDown;
    }
}