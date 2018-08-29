using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Equin.ApplicationFramework;
using Newtonsoft.Json;
using System.IO;

namespace StudyTracker
{
    public partial class LogsDB : Form
    {
        private static Form logsDBRef;
        private static List<StudyLog> studyLogsDBref = null;
        private BindingListView<StudyLog> studyLogListView;
        public static DataGridView dataGridViewRef;
        public static List<StudyLog> rowsToDelete = new List<StudyLog>();
        private static bool promptToSave = false;
        public static bool IsFiltered = false;

        public LogsDB()
        {
            InitializeComponent();
            logsDBRef = this;
            dataGridViewRef = LogsDBView;



            LogsDBView.Font = new Font("lucidia Bright", 10, FontStyle.Regular);
            DataGridTableStyle tableStyle = new DataGridTableStyle();
            tableStyle.HeaderBackColor = Color.DarkSlateGray;
            DoubleBuffered = true;
            logsDBRef.WindowState = FormWindowState.Maximized;

        }
        public static Form LogsDBRef
        {
            get
            {
                if (logsDBRef == null)
                    logsDBRef = new LogsDB();
                return logsDBRef;
            }
        }
        public static List<StudyLog> StudyLogsDBRef
        {
            get
            {
                if (studyLogsDBref == null)
                    studyLogsDBref = new List<StudyLog>();
                return studyLogsDBref;
            }
            set
            {
                studyLogsDBref = value;
            }
        }

        private void LogsDB_Load(object sender, EventArgs e)
        {
            // set data source to study logs ref 
            studyLogListView = new BindingListView<StudyLog>(studyLogsDBref);
            LogsDBView.DataSource = studyLogListView;


            // Default sort is descending upon loading form
            LogsDBView.Sort(LogsDBView.Columns["logsEndDate"], ListSortDirection.Descending);

            //Formatting for each column
            LogsDBView.Columns["logsStartTime"].DefaultCellStyle.Format = "t";          // short time format
            LogsDBView.Columns["logsEndtime"].DefaultCellStyle.Format = "t";            // short time Format
            LogsDBView.Columns["logsStartDate"].DefaultCellStyle.Format = "d";          // short date format
            LogsDBView.Columns["logsEndDate"].DefaultCellStyle.Format = "d";            // short date format
            LogsDBView.Columns["logsTimeStudied"].DefaultCellStyle.Format = "t";        // short time format

            // Databse Colours
            LogsDBView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(244, 242, 240);       // Cream colour
            LogsDBView.EnableHeadersVisualStyles = false;
            LogsDBView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 60, 75);            // Navy blue
            LogsDBView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            LogsDBView.ColumnHeadersDefaultCellStyle.Font = new Font("Lucidia Bright", 11, FontStyle.Regular);

            // Wrap Mode
            LogsDBView.Columns["logsDescription"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            LogsDBView.Columns["logsTopic"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Alignment
            for (int i = 2; i < LogsDBView.Columns.Count; i++)
            {
                LogsDBView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            LogsDBView.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            LogsDBView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // AutoSize mode
            for (int i = 0; i < LogsDBView.Columns.Count; i++)
            {
                LogsDBView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            }
            LogsDBView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // column fill weights 
            LogsDBView.Columns["logsDescription"].FillWeight = 40;
            LogsDBView.Columns["logsTopic"].FillWeight = 8;
            LogsDBView.Columns["logsStartTime"].FillWeight = 3;
            LogsDBView.Columns["logsEndTime"].FillWeight = 3;
            LogsDBView.Columns["logsStartDate"].FillWeight = 6;
            LogsDBView.Columns["logsEndDate"].FillWeight = 6;
            LogsDBView.Columns["logsTimeStudied"].FillWeight = 6;

            // minimum window size
            logsDBRef.MinimumSize = new Size(1150, 400);
        }

        private void LogsDB_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (promptToSave == false)
            {
                e.Cancel = false;
                return;
            }
            else
            {
                DialogResult result = MessageBox.Show("Do you want to save changes before closing?", "Notice", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    SaveToFile();
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                else
                {

                    e.Cancel = false;
                }
            }
        }

        private void LogsDB_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                promptToSave = false;
                //update bindinglist
                FilterDialogForm.FilterDialogBindingRef = studyLogsDBref;           //FilterdialogBindingRef is out date, need to update
                studyLogListView = new BindingListView<StudyLog>(StudyLogsDBRef);
                dataGridViewRef.DataSource = studyLogListView;
                LogsDBView.Sort(LogsDBView.Columns["logsEndDate"], ListSortDirection.Descending);
                LogsDBView.Refresh();
                FilterDialogForm.ClearFilter(FilterDialogForm.FilterDialog);

            }
        }

        private void LogsDBView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            DataGridView dataBase = (DataGridView)sender;
            string stringToTest = e.FormattedValue.ToString();
            // Validating for string.empty for all columns except description
            if (e.ColumnIndex != 1)         // if not description column
            {
                if (stringToTest.Trim(' ') == string.Empty)
                {
                    MessageBox.Show($"{dataBase.Columns[e.ColumnIndex].HeaderText} cannot be empty!");
                    e.Cancel = true;
                    return;
                }
            }

            // Validating specific columns
            if (e.ColumnIndex == 2 || e.ColumnIndex == 3 || e.ColumnIndex == 6) // Start Time, End Time or Time studied
            {
                if (!TimeSpan.TryParse(stringToTest, out TimeSpan time))
                {
                    MessageBox.Show($"{dataBase.Columns[e.ColumnIndex].HeaderText} does not contain a valid time!");
                    e.Cancel = true;
                    return;
                }
            }
            else if (e.ColumnIndex == 4 || e.ColumnIndex == 5)                  // Date started or Date ended
            {
                if (!DateTime.TryParse(stringToTest, out DateTime date))
                {
                    MessageBox.Show($"{dataBase.Columns[e.ColumnIndex].HeaderText} does not contain a valid date!");
                    e.Cancel = true;
                    return;
                }
                else if (!DateTime.TryParseExact(stringToTest, "d", null, System.Globalization.DateTimeStyles.None, out date))
                {
                    MessageBox.Show($"{dataBase.Columns[e.ColumnIndex].HeaderText} is not formatted correctly. Use the date format dd/mm/yyyy");
                    e.Cancel = true;
                    return;
                }
            }
        }

        private void LogsDBView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {

        }

        private void LogsDBView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            //If a filter is applied, display a message telling the user that deletion is diabled while a filter is applied
            if (IsFiltered)
            {
                StudyLog logToDelete = (StudyLog)(ObjectView<StudyLog>)e.Row.DataBoundItem;
                rowsToDelete.Add(logToDelete);
            }

            DialogResult deletePrompt;
            deletePrompt = MessageBox.Show($"Are you sure you want to delete this row?",
                "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (deletePrompt == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else e.Cancel = true;

        }

        private void LogsDBView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            DataGridView dataBase = (DataGridView)sender;
            promptToSave = true;

            // Delete all entries in studylog that were deleted while a filter was applied
            if (IsFiltered)
            {
                foreach (var item in rowsToDelete)
                {
                    studyLogsDBref.Remove(item);
                }
            }
        }

        private void closeDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveToFileToolStrip_Click(object sender, EventArgs e)
        {
            SaveToFile();
        }
        private void SaveToFile()
        {
            List<StudyLog> tempStudyLog = (List<StudyLog>)studyLogListView.DataSource;
            StudyTrackerForm.logList = tempStudyLog;

            //order loglist
            var orderedList = from logs in StudyTrackerForm.logList
                              orderby logs.EndDate descending
                              select logs;

            StudyTrackerForm.logList = orderedList.ToList();

            // serialize and write to file
            var JsonData = JsonConvert.SerializeObject(StudyTrackerForm.logList);
            File.WriteAllText(StudyDir.logsDir, JsonData);

        }

        private void LogsDBView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            promptToSave = true;            //User has made an edit, ask to save before closing the database. If this is false, close without prompt
        }

        private void NewEntryMenuButton_Click(object sender, EventArgs e)
        {
            AddNewLog.AddNewLogRef.StartPosition = FormStartPosition.CenterScreen;
            DialogResult result = AddNewLog.AddNewLogRef.ShowDialog();
            if (result == DialogResult.OK)
            {
                StudyTrackerForm.logList.Add(StudyTrackerForm.newLogFromAddForm);

                studyLogListView = new BindingListView<StudyLog>(studyLogsDBref);
                LogsDBView.DataSource = studyLogListView;
                LogsDBView.Refresh();

                promptToSave = true;
                FilterDialogForm.ClearFilter(FilterDialogForm.FilterDialog);
                LogsDBView.Sort(LogsDBView.Columns["logsEndDate"], ListSortDirection.Descending);
            }
            else
            {
                // do nothing 
            }

        }

        private void FilterDialogStrip_Click(object sender, EventArgs e)
        {
            DialogResult result;
            FilterDialogForm.FilterDialog.StartPosition = FormStartPosition.CenterScreen;
            FilterDialogForm.FilterDialogBindingRef = studyLogsDBref;
            result = FilterDialogForm.FilterDialog.ShowDialog();


        }

        private void DeleteRowsStrip_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in LogsDBView.SelectedRows)
            {
                LogsDBView.Rows.Remove(row);
            }
        }
    }
}
