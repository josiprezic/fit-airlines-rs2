namespace FitAirlines_UI
{
    partial class BaseDataGridViewForm
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.searchNewEditControl1 = new FitAirlines_UI.SearchNewEditControl();
            this.baseDataGridView1 = new FitAirlines_UI.BaseDataGridView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baseDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.Location = new System.Drawing.Point(11, 11);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.searchNewEditControl1);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.baseDataGridView1);
            this.splitContainer.Size = new System.Drawing.Size(875, 569);
            this.splitContainer.SplitterDistance = 75;
            this.splitContainer.SplitterWidth = 3;
            this.splitContainer.TabIndex = 0;
            // 
            // searchNewEditControl1
            // 
            this.searchNewEditControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchNewEditControl1.Location = new System.Drawing.Point(589, 0);
            this.searchNewEditControl1.Margin = new System.Windows.Forms.Padding(2);
            this.searchNewEditControl1.Name = "searchNewEditControl1";
            this.searchNewEditControl1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.searchNewEditControl1.Size = new System.Drawing.Size(286, 75);
            this.searchNewEditControl1.TabIndex = 0;
            // 
            // baseDataGridView1
            // 
            this.baseDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.baseDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.baseDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.baseDataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.baseDataGridView1.Name = "baseDataGridView1";
            this.baseDataGridView1.RowHeadersWidth = 51;
            this.baseDataGridView1.RowTemplate.Height = 24;
            this.baseDataGridView1.Size = new System.Drawing.Size(875, 491);
            this.baseDataGridView1.TabIndex = 0;
            // 
            // BaseDataGridViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 591);
            this.Controls.Add(this.splitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BaseDataGridViewForm";
            this.Text = "BaseDataGridViewForm";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.baseDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private BaseDataGridView baseDataGridView1;
        private SearchNewEditControl searchNewEditControl1;
    }
}