using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace Baackup
{
    public class XMLConfig
    {
        public static void LoadConfig()
        {

            try // If anything goes wrong, this should keep it from breaking the whole program
            {
                using (XmlReader reader = XmlReader.Create(Program.configfile))
                {
                    reader.ReadToFollowing("Config"); // Here we specify the config.. not that there's anything else right now
                    reader.MoveToFirstAttribute();
                    Program.usercon = Boolean.Parse(reader.Value.ToLower()); // Use rcon?
                    reader.MoveToNextAttribute();
                    Program.rconpass = reader.Value; // Rcon password
                    reader.MoveToNextAttribute();
                    Program.rconhostname = reader.Value; // Rcon hostname
                    reader.MoveToNextAttribute();
                    Program.rconport = int.Parse(reader.Value); // Rcon port
                    reader.MoveToNextAttribute();
                    Program.worldscontaineractive = Boolean.Parse(reader.Value.ToLower()); // Use worlds container?
                    reader.MoveToNextAttribute();
                    Program.worldscontainerpath = reader.Value; // Path to worlds container
                    reader.MoveToNextAttribute();
                    Program.backupmsgactive = Boolean.Parse(reader.Value.ToLower()); // Use backup server broadcast?
                    reader.MoveToNextAttribute();
                    Program.backupmsg = reader.Value; // Backup server broadcast message?
                    reader.MoveToNextAttribute();
                    Program.backupplugins = Boolean.Parse(reader.Value.ToLower());  // Backup plugins? (Spigot and Bukkit only)
                    reader.MoveToNextAttribute();
                    Program.backuplogs = Boolean.Parse(reader.Value.ToLower()); // Backup server logs?
                    reader.MoveToNextAttribute();
                    Program.backupcontainer = reader.Value; // Where to save the backups?
                    reader.MoveToNextAttribute();
                    Program.usecustomtmpdir = Boolean.Parse(reader.Value.ToLower()); // Do we use a custom tmp dir? (Default is {Backups save path}\tmp
                    reader.MoveToNextAttribute();
                    Program.customtmpdir = reader.Value; // If the above is enabled, where is this dir you want?
                    reader.MoveToNextAttribute();
                    Program.backupscustomidprefix = reader.Value; // Do you want to prefix your backups?
                    reader.MoveToNextAttribute();
                    Program.compressbackups = Boolean.Parse(reader.Value.ToLower()); // Do you want to compress your backups?
                    reader.MoveToNextAttribute();
                    Program.platform = reader.Value; // Platform? (Spigot/CraftBukkit/Vanilla)
                }
            }
            catch (Exception e)
            {
                // If something goes wrong, maybe this will help.
                Tools.Print("Error:\n" + e.Message + Environment.NewLine + Program.configfile);
                Tools.Pause("Press any key to terminate");
                if (e.Message.ToLower().StartsWith("could not find file"))
                    Tools.Exit(2);
                else
                    Tools.Exit(1);
            }
        }

        public static void CreateConfig() // This is the part where we write the config values to a file. I don't want to comment this shit.
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;

            try
            {
                XmlWriter writer = XmlWriter.Create(Program.configfile, settings);
                writer.WriteStartDocument();
                writer.WriteComment("This is the config file for Baackup, NEVER share or upload this file anywhere on the internet as it could contain your server's RCON password and info in it. However, feel free to edit this file to your liking.");
                writer.WriteStartElement("Config");
                writer.WriteAttributeString("usercon", Program.usercon.ToString());
                writer.WriteAttributeString("rconpass", Program.rconpass);
                writer.WriteAttributeString("rconhostname", Program.rconhostname);
                writer.WriteAttributeString("rconport", Program.rconport.ToString());
                writer.WriteAttributeString("worldscontaineractive", Program.worldscontaineractive.ToString());
                writer.WriteAttributeString("worldscontainerpath", Program.worldscontainerpath);
                writer.WriteAttributeString("backupmsgactive", Program.backupmsgactive.ToString());
                writer.WriteAttributeString("backupmsg", Program.backupmsg);
                writer.WriteAttributeString("backupplugins", Program.backupplugins.ToString());
                writer.WriteAttributeString("backuplogs", Program.backuplogs.ToString());
                writer.WriteAttributeString("backupcontainer", Program.backupcontainer);
                writer.WriteAttributeString("usecustomtmpdir", Program.usecustomtmpdir.ToString());
                writer.WriteAttributeString("customtmpdir", Program.customtmpdir);
                writer.WriteAttributeString("backupscustomidprefix", Program.backupscustomidprefix);
                writer.WriteAttributeString("compressbackups", Program.compressbackups.ToString());
                writer.WriteAttributeString("platform", Program.platform);
                writer.WriteEndElement();
                writer.WriteEndDocument();

                writer.Flush();
                writer.Close();
            }
            catch (Exception e)
            {
                Tools.Print("Error:\n" + e.Message);
                Tools.Pause("Press any key to terminate.");
                Tools.Exit(1);
            }
        }

        public static void GenerateConfig()
        {
            Tools.Title("Temporary config generator");
            Tools.Print("This is a temporary config generator.\nEventually we will have a GUI interface for config editing.");
            Tools.Pause("Press any key to  begin setup.");
            Tools.Clear();
            Tools.Print("Would you like to use RCON integration with your server? (Y/N)");
            Program.usercon = Input.GetKeyTF();
            Tools.Clear();
            if (!(Program.usercon))
            {
                Program.rconpass = null;
                Program.rconhostname = null;
                Program.rconport = 0;
            }
            else
            {
                // Rcon settings
                Tools.Print("Please enter your server's RCON Password.");
                Program.rconpass = Input.GetInput();
                Tools.Clear();

                Tools.Print("Please enter your server's hostname. (127.0.0.1 for local).");
                Program.rconhostname = Input.GetInput("127.0.0.1");
                Tools.Clear();

                Tools.Print("Please enter your server's RCON port. (Default: 25575)");
                Program.rconport = Input.GetNum(2555);
                Tools.Clear();
            }

            if (Program.usercon)
            {
                Tools.Print("Do you want to broadcast a message when your server starts a backup? (Y/N)");
                Program.backupmsgactive = Input.GetKeyTF();
                Tools.Clear();

                if (Program.backupmsgactive)
                {
                    Tools.Print("What message / command do you want to run when a backup is started?\nDefault: \"say The server is beginning a backup! There may be some slight lag...\"");
                    Program.backupmsg = Input.GetInput("say The server is beginning a backup! There may be some slight lag...");
                    Tools.Clear();
                }
                else
                {
                    Program.backupmsg = null;
                }
                Tools.Print("Do you want to broadcast a message when your server finishes a backup?");
                Program.backupfinishmsgactive = Input.GetKeyTF();
                Tools.Clear();

                if (Program.backupfinishmsgactive)
                {
                    Tools.Print("What message / command do you want to run when a backup is finished?\nDefault: \"say Server backup complete!\"");
                    Program.backupfinishmsg = Input.GetInput("say Server backup complete!");
                    Tools.Clear();
                }
                else
                {
                    Program.backupfinishmsg = null;
                }
            }
            else
            {
                Program.backupmsgactive = false;
                Program.backupmsg = null;
                Program.backupfinishmsgactive = false;
                Program.backupfinishmsg = null;
            }

            Tools.Print("Would you like to backup server logs? (Y/N)");
            Program.backuplogs = Input.GetKeyTF();
            Tools.Clear();

            Tools.Print("What is the platform of your server?\n(C for CraftBukkit, S for Spigot, V for Vanilla)");
            while (true)
            {
                char platform;

                platform = Input.GetKey();

                if (platform == 'c')
                    Program.platform = "craftbukkit";
                else if (platform == 's')
                    Program.platform = "spigot";
                else if (platform == 'v')
                    Program.platform = "vanilla";

                if (!(Program.platform == null))
                    break;
            }
            Tools.Clear();

            if (Program.platform == "spigot" || Program.platform == "craftbukkit")
            {
                Tools.Print("Would you like to back up your plugins folder? (Y/N)");
                Program.backupplugins = Input.GetKeyTF();
                Tools.Clear();

                Tools.Print("Do you use a Worlds Container on your server? (Y/N)");
                Program.worldscontaineractive = Input.GetKeyTF();
                Tools.Clear();

                if (Program.worldscontaineractive)
                {
                    Tools.Print("From the root of your server, what is the path to your worlds container?");
                    Program.worldscontainerpath = Input.GetInput();
                    Tools.Clear();
                }
                else
                {
                    Program.worldscontainerpath = "";
                }
            }
            else
            {
                Program.backupplugins = false;
                Program.worldscontaineractive = false;
                Program.worldscontainerpath = null;
            }

            Tools.Print("Where do you want to save your backups?\n(C:\\Backups)");
            Program.backupcontainer = Input.GetInput();
            Tools.Clear();

            Tools.Print("Would you like to use a custom tmp directory? (Y/N)\nDefault: {Backup Save Path}\\Tmp");
            Program.usecustomtmpdir = Input.GetKeyTF();
            Tools.Clear();

            if (Program.usecustomtmpdir)
            {
                Tools.Print("What folder would you like to use as a temporary directory?");
                Program.customtmpdir = Input.GetInput();
                Tools.Clear();
            }
            else
            {
                Program.customtmpdir = Program.backupcontainer + "\\tmp";
            }

            Tools.Print("What would you like to prefix your backup archives with?\nDefault: mcserverbackup");
            Program.backupscustomidprefix = Input.GetInput("mcserverbackup");
            Tools.Clear();

            Tools.Print("Would you like to compress all your backups with 7-Zip compression? (Y/N)");
            Program.compressbackups = Input.GetKeyTF();
            Tools.Clear();

            // Done with setup, save now
            CreateConfig();
        }

        public static bool ConfigExists()
        {
            if (File.Exists(Program.configfile))
                return true;
            else
                return false;
        }
    }
}
