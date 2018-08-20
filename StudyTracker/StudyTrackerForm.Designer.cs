namespace StudyTracker
{
    partial class StudyTrackerForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::StudyTracker.Properties.Resources.Recent_Logs;
            this.panel1.Location = new System.Drawing.Point(259, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 100);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::StudyTracker.Properties.Resources.Recent_Logs;
            this.panel2.Location = new System.Drawing.Point(259, 300);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 100);
            this.panel2.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::StudyTracker.Properties.Resources.Recent_Logs;
            this.panel3.Location = new System.Drawing.Point(259, 435);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(365, 100);
            this.panel3.TabIndex = 19;
            // 
            // StudyTrackerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 700);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "StudyTrackerForm";
            this.Text = "Study Tracker";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}