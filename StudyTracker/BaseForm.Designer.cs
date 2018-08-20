﻿namespace StudyTracker
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
            this.CloseButtonImage = new System.Windows.Forms.PictureBox();
            this.MinimiseButtonImage = new System.Windows.Forms.PictureBox();
            this.SidebarImage = new System.Windows.Forms.PictureBox();
            this.SideBar_BookImage = new System.Windows.Forms.PictureBox();
            this.Sidebar_TitleImage = new System.Windows.Forms.PictureBox();
            this.linkToMyLinkdin = new System.Windows.Forms.LinkLabel();
            this.startLabel = new System.Windows.Forms.Label();
            this.logsLabel = new System.Windows.Forms.Label();
            this.AboutLabel = new System.Windows.Forms.Label();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.StartImage = new System.Windows.Forms.PictureBox();
            this.LogsImage = new System.Windows.Forms.PictureBox();
            this.ExitImage = new System.Windows.Forms.PictureBox();
            this.AboutImage = new System.Windows.Forms.PictureBox();
            this.DragWindow = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButtonImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimiseButtonImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SidebarImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SideBar_BookImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sidebar_TitleImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogsImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AboutImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DragWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButtonImage
            // 
            this.CloseButtonImage.BackgroundImage = global::StudyTracker.Properties.Resources.Close_Icon;
            this.CloseButtonImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseButtonImage.Location = new System.Drawing.Point(663, 5);
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
            this.MinimiseButtonImage.Location = new System.Drawing.Point(632, 5);
            this.MinimiseButtonImage.Name = "MinimiseButtonImage";
            this.MinimiseButtonImage.Size = new System.Drawing.Size(25, 25);
            this.MinimiseButtonImage.TabIndex = 2;
            this.MinimiseButtonImage.TabStop = false;
            this.MinimiseButtonImage.Click += new System.EventHandler(this.MinimiseButtonImage_Click);
            this.MinimiseButtonImage.MouseEnter += new System.EventHandler(this.MinimiseButtonImage_MouseEnter);
            this.MinimiseButtonImage.MouseLeave += new System.EventHandler(this.MinimiseButtonImage_MouseLeave);
            // 
            // SidebarImage
            // 
            this.SidebarImage.BackgroundImage = global::StudyTracker.Properties.Resources.SideBar;
            this.SidebarImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SidebarImage.Location = new System.Drawing.Point(-1, 0);
            this.SidebarImage.Name = "SidebarImage";
            this.SidebarImage.Size = new System.Drawing.Size(210, 700);
            this.SidebarImage.TabIndex = 3;
            this.SidebarImage.TabStop = false;
            // 
            // SideBar_BookImage
            // 
            this.SideBar_BookImage.BackColor = System.Drawing.Color.Transparent;
            this.SideBar_BookImage.BackgroundImage = global::StudyTracker.Properties.Resources.SideBar_Book;
            this.SideBar_BookImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SideBar_BookImage.Location = new System.Drawing.Point(19, 52);
            this.SideBar_BookImage.Name = "SideBar_BookImage";
            this.SideBar_BookImage.Size = new System.Drawing.Size(160, 160);
            this.SideBar_BookImage.TabIndex = 4;
            this.SideBar_BookImage.TabStop = false;
            // 
            // Sidebar_TitleImage
            // 
            this.Sidebar_TitleImage.BackColor = System.Drawing.Color.Transparent;
            this.Sidebar_TitleImage.BackgroundImage = global::StudyTracker.Properties.Resources.StudyTrackerTitle;
            this.Sidebar_TitleImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Sidebar_TitleImage.Location = new System.Drawing.Point(19, -1);
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
            this.linkToMyLinkdin.Location = new System.Drawing.Point(26, 663);
            this.linkToMyLinkdin.Name = "linkToMyLinkdin";
            this.linkToMyLinkdin.Size = new System.Drawing.Size(143, 18);
            this.linkToMyLinkdin.TabIndex = 6;
            this.linkToMyLinkdin.TabStop = true;
            this.linkToMyLinkdin.Text = "Johnathan Nicholas";
            this.linkToMyLinkdin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkToMyLinkdin_LinkClicked);
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.BackColor = System.Drawing.Color.Transparent;
            this.startLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.startLabel.Location = new System.Drawing.Point(72, 297);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(56, 24);
            this.startLabel.TabIndex = 7;
            this.startLabel.Text = "Start";
            this.startLabel.Click += new System.EventHandler(this.StartImage_Click);
            this.startLabel.MouseEnter += new System.EventHandler(this.StartImage_MouseEnter);
            this.startLabel.MouseLeave += new System.EventHandler(this.StartImage_MouseLeave);
            // 
            // logsLabel
            // 
            this.logsLabel.AutoSize = true;
            this.logsLabel.BackColor = System.Drawing.Color.Transparent;
            this.logsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logsLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logsLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logsLabel.Location = new System.Drawing.Point(71, 369);
            this.logsLabel.Name = "logsLabel";
            this.logsLabel.Size = new System.Drawing.Size(55, 24);
            this.logsLabel.TabIndex = 8;
            this.logsLabel.Text = "Logs";
            this.logsLabel.MouseEnter += new System.EventHandler(this.StartImage_MouseEnter);
            this.logsLabel.MouseLeave += new System.EventHandler(this.StartImage_MouseLeave);
            // 
            // AboutLabel
            // 
            this.AboutLabel.AutoSize = true;
            this.AboutLabel.BackColor = System.Drawing.Color.Transparent;
            this.AboutLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AboutLabel.Location = new System.Drawing.Point(66, 441);
            this.AboutLabel.Name = "AboutLabel";
            this.AboutLabel.Size = new System.Drawing.Size(66, 24);
            this.AboutLabel.TabIndex = 9;
            this.AboutLabel.Text = "About";
            this.AboutLabel.Click += new System.EventHandler(this.AboutImage_Click);
            this.AboutLabel.MouseEnter += new System.EventHandler(this.StartImage_MouseEnter);
            this.AboutLabel.MouseLeave += new System.EventHandler(this.StartImage_MouseLeave);
            // 
            // ExitLabel
            // 
            this.ExitLabel.AutoSize = true;
            this.ExitLabel.BackColor = System.Drawing.Color.Transparent;
            this.ExitLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExitLabel.Location = new System.Drawing.Point(74, 513);
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(46, 24);
            this.ExitLabel.TabIndex = 10;
            this.ExitLabel.Text = "Exit";
            this.ExitLabel.Click += new System.EventHandler(this.CloseButtonImage_Click);
            this.ExitLabel.MouseEnter += new System.EventHandler(this.StartImage_MouseEnter);
            this.ExitLabel.MouseLeave += new System.EventHandler(this.StartImage_MouseLeave);
            // 
            // StartImage
            // 
            this.StartImage.BackColor = System.Drawing.Color.Transparent;
            this.StartImage.Location = new System.Drawing.Point(9, 283);
            this.StartImage.Name = "StartImage";
            this.StartImage.Size = new System.Drawing.Size(181, 50);
            this.StartImage.TabIndex = 11;
            this.StartImage.TabStop = false;
            this.StartImage.Click += new System.EventHandler(this.StartImage_Click);
            this.StartImage.MouseEnter += new System.EventHandler(this.StartImage_MouseEnter);
            this.StartImage.MouseLeave += new System.EventHandler(this.StartImage_MouseLeave);
            // 
            // LogsImage
            // 
            this.LogsImage.BackColor = System.Drawing.Color.Transparent;
            this.LogsImage.Location = new System.Drawing.Point(9, 356);
            this.LogsImage.Name = "LogsImage";
            this.LogsImage.Size = new System.Drawing.Size(181, 50);
            this.LogsImage.TabIndex = 12;
            this.LogsImage.TabStop = false;
            this.LogsImage.MouseEnter += new System.EventHandler(this.StartImage_MouseEnter);
            this.LogsImage.MouseLeave += new System.EventHandler(this.StartImage_MouseLeave);
            // 
            // ExitImage
            // 
            this.ExitImage.BackColor = System.Drawing.Color.Transparent;
            this.ExitImage.Location = new System.Drawing.Point(9, 502);
            this.ExitImage.Name = "ExitImage";
            this.ExitImage.Size = new System.Drawing.Size(181, 50);
            this.ExitImage.TabIndex = 16;
            this.ExitImage.TabStop = false;
            this.ExitImage.Click += new System.EventHandler(this.CloseButtonImage_Click);
            this.ExitImage.MouseEnter += new System.EventHandler(this.StartImage_MouseEnter);
            this.ExitImage.MouseLeave += new System.EventHandler(this.StartImage_MouseLeave);
            // 
            // AboutImage
            // 
            this.AboutImage.BackColor = System.Drawing.Color.Transparent;
            this.AboutImage.Location = new System.Drawing.Point(9, 429);
            this.AboutImage.Name = "AboutImage";
            this.AboutImage.Size = new System.Drawing.Size(181, 50);
            this.AboutImage.TabIndex = 15;
            this.AboutImage.TabStop = false;
            this.AboutImage.Click += new System.EventHandler(this.AboutImage_Click);
            this.AboutImage.MouseEnter += new System.EventHandler(this.StartImage_MouseEnter);
            this.AboutImage.MouseLeave += new System.EventHandler(this.StartImage_MouseLeave);
            // 
            // DragWindow
            // 
            this.DragWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.DragWindow.Location = new System.Drawing.Point(215, 0);
            this.DragWindow.Name = "DragWindow";
            this.DragWindow.Size = new System.Drawing.Size(488, 30);
            this.DragWindow.TabIndex = 17;
            this.DragWindow.TabStop = false;
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
            this.Controls.Add(this.ExitImage);
            this.Controls.Add(this.AboutImage);
            this.Controls.Add(this.LogsImage);
            this.Controls.Add(this.StartImage);
            this.Controls.Add(this.ExitLabel);
            this.Controls.Add(this.AboutLabel);
            this.Controls.Add(this.logsLabel);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.linkToMyLinkdin);
            this.Controls.Add(this.Sidebar_TitleImage);
            this.Controls.Add(this.SideBar_BookImage);
            this.Controls.Add(this.SidebarImage);
            this.Controls.Add(this.MinimiseButtonImage);
            this.Controls.Add(this.CloseButtonImage);
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
            ((System.ComponentModel.ISupportInitialize)(this.SidebarImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SideBar_BookImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sidebar_TitleImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogsImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AboutImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DragWindow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox CloseButtonImage;
        private System.Windows.Forms.PictureBox MinimiseButtonImage;
        private System.Windows.Forms.PictureBox SidebarImage;
        private System.Windows.Forms.PictureBox SideBar_BookImage;
        private System.Windows.Forms.PictureBox Sidebar_TitleImage;
        private System.Windows.Forms.LinkLabel linkToMyLinkdin;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label logsLabel;
        private System.Windows.Forms.Label AboutLabel;
        private System.Windows.Forms.Label ExitLabel;
        private System.Windows.Forms.PictureBox StartImage;
        private System.Windows.Forms.PictureBox LogsImage;
        private System.Windows.Forms.PictureBox ExitImage;
        private System.Windows.Forms.PictureBox AboutImage;
        private System.Windows.Forms.PictureBox DragWindow;
    }
}