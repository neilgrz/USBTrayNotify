using System.Runtime.InteropServices;
using System;

public class RefreshTray
{
    // stackoverflow.com/a/72309665
    // Using to cleanup USBLogView icon after killing process
    [StructLayout(LayoutKind.Sequential)]
    public struct RECT
    {
        public int Left, Top, Right, Bottom;
    }

    [DllImport("user32.dll")]
    static extern bool GetClientRect(IntPtr hWnd, out RECT lpRect);

    [DllImport("user32.dll", SetLastError = true)]
    public static extern IntPtr FindWindowEx(IntPtr parentHandle, IntPtr hWndChildAfter, string className, string windowTitle);

    [DllImport("user32.dll", CharSet = CharSet.Auto)]
    public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, nuint wParam, nint lParam);

    const int WM_MOUSEMOVE = 0x0200;

    public static void RefreshTraybar()
    {
        RefreshHiddenTraybar();
        RefreshTraybarInTaskbar();
    }

    static void RefreshHiddenTraybar()
    {
        var hiddenTrayWnd = FindWindowEx(IntPtr.Zero, IntPtr.Zero, "NotifyIconOverflowWindow", null);
        var hiddenNotificationArea = FindWindowEx(hiddenTrayWnd, IntPtr.Zero, "ToolbarWindow32", null);
        RefreshArea(hiddenNotificationArea);
    }

    static void RefreshTraybarInTaskbar()
    {
        var trayInTaskbarWnd = FindWindowEx(IntPtr.Zero, IntPtr.Zero, "Shell_TrayWnd", null);
        var trayNotifyWnd = FindWindowEx(trayInTaskbarWnd, IntPtr.Zero, "TrayNotifyWnd", null);
        var sysPager = FindWindowEx(trayNotifyWnd, IntPtr.Zero, "SysPager", null);
        var trayNotificationArea = FindWindowEx(sysPager, IntPtr.Zero, "ToolbarWindow32", null);
        RefreshArea(trayNotificationArea);
    }

    static void RefreshArea(IntPtr area)
    {
        if (!GetClientRect(area, out var clientRect)) return;

        for (int x = 0; x < clientRect.Right; x += 10)
            for (int y = 0; y < clientRect.Bottom; y += 10)
                SendMessage(area, WM_MOUSEMOVE, 0, (y << 16) + x);
    }
}