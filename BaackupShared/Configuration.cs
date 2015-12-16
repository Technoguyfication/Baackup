using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaackupShared
{
    public static class Configuration
    {
        #region Backup Process Settings

        // RCON
        public static bool RCON_Enabled { get; set; }
        public static string RCON_Password { get; set; }
        public static string RCON_Hostname { get; set; }
        public static int RCON_Port { get; set; }

        // Server Platform
        public static string Platform { get; set; }

        // Worlds Container
        public static bool WorldsContainer_Enabled { get; set; }
        public static string WorldsContainer_Path { get; set; }

        // Backup Messages
        public static bool BackupMessages_StartedEnabled { get; set; }
        public static string BackupMessages_StartedMessage { get; set; }

        public static bool BackupMessages_FinishedEnabled { get; set; }
        public static string BackupMessages_FinishedMessage { get; set; }

        // General Backup Items
        public static bool Backup_PluginsEnabled { get; set; }
        public static bool Backup_LogsEnabled { get; set; }

        // TMP Settings
        public static bool TMP_CustomEnabled { get; set; }
        public static string TMP_CustomPath { get; set; }

        // Save Settings
        public static string Save_Container { get; set; }
        public static string Save_Prefix { get; set; }
        public static bool Save_CompressionEnabled { get; set; }

        #endregion

        #region Indirect Backup Process Settings

        public static bool Platform_IsPluginsSupported()
        {
            return (Platform == "spigot" || Platform == "craftbukkit");
        }

        #endregion
    }
}
