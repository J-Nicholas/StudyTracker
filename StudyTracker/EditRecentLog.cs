using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StudyTracker
{
    public partial class EditRecentLog : Form
    {
        private static Form editLogRef;
        private static StudyLog StudylogToEdit { get; set; }
        private FileStream file;
        private List<string> topicsFromFile = new List<string>();

        /// <summary>
        /// The index of the StudyLogs list that is being changed.
        /// </summary>
        public static int EditIndex { get; set; }

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

        private void SetTextBoxes()
        {
            topicComboBox.Text = StudylogToEdit.Topic;
            StartTimeBox.Text = StudylogToEdit.StartTime.ToShortTimeString();
            dateBox.Text = StudylogToEdit.StartDate.ToShortDateString();
            descriptionBox.Text = StudylogToEdit.Description;
            TimeFinishedBox.Text = StudylogToEdit.EndTime.ToShortTimeString();
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
        private void startButton_Click(object sender, EventArgs e)
        {
            if (ValidateTextBoxes())
            {
                // validated, pass back the data
                StudylogToEdit.Topic = topicComboBox.Text;
                StudylogToEdit.StartTime = DateTime.Parse(StartTimeBox.Text);
                StudylogToEdit.EndTime = DateTime.Parse(TimeFinishedBox.Text);
                StudylogToEdit.StartDate = DateTime.Parse(dateBox.Text);
                StudylogToEdit.Description = descriptionBox.Text;

                //testing 


                if (StudylogToEdit.StartTime > StudylogToEdit.EndTime)
                {
                    // if started before midnight and finished after
                    if (StudylogToEdit.StartTime.Hour <= 23 && StudylogToEdit.EndTime.Hour >= 0)
                    {
                        // The end time was after 12 O'clock so the date advanced 1 day
                        StudylogToEdit.EndDate = StudylogToEdit.StartDate.AddDays(1);

                        // If started before 12 am and finished after 12 am and less than start time

                        TimeSpan oneDay = new TimeSpan(1, 0, 0, 0);
                        TimeSpan timeBeforeTwelve = oneDay.Subtract(StudylogToEdit.StartTime.TimeOfDay);

                        TimeSpan tempTimeStudied = timeBeforeTwelve + StudylogToEdit.EndTime.TimeOfDay;

                        StudylogToEdit.TimeStudied = tempTimeStudied;
                    }
                }
                else
                {
                    StudylogToEdit.TimeStudied = StudylogToEdit.EndTime.Subtract(StudylogToEdit.StartTime);
                    StudylogToEdit.EndDate = StudylogToEdit.StartDate + StudylogToEdit.EndTime.TimeOfDay;
                }
                // Update the log that is being changed with latest changes
                LogData.StudyLogs[EditIndex] = StudylogToEdit;

            }
            else DialogResult = DialogResult.None;
        }

        private void EditRecentLog_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                StudylogToEdit = LogData.StudyLogs[EditIndex];
                SetTextBoxes();
                if (!Directory.Exists(StudyDir.StudyTrackerDir))
                {
                    Directory.CreateDirectory(StudyDir.StudyTrackerDir);
                    using (File.Create(StudyDir.TopicDir)) { };
                }

                RemoveDuplicatesFromFile(StudyDir.TopicDir);
                GetTopicsFromFile();
            }

        }
        

        private void EditRecentLog_Load(object sender, EventArgs e)
        {

        }

        private void GetTopicsFromFile()
        {
            topicComboBox.Items.Clear();
            try
            {
                if (!File.Exists(StudyDir.TopicDir))             //if file doesn't exist
                {
                    try
                    {
                        using (File.Create(StudyDir.TopicDir)) { };
                    }
                    catch (IOException)
                    {
                        MessageBox.Show($"Failed to create topics.txt at: {StudyDir.TopicDir}");
                    }

                }
                using (file = new FileStream(StudyDir.TopicDir, FileMode.Open, FileAccess.Read))
                {
                    using (var input = new StreamReader(file))
                    {
                        file.Seek(0, SeekOrigin.Begin);

                        string fileLine;
                        while ((fileLine = input.ReadLine()) != null)
                        {
                            if (!topicsFromFile.Contains(fileLine) && fileLine != string.Empty)         //if list does NOT contain topic, add it.
                            {
                                topicsFromFile.Add(fileLine);
                            }
                        }
                        file?.Close();

                        foreach (var topic in topicsFromFile)
                        {
                            topicComboBox.Items.Add(topic + Environment.NewLine);
                            if (topicComboBox.Items.Contains(topic) && !topicsFromFile.Contains(fileLine))
                            {
                                topicComboBox.Items.Remove(topic);
                            }
                        }
                    }
                }

            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void RemoveDuplicatesFromFile(string filePath)
        {
            string[] topics;
            string[] delims = new string[] { "\r\n" };
            string temp;

            //commit what is in the file already to memory, if there is a duplicate, do not add.

            topics = File.ReadAllText(filePath).Split(delims, StringSplitOptions.RemoveEmptyEntries);

            List<string> topicList = new List<string>(topics);
            IEnumerable<string> topicNoDuplicates = topicList.Distinct();

            temp = Path.GetTempFileName();

            using (var sw = new StreamWriter(temp))
            {
                foreach (var item in topicNoDuplicates)
                {
                    sw.WriteLine(item);
                }
            }

            File.Delete(filePath);
            File.Move(temp, filePath);
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            char[] delims = { '\r', '\n' };
            string text = topicComboBox.Text;
            text = text.Trim(delims);
            string tempFile = Path.GetTempFileName();
            // Delete the topic from file


            if (topicsFromFile.Contains(text))
            {
                topicsFromFile.Remove(text);

                if (topicComboBox.Items.Contains(text))
                {
                    topicComboBox.Items.Remove(text);
                    MessageBox.Show("removed item with no added \r\n");
                }
                using (file = new FileStream(tempFile, FileMode.Open, FileAccess.Write))
                {
                    using (var writer = new StreamWriter(file))
                    {
                        foreach (var topic in topicsFromFile)
                        {
                            writer.WriteLine(topic + Environment.NewLine);
                        }
                    }
                }
                File.Delete(StudyDir.TopicDir);
                File.Move(tempFile, StudyDir.TopicDir);
                MessageBox.Show("This item has been deleted.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

                topicComboBox.Items.Clear();
                GetTopicsFromFile();
                topicComboBox.Text = string.Empty;
            }

        }
        private void ManageDeleteButton()
        {
            string text = topicComboBox.Text + "\r\n";                  // combobox.items contains strings with \r\n after them

            if (topicComboBox.Items.Contains(text))                     // catches match when topic was typed in
            {                                                           // has added \r\n to what was typed in to box
                deleteButton.Enabled = true;
                deleteButton.BackColor = Color.FromArgb(60, 80, 95);
                //deleteButton.FlatStyle = FlatStyle.Popup;
            }
            else if (topicComboBox.Items.Contains(topicComboBox.Text))  // catches match when topic was selected
            {                                                           // don't add \r\n because when topic is selected, it already has \r\n
                deleteButton.Enabled = true;                            // because it is fetched from items collecction
                deleteButton.BackColor = Color.FromArgb(60, 80, 95);
                //deleteButton.FlatStyle = FlatStyle.Popup;
            }
            else
            {
                deleteButton.Enabled = false;
                deleteButton.BackgroundImage = null;
                deleteButton.BackColor = Color.FromArgb(100, 130, 150);    //medium blue, used for start button, save button and delete.
            }

        }

        private void topicComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ManageDeleteButton();
        }
        private bool TopicValidated()
        {
            if (topicComboBox.Text.Trim(' ') == string.Empty) //trims all spaces from combobox and checks if it is empty
            {
                MessageBox.Show("Topic cannot be empty.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (topicComboBox.Items.Contains(topicComboBox.Text))
            {
                MessageBox.Show("Topic already saved!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else return true;
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            // Saves a topic to file if valid. This file can then be accessed to get previously saved topics in a combo box
            if (ValidateTextBoxes() == true && TopicValidated() == true)
            {
                string topicToSave = topicComboBox.Text;

                if (Directory.Exists(StudyDir.StudyTrackerDir))
                {
                    try
                    {
                        using (file = new FileStream(StudyDir.TopicDir, FileMode.Append, FileAccess.Write))
                        {
                            using (var output = new StreamWriter(file))
                                output.WriteLine(topicToSave);
                        };
                    }
                    catch (IOException error)
                    {
                        Console.WriteLine(error.Message);
                        MessageBox.Show("Could not write to file.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        file?.Dispose();
                    }
                }
                else
                {
                    MessageBox.Show($"Could not find program folder at:\n{StudyDir.StudyTrackerDir}");
                }

                MessageBox.Show("Topic has been saved. Use the dropdown-box to select it quickly in future.",
                    "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetTopicsFromFile();
            }
            ManageDeleteButton();   //calling this here so that once a new item has been added, it can be deleted right away
        }

        private void topicComboBox_DropDown(object sender, EventArgs e)
        {
            RemoveDuplicatesFromFile(StudyDir.TopicDir);
            GetTopicsFromFile();
            ManageDeleteButton();
        }

        private void topicComboBox_DropDownClosed(object sender, EventArgs e)
        {
            ManageDeleteButton();
        }

        private void topicComboBox_TextChanged(object sender, EventArgs e)
        {
            ManageDeleteButton();
        }
    }
}
