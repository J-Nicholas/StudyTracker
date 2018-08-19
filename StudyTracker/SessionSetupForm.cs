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
using Newtonsoft.Json;

namespace StudyTracker
{
    public partial class SessionSetupForm : BaseForm
    {
        private static SessionSetupForm sessionSetup = null;
        private FileStream file;
        private List<string> topicsFromFile = new List<string>();

        public SessionSetupForm()
        {
            InitializeComponent();
            MessageBox.Show($"Base width = {base.ToString()}\nSession Setup Width: {this.Width}");
            this.MaximumSize = base.MaximumSize;
            this.Size = new Size(base.Width, base.Height);


        }

        public static SessionSetupForm SessionSetup
        {
            //form singleton, only allows one instance of a form and allows access to it from other classes
            get
            {
                if (sessionSetup == null)
                {
                    sessionSetup = new SessionSetupForm();
                }
                return sessionSetup;
            }
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
        private void SessionSetupForm_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(StudyDir.StudyTrackerDir))
            {
                Directory.CreateDirectory(StudyDir.StudyTrackerDir);
                using (File.Create(StudyDir.TopicDir)) { };
            }

            RemoveDuplicatesFromFile(StudyDir.TopicDir);
            GetTopicsFromFile();

            dateBox.Text = DateTime.Today.ToShortDateString();
            timeBox.Text = DateTime.Now.ToLongTimeString();
        }
        private void currentTimeTimer_Tick(object sender, EventArgs e)
        {
            //updates once a second i.e. 1000ms tick
            timeBox.Text = DateTime.Now.ToLongTimeString();
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            StudyTrackerForm.StudyTracker.Location = sessionSetup.Location;
            StudyTrackerForm.StudyTracker.Show();
            SessionSetup.Hide();
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            // Saves a topic to file if valid. This file can then be accessed to get previously saved topics in a combo box
            if (topicComboBox.Text.Trim(' ') == string.Empty) //trims all spaces from combobox and checks if it is empty
            {
                MessageBox.Show("Topic cannot be empty.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (topicComboBox.Items.Contains(topicComboBox.Text))
            {
                MessageBox.Show("Topic already saved!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
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
        private void topicComboBox_DropDownClosed(object sender, EventArgs e)
        {
            ManageDeleteButton();
        }
        private void topicComboBox_TextChanged(object sender, EventArgs e)
        {
            ManageDeleteButton();
        }
        private void ManageDeleteButton()
        {
            string text = topicComboBox.Text + "\r\n";                  // combobox.items contains strings with \r\n after them

            if (topicComboBox.Items.Contains(text))                     // catches match when topic was typed in
            {                                                           // has added \r\n to what was typed in to box
                deleteButton.Enabled = true;
                deleteButton.BackgroundImage = Properties.Resources.MenuStrip;
                deleteButton.FlatStyle = FlatStyle.Popup;
            }
            else if (topicComboBox.Items.Contains(topicComboBox.Text))  // catches match when topic was selected
            {                                                           // don't add \r\n because when topic is selected, it already has \r\n
                deleteButton.Enabled = true;                            // because it is fetched from items collecction
                deleteButton.BackgroundImage = Properties.Resources.MenuStrip;
                deleteButton.FlatStyle = FlatStyle.Popup;
            }
            else
            {
                deleteButton.Enabled = false;
                deleteButton.BackgroundImage = null;
                deleteButton.BackColor = Color.DimGray;
            }

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
        private void startButton_Click(object sender, EventArgs e)
        {
            if (topicComboBox.Text.Trim(' ') == string.Empty)
            {
                MessageBox.Show("Topic cannot be empty.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                StudyLog log = new StudyLog(
                    topicComboBox.Text,
                    DateTime.Parse(timeBox.Text),
                    DateTime.Parse(dateBox.Text),
                    descriptionBox.Text);
                // Pass log to Session Manager
                SessionManagerForm.StudyLogRef = log;

                string jsonOutput = JsonConvert.SerializeObject(log, Formatting.Indented);
                JsonSerializer serializer = new JsonSerializer();

                using (var sw = new StreamWriter(StudyDir.logsDir, true))
                {
                    using (var jsonWriter = new JsonTextWriter(sw))
                    {
                        serializer.Serialize(jsonWriter, jsonOutput);
                    }
                }
                SessionManagerForm.SessionManagerRef.Show();
                SessionManagerForm.SessionManagerRef.Location = this.Location;
                this.Hide();

            }
        }
    }
}
