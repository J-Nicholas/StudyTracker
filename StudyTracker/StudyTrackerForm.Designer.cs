namespace StudyTracker
{
    partial class StudyTrackerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.RecentLogsContainer = new System.Windows.Forms.Panel();
            this.RefreshRecentLogs = new System.Windows.Forms.Timer(this.components);
            this.AddLogButton = new System.Windows.Forms.PictureBox();
            this.ManualAddTooltip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AddLogButton)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Recent Study Logs:";
            // 
            // RecentLogsContainer
            // 
            this.RecentLogsContainer.AutoScrollMargin = new System.Drawing.Size(0, 30);
            this.RecentLogsContainer.Location = new System.Drawing.Point(234, 153);
            this.RecentLogsContainer.Name = "RecentLogsContainer";
            this.RecentLogsContainer.Size = new System.Drawing.Size(437, 528);
            this.RecentLogsContainer.TabIndex = 19;
            this.RecentLogsContainer.MouseEnter += new System.EventHandler(this.RecentLogsContainer_Enter);
            // 
            // RefreshRecentLogs
            // 
            this.RefreshRecentLogs.Enabled = true;
            this.RefreshRecentLogs.Interval = 30000;
            this.RefreshRecentLogs.Tick += new System.EventHandler(this.RefreshRecentLogs_Tick);
            // 
            // AddLogButton
            // 
            this.AddLogButton.BackgroundImage = global::StudyTracker.Properties.Resources.Add_Record;
            this.AddLogButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddLogButton.Location = new System.Drawing.Point(603, 99);
            this.AddLogButton.Name = "AddLogButton";
            this.AddLogButton.Size = new System.Drawing.Size(25, 25);
            this.AddLogButton.TabIndex = 21;
            this.AddLogButton.TabStop = false;
            this.ManualAddTooltip.SetToolTip(this.AddLogButton, "Click to add a study session manually.");
            this.AddLogButton.Click += new System.EventHandler(this.AddLogButton_Click);
            // 
            // StudyTrackerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 700);
            this.Controls.Add(this.AddLogButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RecentLogsContainer);
            this.Name = "StudyTrackerForm";
            this.Text = "Study Tracker";
            this.Load += new System.EventHandler(this.StudyTrackerForm_Load);
            this.VisibleChanged += new System.EventHandler(this.StudyTrackerForm_VisibleChanged);
            this.Controls.SetChildIndex(this.RecentLogsContainer, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.AddLogButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.AddLogButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel RecentLogsContainer;
        private System.Windows.Forms.Timer RefreshRecentLogs;
        private System.Windows.Forms.PictureBox AddLogButton;
        private System.Windows.Forms.ToolTip ManualAddTooltip;
    }
}