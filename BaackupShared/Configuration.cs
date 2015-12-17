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
        public static bool RCON_Enabled { get { return false; } }
        public static string RCON_Password { get; }
        public static string RCON_Hostname { get; }
        public static int RCON_Port { get; }

        // Server Platform
        public static string Platform { get; }

        // Worlds Container
        public static bool WorldsContainer_Enabled { get; }
        public static string WorldsContainer_Path { get; }

        // Backup Messages
        public static bool BackupMessages_StartedEnabled { get; }
        public static string BackupMessages_StartedMessage { get; }

        public static bool BackupMessages_FinishedEnabled { get; }
        public static string BackupMessages_FinishedMessage { get; }

        // General Backup Items
        public static bool Backup_PluginsEnabled { get; }
        public static bool Backup_LogsEnabled { get; }

        // TMP Settings
        public static bool TMP_CustomEnabled { get; }

        /// <summary>
        /// The custom save directory for the program to run inside if enabled.
        /// This will automatically return a full path.
        /// </summary>
        public static string TMP_CustomPath { get; }

        // Save Settings
        public static string Save_Container { get; }
        public static string Save_Prefix { get; }

        /// <summary>
        /// Should the program automatically compress the backups?
        /// </summary>
        public static bool Save_CompressionEnabled { get; }

        #endregion

        #region Indirect Backup Process Settings

        /// <summary>
        /// Tests whether the server supports plugins.
        /// </summary>
        /// <returns>Whether or not the sever support plugins.</returns>
        public static bool Platform_IsPluginsSupported()
        {
            return (Platform == "spigot" || Platform == "craftbukkit");
        }

        #endregion

        #region Configuration Variables

        private static XMLConfig DB;

        #endregion

        #region Methods

        public static void Initialize()
        {
            try
            {
                DB = new XMLConfig(Properties.Resources.ConfigPath.Replace("{appdata}", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)));
            }
            catch (Exception) // I just don't know what went wrong... (And I don't care either)
            {
                throw; // Rethrow
            }
        }

        #endregion
    }
}
