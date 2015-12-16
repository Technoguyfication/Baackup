using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Baackup
{
    public class Backup
    {
        public static void StartBackup()
        {
            // Backup start
            RCON.Send("save-off"); // Disable Autosave
            RCON.Send("save-all"); // Perform Manual Save

            Tools.Log("Waiting 3 seconds for server to finish saving...");
            Tools.Wait(3);

            // Inform players that backup is starting
            if (Program.backupmsgactive)
                RCON.Send(Program.backupmsg);

            #region Copy Server Configuration Files

            string[] serverfiles = { "server.properties", "ops.json", "whitelist.json", "banned-ips.json", "banned-players.json" }; // -- A wild array has appeared! --

            foreach (string file in serverfiles) // Copy each file from the array
                CopyFile(file);

            if (Program.platform == "spigot")
            {
                string[] spigotfiles = { "spigot.yml", "bukkit.yml", "commands.yml", "help.yml", "permissions.yml" }; // Yay it's an array

                foreach (string file in spigotfiles) // Copy each file from the array
                    CopyFile(file);
            }

            if (Program.platform == "craftbukkit")
            {
                string[] bukkitfiles = { "permissions.yml", "bukkit.yml", "commands.yml", "help.yml" }; // Yay it's another array

                foreach (string file in bukkitfiles) // Copy each file from the array
                    CopyFile(file);
            }

            #endregion

            #region Copy Worlds

            if (!Program.worldscontaineractive)
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
                CopyFolder(Program.worldscontainerpath); // If a worlds container folder is specified, override the check and copy everything.
            }

            #endregion

            #region Backup Plugins

            if ((Program.platform == "spigot" || Program.platform == "craftbukkit") && Program.backupplugins)
                CopyFolder("plugins");

            #endregion

            #region Backup Logs

            if (Program.backuplogs)
                CopyFolder("logs");

            #endregion

            // Copyfiles end
            RCON.Send("save-on");
            Tools.Log("Done copying files!");

            #region Compress / Move

            // Compress to final directory
            if (Program.compressbackups)
            {
                CompressAndSave();
                Tools.Log("Compression complete!");
            }

            if (!Program.compressbackups)
            {
                Tools.Log("No compression enabled, copying files");

                // Set root for file save
                string filesave = Program.backupcontainer + "\\" + Program.backupid;

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
            if (Program.backupfinishmsgactive)
                RCON.Send(Program.backupfinishmsg);

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
