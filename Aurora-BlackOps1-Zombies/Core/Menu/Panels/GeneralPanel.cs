using System;
using System.Windows.Forms;
using static Aurora_BlackOps1_Zombies.Core.Data.MemoryHandler;
using static Aurora_BlackOps1_Zombies.Core.Data.Variables.Menu;
using static Aurora_BlackOps1_Zombies.Core.Data.Variables;
using static Aurora_BlackOps1_Zombies.Core.Data.DLLImports;

namespace Aurora_BlackOps1_Zombies.Core.Menu.Panels
{
    public partial class GeneralPanel : Form
    {
        public GeneralPanel()
        {
            InitializeComponent();
            Data.ProcessHandler.getProcessInfo();
        }
        #region Player Form Controls
        private void pnlThirdPerson_Click(object sender, EventArgs e)
        {
            if (!Player.ThirdPerson)
            {
                pnlThirdPerson.BackColor = EnabledButton;
                WriteMemory(true, Player.ThirdPersonPointer, "int", "1");
            }
            else
            {
                pnlThirdPerson.BackColor = DisabledButton;
                WriteMemory(true, Player.ThirdPersonPointer, "int", "0");
            }
            Player.ThirdPerson = !Player.ThirdPerson;
        }

        private void pnlNoClip_Click(object sender, EventArgs e)
        {
            if (!Player.NoClip)
            {
                pnlNoClip.BackColor = EnabledButton;
                WriteMemory(true, Player.NoClipPointer, "int", "1");
            }
            else
            {
                pnlNoClip.BackColor = DisabledButton;
                WriteMemory(true, Player.NoClipPointer, "int", "0");
            }
            Player.NoClip = !Player.NoClip;
        }
        private void pnlGod_Click(object sender, EventArgs e)
        {
            if (!Player.GodMode)
            {
                pnlGod.BackColor = EnabledButton;
                WriteMemory(true, Player.GodModePointer, "int", "2081");
            }
            else
            {
                pnlGod.BackColor = DisabledButton;
                WriteMemory(true, Player.GodModePointer, "int", "2080");
            }
            Player.GodMode = !Player.GodMode;
        }
        private void pnlFlyHack_Click(object sender, EventArgs e)
        {
            if (!Player.FlyHack)
            {
                if (!PersistantHealth.Enabled)
                    PersistantHealth.Start();
                pnlFlyHack.BackColor = EnabledButton;
            }
            else
                pnlFlyHack.BackColor = DisabledButton;
            Player.FlyHack = !Player.FlyHack;
        }

        private void txtHealth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void txtHealth_TextChanged(object sender, EventArgs e)
        {
            if (txtHealth.TextLength < 1)
                txtHealth.Text = "0";
            WriteMemory(false, Player.HealthPointer, "int", txtHealth.Text);
            if (!PersistantHealth.Enabled)
                PersistantHealth.Start();
        }

        private void txtCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            if (txtCash.TextLength < 1)
                txtCash.Text = "0";
            WriteMemory(false, Player.CashPointer, "int", txtCash.Text);
        }

        private void txtPlayerSpeed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void txtPlayerSpeed_TextChanged(object sender, EventArgs e)
        {
            if (txtPlayerSpeed.TextLength < 1)
                txtPlayerSpeed.Text = "0";
            WriteMemory(true, Player.PlayerSpeedPointer, "int", txtPlayerSpeed.Text);
        }
        #endregion
        #region Weapon Form Controls
        private void cboPrimary_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPrimary.SelectedIndex != -1)
                WriteMemory(true, Weapons.PrimaryPointer, "int", cboPrimary.SelectedIndex.ToString());
        }

        private void cboSecondary_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSecondary.SelectedIndex != -1)
                WriteMemory(true, Weapons.SecondaryPointer, "int", cboSecondary.SelectedIndex.ToString());
        }

        private void pnlUnlimitedAmmo_Click(object sender, EventArgs e)
        {
            if (!Weapons.UnlimitedAmmo)
            {
                pnlUnlimitedAmmo.BackColor = EnabledButton;
                WriteMemory(true, Weapons.UnlimitedAmmoPointer, "bytes", "90 90 90");
            }
            else
            {
                pnlUnlimitedAmmo.BackColor = DisabledButton;
                WriteMemory(true, Weapons.UnlimitedAmmoPointer, "bytes", "89 50 04");
            }
            Weapons.UnlimitedAmmo = !Weapons.UnlimitedAmmo;
        }

        private void pnlNoRecoil_Click(object sender, EventArgs e)
        {
            if (!Weapons.NoRecoil)
            {
                pnlNoRecoil.BackColor = EnabledButton;
                WriteMemory(false, Weapons.NoRecoilPointer, "int", "117");
            }
            else
            {
                pnlNoRecoil.BackColor = DisabledButton;
                WriteMemory(false, Weapons.NoRecoilPointer, "int", "116");
            }
            Weapons.NoRecoil = !Weapons.NoRecoil;
        }

        private void pnlNoSpread_Click(object sender, EventArgs e)
        {
            if (!Weapons.NoSpread)
            {
                pnlNoSpread.BackColor = EnabledButton;
                WriteMemory(true, Weapons.NoSpreadPointer, "bytes", "90 90 90 90 90 90 90 90");
                WriteMemory(true, Weapons.NoSpreadPointer2, "bytes", "0F 84 EF 02 00 00");
                WriteMemory(true, Weapons.NoSpreadPointer3, "bytes", "90 90 90 90 90 90 90 90");
                WriteMemory(true, Weapons.NoSpreadPointer4, "bytes", "90 90 90 90 90 90 90 90");
                WriteMemory(true, Weapons.NoSpreadPointer5, "bytes", "90 90 90 90 90 90 90 90");
                WriteMemory(true, Weapons.NoSpreadPointer6, "bytes", "F3 0F 10 90 00 04 00 00");
            }
            else
            {
                pnlNoSpread.BackColor = DisabledButton;
                WriteMemory(true, Weapons.NoSpreadPointer, "bytes", "F3 0F 11 86 2C 05 00 00");
                WriteMemory(true, Weapons.NoSpreadPointer2, "bytes", "0F 8B EF 02 00 00");
                WriteMemory(true, Weapons.NoSpreadPointer3, "bytes", "F3 0F 11 8E 2C 05 00 00");
                WriteMemory(true, Weapons.NoSpreadPointer4, "bytes", "F3 0F 11 80 2C 05 00 00");
                WriteMemory(true, Weapons.NoSpreadPointer5, "bytes", "F3 0F 11 88 2C 05 00 00");
                WriteMemory(true, Weapons.NoSpreadPointer6, "bytes", "F3 0F 10 90 CC 04 00 00");
            }
            Weapons.NoSpread = !Weapons.NoSpread;
        }

        private void pnlNoAnimations_Click(object sender, EventArgs e)
        {
            if (!Weapons.NoRecoilAnimation)
            {
                pnlNoAnimations.BackColor = EnabledButton;
                WriteMemory(true, Weapons.NoRecoilAnimationPointer, "bytes", "90 90 90 90 90 90");
            }
            else
            {
                pnlNoAnimations.BackColor = DisabledButton;
                WriteMemory(true, Weapons.NoRecoilAnimationPointer, "bytes", "89 96 24 05 00 00");
            }
            Weapons.NoRecoilAnimation = !Weapons.NoRecoilAnimation;
        }

        private void pnlNoKick_Click(object sender, EventArgs e)
        {
            if (!Weapons.NoGunKick)
            {
                pnlNoKick.BackColor = EnabledButton;
                WriteMemory(true, Weapons.NoGunKickPointer, "bytes", "90 90 90 90 90");
                WriteMemory(true, Weapons.NoGunKickPointer2, "bytes", "90 90 90 90 90");
            }
            else
            {
                pnlNoKick.BackColor = DisabledButton;
                WriteMemory(true, Weapons.NoGunKickPointer, "bytes", "F3 0F 11 49 30");
                WriteMemory(true, Weapons.NoGunKickPointer2, "bytes", "F3 0F 11 51 34");
            }
            Weapons.NoGunKick = !Weapons.NoGunKick;
        }

        private void pnlLongKnife_Click(object sender, EventArgs e)
        {
            if (!Weapons.LongKnife)
            {
                pnlLongKnife.BackColor = EnabledButton;
                WriteMemory(true, Weapons.LongKnifePointer, "float", "9999");
            }
            else
            {
                pnlLongKnife.BackColor = DisabledButton;
                WriteMemory(true, Weapons.LongKnifePointer, "float", "90");
            }
            Weapons.LongKnife = !Weapons.LongKnife;
        }

        private void pnlRapidFire_Click(object sender, EventArgs e)
        {
            if (!Weapons.RapidFire)
            {
                pnlRapidFire.BackColor = EnabledButton;
                WriteMemory(true, Weapons.RapidFirePointer, "bytes", "90 90");
            }
            else
            {
                pnlRapidFire.BackColor = DisabledButton;
                WriteMemory(true, Weapons.RapidFirePointer, "bytes", "89 10");
            }
            Weapons.RapidFire = !Weapons.RapidFire;
        }

        private void txtPrimaryAmmo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void txtPrimaryAmmo_TextChanged(object sender, EventArgs e)
        {
            if (txtPrimaryAmmo.TextLength < 0)
                txtPrimaryAmmo.Text = "0";
            WriteMemory(true, Weapons.PrimaryAmmoPointer, "int", txtPrimaryAmmo.Text);
        }

        private void txtPrimaryAmmoSpare_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void txtPrimaryAmmoSpare_TextChanged(object sender, EventArgs e)
        {
            if (txtPrimaryAmmoSpare.TextLength < 0)
                txtPrimaryAmmoSpare.Text = "0";
            WriteMemory(true, Weapons.PrimaryAmmoSparePointer, "int", txtPrimaryAmmoSpare.Text);
        }

        private void txtSecondaryAmmo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void txtSecondaryAmmo_TextChanged(object sender, EventArgs e)
        {
            if (txtSecondaryAmmo.TextLength < 0)
                txtSecondaryAmmo.Text = "0";
            WriteMemory(true, Weapons.SecondaryAmmoPointer, "int", txtSecondaryAmmo.Text);
        }

        private void txtSecondaryAmmoSpare_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void txtSecondaryAmmoSpare_TextChanged(object sender, EventArgs e)
        {
            if (txtSecondaryAmmo.TextLength < 0)
                txtSecondaryAmmo.Text = "0";
            WriteMemory(true, Weapons.SecondaryAmmoSparePointer, "int", txtSecondaryAmmoSpare.Text);
        }
        #endregion
        #region Visual Form Controls
        private void pnlFullBright_Click(object sender, EventArgs e)
        {
            if (!Visuals.FullBright)
            {
                pnlFullBright.BackColor = EnabledButton;
                WriteMemory(false, Visuals.FullBrightPointer, "int", "4");
            }
            else
            {
                pnlFullBright.BackColor = DisabledButton;
                WriteMemory(false, Visuals.FullBrightPointer, "int", "-16120566");
            }
            Visuals.FullBright = !Visuals.FullBright;
        }

        private void pnlColorized_Click(object sender, EventArgs e)
        {
            if (!Visuals.Colorized)
            {
                pnlColorized.BackColor = EnabledButton;
                WriteMemory(false, Visuals.ColorizedPointer, "int", "2");
            }
            else
            {
                pnlColorized.BackColor = DisabledButton;
                WriteMemory(false, Visuals.ColorizedPointer, "int", "3");
            }
            Visuals.Colorized = !Visuals.Colorized;
        }

        private void pnlNoFog_Click(object sender, EventArgs e)
        {
            if (!Visuals.NoFog)
            {
                pnlNoFog.BackColor = EnabledButton;
                WriteMemory(true, Visuals.NoFogPointer, "int", "0");
            }
            else
            {
                pnlNoFog.BackColor = DisabledButton;
                WriteMemory(true, Visuals.NoFogPointer, "int", "1");
            }
            Visuals.NoFog = !Visuals.NoFog;
        }

        private void pnlUnlockFPS_Click(object sender, EventArgs e)
        {
            if (!Visuals.UnlockFPS)
            {
                pnlUnlockFPS.BackColor = EnabledButton;
                WriteMemory(true, Visuals.UnlockFPSPointer, "int", "144");
            }
            else
            {
                pnlUnlockFPS.BackColor = DisabledButton;
                WriteMemory(true, Visuals.UnlockFPSPointer, "int", "85");
            }
            Visuals.UnlockFPS = !Visuals.UnlockFPS;
        }

        private void pnlHideHUD_Click(object sender, EventArgs e)
        {
            if (!Visuals.ShowHud)
            {
                pnlHideHUD.BackColor = EnabledButton;
                WriteMemory(true, Visuals.ShowHudPointer, "int", "0");
            }
            else
            {
                pnlHideHUD.BackColor = DisabledButton;
                WriteMemory(true, Visuals.ShowHudPointer, "int", "1");
            }
            Visuals.ShowHud = !Visuals.ShowHud;
        }

        private void txtFOV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void txtFOV_TextChanged(object sender, EventArgs e)
        {
            if (txtFOV.TextLength < 0)
                txtFOV.Text = "0";
            WriteMemory(true, Visuals.FOVOffSet, "float", txtFOV.Text);
        }

        private void txtKills_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void txtKills_TextChanged(object sender, EventArgs e)
        {
            if (txtKills.TextLength < 0)
                txtKills.Text = "0";
            WriteMemory(false, Visuals.ScoreBoardKillsPointer, "int", txtKills.Text);
        }

        private void txtHeadshots_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void txtHeadshots_TextChanged(object sender, EventArgs e)
        {
            if (txtHeadshots.TextLength < 0)
                txtHeadshots.Text = "0";
            WriteMemory(false, Visuals.ScoreBoardHeadShotsPointer, "int", txtHeadshots.Text);
        }
        #endregion
        #region World Form Controls
        private void pnlAntiMoveBox_Click(object sender, EventArgs e)
        {
            if (!World.AntiMoveBox)
            {
                pnlAntiMoveBox.BackColor = EnabledButton;
                WriteMemory(true, World.AntiMoveBoxPointer, "int", "50759780");
            }
            else
            {
                pnlAntiMoveBox.BackColor = DisabledButton;
                WriteMemory(true, World.AntiMoveBoxPointer, "int", "50759716");
            }
            World.AntiMoveBox = !World.AntiMoveBox;
        }

        private void txtWorldSpeed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void txtWorldSpeed_TextChanged(object sender, EventArgs e)
        {
            if (txtWorldSpeed.TextLength < 1)
                txtWorldSpeed.Text = "0";
            WriteMemory(true, World.TimeScalePointer, "int", txtWorldSpeed.Text);
        }

        private void txtWorldGravity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void txtWorldGravity_TextChanged(object sender, EventArgs e)
        {
            if (txtWorldGravity.TextLength < 1)
                txtWorldGravity.Text = "0";
            WriteMemory(true, World.GravityPointer, "float", txtWorldGravity.Text);
        }
        #endregion
        #region Zombie Form Controls
        private void pnlFreezeZombies_Click(object sender, EventArgs e)
        {
            if (!Zombies.FreezeZombies)
            {
                pnlFreezeZombies.BackColor = EnabledButton;
                WriteMemory(true, Zombies.FreezeZombiesPointer, "bytes", "90 90 90");
                WriteMemory(true, Zombies.FreezeZombiesPointer2, "bytes", "90 90 90 90 90 90");
            }
            else
            {
                pnlFreezeZombies.BackColor = DisabledButton;
                WriteMemory(true, Zombies.FreezeZombiesPointer, "bytes", "D9 58 04");
                WriteMemory(true, Zombies.FreezeZombiesPointer2, "bytes", "D9 98 1C 01 00 00");
            }
            Zombies.FreezeZombies = !Zombies.FreezeZombies;
        }

        private void pnlZombieGravity_Click(object sender, EventArgs e)
        {
            if (!Zombies.ZombieGravity)
            {
                pnlZombieGravity.BackColor = EnabledButton;
                WriteMemory(true, Zombies.ZombieGravityPointer, "float", "-50");
            }
            else
            {
                pnlZombieGravity.BackColor = DisabledButton;
                if (Zombies.FloatingZombies)
                    WriteMemory(true, Zombies.ZombieGravityPointer, "float", "99");
                else
                    WriteMemory(true, Zombies.ZombieGravityPointer, "float", "-800");
            }
            Zombies.ZombieGravity = !Zombies.ZombieGravity;
        }

        private void pnlFloatingZombies_Click(object sender, EventArgs e)
        {
            if (!Zombies.FloatingZombies)
            {
                pnlFloatingZombies.BackColor = EnabledButton;
                WriteMemory(true, Zombies.FloatingZombiesPointer, "float", "99");
            }
            else
            {
                pnlFloatingZombies.BackColor = DisabledButton;
                if (Zombies.ZombieGravity)
                    WriteMemory(true, Zombies.FloatingZombiesPointer, "float", "-50");
                else
                    WriteMemory(true, Zombies.FloatingZombiesPointer, "float", "-800");
            }
            Zombies.FloatingZombies = !Zombies.FloatingZombies;
        }
        #endregion
        #region Proper Closing
        private void GeneralPanel_FormClosing(object sender, FormClosingEventArgs e)
        { PersistantHealth.Dispose(); }
        #endregion

        private void PersistantHealth_Tick(object sender, EventArgs e)
        {
            if(GetAsyncKeyState(Keys.Space) < 0 && Player.FlyHack)
            {
                float oldV = ReadFloat(true, Player.FlyHackPointer) + 50;
                WriteMemory(true, Player.FlyHackPointer, "float", oldV.ToString());
            }
            if(txtHealth.Text != "100")
                WriteMemory(false, Player.HealthPointer, "int", txtHealth.Text);
            if (txtHealth.Text == "100" && !Player.FlyHack)
                PersistantHealth.Stop();
        }
    }
}
