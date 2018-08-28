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
    public partial class EditRecentLog : Form
    {
        private static Form editLogRef;
        private static StudyLog editStudyLogRef;
        private static bool IsValidated = false;
        private static bool TriedToSave = false;

        public EditRecentLog()
        {
            InitializeComponent();
            editLogRef = this;
            FinishedButton.DialogResult = DialogResult.OK;
            cancelButton.DialogResult = DialogResult.Cancel;
        }
        public static Form EditLogRef
        {
            get
            {
                if (editLogRef == null)
                {
                    editLogRef = new EditRecentLog();
                }
                return editLogRef;
            }
        }
        public static StudyLog EditStudyLogRef
        {
            get
            {
                if (editStudyLogRef == null)
                {
                    editStudyLogRef = new StudyLog();
                }
                return editStudyLogRef;
            }
            set
            {
                editStudyLogRef = value;
            }
        }
        private void SetTextBoxes()
        {
            topicComboBox.Text = EditStudyLogRef.Topic;
            StartTimeBox.Text = EditStudyLogRef.StartTime.ToShortTimeString();
            dateBox.Text = EditStudyLogRef.StartDate.ToShortDateString();
            descriptionBox.Text = EditStudyLogRef.Description;
            TimeFinishedBox.Text = EditStudyLogRef.EndTime.ToShortTimeString();
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
                IsValidated = true;
                return true;
            }
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            TriedToSave = true;
            if (ValidateTextBoxes())
            {
                // validated, pass back the data
                EditStudyLogRef.Topic = topicComboBox.Text;
                EditStudyLogRef.StartTime = DateTime.Parse(StartTimeBox.Text);
                EditStudyLogRef.EndTime = DateTime.Parse(TimeFinishedBox.Text);
                EditStudyLogRef.StartDate = DateTime.Parse(dateBox.Text);
                EditStudyLogRef.Description = descriptionBox.Text;

                //testing 


                if (EditStudyLogRef.StartTime > EditStudyLogRef.EndTime)
                {
                    // if started before midnight and finished after
                    if (EditStudyLogRef.StartTime.Hour <= 23 && EditStudyLogRef.EndTime.Hour >= 0)
                    {
                        // The end time was after 12 O'clock so the date advanced 1 day
                        EditStudyLogRef.EndDate = EditStudyLogRef.StartDate.AddDays(1);

                        // If started before 12 am and finished after 12 am and less than start time

                        TimeSpan oneDay = new TimeSpan(1, 0, 0, 0);
                        TimeSpan timeBeforeTwelve = oneDay.Subtract(EditStudyLogRef.StartTime.TimeOfDay);

                        TimeSpan tempTimeStudied = timeBeforeTwelve + EditStudyLogRef.EndTime.TimeOfDay;

                        EditStudyLogRef.TimeStudied = tempTimeStudied;
                    }

                }
                else
                {
                    EditStudyLogRef.TimeStudied = EditStudyLogRef.EndTime.Subtract(EditStudyLogRef.StartTime);
                    EditStudyLogRef.EndDate = EditStudyLogRef.StartDate + EditStudyLogRef.EndTime.TimeOfDay;
                }

            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            TriedToSave = false;
        }

        private void EditRecentLog_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void EditRecentLog_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                SetTextBoxes();
            }
        }

        private void EditRecentLog_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (TriedToSave == true && IsValidated == true)
            {
                e.Cancel = false;
            }
            else if (TriedToSave == false)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
