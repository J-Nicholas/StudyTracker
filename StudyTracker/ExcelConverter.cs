using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Runtime.InteropServices;

namespace StudyTracker
{
    class ExcelConverter
    {
        private List<StudyLog> excelStudyLog = new List<StudyLog>();

        public void ReadExcel(string workBook)
        {
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(workBook);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;

            //if (xlRange.Cells[2, 1] != null && xlRange.Cells[2, 1].Value2 != null)
            //    MessageBox.Show($"{xlRange.Cells[2, 1].Value2.ToString() + "\t"}");

            StudyLog log = new StudyLog();
            for (int i = 2; i <= 77; i++)                       //rows
            {
                log = new StudyLog();
                for (int j = 1; j <= 6; j++)                    //columns
                {
                    //write the value to the console
                    if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
                    {
                        switch (j)
                        {
                            case 1:
                                log.Topic = xlRange.Cells[i, j].Value.ToString();
                                break;
                            case 2:
                                log.Description = xlRange.Cells[i, j].Value.ToString();
                                break;
                            case 3:
                                log.StartDate = DateTime.Parse(xlRange.Cells[i, j].Value.ToString());
                                log.EndDate = DateTime.Parse(xlRange.Cells[i, j].Value.ToString());
                                break;
                            case 4:
                                log.StartTime = DateTime.Parse(xlRange.Cells[i, j].Value.ToString());
                                break;
                            case 5:
                                log.EndTime = DateTime.Parse(xlRange.Cells[i, j].Value.ToString());
                                break;
                            case 6:
                                log.TimeStudied = TimeSpan.Parse(xlRange.Cells[i, j].Value.ToString());
                                break;
                            default:
                                throw new Exception("Mistake in switch statement. Read Excel Function.");
                        }
                    }
                }
                if (log.Topic != null)
                {
                    excelStudyLog.Add(log);
                }
            }

            //cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();

            //rule of thumb for releasing com objects:
            //  never use two dots, all COM objects must be referenced and released individually
            //  ex: [somthing].[something].[something] is bad

            //release com objects to fully kill excel process from running in the background
            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);

            //close and release
            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);

            //quit and release
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);
        }
        public void WriteExcelToJson(string fileName)
        {
            List<StudyLog> tempStudyLogs = new List<StudyLog>();
            var orderedLogs = from logs in excelStudyLog
                              orderby logs.EndDate descending
                              select logs;
            tempStudyLogs = orderedLogs.ToList();
            var jsonData = JsonConvert.SerializeObject(tempStudyLogs);

            File.WriteAllText(fileName, jsonData);
        }
    }
}
