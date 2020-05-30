namespace FitAirlines_UI
{
    partial class MainMenuForm
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
            this.flightsButton = new FitAirlines_UI.CustomViews.MainMenuButton();
            this.mainMenuButton2 = new FitAirlines_UI.CustomViews.MainMenuButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.Controls.Add(this.settingsButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.reservationsButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.offersButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.usersButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flightsButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.mainMenuButton2, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 10);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(582, 346);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // settingsButton
            // 
            this.settingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsButton.BackColor = System.Drawing.Color.Blue;
            this.settingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.settingsButton.ForeColor = System.Drawing.Color.White;
            this.settingsButton.Location = new System.Drawing.Point(194, 175);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(2);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(188, 169);
            this.settingsButton.TabIndex = 3;
            this.settingsButton.Text = "MAINMENUBUTTON4";
            this.settingsButton.UseVisualStyleBackColor = false;
            // 
            // reservationsButton
            // 
            this.reservationsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reservationsButton.BackColor = System.Drawing.Color.Blue;
            this.reservationsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.reservationsButton.ForeColor = System.Drawing.Color.White;
            this.reservationsButton.Location = new System.Drawing.Point(2, 2);
            this.reservationsButton.Margin = new System.Windows.Forms.Padding(2);
            this.reservationsButton.Name = "reservationsButton";
            this.reservationsButton.Size = new System.Drawing.Size(188, 169);
            this.reservationsButton.TabIndex = 4;
            this.reservationsButton.Text = "MAINMENUBUTTON2";
            this.reservationsButton.UseVisualStyleBackColor = false;
            this.reservationsButton.Click += new System.EventHandler(this.reservationsButton_Click);
            // 
            // offersButton
            // 
            this.offersButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.offersButton.BackColor = System.Drawing.Color.Blue;
            this.offersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.offersButton.ForeColor = System.Drawing.Color.White;
            this.offersButton.Location = new System.Drawing.Point(194, 2);
            this.offersButton.Margin = new System.Windows.Forms.Padding(2);
            this.offersButton.Name = "offersButton";
            this.offersButton.Size = new System.Drawing.Size(188, 169);
            this.offersButton.TabIndex = 5;
            this.offersButton.Text = "MAINMENUBUTTON1";
            this.offersButton.UseVisualStyleBackColor = false;
            this.offersButton.Click += new System.EventHandler(this.offersButton_Click);
            // 
            // usersButton
            // 
            this.usersButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usersButton.BackColor = System.Drawing.Color.Blue;
            this.usersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.usersButton.ForeColor = System.Drawing.Color.White;
            this.usersButton.Location = new System.Drawing.Point(2, 175);
            this.usersButton.Margin = new System.Windows.Forms.Padding(2);
            this.usersButton.Name = "usersButton";
            this.usersButton.Size = new System.Drawing.Size(188, 169);
            this.usersButton.TabIndex = 6;
            this.usersButton.Text = "MAINMENUBUTTON3";
            this.usersButton.UseVisualStyleBackColor = false;
            this.usersButton.Click += new System.EventHandler(this.usersButton_Click);
            // 
            // flightsButton
            // 
            this.flightsButton.BackColor = System.Drawing.Color.Blue;
            this.flightsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flightsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.flightsButton.ForeColor = System.Drawing.Color.White;
            this.flightsButton.Location = new System.Drawing.Point(387, 3);
            this.flightsButton.Name = "flightsButton";
            this.flightsButton.Size = new System.Drawing.Size(192, 167);
            this.flightsButton.TabIndex = 7;
            this.flightsButton.Text = "MAINMENUBUTTON1";
            this.flightsButton.UseVisualStyleBackColor = false;
            this.flightsButton.Click += new System.EventHandler(this.flightsButton_Click);
            // 
            // mainMenuButton2
            // 
            this.mainMenuButton2.BackColor = System.Drawing.Color.Blue;
            this.mainMenuButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainMenuButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.mainMenuButton2.ForeColor = System.Drawing.Color.White;
            this.mainMenuButton2.Location = new System.Drawing.Point(387, 176);
            this.mainMenuButton2.Name = "mainMenuButton2";
            this.mainMenuButton2.Size = new System.Drawing.Size(192, 167);
            this.mainMenuButton2.TabIndex = 8;
            this.mainMenuButton2.Text = "MAINMENUBUTTON2";
            this.mainMenuButton2.UseVisualStyleBackColor = false;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenuForm";
            this.Text = "Main Menu";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CustomViews.MainMenuButton settingsButton;
        private CustomViews.MainMenuButton reservationsButton;
        private CustomViews.MainMenuButton offersButton;
        private CustomViews.MainMenuButton usersButton;
        private CustomViews.MainMenuButton flightsButton;
        private CustomViews.MainMenuButton mainMenuButton2;
    }
}

