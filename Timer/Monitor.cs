using System;
using System.Windows.Forms;

#region References



#endregion

namespace Timer
{
    public partial class Monitor : Form
    {

        #region Class Declarations

        private FGHook _objfgHook = null;
        private DataStore _objDataStore = null;
        private string _strStatus = string.Empty;

        private class Status
        {
            public const string Running = "Running!";
            public const string Stopped = "Stopped!";
        }

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
                SetAllowedActions(_strStatus);
            }
        }

        #endregion

        #region Constructor and Initialization

        public Monitor()
        {
            try
            {
                InitializeComponent();
                notifyIcon.ContextMenuStrip = cmMenu;
                _objDataStore = DataStore.GetInstance();
                _objfgHook = new FGHook(_objDataStore);
                _objDataStore.PropertyChanged += _objDataStore_PropertyChanged;
                AppStatus = Status.Running;
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        #endregion

        #region UI Screen Event Handlers

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartMonitoring();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopMonitoring();
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

        #endregion

        #region Update UI Data

        private void _objDataStore_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            tbxLog.Text = string.Join(Environment.NewLine, _objDataStore.Data);
        }

        private void SetAllowedActions(string pstrStatus)
        {
            bool bStatus = pstrStatus == Status.Running;

            btnStart.Enabled = !bStatus;
            startToolStripMenuItem.Enabled = !bStatus;
            btnStop.Enabled = bStatus;
            stopToolStripMenuItem.Enabled = bStatus;
        }

        #endregion

        #region Helpers

        private void StartMonitoring()
        {
            try
            {
                if (AppStatus != Status.Running)
                {
                    AppStatus = Status.Running;
                    _objfgHook = new FGHook(_objDataStore);
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
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

        private void HandleException(Exception ex)
        {
            if (_objfgHook != null)
            {
                _objfgHook.Dispose();
            }
            MessageBox.Show(ex.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion

        #region System tray context menu event handlers

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

        #endregion
        
    }
}

