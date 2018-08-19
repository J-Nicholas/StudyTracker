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
            this.descriptionBox = new System.Windows.Forms.RichTextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.currentTimeTimer = new System.Windows.Forms.Timer(this.components);
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackgroundImage = global::StudyTracker.Properties.Resources.MenuStrip;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backButton.Location = new System.Drawing.Point(23, 301);
            this.backButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(56, 19);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // topicLabel
            // 
            this.topicLabel.AutoSize = true;
            this.topicLabel.BackColor = System.Drawing.Color.Transparent;
            this.topicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topicLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.topicLabel.Location = new System.Drawing.Point(20, 50);
            this.topicLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.topicLabel.Name = "topicLabel";
            this.topicLabel.Size = new System.Drawing.Size(47, 17);
            this.topicLabel.TabIndex = 6;
            this.topicLabel.Text = "Topic:";
            // 
            // topicComboBox
            // 
            this.topicComboBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.topicComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.topicComboBox.ForeColor = System.Drawing.Color.White;
            this.topicComboBox.FormattingEnabled = true;
            this.topicComboBox.Location = new System.Drawing.Point(75, 50);
            this.topicComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.topicComboBox.Name = "topicComboBox";
            this.topicComboBox.Size = new System.Drawing.Size(242, 21);
            this.topicComboBox.TabIndex = 7;
            this.topicComboBox.DropDown += new System.EventHandler(this.topicComboBox_DropDown);
            this.topicComboBox.TextChanged += new System.EventHandler(this.topicComboBox_TextChanged);
            // 
            // saveButton
            // 
            this.saveButton.BackgroundImage = global::StudyTracker.Properties.Resources.MenuStrip;
            this.saveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveButton.Location = new System.Drawing.Point(199, 80);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(56, 19);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.timeLabel.Location = new System.Drawing.Point(20, 81);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(43, 17);
            this.timeLabel.TabIndex = 9;
            this.timeLabel.Text = "Time:";
            // 
            // timeBox
            // 
            this.timeBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.timeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeBox.ForeColor = System.Drawing.Color.White;
            this.timeBox.Location = new System.Drawing.Point(75, 80);
            this.timeBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.timeBox.Name = "timeBox";
            this.timeBox.ReadOnly = true;
            this.timeBox.Size = new System.Drawing.Size(88, 20);
            this.timeBox.TabIndex = 10;
            this.timeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.dateLabel.Location = new System.Drawing.Point(170, 147);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(42, 17);
            this.dateLabel.TabIndex = 11;
            this.dateLabel.Text = "Date:";
            // 
            // dateBox
            // 
            this.dateBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.dateBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateBox.ForeColor = System.Drawing.Color.White;
            this.dateBox.Location = new System.Drawing.Point(228, 145);
            this.dateBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateBox.Name = "dateBox";
            this.dateBox.ReadOnly = true;
            this.dateBox.Size = new System.Drawing.Size(88, 20);
            this.dateBox.TabIndex = 12;
            this.dateBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.descriptionLabel.Location = new System.Drawing.Point(20, 147);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(143, 17);
            this.descriptionLabel.TabIndex = 13;
            this.descriptionLabel.Text = "Description (optional)";
            // 
            // descriptionBox
            // 
            this.descriptionBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.descriptionBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionBox.ForeColor = System.Drawing.Color.White;
            this.descriptionBox.Location = new System.Drawing.Point(23, 177);
            this.descriptionBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(292, 102);
            this.descriptionBox.TabIndex = 14;
            this.descriptionBox.Text = "";
            // 
            // startButton
            // 
            this.startButton.BackgroundImage = global::StudyTracker.Properties.Resources.MenuStrip;
            this.startButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startButton.Location = new System.Drawing.Point(260, 301);
            this.startButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(56, 19);
            this.startButton.TabIndex = 15;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // currentTimeTimer
            // 
            this.currentTimeTimer.Enabled = true;
            this.currentTimeTimer.Interval = 1000;
            this.currentTimeTimer.Tick += new System.EventHandler(this.currentTimeTimer_Tick);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.DimGray;
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteButton.Enabled = false;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteButton.Location = new System.Drawing.Point(260, 80);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(56, 19);
            this.deleteButton.TabIndex = 16;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // SessionSetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(254, 305);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.topicComboBox);
            this.Controls.Add(this.topicLabel);
            this.Controls.Add(this.backButton);
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(270, 344);
            this.MinimumSize = new System.Drawing.Size(270, 297);
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
            this.Controls.SetChildIndex(this.descriptionBox, 0);
            this.Controls.SetChildIndex(this.startButton, 0);
            this.Controls.SetChildIndex(this.deleteButton, 0);
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
        private System.Windows.Forms.RichTextBox descriptionBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer currentTimeTimer;
        private System.Windows.Forms.Button deleteButton;
    }
}