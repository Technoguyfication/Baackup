using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Baackup
{
    public class Backup
    {

        public static void StartBackup()
        {
            // Disable autosaving and save level
            RCON.Send("save-off");
            RCON.Send("save-all");
            Tools.Log("Wait 3 secs...");
            Tools.Wait(3);

            // Warn players
            if (Program.backupmsgactive)
                RCON.Send(Program.backupmsg);

            // Copy Server properties and other config files
            CopyFile("server.properties");
            CopyFile("ops.json");
            CopyFile("whitelist.json");
            CopyFile("banned-ips.json");
            CopyFile("banned-players.json");

            if (Program.platform == "spigot")
            {
                CopyFile("spigot.yml");
                CopyFile("bukkit.yml");
                CopyFile("commands.yml");
                CopyFile("help.yml");
            }

            if (Program.platform == "craftbukkit")
            {
                CopyFile("permissions.yml");
                CopyFile("bukkit.yml");
                CopyFile("commands.yml");
                CopyFile("help.yml");
            }

            // Backup logs
            if (Program.backuplogs)
                CopyFolder("logs");

            // Backup worlds
            if (!Program.worldscontaineractive)
            {
                string[] serverfolders = { "crash-reports", "plugins", "logs", "mods" };
                string[] worlds = Directory.GetDirectories(Program.exepath);

                foreach (string world in worlds)
                {
                    foreach (string serverfolder in serverfolders)
                    {
                        if (world == serverfolder)
                            worlds = worlds.Where(val => val != world).ToArray();
                    }
                }

                foreach (string world in worlds)
                    CopyFolder(world);
            }
            else
            {
                CopyFolder(Program.worldscontainerpath);
            }

            // Backup plugins
            if ((Program.platform == "spigot" || Program.platform == "craftbukkit") && Program.backupplugins)
                CopyFolder("plugins");



            // Backup complete
            RCON.Send("save-on");
            Tools.Log("Backup complete!");
            Tools.Wait(1);
            Tools.Exit(0);

        }

        static void CopyFile(string file)
        {
            File.Copy(Program.exepath + file, Program.tmpsave + file);
            Tools.Log("Copied File:" + file);
        }

        static void CopyFolder(string folder)
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

    }
}
