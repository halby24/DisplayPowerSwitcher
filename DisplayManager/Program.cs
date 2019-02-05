using System;
using System.Runtime.InteropServices;

namespace DisplayManager
{
    class Program
    {
        private const int HWND_BROADCAST = 0xFFFF;
        private const uint WM_SYSCOMMAND = 0x0112;
        private const int SC_MONITORPOWER = 0xF170;
        private const int DISPLAY_ON = -1;
        private const int DISPLAY_OFF = 2;

        [DllImport("user32.dll")]
        private static extern bool PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        static void Main(string[] args)
        {
            switch (args[0])
            {
                case "ON":
                    PostMessage(new IntPtr(HWND_BROADCAST), WM_SYSCOMMAND, new IntPtr(SC_MONITORPOWER),
                        new IntPtr(DISPLAY_ON));
                    break;
                case "OFF":
                    PostMessage(new IntPtr(HWND_BROADCAST), WM_SYSCOMMAND, new IntPtr(SC_MONITORPOWER),
                        new IntPtr(DISPLAY_OFF));
                    break;
            }
        }
    }
}