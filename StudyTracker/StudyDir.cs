using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StudyTracker
{
    public class StudyDir
    {
        //list of directories that I can fetch easily
        public static string StudyTrackerDir { get; } = $"{ Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}" + @"\Study Tracker\";
        public static string TopicDir { get; } = StudyTrackerDir + "topics.txt";
        public static string logsDir { get; } = StudyTrackerDir + "logs.json";
        public static string settingsDir { get; } = StudyTrackerDir + "settings.json";
    }
}
