namespace Time_Library
{
    partial class AddProcess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProcess));
            this.addProcessButton = new System.Windows.Forms.Button();
            this.processListComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // addProcessButton
            // 
            this.addProcessButton.Location = new System.Drawing.Point(12, 40);
            this.addProcessButton.Name = "addProcessButton";
            this.addProcessButton.Size = new System.Drawing.Size(158, 23);
            this.addProcessButton.TabIndex = 1;
            this.addProcessButton.Text = "add and save";
            this.addProcessButton.UseVisualStyleBackColor = true;
            this.addProcessButton.Click += new System.EventHandler(this.addProcessButton_Click);
            // 
            // processListComboBox
            // 
            this.processListComboBox.FormattingEnabled = true;
            this.processListComboBox.Location = new System.Drawing.Point(12, 13);
            this.processListComboBox.Name = "processListComboBox";
            this.processListComboBox.Size = new System.Drawing.Size(158, 21);
            this.processListComboBox.TabIndex = 2;
            // 
            // AddProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 75);
            this.Controls.Add(this.processListComboBox);
            this.Controls.Add(this.addProcessButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddProcess";
            this.Text = "AddProcess";
            this.Load += new System.EventHandler(this.AddProcess_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addProcessButton;
        private System.Windows.Forms.ComboBox processListComboBox;
    }
}