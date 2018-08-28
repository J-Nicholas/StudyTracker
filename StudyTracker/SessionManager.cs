﻿using System;
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
        #region Embedding Timer Font

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv,
            [System.Runtime.InteropServices.In] ref uint pcFonts);
        private PrivateFontCollection fontCollection = new PrivateFontCollection();

        Font clockFont;
        private void FontSetup()
        {
            byte[] fontData = Properties.Resources.DIGITALDREAMFATSKEW;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fontCollection.AddMemoryFont(fontPtr, Properties.Resources.DIGITALDREAMFATSKEW.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.DIGITALDREAMFATSKEW.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            clockFont = new Font(fontCollection.Families[0], 20);
        }
        #endregion

        private TimeSpan timeElapsed;
        public static Stopwatch stopWatch = new Stopwatch();
        private static StudyLog studyLogRef;
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
        public static StudyLog StudyLogRef
        {
            get
            {
                if (studyLogRef == null)
                {
                    studyLogRef = new StudyLog();
                }
                return studyLogRef;
            }
            set
            {
                studyLogRef = value;
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
                topicLabel.Text = $"{StudyLogRef.Topic} for:";
                topicLabel.Parent = WindowPanel;
                topicLabel.Location = new Point((WindowPanel.Width - topicLabel.Width) / 2, topicLabel.Location.Y);

            }
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            stopWatch.Stop();
            // Add End Time, End Date, Total time spent

            // Highlights the newest entry in the list of recent logs
            StudyTrackerForm.AddedNewEntry = true;
            StudyTrackerForm.StudyTracker.HighlightLatest = true;



            // Writing log to Json file
            //string jsonOutput = JsonConvert.SerializeObject(StudyLogRef);
            //JsonSerializer serializer = new JsonSerializer();

            try
            {
                if (!File.Exists(StudyDir.logsDir))
                {
                    using (File.Create(StudyDir.logsDir)) { };
                }
                var jsonData = File.ReadAllText(StudyDir.logsDir);
                var logList = JsonConvert.DeserializeObject<List<StudyLog>>(jsonData)
                    ?? new List<StudyLog>();

                StudyLogRef.TimeStudied = timeElapsed;
                //Formatting Time studied so that it doesn't have really long millisecond component
                StudyLogRef.TimeStudied = new TimeSpan( StudyLogRef.TimeStudied.Hours, StudyLogRef.TimeStudied.Minutes, StudyLogRef.TimeStudied.Seconds);

                StudyLogRef.TimeStudied =  StudyLogRef.TimeStudied.Subtract(new TimeSpan(StudyLogRef.TimeStudied.Milliseconds));
                StudyLogRef.EndDate = DateTime.Now;
                StudyLogRef.EndTime = DateTime.Now;

                logList.Add(StudyLogRef);
                var logBackup = from logs in logList
                                orderby logs.EndDate descending
                                select logs;

                logList = logBackup.ToList();

                jsonData = JsonConvert.SerializeObject(logList);
                File.WriteAllText(StudyDir.logsDir, jsonData);

            }
            catch (IOException error)
            {
                MessageBox.Show("Could not write to log file.\n" + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show("Well done!\nYour study session has been saved!", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            StudyTrackerForm.StudyTracker.Show();
            SessionManagerRef.Hide();
            StudyTrackerForm.StudyTracker.Location = this.Location;
            StudyTrackerForm.StudyTracker.Focus();

        }
    }
}