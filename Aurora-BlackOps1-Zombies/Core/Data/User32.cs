using System;

namespace Aurora_BlackOps1_Zombies.Core.Data
{
    class User32
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")] public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);
        [System.Runtime.InteropServices.DllImport("user32.dll")] public static extern bool UnregisterHotKey(IntPtr hWnd, int id);
    }
}
