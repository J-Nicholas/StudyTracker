using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace StudyTracker
{
    public partial class OptionsMenu : Form
    {
        private Settings settings;

        public OptionsMenu()
        {
            InitializeComponent();
        }

        public Settings Settings
        {
            get
            {
                if (settings == null)
                {
                    settings = new Settings();
                }
                return settings;
            }
        }

        public void readSettingsFile()
        {
            if (File.Exists(StudyDir.settingsDir))
            {
                try
                {
                    var jsonData = File.ReadAllText(StudyDir.settingsDir);
                    settings = JsonConvert.DeserializeObject<Settings>(jsonData);

                }
                catch (Exception e)
                {
                    MessageBox.Show("Error:" + e.Message + '\n' + e.StackTrace);
                }
            }
            else
            {
                settings = new Settings();
            }
        }

        private void enableFloatButton_Click(object sender, EventArgs e)
        {
            // Toggles enabled/disabled buttons
            disableFloatButton.Enabled = !disableFloatButton.Enabled;
            enableFloatButton.Enabled = !enableFloatButton.Enabled;

            
            if (disableFloatButton.Enabled) // setting enabled
            {
                settings.showFloatingWindow = true;
            }
            else
            {
                settings.showFloatingWindow = false;
            }
        }

        private void saveOptionsButton_Click(object sender, EventArgs e)
        {
            var jsonData = JsonConvert.SerializeObject(settings);
            File.WriteAllText(StudyDir.settingsDir, jsonData);
        }

        private void OptionsMenu_Load(object sender, EventArgs e)
        {
            if (settings != null)
            {
                if (settings.showFloatingWindow)
                {
                    enableFloatButton.Enabled = false;
                    disableFloatButton.Enabled = true;
                }
            }
        }
    }
}
