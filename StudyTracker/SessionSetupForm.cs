using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyTracker
{
    public partial class SessionSetupForm : BaseForm
    {
        private static SessionSetupForm sessionSetup = null;

        public SessionSetupForm()
        {
            InitializeComponent();
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

        private void SessionSetupForm_Load(object sender, EventArgs e)
        {
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
    }
}
