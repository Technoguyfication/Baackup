using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaackupConfig
{
    public static class Variables
    {
        #region Config Options

        #region Server Settings

        // RCON
        public static bool UseRCON;
        public static string RCONPass;
        public static string RCONHostname;
        public static int RCONPort;

        // Server Platform
        public static string Platform;

        #endregion

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

        #endregion

        // Configuration File Path
        public static string ConfigFilePath = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\baackupconfig.xml");

        public static void UpdateConfigSettings()
        {
            MainWindow Main = new MainWindow();

            // RCON
            Variables.UseRCON = false;
            Variables.RCONHostname = "127.0.0.1";
            Variables.RCONPass = null;
            Variables.RCONPort = 25575;

            // Server Platform
            Variables.Platform = "vanilla";

            // Worlds container
            Variables.WorldsContainerActive = Main.WorldsContainerButton.Checked;
            Variables.WorldsContainerPath = Main.WorldsContainerPathTextBox.Text;

            // Backup Messages
            Variables.BackupMessageActive = false;
            Variables.BackupMessage = "say The server is backing up! Prepare for some slight lag!";

            Variables.BackupFinishedMessageActive = false;
            Variables.BackupFinishedMessage = "say Server Backup Completed!";

            // Backup items
            Variables.BackupPlugins = false;
            Variables.BackupLogs = true;

            // Folders
            Variables.BackupContainer = null;
            Variables.UseCustomTMPDir = false;
            Variables.CustomTMPDir = null;

            // Backup Saving
            Variables.BackupPrefix = null;
            Variables.CompressBackups = true;
        }
    }
}
