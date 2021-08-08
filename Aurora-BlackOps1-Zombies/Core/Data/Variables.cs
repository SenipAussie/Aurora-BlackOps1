using System;
using System.Diagnostics;
using System.Drawing;

namespace Aurora_BlackOps1_Zombies.Core.Data
{
    class Variables
    {
        public struct Info
        {
            public static string Title = "AURORA";
            public static string Version = "1.1";
            public static string Made = "8/7/2021";
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

        public struct ProcessInfo
        {
            public static Process GameProcess;
            public static IntPtr Handle;
            public static IntPtr Module;
        }

        public struct Player
        {
            public static bool ThirdPerson;
            public static string ThirdPersonPointer = "0x022210F0,0x18";

            public static bool NoClip;
            public static string NoClipPointer = "0x024C4FE0,0x124";

            public static bool GodMode;
            public static string GodModePointer = "0x1679868";

            public static bool FlyHack;
            public static string FlyHackPointer = "0x1808B6C";

            public static string HealthPointer = "0x01A7987C";

            public static string CashPointer = "0x01C0a6C8";

            public static string PlayerSpeedPointer = "0x01801810,0x18";
        }

        public struct Weapons
        {
            public static string PrimaryPointer = "0x1808D34";

            public static string SecondaryPointer = "0x1808D64";

            public static bool UnlimitedAmmo;
            public static string UnlimitedAmmoPointer = "0x297A10";

            public static bool NoRecoil;
            public static string NoRecoilPointer = "0x006562F0";

            public static bool NoSpread;
            public static string NoSpreadPointer = "0x366F46";
            public static string NoSpreadPointer2 = "0x85254";
            public static string NoSpreadPointer3 = "0x366F50";
            public static string NoSpreadPointer4 = "0x35BEA0";
            public static string NoSpreadPointer5 = "0x35BEAA";
            public static string NoSpreadPointer6 = "0x6CFE";

            public static bool NoRecoilAnimation;
            public static string NoRecoilAnimationPointer = "0x366EF7";

            public static bool NoGunKick;
            public static string NoGunKickPointer = "0x28206F";
            public static string NoGunKickPointer2 = "0x28207D";

            public static bool LongKnife;
            public static string LongKnifePointer = "0x007A62DC,0x18";

            public static bool RapidFire;
            public static string RapidFirePointer = "0x3669EC";

            public static string PrimaryAmmoPointer = "0x1808F00";
            public static string PrimaryAmmoSparePointer = "0x1808E88";

            public static string SecondaryAmmoPointer = "0x1808F10";
            public static string SecondaryAmmoSparePointer = "0x1808E98";
        }

        public struct Visuals
        {
            public static bool FullBright;
            public static string FullBrightPointer = "0x045FBDAC";

            public static bool Colorized;
            public static string ColorizedPointer = "0x045FBDA8";

            public static bool NoFog;
            public static string NoFogPointer = "0x022214B8,0x18";

            public static bool UnlockFPS;
            public static string UnlockFPSPointer = "0x02244818";

            public static bool ShowHud;
            public static string ShowHudPointer = "0x0221DE68,0x18";

            public static string FOVOffSet = "0x0221D364,0x18";

            public static string ScoreBoardHeadShotsPointer = "0x01C0A6EC";
            public static string ScoreBoardKillsPointer = "0x01C0A6CC";
        }

        public struct World
        {
            public static bool AntiMoveBox;
            public static string AntiMoveBoxPointer = "0x0221E054,0x18";

            public static string TimeScalePointer = "0x0203FCF4,0x18";

            public static string GravityPointer = "0x007CAEFC,0x18";
        }

        public struct Zombies
        {
            public static bool FreezeZombies;
            public static string FreezeZombiesPointer = "0x1757C3";
            public static string FreezeZombiesPointer2 = "0x1757B2";

            public static bool ZombieGravity;
            public static string ZombieGravityPointer = "0x01FD2FA8,0x18";

            public static bool FloatingZombies;
            public static string FloatingZombiesPointer = "0x01FD2FA8,0x18";
        }

        public struct Teleports
        {
            public static float CurrentX = 0;
            public static string CurrentXPointer = "0x01C08B6C";

            public static float CurrentY = 0;
            public static string CurrentYPointer = "0x01C08B68";

            public static float CurrentZ = 0;
            public static string CurrentZPointer = "0x01C08B64";

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