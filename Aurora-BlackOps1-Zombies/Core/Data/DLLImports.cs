using System;
using System.Runtime.InteropServices;

namespace Aurora_BlackOps1_Zombies.Core.Data
{
    class DLLImports
    {
        // USER32 IMPORTS
        [DllImport("user32.dll")] public static extern bool RegisterHotKey(
            IntPtr hWnd, 
            int id, 
            int fsModifiers, 
            int vk);
        [DllImport("user32.dll")] public static extern bool UnregisterHotKey(
            IntPtr hWnd, 
            int id);

        [DllImport("user32.dll")] public static extern short GetAsyncKeyState(
            System.Windows.Forms.Keys vKey);

        // KERNAL32 IMPORTS
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr CreateToolhelp32Snapshot(
            ProcessHandler.SnapshotFlags dwFlags, 
            int th32ProcessID);

        [DllImport("kernel32.dll")]
        public static extern bool WriteProcessMemory(
            IntPtr hProcess, 
            UIntPtr lpBaseAddress,
            byte[] lpBuffer,
            UIntPtr nSize,
            IntPtr lpNumberOfBytesWritten);

        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(
            IntPtr hProcess,
            UIntPtr lpBaseAddress, 
            [Out] byte[] lpBuffer,
            UIntPtr nSize,
            IntPtr lpNumberOfBytesRead);

        [DllImport("kernel32.dll")]
        public static extern bool Module32First(
            IntPtr hSnapshot, 
            ref ProcessHandler.MODULEENTRY32 lpme);

        [DllImport("kernel32.dll")]
        public static extern bool Module32Next(
            IntPtr hSnapshot,
            ref ProcessHandler.MODULEENTRY32 lpme);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool CloseHandle(
            IntPtr hHandle);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr OpenProcess(
            ProcessHandler.ProcessAccessFlags processAccess, 
            bool bInheritHandle, 
            int processId);
    }
}
