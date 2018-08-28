namespace StudyTracker
{
    partial class AddNewLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewLog));
            this.SetupPanel = new System.Windows.Forms.Panel();
            this.TimeFinishedBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.FinishedButton = new System.Windows.Forms.Button();
            this.descriptionBox = new System.Windows.Forms.RichTextBox();
            this.topicComboBox = new System.Windows.Forms.ComboBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.topicLabel = new System.Windows.Forms.Label();
            this.StartTimeBox = new System.Windows.Forms.TextBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.dateBox = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.SetupPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SetupPanel
            // 
            this.SetupPanel.BackColor = System.Drawing.Color.Transparent;
            this.SetupPanel.BackgroundImage = global::StudyTracker.Properties.Resources.Form_Background_Alt;
            this.SetupPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SetupPanel.Controls.Add(this.TimeFinishedBox);
            this.SetupPanel.Controls.Add(this.label1);
            this.SetupPanel.Controls.Add(this.cancelButton);
            this.SetupPanel.Controls.Add(this.FinishedButton);
            this.SetupPanel.Controls.Add(this.descriptionBox);
            this.SetupPanel.Controls.Add(this.topicComboBox);
            this.SetupPanel.Controls.Add(this.descriptionLabel);
            this.SetupPanel.Controls.Add(this.topicLabel);
            this.SetupPanel.Controls.Add(this.StartTimeBox);
            this.SetupPanel.Controls.Add(this.timeLabel);
            this.SetupPanel.Controls.Add(this.dateBox);
            this.SetupPanel.Controls.Add(this.dateLabel);
            this.SetupPanel.Location = new System.Drawing.Point(13, 12);
            this.SetupPanel.Name = "SetupPanel";
            this.SetupPanel.Size = new System.Drawing.Size(433, 637);
            this.SetupPanel.TabIndex = 20;
            // 
            // TimeFinishedBox
            // 
            this.TimeFinishedBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(232)))), ((int)(((byte)(230)))));
            this.TimeFinishedBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TimeFinishedBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeFinishedBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TimeFinishedBox.Location = new System.Drawing.Point(270, 214);
            this.TimeFinishedBox.Margin = new System.Windows.Forms.Padding(2);
            this.TimeFinishedBox.Name = "TimeFinishedBox";
            this.TimeFinishedBox.Size = new System.Drawing.Size(88, 16);
            this.TimeFinishedBox.TabIndex = 19;
            this.TimeFinishedBox.Text = "00:00";
            this.TimeFinishedBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(156, 214);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Time Finished:";
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(95)))));
            this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cancelButton.Location = new System.Drawing.Point(164, 539);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(180, 47);
            this.cancelButton.TabIndex = 17;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // FinishedButton
            // 
            this.FinishedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(95)))));
            this.FinishedButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FinishedButton.FlatAppearance.BorderSize = 0;
            this.FinishedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FinishedButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishedButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FinishedButton.Location = new System.Drawing.Point(164, 488);
            this.FinishedButton.Margin = new System.Windows.Forms.Padding(2);
            this.FinishedButton.Name = "FinishedButton";
            this.FinishedButton.Size = new System.Drawing.Size(180, 47);
            this.FinishedButton.TabIndex = 15;
            this.FinishedButton.Text = "Save";
            this.FinishedButton.UseVisualStyleBackColor = false;
            this.FinishedButton.Click += new System.EventHandler(this.FinishedButton_Click);
            // 
            // descriptionBox
            // 
            this.descriptionBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(232)))), ((int)(((byte)(230)))));
            this.descriptionBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.descriptionBox.Location = new System.Drawing.Point(112, 367);
            this.descriptionBox.Margin = new System.Windows.Forms.Padding(2);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(280, 102);
            this.descriptionBox.TabIndex = 14;
            this.descriptionBox.Text = "";
            // 
            // topicComboBox
            // 
            this.topicComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(232)))), ((int)(((byte)(230)))));
            this.topicComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.topicComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topicComboBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.topicComboBox.FormattingEnabled = true;
            this.topicComboBox.Location = new System.Drawing.Point(164, 97);
            this.topicComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.topicComboBox.MaxLength = 32;
            this.topicComboBox.Name = "topicComboBox";
            this.topicComboBox.Size = new System.Drawing.Size(228, 24);
            this.topicComboBox.TabIndex = 7;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.descriptionLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(80)))));
            this.descriptionLabel.Location = new System.Drawing.Point(109, 345);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(154, 16);
            this.descriptionLabel.TabIndex = 13;
            this.descriptionLabel.Text = "Description (optional)";
            // 
            // topicLabel
            // 
            this.topicLabel.AutoSize = true;
            this.topicLabel.BackColor = System.Drawing.Color.Transparent;
            this.topicLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topicLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(80)))));
            this.topicLabel.Location = new System.Drawing.Point(109, 97);
            this.topicLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.topicLabel.Name = "topicLabel";
            this.topicLabel.Size = new System.Drawing.Size(50, 16);
            this.topicLabel.TabIndex = 6;
            this.topicLabel.Text = "Topic:";
            // 
            // StartTimeBox
            // 
            this.StartTimeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(232)))), ((int)(((byte)(230)))));
            this.StartTimeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StartTimeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTimeBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StartTimeBox.Location = new System.Drawing.Point(270, 183);
            this.StartTimeBox.Margin = new System.Windows.Forms.Padding(2);
            this.StartTimeBox.Name = "StartTimeBox";
            this.StartTimeBox.Size = new System.Drawing.Size(88, 16);
            this.StartTimeBox.TabIndex = 10;
            this.StartTimeBox.Text = "00:00";
            this.StartTimeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(80)))));
            this.timeLabel.Location = new System.Drawing.Point(156, 184);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(99, 16);
            this.timeLabel.TabIndex = 9;
            this.timeLabel.Text = "Time Started:";
            // 
            // dateBox
            // 
            this.dateBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(232)))), ((int)(((byte)(230)))));
            this.dateBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dateBox.Location = new System.Drawing.Point(270, 245);
            this.dateBox.Margin = new System.Windows.Forms.Padding(2);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(88, 16);
            this.dateBox.TabIndex = 12;
            this.dateBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(80)))));
            this.dateLabel.Location = new System.Drawing.Point(156, 245);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(43, 16);
            this.dateLabel.TabIndex = 11;
            this.dateLabel.Text = "Date:";
            // 
            // AddNewLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 661);
            this.Controls.Add(this.SetupPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(475, 700);
            this.MinimumSize = new System.Drawing.Size(475, 700);
            this.Name = "AddNewLog";
            this.Text = "Add Study Log";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddNewLog_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.AddNewLog_VisibleChanged);
            this.SetupPanel.ResumeLayout(false);
            this.SetupPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SetupPanel;
        private System.Windows.Forms.TextBox TimeFinishedBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button FinishedButton;
        private System.Windows.Forms.RichTextBox descriptionBox;
        private System.Windows.Forms.ComboBox topicComboBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label topicLabel;
        private System.Windows.Forms.TextBox StartTimeBox;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.TextBox dateBox;
        private System.Windows.Forms.Label dateLabel;
    }
}