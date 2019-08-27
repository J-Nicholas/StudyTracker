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
    public partial class FloatWindow : Form
    {
        private bool paused = false;

        public FloatWindow()
        {
            InitializeComponent();
        }

        private const int WS_EX_NOACTIVATE = 0x08000000;
        /// <summary>
        /// This is required for this window so that when the user clicks on app icon on taskbar
        /// the floating window does not get focus. This stops the main window from closing because 
        /// another Activate event is fired. Which must be because Float window is contained inside main
        /// window.
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                createParams.ExStyle |= WS_EX_NOACTIVATE;
                return createParams;
            }
        }

        private void FloatWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = false;
            }
        }

        private void pauseButtonFloat_Click(object sender, EventArgs e)
        {
            toggleButtonText();
            OnFloatPaused();
        }

        private void toggleButtonText()
        {
            paused = !paused;
            if (paused)
                pauseButtonFloat.Text = "RESUME";
            else
                pauseButtonFloat.Text = "PAUSE";
        }

        public void MainTrackerPaused(object sender, EventArgs e)
        {
            toggleButtonText();
        }

        public void ResetButton(object sender, EventArgs e)
        {
            pauseButtonFloat.Text = "PAUSE";
            paused = false;
        }

        public event EventHandler FloatPaused;

        protected virtual void OnFloatPaused()
        {
            FloatPaused?.Invoke(this, EventArgs.Empty);
        }
    }
}
