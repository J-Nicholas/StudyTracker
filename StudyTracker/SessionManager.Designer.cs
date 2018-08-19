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
            ((System.ComponentModel.ISupportInitialize)(this.ClockImage)).BeginInit();
            this.SuspendLayout();
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.BackColor = System.Drawing.Color.Transparent;
            this.timerLabel.Font = new System.Drawing.Font("Yu Gothic UI", 30.05217F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.timerLabel.Location = new System.Drawing.Point(131, 148);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(187, 65);
            this.timerLabel.TabIndex = 5;
            this.timerLabel.Text = "00:00.0";
            // 
            // pauseButton
            // 
            this.pauseButton.BackgroundImage = global::StudyTracker.Properties.Resources.MenuStrip;
            this.pauseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pauseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pauseButton.Location = new System.Drawing.Point(164, 264);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(120, 35);
            this.pauseButton.TabIndex = 6;
            this.pauseButton.Text = "PAUSE";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // finishButton
            // 
            this.finishButton.BackgroundImage = global::StudyTracker.Properties.Resources.MenuStrip;
            this.finishButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.finishButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finishButton.Location = new System.Drawing.Point(164, 321);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(120, 35);
            this.finishButton.TabIndex = 7;
            this.finishButton.Text = "FINISHED";
            this.finishButton.UseVisualStyleBackColor = true;
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
            this.InfoLabel.Location = new System.Drawing.Point(113, 58);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(235, 21);
            this.InfoLabel.TabIndex = 8;
            this.InfoLabel.Text = "You have been studying";
            // 
            // topicLabel
            // 
            this.topicLabel.AutoSize = true;
            this.topicLabel.BackColor = System.Drawing.Color.Transparent;
            this.topicLabel.Font = new System.Drawing.Font("Bookman Old Style", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topicLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.topicLabel.Location = new System.Drawing.Point(177, 80);
            this.topicLabel.Name = "topicLabel";
            this.topicLabel.Size = new System.Drawing.Size(96, 28);
            this.topicLabel.TabIndex = 9;
            this.topicLabel.Text = "(coded)";
            // 
            // ClockImage
            // 
            this.ClockImage.Image = global::StudyTracker.Properties.Resources.ClockTimer_Green;
            this.ClockImage.Location = new System.Drawing.Point(57, 114);
            this.ClockImage.Name = "ClockImage";
            this.ClockImage.Size = new System.Drawing.Size(344, 99);
            this.ClockImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ClockImage.TabIndex = 10;
            this.ClockImage.TabStop = false;
            // 
            // SessionManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StudyTracker.Properties.Resources.Abstract_Black_BkGrnd;
            this.ClientSize = new System.Drawing.Size(449, 386);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.topicLabel);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.ClockImage);
            this.Name = "SessionManagerForm";
            this.Text = "Session Manager";
            this.Load += new System.EventHandler(this.SessionManagerForm_Load);
            this.Controls.SetChildIndex(this.ClockImage, 0);
            this.Controls.SetChildIndex(this.pauseButton, 0);
            this.Controls.SetChildIndex(this.finishButton, 0);
            this.Controls.SetChildIndex(this.InfoLabel, 0);
            this.Controls.SetChildIndex(this.topicLabel, 0);
            this.Controls.SetChildIndex(this.timerLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ClockImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.Timer timeElapsedTimer;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Label topicLabel;
        private System.Windows.Forms.PictureBox ClockImage;
    }
}