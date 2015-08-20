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
            Variables.UseRCON = Main.UseRCONBox.Checked;
            Variables.RCONHostname = Main.RCONHostnameTextBox.Text;
            Variables.RCONPass = Main.RCONPasswordTextBox.Text;
            Variables.RCONPort = int.Parse(Main.RCONPortTextBox.Text);

            // Server Platform
            if (Main.Platform_Vanilla.Checked)
                Variables.Platform = "vanilla";
            else if (Main.Platform_Spigot.Checked)
                Variables.Platform = "spigot";
            else
                Variables.Platform = "craftbukkit";

            // Worlds container
            Variables.WorldsContainerActive = Main.WorldsContainerButton.Checked;
            Variables.WorldsContainerPath = Main.WorldsContainerPathTextBox.Text;

            // Backup Messages
            Variables.BackupMessageActive = Main.BackupStartedMessageEnabledBox.Checked;
            Variables.BackupMessage = Main.BackupStartedMessageTextBox.Text;

            Variables.BackupFinishedMessageActive = Main.BackupFinishedMessageEnabledBox.Checked;
            Variables.BackupFinishedMessage = Main.BackupFinishedMessageTextBox.Text;

            // Backup items
            Variables.BackupPlugins = Main.BackupPluginsBox.Checked;
            Variables.BackupLogs = Main.BackupLogsBox.Checked;

            // Folders
            Variables.BackupContainer = Main.BackupContainerTextBox.Text;
            Variables.UseCustomTMPDir = false;
            Variables.CustomTMPDir = null;

            // Backup Saving
            Variables.BackupPrefix = null;
            Variables.CompressBackups = true;
            
        }

        public static void SendConfigSettings()
        {

        }
    }
}
