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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.CloseButtonImage = new System.Windows.Forms.PictureBox();
            this.MinimiseButtonImage = new System.Windows.Forms.PictureBox();
            this.Sidebar_TitleImage = new System.Windows.Forms.PictureBox();
            this.linkToMyLinkdin = new System.Windows.Forms.LinkLabel();
            this.StatsToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.optionsButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.statsButton = new System.Windows.Forms.Button();
            this.logsButton = new System.Windows.Forms.Button();
            this.startSessionButton = new System.Windows.Forms.Button();
            this.bookButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DragWindow = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButtonImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimiseButtonImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sidebar_TitleImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.DragWindow.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseButtonImage
            // 
            this.CloseButtonImage.BackgroundImage = global::StudyTracker.Properties.Resources.Close_Icon;
            this.CloseButtonImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseButtonImage.Location = new System.Drawing.Point(664, 5);
            this.CloseButtonImage.Name = "CloseButtonImage";
            this.CloseButtonImage.Size = new System.Drawing.Size(25, 25);
            this.CloseButtonImage.TabIndex = 1;
            this.CloseButtonImage.TabStop = false;
            this.CloseButtonImage.Click += new System.EventHandler(this.CloseButtonImage_Click);
            this.CloseButtonImage.MouseEnter += new System.EventHandler(this.CloseButtonImage_MouseEnter);
            this.CloseButtonImage.MouseLeave += new System.EventHandler(this.CloseButtonImage_MouseLeave);
            // 
            // MinimiseButtonImage
            // 
            this.MinimiseButtonImage.BackgroundImage = global::StudyTracker.Properties.Resources.Minimise_Icon;
            this.MinimiseButtonImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MinimiseButtonImage.Location = new System.Drawing.Point(633, 5);
            this.MinimiseButtonImage.Name = "MinimiseButtonImage";
            this.MinimiseButtonImage.Size = new System.Drawing.Size(25, 25);
            this.MinimiseButtonImage.TabIndex = 2;
            this.MinimiseButtonImage.TabStop = false;
            this.MinimiseButtonImage.Click += new System.EventHandler(this.MinimiseButtonImage_Click);
            this.MinimiseButtonImage.MouseEnter += new System.EventHandler(this.MinimiseButtonImage_MouseEnter);
            this.MinimiseButtonImage.MouseLeave += new System.EventHandler(this.MinimiseButtonImage_MouseLeave);
            // 
            // Sidebar_TitleImage
            // 
            this.Sidebar_TitleImage.BackColor = System.Drawing.Color.Transparent;
            this.Sidebar_TitleImage.BackgroundImage = global::StudyTracker.Properties.Resources.StudyTrackerTitle;
            this.Sidebar_TitleImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Sidebar_TitleImage.Location = new System.Drawing.Point(24, 0);
            this.Sidebar_TitleImage.Name = "Sidebar_TitleImage";
            this.Sidebar_TitleImage.Size = new System.Drawing.Size(160, 30);
            this.Sidebar_TitleImage.TabIndex = 5;
            this.Sidebar_TitleImage.TabStop = false;
            // 
            // linkToMyLinkdin
            // 
            this.linkToMyLinkdin.AutoSize = true;
            this.linkToMyLinkdin.BackColor = System.Drawing.Color.Transparent;
            this.linkToMyLinkdin.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkToMyLinkdin.LinkColor = System.Drawing.Color.White;
            this.linkToMyLinkdin.Location = new System.Drawing.Point(27, 656);
            this.linkToMyLinkdin.Name = "linkToMyLinkdin";
            this.linkToMyLinkdin.Size = new System.Drawing.Size(143, 18);
            this.linkToMyLinkdin.TabIndex = 5;
            this.linkToMyLinkdin.TabStop = true;
            this.linkToMyLinkdin.Text = "Johnathan Nicholas";
            this.linkToMyLinkdin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkToMyLinkdin_LinkClicked);
            // 
            // optionsButton
            // 
            this.optionsButton.BackColor = System.Drawing.Color.Transparent;
            this.optionsButton.BackgroundImage = global::StudyTracker.Properties.Resources.SideBar;
            this.optionsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.optionsButton.FlatAppearance.BorderSize = 0;
            this.optionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optionsButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.optionsButton.Location = new System.Drawing.Point(10, 486);
            this.optionsButton.Name = "optionsButton";
            this.optionsButton.Size = new System.Drawing.Size(181, 50);
            this.optionsButton.TabIndex = 20;
            this.optionsButton.Text = "Options";
            this.optionsButton.UseVisualStyleBackColor = false;
            this.optionsButton.Click += new System.EventHandler(this.optionsButton_Click);
            this.optionsButton.MouseEnter += new System.EventHandler(this.StartImage_MouseEnter);
            this.optionsButton.MouseLeave += new System.EventHandler(this.StartImage_MouseLeave);
            // 
            // aboutButton
            // 
            this.aboutButton.BackColor = System.Drawing.Color.Transparent;
            this.aboutButton.BackgroundImage = global::StudyTracker.Properties.Resources.SideBar;
            this.aboutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.aboutButton.FlatAppearance.BorderSize = 0;
            this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.aboutButton.Location = new System.Drawing.Point(13, 419);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(181, 50);
            this.aboutButton.TabIndex = 21;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = false;
            this.aboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            this.aboutButton.MouseEnter += new System.EventHandler(this.StartImage_MouseEnter);
            this.aboutButton.MouseLeave += new System.EventHandler(this.StartImage_MouseLeave);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.BackgroundImage = global::StudyTracker.Properties.Resources.SideBar;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitButton.Location = new System.Drawing.Point(13, 553);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(181, 50);
            this.exitButton.TabIndex = 22;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.CloseButtonImage_Click);
            this.exitButton.MouseEnter += new System.EventHandler(this.StartImage_MouseEnter);
            this.exitButton.MouseLeave += new System.EventHandler(this.StartImage_MouseLeave);
            // 
            // statsButton
            // 
            this.statsButton.BackColor = System.Drawing.Color.Transparent;
            this.statsButton.BackgroundImage = global::StudyTracker.Properties.Resources.SideBar;
            this.statsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.statsButton.FlatAppearance.BorderSize = 0;
            this.statsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statsButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statsButton.Location = new System.Drawing.Point(13, 352);
            this.statsButton.Name = "statsButton";
            this.statsButton.Size = new System.Drawing.Size(181, 50);
            this.statsButton.TabIndex = 23;
            this.statsButton.Text = "Statistics";
            this.statsButton.UseVisualStyleBackColor = false;
            this.statsButton.Click += new System.EventHandler(this.StatisticsButton_Click);
            this.statsButton.MouseEnter += new System.EventHandler(this.StartImage_MouseEnter);
            this.statsButton.MouseLeave += new System.EventHandler(this.StartImage_MouseLeave);
            // 
            // logsButton
            // 
            this.logsButton.BackColor = System.Drawing.Color.Transparent;
            this.logsButton.BackgroundImage = global::StudyTracker.Properties.Resources.SideBar;
            this.logsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logsButton.FlatAppearance.BorderSize = 0;
            this.logsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logsButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logsButton.Location = new System.Drawing.Point(13, 285);
            this.logsButton.Name = "logsButton";
            this.logsButton.Size = new System.Drawing.Size(181, 50);
            this.logsButton.TabIndex = 24;
            this.logsButton.Text = "All logs";
            this.logsButton.UseVisualStyleBackColor = false;
            this.logsButton.Click += new System.EventHandler(this.LogsButton_Click);
            this.logsButton.MouseEnter += new System.EventHandler(this.StartImage_MouseEnter);
            this.logsButton.MouseLeave += new System.EventHandler(this.StartImage_MouseLeave);
            // 
            // startSessionButton
            // 
            this.startSessionButton.BackColor = System.Drawing.Color.Transparent;
            this.startSessionButton.BackgroundImage = global::StudyTracker.Properties.Resources.SideBar;
            this.startSessionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.startSessionButton.FlatAppearance.BorderSize = 0;
            this.startSessionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startSessionButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startSessionButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.startSessionButton.Location = new System.Drawing.Point(13, 218);
            this.startSessionButton.Name = "startSessionButton";
            this.startSessionButton.Size = new System.Drawing.Size(181, 50);
            this.startSessionButton.TabIndex = 25;
            this.startSessionButton.Text = "Start";
            this.startSessionButton.UseVisualStyleBackColor = false;
            this.startSessionButton.Click += new System.EventHandler(this.StartButton_Click);
            this.startSessionButton.MouseEnter += new System.EventHandler(this.StartImage_MouseEnter);
            this.startSessionButton.MouseLeave += new System.EventHandler(this.StartImage_MouseLeave);
            // 
            // bookButton
            // 
            this.bookButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(57)))), ((int)(((byte)(76)))));
            this.bookButton.BackgroundImage = global::StudyTracker.Properties.Resources.Study_Tracker_Icon;
            this.bookButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bookButton.FlatAppearance.BorderSize = 0;
            this.bookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bookButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bookButton.Location = new System.Drawing.Point(24, 52);
            this.bookButton.Name = "bookButton";
            this.bookButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bookButton.Size = new System.Drawing.Size(160, 160);
            this.bookButton.TabIndex = 26;
            this.bookButton.UseVisualStyleBackColor = false;
            this.bookButton.Click += new System.EventHandler(this.StatisticsButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::StudyTracker.Properties.Resources.SideBar;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.Sidebar_TitleImage);
            this.panel1.Controls.Add(this.logsButton);
            this.panel1.Controls.Add(this.bookButton);
            this.panel1.Controls.Add(this.statsButton);
            this.panel1.Controls.Add(this.startSessionButton);
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.linkToMyLinkdin);
            this.panel1.Controls.Add(this.aboutButton);
            this.panel1.Controls.Add(this.optionsButton);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 700);
            this.panel1.TabIndex = 27;
            // 
            // DragWindow
            // 
            this.DragWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            this.DragWindow.Controls.Add(this.MinimiseButtonImage);
            this.DragWindow.Controls.Add(this.CloseButtonImage);
            this.DragWindow.Location = new System.Drawing.Point(-1, 0);
            this.DragWindow.Name = "DragWindow";
            this.DragWindow.Size = new System.Drawing.Size(704, 30);
            this.DragWindow.TabIndex = 28;
            this.DragWindow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragWindow_MouseDown);
            this.DragWindow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragWindow_MouseMove);
            this.DragWindow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragWindow_MouseUp);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(700, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DragWindow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 700);
            this.MinimumSize = new System.Drawing.Size(700, 700);
            this.Name = "BaseForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "StudyTrackerForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BaseForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BaseForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.CloseButtonImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimiseButtonImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sidebar_TitleImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.DragWindow.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox CloseButtonImage;
        private System.Windows.Forms.PictureBox MinimiseButtonImage;
        private System.Windows.Forms.PictureBox Sidebar_TitleImage;
        private System.Windows.Forms.LinkLabel linkToMyLinkdin;
        private System.Windows.Forms.ToolTip StatsToolTip;
        private System.Windows.Forms.Button optionsButton;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button statsButton;
        private System.Windows.Forms.Button logsButton;
        public System.Windows.Forms.Button startSessionButton;
        private System.Windows.Forms.Button bookButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel DragWindow;
    }
}