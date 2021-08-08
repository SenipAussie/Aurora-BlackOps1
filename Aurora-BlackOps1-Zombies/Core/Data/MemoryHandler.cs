using System;
using System.Globalization;
using System.Linq;
using static Aurora_BlackOps1_Zombies.Core.Data.Variables;
using static Aurora_BlackOps1_Zombies.Core.Data.DLLImports;
using System.Collections.Generic;

namespace Aurora_BlackOps1_Zombies.Core.Data
{
    class MemoryHandler
    {
        public static void WriteMemory(bool requiresModule, string pointer, string type, string write)
        {
            UIntPtr Address = GetAddress(requiresModule, pointer);
            byte[] memory = new byte[4];
            int size = 4;

            switch (type.ToLower())
            {
                case "float":
                    write = Convert.ToString(float.Parse(write, CultureInfo.InvariantCulture));
                    memory = BitConverter.GetBytes(Convert.ToSingle(write));
                    size = 4;
                    break;
                case "int":
                    memory = BitConverter.GetBytes(Convert.ToInt32(write));
                    size = 4;
                    break;
                case "byte":
                    memory = new byte[1];
                    memory[0] = Convert.ToByte(write, 16);
                    size = 1;
                    break;
                case "bytes":
                    string[] stringBytes = write.Split(' ');
                    memory = new byte[stringBytes.Count()];
                    for (int i = 0; i < stringBytes.Count(); i++)
                        memory[i] = Convert.ToByte(stringBytes[i], 16);
                    size = stringBytes.Count();
                    break;
            }
            WriteProcessMemory(ProcessInfo.Handle, Address, memory, (UIntPtr)size, IntPtr.Zero);
        }

        public static float ReadFloat(bool requiresModule, string pointer)
        {
            UIntPtr Address = GetAddress(requiresModule, pointer);
            byte[] memory = new byte[4];
            try
            {
                if (ReadProcessMemory(ProcessInfo.Handle, Address, memory, (UIntPtr)4, IntPtr.Zero))
                {
                    float address = (float)BitConverter.ToSingle(memory, 0);
                    return (float)Math.Round(address, 2);
                }
                else
                    return 0;
            }
            catch { return 0; }
        }

        public static UIntPtr GetAddress(bool requiresModule, string pointer, int size = 8)
        {
            if (!requiresModule && !pointer.Contains(","))
                return (UIntPtr)(Convert.ToUInt32(pointer, 16));
            else
                if (!pointer.Contains(","))
                return (UIntPtr)((int)ProcessInfo.Module + Convert.ToInt32(pointer, 16));

            byte[] MemoryAddress = new byte[size];
            List<int> OffSetList = new List<int>();
            string[] OffSetArray = pointer.Split(',');

            foreach (string OffSetElement in OffSetArray)
            {
                string WithoutHexPrefix = OffSetElement;
                if (OffSetElement.Contains("0x")) WithoutHexPrefix = OffSetElement.Replace("0x", "");
                OffSetList.Add(Int32.Parse(WithoutHexPrefix, NumberStyles.AllowHexSpecifier));
            }

            int[] OffSets = OffSetList.ToArray();
            ReadProcessMemory(ProcessInfo.Handle, (UIntPtr)(long)(ProcessInfo.Module + OffSets[0]), MemoryAddress, (UIntPtr)size, IntPtr.Zero);
            uint AddOffsets = BitConverter.ToUInt32(MemoryAddress, 0);
            UIntPtr AdjustedAddress = UIntPtr.Zero;

            for (int i = 1; i < OffSets.Length; i++)
            {
                AdjustedAddress = new UIntPtr(Convert.ToUInt32(AddOffsets + OffSets[i]));
                ReadProcessMemory(ProcessInfo.Handle, AdjustedAddress, MemoryAddress, (UIntPtr)size, IntPtr.Zero);
                AddOffsets = BitConverter.ToUInt32(MemoryAddress, 0);
            }
            return AdjustedAddress;
        }
    }
}
