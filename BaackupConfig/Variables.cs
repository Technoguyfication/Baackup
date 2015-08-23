using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaackupConfig
{
    public static class Variables
    {
        // RCON
        public static bool UseRCON;
        public static string RCONPass;
        public static string RCONHostname;
        public static int RCONPort;

        // Server Platform
        public static string Platform;

        // Worlds Container
        public static bool WorldsContainerActive;
        public static string WorldsContainerPath;

        // Backup Messages
        public static bool BackupMessageActive;
        public static string BackupMessage;
        public static bool BackupFinishedMessageActive;
        public static string BackupFinishedMessage;

        // General Backup Items
        public static bool BackupPlugins;
        public static bool BackupLogs;

        // Folder Settings
        public static string BackupContainer;
        public static bool UseCustomTMPDir;
        public static string CustomTMPDir;

        // Backup Saving Settings
        public static string BackupPrefix;
        public static bool CompressBackups;

        // Configuration File Path
        public static string ConfigFilePath = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\baackupconfig.xml");
    }
}
