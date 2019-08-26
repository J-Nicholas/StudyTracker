namespace StudyTracker
{
    partial class FloatWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FloatWindow));
            this.pauseButtonFloat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pauseButtonFloat
            // 
            this.pauseButtonFloat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(150)))), ((int)(((byte)(170)))));
            this.pauseButtonFloat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pauseButtonFloat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pauseButtonFloat.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseButtonFloat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pauseButtonFloat.Location = new System.Drawing.Point(0, -1);
            this.pauseButtonFloat.Margin = new System.Windows.Forms.Padding(0);
            this.pauseButtonFloat.Name = "pauseButtonFloat";
            this.pauseButtonFloat.Size = new System.Drawing.Size(135, 49);
            this.pauseButtonFloat.TabIndex = 1;
            this.pauseButtonFloat.Text = "PAUSE";
            this.pauseButtonFloat.UseVisualStyleBackColor = false;
            this.pauseButtonFloat.Click += new System.EventHandler(this.pauseButtonFloat_Click);
            // 
            // FloatWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(134, 47);
            this.Controls.Add(this.pauseButtonFloat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(150, 86);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(150, 86);
            this.Name = "FloatWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Study Tracker";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FloatWindow_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pauseButtonFloat;
    }
}