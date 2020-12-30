using System;
using System.Runtime.InteropServices;
using Timer;

class FGHook : IDisposable
{
    // Delegate and imports from pinvoke.net:

    private static DataStore _objDataStore = null;

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
        _objDataStore = DataStore.GetInstance();
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

        GetWindowThreadProcessId(hwnd, out uint pid);

        foreach (System.Diagnostics.Process p in System.Diagnostics.Process.GetProcesses())
        {
            if (p.Id == pid)
            {
                _objDataStore.UpdateData(p.ProcessName);
                return;
            }
        }
        _objDataStore.UpdateData("Unknown");
    }

    public void Dispose()
    {
        UnhookWinEvent(hhook);
    }
}
