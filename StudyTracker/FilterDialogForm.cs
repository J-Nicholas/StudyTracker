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

namespace StudyTracker
{
    public partial class FilterDialogForm : Form
    {
        private static Form filterDialog;
        private static CheckBox topicCheckBox;
        private static CheckBox dateCheckBox;
        private static CheckBox timeFrameCheckBox;
        private static Button applyButton;

        public FilterDialogForm()
        {
            InitializeComponent();
            filterDialog = this;
            FilterDialogBindingRef = LogsDB.StudyLogsDBRef;
            this.Controls.Add(FilterGroup);

            // references to checkboxes for apply button reference
            topicCheckBox = TopicFilterCheckBox;
            dateCheckBox = DateFilterCheckBox;
            timeFrameCheckBox = TimeFrameFilterCheckBox;
            applyButton = ApplyFilterButton;

            // setting up dialog results
            OkayFilterDialogButton.DialogResult = DialogResult.OK;

        }
        public static Form FilterDialog
        {
            get
            {
                if (filterDialog == null)
                {
                    filterDialog = new FilterDialogForm();
                }
                return filterDialog;
            }
        }
        public static List<StudyLog> FilterDialogBindingRef { get; set; }


        private void FilterCheckBoxes_CheckedChanged(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            if (control is CheckBox checkBox)
            {
                if (checkBox == TopicFilterCheckBox)
                {
                    TopicFilterComboBox.Enabled = !TopicFilterComboBox.Enabled;
                    TopicFilterComboBox.SelectedIndex = 0;
                }
                else if (checkBox == TimeFrameFilterCheckBox)       // TimeFrame and Date Filters are Exclusive OR
                {
                    TimeFrameComboBox.Enabled = !TimeFrameComboBox.Enabled;
                    TimeFrameComboBox.SelectedIndex = 0;

                    if (DateFilterCheckBox.Checked == true)
                    {
                        //disabling Date Picker 
                        DateFilterCheckBox.Checked = false;
                        DatePickerFilter.ResetText();
                        DatePickerFilter.Enabled = false;
                    }
                }
                else if (checkBox == DateFilterCheckBox)            // TimeFrame and Date Filters are Exclusive OR
                {
                    DatePickerFilter.Enabled = !DatePickerFilter.Enabled;
                    if (TimeFrameFilterCheckBox.Checked == true)
                    {
                        TimeFrameFilterCheckBox.Checked = false;
                        TimeFrameComboBox.ResetText();
                        TimeFrameComboBox.Enabled = false;
                    }
                }

                // Check if Apply button should be enabled
                ValidateApplyButton();
            }
        }
        private static void ValidateApplyButton()
        {
            if (topicCheckBox.Checked == false && dateCheckBox.Checked == false && timeFrameCheckBox.Checked == false)
            {
                applyButton.Enabled = false;
            }
            else
            {
                applyButton.Enabled = true;
            }
        }

        public static void ClearFilter(Form filterForm)
        {

            foreach (Control control in filterForm.Controls)        // first level for group box
            {
                if (control is GroupBox group)
                {
                    foreach (Control item in group.Controls)          //second for buttons and controls
                    {
                        if (item is CheckBox checkBox)
                        {
                            checkBox.Checked = false;
                        }
                        else if (item is ComboBox combo)
                        {
                            combo.ResetText();
                            combo.Enabled = false;
                        }
                        else if (item is DateTimePicker picker)
                        {
                            picker.ResetText();
                            picker.Enabled = false;
                        }
                    }
                }
            }
            BindingListView<StudyLog> filteredList = new BindingListView<StudyLog>(FilterDialogBindingRef);

            LogsDB.dataGridViewRef.DataSource = filteredList;
            LogsDB.dataGridViewRef.Sort(LogsDB.dataGridViewRef.Columns["logsEndDate"], ListSortDirection.Descending);
            ValidateApplyButton();
            LogsDB.IsFiltered = false;
        }

        private void ClearFilterButton_Click(object sender, EventArgs e)
        {
            ClearFilter(this);
        }

        private void PopulateTopicComboBoxItems()
        {
            // This function gets Topics from studylog database and puts them into combobox item collection
            List<String> topics = new List<string>();


            foreach (StudyLog log in FilterDialogBindingRef)            // get topics from database
            {
                topics.Add(log.Topic);
            }

            var uniqueTopics = new HashSet<string>(topics);             // filter out duplicates with hash set


            foreach (var item in uniqueTopics)
            {
                TopicFilterComboBox.Items.Add(item);
            }
        }

        private void FilterDialogForm_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                if (TopicFilterCheckBox.Checked == false)
                {
                    TopicFilterComboBox.Items.Clear();
                    PopulateTopicComboBoxItems();
                    TopicFilterComboBox.SelectedIndex = 0;
                }
                else
                {

                }
                ValidateApplyButton();
            }
        }

        private void ApplyFilter()
        {

            IEnumerable<StudyLog> topicQuery = null;
            IEnumerable<StudyLog> dateQuery = null;
            IEnumerable<StudyLog> timeFrameQuery = null;

            // gather queries independtly 
            if (TopicFilterCheckBox.Checked == true)
            {
                topicQuery = from logs in FilterDialogBindingRef
                             where logs.Topic == TopicFilterComboBox.SelectedItem.ToString()
                             select logs;
            }
            if (DateFilterCheckBox.Checked == true)
            {
                dateQuery = from logs in FilterDialogBindingRef
                            where logs.EndDate.Date == DatePickerFilter.Value.Date || logs.StartDate.Date == DatePickerFilter.Value.Date
                            select logs;
            }
            else if (TimeFrameFilterCheckBox.Checked == true)
            {
                if (TimeFrameComboBox.SelectedItem.ToString() == "Today")
                {
                    timeFrameQuery = from logs in FilterDialogBindingRef
                                     where logs.EndDate.Date == DateTime.Now.Date || logs.StartDate.Date == DateTime.Now.Date
                                     select logs;
                }
                else if (TimeFrameComboBox.SelectedItem.ToString() == "Last 7 days")
                {
                    timeFrameQuery = from logs in FilterDialogBindingRef
                                     where logs.EndDate.Date <= DateTime.Now.Date && logs.EndDate.Date >= DateTime.Now.Date.AddDays(-7)
                                     select logs;
                }
                else if (TimeFrameComboBox.SelectedItem.ToString() == "Last 30 days")
                {
                    timeFrameQuery = from logs in FilterDialogBindingRef
                                     where logs.EndDate.Date <= DateTime.Now.Date && logs.EndDate.Date >= DateTime.Now.Date.AddDays(-30)
                                     select logs;
                }
                else if (TimeFrameComboBox.SelectedItem.ToString() == "last 12 months")
                {
                    timeFrameQuery = from logs in FilterDialogBindingRef
                                     where logs.EndDate.Date <= DateTime.Now.Date && logs.EndDate.Date >= DateTime.Now.Date.AddDays(-365)
                                     select logs;
                }
            }


            // Intersect all queries
            IEnumerable<StudyLog> combinedQuery = null;
            if (topicQuery != null)
            {
                if (timeFrameQuery != null)
                {
                    combinedQuery = topicQuery.Intersect(timeFrameQuery);
                }
                else if (dateQuery != null)
                {
                    combinedQuery = topicQuery.Intersect(dateQuery);
                }
                else combinedQuery = topicQuery;
            }
            else            // topic not being filtered but one of the other two might 
            {

                if (timeFrameQuery != null)
                {
                    // Can't be datepicker because the two are exclusive OR
                    combinedQuery = timeFrameQuery;
                }
                else
                {
                    // it's just datePicker that might be checked
                    if (dateQuery != null)
                    {
                        combinedQuery = dateQuery;
                    }
                }
            }

            var filtered = combinedQuery.ToList();

            BindingListView<StudyLog> filteredList = new BindingListView<StudyLog>(filtered);

            LogsDB.dataGridViewRef.DataSource = filteredList;
            LogsDB.IsFiltered = true;
        }

        private void ApplyFilterButton_Click(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void TopicFilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TopicFilterComboBox.SelectedItem.ToString().Length > 20)
            {
                FilterDialog.Width = FilterDialog.MaximumSize.Width;
            }
            else
                FilterDialog.Width = FilterDialog.MinimumSize.Width;
        }

        private void FilterDialogForm_Load(object sender, EventArgs e)
        {
            TimeFrameComboBox.SelectedIndex = 0;
        }

        private void OkayFilterDialogButton_Click(object sender, EventArgs e)
        {
            if (applyButton.Enabled == true)
            {
                ApplyFilter();
            }
        }
    }
}
