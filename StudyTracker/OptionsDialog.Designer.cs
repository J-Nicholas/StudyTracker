namespace StudyTracker
{
    partial class OptionsMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsMenu));
            this.FloatingGroup = new System.Windows.Forms.GroupBox();
            this.enableFloatButton = new System.Windows.Forms.Button();
            this.disableFloatButton = new System.Windows.Forms.Button();
            this.saveOptionsButton = new System.Windows.Forms.Button();
            this.cancelOptionsButton = new System.Windows.Forms.Button();
            this.FloatingGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // FloatingGroup
            // 
            this.FloatingGroup.Controls.Add(this.disableFloatButton);
            this.FloatingGroup.Controls.Add(this.enableFloatButton);
            this.FloatingGroup.Location = new System.Drawing.Point(28, 30);
            this.FloatingGroup.Margin = new System.Windows.Forms.Padding(50);
            this.FloatingGroup.Name = "FloatingGroup";
            this.FloatingGroup.Padding = new System.Windows.Forms.Padding(50);
            this.FloatingGroup.Size = new System.Drawing.Size(245, 76);
            this.FloatingGroup.TabIndex = 0;
            this.FloatingGroup.TabStop = false;
            this.FloatingGroup.Text = "Floating Start/Stop Button";
            // 
            // enableFloatButton
            // 
            this.enableFloatButton.Location = new System.Drawing.Point(23, 27);
            this.enableFloatButton.Name = "enableFloatButton";
            this.enableFloatButton.Size = new System.Drawing.Size(75, 23);
            this.enableFloatButton.TabIndex = 0;
            this.enableFloatButton.Text = "Enable";
            this.enableFloatButton.UseVisualStyleBackColor = true;
            this.enableFloatButton.Click += new System.EventHandler(this.enableFloatButton_Click);
            // 
            // disableFloatButton
            // 
            this.disableFloatButton.Enabled = false;
            this.disableFloatButton.Location = new System.Drawing.Point(136, 27);
            this.disableFloatButton.Name = "disableFloatButton";
            this.disableFloatButton.Size = new System.Drawing.Size(75, 23);
            this.disableFloatButton.TabIndex = 1;
            this.disableFloatButton.Text = "Disable";
            this.disableFloatButton.UseVisualStyleBackColor = true;
            this.disableFloatButton.Click += new System.EventHandler(this.enableFloatButton_Click);
            // 
            // saveOptionsButton
            // 
            this.saveOptionsButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveOptionsButton.Location = new System.Drawing.Point(51, 185);
            this.saveOptionsButton.Name = "saveOptionsButton";
            this.saveOptionsButton.Size = new System.Drawing.Size(75, 23);
            this.saveOptionsButton.TabIndex = 1;
            this.saveOptionsButton.Text = "Save";
            this.saveOptionsButton.UseVisualStyleBackColor = true;
            this.saveOptionsButton.Click += new System.EventHandler(this.saveOptionsButton_Click);
            // 
            // cancelOptionsButton
            // 
            this.cancelOptionsButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelOptionsButton.Location = new System.Drawing.Point(164, 185);
            this.cancelOptionsButton.Name = "cancelOptionsButton";
            this.cancelOptionsButton.Size = new System.Drawing.Size(75, 23);
            this.cancelOptionsButton.TabIndex = 2;
            this.cancelOptionsButton.Text = "Cancel";
            this.cancelOptionsButton.UseVisualStyleBackColor = true;
            // 
            // OptionsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 231);
            this.Controls.Add(this.cancelOptionsButton);
            this.Controls.Add(this.saveOptionsButton);
            this.Controls.Add(this.FloatingGroup);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(320, 270);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(320, 270);
            this.Name = "OptionsMenu";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.OptionsMenu_Load);
            this.FloatingGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox FloatingGroup;
        private System.Windows.Forms.Button disableFloatButton;
        private System.Windows.Forms.Button enableFloatButton;
        private System.Windows.Forms.Button saveOptionsButton;
        private System.Windows.Forms.Button cancelOptionsButton;
    }
}