namespace StudyTracker
{
    partial class BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplicationStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sessionSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.mainMenuStrip.BackgroundImage = global::StudyTracker.Properties.Resources.MenuStrip;
            this.mainMenuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileStripMenu,
            this.toolStripMenuItem3,
            this.viewToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mainMenuStrip.Size = new System.Drawing.Size(338, 24);
            this.mainMenuStrip.TabIndex = 4;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileStripMenu
            // 
            this.fileStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitApplicationStrip});
            this.fileStripMenu.Name = "fileStripMenu";
            this.fileStripMenu.Size = new System.Drawing.Size(37, 20);
            this.fileStripMenu.Text = "&File";
            // 
            // exitApplicationStrip
            // 
            this.exitApplicationStrip.Name = "exitApplicationStrip";
            this.exitApplicationStrip.Size = new System.Drawing.Size(156, 22);
            this.exitApplicationStrip.Text = "Exit Application";
            this.exitApplicationStrip.Click += new System.EventHandler(this.exitApplicationStrip_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(39, 20);
            this.toolStripMenuItem3.Text = "&Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem,
            this.sessionSetupToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mainMenuToolStripMenuItem.Text = "Topic to Description";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // sessionSetupToolStripMenuItem
            // 
            this.sessionSetupToolStripMenuItem.Name = "sessionSetupToolStripMenuItem";
            this.sessionSetupToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sessionSetupToolStripMenuItem.Text = "Session Setup";
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::StudyTracker.Properties.Resources.Abstract_Black_BkGrnd;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(338, 318);
            this.Controls.Add(this.mainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(354, 357);
            this.MinimumSize = new System.Drawing.Size(354, 357);
            this.Name = "BaseForm";
            this.Text = "StudyTrackerForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BaseForm_FormClosed);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileStripMenu;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sessionSetupToolStripMenuItem;
    }
}