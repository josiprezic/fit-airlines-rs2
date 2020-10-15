namespace FitAirlines.UI
{
    partial class UsersForm
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
            this.baseDataGridView1 = new FitAirlines.UI.BaseDataGridView(this.components);
            this.nameSurnameTextBox = new System.Windows.Forms.TextBox();
            this.nameSurnameLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.memberLevelComboBox = new FitAirlines.UI.BaseComboBox();
            this.memberLevelLabel = new System.Windows.Forms.Label();
            this.isActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.searchImageButton = new FitAirlines.UI.ImageButton(this.components);
            this.editImageButton = new FitAirlines.UI.ImageButton(this.components);
            this.addImageButton = new FitAirlines.UI.ImageButton(this.components);
            this.genderComboBox = new FitAirlines.UI.BaseComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.baseDataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.baseDataGridView1.Location = new System.Drawing.Point(12, 77);
            this.baseDataGridView1.MultiSelect = false;
            this.baseDataGridView1.Name = "baseDataGridView1";
            this.baseDataGridView1.ReadOnly = true;
            this.baseDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.baseDataGridView1.Size = new System.Drawing.Size(853, 421);
            this.baseDataGridView1.TabIndex = 0;
            // 
            // nameSurnameTextBox
            // 
            this.nameSurnameTextBox.Location = new System.Drawing.Point(12, 33);
            this.nameSurnameTextBox.Name = "nameSurnameTextBox";
            this.nameSurnameTextBox.Size = new System.Drawing.Size(194, 20);
            this.nameSurnameTextBox.TabIndex = 1;
            // 
            // nameSurnameLabel
            // 
            this.nameSurnameLabel.AutoSize = true;
            this.nameSurnameLabel.Location = new System.Drawing.Point(9, 17);
            this.nameSurnameLabel.Name = "nameSurnameLabel";
            this.nameSurnameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameSurnameLabel.TabIndex = 2;
            this.nameSurnameLabel.Text = "label1";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(209, 17);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(35, 13);
            this.genderLabel.TabIndex = 4;
            this.genderLabel.Text = "label2";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(191, 33);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(0, 20);
            this.textBox2.TabIndex = 3;
            // 
            // memberLevelComboBox
            // 
            this.memberLevelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.memberLevelComboBox.FormattingEnabled = true;
            this.memberLevelComboBox.Location = new System.Drawing.Point(340, 32);
            this.memberLevelComboBox.Name = "memberLevelComboBox";
            this.memberLevelComboBox.Size = new System.Drawing.Size(121, 21);
            this.memberLevelComboBox.TabIndex = 6;
            // 
            // memberLevelLabel
            // 
            this.memberLevelLabel.AutoSize = true;
            this.memberLevelLabel.Location = new System.Drawing.Point(337, 16);
            this.memberLevelLabel.Name = "memberLevelLabel";
            this.memberLevelLabel.Size = new System.Drawing.Size(35, 13);
            this.memberLevelLabel.TabIndex = 7;
            this.memberLevelLabel.Text = "label3";
            // 
            // isActiveCheckBox
            // 
            this.isActiveCheckBox.AutoSize = true;
            this.isActiveCheckBox.Location = new System.Drawing.Point(467, 33);
            this.isActiveCheckBox.Name = "isActiveCheckBox";
            this.isActiveCheckBox.Size = new System.Drawing.Size(80, 17);
            this.isActiveCheckBox.TabIndex = 8;
            this.isActiveCheckBox.Text = "checkBox1";
            this.isActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // searchImageButton
            // 
            this.searchImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchImageButton.Location = new System.Drawing.Point(592, 12);
            this.searchImageButton.Name = "searchImageButton";
            this.searchImageButton.Size = new System.Drawing.Size(95, 51);
            this.searchImageButton.TabIndex = 15;
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
            this.editImageButton.TabIndex = 14;
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
            this.addImageButton.TabIndex = 13;
            this.addImageButton.Text = "imageButton1";
            this.addImageButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addImageButton.UseVisualStyleBackColor = true;
            this.addImageButton.Click += new System.EventHandler(this.addImageButton_Click);
            // 
            // genderComboBox
            // 
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "All",
            "M",
            "Z"});
            this.genderComboBox.Location = new System.Drawing.Point(213, 32);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(121, 21);
            this.genderComboBox.TabIndex = 16;
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 510);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.searchImageButton);
            this.Controls.Add(this.editImageButton);
            this.Controls.Add(this.addImageButton);
            this.Controls.Add(this.isActiveCheckBox);
            this.Controls.Add(this.memberLevelLabel);
            this.Controls.Add(this.memberLevelComboBox);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.nameSurnameLabel);
            this.Controls.Add(this.nameSurnameTextBox);
            this.Controls.Add(this.baseDataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UsersForm";
            this.Text = "UsersForm";
            this.Load += new System.EventHandler(this.UsersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baseDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BaseDataGridView baseDataGridView1;
        private System.Windows.Forms.TextBox nameSurnameTextBox;
        private System.Windows.Forms.Label nameSurnameLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.TextBox textBox2;
        private BaseComboBox memberLevelComboBox;
        private System.Windows.Forms.Label memberLevelLabel;
        private System.Windows.Forms.CheckBox isActiveCheckBox;
        private ImageButton searchImageButton;
        private ImageButton editImageButton;
        private ImageButton addImageButton;
        private BaseComboBox genderComboBox;
    }
}