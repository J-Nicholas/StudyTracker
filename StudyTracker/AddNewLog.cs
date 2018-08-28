using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyTracker
{
    public partial class AddNewLog : Form
    {
        private static Form addNewLogRef;
        private static StudyLog newLogToAdd = new StudyLog();
        private static bool canSave = false;


        public AddNewLog()
        {
            InitializeComponent();
            addNewLogRef = this;

            FinishedButton.DialogResult = DialogResult.OK;
            cancelButton.DialogResult = DialogResult.Cancel;

        }
        public static Form AddNewLogRef
        {
            get
            {
                if (addNewLogRef == null)
                {
                    addNewLogRef = new AddNewLog();
                }
                return addNewLogRef;
            }
        }

        private void FinishedButton_Click(object sender, EventArgs e)
        {
            if (ValidateTextBoxes())
            {
                // validated, pass back the data
                newLogToAdd.Topic = topicComboBox.Text;
                newLogToAdd.StartTime = DateTime.Parse(StartTimeBox.Text);
                newLogToAdd.EndTime = DateTime.Parse(TimeFinishedBox.Text);
                newLogToAdd.StartDate = DateTime.Parse(dateBox.Text);
                newLogToAdd.Description = descriptionBox.Text;

                //testing 


                if (newLogToAdd.StartTime > newLogToAdd.EndTime)
                {
                    // if started before midnight and finished after
                    if (newLogToAdd.StartTime.Hour <= 23 && newLogToAdd.EndTime.Hour >= 0)
                    {
                        // The end time was after 12 O'clock so the date advanced 1 day
                        newLogToAdd.EndDate = newLogToAdd.StartDate.AddDays(1);

                        // If started before 12 am and finished after 12 am and less than start time

                        TimeSpan oneDay = new TimeSpan(1, 0, 0, 0);
                        TimeSpan timeBeforeTwelve = oneDay.Subtract(newLogToAdd.StartTime.TimeOfDay);

                        TimeSpan tempTimeStudied = timeBeforeTwelve + newLogToAdd.EndTime.TimeOfDay;

                        newLogToAdd.TimeStudied = tempTimeStudied;
                    }
                }
                else
                {
                    newLogToAdd.TimeStudied = newLogToAdd.EndTime.Subtract(newLogToAdd.StartTime);
                    newLogToAdd.EndDate = newLogToAdd.StartDate + newLogToAdd.EndTime.TimeOfDay;
                }
                // pass log to studylog in StudyTrackerForm
                StudyTrackerForm.newLogFromAddForm = newLogToAdd;
                newLogToAdd = new StudyLog();
                canSave = true;
            }
            else
                this.DialogResult = DialogResult.None;
        }
        private bool ValidateTextBoxes()
        {
            DateTime TestDateParse;
            DateTime desiredStartDate;
            TimeSpan tempStartTime;
            TimeSpan tempEndTime;

            desiredStartDate = DateTime.Parse(dateBox.Text);
            TimeSpan.TryParse(StartTimeBox.Text, out tempStartTime);
            TimeSpan.TryParse(TimeFinishedBox.Text, out tempEndTime);

            if (topicComboBox.Text.Trim(' ') == string.Empty)
            {
                MessageBox.Show("Topic cannot be empty!");
                return false;
            }
            else if (StartTimeBox.Text.Trim(' ') == string.Empty)
            {
                MessageBox.Show("Start Time cannot be empty!");
                return false;
            }
            else if (TimeFinishedBox.Text.Trim(' ') == string.Empty)
            {
                MessageBox.Show("Finish Time cannot be empty!");
                return false;
            }
            else if (dateBox.Text.Trim(' ') == string.Empty)
            {
                MessageBox.Show("Date cannot be empty!");
                return false;
            }
            else if (tempEndTime < tempStartTime && !(tempEndTime >= TimeSpan.MinValue && tempEndTime < tempStartTime))
            {
                MessageBox.Show("Start time can't be later than end time.");
                return false;
            }
            else if (DateTime.Now < DateTime.Parse(dateBox.Text))
            {
                MessageBox.Show("Date cannot be in the future!");
                return false;
            }
            else if (!DateTime.TryParse(dateBox.Text, out TestDateParse))
            {
                MessageBox.Show("Invalid Date Format.");
                return false;
            }
            else if (!DateTime.TryParse(StartTimeBox.Text, out TestDateParse))
            {
                MessageBox.Show("Invalid Time Started Format.");
                return false;
            }
            else if (!DateTime.TryParse(TimeFinishedBox.Text, out TestDateParse))
            {
                MessageBox.Show("Invalid Time Finished format.");
                return false;
            }
            else if (TimeSpan.TryParse(StartTimeBox.Text, out tempStartTime) && (tempStartTime > DateTime.Now.TimeOfDay && desiredStartDate == DateTime.Now.Date))
            {
                MessageBox.Show("Time started cannot be in the future.");
                return false;
            }
            else if (TimeSpan.TryParse(TimeFinishedBox.Text, out tempEndTime) && (tempEndTime > DateTime.Now.TimeOfDay && desiredStartDate == DateTime.Now.Date))
            {
                MessageBox.Show("Time finished cannot be in the future.");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void AddNewLog_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
        private void ClearForm ()
        {
            topicComboBox.Text = string.Empty;
            StartTimeBox.Text = $"{DateTime.Now.ToShortTimeString()}";
            TimeFinishedBox.Text = $"{DateTime.Now.ToShortTimeString()}";
            dateBox.Text = $"{DateTime.Now.Day}/{DateTime.Now.Month}/{DateTime.Now.Year}";
            descriptionBox.Text = string.Empty;
        }

        private void AddNewLog_VisibleChanged(object sender, EventArgs e)
        {
            ClearForm();
            canSave = false;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
        }
    }
}
