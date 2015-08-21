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

        // Transfer settings to / from GUI

        public static void UpdateConfigSettings()
        {
            MainWindow Main = MainWindow();
            
            // RCON
            Variables.UseRCON = Main.UseRCONBox.Checked;
            Variables.RCONHostname = Main.RCONHostnameTextBox.Text;
            Variables.RCONPass = Main.RCONPasswordTextBox.Text;
            Variables.RCONPort = int.Parse(Main.RCONPortTextBox.Text);

            // Server Platform
            if (Main.Platform_CraftBukkit.Checked)
                Variables.Platform = "craftbukkit";
            else if (Main.Platform_Spigot.Checked)
                Variables.Platform = "spigot";
            else
                Variables.Platform = "vanilla";

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
            Variables.UseCustomTMPDir = Main.TmpSaveLocationEnabledBox.Checked;
            Variables.CustomTMPDir = Main.TmpSaveLocationTextBox.Text;

            // Backup Saving
            Variables.BackupPrefix = Main.BackupPrefixLabel.Text;
            Variables.CompressBackups = Main.CompressBackupsBox.Checked;
            
        }

        public static void SendConfigSettings()
        {
            MainWindow Main = new MainWindow();

            // RCON
            Main.UseRCONBox.Checked = Variables.UseRCON;
            Main.RCONHostnameTextBox.Text = Variables.RCONHostname;
            Main.RCONPasswordTextBox.Text = Variables.RCONPass;
            Main.RCONPortLabel.Text = Variables.RCONPort.ToString();

            // Server Platform
            if (Variables.Platform == "spigot")
            {
                Main.Platform_Spigot.Checked = true;

                Main.Platform_Vanilla.Checked = false;
                Main.Platform_CraftBukkit.Checked = false;
            }
            else if (Variables.Platform == "craftbukkit")
            {
                Main.Platform_CraftBukkit.Checked = true;

                Main.Platform_Spigot.Checked = false;
                Main.Platform_Vanilla.Checked = false;
            }
            else
            {
                Main.Platform_Vanilla.Checked = true;

                Main.Platform_Spigot.Checked = false;
                Main.Platform_CraftBukkit.Checked = false;
            }

            // Worlds container
            Main.WorldsContainerButton.Checked = Variables.WorldsContainerActive;
            Main.WorldsContainerPathTextBox.Text = Variables.WorldsContainerPath;

            // Backup Messages
            Main.BackupStartedMessageEnabledBox.Checked = Variables.BackupMessageActive;
            Main.BackupStartedMessageTextBox.Text = Variables.BackupMessage;

            Main.BackupFinishedMessageEnabledBox.Checked = Variables.BackupFinishedMessageActive;
            Main.BackupFinishedMessageTextBox.Text = Variables.BackupFinishedMessage;

            // Backup items
            Main.BackupPluginsBox.Checked = Variables.BackupPlugins;
            Main.BackupLogsBox.Checked = Variables.BackupLogs;

            // Folders
            Main.BackupContainerTextBox.Text = Variables.BackupContainer;
            Main.TmpSaveLocationEnabledBox.Checked = Variables.UseCustomTMPDir;
            Main.TmpSaveLocationTextBox.Text = Variables.CustomTMPDir;

            // Backup Saving
            Main.BackupPrefixLabel.Text = Variables.BackupPrefix;
            Main.CompressBackupsBox.Checked = Variables.CompressBackups;
        }
    }
}
