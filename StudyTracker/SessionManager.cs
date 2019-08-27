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
using System.Threading;

namespace StudyTracker
{
    public partial class SessionManagerForm : BaseForm
    {
        private TimeSpan timeElapsed;
        private bool finishedStudying = false;
        private bool shouldPause = false;
        private FloatWindow floater;
        public static Stopwatch stopWatch = new Stopwatch();
        public static StudyLog NewStudyLog { get; set; }
        private int activateCount = 0;
        private int deactivateCount = 0;


        private static SessionManagerForm sessionManagerRef;

        private SessionManagerForm()
        {
            InitializeComponent();
            Options.OptionsSaved += this.NewMenuOpened;
            base.SideBarMenu_Click += this.NewMenuOpened;
            Paused += FloatWindow.MainTrackerPaused;
            FloatWindow.FloatPaused += this.Float_Click;
            FinishedStudying += FloatWindow.ResetButton;
            base.startSessionButton.Text = "Home";
        }

        public FloatWindow FloatWindow
        {
            get
            {
                if (floater == null)
                {
                    floater = new FloatWindow();

                }
                return floater;
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
            // Placing floating button in bottom right of user's screen
            Screen screen = Screen.FromControl(this);
            Rectangle area = screen.WorkingArea;

            FloatWindow.Location = new Point(area.Width - FloatWindow.Width,
                                                    area.Height - FloatWindow.Height);
            // setting up clock position and colour
            timerLabel.Parent = ClockImage;
            timerLabel.ForeColor = Color.FromArgb(120, 150, 170);

            ReCenterTimerLabel();
        }

        private void timeElapsedTimer_Tick(object sender, EventArgs e)
        {
            //if (Debugger.IsAttached)
            //{
            //    timeElapsedTimer.Enabled = false;
            //    return;
            //}

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
            OnPaused();
            TogglePauseButtonText();
        }

        private void Float_Click(object sender, EventArgs e)
        {
            TogglePauseButtonText();
        }

        private void TogglePauseButtonText()
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
                finishedStudying = false;
                stopWatch.Start();
                topicLabel.Text = $"{NewStudyLog.Topic} for:";
                topicLabel.Parent = WindowPanel;
                topicLabel.Location = new Point((WindowPanel.Width - topicLabel.Width) / 2, topicLabel.Location.Y);

            }
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            finishedStudying = true;
            OnFinishedStudying();
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

        // Overriding
        new public void StartButton_Click(object obj, EventArgs e)
        {
            // Label says Home, allow user to return to main menu, ask them if they are sure, their work wont' be saved until they click finsih button
            DialogResult result = MessageBox.Show("Are you sure you want to return to Home?\nYour study session wont't be logged unless you click finish.",
                    "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Stopping study, should stop showing floating window tracker.
                finishedStudying = true;
                OnFinishedStudying();
                StudyTrackerForm.StudyTracker.Show();
                SessionManagerForm.SessionManagerRef.Hide();
                StudyTrackerForm.StudyTracker.Location = SessionManagerForm.SessionManagerRef.Location;
                StudyTrackerForm.StudyTracker.Focus();
            }
        }


        private void SessionManagerForm_Deactivate(object sender, EventArgs e)
        {

            if (Options.Settings.showFloatingWindow)
            {
                if (finishedStudying)
                {
                    FloatWindow.Hide();
                }
                else
                {
                    FloatWindow.Show();
                }
            }
        }

        private void SessionManagerForm_Activated(object sender, EventArgs e)
        {
            this.Activate(); // needed to give Session window focus, params set in floating window seems 
                             // to stop this window from being active form.
            if (Options.Settings.showFloatingWindow)
            {
                if(this == ActiveForm)
                    FloatWindow.Hide();

            }
        }

        public void NewMenuOpened(object obj, EventArgs e)
        {
            FloatWindow.Hide();
        }

        #region Events
        public event EventHandler Paused;
        protected virtual void OnPaused()
        {
            Paused?.Invoke(this, EventArgs.Empty);
        }
        public event EventHandler FinishedStudying;
        protected virtual void OnFinishedStudying()
        {
            FinishedStudying?.Invoke(this, EventArgs.Empty);
        }
        #endregion
    }
}
