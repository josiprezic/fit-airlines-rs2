namespace FitAirlines_UI
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.settingsButton = new FitAirlines_UI.CustomViews.MainMenuButton();
            this.reservationsButton = new FitAirlines_UI.CustomViews.MainMenuButton();
            this.offersButton = new FitAirlines_UI.CustomViews.MainMenuButton();
            this.usersButton = new FitAirlines_UI.CustomViews.MainMenuButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.settingsButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.reservationsButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.offersButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.usersButton, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 426);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // settingsButton
            // 
            this.settingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsButton.BackColor = System.Drawing.Color.Blue;
            this.settingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.settingsButton.ForeColor = System.Drawing.Color.White;
            this.settingsButton.Location = new System.Drawing.Point(391, 216);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(382, 207);
            this.settingsButton.TabIndex = 3;
            this.settingsButton.Text = "mainMenuButton4";
            this.settingsButton.UseVisualStyleBackColor = false;
            // 
            // reservationsButton
            // 
            this.reservationsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reservationsButton.BackColor = System.Drawing.Color.Blue;
            this.reservationsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.reservationsButton.ForeColor = System.Drawing.Color.White;
            this.reservationsButton.Location = new System.Drawing.Point(391, 3);
            this.reservationsButton.Name = "reservationsButton";
            this.reservationsButton.Size = new System.Drawing.Size(382, 207);
            this.reservationsButton.TabIndex = 4;
            this.reservationsButton.Text = "mainMenuButton2";
            this.reservationsButton.UseVisualStyleBackColor = false;
            // 
            // offersButton
            // 
            this.offersButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.offersButton.BackColor = System.Drawing.Color.Blue;
            this.offersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.offersButton.ForeColor = System.Drawing.Color.White;
            this.offersButton.Location = new System.Drawing.Point(3, 3);
            this.offersButton.Name = "offersButton";
            this.offersButton.Size = new System.Drawing.Size(382, 207);
            this.offersButton.TabIndex = 5;
            this.offersButton.Text = "mainMenuButton1";
            this.offersButton.UseVisualStyleBackColor = false;
            // 
            // usersButton
            // 
            this.usersButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usersButton.BackColor = System.Drawing.Color.Blue;
            this.usersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.usersButton.ForeColor = System.Drawing.Color.White;
            this.usersButton.Location = new System.Drawing.Point(3, 216);
            this.usersButton.Name = "usersButton";
            this.usersButton.Size = new System.Drawing.Size(382, 207);
            this.usersButton.TabIndex = 6;
            this.usersButton.Text = "mainMenuButton3";
            this.usersButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CustomViews.MainMenuButton settingsButton;
        private CustomViews.MainMenuButton reservationsButton;
        private CustomViews.MainMenuButton offersButton;
        private CustomViews.MainMenuButton usersButton;
    }
}

