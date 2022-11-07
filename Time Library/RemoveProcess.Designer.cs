namespace Time_Library
{
    partial class RemoveProcess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveProcess));
            this.processListComboBox = new System.Windows.Forms.ComboBox();
            this.removeProcessButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // processListComboBox
            // 
            this.processListComboBox.FormattingEnabled = true;
            this.processListComboBox.Location = new System.Drawing.Point(12, 12);
            this.processListComboBox.Name = "processListComboBox";
            this.processListComboBox.Size = new System.Drawing.Size(158, 21);
            this.processListComboBox.TabIndex = 4;
            // 
            // removeProcessButton
            // 
            this.removeProcessButton.Location = new System.Drawing.Point(12, 39);
            this.removeProcessButton.Name = "removeProcessButton";
            this.removeProcessButton.Size = new System.Drawing.Size(158, 23);
            this.removeProcessButton.TabIndex = 3;
            this.removeProcessButton.Text = "remove and save";
            this.removeProcessButton.UseVisualStyleBackColor = true;
            this.removeProcessButton.Click += new System.EventHandler(this.removeProcessButton_Click);
            // 
            // RemoveProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 75);
            this.Controls.Add(this.processListComboBox);
            this.Controls.Add(this.removeProcessButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RemoveProcess";
            this.Text = "RemoveProcess";
            this.Load += new System.EventHandler(this.RemoveProcess_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox processListComboBox;
        private System.Windows.Forms.Button removeProcessButton;
    }
}