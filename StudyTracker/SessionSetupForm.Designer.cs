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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SessionSetupForm));
            this.timeLabel = new System.Windows.Forms.Label();
            this.timeBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionBox = new System.Windows.Forms.RichTextBox();
            this.currentTimeTimer = new System.Windows.Forms.Timer(this.components);
            this.saveButton = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateBox = new System.Windows.Forms.TextBox();
            this.topicLabel = new System.Windows.Forms.Label();
            this.topicComboBox = new System.Windows.Forms.ComboBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.SetupPanel = new System.Windows.Forms.Panel();
            this.SetupPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(80)))));
            this.timeLabel.Location = new System.Drawing.Point(109, 160);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(45, 16);
            this.timeLabel.TabIndex = 9;
            this.timeLabel.Text = "Time:";
            // 
            // timeBox
            // 
            this.timeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(232)))), ((int)(((byte)(230)))));
            this.timeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.timeBox.Location = new System.Drawing.Point(164, 162);
            this.timeBox.Margin = new System.Windows.Forms.Padding(2);
            this.timeBox.Name = "timeBox";
            this.timeBox.ReadOnly = true;
            this.timeBox.Size = new System.Drawing.Size(88, 16);
            this.timeBox.TabIndex = 3;
            this.timeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.descriptionLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(80)))));
            this.descriptionLabel.Location = new System.Drawing.Point(109, 284);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(154, 16);
            this.descriptionLabel.TabIndex = 13;
            this.descriptionLabel.Text = "Description (optional)";
            // 
            // descriptionBox
            // 
            this.descriptionBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(232)))), ((int)(((byte)(230)))));
            this.descriptionBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.descriptionBox.Location = new System.Drawing.Point(112, 306);
            this.descriptionBox.Margin = new System.Windows.Forms.Padding(2);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(280, 102);
            this.descriptionBox.TabIndex = 5;
            this.descriptionBox.Text = "What will you do this session?";
            this.descriptionBox.Enter += new System.EventHandler(this.descriptionBox_Enter);
            // 
            // currentTimeTimer
            // 
            this.currentTimeTimer.Enabled = true;
            this.currentTimeTimer.Interval = 1000;
            this.currentTimeTimer.Tick += new System.EventHandler(this.currentTimeTimer_Tick);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(95)))));
            this.saveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveButton.Location = new System.Drawing.Point(262, 122);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(56, 26);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(80)))));
            this.dateLabel.Location = new System.Drawing.Point(109, 222);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(43, 16);
            this.dateLabel.TabIndex = 11;
            this.dateLabel.Text = "Date:";
            // 
            // dateBox
            // 
            this.dateBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(232)))), ((int)(((byte)(230)))));
            this.dateBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dateBox.Location = new System.Drawing.Point(164, 222);
            this.dateBox.Margin = new System.Windows.Forms.Padding(2);
            this.dateBox.Name = "dateBox";
            this.dateBox.ReadOnly = true;
            this.dateBox.Size = new System.Drawing.Size(88, 16);
            this.dateBox.TabIndex = 4;
            this.dateBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // topicLabel
            // 
            this.topicLabel.AutoSize = true;
            this.topicLabel.BackColor = System.Drawing.Color.Transparent;
            this.topicLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topicLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(80)))));
            this.topicLabel.Location = new System.Drawing.Point(109, 98);
            this.topicLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.topicLabel.Name = "topicLabel";
            this.topicLabel.Size = new System.Drawing.Size(50, 16);
            this.topicLabel.TabIndex = 6;
            this.topicLabel.Text = "Topic:";
            // 
            // topicComboBox
            // 
            this.topicComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(232)))), ((int)(((byte)(230)))));
            this.topicComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.topicComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topicComboBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.topicComboBox.FormattingEnabled = true;
            this.topicComboBox.Location = new System.Drawing.Point(164, 97);
            this.topicComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.topicComboBox.MaxLength = 32;
            this.topicComboBox.Name = "topicComboBox";
            this.topicComboBox.Size = new System.Drawing.Size(228, 24);
            this.topicComboBox.TabIndex = 0;
            this.topicComboBox.DropDown += new System.EventHandler(this.topicComboBox_DropDown);
            this.topicComboBox.TextChanged += new System.EventHandler(this.topicComboBox_TextChanged);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(130)))), ((int)(((byte)(150)))));
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteButton.Enabled = false;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteButton.Location = new System.Drawing.Point(322, 122);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(70, 26);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(95)))));
            this.startButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.startButton.FlatAppearance.BorderSize = 0;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.startButton.Location = new System.Drawing.Point(164, 434);
            this.startButton.Margin = new System.Windows.Forms.Padding(2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(180, 47);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            this.startButton.MouseEnter += new System.EventHandler(this.startButton_MouseEnter);
            this.startButton.MouseLeave += new System.EventHandler(this.startButton_MouseLeave);
            // 
            // SetupPanel
            // 
            this.SetupPanel.BackColor = System.Drawing.Color.Transparent;
            this.SetupPanel.BackgroundImage = global::StudyTracker.Properties.Resources.Form_Background_Alt;
            this.SetupPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SetupPanel.Controls.Add(this.startButton);
            this.SetupPanel.Controls.Add(this.deleteButton);
            this.SetupPanel.Controls.Add(this.descriptionBox);
            this.SetupPanel.Controls.Add(this.topicComboBox);
            this.SetupPanel.Controls.Add(this.descriptionLabel);
            this.SetupPanel.Controls.Add(this.topicLabel);
            this.SetupPanel.Controls.Add(this.timeBox);
            this.SetupPanel.Controls.Add(this.timeLabel);
            this.SetupPanel.Controls.Add(this.dateBox);
            this.SetupPanel.Controls.Add(this.dateLabel);
            this.SetupPanel.Controls.Add(this.saveButton);
            this.SetupPanel.Location = new System.Drawing.Point(246, 83);
            this.SetupPanel.Name = "SetupPanel";
            this.SetupPanel.Size = new System.Drawing.Size(425, 566);
            this.SetupPanel.TabIndex = 18;
            // 
            // SessionSetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 700);
            this.Controls.Add(this.SetupPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SessionSetupForm";
            this.Text = "Study Tracker";
            this.Load += new System.EventHandler(this.SessionSetupForm_Load);
            this.VisibleChanged += new System.EventHandler(this.SessionSetupForm_VisibleChanged);
            this.Controls.SetChildIndex(this.SetupPanel, 0);
            this.SetupPanel.ResumeLayout(false);
            this.SetupPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.RichTextBox descriptionBox;
        private System.Windows.Forms.Timer currentTimeTimer;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label topicLabel;
        private System.Windows.Forms.ComboBox topicComboBox;
        private System.Windows.Forms.Button deleteButton;
        public System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Panel SetupPanel;
        private System.Windows.Forms.TextBox timeBox;
        private System.Windows.Forms.TextBox dateBox;
    }
}