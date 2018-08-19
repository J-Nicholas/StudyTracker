using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_dictionary_syntax
{
    public enum STDir
    {
        StudyTrackerDir,
        TopicPath,
        UserDocumentDir,

    }
    class test
    {
        public test()
        {

        }
        public static  Dictionary<STDir, string> directories = new Dictionary<STDir, string>()
        {
            [STDir.UserDocumentDir] = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}",
            [STDir.StudyTrackerDir] = $"{directories[STDir.UserDocumentDir]}" + @"\Study Tracker\",
            [STDir.TopicPath] = $"{directories[STDir.StudyTrackerDir]}" + "topic.txt"
        };

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"First value of dictionary: {test.directories[STDir.UserDocumentDir]}");

        }
    }
}

