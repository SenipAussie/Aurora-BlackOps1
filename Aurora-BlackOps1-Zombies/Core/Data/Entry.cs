using Aurora_BlackOps1_Zombies.Core.Data;
using System;
using System.Windows.Forms;

namespace Aurora_BlackOps1_Zombies
{
    static class Entry
    {
        [STAThread]
        static void Main()
        {
            ProcessHandler.getProcessInfo();
            if (!ProcessHandler.isOpen())
            {
                MessageBox.Show("BlackOps.exe is not Running!");
                Environment.Exit(0);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AuroraBlackOps1());
        }
    }
}
