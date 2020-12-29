using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
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
        public Monitor()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RecordData()
        {
            Application.DoEvents();
            using (FGHook obj = new FGHook())
            {
                while (true)
                {
                    System.Threading.Thread.Sleep(new TimeSpan(0, 0, 1));
                    tbxLog.Text = string.Join(Environment.NewLine, FGHook.APPList);
                    Application.DoEvents();
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            RecordData();
        }
    }

    #region Gater Data

    class FGHook : IDisposable
    {
        // Delegate and imports from pinvoke.net:

        public static List<string> APPList = new List<string>();

        delegate void WinEventDelegate(IntPtr hWinEventHook, uint eventType, IntPtr hwnd, int idObject, int idChild, uint dwEventThread, uint dwmsEventTime);

        [DllImport("user32.dll")]
        static extern IntPtr SetWinEventHook(uint eventMin, uint eventMax, IntPtr
           hmodWinEventProc, WinEventDelegate lpfnWinEventProc, uint idProcess,
           uint idThread, uint dwFlags);

        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        static extern Int32 GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

        [DllImport("user32.dll")]
        static extern bool UnhookWinEvent(IntPtr hWinEventHook);

        // Constants from winuser.h
        const uint EVENT_SYSTEM_FOREGROUND = 3;
        const uint WINEVENT_OUTOFCONTEXT = 0;
        private IntPtr hhook;

        // Need to ensure delegate is not collected while we're using it,
        // storing it in a class field is simplest way to do this.
        static WinEventDelegate procDelegate = new WinEventDelegate(WinEventProc);

        public FGHook()
        {
            hhook = SetWinEventHook(EVENT_SYSTEM_FOREGROUND, EVENT_SYSTEM_FOREGROUND, IntPtr.Zero, procDelegate, 0, 0, WINEVENT_OUTOFCONTEXT);
        }

        static void WinEventProc(IntPtr hWinEventHook, uint eventType, IntPtr hwnd, int idObject, int idChild, uint dwEventThread, uint dwmsEventTime)
        {
            GetForegroundProcessName();
        }

        static void GetForegroundProcessName()
        {
            IntPtr hwnd = GetForegroundWindow();

            // The foreground window can be NULL in certain circumstances, 
            // such as when a window is losing activation.
            if (hwnd == null)
                return;

            uint pid;
            GetWindowThreadProcessId(hwnd, out pid);

            foreach (System.Diagnostics.Process p in System.Diagnostics.Process.GetProcesses())
            {
                if (p.Id == pid)
                {
                    APPList.Add(p.ProcessName);
                    return;
                }
            }
            APPList.Add("Unknown");
        }

        public void Dispose()
        {
            UnhookWinEvent(hhook);
        }

        #endregion

    }
}
