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

        /// <summary>
        /// The custom save directory for the program to run inside if enabled.
        /// This will automatically return a full path.
        /// </summary>
        public static string TMP_CustomPath { get; set; }

        // Save Settings
        public static string Save_Container { get; set; }
        public static string Save_Prefix { get; set; }

        /// <summary>
        /// Should the program automatically compress the backups?
        /// </summary>
        public static bool Save_CompressionEnabled { get; set; }

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
        private static bool Initialized = false;
        public static string ConfigPath
        {
            get
            {
                return Properties.Resources.ConfigPath.Replace("{appdata}", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
            }
        }

        #endregion

        #region Methods

        public static void Initialize()
        {
            Initialized = false;
            try
            {
                DB = new XMLConfig(ConfigPath);
                Initialized = true; // Once the database is loaded, we are ready to start giving out variables :D
            }
            catch (Exception) // I just don't know what went wrong... (And I don't care either)
            {
                throw; // Rethrow
            }
        }

        /// <summary>
        /// Generates a new default configuration.
        /// </summary>
        public static void ResetConfig()
        {
            RCON_Enabled = false;
            RCON_Hostname = null;
            RCON_Password = null;
            RCON_Port = 25575;

            Platform = "vanilla"; // As opposed to "spigot", "craftbukkit"

            WorldsContainer_Enabled = false;
            WorldsContainer_Path = null;

            BackupMessages_StartedEnabled = false;
            BackupMessages_StartedMessage = "say Server backup starting... You may experience slight lag..";
            BackupMessages_FinishedEnabled = false;
            BackupMessages_FinishedMessage = "say Server backup completed.";

            Backup_PluginsEnabled = false;
            Backup_LogsEnabled = false;

            TMP_CustomEnabled = false;
            TMP_CustomPath = null;

            Save_Container = null;
            Save_Prefix = "Baackup";
            Save_CompressionEnabled = true;
        }

        public static void SaveConfig()
        {
            // Save
            if (Initialized)
                DB.Save();
            else
                throw new ConfigNotInitializedException();
        }

        #endregion
    }
}
