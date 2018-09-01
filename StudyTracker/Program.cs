using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyTracker
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Excel stuff
            //ExcelConverter convert = new ExcelConverter();
            //convert.ReadExcel(StudyDir.StudyTrackerDir + "TimeLog2.xlsx");
            //convert.WriteExcelToJson(StudyDir.StudyTrackerDir + "Excel.json");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StudyTrackerForm());
        }
    }
}
