using System;
using System.Windows.Forms;
using static Aurora_BlackOps1_Zombies.Core.Data.MemoryHandler;
using static Aurora_BlackOps1_Zombies.Core.Data.Variables.Menu;
using static Aurora_BlackOps1_Zombies.Core.Data.Variables;
using System.Threading;

namespace Aurora_BlackOps1_Zombies.Core.Menu.Panels
{
    public partial class GeneralPanel : Form
    {
        public GeneralPanel()
        {
            InitializeComponent();
        }
        #region Player Form Controls
        private void pnlThirdPerson_Click(object sender, EventArgs e)
        {
            if (!Player.ThirdPerson)
            {
                pnlThirdPerson.BackColor = EnabledButton;
                WriteToMemory(Player.ThirdPersonOffSet, "int", "1");
            }
            else
            {
                pnlThirdPerson.BackColor = DisabledButton;
                WriteToMemory(Player.ThirdPersonOffSet, "int", "0");
            }
            Player.ThirdPerson = !Player.ThirdPerson;
        }

        private void pnlNoClip_Click(object sender, EventArgs e)
        {
            if (!Player.NoClip)
            {
                pnlNoClip.BackColor = EnabledButton;
                WriteToMemory(Player.NoClipOffSet, "int", "1");
            }
            else
            {
                pnlNoClip.BackColor = DisabledButton;
                WriteToMemory(Player.NoClipOffSet, "int", "0");
            }
            Player.NoClip = !Player.NoClip;
        }
        private void pnlGod_Click(object sender, EventArgs e)
        {
            if (!Player.GodMode)
            {
                pnlGod.BackColor = EnabledButton;
                WriteToMemory(Player.GodModeOffSet, "int", "2081");
            }
            else
            {
                pnlGod.BackColor = DisabledButton;
                WriteToMemory(Player.GodModeOffSet, "int", "2080");
            }
            Player.GodMode = !Player.GodMode;
        }
        private void pnlFlyHack_Click(object sender, EventArgs e)
        {
            if (!Player.FlyHack)
                pnlFlyHack.BackColor = EnabledButton;
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
            WriteToMemory(Player.HealthOffset, "int", txtHealth.Text);
        }

        private void txtCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            if (txtCash.TextLength < 1)
                txtCash.Text = "0";
            WriteToMemory(Player.CashOffSet, "int", txtCash.Text);
        }

        private void txtPlayerSpeed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void txtPlayerSpeed_TextChanged(object sender, EventArgs e)
        {
            if (txtPlayerSpeed.TextLength < 1)
                txtPlayerSpeed.Text = "0";
            WriteToMemory(Player.PlayerSpeedOffSet, "int", txtPlayerSpeed.Text);
        }
        #endregion
        #region Weapon Form Controls
        private void cboPrimary_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPrimary.SelectedIndex != -1)
                WriteToMemory(Weapons.PrimaryOffSet, "int", cboPrimary.SelectedIndex.ToString());
        }

        private void cboSecondary_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSecondary.SelectedIndex != -1)
                WriteToMemory(Weapons.SecondaryOffSet, "int", cboSecondary.SelectedIndex.ToString());
        }

        private void pnlUnlimitedAmmo_Click(object sender, EventArgs e)
        {
            if (!Weapons.UnlimitedAmmo)
            {
                pnlUnlimitedAmmo.BackColor = EnabledButton;
                WriteToMemory(Weapons.UnlimitedAmmoOffSet, "bytes", "90 90 90");
            }
            else
            {
                pnlUnlimitedAmmo.BackColor = DisabledButton;
                WriteToMemory(Weapons.UnlimitedAmmoOffSet, "bytes", "89 50 04");
            }
            Weapons.UnlimitedAmmo = !Weapons.UnlimitedAmmo;
        }

        private void pnlNoRecoil_Click(object sender, EventArgs e)
        {
            if (!Weapons.NoRecoil)
            {
                pnlNoRecoil.BackColor = EnabledButton;
                WriteToMemory(Weapons.NoRecoilOffSet, "int", "117");
            }
            else
            {
                pnlNoRecoil.BackColor = DisabledButton;
                WriteToMemory(Weapons.NoRecoilOffSet, "int", "116");
            }
            Weapons.NoRecoil = !Weapons.NoRecoil;
        }

        private void pnlNoSpread_Click(object sender, EventArgs e)
        {
            if (!Weapons.NoSpread)
            {
                pnlNoSpread.BackColor = EnabledButton;
                WriteToMemory(Weapons.NoSpreadOffSet, "bytes", "90 90 90 90 90 90 90 90");
                WriteToMemory(Weapons.NoSpreadOffSet2, "bytes", "0F 84 EF 02 00 00");
                WriteToMemory(Weapons.NoSpreadOffSet3, "bytes", "90 90 90 90 90 90 90 90");
                WriteToMemory(Weapons.NoSpreadOffSet4, "bytes", "90 90 90 90 90 90 90 90");
                WriteToMemory(Weapons.NoSpreadOffSet5, "bytes", "90 90 90 90 90 90 90 90");
                WriteToMemory(Weapons.NoSpreadOffSet6, "bytes", "F3 0F 10 90 00 04 00 00");
            }
            else
            {
                pnlNoSpread.BackColor = DisabledButton;
                WriteToMemory(Weapons.NoSpreadOffSet, "bytes", "F3 0F 11 86 2C 05 00 00");
                WriteToMemory(Weapons.NoSpreadOffSet2, "bytes", "0F 8B EF 02 00 00");
                WriteToMemory(Weapons.NoSpreadOffSet3, "bytes", "F3 0F 11 8E 2C 05 00 00");
                WriteToMemory(Weapons.NoSpreadOffSet4, "bytes", "F3 0F 11 80 2C 05 00 00");
                WriteToMemory(Weapons.NoSpreadOffSet5, "bytes", "F3 0F 11 88 2C 05 00 00");
                WriteToMemory(Weapons.NoSpreadOffSet6, "bytes", "F3 0F 10 90 CC 04 00 00");
            }
            Weapons.NoSpread = !Weapons.NoSpread;
        }

        private void pnlNoAnimations_Click(object sender, EventArgs e)
        {
            if (!Weapons.NoRecoilAnimation)
            {
                pnlNoAnimations.BackColor = EnabledButton;
                WriteToMemory(Weapons.NoRecoilAnimationOffSet, "bytes", "90 90 90 90 90 90");
            }
            else
            {
                pnlNoAnimations.BackColor = DisabledButton;
                WriteToMemory(Weapons.NoRecoilAnimationOffSet, "bytes", "89 96 24 05 00 00");
            }
            Weapons.NoRecoilAnimation = !Weapons.NoRecoilAnimation;
        }

        private void pnlNoKick_Click(object sender, EventArgs e)
        {
            if (!Weapons.NoGunKick)
            {
                pnlNoKick.BackColor = EnabledButton;
                WriteToMemory(Weapons.NoGunKickOffSet, "bytes", "90 90 90 90 90");
                WriteToMemory(Weapons.NoGunKickOffSet2, "bytes", "90 90 90 90 90");
            }
            else
            {
                pnlNoKick.BackColor = DisabledButton;
                WriteToMemory(Weapons.NoGunKickOffSet, "bytes", "F3 0F 11 49 30");
                WriteToMemory(Weapons.NoGunKickOffSet2, "bytes", "F3 0F 11 51 34");
            }
            Weapons.NoGunKick = !Weapons.NoGunKick;
        }

        private void pnlLongKnife_Click(object sender, EventArgs e)
        {
            if (!Weapons.LongKnife)
            {
                pnlLongKnife.BackColor = EnabledButton;
                WriteToMemory(Weapons.LongKnifeOffSet, "float", "9999");
            }
            else
            {
                pnlLongKnife.BackColor = DisabledButton;
                WriteToMemory(Weapons.LongKnifeOffSet, "float", "90");
            }
            Weapons.LongKnife = !Weapons.LongKnife;
        }

        private void pnlRapidFire_Click(object sender, EventArgs e)
        {
            if (!Weapons.RapidFire)
            {
                pnlRapidFire.BackColor = EnabledButton;
                WriteToMemory(Weapons.RapidFireOffSet, "bytes", "90 90");
            }
            else
            {
                pnlRapidFire.BackColor = DisabledButton;
                WriteToMemory(Weapons.RapidFireOffSet, "bytes", "89 10");
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
            WriteToMemory(Weapons.PrimaryAmmoOffset, "int", txtPrimaryAmmo.Text);
        }

        private void txtPrimaryAmmoSpare_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void txtPrimaryAmmoSpare_TextChanged(object sender, EventArgs e)
        {
            if (txtPrimaryAmmoSpare.TextLength < 0)
                txtPrimaryAmmoSpare.Text = "0";
            WriteToMemory(Weapons.PrimaryAmmoSpareOffset, "int", txtPrimaryAmmoSpare.Text);
        }

        private void txtSecondaryAmmo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void txtSecondaryAmmo_TextChanged(object sender, EventArgs e)
        {
            if (txtSecondaryAmmo.TextLength < 0)
                txtSecondaryAmmo.Text = "0";
            WriteToMemory(Weapons.SecondaryAmmoOffset, "int", txtSecondaryAmmo.Text);
        }

        private void txtSecondaryAmmoSpare_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void txtSecondaryAmmoSpare_TextChanged(object sender, EventArgs e)
        {
            if (txtSecondaryAmmo.TextLength < 0)
                txtSecondaryAmmo.Text = "0";
            WriteToMemory(Weapons.SecondaryAmmoSpareOffset, "int", txtSecondaryAmmoSpare.Text);
        }
        #endregion
        #region Visual Form Controls
        private void pnlFullBright_Click(object sender, EventArgs e)
        {
            if (!Visuals.FullBright)
            {
                pnlFullBright.BackColor = EnabledButton;
                WriteToMemory(Visuals.FullBrightOffSet, "int", "4");
            }
            else
            {
                pnlFullBright.BackColor = DisabledButton;
                WriteToMemory(Visuals.FullBrightOffSet, "int", "-16120566");
            }
            Visuals.FullBright = !Visuals.FullBright;
        }

        private void pnlColorized_Click(object sender, EventArgs e)
        {
            if (!Visuals.Colorized)
            {
                pnlColorized.BackColor = EnabledButton;
                WriteToMemory(Visuals.ColorizedOffSet, "int", "2");
            }
            else
            {
                pnlColorized.BackColor = DisabledButton;
                WriteToMemory(Visuals.ColorizedOffSet, "int", "3");
            }
            Visuals.Colorized = !Visuals.Colorized;
        }

        private void pnlNoFog_Click(object sender, EventArgs e)
        {
            if (!Visuals.NoFog)
            {
                pnlNoFog.BackColor = EnabledButton;
                WriteToMemory(Visuals.NoFogOffSet, "int", "0");
            }
            else
            {
                pnlNoFog.BackColor = DisabledButton;
                WriteToMemory(Visuals.NoFogOffSet, "int", "1");
            }
            Visuals.NoFog = !Visuals.NoFog;
        }

        private void pnlUnlockFPS_Click(object sender, EventArgs e)
        {
            if (!Visuals.UnlockFPS)
            {
                pnlUnlockFPS.BackColor = EnabledButton;
                WriteToMemory(Visuals.UnlockFPSOffSet, "int", "144");
            }
            else
            {
                pnlUnlockFPS.BackColor = DisabledButton;
                WriteToMemory(Visuals.UnlockFPSOffSet, "int", "85");
            }
            Visuals.UnlockFPS = !Visuals.UnlockFPS;
        }

        private void pnlHideHUD_Click(object sender, EventArgs e)
        {
            if (!Visuals.ShowHud)
            {
                pnlHideHUD.BackColor = EnabledButton;
                WriteToMemory(Visuals.ShowHudOffSet, "int", "0");
            }
            else
            {
                pnlHideHUD.BackColor = DisabledButton;
                WriteToMemory(Visuals.ShowHudOffSet, "int", "1");
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
            WriteToMemory(Visuals.FOVOffSet, "float", txtFOV.Text);
        }

        private void txtKills_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void txtKills_TextChanged(object sender, EventArgs e)
        {
            if (txtKills.TextLength < 0)
                txtKills.Text = "0";
            WriteToMemory(Visuals.ScoreBoardKillsOffSet, "int", txtKills.Text);
        }

        private void txtHeadshots_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void txtHeadshots_TextChanged(object sender, EventArgs e)
        {
            if (txtHeadshots.TextLength < 0)
                txtHeadshots.Text = "0";
            WriteToMemory(Visuals.ScoreBoardHeadShotsOffSet, "int", txtHeadshots.Text);
        }
        #endregion
        #region World Form Controls
        private void pnlAntiMoveBox_Click(object sender, EventArgs e)
        {
            if (!World.AntiMoveBox)
            {
                pnlAntiMoveBox.BackColor = EnabledButton;
                WriteToMemory(World.AntiMoveBoxOffSet, "int", "50759780");
            }
            else
            {
                pnlAntiMoveBox.BackColor = DisabledButton;
                WriteToMemory(World.AntiMoveBoxOffSet, "int", "50759716");
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
            WriteToMemory(World.TimeScaleOffSet, "int", txtWorldSpeed.Text);
        }

        private void txtWorldGravity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void txtWorldGravity_TextChanged(object sender, EventArgs e)
        {
            if (txtWorldGravity.TextLength < 1)
                txtWorldGravity.Text = "0";
            WriteToMemory(World.GravityOffSet, "float", txtWorldGravity.Text);
        }
        #endregion
        #region Zombie Form Controls
        private void pnlFreezeZombies_Click(object sender, EventArgs e)
        {
            if (!Zombies.FreezeZombies)
            {
                pnlFreezeZombies.BackColor = EnabledButton;
                WriteToMemory(Zombies.FreezeZombiesOffSet, "bytes", "90 90 90");
                WriteToMemory(Zombies.FreezeZombiesOffSet2, "bytes", "90 90 90 90 90 90");
            }
            else
            {
                pnlFreezeZombies.BackColor = DisabledButton;
                WriteToMemory(Zombies.FreezeZombiesOffSet, "bytes", "D9 58 04");
                WriteToMemory(Zombies.FreezeZombiesOffSet2, "bytes", "D9 98 1C 01 00 00");
            }
            Zombies.FreezeZombies = !Zombies.FreezeZombies;
        }

        private void pnlZombieGravity_Click(object sender, EventArgs e)
        {
            if (!Zombies.ZombieGravity)
            {
                pnlZombieGravity.BackColor = EnabledButton;
                WriteToMemory(Zombies.ZombieGravityOffSet, "float", "-50");
            }
            else
            {
                pnlZombieGravity.BackColor = DisabledButton;
                if (Zombies.FloatingZombies)
                    WriteToMemory(Zombies.ZombieGravityOffSet, "float", "99");
                else
                    WriteToMemory(Zombies.ZombieGravityOffSet, "float", "-800");
            }
            Zombies.ZombieGravity = !Zombies.ZombieGravity;
        }

        private void pnlFloatingZombies_Click(object sender, EventArgs e)
        {
            if (!Zombies.FloatingZombies)
            {
                pnlFloatingZombies.BackColor = EnabledButton;
                WriteToMemory(Zombies.FloatingZombiesOffSet, "float", "99");
            }
            else
            {
                pnlFloatingZombies.BackColor = DisabledButton;
                if (Zombies.ZombieGravity)
                    WriteToMemory(Zombies.FloatingZombiesOffSet, "float", "-50");
                else
                    WriteToMemory(Zombies.FloatingZombiesOffSet, "float", "-800");
            }
            Zombies.FloatingZombies = !Zombies.FloatingZombies;
        }
        #endregion
        #region Proper Closing
        private void GeneralPanel_FormClosing(object sender, FormClosingEventArgs e)
        { PersistantHealth.Dispose(); }
        #endregion
    }
}
