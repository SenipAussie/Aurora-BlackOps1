using Memory;

namespace Aurora_BlackOps1_Zombies.Core.Data
{
    class MemoryHandler
    {
        public static Mem m = new Mem();
        
        public static void WriteToMemory(string offset, string datatype, string bytes)
        {
            try
            {
                m.WriteMemory(offset, datatype, bytes);
            } catch { }
        }

        public static float ReadFromMemory(string offset)
        {
            try
            {
                return m.ReadFloat(offset);
            } catch { return 0; }
        }

        public static bool isOpen()
        {
            if (!m.OpenProcess("BlackOps.exe"))
                return false;
            else 
                return true;
        }
    }
}
