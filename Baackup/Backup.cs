using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using BaackupShared;

namespace Baackup
{
    public class Backup
    {
        public static void StartBackup()
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
                if (!File.Exists(file))
                {
                    Tools.Log(string.Format("Server config file \"{0}\" was not found! Removing from backup que.", file), "Warning");
                    serverfiles.Remove(file);
                }
            }

            // Now that we have a verified file list, backup said files
            foreach (string file in serverfiles)
            {
                CopyFile(file);
            }

            #endregion

            #region Copy Worlds

            if (!Configuration.WorldsContainer_Enabled)
            {
                string[] worlds = Directory.GetDirectories(Program.ServerDirectory);

                foreach (string world in worlds)
                {
                    if (File.Exists(world + "\\level.dat")) // Only copy a folder if it contains a level.dat file inside of it.
                        CopyFolder(world);
                }
            }
            else
            {
                CopyFolder(Configuration.WorldsContainer_Path); // If a worlds container folder is specified, override the check and copy everything.
            }

            #endregion

            #region Backup Plugins

            if (Configuration.Platform_IsPluginsSupported() && Configuration.Backup_PluginsEnabled)
                CopyFolder("plugins");

            #endregion

            #region Backup Logs

            if (Configuration.Backup_LogsEnabled)
                CopyFolder("logs");

            #endregion

            RCON.Send("save-on"); // Re-enable autosaving
            Tools.Log("Files copied, Compression / Final Move will continue in background.");

            #region Compress / Move

            // Compress to final directory
            if (Configuration.Save_CompressionEnabled)
            {
                CompressAndSave();
                Tools.Log("Compression complete!");
            }
            else
            {
                Tools.Log("No compression enabled, copying files");

                // Set root for file save
                string filesave = Configuration.Save_Container + "\\" /*+ id */;

                //Now Create all of the directories
                foreach (string dirPath in Directory.GetDirectories(Program.tmpsave, "*",
                    SearchOption.AllDirectories))
                    Directory.CreateDirectory(dirPath.Replace(Program.tmpsave, filesave + "\\"));

                //Copy all the files & Replaces any files with the same name
                foreach (string newPath in Directory.GetFiles(Program.tmpsave, "*.*",
                    SearchOption.AllDirectories))
                    File.Copy(newPath, newPath.Replace(Program.tmpsave, filesave + "\\"), true);
            }

            Directory.Delete(Program.tmpsave, true);

            #endregion Compress / Move

            // Tell players backup is complete
            if (Configuration.BackupMessages_FinishedEnabled)
                RCON.Send(Configuration.BackupMessages_FinishedMessage);

            // Wait one second then terminate program
            Tools.Wait(1);
            Tools.Exit(0);
        }

        #region Other Stuff

        static void CopyFile(string file)
        {
            try
            {
                File.Copy(Program.ServerDirectory + file, Program.tmpsave + file);
                Tools.Log("Copied File:" + file);
            }
            catch (Exception e)
            {
                Tools.Log("Could not copy file \"" + file + "\": " + e.Message);
            }
        }

        static void CopyFolder(string folder)
        {
            folder = Program.ServerDirectory + new DirectoryInfo(folder).Name;

            try
            {
                Tools.Log("Copying Directory: " + folder);

                //Create start directory
                Directory.CreateDirectory(Program.tmpsave + new DirectoryInfo(folder).Name);

                //Create all of the directories
                foreach (string dirPath in Directory.GetDirectories(folder, "*",
                    SearchOption.AllDirectories))
                {
                    Directory.CreateDirectory(dirPath.Replace(folder, Program.tmpsave + new DirectoryInfo(folder).Name));
                    Tools.Log(folder + ": Create subdirectory with name " + dirPath.Replace(folder, Program.tmpsave + folder));
                }

                //Copy all the files & Replaces any files with the same name
                foreach (string newPath in Directory.GetFiles(folder, "*.*",
                    SearchOption.AllDirectories))
                {
                    File.Copy(newPath, newPath.Replace(folder, Program.tmpsave + new DirectoryInfo(folder).Name), true);
                    Tools.Log(folder + ": Create file with name " + Path.GetFileName(newPath.Replace(folder, Program.tmpsave + folder)) + " inside " + Path.GetDirectoryName(newPath.Replace(folder, Program.tmpsave + folder)));
                }
            }
            catch (Exception e)
            {
                Tools.Log("Could not copy the directory \"" + folder + "\": " + e.Message);
            }
        }

        static void CompressAndSave()
        {
            ProcessStartInfo p = new ProcessStartInfo(); // Set processinfo

            p.FileName = Program.ServerDirectory + "7z.exe"; // Set filename

            // EXAMPLE FOR BELOW: a -t7z "C:\Backups\backup-{ID}.7z" "C:\backups\tmp\backup-{ID}\"
            p.Arguments = "a -t7z \"" + Program.backupcontainer + "\\" + Program.backupid + ".7z\" \"" + Program.tmpsave + "\\\""; // Set args
            p.WindowStyle = ProcessWindowStyle.Hidden; // Hde window

            Tools.Log("Compressing (This may take a long time)");

            Process x = Process.Start(p); // Start Process and wait to exit.
            x.WaitForExit();
        }

        #endregion Other Stuff
    }
}
