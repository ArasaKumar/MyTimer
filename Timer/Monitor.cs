using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;
using Timer.Interfaces;

#region References



#endregion

namespace Timer
{
    public partial class Monitor : MaterialForm
    {

        #region Class Declarations

        private FGHook _objfgHook = null;

        private readonly MaterialSkinManager _materialSkinManager;
        private readonly ColorScheme _csLight;
        private readonly ColorScheme _csDark;

        private IExceptionHandler _exceptionHandler;
        private ISaveData _saveData;
        private IDataStore _dataStore = null;

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
                mlblMessage.Text = _strStatus;
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

                Factory objFactory = new Factory();
                _exceptionHandler = objFactory.GetExceptionHandler();
                _saveData = objFactory.GetSaveData();
                _dataStore = objFactory.GetDataStore();

                _materialSkinManager = MaterialSkinManager.Instance;
                _materialSkinManager.AddFormToManage(this);
                _materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                _csLight = _materialSkinManager.ColorScheme;
                _csDark = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

                notifyIcon.ContextMenuStrip = cmMenu;
                _objfgHook = new FGHook(_dataStore);
                _dataStore.PropertyChanged += _objDataStore_PropertyChanged;


                AppStatus = Constants.Running;
            }
            catch (Exception ex)
            {
                DisposeHook();
                _exceptionHandler.HandleException(ex);
            }
        }

        private void bswtTheme_CheckedChanged(object sender, EventArgs e)
        {
            _materialSkinManager.Theme = bswtTheme.Checked ? MaterialSkinManager.Themes.DARK : MaterialSkinManager.Themes.LIGHT;
            _materialSkinManager.ColorScheme = bswtTheme.Checked ? _csDark : _csLight;
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

        private void Monitor_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisposeHook();
        }

        private void Monitor_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon.Visible = true;
            }
        }

        private void mbtnClear_Click(object sender, EventArgs e)
        {
            _dataStore.Reset();
        }

        private void mbtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                _saveData.SaveData(DateTime.Now, _dataStore.Data, _exceptionHandler);
            }
            catch (Exception ex)
            {
                _exceptionHandler.HandleException(ex);
            }
        }

        #endregion

        #region Update UI Data

        private void _objDataStore_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            mmtbxData.Lines = _dataStore.Data;
        }

        private void SetAllowedActions(string pstrStatus)
        {
            bool bStatus = pstrStatus == Constants.Running;

            mbtnStart.Enabled = !bStatus;
            startToolStripMenuItem.Enabled = !bStatus;
            mbtnStop.Enabled = bStatus;
            stopToolStripMenuItem.Enabled = bStatus;
        }

        #endregion

        #region Helpers

        private void StartMonitoring()
        {
            try
            {
                if (AppStatus != Constants.Running)
                {
                    AppStatus = Constants.Running;
                    _objfgHook = new FGHook(_dataStore);
                }
            }
            catch (Exception ex)
            {
                DisposeHook();
                _exceptionHandler.HandleException(ex);
            }
        }

        private void StopMonitoring()
        {
            if (AppStatus != Constants.Stopped)
            {
                AppStatus = Constants.Stopped;
                DisposeHook();
            }
        }

        private void QuitApp()
        {
            try
            {
                DisposeHook();
                this.Close();
            }
            catch (Exception ex)
            {
                DisposeHook();
                _exceptionHandler.HandleException(ex);
            }
        }

        private void DisposeHook()
        {
            if (_objfgHook != null)
            {
                _objfgHook.Dispose();
                _objfgHook = null;
            }
            AppStatus = Constants.Stopped;
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
                DisposeHook();
                _exceptionHandler.HandleException(ex);
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

