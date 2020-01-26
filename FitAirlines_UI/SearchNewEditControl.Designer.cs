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
            this.imageButton1 = new FitAirlines_UI.ImageButton(this.components);
            this.imageButton2 = new FitAirlines_UI.ImageButton(this.components);
            this.imageButton3 = new FitAirlines_UI.ImageButton(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.imageButton1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.imageButton2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.imageButton3, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(497, 177);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // imageButton1
            // 
            this.imageButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageButton1.Image = ((System.Drawing.Image)(resources.GetObject("imageButton1.Image")));
            this.imageButton1.Location = new System.Drawing.Point(3, 3);
            this.imageButton1.Name = "imageButton1";
            this.imageButton1.Size = new System.Drawing.Size(159, 171);
            this.imageButton1.TabIndex = 0;
            this.imageButton1.Text = "imageButton1";
            this.imageButton1.UseVisualStyleBackColor = true;
            // 
            // imageButton2
            // 
            this.imageButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageButton2.Image = ((System.Drawing.Image)(resources.GetObject("imageButton2.Image")));
            this.imageButton2.Location = new System.Drawing.Point(168, 3);
            this.imageButton2.Name = "imageButton2";
            this.imageButton2.Size = new System.Drawing.Size(159, 171);
            this.imageButton2.TabIndex = 1;
            this.imageButton2.Text = "imageButton2";
            this.imageButton2.UseVisualStyleBackColor = true;
            // 
            // imageButton3
            // 
            this.imageButton3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageButton3.Image = ((System.Drawing.Image)(resources.GetObject("imageButton3.Image")));
            this.imageButton3.Location = new System.Drawing.Point(333, 3);
            this.imageButton3.Name = "imageButton3";
            this.imageButton3.Size = new System.Drawing.Size(161, 171);
            this.imageButton3.TabIndex = 2;
            this.imageButton3.Text = "imageButton3";
            this.imageButton3.UseVisualStyleBackColor = true;
            // 
            // SearchNewEditControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SearchNewEditControl";
            this.Size = new System.Drawing.Size(497, 177);
            this.Load += new System.EventHandler(this.SearchNewEditControl_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ImageButton imageButton1;
        private ImageButton imageButton2;
        private ImageButton imageButton3;
    }
}
