using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing.Text;
using Newtonsoft.Json;
using System.IO;

namespace StudyTracker
{
    public partial class SessionManagerForm : BaseForm
    {
        private TimeSpan timeElapsed;
        public static Stopwatch stopWatch = new Stopwatch();
        public static StudyLog NewStudyLog { get; set; }
        public static Label startButtonLabelRef;
        public static PictureBox startImageRef;
        private static SessionManagerForm sessionManagerRef;
        private bool shouldPause = false;

        private SessionManagerForm()
        {
            InitializeComponent();
            startButtonLabelRef = StartLabelBaseRef;
            startImageRef = StartImageRef;
        }
        public static PictureBox SessionManStartImageRef
        {
            get
            {
                if (startImageRef == null)
                {
                    startImageRef = BaseForm.StartImageRef;
                }
                return StartImageRef;
            }
        }

        public static SessionManagerForm SessionManagerRef
        {
            get
            {
                if (sessionManagerRef == null)
                {
                    sessionManagerRef = new SessionManagerForm();
                }
                return sessionManagerRef;
            }
        }
        private void ReCenterTimerLabel()
        {
            timerLabel.Location = new Point(
                (ClockImage.Size.Width - timerLabel.Width) / 2,
                (ClockImage.Size.Height - timerLabel.Height) / 2);
        }
        private void SessionManagerForm_Load(object sender, EventArgs e)
        {
            timerLabel.Parent = ClockImage;
            timerLabel.ForeColor = Color.FromArgb(120, 150, 170);

            ReCenterTimerLabel();
        }

        private void timeElapsedTimer_Tick(object sender, EventArgs e)
        {
            if (Debugger.IsAttached)
            {
                timeElapsedTimer.Enabled = false;
                return;
            }

            // Handle outputting time elapsed to label if button is not paused
            if (shouldPause == false)
            {
                timeElapsed = stopWatch.Elapsed;

                if (timeElapsed.Hours < 1)                          // hide hours if it hasn't been an hour yet
                {
                    timerLabel.Text = timeElapsed.ToString("mm':'ss'.'f");
                }
                else                                                // show hours
                {
                    bool adjusted = false;
                    if (adjusted == false)
                    {
                        ReCenterTimerLabel();
                        adjusted = true;
                    }
                    timerLabel.Text = timeElapsed.ToString("hh':'mm':'ss'.'f");
                }
            }
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            shouldPause = !shouldPause;                     //toggle pause / start
            if (shouldPause)
            {
                stopWatch.Stop();
                pauseButton.Text = "RESUME";
                timerLabel.ForeColor = Color.Firebrick;
            }
            else
            {
                stopWatch.Start();
                pauseButton.Text = "PAUSE";
                timerLabel.ForeColor = Color.FromArgb(120, 150, 170);
            }
        }

        private void SessionManagerForm_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == false)
            {
                stopWatch.Reset();
                timeElapsed = TimeSpan.MinValue;
                topicLabel.Text = string.Empty;
                if (shouldPause)
                {
                    shouldPause = false;
                    pauseButton.Text = "PAUSE";
                    timerLabel.ForeColor = Color.FromArgb(120, 150, 170);
                }
            }
            else
            {
                stopWatch.Start();
                topicLabel.Text = $"{NewStudyLog.Topic} for:";
                topicLabel.Parent = WindowPanel;
                topicLabel.Location = new Point((WindowPanel.Width - topicLabel.Width) / 2, topicLabel.Location.Y);

            }
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            // Add End Time, End Date, Total time spent
            stopWatch.Stop();

            // Highlights the newest entry in the list of recent logs
            StudyTrackerForm.AddedNewEntry = true;
            StudyTrackerForm.StudyTracker.HighlightLatest = true;


            if (!File.Exists(StudyDir.logsDir))
            {
                using (File.Create(StudyDir.logsDir)) { };
            }

            LogData.ReadFromFile();                             // Get latest version of log file

            //Formatting Time studied so that it doesn't have really long millisecond component
            NewStudyLog.TimeStudied = timeElapsed;
            NewStudyLog.TimeStudied = NewStudyLog.TimeStudied.Subtract(new TimeSpan(NewStudyLog.TimeStudied.Milliseconds));
            NewStudyLog.TimeStudied = new TimeSpan(NewStudyLog.TimeStudied.Hours, NewStudyLog.TimeStudied.Minutes, NewStudyLog.TimeStudied.Seconds);

            // Updating New log with new information before saving
            NewStudyLog.EndDate = DateTime.Now;
            NewStudyLog.EndTime = DateTime.Now;

            LogData.StudyLogs.Add(NewStudyLog);                 // Add new log that has been created
            LogData.WriteToFile();                              // Save to file

            MessageBox.Show("Well done!\nYour study session has been saved!", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);



            StudyTrackerForm.StudyTracker.Show();
            SessionManagerRef.Hide();
            StudyTrackerForm.StudyTracker.Location = this.Location;
            StudyTrackerForm.StudyTracker.Focus();

        }
    }
}
