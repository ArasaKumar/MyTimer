using System;
using System.Windows.Forms;

#region References

/*
 * https://www.bleepingcomputer.com/tutorials/windows-program-automatic-startup-locations/
 * https://stackoverflow.com/questions/995195/how-can-i-make-a-net-windows-forms-application-that-only-runs-in-the-system-tra
 * https://stackoverflow.com/questions/97283/how-can-i-determine-the-name-of-the-currently-focused-process-in-c-sharp
*/

#endregion

namespace Timer
{
    public partial class Monitor : Form
    {
        private FGHook _objfgHook = null;
        private string _strStatus = string.Empty;

        private string AppStatus
        {
            get
            {
                return _strStatus;
            }
            set
            {
                _strStatus = value;
                lblMessage.Text = _strStatus;
            }
        }

        private class Status
        {
            public const string Running = "Running!";
            public const string Stopped = "Stopped!";
        }

        public Monitor()
        {
            try
            {
                InitializeComponent();
                notifyIcon.ContextMenuStrip = cmMenu;
                AppStatus = Status.Stopped;
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        public void RecordData()
        {
            _objfgHook = new FGHook();
            while (true)
            {
                System.Threading.Thread.Sleep(new TimeSpan(0, 0, 1));
                tbxLog.Text = string.Join(Environment.NewLine, FGHook.APPList);
                Application.DoEvents();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartMonitoring();
        }

        private void StartMonitoring()
        {
            try
            {
                if (AppStatus != Status.Running)
                {
                    AppStatus = Status.Running;
                    RecordData();
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopMonitoring();
        }

        private void StopMonitoring()
        {
            if (AppStatus != Status.Stopped)
            {
                AppStatus = Status.Stopped;
                if (_objfgHook != null)
                {
                    _objfgHook.Dispose();
                }
            }
        }

        private void HandleException(Exception ex)
        {
            if (_objfgHook != null)
            {
                _objfgHook.Dispose();
            }
            MessageBox.Show(ex.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            Hide();
            notifyIcon.Visible = true;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            QuitApp();
        }

        private void maximizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Show();
                this.WindowState = FormWindowState.Normal;
                notifyIcon.Visible = false;
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void QuitApp()
        {
            try
            {
                if (_objfgHook != null)
                {
                    _objfgHook.Dispose();
                }
                this.Close();
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuitApp();
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopMonitoring();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartMonitoring();
        }

        private void showStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon.ShowBalloonTip(10, "Status", AppStatus, ToolTipIcon.Info);
        }
    }
}

