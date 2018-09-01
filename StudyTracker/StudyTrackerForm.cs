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
using System.Diagnostics;

namespace StudyTracker
{
    public partial class StudyTrackerForm : BaseForm
    {
        #region RecentLogPanels
        private const int maxRecentLogs = 8;                                // Controls max recent logs that can appear on main menu
        private Size logPanelDimensions = new Size(400, 105);


        private static Point initialLogPos;
        private static List<Panel> panels = new List<Panel>();
        private static List<Label> topics = new List<Label>();
        private static List<Label> topicValue = new List<Label>();
        private static List<Label> durationText = new List<Label>();
        private static List<Label> durationValue = new List<Label>();
        private static List<Label> dateStudied = new List<Label>();
        private static List<Label> dateStudiedValue = new List<Label>();
        private static List<Label> timeStart = new List<Label>();
        private static List<Label> timeStartValue = new List<Label>();
        private static List<Label> timeFinished = new List<Label>();
        private static List<Label> timeFinishedValue = new List<Label>();
        private static List<PictureBox> deleteButtons = new List<PictureBox>();
        private static List<PictureBox> editButtons = new List<PictureBox>();
        private static int spacing = 30;

        public bool HighlightLatest = true;
        public static bool AddedNewEntry = false;



        //To display when there isn't an existing log file
        private static Panel nothingHere;
        private static Label nothingToDisplay;
        private static Label checkBackLabel;

        private Point GetIntialLogPos()
        {
            const int verticalOffset = 10;
            return initialLogPos = new Point(0, verticalOffset);          //make parent first
        }
        private void AddPanelNothingHere()
        {
            //Let the user know there are no logs to display just yet

            // Add Empty Panel contained in RecentLogsPanel 
            nothingHere = new Panel
            {
                Parent = RecentLogsContainer,
                Location = GetIntialLogPos(),
                Name = "NothingHereLabel",
                BackgroundImage = Properties.Resources.Recent_Logs_none,
                BackgroundImageLayout = ImageLayout.Stretch,
                Size = logPanelDimensions
            };
            RecentLogsContainer.Controls.Add(nothingHere);
            nothingHere.Location = new Point(0, (RecentLogsContainer.Height - nothingHere.Height) / 8);
            // Add label telling user that there's nothing here
            nothingToDisplay = new Label
            {
                Text = $"No recent logs to display yet.",
                Name = "NothingLabel",
                Parent = nothingHere,
                AutoSize = true,
                BackColor = Color.Transparent,
                Font = new Font("Lucida Bright", 10, FontStyle.Regular, GraphicsUnit.Point),

            };
            checkBackLabel = new Label
            {
                Text = $"Check back later!",
                Name = "CheckBackLabel",
                Parent = nothingHere,
                AutoSize = true,
                BackColor = Color.Transparent,
                Font = new Font("Lucida Bright", 10, FontStyle.Regular, GraphicsUnit.Point),

            };
            nothingToDisplay.Location = new Point((nothingHere.Width - nothingToDisplay.Size.Width) / 2, (nothingHere.Height - nothingToDisplay.Size.Height) / 2 - (nothingToDisplay.Height / 2) - 2);
            checkBackLabel.Location = new Point((nothingHere.Width - checkBackLabel.Width) / 2, nothingToDisplay.Location.Y + (nothingToDisplay.Height) + 2);


        }

        public void GenerateRecentLogs()
        {
            // Generates a list of panels no more than "maxRecentLogs", which all contain labels describing the latest study sessions the student completed
            //variables
            float fontSize = 10f;
            Point lastLogPos = GetIntialLogPos();               // Gets the X, Y co-ordinates of the first recent log panel and then changes Y each time through loop

            for (int i = 0; i < LogData.StudyLogs.Count && i < maxRecentLogs; i++)
            {
                // --------------Panels -----------------//
                panels.Add(new Panel());
                panels[i].AutoScroll = false;
                RecentLogsContainer.Controls.Add(panels[i]);
                panels[i].Location = lastLogPos;
                panels[i].Size = logPanelDimensions;
                panels[i].Name = "RecentLogPanel" + i.ToString();
                panels[i].MouseEnter += RecentLogPanels_MouseEnter;         // display edit and delete icons for that panel
                if (AddedNewEntry)
                {
                    panels[i].BackgroundImage = Properties.Resources.Recent_Logs;           //Highlights the top
                    selectedPanel = panels[i];
                    AddedNewEntry = false;
                    HighlightLatest = false;
                }
                else if (panels[i].Name == selectedPanel.Name)
                {
                    panels[i].BackgroundImage = Properties.Resources.Recent_Logs;

                }
                else if (HighlightLatest == true)
                {
                    panels[i].BackgroundImage = Properties.Resources.Recent_Logs;           //Highlights the top
                    selectedPanel = panels[i];
                    HighlightLatest = false;
                }
                else
                {
                    panels[i].BackgroundImage = Properties.Resources.Recent_Logs_none;
                }
                panels[i].BackgroundImageLayout = ImageLayout.Stretch;
                lastLogPos = new Point(lastLogPos.X, lastLogPos.Y + logPanelDimensions.Height + spacing);
                //----------------------------------------//

                // --------------Delete Buttons -----------//
                deleteButtons.Add(new PictureBox());
                panels[i].Controls.Add(deleteButtons[i]);
                deleteButtons[i].Size = new Size(25, 25);
                deleteButtons[i].Location = new Point(panels[i].Width - deleteButtons[i].Width - 5, 2);
                deleteButtons[i].BackgroundImage = Properties.Resources.DeleteLogButton;
                deleteButtons[i].BackColor = Color.Transparent;
                deleteButtons[i].BackgroundImageLayout = ImageLayout.Stretch;
                if (selectedPanel == panels[i])
                {
                    deleteButtons[i].Visible = true;
                }
                else if (panels[i].Name == selectedPanel.Name)
                {
                    deleteButtons[i].Show();
                }
                else
                {
                    deleteButtons[i].Visible = false;
                }
                deleteButtons[i].Click += DeleteButton_Click;

                //----------------------------------------//

                // --------------Edit Buttons -----------//
                editButtons.Add(new PictureBox());
                panels[i].Controls.Add(editButtons[i]);
                editButtons[i].Size = new Size(25, 25);
                editButtons[i].Location = new Point(panels[i].Width - editButtons[i].Width - 5, panels[i].Height - editButtons[i].Height - 2);
                editButtons[i].BackgroundImage = Properties.Resources.EditButton;
                editButtons[i].BackColor = Color.Transparent;
                editButtons[i].BackgroundImageLayout = ImageLayout.Stretch;
                if (selectedPanel == panels[i])
                {
                    editButtons[i].Visible = true;
                }
                else if (panels[i].Name == selectedPanel.Name)
                {
                    editButtons[i].Visible = true;
                }
                else
                {
                    editButtons[i].Visible = false;
                }
                editButtons[i].Click += EditButton_Click;
                //----------------------------------------//


                // --------------Topics Labels -----------//
                topics.Add(new Label());
                panels[i].Controls.Add(topics[i]);
                topics[i].Location = new Point(20, 3);
                topics[i].AutoSize = true;
                topics[i].Text = "Topic:";
                topics[i].BackColor = Color.Transparent;
                topics[i].Font = new Font("lucidia Bright", fontSize, FontStyle.Italic, GraphicsUnit.Point);
                //----------------------------------------//



                // -------Topic that they studied value-----//
                topicValue.Add(new Label());
                panels[i].Controls.Add(topicValue[i]);
                topicValue[i].Location = new Point(topics[i].Location.X + topics[i].Width + spacing, topics[i].Location.Y);
                topicValue[i].AutoSize = true;
                topicValue[i].Text = $"{LogData.StudyLogs[i].Topic}";
                topicValue[i].BackColor = Color.Transparent;
                topicValue[i].Font = new Font("lucidia Bright", fontSize, FontStyle.Bold, GraphicsUnit.Point);
                //----------------------------------------//


                // -----------Duration Label--------------//
                durationText.Add(new Label());
                panels[i].Controls.Add(durationText[i]);
                durationText[i].Location = new Point(topics[i].Location.X, topics[i].Location.Y + spacing);
                durationText[i].AutoSize = true;
                durationText[i].Text = "Duration:";
                durationText[i].BackColor = Color.Transparent;
                durationText[i].Font = new Font("lucidia Bright", fontSize, FontStyle.Italic, GraphicsUnit.Point);
                //----------------------------------------//


                //Durationn that they studied value
                durationValue.Add(new Label());
                panels[i].Controls.Add(durationValue[i]);
                durationValue[i].AutoSize = true;
                if (LogData.StudyLogs[i].TimeStudied.Hours < 1)
                {
                    durationValue[i].Text = $"{LogData.StudyLogs[i].TimeStudied.Minutes} minutes, and {LogData.StudyLogs[i].TimeStudied.Seconds} seconds.";
                }
                else
                {
                    durationValue[i].Text = $"{LogData.StudyLogs[i].TimeStudied.Hours} hours, {LogData.StudyLogs[i].TimeStudied.Minutes} minutes, and {LogData.StudyLogs[i].TimeStudied.Seconds} seconds.";
                }
                durationValue[i].Location = new Point(topicValue[i].Location.X, durationText[i].Location.Y);
                durationValue[i].BackColor = Color.Transparent;
                durationValue[i].Font = new Font("lucidia Bright", fontSize, FontStyle.Italic, GraphicsUnit.Point);
                //----------------------------------------//



                // Date Label 
                dateStudied.Add(new Label());
                panels[i].Controls.Add(dateStudied[i]);
                dateStudied[i].AutoSize = true;
                dateStudied[i].Location = new Point(topics[i].Location.X, durationText[i].Location.Y + spacing - 10);
                dateStudied[i].Text = "When:";
                dateStudied[i].BackColor = Color.Transparent;
                dateStudied[i].Font = new Font("lucidia Bright", fontSize, FontStyle.Italic, GraphicsUnit.Point);
                //----------------------------------------//



                // Date/ how long its been since session if it was today
                dateStudiedValue.Add(new Label());
                panels[i].Controls.Add(dateStudiedValue[i]);
                dateStudiedValue[i].AutoSize = true;
                dateStudiedValue[i].BackColor = Color.Transparent;
                dateStudiedValue[i].Font = new Font("Lucidia Bright", fontSize, FontStyle.Italic, GraphicsUnit.Point);
                dateStudiedValue[i].Location = new Point(durationValue[i].Location.X, durationValue[i].Location.Y + spacing - 10);
                if (LogData.StudyLogs[i].EndDate.Day == DateTime.Now.Day)
                {
                    var timePassed = DateTime.Now.Subtract(LogData.StudyLogs[i].EndDate);

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
                    dateStudiedValue[i].Text = $"{LogData.StudyLogs[i].EndDate.ToShortDateString()}";

                //----------------------------------------//

                //----------------Time Started-------------------//
                timeStart.Add(new Label());
                panels[i].Controls.Add(timeStart[i]);
                timeStart[i].AutoSize = true;
                timeStart[i].BackColor = Color.Transparent;
                timeStart[i].Font = new Font("Lucidia Bright", fontSize, FontStyle.Italic, GraphicsUnit.Point);
                timeStart[i].Location = new Point(dateStudied[i].Location.X, dateStudied[i].Location.Y + spacing - 10);
                timeStart[i].Text = "Started:";
                //--------------------------------------------//


                //----------------Time Started Value------------//
                timeStartValue.Add(new Label());
                panels[i].Controls.Add(timeStartValue[i]);
                timeStartValue[i].AutoSize = true;
                timeStartValue[i].BackColor = Color.Transparent;
                timeStartValue[i].Font = new Font("Lucidia Bright", fontSize, FontStyle.Italic, GraphicsUnit.Point);
                timeStartValue[i].Location = new Point(dateStudiedValue[i].Location.X, dateStudied[i].Location.Y + spacing - 10);
                timeStartValue[i].Text = $"{LogData.StudyLogs[i].StartTime.ToShortTimeString()}";
                //--------------------------------------------//


                //----------------Time Finished-------------------//
                timeFinished.Add(new Label());
                panels[i].Controls.Add(timeFinished[i]);
                timeFinished[i].AutoSize = true;
                timeFinished[i].BackColor = Color.Transparent;
                timeFinished[i].Font = new Font("Lucidia Bright", fontSize, FontStyle.Italic, GraphicsUnit.Point);
                timeFinished[i].Location = new Point(
                timeStartValue[i].Location.X + timeStartValue[i].Width + spacing, timeStartValue[i].Location.Y);                                                   // Y
                timeFinished[i].Text = "Finished:";
                //--------------------------------------------//

                //----------------Time Finished Value------------//
                timeFinishedValue.Add(new Label());
                panels[i].Controls.Add(timeFinishedValue[i]);
                timeFinishedValue[i].AutoSize = true;
                timeFinishedValue[i].BackColor = Color.Transparent;
                timeFinishedValue[i].Font = new Font("Lucidia Bright", fontSize, FontStyle.Italic, GraphicsUnit.Point);
                timeFinishedValue[i].Location = new Point(timeFinished[i].Location.X + timeFinished[i].Width + spacing, timeStart[i].Location.Y);
                timeFinishedValue[i].Text = $"{LogData.StudyLogs[i].EndTime.ToShortTimeString()}";
                //--------------------------------------------//
            }

        }
        public void ClearPanels()
        {
            RecentLogsContainer.Controls.Clear();
            panels.Clear();
            topics.Clear();
            topicValue.Clear();
            durationText.Clear();
            durationValue.Clear();
            dateStudied.Clear();
            dateStudiedValue.Clear();
            timeStart.Clear();
            timeStartValue.Clear();
            timeFinished.Clear();
            timeFinishedValue.Clear();
            editButtons.Clear();
            deleteButtons.Clear();

        }

        #endregion


        private static StudyTrackerForm studyTracker;   // reference to this form that can be accessed by property 
        private static Label startButtonLabel;
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
        
        private void StudyTrackerForm_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                // Try and read Json file with logs. If file can't be found. Tell the user there isn't any logs just yet
                ClearPanels();
                studyTracker.Focus();
                if (File.Exists(StudyDir.logsDir))
                {
                    LogData.ReadFromFile();
                    GenerateRecentLogs();

                    if (LogData.StudyLogs.Count == 0)
                    {
                        // Log file exists but there are no logs in it

                        AddPanelNothingHere();
                    }
                }
                else
                {       // Let the user know that there aren't any logs just yet but to check back later
                    AddPanelNothingHere();
                }
            }
        }

        private void RecentLogsContainer_Enter(object sender, EventArgs e)
        {
            RecentLogsContainer.Focus();
        }

        private void RefreshRecentLogs_Tick(object sender, EventArgs e)
        {
            if (Debugger.IsAttached)
            {
                RefreshRecentLogs.Enabled = true;
            }
            if (ActiveForm == StudyTracker && EditRecentLog.EditLogRef.Visible == false)
            {
                for (int i = 0; i < dateStudiedValue.Count; i++)
                {
                    if (LogData.StudyLogs[i].EndDate.Day == DateTime.Now.Day)
                    {
                        var timePassed = DateTime.Now.Subtract(LogData.StudyLogs[i].EndDate);

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
                        dateStudiedValue[i].Text = $"{LogData.StudyLogs[i].EndDate.ToShortDateString()}";
                }
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
                    LogData.StudyLogs.RemoveAt(i);
                }
            }

            // Generate new panels
            ClearPanels();
            GenerateRecentLogs();
            RecentLogsContainer.VerticalScroll.Value = ScrollPosition;

            // Write changes to file
            LogData.WriteToFile();

            // If loglist is now empty, show empty panel notification
            if (LogData.StudyLogs.Count == 0)
            {
                AddPanelNothingHere();
            }

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            PictureBox selectedEdit = (PictureBox)sender;

            for (int i = 0; i < panels.Count; i++)
            {
                if (selectedEdit.Parent == panels[i])
                {
                    // correct index of panel to edit
                    EditRecentLog.EditIndex = i;
                }
            }

            
            EditRecentLog.EditLogRef.Location = new Point(StudyTracker.Location.X + StudyTracker.Width / 2, StudyTracker.Location.Y );
            DialogResult result = EditRecentLog.EditLogRef.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Save changes by writing to file
                LogData.WriteToFile();
                ClearPanels();
                GenerateRecentLogs();
            }
            else 
            {
                // do nothing 
            }
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

        private void AddLogButton_Click(object sender, EventArgs e)
        {
            //AddNewLog.AddNewLogRef.StartPosition = FormStartPosition.CenterParent;
            DialogResult result;
            AddNewLog.AddNewLogRef.StartPosition = FormStartPosition.Manual;
            AddNewLog.AddNewLogRef.Location = new Point(StudyTracker.Location.X+ AddNewLog.AddNewLogRef.Width/2, StudyTracker.Location.Y );

            result = AddNewLog.AddNewLogRef.ShowDialog();
            if (result == DialogResult.OK)
            {
                // show confirmation 
                MessageBox.Show("Your log has been saved.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Write logs to file
                LogData.WriteToFile();

                ClearPanels();
                GenerateRecentLogs();
            }
        }
    }
}