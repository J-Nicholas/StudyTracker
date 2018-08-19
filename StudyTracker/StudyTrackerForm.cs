using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace StudyTracker
{
    public partial class StudyTrackerForm : BaseForm
    {
        private static StudyTrackerForm studyTracker;   // reference to this form that can be accessed by property 

        public StudyTrackerForm()
        {
            InitializeComponent();
            studyTracker = this;                        // lining current form to reference 
            CenterWindow();
        }

        public static StudyTrackerForm StudyTracker
        {
            // singleton that only allows one instance of this form
            get
            {
                if (studyTracker == null)
                {
                    studyTracker = new StudyTrackerForm();
                }
                return studyTracker;
            }
        }
        private void CenterWindow ()
        {
            Rectangle screen = GetScreenSize();
            int screenHeight = screen.Height;
            int screenWidth = screen.Width;

            // Sets location to the centre of the screen, - size.width/2 is needed
            //because window location is based on top left corner and this corrects it.
            Location = new Point((screenWidth / 2) - (Size.Width / 2), (screenHeight / 2) - (Size.Height / 2));
        }
        private Rectangle GetScreenSize()
        {
            return Screen.GetWorkingArea(this);
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            SessionSetupForm.SessionSetup.Show();
            SessionSetupForm.SessionSetup.Location = StudyTracker.Location;
            SessionSetupForm.SessionSetup.Focus();
            StudyTracker.Hide();
        }
    }
}
