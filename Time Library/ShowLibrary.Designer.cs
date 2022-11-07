namespace Time_Library
{
    partial class ShowLibrary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowLibrary));
            this.processNameTextBox = new System.Windows.Forms.TextBox();
            this.processTimeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // processNameTextBox
            // 
            this.processNameTextBox.Enabled = false;
            this.processNameTextBox.Location = new System.Drawing.Point(12, 12);
            this.processNameTextBox.Multiline = true;
            this.processNameTextBox.Name = "processNameTextBox";
            this.processNameTextBox.ReadOnly = true;
            this.processNameTextBox.Size = new System.Drawing.Size(224, 324);
            this.processNameTextBox.TabIndex = 0;
            this.processNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // processTimeTextBox
            // 
            this.processTimeTextBox.Enabled = false;
            this.processTimeTextBox.Location = new System.Drawing.Point(242, 12);
            this.processTimeTextBox.Multiline = true;
            this.processTimeTextBox.Name = "processTimeTextBox";
            this.processTimeTextBox.ReadOnly = true;
            this.processTimeTextBox.Size = new System.Drawing.Size(106, 324);
            this.processTimeTextBox.TabIndex = 1;
            this.processTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ShowLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 348);
            this.Controls.Add(this.processTimeTextBox);
            this.Controls.Add(this.processNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShowLibrary";
            this.Text = "Library";
            this.Load += new System.EventHandler(this.ShowLibrary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox processNameTextBox;
        private System.Windows.Forms.TextBox processTimeTextBox;
    }
}