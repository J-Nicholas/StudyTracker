namespace StudyTracker
{
    partial class LogsDB
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogsDB));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.LogsDBView = new System.Windows.Forms.DataGridView();
            this.logsTopic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logsDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logsStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logsEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logsStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logsEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logsTimeStudied = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studyLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToFileToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CloseDatabaseStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FilterByToday = new System.Windows.Forms.ToolStripMenuItem();
            this.FilterByWeek = new System.Windows.Forms.ToolStripMenuItem();
            this.FilterByMonth = new System.Windows.Forms.ToolStripMenuItem();
            this.FilterByYear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.FilterViewAll = new System.Windows.Forms.ToolStripMenuItem();
            this.NewEntryMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.LogsDBView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studyLogBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 24);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 337);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // LogsDBView
            // 
            this.LogsDBView.AllowUserToOrderColumns = true;
            this.LogsDBView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogsDBView.AutoGenerateColumns = false;
            this.LogsDBView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.LogsDBView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LogsDBView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.logsTopic,
            this.logsDescription,
            this.logsStartTime,
            this.logsEndTime,
            this.logsStartDate,
            this.logsEndDate,
            this.logsTimeStudied});
            this.LogsDBView.DataSource = this.studyLogBindingSource;
            this.LogsDBView.Location = new System.Drawing.Point(0, 28);
            this.LogsDBView.Name = "LogsDBView";
            this.LogsDBView.Size = new System.Drawing.Size(679, 333);
            this.LogsDBView.TabIndex = 1;
            this.LogsDBView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.LogsDBView_CellBeginEdit);
            this.LogsDBView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.LogsDBView_CellValidating);
            this.LogsDBView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.LogsDBView_UserAddedRow);
            this.LogsDBView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.LogsDBView_UserDeletedRow);
            this.LogsDBView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.LogsDBView_UserDeletingRow);
            // 
            // logsTopic
            // 
            this.logsTopic.DataPropertyName = "Topic";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.logsTopic.DefaultCellStyle = dataGridViewCellStyle1;
            this.logsTopic.HeaderText = "Topic";
            this.logsTopic.MinimumWidth = 100;
            this.logsTopic.Name = "logsTopic";
            // 
            // logsDescription
            // 
            this.logsDescription.DataPropertyName = "Description";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.logsDescription.DefaultCellStyle = dataGridViewCellStyle2;
            this.logsDescription.FillWeight = 150F;
            this.logsDescription.HeaderText = "Description";
            this.logsDescription.MinimumWidth = 150;
            this.logsDescription.Name = "logsDescription";
            this.logsDescription.Width = 150;
            // 
            // logsStartTime
            // 
            this.logsStartTime.DataPropertyName = "StartTime";
            this.logsStartTime.FillWeight = 50F;
            this.logsStartTime.HeaderText = "Start Time";
            this.logsStartTime.MinimumWidth = 50;
            this.logsStartTime.Name = "logsStartTime";
            this.logsStartTime.Width = 80;
            // 
            // logsEndTime
            // 
            this.logsEndTime.DataPropertyName = "EndTime";
            this.logsEndTime.FillWeight = 50F;
            this.logsEndTime.HeaderText = "End Time";
            this.logsEndTime.MinimumWidth = 50;
            this.logsEndTime.Name = "logsEndTime";
            this.logsEndTime.Width = 77;
            // 
            // logsStartDate
            // 
            this.logsStartDate.DataPropertyName = "StartDate";
            this.logsStartDate.FillWeight = 70F;
            this.logsStartDate.HeaderText = "Start Date";
            this.logsStartDate.MinimumWidth = 50;
            this.logsStartDate.Name = "logsStartDate";
            this.logsStartDate.Width = 80;
            // 
            // logsEndDate
            // 
            this.logsEndDate.DataPropertyName = "EndDate";
            this.logsEndDate.FillWeight = 70F;
            this.logsEndDate.HeaderText = "End Date";
            this.logsEndDate.MinimumWidth = 50;
            this.logsEndDate.Name = "logsEndDate";
            this.logsEndDate.Width = 77;
            // 
            // logsTimeStudied
            // 
            this.logsTimeStudied.DataPropertyName = "TimeStudied";
            this.logsTimeStudied.FillWeight = 50F;
            this.logsTimeStudied.HeaderText = "Time Studied";
            this.logsTimeStudied.MinimumWidth = 50;
            this.logsTimeStudied.Name = "logsTimeStudied";
            this.logsTimeStudied.Width = 94;
            // 
            // studyLogBindingSource
            // 
            this.studyLogBindingSource.DataSource = typeof(StudyTracker.StudyLog);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.filterToolStripMenuItem,
            this.NewEntryMenuButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveToFileToolStrip,
            this.toolStripSeparator1,
            this.CloseDatabaseStrip});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // SaveToFileToolStrip
            // 
            this.SaveToFileToolStrip.Name = "SaveToFileToolStrip";
            this.SaveToFileToolStrip.Size = new System.Drawing.Size(154, 22);
            this.SaveToFileToolStrip.Text = "Save";
            this.SaveToFileToolStrip.Click += new System.EventHandler(this.SaveToFileToolStrip_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(151, 6);
            // 
            // CloseDatabaseStrip
            // 
            this.CloseDatabaseStrip.Name = "CloseDatabaseStrip";
            this.CloseDatabaseStrip.Size = new System.Drawing.Size(154, 22);
            this.CloseDatabaseStrip.Text = "Close Database";
            this.CloseDatabaseStrip.Click += new System.EventHandler(this.closeDatabaseToolStripMenuItem_Click);
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FilterByToday,
            this.FilterByWeek,
            this.FilterByMonth,
            this.FilterByYear,
            this.toolStripSeparator2,
            this.FilterViewAll});
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.filterToolStripMenuItem.Text = "Filter";
            // 
            // FilterByToday
            // 
            this.FilterByToday.Name = "FilterByToday";
            this.FilterByToday.Size = new System.Drawing.Size(180, 22);
            this.FilterByToday.Text = "Today";
            this.FilterByToday.Click += new System.EventHandler(this.FilterByToday_Click);
            // 
            // FilterByWeek
            // 
            this.FilterByWeek.Name = "FilterByWeek";
            this.FilterByWeek.Size = new System.Drawing.Size(180, 22);
            this.FilterByWeek.Text = "This Week";
            this.FilterByWeek.Click += new System.EventHandler(this.FilterByWeek_Click);
            // 
            // FilterByMonth
            // 
            this.FilterByMonth.Name = "FilterByMonth";
            this.FilterByMonth.Size = new System.Drawing.Size(180, 22);
            this.FilterByMonth.Text = "This Month";
            this.FilterByMonth.Click += new System.EventHandler(this.FilterByMonth_Click);
            // 
            // FilterByYear
            // 
            this.FilterByYear.Name = "FilterByYear";
            this.FilterByYear.Size = new System.Drawing.Size(180, 22);
            this.FilterByYear.Text = "This Year";
            this.FilterByYear.Click += new System.EventHandler(this.FilterByYear_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // FilterViewAll
            // 
            this.FilterViewAll.Checked = true;
            this.FilterViewAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FilterViewAll.Name = "FilterViewAll";
            this.FilterViewAll.Size = new System.Drawing.Size(180, 22);
            this.FilterViewAll.Text = "View All";
            this.FilterViewAll.Click += new System.EventHandler(this.FilterViewAll_Click);
            // 
            // NewEntryMenuButton
            // 
            this.NewEntryMenuButton.Name = "NewEntryMenuButton";
            this.NewEntryMenuButton.Size = new System.Drawing.Size(73, 20);
            this.NewEntryMenuButton.Text = "New Entry";
            this.NewEntryMenuButton.Click += new System.EventHandler(this.NewEntryMenuButton_Click);
            // 
            // LogsDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.LogsDBView);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LogsDB";
            this.Text = "Study Log Database";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LogsDB_FormClosing);
            this.Load += new System.EventHandler(this.LogsDB_Load);
            this.VisibleChanged += new System.EventHandler(this.LogsDB_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.LogsDBView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studyLogBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridView LogsDBView;
        private System.Windows.Forms.BindingSource studyLogBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn logsTopic;
        private System.Windows.Forms.DataGridViewTextBoxColumn logsDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn logsStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn logsEndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn logsStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn logsEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn logsTimeStudied;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToFileToolStrip;
        private System.Windows.Forms.ToolStripMenuItem CloseDatabaseStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FilterByToday;
        private System.Windows.Forms.ToolStripMenuItem FilterByWeek;
        private System.Windows.Forms.ToolStripMenuItem FilterByMonth;
        private System.Windows.Forms.ToolStripMenuItem FilterByYear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem FilterViewAll;
        private System.Windows.Forms.ToolStripMenuItem NewEntryMenuButton;
    }
}