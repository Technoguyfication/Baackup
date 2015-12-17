using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using BaackupShared;

namespace Baackup
{
    public class Backup
    {
        public static void StartBackup(BaackupIO IO)
        {
            // Autosave the server if possible
            if (Configuration.RCON_Enabled) // We don't _really_ need to test for RCON support, but this saves the uselss log entry.
            {
                RCON.Send("save-off"); // Disable Autosave
                RCON.Send("save-all"); // Perform Manual Save

                Tools.Log("Waiting 3 seconds for server to perform manual save.");
                Tools.Wait(3);
            }

            // Inform players that backup is starting
            if (Configuration.BackupMessages_StartedEnabled)
                RCON.Send(Configuration.BackupMessages_StartedMessage);

            #region Copy Server Configuration Files

            // Make a list of all the server files.
            List<string> serverfiles = new List<string> { // We're going to have to assume that the server runs MC1.7.10 or above.
                "server.properties",
                "ops.json",
                "whitelist.json",
                "banned-ips.json",
                "banned-players.json"
            };

            // Add all the modded ones if applicable
            if (Configuration.Platform_IsPluginsSupported())
            {
                serverfiles.AddRange(new List<string> { "permissions.yml", "commands.yml", "help.yml", "bukkit.yml" });
            }

            // Add spigot's file if the server is spigot
            if (Configuration.Platform == "spigot")
                serverfiles.Add("spigot.yml");

            // Make sure all these files actually exist
            foreach (string file in serverfiles)
            {
                if (!IO.ServerFileExists(file))
                {
                    Tools.Log(string.Format("Server config file \"{0}\" was not found! Removing from backup que.", file), "Warning");
                    serverfiles.Remove(file);
                }
            }

            // Now that we have a verified file list, backup said files
            foreach (string file in serverfiles)
                CopyFile(file);

            #endregion

            #region Copy Worlds

            if (!Configuration.WorldsContainer_Enabled)
            {
                List<string> worlds = new List<string>(); // Make a new list
                worlds.AddRange(Directory.GetDirectories(Program.ServerDirectory)); // Populate the list with the folders in the server folder

                // Remove any non-world entries
                foreach (string world in worlds)
                {
                    if (!IO.ServerFileExists(string.Format("{0}\\level.dat", world))) // Test for the "level.dat" file
                        worlds.Remove(world);
                }

                // Backup the verified worlds list
                foreach (string world in worlds)
                    CopyFolder(world);

            }
            else
            {
                CopyFolder(Configuration.WorldsContainer_Path); // If a worlds container folder is specified, override the check and copy everything.
            }

            #endregion

            #region Copy Plugins

            if (Configuration.Platform_IsPluginsSupported() && Configuration.Backup_PluginsEnabled)
                CopyFolder("plugins");

            #endregion

            #region Copy Logs

            if (Configuration.Backup_LogsEnabled)
                CopyFolder("logs");

            #endregion

            RCON.Send("save-on"); // Re-enable autosaving
            Tools.Log("Files copied, Compression / Final Move will continue in background.");

            #region Compress / Move

            if (!Directory.Exists(Program.BackupTMPSave))
            {
                Tools.Log("We could not locate the temporary backup directory! Baackup can no longer continue to function, exiting.", "Fatal");
                Tools.Exit(3);
            }

            // Send to final directory
            if (Configuration.Save_CompressionEnabled)
                CompressAndSave();
            else
                SaveOnly();

            Tools.Log("Removing temporary files...");

            Directory.Delete(Program.BackupTMPSave, true); // Dete temporary files

            #endregion Compress / Move

            // Tell players backup is complete
            if (Configuration.BackupMessages_FinishedEnabled)
                RCON.Send(Configuration.BackupMessages_FinishedMessage);

            // Wait one second then terminate program
            Tools.Wait(1);
            Tools.Log("Shutting down...");
            Tools.Exit(0);
        }

        #region Other Stuff

        private static void CopyFile(string file)
        {
            File.Copy(string.Format("{0}\\{1}", Program.ServerDirectory, file), string.Format("{0}\\{1}", Program.BackupTMPSave, file));
        }

        private static void CopyFolder(string folder)
        {
            CopyFolderStructure(string.Format("{0}\\{1}", Program.ServerDirectory, folder), Program.BackupTMPSave);
        }

        private static void CompressAndSave()
        {
            if (!File.Exists(Program.ServerDirectory + "7z.exe"))
            {
                Tools.Log("Could not locate 7z.exe! We can't compress the files, copying files to save location instead.", "Error");
                SaveOnly();
                return;
            }

            ProcessStartInfo ZipStartInfo = new ProcessStartInfo(); // Set processinfo

            ZipStartInfo.FileName = Program.ServerDirectory + "7z.exe"; // Set filename

            // Example args: a -t7z "C:\Backups\1-2-3.1234-Baackup.7z" "C:\Temp\Baackup\1-2-3.1234-Baackup\"
            ZipStartInfo.Arguments = string.Format("a -t7z \"{0}\\{1}-{2}\" \"{3}\"", Configuration.Save_Container, Program.BackupID, Configuration.Save_Prefix, Program.BackupTMPSave);
            ZipStartInfo.WindowStyle = ProcessWindowStyle.Hidden; // Hide window

            Tools.Log("Beginning compression.. (This may take a while)");

            try
            {
                Process ZipProcess = Process.Start(ZipStartInfo); // Start Process and wait to exit.
                ZipProcess.WaitForExit();
            }
            catch (Exception) // 7-zip has died in some way
            {
                Tools.Log("7z.exe failed to execute properly! Copying files to save location instead.", "Error");
                SaveOnly();
                return;
            }

            Tools.Log("Compression complete!");
        }

        private static void SaveOnly()
        {
            string savecontainer = string.Format("{0}\\{1}", Path.GetFullPath(Configuration.Save_Container), Program.BackupID);

            // Create the save container
            Directory.CreateDirectory(savecontainer);

            CopyFolderStructure(Program.BackupTMPSave, savecontainer);

            Tools.Log("Backup files copied to backup location!");
        }

        private static void CopyFolderStructure(string source, string dest)
        {
            // Create directory structure first
            foreach (string folder in Directory.GetDirectories(source, "*", SearchOption.AllDirectories))
            {
                Directory.CreateDirectory(string.Format("{0}\\{1}", dest, folder));
            }

            // Now copy the files
            foreach (string file in Directory.GetFiles(source, "*", SearchOption.AllDirectories))
            {
                File.Copy(file, string.Format("{0}\\{1}", dest, file));
            }
        }

        #endregion Other Stuff
    }
}
