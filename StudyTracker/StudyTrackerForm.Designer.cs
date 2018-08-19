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
            this.startImage = new System.Windows.Forms.PictureBox();
            this.startSessionButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.startImage)).BeginInit();
            this.SuspendLayout();
            // 
            // startImage
            // 
            this.startImage.BackColor = System.Drawing.Color.Transparent;
            this.startImage.Image = global::StudyTracker.Properties.Resources.PlayButton;
            this.startImage.Location = new System.Drawing.Point(74, 61);
            this.startImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startImage.Name = "startImage";
            this.startImage.Size = new System.Drawing.Size(189, 148);
            this.startImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.startImage.TabIndex = 5;
            this.startImage.TabStop = false;
            this.startImage.Click += new System.EventHandler(this.startButton_Click);
            // 
            // startSessionButton
            // 
            this.startSessionButton.BackgroundImage = global::StudyTracker.Properties.Resources.MenuStrip;
            this.startSessionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.startSessionButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startSessionButton.Location = new System.Drawing.Point(109, 223);
            this.startSessionButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startSessionButton.Name = "startSessionButton";
            this.startSessionButton.Size = new System.Drawing.Size(118, 28);
            this.startSessionButton.TabIndex = 6;
            this.startSessionButton.Text = "Start new session";
            this.startSessionButton.UseVisualStyleBackColor = true;
            this.startSessionButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // StudyTrackerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 305);
            this.Controls.Add(this.startSessionButton);
            this.Controls.Add(this.startImage);
            this.MaximumSize = new System.Drawing.Size(270, 344);
            this.MinimumSize = new System.Drawing.Size(270, 297);
            this.Name = "StudyTrackerForm";
            this.Text = "Study Tracker";
            this.Controls.SetChildIndex(this.startImage, 0);
            this.Controls.SetChildIndex(this.startSessionButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.startImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox startImage;
        private System.Windows.Forms.Button startSessionButton;
    }
}