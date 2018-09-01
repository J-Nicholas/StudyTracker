using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace StudyTracker
{
    /// <summary>
    /// Class that holds all logs retrieved from file.
    /// </summary>
    public static class LogData
    {
        private static List<StudyLog> studyLogs;
        /// <summary>
        /// Contains the list of all study logs that have been read from file.
        /// </summary>
        public static List<StudyLog> StudyLogs
        {
            get
            {
                if (studyLogs == null)
                {
                    studyLogs = new List<StudyLog>();
                }
                return studyLogs;
            }
            set
            {
                studyLogs = value;
            }
        }

        /// <summary>
        /// Gets list of study logs from file, orderers them by EndDate in descending order and assigns them to the StudyLogs list.
        /// </summary>
        public static void ReadFromFile ()
        {
            if (File.Exists(StudyDir.logsDir))
            {
                try
                {
                    var jsonData = File.ReadAllText(StudyDir.logsDir);
                    StudyLogs = JsonConvert.DeserializeObject<List<StudyLog>>(jsonData)
                                                    ?? new List<StudyLog>();
                    // order it by most recent first
                    var sortedLogList = from logs in StudyLogs
                                        orderby logs.EndDate descending
                                        select logs;
                    StudyLogs = sortedLogList.ToList();
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

        /// <summary>
        /// Writes the current list of StudyLogs to the logs file and orders them in descending order by EndDate
        /// </summary>
        public static void WriteToFile ()
        {
            var orderedLogs = from logs in StudyLogs
                              orderby logs.EndDate descending
                              select logs;
            StudyLogs = orderedLogs.ToList();
            var jsonData = JsonConvert.SerializeObject(StudyLogs);
            File.WriteAllText(StudyDir.logsDir, jsonData);

        }

    }
}
