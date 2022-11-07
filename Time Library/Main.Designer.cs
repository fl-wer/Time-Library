namespace Time_Library
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.addProcessButton = new System.Windows.Forms.Button();
            this.removeProcessButton = new System.Windows.Forms.Button();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.seeLibraryButton = new System.Windows.Forms.Button();
            this.trayMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // addProcessButton
            // 
            this.addProcessButton.Location = new System.Drawing.Point(12, 12);
            this.addProcessButton.Name = "addProcessButton";
            this.addProcessButton.Size = new System.Drawing.Size(239, 23);
            this.addProcessButton.TabIndex = 0;
            this.addProcessButton.Text = "add process";
            this.addProcessButton.UseVisualStyleBackColor = true;
            this.addProcessButton.Click += new System.EventHandler(this.addProcessButton_Click);
            // 
            // removeProcessButton
            // 
            this.removeProcessButton.Location = new System.Drawing.Point(12, 41);
            this.removeProcessButton.Name = "removeProcessButton";
            this.removeProcessButton.Size = new System.Drawing.Size(239, 23);
            this.removeProcessButton.TabIndex = 1;
            this.removeProcessButton.Text = "remove process";
            this.removeProcessButton.UseVisualStyleBackColor = true;
            this.removeProcessButton.Click += new System.EventHandler(this.removeProcessButton_Click);
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.trayMenuStrip;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "Time Library";
            this.trayIcon.Visible = true;
            this.trayIcon.DoubleClick += new System.EventHandler(this.trayIcon_DoubleClick);
            // 
            // trayMenuStrip
            // 
            this.trayMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.trayMenuStrip.Name = "trayMenuStrip";
            this.trayMenuStrip.Size = new System.Drawing.Size(104, 48);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            // 
            // seeLibraryButton
            // 
            this.seeLibraryButton.Location = new System.Drawing.Point(12, 70);
            this.seeLibraryButton.Name = "seeLibraryButton";
            this.seeLibraryButton.Size = new System.Drawing.Size(239, 23);
            this.seeLibraryButton.TabIndex = 2;
            this.seeLibraryButton.Text = "show library";
            this.seeLibraryButton.UseVisualStyleBackColor = true;
            this.seeLibraryButton.Click += new System.EventHandler(this.seeLibraryButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(263, 104);
            this.Controls.Add(this.seeLibraryButton);
            this.Controls.Add(this.removeProcessButton);
            this.Controls.Add(this.addProcessButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time Library";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.trayMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addProcessButton;
        private System.Windows.Forms.Button removeProcessButton;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip trayMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Button seeLibraryButton;
    }
}

