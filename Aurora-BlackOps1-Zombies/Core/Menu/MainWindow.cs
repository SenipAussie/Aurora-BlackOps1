using System;
using System.Drawing;
using System.Windows.Forms;
using Aurora_BlackOps1_Zombies.Core.Data;
using Aurora_BlackOps1_Zombies.Core.Menu.Panels;
using static Aurora_BlackOps1_Zombies.Core.Data.Variables;

namespace Aurora_BlackOps1_Zombies
{
    public partial class AuroraBlackOps1 : Form
    {
        public AuroraBlackOps1()
        {
            InitializeComponent();
            InitiatePanels();
            WaitingForClose.Start();
        }

        #region Moveable Form
        private void AuroraBlackOps1_MouseDown(object sender, MouseEventArgs e) { Variables.Menu.Offset = new Point(MousePosition.X - Bounds.X, MousePosition.Y - Bounds.Y); }
        private void AuroraBlackOps1_MouseMove(object sender, MouseEventArgs e) { if (Control.MouseButtons == MouseButtons.Left) this.SetDesktopLocation(MousePosition.X - Variables.Menu.Offset.X, MousePosition.Y - Variables.Menu.Offset.Y); }
        private void AuroraColor_MouseDown(object sender, MouseEventArgs e) { Variables.Menu.Offset = new Point(MousePosition.X - Bounds.X, MousePosition.Y - Bounds.Y); }
        private void AuroraColor_MouseMove(object sender, MouseEventArgs e) { if (Control.MouseButtons == MouseButtons.Left) this.SetDesktopLocation(MousePosition.X - Variables.Menu.Offset.X, MousePosition.Y - Variables.Menu.Offset.Y); }
        #endregion
        #region Main Window Tabs
        GeneralPanel GP = new GeneralPanel() { TopLevel = false, TopMost = false };
        TeleportsPanel TP = new TeleportsPanel() { TopLevel = false, TopMost = false };
        private void InitiatePanels()
        {
            DLLImports.RegisterHotKey(this.Handle, 0, (int)KeyModifier.None, Keys.Insert.GetHashCode());
            pnlPage.Controls.Add(GP);
            pnlPage.Controls.Add(TP);
            GP.Show();
            lstConsole.Items.Add(Info.Title);
            lstConsole.Items.Add("Version: " + Info.Version);
            lstConsole.Items.Add("Updated on: " + Info.Made);
            lstConsole.Items.Add("Built by: " + Info.Creator);
            lstConsole.Items.Add(Info.Message);
            lstConsole.Items.Add(Info.Divider);
            lstConsole.Items.Add(Info.HotKey);
        }

        private void TabIndex(int Index)
        {
            DeSelectAll();
            switch (Index)
            {
                case 0: // General
                    pnlGeneral.BackColor = Variables.Menu.SelectedTab;
                    GP.Show();
                    break;
                case 1: // Teleport
                    pnlTeleports.BackColor = Variables.Menu.SelectedTab;
                    TP.Show();
                    break;
            }
        }
        private void DeSelectAll()
        {
            pnlGeneral.BackColor = Variables.Menu.DeSelectedTab;
            pnlTeleports.BackColor = Variables.Menu.DeSelectedTab;
            GP.Hide();
            TP.Hide();
        }
        #endregion
        #region General Form Index Selector
        private void lblGeneral_Click(object sender, EventArgs e) { TabIndex(0); }
        private void picGeneral_Click(object sender, EventArgs e) { TabIndex(0); }
        private void pnlGeneral_Click(object sender, EventArgs e) { TabIndex(0); }
        #endregion
        #region Teleport Form Index Selector
        private void lblTeleports_Click(object sender, EventArgs e) { TabIndex(1); }
        private void picTeleports_Click(object sender, EventArgs e) { TabIndex(1); }
        private void pnlTeleports_Click(object sender, EventArgs e) { TabIndex(1); }
        #endregion
        #region HotKeyListener
        enum KeyModifier
        { None = 0 }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == 0x0312)
            {
                Keys key = (Keys)(((int)m.LParam >> 16) & 0xFFFF);
                KeyModifier modifier = (KeyModifier)((int)m.LParam & 0xFFFF);
                int id = m.WParam.ToInt32();
                Variables.Menu.hitInsert = !Variables.Menu.hitInsert;
                if (Variables.Menu.hitInsert)
                {
                    base.WindowState = FormWindowState.Normal;
                    base.TopMost = true;
                }
                else
                {
                    base.WindowState = FormWindowState.Minimized;
                    base.TopMost = false;
                }
            }
        }
        #endregion
        #region Proper Closing        
        private void Closing()
        {
            WaitingForClose.Dispose();
            DLLImports.UnregisterHotKey(this.Handle, 0);
            ProcessInfo.GameProcess.Close();
            GP.Dispose();
            TP.Dispose();
            this.Dispose();
        }
        private void WaitingForClose_Tick(object sender, EventArgs e)
        {
            if (!ProcessHandler.isOpen())
                Closing();
        }
        private void AuroraBlackOps1_FormClosing(object sender, FormClosingEventArgs e) { Closing(); }
        private void lblClose_Click(object sender, EventArgs e) { Closing(); }
        private void picClose_Click(object sender, EventArgs e) { Closing(); }
        private void pnlClose_Click(object sender, EventArgs e) { Closing(); }
        #endregion
    }
}
