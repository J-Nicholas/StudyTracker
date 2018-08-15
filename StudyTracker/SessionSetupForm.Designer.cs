namespace StudyTracker
{
    partial class SessionSetupForm
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
            this.backButton = new System.Windows.Forms.Button();
            this.topicLabel = new System.Windows.Forms.Label();
            this.topicComboBox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timeBox = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.currentTimeTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(85, 332);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // topicLabel
            // 
            this.topicLabel.AutoSize = true;
            this.topicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topicLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.topicLabel.Location = new System.Drawing.Point(27, 62);
            this.topicLabel.Name = "topicLabel";
            this.topicLabel.Size = new System.Drawing.Size(51, 20);
            this.topicLabel.TabIndex = 6;
            this.topicLabel.Text = "Topic:";
            // 
            // topicComboBox
            // 
            this.topicComboBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.topicComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.topicComboBox.FormattingEnabled = true;
            this.topicComboBox.Items.AddRange(new object[] {
            "C#",
            "Java"});
            this.topicComboBox.Location = new System.Drawing.Point(100, 62);
            this.topicComboBox.Name = "topicComboBox";
            this.topicComboBox.Size = new System.Drawing.Size(226, 24);
            this.topicComboBox.TabIndex = 7;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(346, 62);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.timeLabel.Location = new System.Drawing.Point(27, 110);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(47, 20);
            this.timeLabel.TabIndex = 9;
            this.timeLabel.Text = "Time:";
            // 
            // timeBox
            // 
            this.timeBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.timeBox.Location = new System.Drawing.Point(100, 110);
            this.timeBox.Name = "timeBox";
            this.timeBox.ReadOnly = true;
            this.timeBox.Size = new System.Drawing.Size(117, 22);
            this.timeBox.TabIndex = 10;
            this.timeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.dateLabel.Location = new System.Drawing.Point(234, 110);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(48, 20);
            this.dateLabel.TabIndex = 11;
            this.dateLabel.Text = "Date:";
            // 
            // dateBox
            // 
            this.dateBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.dateBox.Location = new System.Drawing.Point(304, 110);
            this.dateBox.Name = "dateBox";
            this.dateBox.ReadOnly = true;
            this.dateBox.Size = new System.Drawing.Size(117, 22);
            this.dateBox.TabIndex = 12;
            this.dateBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.descriptionLabel.Location = new System.Drawing.Point(27, 152);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(159, 20);
            this.descriptionLabel.TabIndex = 13;
            this.descriptionLabel.Text = "Description (optional)";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.richTextBox1.Location = new System.Drawing.Point(31, 189);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(390, 126);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(304, 332);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 15;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // currentTimeTimer
            // 
            this.currentTimeTimer.Enabled = true;
            this.currentTimeTimer.Interval = 1000;
            this.currentTimeTimer.Tick += new System.EventHandler(this.currentTimeTimer_Tick);
            // 
            // SessionSetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(449, 386);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.topicComboBox);
            this.Controls.Add(this.topicLabel);
            this.Controls.Add(this.backButton);
            this.Name = "SessionSetupForm";
            this.Text = "Setup Session";
            this.Load += new System.EventHandler(this.SessionSetupForm_Load);
            this.Controls.SetChildIndex(this.backButton, 0);
            this.Controls.SetChildIndex(this.topicLabel, 0);
            this.Controls.SetChildIndex(this.topicComboBox, 0);
            this.Controls.SetChildIndex(this.saveButton, 0);
            this.Controls.SetChildIndex(this.timeLabel, 0);
            this.Controls.SetChildIndex(this.timeBox, 0);
            this.Controls.SetChildIndex(this.dateLabel, 0);
            this.Controls.SetChildIndex(this.dateBox, 0);
            this.Controls.SetChildIndex(this.descriptionLabel, 0);
            this.Controls.SetChildIndex(this.richTextBox1, 0);
            this.Controls.SetChildIndex(this.startButton, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label topicLabel;
        private System.Windows.Forms.ComboBox topicComboBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.TextBox timeBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox dateBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer currentTimeTimer;
    }
}