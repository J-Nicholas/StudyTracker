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
        private static Stopwatch stopWatch = new Stopwatch();
        private static StudyLog studyLogRef;
        private static SessionManagerForm sessionManagerRef;
        private bool shouldPause = false;

        private SessionManagerForm()
        {
            InitializeComponent();
            FontSetup();

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
        private void ReCenterTimerLabel ()
        {
            timerLabel.Location = new Point(
                (ClockImage.Size.Width - timerLabel.Width) / 2,
                (ClockImage.Size.Height - timerLabel.Height) / 2);
        }
        private void SessionManagerForm_Load(object sender, EventArgs e)
        {
            stopWatch.Start();
            topicLabel.Text = $"{StudyLogRef.Topic} for:";
            timerLabel.Font = clockFont;
            timerLabel.Parent = ClockImage;
            timerLabel.ForeColor = Color.LawnGreen;
            ReCenterTimerLabel();
        }

        private void timeElapsedTimer_Tick(object sender, EventArgs e)
        {
            topicLabel.Left = (this.ClientSize.Width - topicLabel.Width) / 2;

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
                timerLabel.ForeColor = Color.Red;
                ClockImage.Image = Properties.Resources.ClockTimer_Red;
            }
            else
            {
                stopWatch.Start();
                pauseButton.Text = "PAUSE";
                timerLabel.ForeColor = Color.LawnGreen;
                ClockImage.Image = Properties.Resources.ClockTimer_Green;

            }
        }

        private void finishButton_Click(object sender, EventArgs e)
        {

        }


    }
}
