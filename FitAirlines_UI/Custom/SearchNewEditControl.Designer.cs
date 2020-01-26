namespace FitAirlines_UI
{
    partial class SearchNewEditControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchNewEditControl));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.searchImageButton = new FitAirlines_UI.ImageButton(this.components);
            this.newImageButton = new FitAirlines_UI.ImageButton(this.components);
            this.editImageButton = new FitAirlines_UI.ImageButton(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.searchImageButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.newImageButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.editImageButton, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(497, 177);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // searchImageButton
            // 
            this.searchImageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchImageButton.Image = ((System.Drawing.Image)(resources.GetObject("searchImageButton.Image")));
            this.searchImageButton.Location = new System.Drawing.Point(3, 3);
            this.searchImageButton.Name = "searchImageButton";
            this.searchImageButton.Size = new System.Drawing.Size(159, 171);
            this.searchImageButton.TabIndex = 0;
            this.searchImageButton.Text = "imageButton1";
            this.searchImageButton.UseVisualStyleBackColor = true;
            // 
            // newImageButton
            // 
            this.newImageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newImageButton.Image = ((System.Drawing.Image)(resources.GetObject("newImageButton.Image")));
            this.newImageButton.Location = new System.Drawing.Point(168, 3);
            this.newImageButton.Name = "newImageButton";
            this.newImageButton.Size = new System.Drawing.Size(159, 171);
            this.newImageButton.TabIndex = 1;
            this.newImageButton.Text = "imageButton2";
            this.newImageButton.UseVisualStyleBackColor = true;
            // 
            // editImageButton
            // 
            this.editImageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editImageButton.Image = ((System.Drawing.Image)(resources.GetObject("editImageButton.Image")));
            this.editImageButton.Location = new System.Drawing.Point(333, 3);
            this.editImageButton.Name = "editImageButton";
            this.editImageButton.Size = new System.Drawing.Size(161, 171);
            this.editImageButton.TabIndex = 2;
            this.editImageButton.Text = "imageButton3";
            this.editImageButton.UseVisualStyleBackColor = true;
            // 
            // SearchNewEditControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SearchNewEditControl";
            this.Size = new System.Drawing.Size(497, 177);
            this.Load += new System.EventHandler(this.SearchNewEditControl_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ImageButton searchImageButton;
        private ImageButton newImageButton;
        private ImageButton editImageButton;
    }
}
