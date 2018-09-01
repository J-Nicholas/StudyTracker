namespace StudyTracker
{
    partial class StatsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatsForm));
            this.StudyChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.MinimiseButtonImage = new System.Windows.Forms.PictureBox();
            this.CloseButtonImage = new System.Windows.Forms.PictureBox();
            this.DragWindow = new System.Windows.Forms.PictureBox();
            this.StatsTitleImage = new System.Windows.Forms.Panel();
            this.TimeStudiedTodayLabel = new System.Windows.Forms.Label();
            this.TimeStudiedWeekLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TimeStudiedPanel = new System.Windows.Forms.Panel();
            this.TimeStudiedThisMonthValueLabel = new System.Windows.Forms.Label();
            this.TimeStudiedWeekValueLabel = new System.Windows.Forms.Label();
            this.TimeStudiedTodayValueLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TopicTimeSpentLabel = new System.Windows.Forms.Label();
            this.TimeFrameLabel = new System.Windows.Forms.Label();
            this.TopicLabel = new System.Windows.Forms.Label();
            this.TopicSpentLabel = new System.Windows.Forms.Label();
            this.TimeFrameBox = new System.Windows.Forms.ComboBox();
            this.TopicBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ChartTimeFrameCombo = new System.Windows.Forms.ComboBox();
            this.MaxLogsNumeric = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.StudyChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimiseButtonImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButtonImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DragWindow)).BeginInit();
            this.TimeStudiedPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxLogsNumeric)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudyChart
            // 
            this.StudyChart.BackColor = System.Drawing.Color.Transparent;
            this.StudyChart.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.StudyChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.StudyChart.Legends.Add(legend1);
            this.StudyChart.Location = new System.Drawing.Point(21, 74);
            this.StudyChart.Name = "StudyChart";
            this.StudyChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.StudyChart.Series.Add(series1);
            this.StudyChart.Size = new System.Drawing.Size(326, 251);
            this.StudyChart.TabIndex = 0;
            this.StudyChart.Text = "chart1";
            // 
            // MinimiseButtonImage
            // 
            this.MinimiseButtonImage.BackgroundImage = global::StudyTracker.Properties.Resources.Minimise_Icon;
            this.MinimiseButtonImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MinimiseButtonImage.Location = new System.Drawing.Point(334, 4);
            this.MinimiseButtonImage.Name = "MinimiseButtonImage";
            this.MinimiseButtonImage.Size = new System.Drawing.Size(25, 25);
            this.MinimiseButtonImage.TabIndex = 19;
            this.MinimiseButtonImage.TabStop = false;
            this.MinimiseButtonImage.Click += new System.EventHandler(this.MinimiseButtonImage_Click);
            this.MinimiseButtonImage.MouseEnter += new System.EventHandler(this.MinimiseButtonImage_MouseEnter);
            this.MinimiseButtonImage.MouseLeave += new System.EventHandler(this.MinimiseButtonImage_MouseLeave);
            // 
            // CloseButtonImage
            // 
            this.CloseButtonImage.BackgroundImage = global::StudyTracker.Properties.Resources.Close_Icon;
            this.CloseButtonImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseButtonImage.Location = new System.Drawing.Point(365, 4);
            this.CloseButtonImage.Name = "CloseButtonImage";
            this.CloseButtonImage.Size = new System.Drawing.Size(25, 25);
            this.CloseButtonImage.TabIndex = 18;
            this.CloseButtonImage.TabStop = false;
            this.CloseButtonImage.Click += new System.EventHandler(this.CloseButtonImage_Click);
            this.CloseButtonImage.MouseEnter += new System.EventHandler(this.CloseButtonImage_MouseEnter);
            this.CloseButtonImage.MouseLeave += new System.EventHandler(this.CloseButtonImage_MouseLeave);
            // 
            // DragWindow
            // 
            this.DragWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            this.DragWindow.Location = new System.Drawing.Point(0, -1);
            this.DragWindow.Name = "DragWindow";
            this.DragWindow.Size = new System.Drawing.Size(395, 30);
            this.DragWindow.TabIndex = 20;
            this.DragWindow.TabStop = false;
            this.DragWindow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragWindow_MouseDown);
            this.DragWindow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragWindow_MouseMove);
            this.DragWindow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragWindow_MouseUp);
            // 
            // StatsTitleImage
            // 
            this.StatsTitleImage.BackgroundImage = global::StudyTracker.Properties.Resources.Stats_Title;
            this.StatsTitleImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StatsTitleImage.Location = new System.Drawing.Point(23, 39);
            this.StatsTitleImage.Name = "StatsTitleImage";
            this.StatsTitleImage.Size = new System.Drawing.Size(341, 59);
            this.StatsTitleImage.TabIndex = 22;
            // 
            // TimeStudiedTodayLabel
            // 
            this.TimeStudiedTodayLabel.AutoSize = true;
            this.TimeStudiedTodayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeStudiedTodayLabel.Location = new System.Drawing.Point(20, 13);
            this.TimeStudiedTodayLabel.Name = "TimeStudiedTodayLabel";
            this.TimeStudiedTodayLabel.Size = new System.Drawing.Size(143, 18);
            this.TimeStudiedTodayLabel.TabIndex = 23;
            this.TimeStudiedTodayLabel.Text = "Time Studied Today:";
            // 
            // TimeStudiedWeekLabel
            // 
            this.TimeStudiedWeekLabel.AutoSize = true;
            this.TimeStudiedWeekLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeStudiedWeekLabel.Location = new System.Drawing.Point(20, 40);
            this.TimeStudiedWeekLabel.Name = "TimeStudiedWeekLabel";
            this.TimeStudiedWeekLabel.Size = new System.Drawing.Size(173, 18);
            this.TimeStudiedWeekLabel.TabIndex = 24;
            this.TimeStudiedWeekLabel.Text = "Time Studied This Week:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Time Studied This Month:";
            // 
            // TimeStudiedPanel
            // 
            this.TimeStudiedPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            this.TimeStudiedPanel.BackgroundImage = global::StudyTracker.Properties.Resources.Recent_Logs;
            this.TimeStudiedPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TimeStudiedPanel.Controls.Add(this.TimeStudiedThisMonthValueLabel);
            this.TimeStudiedPanel.Controls.Add(this.TimeStudiedWeekValueLabel);
            this.TimeStudiedPanel.Controls.Add(this.TimeStudiedTodayValueLabel);
            this.TimeStudiedPanel.Controls.Add(this.TimeStudiedTodayLabel);
            this.TimeStudiedPanel.Controls.Add(this.label2);
            this.TimeStudiedPanel.Controls.Add(this.TimeStudiedWeekLabel);
            this.TimeStudiedPanel.Location = new System.Drawing.Point(12, 104);
            this.TimeStudiedPanel.Name = "TimeStudiedPanel";
            this.TimeStudiedPanel.Size = new System.Drawing.Size(368, 100);
            this.TimeStudiedPanel.TabIndex = 26;
            // 
            // TimeStudiedThisMonthValueLabel
            // 
            this.TimeStudiedThisMonthValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeStudiedThisMonthValueLabel.Location = new System.Drawing.Point(202, 66);
            this.TimeStudiedThisMonthValueLabel.Name = "TimeStudiedThisMonthValueLabel";
            this.TimeStudiedThisMonthValueLabel.Size = new System.Drawing.Size(150, 18);
            this.TimeStudiedThisMonthValueLabel.TabIndex = 28;
            this.TimeStudiedThisMonthValueLabel.Text = "00:00:00";
            this.TimeStudiedThisMonthValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TimeStudiedWeekValueLabel
            // 
            this.TimeStudiedWeekValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeStudiedWeekValueLabel.Location = new System.Drawing.Point(199, 39);
            this.TimeStudiedWeekValueLabel.Name = "TimeStudiedWeekValueLabel";
            this.TimeStudiedWeekValueLabel.Size = new System.Drawing.Size(154, 18);
            this.TimeStudiedWeekValueLabel.TabIndex = 27;
            this.TimeStudiedWeekValueLabel.Text = "00:00:00";
            this.TimeStudiedWeekValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TimeStudiedTodayValueLabel
            // 
            this.TimeStudiedTodayValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeStudiedTodayValueLabel.Location = new System.Drawing.Point(202, 12);
            this.TimeStudiedTodayValueLabel.Name = "TimeStudiedTodayValueLabel";
            this.TimeStudiedTodayValueLabel.Size = new System.Drawing.Size(151, 18);
            this.TimeStudiedTodayValueLabel.TabIndex = 26;
            this.TimeStudiedTodayValueLabel.Text = "00:00:00";
            this.TimeStudiedTodayValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 18);
            this.label1.TabIndex = 29;
            this.label1.Text = "Time Spent By Topic:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            this.panel1.BackgroundImage = global::StudyTracker.Properties.Resources.Recent_Logs;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.TopicTimeSpentLabel);
            this.panel1.Controls.Add(this.TimeFrameLabel);
            this.panel1.Controls.Add(this.TopicLabel);
            this.panel1.Controls.Add(this.TopicSpentLabel);
            this.panel1.Controls.Add(this.TimeFrameBox);
            this.panel1.Controls.Add(this.TopicBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 217);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 130);
            this.panel1.TabIndex = 0;
            // 
            // TopicTimeSpentLabel
            // 
            this.TopicTimeSpentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopicTimeSpentLabel.Location = new System.Drawing.Point(187, 89);
            this.TopicTimeSpentLabel.Name = "TopicTimeSpentLabel";
            this.TopicTimeSpentLabel.Size = new System.Drawing.Size(165, 18);
            this.TopicTimeSpentLabel.TabIndex = 35;
            this.TopicTimeSpentLabel.Text = "00:00:00";
            this.TopicTimeSpentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TimeFrameLabel
            // 
            this.TimeFrameLabel.AutoSize = true;
            this.TimeFrameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeFrameLabel.Location = new System.Drawing.Point(218, 53);
            this.TimeFrameLabel.Name = "TimeFrameLabel";
            this.TimeFrameLabel.Size = new System.Drawing.Size(51, 18);
            this.TimeFrameLabel.TabIndex = 34;
            this.TimeFrameLabel.Text = "When:";
            // 
            // TopicLabel
            // 
            this.TopicLabel.AutoSize = true;
            this.TopicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopicLabel.Location = new System.Drawing.Point(18, 53);
            this.TopicLabel.Name = "TopicLabel";
            this.TopicLabel.Size = new System.Drawing.Size(49, 18);
            this.TopicLabel.TabIndex = 33;
            this.TopicLabel.Text = "Topic:";
            // 
            // TopicSpentLabel
            // 
            this.TopicSpentLabel.AutoSize = true;
            this.TopicSpentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopicSpentLabel.Location = new System.Drawing.Point(20, 89);
            this.TopicSpentLabel.Name = "TopicSpentLabel";
            this.TopicSpentLabel.Size = new System.Drawing.Size(129, 18);
            this.TopicSpentLabel.TabIndex = 32;
            this.TopicSpentLabel.Text = "Topic Studied For:";
            // 
            // TimeFrameBox
            // 
            this.TimeFrameBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TimeFrameBox.FormattingEnabled = true;
            this.TimeFrameBox.Items.AddRange(new object[] {
            "Today",
            "This Week",
            "This Month",
            "This Year",
            "Total"});
            this.TimeFrameBox.Location = new System.Drawing.Point(273, 53);
            this.TimeFrameBox.Name = "TimeFrameBox";
            this.TimeFrameBox.Size = new System.Drawing.Size(80, 21);
            this.TimeFrameBox.TabIndex = 1;
            this.TimeFrameBox.SelectedIndexChanged += new System.EventHandler(this.TopicBox_SelectedIndexChanged);
            // 
            // TopicBox
            // 
            this.TopicBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TopicBox.FormattingEnabled = true;
            this.TopicBox.Items.AddRange(new object[] {
            ""});
            this.TopicBox.Location = new System.Drawing.Point(70, 53);
            this.TopicBox.Name = "TopicBox";
            this.TopicBox.Size = new System.Drawing.Size(142, 21);
            this.TopicBox.TabIndex = 0;
            this.TopicBox.SelectedIndexChanged += new System.EventHandler(this.TopicBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 37;
            this.label3.Text = "When:";
            // 
            // ChartTimeFrameCombo
            // 
            this.ChartTimeFrameCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChartTimeFrameCombo.FormattingEnabled = true;
            this.ChartTimeFrameCombo.Items.AddRange(new object[] {
            "Today",
            "This Week",
            "This Month",
            "This Year",
            "Total"});
            this.ChartTimeFrameCombo.Location = new System.Drawing.Point(100, 45);
            this.ChartTimeFrameCombo.Name = "ChartTimeFrameCombo";
            this.ChartTimeFrameCombo.Size = new System.Drawing.Size(80, 21);
            this.ChartTimeFrameCombo.TabIndex = 0;
            this.ChartTimeFrameCombo.SelectedIndexChanged += new System.EventHandler(this.ChartTimeFrameCombo_SelectedIndexChanged);
            // 
            // MaxLogsNumeric
            // 
            this.MaxLogsNumeric.Location = new System.Drawing.Point(273, 45);
            this.MaxLogsNumeric.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.MaxLogsNumeric.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.MaxLogsNumeric.Name = "MaxLogsNumeric";
            this.MaxLogsNumeric.Size = new System.Drawing.Size(33, 20);
            this.MaxLogsNumeric.TabIndex = 1;
            this.MaxLogsNumeric.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.MaxLogsNumeric.ValueChanged += new System.EventHandler(this.ChartTimeFrameCombo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(202, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 18);
            this.label4.TabIndex = 39;
            this.label4.Text = "Top:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(114, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 18);
            this.label5.TabIndex = 36;
            this.label5.Text = "Time Studying Ratio";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            this.panel2.BackgroundImage = global::StudyTracker.Properties.Resources.Recent_Logs;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.MaxLogsNumeric);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.ChartTimeFrameCombo);
            this.panel2.Controls.Add(this.StudyChart);
            this.panel2.Location = new System.Drawing.Point(12, 360);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 332);
            this.panel2.TabIndex = 1;
            // 
            // StatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(392, 700);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TimeStudiedPanel);
            this.Controls.Add(this.StatsTitleImage);
            this.Controls.Add(this.MinimiseButtonImage);
            this.Controls.Add(this.CloseButtonImage);
            this.Controls.Add(this.DragWindow);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StatsForm";
            this.Text = "StatsForm";
            this.Activated += new System.EventHandler(this.StatsForm_VisibleChanged);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StatsForm_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.StatsForm_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.StudyChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimiseButtonImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButtonImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DragWindow)).EndInit();
            this.TimeStudiedPanel.ResumeLayout(false);
            this.TimeStudiedPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxLogsNumeric)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart StudyChart;
        private System.Windows.Forms.PictureBox MinimiseButtonImage;
        private System.Windows.Forms.PictureBox CloseButtonImage;
        private System.Windows.Forms.PictureBox DragWindow;
        private System.Windows.Forms.Panel StatsTitleImage;
        private System.Windows.Forms.Label TimeStudiedTodayLabel;
        private System.Windows.Forms.Label TimeStudiedWeekLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel TimeStudiedPanel;
        private System.Windows.Forms.Label TimeStudiedThisMonthValueLabel;
        private System.Windows.Forms.Label TimeStudiedWeekValueLabel;
        private System.Windows.Forms.Label TimeStudiedTodayValueLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TopicTimeSpentLabel;
        private System.Windows.Forms.Label TimeFrameLabel;
        private System.Windows.Forms.Label TopicLabel;
        private System.Windows.Forms.Label TopicSpentLabel;
        private System.Windows.Forms.ComboBox TimeFrameBox;
        private System.Windows.Forms.ComboBox TopicBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ChartTimeFrameCombo;
        private System.Windows.Forms.NumericUpDown MaxLogsNumeric;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
    }
}