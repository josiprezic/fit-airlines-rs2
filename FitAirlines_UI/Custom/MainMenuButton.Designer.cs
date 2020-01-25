namespace FitAirlines_UI.CustomViews
{
    partial class MainMenuButton
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
            this.baseButton1 = new FitAirlines_UI.BaseButton();
            this.SuspendLayout();
            // 
            // baseButton1
            // 
            this.baseButton1.Location = new System.Drawing.Point(0, 0);
            this.baseButton1.Name = "baseButton1";
            this.baseButton1.Size = new System.Drawing.Size(75, 23);
            this.baseButton1.TabIndex = 0;
            this.baseButton1.Text = "baseButton1";
            this.baseButton1.UseVisualStyleBackColor = true;
            this.ResumeLayout(false);

        }

        #endregion

        private BaseButton baseButton1;
    }
}
