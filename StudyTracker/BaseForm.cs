using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Diagnostics;

namespace StudyTracker
{
    public partial class BaseForm : Form
    {
        // consts for creating params for form. Allows form to be restored from taskbar
        const int WS_MINIMIZEBOX = 0x20000;
        const int CS_DBLCLKS = 0x8;

        // Needed for dragging form becuase it is borderless
        private bool IsDragging = false;
        private Point lastLocation;

        private static BaseForm baseFormRef;
        private static Label startLabelBaseRef;
        private static PictureBox startImageRef;
        private static bool IsFirstCloseFormCheck = true;

        public BaseForm()
        {
            InitializeComponent();
            baseFormRef = this;
            this.DoubleBuffered = true;

            SideBar_BookImage.Parent = SidebarImage;
            Sidebar_TitleImage.Parent = SidebarImage;
            linkToMyLinkdin.Parent = SidebarImage;

            logsLabel.Parent = SidebarImage;
            AboutLabel.Parent = SidebarImage;
            ExitLabel.Parent = SidebarImage;

            CloseButtonImage.Parent = DragWindow;                                                               // location is now relatvie to dragwindow. so 
            CloseButtonImage.Location = new Point(DragWindow.Width - (CloseButtonImage.Width + 7), 3);          // button should be image.width number of pixels from 
            MinimiseButtonImage.Parent = DragWindow;                                                            // right + 7 for space and 3 from top
            MinimiseButtonImage.Location = new Point(CloseButtonImage.Location.X - MinimiseButtonImage.Width, CloseButtonImage.Location.Y);

            AlignMenuBars(StartImage, SidebarImage);
            AlignMenuBars(startLabel, StartImage);
            AlignMenuBars(LogsImage, SidebarImage);
            AlignMenuBars(logsLabel, LogsImage);
            AlignMenuBars(AboutImage, SidebarImage);
            AlignMenuBars(AboutLabel, AboutImage);
            AlignMenuBars(ExitImage, SidebarImage);
            AlignMenuBars(ExitLabel, ExitImage);

            startLabelBaseRef = startLabel;
            startImageRef = StartImage;
        }

        public static Label StartLabelBaseRef
        {
            get
            {
                if (startLabelBaseRef == null)
                {
                    startLabelBaseRef = new Label();
                }
                return startLabelBaseRef;
            }
        }
        public static PictureBox StartImageRef
        {
            get
            {
                if (startImageRef == null)
                {
                    startImageRef = new PictureBox();
                }
                return startImageRef;
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= WS_MINIMIZEBOX;
                cp.ClassStyle |= CS_DBLCLKS;
                //cp.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED
                return cp;
            }
        }

        private void AlignMenuBars<T>(T control, PictureBox parent) where T : Control
        {
            if (control is Label)
            {
                control.Parent = parent;
                control.Location = new Point((parent.Width - control.Width) / 2, (parent.Height - control.Height) / 2);
            }
            else
            {
                control.Parent = parent;
                control.Location = new Point((parent.Width - control.Width) / 2, control.Location.Y);
            }
        }

        public static BaseForm BaseFormRef
        {
            get
            {
                if (baseFormRef == null)
                {
                    baseFormRef = new BaseForm();
                }
                return BaseFormRef;
            }
        }

        private static Rectangle GetScreenSize()
        {
            return Screen.PrimaryScreen.Bounds;
        }

        private void BaseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void linkToMyLinkdin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.linkedin.com/in/johnathan-nicholas-201477161/");
        }

        private void CloseButtonImage_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartImage_MouseEnter(object sender, EventArgs e)
        {
            Control control = (Control)sender;                                  // Parsing sender object into a control object so we can get information about the control

            //deals with mouseenter on exit label and exit image
            if (control.Name == ExitLabel.Name || control.Name == ExitImage.Name)
            {
                if (control.Name == ExitLabel.Name)
                {
                    control.Parent.BackgroundImage = Properties.Resources.ExitButtonSelected;
                }
                else
                    control.BackgroundImage = Properties.Resources.ExitButtonSelected;
                return;
            }
            // otherwise its one of the menu images
            if (control is PictureBox)
            {
                control.BackgroundImage = Properties.Resources.ButtonSelected;
            }
            else                    // it's a label, and its parent is one of the menu images
                control.Parent.BackgroundImage = Properties.Resources.ButtonSelected;
        }

        private void StartImage_MouseLeave(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            if (control is PictureBox)
            {
                control.BackgroundImage = null;
            }
            else if (control is Label)
            {
                control.Parent.BackgroundImage = null;
            }
        }

        private void AboutImage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This application will track the time you spend studying and will log your studying sessions" +
                " Click Start to begin a session now! Or add a session manually by click the green plus symbol!" +
                " You can view your recent study session here or you can view them all by clicking All logs on the sidebar.\n ", "About",
                MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void MinimiseButtonImage_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;                     // This allows the minimise animation to play 
            this.WindowState = FormWindowState.Minimized;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void DragWindow_MouseDown(object sender, MouseEventArgs e)
        {
            IsDragging = true;
            lastLocation = e.Location;
        }

        private void DragWindow_MouseMove(object sender, MouseEventArgs e)
        {
            Point Offset = new Point(DragWindow.Location.X - this.Location.X, DragWindow.Location.Y - this.Location.Y);

            if (IsDragging)
            {
                this.Location = new Point(
                (this.Location.X - lastLocation.X) + (e.Location.X), (this.Location.Y - lastLocation.Y) + (e.Location.Y));

                this.Update();

            }
        }

        private void DragWindow_MouseUp(object sender, MouseEventArgs e)
        {
            IsDragging = false;
        }

        private void StartImage_Click(object sender, EventArgs e)
        {

            if (ActiveForm == SessionManagerForm.SessionManagerRef)
            {
                // Label says Home, allow user to return to main menu, ask them if they are sure, their work wont' be saved until they click finsih button
                DialogResult result = MessageBox.Show("Are you sure you want to return to Home?\nYour study session wont't be logged unless you click finish.",
                        "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    StudyTrackerForm.StudyTracker.Show();
                    SessionManagerForm.SessionManagerRef.Hide();
                    StudyTrackerForm.StudyTracker.Location = SessionManagerForm.SessionManagerRef.Location;
                    StudyTrackerForm.StudyTracker.Focus();
                }
            }
            else if (ActiveForm == StudyTrackerForm.StudyTracker)
            {
                SessionSetupForm.SessionSetup.Show();
                StudyTrackerForm.StudyTracker.Hide();
                SessionSetupForm.SessionSetup.Location = this.Location;
                SessionSetupForm.SessionSetup.Focus();
                SessionSetupForm.SidebarLabelRef.Text = "Return";
                SessionSetupForm.SidebarLabelRef.Location =                             //Centre the label text
                    new Point((StartImage.Width - SessionSetupForm.SidebarLabelRef.Width) / 2, SessionSetupForm.SidebarLabelRef.Location.Y);
            }
            else if (ActiveForm == SessionSetupForm.SessionSetup)
            {
                StudyTrackerForm.StudyTracker.Show();
                SessionSetupForm.SessionSetup.Hide();
                StudyTrackerForm.StudyTracker.Location = SessionSetupForm.SessionSetup.Location;
                StudyTrackerForm.StudyTracker.Focus();
                StudyTrackerForm.StartButtonLabel.Text = "Start";
            }
        }

        private void MinimiseButtonImage_MouseEnter(object sender, EventArgs e)
        {
            MinimiseButtonImage.BackgroundImage = Properties.Resources.Min_hover;
        }

        private void MinimiseButtonImage_MouseLeave(object sender, EventArgs e)
        {
            MinimiseButtonImage.BackgroundImage = Properties.Resources.Minimise_Icon;
        }

        private void CloseButtonImage_MouseEnter(object sender, EventArgs e)
        {
            CloseButtonImage.BackgroundImage = Properties.Resources.Close_hover;
        }

        private void CloseButtonImage_MouseLeave(object sender, EventArgs e)
        {
            CloseButtonImage.BackgroundImage = Properties.Resources.Close_Icon;
        }

        private void BaseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result;
            if (IsFirstCloseFormCheck)
            {
                if (ActiveForm == SessionManagerForm.SessionManagerRef)
                {
                    result = MessageBox.Show("Are you sure you want to exit?\nYour study session wont't be logged unless you click finish.",
                        "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                    {
                        e.Cancel = true;
                        return;
                    }
                }
                else
                {
                    result = MessageBox.Show($"Are you sure you want to exit?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                    {
                        e.Cancel = true;
                        return;
                    }
                }
                IsFirstCloseFormCheck = false;
            }
        }

        private void LogsImage_Click(object sender, EventArgs e)
        {
            if (StudyTrackerForm.logList.Count == 0)
            {
                MessageBox.Show("There are no logs to display. Click the green plus icon to add a study session manually or press \"Start\" to start an automatic session.",
                    "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                LogsDB.StudyLogsDBRef = StudyTrackerForm.logList;
                LogsDB.LogsDBRef.StartPosition = FormStartPosition.CenterScreen;
                LogsDB.LogsDBRef.ShowDialog();
                if (ActiveForm == StudyTrackerForm.StudyTracker)
                {
                    StudyTrackerForm.StudyTracker.ClearPanels();
                    StudyTrackerForm.StudyTracker.GenerateRecentLogs();

                }

            }
        }
    }
}
