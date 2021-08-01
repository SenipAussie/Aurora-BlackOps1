using System.Drawing;

namespace Aurora_BlackOps1_Zombies.Core.Data
{
    class Variables
    {
        public struct Info
        {
            public static string Title = "AURORA";
            public static string Version = "1.0";
            public static string Made = "8/1/2021";
            public static string Creator = "Senip";
            public static string Message = "Hope you enjoy!";
            public static string Divider = "            ----------------";
            public static string HotKey = "> Press insert for menu!";
        }

        public struct Menu
        {
            public static bool hitInsert;
            public static Color SelectedTab = Color.FromArgb(255, 45, 48, 57);
            public static Color DeSelectedTab = Color.FromArgb(255, 32, 33, 37);
            public static Color EnabledButton = Color.FromArgb(255, 132, 50, 251);
            public static Color DisabledButton = Color.FromArgb(45, 48, 57);
            public static Point Offset;
        }
        public struct Player
        {
            public static bool ThirdPerson;
            public static string ThirdPersonOffSet = "base+022210F0,18";

            public static bool NoClip;
            public static string NoClipOffSet = "base+024C4FE0,124";

            public static bool GodMode;
            public static string GodModeOffSet = "base+0x1679868";

            public static bool FlyHack;
            public static string FlyHackOffSet = "base+0x1808B6C";

            public static string HealthOffset = "0x01A7987C";

            public static string CashOffSet = "0x01C0a6C8";

            public static string PlayerSpeedOffSet = "base+0x01801810,18";
        }

        public struct Weapons
        {
            public static string PrimaryOffSet = "base+0x1808D34";

            public static string SecondaryOffSet = "base+0x1808D64";

            public static bool UnlimitedAmmo;
            public static string UnlimitedAmmoOffSet = "base+0x297A10";

            public static bool NoRecoil;
            public static string NoRecoilOffSet = "0x006562F0";

            public static bool NoSpread;
            public static string NoSpreadOffSet = "base+0x366F46";
            public static string NoSpreadOffSet2 = "base+0x85254";
            public static string NoSpreadOffSet3 = "base+0x366F50";
            public static string NoSpreadOffSet4 = "base+0x35BEA0";
            public static string NoSpreadOffSet5 = "base+0x35BEAA";
            public static string NoSpreadOffSet6 = "base+0x6CFE";

            public static bool NoRecoilAnimation;
            public static string NoRecoilAnimationOffSet = "base+0x366EF7";

            public static bool NoGunKick;
            public static string NoGunKickOffSet = "base+0x28206F";
            public static string NoGunKickOffSet2 = "base+0x28207D";

            public static bool LongKnife;
            public static string LongKnifeOffSet = "base+0x007A62DC,18";

            public static bool RapidFire;
            public static string RapidFireOffSet = "base+0x3669EC";

            public static string PrimaryAmmoOffset = "base+0x1808F00";
            public static string PrimaryAmmoSpareOffset = "base+0x1808E88";

            public static string SecondaryAmmoOffset = "base+0x1808F10";
            public static string SecondaryAmmoSpareOffset = "base+0x1808E98";
        }

        public struct Visuals
        {
            public static bool FullBright;
            public static string FullBrightOffSet = "0x045FBDAC";

            public static bool Colorized;
            public static string ColorizedOffSet = "0x045FBDA8";

            public static bool NoFog;
            public static string NoFogOffSet = "base+0x0221E880,18";

            public static bool UnlockFPS;
            public static string UnlockFPSOffSet = "0x02481760,18";

            public static bool ShowHud;
            public static string ShowHudOffSet = "base+0x0221DE68,18";

            public static string FOVOffSet = "base+0x0221D364,18";

            public static string ScoreBoardHeadShotsOffSet = "0x01C0A6EC";
            public static string ScoreBoardKillsOffSet = "0x01C0A6CC";
        }

        public struct World
        {
            public static bool AntiMoveBox;
            public static string AntiMoveBoxOffSet = "base+0x0221E054,18";

            public static string TimeScaleOffSet = "base+0x0203FCF4,18";

            public static string GravityOffSet = "base+0x007CAEFC,18"; // 7CF110,88 
        }

        public struct Zombies
        {
            public static bool FreezeZombies;
            public static string FreezeZombiesOffSet = "base+0x1757C3";
            public static string FreezeZombiesOffSet2 = "base+0x1757B2";

            public static bool ZombieGravity;
            public static string ZombieGravityOffSet = "base+0x01FD2FA8,18";

            public static bool FloatingZombies;
            public static string FloatingZombiesOffSet = "base+0x01FD2FA8,18";
        }

        public struct Teleports
        {
            public static float CurrentX = 0;
            public static string CurrentXOffSet = "0x01C08B6C";

            public static float CurrentY = 0;
            public static string CurrentYOffSet = "0x01C08B68";

            public static float CurrentZ = 0;
            public static string CurrentZOffSet = "0x01C08B64";

            public static float ManualX = 0;
            public static float ManualY = 0;
            public static float ManualZ = 0;

            public static float SavedLocation1X = 0;
            public static float SavedLocation1Y = 0;
            public static float SavedLocation1Z = 0;

            public static float SavedLocation2X = 0;
            public static float SavedLocation2Y = 0;
            public static float SavedLocation2Z = 0;
        }
    }
}