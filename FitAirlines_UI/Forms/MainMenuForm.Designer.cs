namespace FitAirlines.UI
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
            this.usersButton = new FitAirlines.UI.CustomViews.MainMenuButton();
            this.reservationsButton = new FitAirlines.UI.CustomViews.MainMenuButton();
            this.offersButton = new FitAirlines.UI.CustomViews.MainMenuButton();
            this.flightsButton = new FitAirlines.UI.CustomViews.MainMenuButton();
            this.button1 = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.Controls.Add(this.usersButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.reservationsButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.flightsButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.offersButton, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 56);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(578, 299);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // usersButton
            // 
            this.usersButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usersButton.BackColor = System.Drawing.Color.Blue;
            this.usersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.usersButton.ForeColor = System.Drawing.Color.White;
            this.usersButton.Location = new System.Drawing.Point(5, 5);
            this.usersButton.Margin = new System.Windows.Forms.Padding(5);
            this.usersButton.Name = "usersButton";
            this.usersButton.Size = new System.Drawing.Size(274, 139);
            this.usersButton.TabIndex = 0;
            this.usersButton.Text = "USERS";
            this.usersButton.UseVisualStyleBackColor = false;
            this.usersButton.Click += new System.EventHandler(this.usersButton_Click);
            // 
            // reservationsButton
            // 
            this.reservationsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reservationsButton.BackColor = System.Drawing.Color.Blue;
            this.reservationsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.reservationsButton.ForeColor = System.Drawing.Color.White;
            this.reservationsButton.Location = new System.Drawing.Point(289, 154);
            this.reservationsButton.Margin = new System.Windows.Forms.Padding(5);
            this.reservationsButton.Name = "reservationsButton";
            this.reservationsButton.Size = new System.Drawing.Size(284, 140);
            this.reservationsButton.TabIndex = 3;
            this.reservationsButton.Text = "RESERVATIONS";
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
            this.offersButton.Location = new System.Drawing.Point(289, 5);
            this.offersButton.Margin = new System.Windows.Forms.Padding(5);
            this.offersButton.Name = "offersButton";
            this.offersButton.Size = new System.Drawing.Size(284, 139);
            this.offersButton.TabIndex = 1;
            this.offersButton.Text = "OFFERS";
            this.offersButton.UseVisualStyleBackColor = false;
            this.offersButton.Click += new System.EventHandler(this.offersButton_Click);
            // 
            // flightsButton
            // 
            this.flightsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flightsButton.BackColor = System.Drawing.Color.Blue;
            this.flightsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.flightsButton.ForeColor = System.Drawing.Color.White;
            this.flightsButton.Location = new System.Drawing.Point(5, 154);
            this.flightsButton.Margin = new System.Windows.Forms.Padding(5);
            this.flightsButton.Name = "flightsButton";
            this.flightsButton.Size = new System.Drawing.Size(274, 140);
            this.flightsButton.TabIndex = 2;
            this.flightsButton.Text = "FLIGHTS";
            this.flightsButton.UseVisualStyleBackColor = false;
            this.flightsButton.Click += new System.EventHandler(this.flightsButton_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImage = global::FitAirlines.UI.Properties.Resources.Icon_Settings;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(543, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 39);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(64, 12);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(185, 34);
            this.welcomeLabel.TabIndex = 2;
            this.welcomeLabel.Text = "Hello, Smith!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::FitAirlines.UI.Properties.Resources.hand;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(16, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 40);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenuForm";
            this.Text = "Fit Airlines";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CustomViews.MainMenuButton reservationsButton;
        private CustomViews.MainMenuButton offersButton;
        private CustomViews.MainMenuButton usersButton;
        private CustomViews.MainMenuButton flightsButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

