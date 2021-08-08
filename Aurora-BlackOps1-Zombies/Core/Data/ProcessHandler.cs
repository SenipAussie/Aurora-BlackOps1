using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using static Aurora_BlackOps1_Zombies.Core.Data.Variables;

namespace Aurora_BlackOps1_Zombies.Core.Data
{
    class ProcessHandler
    {
        [Flags] public enum SnapshotFlags : uint
        {
            HeapList = 0x00000001,
            Process = 0x00000002,
            Thread = 0x00000004,
            Module = 0x00000008,
            Module32 = 0x00000010,
            Inherit = 0x80000000,
            All = 0x0000001F,
            NoHeaps = 0x40000000
        }

        [Flags] public enum ProcessAccessFlags : uint
        {
            All = 0x001F0FFF,
            Terminate = 0x00000001,
            CreateThread = 0x00000002,
            VirtualMemoryOperation = 0x00000008,
            VirtualMemoryRead = 0x00000010,
            VirtualMemoryWrite = 0x00000020,
            DuplicateHandle = 0x00000040,
            CreateProcess = 0x000000080,
            SetQuota = 0x00000100,
            SetInformation = 0x00000200,
            QueryInformation = 0x00000400,
            QueryLimitedInformation = 0x00001000,
            Synchronize = 0x00100000
        }

        public struct MODULEENTRY32
        {
            internal uint dwSize;
            internal uint th32ModuleID;
            internal uint th32ProcessID;
            internal uint GlblcntUsage;
            internal uint ProccntUsage;
            internal IntPtr modBaseAddr;
            internal uint modBaseSize;
            internal IntPtr hModule;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
            internal string szModule;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            internal string szExePath;
        }

        public static void getProcessInfo()
        {
            ProcessInfo.GameProcess = Process.GetProcessesByName("BlackOps")[0];
            ProcessInfo.Handle = DLLImports.OpenProcess(ProcessAccessFlags.All, false, ProcessInfo.GameProcess.Id);
            ProcessInfo.Module = GetModuleBaseAddress(ProcessInfo.GameProcess.Id, "BlackOps.exe");
        }

        public static bool isOpen()
        {
            if (ProcessInfo.GameProcess == null)
                return false;
            else
                return true;
        }

        public static IntPtr GetModuleBaseAddress(int procId, string modName)
        {
            IntPtr modBaseAddr = IntPtr.Zero;
            IntPtr hSnap = DLLImports.CreateToolhelp32Snapshot(SnapshotFlags.Module | SnapshotFlags.Module32, procId);

            if (hSnap.ToInt64() != -1)
            {
                MODULEENTRY32 modEntry = new MODULEENTRY32();
                modEntry.dwSize = (uint)Marshal.SizeOf(typeof(MODULEENTRY32));

                if (DLLImports.Module32First(hSnap, ref modEntry))
                {
                    do
                    {
                        if (modEntry.szModule.Equals(modName))
                        {
                            modBaseAddr = modEntry.modBaseAddr;
                            break;
                        }
                    } while (DLLImports.Module32Next(hSnap, ref modEntry));
                }
            }
            DLLImports.CloseHandle(hSnap);
            return modBaseAddr;
        }
    }
}
