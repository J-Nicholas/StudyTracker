using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace StudyTracker
{
    partial class StudyTrackerForm : BaseForm
    {
        private const int maxRecentLogs = 8;
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

        private void GenerateRecentLogs()
        {
            // Generates a list of panels no more than "maxRecentLogs", which all contain labels describing the latest study sessions the student completed
            //variables
            float fontSize = 10f;
            Point lastLogPos = GetIntialLogPos();               // Gets the X, Y co-ordinates of the first recent log panel and then changes Y each time through loop

            for (int i = 0; i < logList.Count && i < maxRecentLogs; i++)
            {
                // --------------Panels -----------------//
                panels.Add(new Panel());
                panels[i].AutoScroll = false;
                RecentLogsContainer.Controls.Add(panels[i]);
                panels[i].Location = lastLogPos;
                panels[i].Size = logPanelDimensions;
                panels[i].Name = "RecentLogPanel" + i.ToString();
                panels[i].Click += RecentLogPanel_Click;                    //select panel by highlighting
                panels[i].MouseEnter += RecentLogPanels_MouseEnter;         // display edit and delete icons for that panel
                panels[i].MouseLeave += RecentLogPanels_MouseLeave;         //  stop displaying edit and delete icons
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
                topicValue[i].Text = $"{logList[i].Topic}";
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
                if (logList[i].TimeStudied.Hours < 1)
                {
                    durationValue[i].Text = $"{logList[i].TimeStudied.Minutes} minutes, and {logList[i].TimeStudied.Seconds} seconds.";
                }
                else
                {
                    durationValue[i].Text = $"{logList[i].TimeStudied.Hours} hours, {logList[i].TimeStudied.Minutes} minutes, and {logList[i].TimeStudied.Seconds} seconds.";
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
                timeStartValue[i].Text = $"{logList[i].StartTime.ToShortTimeString()}";
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
                timeFinishedValue[i].Text = $"{logList[i].EndTime.ToShortTimeString()}";
                //--------------------------------------------//
            }

        }
        private void ClearPanels()
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
    }
}
