namespace StudyTracker
{
    partial class SessionManagerForm
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
            this.timerLabel = new System.Windows.Forms.Label();
            this.pauseButton = new System.Windows.Forms.Button();
            this.finishButton = new System.Windows.Forms.Button();
            this.timeElapsedTimer = new System.Windows.Forms.Timer(this.components);
            this.InfoLabel = new System.Windows.Forms.Label();
            this.topicLabel = new System.Windows.Forms.Label();
            this.ClockImage = new System.Windows.Forms.PictureBox();
            this.WindowPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ClockImage)).BeginInit();
            this.WindowPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.BackColor = System.Drawing.Color.Transparent;
            this.timerLabel.Font = new System.Drawing.Font("Tw Cen MT", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.timerLabel.Location = new System.Drawing.Point(117, 191);
            this.timerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(141, 47);
            this.timerLabel.TabIndex = 5;
            this.timerLabel.Text = "00:00.0";
            // 
            // pauseButton
            // 
            this.pauseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(150)))), ((int)(((byte)(170)))));
            this.pauseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pauseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pauseButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pauseButton.Location = new System.Drawing.Point(27, 397);
            this.pauseButton.Margin = new System.Windows.Forms.Padding(2);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(132, 50);
            this.pauseButton.TabIndex = 6;
            this.pauseButton.Text = "PAUSE";
            this.pauseButton.UseVisualStyleBackColor = false;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // finishButton
            // 
            this.finishButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(150)))), ((int)(((byte)(170)))));
            this.finishButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.finishButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finishButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.finishButton.Location = new System.Drawing.Point(206, 397);
            this.finishButton.Margin = new System.Windows.Forms.Padding(2);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(138, 50);
            this.finishButton.TabIndex = 7;
            this.finishButton.Text = "FINISHED";
            this.finishButton.UseVisualStyleBackColor = false;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // timeElapsedTimer
            // 
            this.timeElapsedTimer.Enabled = true;
            this.timeElapsedTimer.Tick += new System.EventHandler(this.timeElapsedTimer_Tick);
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.InfoLabel.Font = new System.Drawing.Font("Bookman Old Style", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.InfoLabel.ImageKey = "(none)";
            this.InfoLabel.Location = new System.Drawing.Point(91, 67);
            this.InfoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(198, 20);
            this.InfoLabel.TabIndex = 8;
            this.InfoLabel.Text = "You have been studying";
            // 
            // topicLabel
            // 
            this.topicLabel.AutoSize = true;
            this.topicLabel.BackColor = System.Drawing.Color.Transparent;
            this.topicLabel.Font = new System.Drawing.Font("Bookman Old Style", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topicLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.topicLabel.Location = new System.Drawing.Point(153, 97);
            this.topicLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.topicLabel.Name = "topicLabel";
            this.topicLabel.Size = new System.Drawing.Size(79, 22);
            this.topicLabel.TabIndex = 9;
            this.topicLabel.Text = "(coded)";
            // 
            // ClockImage
            // 
            this.ClockImage.BackColor = System.Drawing.Color.Transparent;
            this.ClockImage.Location = new System.Drawing.Point(62, 179);
            this.ClockImage.Margin = new System.Windows.Forms.Padding(2);
            this.ClockImage.Name = "ClockImage";
            this.ClockImage.Size = new System.Drawing.Size(258, 80);
            this.ClockImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ClockImage.TabIndex = 10;
            this.ClockImage.TabStop = false;
            // 
            // WindowPanel
            // 
            this.WindowPanel.BackgroundImage = global::StudyTracker.Properties.Resources.Session_Manager_Window;
            this.WindowPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WindowPanel.Controls.Add(this.InfoLabel);
            this.WindowPanel.Controls.Add(this.timerLabel);
            this.WindowPanel.Controls.Add(this.ClockImage);
            this.WindowPanel.Controls.Add(this.topicLabel);
            this.WindowPanel.Controls.Add(this.pauseButton);
            this.WindowPanel.Controls.Add(this.finishButton);
            this.WindowPanel.Location = new System.Drawing.Point(274, 105);
            this.WindowPanel.Name = "WindowPanel";
            this.WindowPanel.Size = new System.Drawing.Size(369, 507);
            this.WindowPanel.TabIndex = 18;
            // 
            // SessionManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 700);
            this.Controls.Add(this.WindowPanel);
            this.Name = "SessionManagerForm";
            this.Text = "Study Tracker";
            this.Load += new System.EventHandler(this.SessionManagerForm_Load);
            this.VisibleChanged += new System.EventHandler(this.SessionManagerForm_VisibleChanged);
            this.Controls.SetChildIndex(this.WindowPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ClockImage)).EndInit();
            this.WindowPanel.ResumeLayout(false);
            this.WindowPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.Timer timeElapsedTimer;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Label topicLabel;
        private System.Windows.Forms.PictureBox ClockImage;
        private System.Windows.Forms.Panel WindowPanel;
    }
}