namespace StudyTracker
{
    partial class FilterDialogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterDialogForm));
            this.FilterGroup = new System.Windows.Forms.GroupBox();
            this.TimeFrameFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.TopicFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.DateFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.DatePickerFilter = new System.Windows.Forms.DateTimePicker();
            this.DateFilterLabel = new System.Windows.Forms.Label();
            this.TopicFilterComboBox = new System.Windows.Forms.ComboBox();
            this.TopicFilterLabel = new System.Windows.Forms.Label();
            this.TimeFrameLabel = new System.Windows.Forms.Label();
            this.TimeFrameComboBox = new System.Windows.Forms.ComboBox();
            this.ApplyFilterButton = new System.Windows.Forms.Button();
            this.ClearFilterButton = new System.Windows.Forms.Button();
            this.OkayFilterDialogButton = new System.Windows.Forms.Button();
            this.FilterGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // FilterGroup
            // 
            this.FilterGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterGroup.Controls.Add(this.TimeFrameFilterCheckBox);
            this.FilterGroup.Controls.Add(this.TopicFilterCheckBox);
            this.FilterGroup.Controls.Add(this.DateFilterCheckBox);
            this.FilterGroup.Controls.Add(this.DatePickerFilter);
            this.FilterGroup.Controls.Add(this.DateFilterLabel);
            this.FilterGroup.Controls.Add(this.TopicFilterComboBox);
            this.FilterGroup.Controls.Add(this.TopicFilterLabel);
            this.FilterGroup.Controls.Add(this.TimeFrameLabel);
            this.FilterGroup.Controls.Add(this.TimeFrameComboBox);
            this.FilterGroup.Location = new System.Drawing.Point(12, 24);
            this.FilterGroup.Name = "FilterGroup";
            this.FilterGroup.Size = new System.Drawing.Size(274, 206);
            this.FilterGroup.TabIndex = 0;
            this.FilterGroup.TabStop = false;
            this.FilterGroup.Text = "Filter";
            // 
            // TimeFrameFilterCheckBox
            // 
            this.TimeFrameFilterCheckBox.AutoSize = true;
            this.TimeFrameFilterCheckBox.Location = new System.Drawing.Point(94, 97);
            this.TimeFrameFilterCheckBox.Name = "TimeFrameFilterCheckBox";
            this.TimeFrameFilterCheckBox.Size = new System.Drawing.Size(15, 14);
            this.TimeFrameFilterCheckBox.TabIndex = 9;
            this.TimeFrameFilterCheckBox.UseVisualStyleBackColor = true;
            this.TimeFrameFilterCheckBox.Click += new System.EventHandler(this.FilterCheckBoxes_CheckedChanged);
            // 
            // TopicFilterCheckBox
            // 
            this.TopicFilterCheckBox.AutoSize = true;
            this.TopicFilterCheckBox.Location = new System.Drawing.Point(94, 49);
            this.TopicFilterCheckBox.Name = "TopicFilterCheckBox";
            this.TopicFilterCheckBox.Size = new System.Drawing.Size(15, 14);
            this.TopicFilterCheckBox.TabIndex = 8;
            this.TopicFilterCheckBox.UseVisualStyleBackColor = true;
            this.TopicFilterCheckBox.Click += new System.EventHandler(this.FilterCheckBoxes_CheckedChanged);
            // 
            // DateFilterCheckBox
            // 
            this.DateFilterCheckBox.AutoSize = true;
            this.DateFilterCheckBox.Location = new System.Drawing.Point(94, 146);
            this.DateFilterCheckBox.Name = "DateFilterCheckBox";
            this.DateFilterCheckBox.Size = new System.Drawing.Size(15, 14);
            this.DateFilterCheckBox.TabIndex = 7;
            this.DateFilterCheckBox.UseVisualStyleBackColor = true;
            this.DateFilterCheckBox.Click += new System.EventHandler(this.FilterCheckBoxes_CheckedChanged);
            // 
            // DatePickerFilter
            // 
            this.DatePickerFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DatePickerFilter.Enabled = false;
            this.DatePickerFilter.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePickerFilter.Location = new System.Drawing.Point(118, 141);
            this.DatePickerFilter.Name = "DatePickerFilter";
            this.DatePickerFilter.Size = new System.Drawing.Size(121, 20);
            this.DatePickerFilter.TabIndex = 6;
            // 
            // DateFilterLabel
            // 
            this.DateFilterLabel.AutoSize = true;
            this.DateFilterLabel.Location = new System.Drawing.Point(26, 145);
            this.DateFilterLabel.Name = "DateFilterLabel";
            this.DateFilterLabel.Size = new System.Drawing.Size(48, 13);
            this.DateFilterLabel.TabIndex = 4;
            this.DateFilterLabel.Text = "By Date:";
            // 
            // TopicFilterComboBox
            // 
            this.TopicFilterComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TopicFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TopicFilterComboBox.Enabled = false;
            this.TopicFilterComboBox.FormattingEnabled = true;
            this.TopicFilterComboBox.Location = new System.Drawing.Point(118, 45);
            this.TopicFilterComboBox.Name = "TopicFilterComboBox";
            this.TopicFilterComboBox.Size = new System.Drawing.Size(121, 21);
            this.TopicFilterComboBox.Sorted = true;
            this.TopicFilterComboBox.TabIndex = 3;
            this.TopicFilterComboBox.SelectedIndexChanged += new System.EventHandler(this.TopicFilterComboBox_SelectedIndexChanged);
            // 
            // TopicFilterLabel
            // 
            this.TopicFilterLabel.AutoSize = true;
            this.TopicFilterLabel.Location = new System.Drawing.Point(26, 49);
            this.TopicFilterLabel.Name = "TopicFilterLabel";
            this.TopicFilterLabel.Size = new System.Drawing.Size(52, 13);
            this.TopicFilterLabel.TabIndex = 2;
            this.TopicFilterLabel.Text = "By Topic:";
            // 
            // TimeFrameLabel
            // 
            this.TimeFrameLabel.AutoSize = true;
            this.TimeFrameLabel.Location = new System.Drawing.Point(26, 97);
            this.TimeFrameLabel.Name = "TimeFrameLabel";
            this.TimeFrameLabel.Size = new System.Drawing.Size(65, 13);
            this.TimeFrameLabel.TabIndex = 1;
            this.TimeFrameLabel.Text = "Time Frame:";
            // 
            // TimeFrameComboBox
            // 
            this.TimeFrameComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeFrameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TimeFrameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.TimeFrameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TimeFrameComboBox.Enabled = false;
            this.TimeFrameComboBox.FormattingEnabled = true;
            this.TimeFrameComboBox.Items.AddRange(new object[] {
            "Today",
            "Last 7 days",
            "Last 30 days",
            "last 12 months"});
            this.TimeFrameComboBox.Location = new System.Drawing.Point(118, 94);
            this.TimeFrameComboBox.Name = "TimeFrameComboBox";
            this.TimeFrameComboBox.Size = new System.Drawing.Size(121, 21);
            this.TimeFrameComboBox.TabIndex = 0;
            // 
            // ApplyFilterButton
            // 
            this.ApplyFilterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplyFilterButton.Enabled = false;
            this.ApplyFilterButton.Location = new System.Drawing.Point(130, 266);
            this.ApplyFilterButton.Name = "ApplyFilterButton";
            this.ApplyFilterButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyFilterButton.TabIndex = 1;
            this.ApplyFilterButton.Text = "Apply";
            this.ApplyFilterButton.UseVisualStyleBackColor = true;
            this.ApplyFilterButton.Click += new System.EventHandler(this.ApplyFilterButton_Click);
            // 
            // ClearFilterButton
            // 
            this.ClearFilterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearFilterButton.Location = new System.Drawing.Point(12, 266);
            this.ClearFilterButton.Name = "ClearFilterButton";
            this.ClearFilterButton.Size = new System.Drawing.Size(75, 23);
            this.ClearFilterButton.TabIndex = 2;
            this.ClearFilterButton.Text = "Clear Filter";
            this.ClearFilterButton.UseVisualStyleBackColor = true;
            this.ClearFilterButton.Click += new System.EventHandler(this.ClearFilterButton_Click);
            // 
            // OkayFilterDialogButton
            // 
            this.OkayFilterDialogButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkayFilterDialogButton.Location = new System.Drawing.Point(211, 266);
            this.OkayFilterDialogButton.Name = "OkayFilterDialogButton";
            this.OkayFilterDialogButton.Size = new System.Drawing.Size(75, 23);
            this.OkayFilterDialogButton.TabIndex = 2;
            this.OkayFilterDialogButton.Text = "OK";
            this.OkayFilterDialogButton.UseVisualStyleBackColor = true;
            this.OkayFilterDialogButton.Click += new System.EventHandler(this.OkayFilterDialogButton_Click);
            // 
            // FilterDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 301);
            this.Controls.Add(this.ClearFilterButton);
            this.Controls.Add(this.OkayFilterDialogButton);
            this.Controls.Add(this.FilterGroup);
            this.Controls.Add(this.ApplyFilterButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(360, 340);
            this.MinimumSize = new System.Drawing.Size(315, 340);
            this.Name = "FilterDialogForm";
            this.Text = "Filter Logs";
            this.Load += new System.EventHandler(this.FilterDialogForm_Load);
            this.VisibleChanged += new System.EventHandler(this.FilterDialogForm_VisibleChanged);
            this.FilterGroup.ResumeLayout(false);
            this.FilterGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ApplyFilterButton;
        private System.Windows.Forms.Button ClearFilterButton;
        private System.Windows.Forms.Label TimeFrameLabel;
        private System.Windows.Forms.ComboBox TimeFrameComboBox;
        private System.Windows.Forms.Button OkayFilterDialogButton;
        private System.Windows.Forms.Label DateFilterLabel;
        private System.Windows.Forms.ComboBox TopicFilterComboBox;
        private System.Windows.Forms.Label TopicFilterLabel;
        private System.Windows.Forms.DateTimePicker DatePickerFilter;
        private System.Windows.Forms.CheckBox DateFilterCheckBox;
        private System.Windows.Forms.CheckBox TimeFrameFilterCheckBox;
        private System.Windows.Forms.CheckBox TopicFilterCheckBox;
        public System.Windows.Forms.GroupBox FilterGroup;
    }
}