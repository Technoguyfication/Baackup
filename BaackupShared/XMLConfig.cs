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
        #region XMLConfig Data

        private int ConfigVersion { get { return int.Parse(Properties.Resources.ConfigVersion); } } // int.Parse() shouldn't return an exception unless the resources get messed up.
        private string ConfigFile { get; set; }

        #endregion

        #region Configuration Value Bases

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

        #endregion

        public XMLConfig(string ConfigurationFile)
        {
            ConfigFile = ConfigurationFile; // Set the configuration file path

            Load(); // Any exceptions this generates should be passed to the Configuration class
        }

        #region Config Get

        private void Load()
        {
            int _version; // Temporary version to be loaded from XML file. If this isn't equal to the program version, config will be reset.

            // If the configuration file does not exist, simply return false.
            if (!File.Exists(ConfigFile))
            {
                throw new ConfigNonexistentException();
            }

            try
            {
                using (XmlReader reader = XmlReader.Create(ConfigFile))
                {
                    reader.ReadToFollowing("BaackupConfig"); // Start at beginning of document
                    _version = int.Parse(reader.GetAttribute("version")); // Set the temporary version.
                    reader.Read(); // Move to the dataset

                    RCON_Enabled = bool.Parse(reader.ReadElementContentAsString("RCON_Enabled", "")); // RCON Enabled
                    RCON_Hostname = reader.ReadElementContentAsString("RCON_Hostname", ""); // RCON Hostname
                    RCON_Password = reader.ReadElementContentAsString("RCON_Password", ""); // RCON Password
                    RCON_Port = int.Parse(reader.ReadElementContentAsString("RCON_Port", "")); // RCON Port

                    Platform = reader.ReadElementContentAsString("Platform", ""); // Server Platform

                    WorldsContainer_Enabled = bool.Parse(reader.ReadElementContentAsString("WorldsContainer_Enabled", "")); // Worlds Container Enabled
                    WorldsContainer_Path = reader.ReadElementContentAsString("WorldsContainer_Path", ""); // Worlds Container Path

                    BackupMessages_StartedEnabled = bool.Parse(reader.ReadElementContentAsString("BackupMessages_StartedEnabled", "")); // Started Backup Message Enabled
                    BackupMessages_StartedMessage = reader.ReadElementContentAsString("BackupMessages_StartedMessage", ""); // Started Backup Message
                    BackupMessages_FinishedEnabled = bool.Parse(reader.ReadElementContentAsString("BackupMessages_FinishedEnabled", "")); // Finished Backup Message Enabled
                    BackupMessages_FinishedMessage = reader.ReadElementContentAsString("BackupMessages_FinishedMessage", ""); // Finished Backup Message

                    Backup_PluginsEnabled = bool.Parse(reader.ReadElementContentAsString("Backup_PluginsEnabled", "")); // Plugins Enabled
                    Backup_LogsEnabled = bool.Parse(reader.ReadElementContentAsString("Backup_LogsEnabled", "")); // Logs Enabled

                    TMP_CustomEnabled = bool.Parse(reader.ReadElementContentAsString("TMP_CustomEnabled", "")); // Custom TMP Folder Enabled
                    TMP_CustomPath = reader.ReadElementContentAsString("TMP_CustomPath", ""); // Custom TMP Folder Path

                    Save_Container = reader.ReadElementContentAsString("Save_Container", ""); // Save Container
                    Save_CompressionEnabled = bool.Parse(reader.ReadElementContentAsString("Save_CompressionEnabled", "")); // Compression Enabled
                    Save_Prefix = reader.ReadElementContentAsString("Save_Prefix", ""); // Save Prefix
                }
            }
            catch (XmlException) // Is the XML file invalid?
            {
                throw new ConfigInvalidException(); // Throw Invalid Config File exception.
            }
            catch (Exception) // Did something magical go wrong?
            {
                throw; // Rethrow exception.
            }

            if (!(_version == ConfigVersion)) // Is the config the wrong version?
            {
                throw new ConfigResetException(); // Throw ConfigReset exception.
            }
        }

        public void DefaultConfig()
        {

        }

        #endregion

    }
}
