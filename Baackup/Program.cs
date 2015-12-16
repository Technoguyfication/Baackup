using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Baackup
{
    class Program
    {
        #region Class Variables

        #region Backup Process Settings

        // RCON
        public static bool Config_RCON_Enabled { get; set; }
        public static string Config_RCON_Password { get; set; }
        public static string Config_RCON_Hostname { get; set; }
        public static int Config_RCON_Port { get; set; }

        // Server Platform
        public static string Config_Platform { get; set; }


        // Worlds Container
        public static bool Config_WorldsContainer_Enabled { get; set; }
        public static string Config_WorldsContainer_Path { get; set; }

        // Backup Messages
        public static bool Config_BackupMessages_StartedEnabled { get; set; }
        public static string Config_BackupMessages_StartedMessage { get; set; }

        public static bool Config_BackupMessages_FinishedEnabled { get; set; }
        public static string Config_BackupMessages_FinishedMessage { get; set; }

        // General Backup Items
        public static bool Config_Backup_PluginsEnabled { get; set; }
        public static bool Config_Backup_ConfigEnabled { get; set; }

        // TMP Settings
        public static bool Config_TMP_CustomEnabled { get; set; }
        public static string Config_TMP_CustomPath { get; set; }

        // Save Settings
        public static string Config_Save_Container { get; set; }
        public static string Config_Save_Prefix { get; set; }
        public static bool Config_Save_CompressionEnabled { get; set; }

        #endregion

        // Config path
        public static string Config_File = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + Properties.Resources.ConfigFileName);

        // Execution path
        public static string Executable;

        // TMP Settings
        public static string BackupID;

        #endregion Class Variables

        static void Main(string[] args)
        {
            Tools.Title(); // Basic Title

            // Attempt to get the executable path from the launch args
            try
            {
                Executable = args[0] + '\\';
            }
            catch (Exception e)
            {
                Tools.Print("There was an issue starting the program!\nAre you sure you started it with the Batch script?\n\nError details: " + e.Message);
                Tools.Pause();
                Tools.Exit(1);
            }

            new Program().Start(); // New Instance of the program, then start.

            Tools.Exit(1); // If for some reason we end up back here, there's an error so we exit with '1'
        }

        public void Start()
        {
            // Display title and intro text
            Tools.Print("Baackup Initialized...");
            Tools.Print("Running on path: " + Executable);

            if (XMLConfig.ConfigExists())
            {
                // Load program configuration from file
                XMLConfig.LoadConfig();
                Tools.NewBackupID();
                if (usecustomtmpdir)
                    tmpsave = customtmpdir + "\\" + backupid + "\\";
                else
                    tmpsave = backupcontainer + "\\tmp\\" + backupid + "\\";

                // Check that we are running in a server directory.
                if (!IOStatus.FileExists("server.properties", true))
                {
                    Tools.Print("We did not detect you are running in a server directory!\nPlease but the batch file in your root directory\nwith the jar/exe file and server.properties!");
                    Tools.Pause();
                    Tools.Exit(2);
                }
                else
                {
                    Tools.Log("Found server.properties!");

                    // Create tmp dir
                    if (!IOStatus.FolderExists(Program.tmpsave, false))
                        Directory.CreateDirectory(Program.tmpsave);

                    Backup.StartBackup();
                }
            }
            else
            {
                Tools.Print("Please use the configuration tool to generate a server configuration file.");
                Tools.Pause();
                Tools.Exit();
            }
        }
    }
}
