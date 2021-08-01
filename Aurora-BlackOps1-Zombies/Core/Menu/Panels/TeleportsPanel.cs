using System;
using System.Windows.Forms;
using static Aurora_BlackOps1_Zombies.Core.Data.MemoryHandler;
using static Aurora_BlackOps1_Zombies.Core.Data.Variables;

namespace Aurora_BlackOps1_Zombies.Core.Menu.Panels
{
    public partial class TeleportsPanel : Form
    {
        public TeleportsPanel()
        {
            InitializeComponent();
            IntervalUpdates.Start();
        }

        private void IntervalUpdates_Tick(object sender, EventArgs e)
        {
            if (isOpen())
            {
                txtCurrentX.Text = ReadFromMemory(Teleports.CurrentXOffSet).ToString();
                txtCurrentY.Text = ReadFromMemory(Teleports.CurrentYOffSet).ToString();
                txtCurrentZ.Text = ReadFromMemory(Teleports.CurrentZOffSet).ToString();
            }
            else { this.Close(); }
        }

        private bool ValidateInput(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57 || e.KeyChar == '-') && e.KeyChar != 8 && e.KeyChar != 46 && e.KeyChar != '-'))
            {
                e.Handled = true;
                return true;
            }

            if (e.KeyChar == 46 || e.KeyChar == '-')
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
                return true;
            }
            return false;
        }

        #region Manual Teleports
        private void btnManualClear_Click(object sender, EventArgs e)
        {
            txtManualX.Text = "0";
            txtManualY.Text = "0";
            txtManualZ.Text = "0";
        }

        private void btnManualTeleport_Click(object sender, EventArgs e)
        {
            // Yes, I know this looks redundant... The textbox to write memory throws a fit. The work around is parsing then back to string, lmao. 
            Teleports.ManualX = float.Parse(txtManualX.Text);
            Teleports.ManualY = float.Parse(txtManualY.Text);
            Teleports.ManualZ = float.Parse(txtManualZ.Text);
            WriteToMemory(Teleports.CurrentXOffSet, "float", Teleports.ManualX.ToString());
            WriteToMemory(Teleports.CurrentYOffSet, "float", Teleports.ManualY.ToString());
            WriteToMemory(Teleports.CurrentZOffSet, "float", Teleports.ManualZ.ToString());
        }

        private void txtManualX_KeyPress(object sender, KeyPressEventArgs e) { ValidateInput(sender, e); }
        private void txtManualX_TextChanged(object sender, EventArgs e)
        {
            if (txtManualX.TextLength < 1)
                txtManualX.Text = "0";
        }
        private void txtManualY_KeyPress(object sender, KeyPressEventArgs e) { ValidateInput(sender, e); }
        private void txtManualY_TextChanged(object sender, EventArgs e)
        {
            if (txtManualY.TextLength < 1)
                txtManualY.Text = "0";
        }

        private void txtManualZ_KeyPress(object sender, KeyPressEventArgs e) { ValidateInput(sender, e); }


        private void txtManualZ_TextChanged(object sender, EventArgs e)
        {
            if (txtManualZ.TextLength < 1)
                txtManualZ.Text = "0";
        }
        #endregion
        #region Save Locations
        private void btnSaveLocation1_Click(object sender, EventArgs e)
        {
            txtTeleportLocation1X.Text = txtCurrentX.Text;
            txtTeleportLocation1Y.Text = txtCurrentY.Text;
            txtTeleportLocation1Z.Text = txtCurrentZ.Text;
            Teleports.SavedLocation1X = float.Parse(txtCurrentX.Text);
            Teleports.SavedLocation1Y = float.Parse(txtCurrentY.Text);
            Teleports.SavedLocation1Z = float.Parse(txtCurrentZ.Text);
        }

        private void btnSaveLocation2_Click(object sender, EventArgs e)
        {
            txtTeleportLocation2X.Text = txtCurrentX.Text;
            txtTeleportLocation2Y.Text = txtCurrentY.Text;
            txtTeleportLocation2Z.Text = txtCurrentZ.Text;
            Teleports.SavedLocation2X = float.Parse(txtCurrentX.Text);
            Teleports.SavedLocation2Y = float.Parse(txtCurrentY.Text);
            Teleports.SavedLocation2Z = float.Parse(txtCurrentZ.Text);
        }
        #endregion
        #region Location 1
        private void txtTeleportLocation1X_KeyPress(object sender, KeyPressEventArgs e) { ValidateInput(sender, e); }
        private void txtTeleportLocation1X_TextChanged(object sender, EventArgs e)
        {
            if (txtTeleportLocation1X.TextLength < 1)
                txtTeleportLocation1X.Text = "0";
        }

        private void txtTeleportLocation1Y_KeyPress(object sender, KeyPressEventArgs e) { ValidateInput(sender, e); }
        private void txtTeleportLocation1Y_TextChanged(object sender, EventArgs e)
        {
            if (txtTeleportLocation1Y.TextLength < 1)
                txtTeleportLocation1Y.Text = "0";
        }
        private void txtTeleportLocation1Z_KeyPress(object sender, KeyPressEventArgs e) { ValidateInput(sender, e); }
        private void txtTeleportLocation1Z_TextChanged(object sender, EventArgs e)
        {
            if (txtTeleportLocation1Z.TextLength < 1)
                txtTeleportLocation1Z.Text = "0";
        }
        private void btnClearLocation1_Click(object sender, EventArgs e)
        {
            txtTeleportLocation1X.Text = "0";
            txtTeleportLocation1Y.Text = "0";
            txtTeleportLocation1Z.Text = "0";
            Teleports.SavedLocation1X = 0;
            Teleports.SavedLocation1Y = 0;
            Teleports.SavedLocation1Z = 0;
        }

        private void btnTeleportLocation1_Click(object sender, EventArgs e)
        {
            WriteToMemory(Teleports.CurrentXOffSet, "float", Teleports.SavedLocation1X.ToString());
            WriteToMemory(Teleports.CurrentYOffSet, "float", Teleports.SavedLocation1Y.ToString());
            WriteToMemory(Teleports.CurrentZOffSet, "float", Teleports.SavedLocation1Z.ToString());
        }
        #endregion
        #region Location 2
        private void txtTeleportLocation2X_KeyPress(object sender, KeyPressEventArgs e) { ValidateInput(sender, e); }
        private void txtTeleportLocation2X_TextChanged(object sender, EventArgs e)
        {
            if (txtTeleportLocation2X.TextLength < 1)
                txtTeleportLocation2X.Text = "0";
        }

        private void txtTeleportLocation2Y_KeyPress(object sender, KeyPressEventArgs e) { ValidateInput(sender, e); }
        private void txtTeleportLocation2Y_TextChanged(object sender, EventArgs e)
        {
            if (txtTeleportLocation2Y.TextLength < 1)
                txtTeleportLocation2Y.Text = "0";
        }

        private void txtTeleportLocation2Z_KeyPress(object sender, KeyPressEventArgs e) { ValidateInput(sender, e); }
        private void txtTeleportLocation2Z_TextChanged(object sender, EventArgs e)
        {
            if (txtTeleportLocation2Z.TextLength < 1)
                txtTeleportLocation2Z.Text = "0";
        }
        private void btnClearLocation2_Click(object sender, EventArgs e)
        {
            txtTeleportLocation2X.Text = "0";
            txtTeleportLocation2Y.Text = "0";
            txtTeleportLocation2Z.Text = "0";
            Teleports.SavedLocation2X = 0;
            Teleports.SavedLocation2Y = 0;
            Teleports.SavedLocation2Z = 0;
        }

        private void btnTeleportLocation2_Click(object sender, EventArgs e)
        {
            WriteToMemory(Teleports.CurrentXOffSet, "float", Teleports.SavedLocation2X.ToString());
            WriteToMemory(Teleports.CurrentYOffSet, "float", Teleports.SavedLocation2Y.ToString());
            WriteToMemory(Teleports.CurrentZOffSet, "float", Teleports.SavedLocation2Z.ToString());
        }
        #endregion
        #region Proper Closing
        private void TeleportsPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            IntervalUpdates.Stop();
            IntervalUpdates.Dispose();
        }
        #endregion
    }
}