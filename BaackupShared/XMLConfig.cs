using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace BaackupShared
{
    internal class XMLConfig
    {
        private int ConfigVersion { get { return int.Parse(Properties.Resources.ConfigVersion); } } // int.Parse() shouldn't return an exception unless the resources get messed up.
        private string ConfigFile { get; set; }

        // RCON
        bool RCON_Enabled;
        string RCON_Password;
        string RCON_Hostname;
        int RCON_Port;

        // Server Platform
        string Platform;

        // Worlds Container
        bool WorldsContainer_Enabled;
        string WorldsContainer_Path;

        // Backup Messages
        bool BackupMessages_StartedEnabled;
        string BackupMessages_StartedMessage;

        bool BackupMessages_FinishedEnabled;
        string BackupMessages_FinishedMessage;

        // General Backup Items
        bool Backup_PluginsEnabled;
        bool Backup_LogsEnabled;

        // TMP Settings
        bool TMP_CustomEnabled;
        string TMP_CustomPath;

        // Save Settings
        string Save_Container;
        string Save_Prefix;
        bool Save_CompressionEnabled;

        public XMLConfig(string ConfigurationFile)
        {
            ConfigFile = ConfigurationFile; // Set the configuration file path

            Load(); // Any exceptions this generates should be passed to the Configuration class
        }

        #region Config Get

        private void Load()
        {
            // If the configuration file does not exist, simply return false.
            if (!File.Exists(ConfigFile))
            {
                throw new ConfigNonexistentException();
            }


        }

        public void DefaultConfig()
        {

        }

        #endregion

    }
}
