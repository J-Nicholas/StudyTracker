using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace StudyTracker
{
    public partial class StudyTrackerForm : BaseForm
    {
        private static StudyTrackerForm studyTracker;   // reference to this form that can be accessed by property 
        private static Label startButtonLabel;
        private static List<StudyLog> logList = new List<StudyLog>();
        private static Stack<StudyLog> stackLogList = new Stack<StudyLog>();
        private static Panel selectedPanel = new Panel();
        private static int ScrollPosition = new int();


        public StudyTrackerForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            CenterWindow();
            studyTracker = this;
            startButtonLabel = StartLabelBaseRef;
            this.RecentLogsContainer.MouseWheel += RecentLogsContainer_MouseScroll;
            RecentLogsContainer.AutoScroll = true;
            RecentLogsContainer.VerticalScroll.Enabled = true;
            RecentLogsContainer.VerticalScroll.Maximum = (panels.Count * logPanelDimensions.Height) + (panels.Count * spacing);
        }

        public static StudyTrackerForm StudyTracker
        {
            // singleton that only allows one instance of this form
            get
            {
                if (studyTracker == null)
                {
                    studyTracker = new StudyTrackerForm();
                }
                return studyTracker;
            }
        }
        public static Label StartButtonLabel
        {
            get
            {
                if (startButtonLabel == null)
                    startButtonLabel = new Label();
                return startButtonLabel;
            }
        }

        private void CenterWindow()
        {
            Rectangle screen = GetScreenSize();
            int screenHeight = screen.Height;
            int screenWidth = screen.Width;

            // Sets location to the centre of the screen, - size.width/2 is needed
            //because window location is based on top left corner and this corrects it.
            Location = new Point((screenWidth / 2) - (Size.Width / 2), (screenHeight / 2) - (Size.Height / 2));
        }
        private Rectangle GetScreenSize()
        {
            return Screen.GetWorkingArea(this);
        }

        private void StudyTrackerForm_Load(object sender, EventArgs e)
        {

        }
        private void RecentLogsContainer_MouseScroll(object sender, MouseEventArgs e)
        {
            // one scroll of the mouse changes the value of scrollbar by 120, so I want to reduce this amount  each time. 

            int scrollLimiter = 80;                 //amount to reduce scroll by

            if (e.Delta < 0)                         // Scrolled down
            {
                // If scroll + scrollLimiter causes value to go past max, set it to max;
                if (RecentLogsContainer.VerticalScroll.Value + scrollLimiter > (RecentLogsContainer.VerticalScroll.Maximum - RecentLogsContainer.Size.Height)
                    || RecentLogsContainer.VerticalScroll.Value - scrollLimiter < RecentLogsContainer.VerticalScroll.Minimum)
                {
                    RecentLogsContainer.VerticalScroll.Value = RecentLogsContainer.VerticalScroll.Maximum;
                }
                else
                {
                    // This reduces amount scrolled by deducting from the amount scrolled
                    RecentLogsContainer.VerticalScroll.Value -= scrollLimiter;
                }
            }
            else if (e.Delta > 0)                   // Scrolled up
            {
                // If I'm close enough to the top that deducting the scrollLimt variable would be negative, then set it to minimum.
                // this stops the scrollbar getting stuck just before hitting the top
                if ((RecentLogsContainer.VerticalScroll.Value - scrollLimiter) < RecentLogsContainer.VerticalScroll.Minimum
                    || RecentLogsContainer.VerticalScroll.Value + scrollLimiter > RecentLogsContainer.VerticalScroll.Maximum)
                {
                    RecentLogsContainer.VerticalScroll.Value = RecentLogsContainer.VerticalScroll.Minimum;
                }
                // else just reduce the amount scrolled.
                else
                {
                    // vertical scroll value is decreasing so this reduces scroll effectively by 
                    RecentLogsContainer.VerticalScroll.Value += scrollLimiter;
                }
            }
            ScrollPosition = RecentLogsContainer.VerticalScroll.Value;


        }
        public static void ReadJsonLogs()
        {
            // Fetches log data from log
            if (File.Exists(StudyDir.logsDir))
            {
                try
                {
                    var jsonData = File.ReadAllText(StudyDir.logsDir);
                    logList = JsonConvert.DeserializeObject<List<StudyLog>>(jsonData)
                                                    ?? new List<StudyLog>();
                }
                catch (IOException error)
                {
                    MessageBox.Show("Could not open log file.\n" + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (JsonException error)
                {
                    MessageBox.Show("Error with Json Deserialization\n" + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Log File doesn't exist yet.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private void StudyTrackerForm_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                // Try and read Json file with logs. If file can't be found. Tell the user there isn't any logs just yet
                ClearPanels();
                studyTracker.Focus();
                if (File.Exists(StudyDir.logsDir))
                {
                    ReadJsonLogs();

                    //Reverse order of logs to give newwest first, this will need to be changed once manual editing comes in 
                    stackLogList = new Stack<StudyLog>();
                    foreach (var log in logList)
                    {
                        stackLogList.Push(log);
                    }
                    logList = stackLogList.ToList();

                    GenerateRecentLogs();
                    if (logList.Count == 0)
                    {
                        AddPanelNothingHere();
                    }
                }
                else
                {
                    // No study sessions have been logged yet, show a panel saying so and to check back later
                    AddPanelNothingHere();
                }
            }
        }

        private void RecentLogsContainer_Enter(object sender, EventArgs e)
        {
            RecentLogsContainer.Focus();
        }
        private void RecentLogPanel_Click(object sender, EventArgs e)
        {
            //Panel clickedPanel = (Panel)sender;
            ////set all to default and then set the one that was clicked to highlighted
            //foreach (var panel in panels)
            //{
            //    panel.BackgroundImage = Properties.Resources.Recent_Logs_none;
            //}
            //clickedPanel.BackgroundImage = Properties.Resources.Recent_Logs;
            //selectedPanel = clickedPanel;
        }
        private void RefreshRecentLogs_Tick(object sender, EventArgs e)
        {
            //if (File.Exists(StudyDir.logsDir))
            //{
            //    ClearPanels();
            //    //HighlightLatest = false;            // so that top item gets highlighted
            //    GenerateRecentLogs();
            //    RecentLogsContainer.VerticalScroll.Value = ScrollPosition;
            //}

            for (int i = 0; i < dateStudiedValue.Count; i++)
            {
                if (logList[i].EndDate.Day == DateTime.Now.Day)
                {
                    var timePassed = DateTime.Now.Subtract(logList[i].EndDate);

                    if (timePassed.Minutes == 0 && timePassed.Hours < 1)
                    {
                        dateStudiedValue[i].Text = $"Just now.";
                    }
                    else if (timePassed.Hours < 1)
                    {
                        //its been less than an hour. display the time difference in minutes
                        dateStudiedValue[i].Text = $"{timePassed.Minutes} {(timePassed.Minutes > 1 ? "minutes" : "minute")} ago.";
                    }
                    else if (timePassed.Hours < 24)
                    {
                        dateStudiedValue[i].Text = $"{timePassed.Hours} hours and {timePassed.Minutes} minutes ago.";
                    }
                }
                else
                    dateStudiedValue[i].Text = $"{logList[i].EndDate.ToShortDateString()}";
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            ScrollPosition = RecentLogsContainer.VerticalScroll.Value;
            // get the parent of deletebutton that was pressed and then remove that panels index from loglist index
            PictureBox deleteIcon = (PictureBox)sender;
            for (int i = 0; i < panels.Count; i++)
            {
                if (deleteIcon.Parent == panels[i])
                {
                    // Correct index to remove logList 
                    logList.RemoveAt(i);
                }
            }

            // Generate new panels
            ClearPanels();
            GenerateRecentLogs();
            RecentLogsContainer.VerticalScroll.Value = ScrollPosition;

            // Write new loglist to file --         CAUTION loglist needs to be reversed again as it has been reversed by stack
            Stack<StudyLog> reverseOrder = new Stack<StudyLog>();
            foreach (var log in logList)
            {
                reverseOrder.Push(log);
            }
            logList = reverseOrder.ToList();

            // Safe to write to file now
            var jsonData = JsonConvert.SerializeObject(logList);
            File.WriteAllText(StudyDir.logsDir, jsonData);


            // Reverse again
            reverseOrder = new Stack<StudyLog>();
            foreach (var log in logList)
            {
                reverseOrder.Push(log);
            }
            logList = reverseOrder.ToList();

            // If loglist is now empty, show empty panel notification
            if (logList.Count == 0)
            {
                AddPanelNothingHere();
            }

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edit button coming soon!");

        }
        private void RecentLogPanels_MouseEnter(object sender, EventArgs e)
        {
            Panel panelEntered = (Panel)sender;



            for (int i = 0; i < panels.Count; i++)
            {
                if (panelEntered == deleteButtons[i].Parent && panelEntered == panels[i]
                    && panelEntered == editButtons[i].Parent)
                {
                    // highlight the panel and show delete button for this panel

                    deleteButtons[i].Show();
                    editButtons[i].Show();
                    panelEntered.BackgroundImage = Properties.Resources.Recent_Logs;
                }
                else
                {
                    // hide all delete buttons except for this panel and deselect all other panels

                    deleteButtons[i].Hide();
                    editButtons[i].Hide();
                    panels[i].BackgroundImage = Properties.Resources.Recent_Logs_none;
                }
            }
            selectedPanel = panelEntered;

        }
        private void RecentLogPanels_MouseLeave(object sender, EventArgs e)
        {

        }

    }
}