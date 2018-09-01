using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace StudyTracker
{

    public partial class StatsForm : Form
    {
        // Needed for dragging form becuase it is borderless
        private bool IsDragging = false;
        private Point lastLocation;

        private string mySeries = "StudyTracker";
        private static string topicName = string.Empty;
        private static int MAX_LOGS = 6;

        /// <summary>
        /// Filters study logs based on a time frame tooken and only returns logs for a chosen topic
        /// </summary>
        private Dictionary<TimeFrame, Func<StudyLog, bool>> filterDictionaryTopic = new Dictionary<TimeFrame, Func<StudyLog, bool>>
        {
            [TimeFrame.Today] = (log) => log.Topic == topicName && log.EndDate.Date == DateTime.Now.Date,
            [TimeFrame.ThisWeek] = (log) => log.Topic == topicName && log.EndDate.Date <= DateTime.Now.Date && log.EndDate.Date >= DateTime.Now.Date.AddDays(-7),
            [TimeFrame.ThisMonth] = (log) => log.Topic == topicName && log.EndDate.Date <= DateTime.Now.Date && log.EndDate.Date >= DateTime.Now.Date.AddDays(-30),
            [TimeFrame.ThisYear] = (log) => log.Topic == topicName && log.EndDate.Date <= DateTime.Now.Date && log.EndDate.Date >= DateTime.Now.Date.AddDays(-365),
            [TimeFrame.Total] = (log) => log.Topic == topicName,
        };
        /// <summary>
        /// Filters studylogs based on a certain time frame that includes all topics
        /// </summary>
        private Dictionary<TimeFrame, Func<StudyLog, bool>> filterDictionaryAll = new Dictionary<TimeFrame, Func<StudyLog, bool>>
        {
            [TimeFrame.Today] = (log) => log.EndDate.Date == DateTime.Now.Date,
            [TimeFrame.ThisWeek] = (log) => log.EndDate.Date <= DateTime.Now.Date && log.EndDate.Date >= DateTime.Now.Date.AddDays(-7),
            [TimeFrame.ThisMonth] = (log) => log.EndDate.Date <= DateTime.Now.Date && log.EndDate.Date >= DateTime.Now.Date.AddDays(-30),
            [TimeFrame.ThisYear] = (log) => log.EndDate.Date <= DateTime.Now.Date && log.EndDate.Date >= DateTime.Now.Date.AddDays(-365),
            [TimeFrame.Total] = (log) => log.EndTime.TimeOfDay < DateTime.Now.TimeOfDay,
        };

        public StatsForm()
        {
            InitializeComponent();
            StatsRef = this;
            ChartSetup();

            //Set up min and close button
            CloseButtonImage.Parent = DragWindow;                                                               // location is now relatvie to dragwindow. so 
            CloseButtonImage.Location = new Point(DragWindow.Width - (CloseButtonImage.Width + 7), 3);          // button should be image.width number of pixels from 
            MinimiseButtonImage.Parent = DragWindow;                                                            // right + 7 for space and 3 from top
            MinimiseButtonImage.Location = new Point(CloseButtonImage.Location.X - MinimiseButtonImage.Width, CloseButtonImage.Location.Y);
            TopicBox.Items.Add("No Topics");
            // fonts for Time Studied
            foreach (Control label in TimeStudiedPanel.Controls)
            {
                label.Font = new Font("lucidia Bright", 10f, FontStyle.Italic, GraphicsUnit.Point);
            }
            // Set up times

            UpdateTimeSpentLabels();
            UpdateTopicBox();
            UpdateTimeSpentOnTopic();
        }
        /// <summary>
        /// Setting up chart design
        /// </summary>
        private void ChartSetup()
        {
            StudyChart.Series.Clear();
            StudyChart.Legends.Clear();

            // setting background to transparent
            StudyChart.BackColor = Color.Transparent;
            StudyChart.ChartAreas[0].BackColor = Color.Transparent;

            //setting up color pallete
            List<Color> customPallete = new List<Color>
            {
                Color.FromArgb(110, 130, 150),                          // Nice Navy Blue
                Color.FromArgb(48, 77, 110),                            // Desaturated Blue
                Color.FromArgb(130, 160, 190),
                Color.FromArgb(0, 170, 190),
                Color.FromArgb(225, 122, 1),
                Color.FromArgb(237, 144, 137),
                Color.FromArgb(50, 90, 130),

            };
            Color[] customColorArray = customPallete.ToArray();
            StudyChart.Palette = ChartColorPalette.None;
            StudyChart.PaletteCustomColors = customColorArray;

            //Add a new Legend(if needed) and do some formating
            StudyChart.Legends.Add("MyLegend");
            StudyChart.Legends[0].LegendStyle = LegendStyle.Table;
            StudyChart.Legends[0].Docking = Docking.Bottom;
            StudyChart.Legends[0].Alignment = StringAlignment.Center;
            StudyChart.Legends[0].Title = "Topics";
            StudyChart.Legends[0].BorderColor = Color.Black;

            StudyChart.Series.Add(mySeries);
            StudyChart.Series[mySeries].ChartType = SeriesChartType.Pie;
            StudyChart.BackColor = Color.Transparent;

            //Add some datapoints so the series. in this case you can pass the values to this method
            StudyChart.Series[mySeries]["PieLabelStyle"] = "Outside";
            StudyChart.Series[mySeries]["PieLineColor"] = "Black";
            StudyChart.Series[mySeries].XValueMember = "Name";
            StudyChart.Series[mySeries].YValueMembers = "Count";
            StudyChart.Series[mySeries].IsValueShownAsLabel = true;

            // I need a list of the top 9 topics by Time studied that the user has studied
            // X is Topic , Y is TimeStudied in Minutes
            List<TopicTime> topStudiedTopics = GetTopStudiedTopics(TimeFrame.Today);
            foreach (var log in topStudiedTopics)
            {
                StudyChart.Series[mySeries].Points.AddXY(log.TopicName, log.TimeSpent.TotalMinutes);
            }

            int i = 0;
            foreach (DataPoint p in StudyChart.Series[mySeries].Points)
            {
                p.Label = "#PERCENT";
                p.LegendText = topStudiedTopics[i].TopicName + " #PERCENT";
                i++;
            }
        }

        private List<TopicTime> GetTopStudiedTopics(TimeFrame timeFrame)
        {
            List<string> uniqueTopics = new List<string>();

            List<TopicTime> topicAndTime = new List<TopicTime>();
            List<TopicTime> topNineTopics = new List<TopicTime>();

            MAX_LOGS = (int)MaxLogsNumeric.Value;

            // Get unique topic list
            foreach (StudyLog log in LogData.StudyLogs.Where((log) => !uniqueTopics.Contains(log.Topic)))
            {
                uniqueTopics.Add(log.Topic);
            }

            foreach (var topic in uniqueTopics)
            {
                topicAndTime.Add(new TopicTime(topic, new TimeSpan(0, 0, 0)));
            }

            int j = 0;
            for (int i = 0; i < uniqueTopics.Count; i++)
            {
                topicName = uniqueTopics[i];
                foreach (StudyLog log in LogData.StudyLogs.Where(filterDictionaryTopic[timeFrame]))
                {
                    if (topicAndTime[i].TopicName == log.Topic)
                    {
                        topicAndTime[i].TimeSpent += log.TimeStudied;
                    }
                    j++;
                }
            }

            // Sort logs by time studied
            var sortedLogs = from logs in topicAndTime
                             orderby logs.TimeSpent descending
                             select logs;
            topicAndTime = sortedLogs.ToList();

            for (int i = 0; i < MAX_LOGS && i < topicAndTime.Count; i++)
            {
                if (topicAndTime[i].TimeSpent != new TimeSpan(0, 0, 0))
                {
                    topNineTopics.Add(topicAndTime[i]);
                }
            }


            return topNineTopics;

        }


        private static Form statsRef;
        /// <summary>
        /// Singleton Form reference
        /// </summary>
        public static Form StatsRef
        {
            get
            {
                if (statsRef == null)
                {
                    statsRef = new StatsForm();
                }
                return statsRef;
            }
            private set { }
        }

        /// <summary>
        /// Overrides CreateParams and gives this form dropshadow
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private void CloseButtonImage_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void MinimiseButtonImage_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;                     // This allows the minimise animation to play 
            this.WindowState = FormWindowState.Minimized;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void MinimiseButtonImage_MouseEnter(object sender, EventArgs e)
        {
            MinimiseButtonImage.BackgroundImage = Properties.Resources.Min_hover;
        }

        private void MinimiseButtonImage_MouseLeave(object sender, EventArgs e)
        {
            MinimiseButtonImage.BackgroundImage = Properties.Resources.Minimise_Icon;
        }

        private void CloseButtonImage_MouseEnter(object sender, EventArgs e)
        {
            CloseButtonImage.BackgroundImage = Properties.Resources.Close_hover;
        }

        private void CloseButtonImage_MouseLeave(object sender, EventArgs e)
        {
            CloseButtonImage.BackgroundImage = Properties.Resources.Close_Icon;
        }

        private void DragWindow_MouseDown(object sender, MouseEventArgs e)
        {
            IsDragging = true;
            lastLocation = e.Location;
        }

        private void DragWindow_MouseMove(object sender, MouseEventArgs e)
        {
            Point Offset = new Point(DragWindow.Location.X - this.Location.X, DragWindow.Location.Y - this.Location.Y);

            if (IsDragging)
            {
                this.Location = new Point(
                (this.Location.X - lastLocation.X) + (e.Location.X), (this.Location.Y - lastLocation.Y) + (e.Location.Y));

                this.Update();

            }
        }

        private void DragWindow_MouseUp(object sender, MouseEventArgs e)
        {
            IsDragging = false;
        }

        private void StatsForm_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                UpdateTimeSpentLabels();
                UpdateTopicBox();
                UpdateTimeSpentOnTopic();
                TimeFrameBox.SelectedIndex = 0;
                TopicBox.SelectedIndex = 0;
                ChartTimeFrameCombo.SelectedIndex = 0;
            }
        }
        private void UpdateTimeSpentLabels()
        {
            // Time spent studying today
            TimeSpan today = GetTimeStudied(TimeFrame.Today);
            TimeStudiedTodayValueLabel.Text = $"{today.Hours:d2}h {today.Minutes:d2}m {today.Seconds:d2}s";

            // Time Spent studying this week
            TimeSpan week = GetTimeStudied(TimeFrame.ThisWeek);
            int days = week.Days;
            TimeStudiedWeekValueLabel.Text = $"{week.Hours + (days * 24):d2}h {week.Minutes:d2}m {week.Seconds:d2}s";

            // Time spent studying this month
            TimeSpan month = GetTimeStudied(TimeFrame.ThisMonth);
            days = month.Days;
            TimeStudiedThisMonthValueLabel.Text = $"{month.Hours + (days * 24):d2}h {month.Minutes:d2}m {month.Seconds:d2}s";
        }
        /// <summary>
        /// Gets unique topics and then orders them by most time studied in descending order, then adds them to topic drop down items list.
        /// </summary>
        private void UpdateTopicBox()
        {
            // get list of unique topics
            List<string> topics = new List<string>();
            foreach (var log in LogData.StudyLogs)
            {
                topics.Add(log.Topic);
            }
            var uniqueTopicsHash = new HashSet<string>(topics);
            List<string> uniqueTopicList = uniqueTopicsHash.ToList();


            // Add each unique topic to Topic Time list so that we can make a paired list
            List<TopicTime> topicAndTime = new List<TopicTime>();
            foreach (var topic in uniqueTopicList)
            {
                topicAndTime.Add(new TopicTime(topic, new TimeSpan(0, 0, 0)));
            }

            // We have list of unique topics, now we add up the time spent studying for each topic in studylogs
            for (int i = 0; i < topicAndTime.Count; i++)
            {
                for (int j = 0; j < LogData.StudyLogs.Count; j++)
                {
                    if (topicAndTime[i].TopicName == LogData.StudyLogs[j].Topic)
                    {
                        topicAndTime[i].TimeSpent += LogData.StudyLogs[j].TimeStudied;
                    }
                }
            }


            // Order the topics by greatest time spent studying
            var orderbyTimeStudied = from log in topicAndTime
                                     orderby log.TimeSpent descending
                                     select log;

            topicAndTime = orderbyTimeStudied.ToList();

            // Add items to topic box drop down
            TopicBox.Items.Clear();
            foreach (var log in topicAndTime)
            {
                TopicBox.Items.Add(log.TopicName);
            }

            // Select first topic by default
            if (TopicBox.Items.Count > 1)
            {
                TopicBox.Items.Remove("No Topics");
                TopicBox.SelectedIndex = 0;
            }
            else
            {
                TopicBox.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Gets time studied for all subjects in a certain time frame e.g. last 7 days, last 30 days etc.
        /// </summary>
        /// <param name="timeFrame">TimeFrame enum that corresponds to a dictionary key for a relevant delegate value</param>
        /// <returns></returns>
        private TimeSpan GetTimeStudied(TimeFrame timeFrame)
        {
            TimeSpan timeStudied = new TimeSpan();

            foreach (StudyLog log in LogData.StudyLogs.Where(filterDictionaryAll[timeFrame]))
            {
                timeStudied += log.TimeStudied;
            }
            return timeStudied;
        }

        /// <summary>
        /// Gets time studied for a specific time frame and a specific topic based on drop down boxes in stats form.
        /// </summary>
        /// <param name="timeFrameDropDown">Drop down box to retrieve timeframe enum from</param>
        /// <param name="topicName">Topic string that query will be filtered by.</param>
        /// <returns></returns>
        private TimeSpan GetTimeStudied(ComboBox timeFrameDropDown, string topicName)
        {
            // Get topic from topicBox
            List<StudyLog> tempList = LogData.StudyLogs;
            TimeFrame selectedTimeFrame = (TimeFrame)timeFrameDropDown.SelectedIndex;
            if ((int)selectedTimeFrame == -1) selectedTimeFrame = 0;  // Default for first run of program

            TimeSpan sum = new TimeSpan();
            StatsForm.topicName = topicName;

            foreach (StudyLog log in tempList.Where(filterDictionaryTopic[selectedTimeFrame]))
            {
                sum += log.TimeStudied;
            }
            return sum;
        }

        /// <summary>
        /// Updates topicTimeSpent label with specific time studied for a selected topic and time frame
        /// </summary>
        private void UpdateTimeSpentOnTopic()
        {
            TimeSpan TimeStudied = GetTimeStudied(TimeFrameBox, TopicBox.SelectedItem.ToString());
            int days = TimeStudied.Days;                                //Getting rid of days component by multiplying days by 24 hours
            int hours = 24;

            TopicTimeSpentLabel.Text = $"{TimeStudied.Hours + (days * hours):d2}h {TimeStudied.Minutes:d2}m {TimeStudied.Seconds:d2}s";

        }

        /// <summary>
        /// Used as dictionary key to retrive a generic delegate that returns StudyLog topics based on a certain time frame.
        /// </summary>
        private enum TimeFrame : int
        {
            Today,
            ThisWeek,
            ThisMonth,
            ThisYear,
            Total
        }

        /// <summary>
        /// Each time topicBox selected item changes, get the new topic study times
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TopicBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTimeSpentOnTopic();
        }

        /// <summary>
        /// Gets the top studied topics based on the dropDown above the chart. Adds the list of topics in descending order based on time studied.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChartTimeFrameCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<TopicTime> topStudiedTopics = GetTopStudiedTopics((TimeFrame)ChartTimeFrameCombo.SelectedIndex);
            StudyChart.Series[mySeries].Points.Clear();
            if (topStudiedTopics.Count == 0)
            {
                StudyChart.Series[mySeries].Points.AddXY("No Entries", 1);
            }
            else
            {
                foreach (var log in topStudiedTopics)
                {
                    StudyChart.Series[mySeries].Points.AddXY(log.TopicName, log.TimeSpent.TotalMinutes);
                }
            }

            // If today was selected, we need to get the top topics from today in order and then total minutes per topic for chart

            int i = 0;
            foreach (DataPoint p in StudyChart.Series[mySeries].Points)
            {
                p.Label = "#PERCENT";
                if (topStudiedTopics.Count > 0)
                {
                    p.LegendText = topStudiedTopics[i].TopicName + " #PERCENT";
                }
                else
                {
                    p.LegendText = "No Entries" + " #PERCENT";
                }
                i++;
            }
        }

        private void StatsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            BaseForm.IsStatsOpen = false;
            CloseReason reason = e.CloseReason;
            if (reason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = false;
            }
            else
            {
                this.Hide();
                e.Cancel = true;
            }
        }
    }
}
