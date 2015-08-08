using System;
using System.IO;
using System.Xml;

namespace Baackup
{
    internal class XMLConfig
    {
        public static bool ConfigExists()
        {
            if (File.Exists(new Program().configfile))
                return true;
            else
                return false;
        }

        public static void CreateConfig() // This is the part where we write the config values to a file. I don't want to comment this shit.
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;

            try
            {
                XmlWriter writer = XmlWriter.Create(new Program().configfile, settings);
                writer.WriteStartDocument();
                writer.WriteComment("This is the config file for Baackup, NEVER share or upload this file anywhere on the internet as it could contain your server's RCON password and info in it. However, feel free to edit this file to your liking.");
                writer.WriteStartElement("Config");
                writer.WriteAttributeString("usercon", new Program().usercon.ToString());
                writer.WriteAttributeString("rconpass", new Program().rconpass);
                writer.WriteAttributeString("rconhostname", new Program().rconhostname);
                writer.WriteAttributeString("rconport", new Program().rconport.ToString());
                writer.WriteAttributeString("worldscontaineractive", new Program().worldscontaineractive.ToString());
                writer.WriteAttributeString("worldscontainerpath", new Program().worldscontainerpath);
                writer.WriteAttributeString("backupmsgactive", new Program().backupmsgactive.ToString());
                writer.WriteAttributeString("backupmsg", new Program().backupmsg);
                writer.WriteAttributeString("backupplugins", new Program().backupplugins.ToString());
                writer.WriteAttributeString("backuplogs", new Program().backuplogs.ToString());
                writer.WriteAttributeString("backupcontainer", new Program().backupcontainer);
                writer.WriteAttributeString("usecustomtmpdir", new Program().usecustomtmpdir.ToString());
                writer.WriteAttributeString("backupscustomidprefix", new Program().backupscustomidprefix);
                writer.WriteAttributeString("compressbackups", new Program().compressbackups.ToString());
                writer.WriteAttributeString("platform", new Program().platform);
            }
            catch (Exception e)
            {
                ConsoleTools.Print("Error:\n" + e.Message);
                ConsoleTools.Pause("Press any key to terminate.");
                ConsoleTools.Exit(1);
            }
        }

        public static void GenerateConfig()
        {
            ConsoleTools.Clear();
            ConsoleTools.Print("Would you like to use RCON integration with your server?");
            new Program().usercon = Input.GetKeyTF();
            ConsoleTools.Clear();
            if (!(new Program().usercon))
            {
                new Program().rconpass = null;
                new Program().rconhostname = null;
                new Program().rconport = 0;
            }
            else
            {
                ConsoleTools.Print("Please enter your server's RCON Password.");
                new Program().rconpass = Input.GetInput();
                ConsoleTools.Clear();

                ConsoleTools.Print("Please enter your server's hostname. (127.0.0.1 for local).");
                new Program().rconhostname = Input.GetInput("127.0.0.1");
                ConsoleTools.Clear();

                ConsoleTools.Print("Please enter your server's RCON port. (Default: 25565)");
                new Program().rconport = int.Parse(Input.GetInput("25565"));
            }
        }

        public static void LoadConfig()
        {
            try // If anything goes wrong, this should keep it from braeking the whole program
            {
                using (XmlReader reader = XmlReader.Create(new Program().configfile))
                {
                    reader.ReadToFollowing("Config"); // Here we specify the config.. not that there's anything else right now
                    reader.MoveToFirstAttribute();
                    new Program().usercon = Boolean.Parse(reader.Value); // Use rcon?
                    reader.MoveToNextAttribute();
                    new Program().rconpass = reader.Value; // Rcon password
                    reader.MoveToNextAttribute();
                    new Program().rconhostname = reader.Value; // Rcon hostname
                    reader.MoveToNextAttribute();
                    new Program().rconport = int.Parse(reader.Value); // Rcon port
                    reader.MoveToNextAttribute();
                    new Program().worldscontaineractive = Boolean.Parse(reader.Value); // Use worlds container?
                    reader.MoveToNextAttribute();
                    new Program().worldscontainerpath = reader.Value; // Path to worlds container
                    reader.MoveToNextAttribute();
                    new Program().backupmsgactive = Boolean.Parse(reader.Value); // Use backup server broadcast?
                    reader.MoveToNextAttribute();
                    new Program().backupmsg = reader.Value; // Backup server broadcast message?
                    reader.MoveToNextAttribute();
                    new Program().backupplugins = Boolean.Parse(reader.Value);  // Backup plugins? (Spigot and Bukkit only)
                    reader.MoveToNextAttribute();
                    new Program().backuplogs = Boolean.Parse(reader.Value); // Backup server logs?
                    reader.MoveToNextAttribute();
                    new Program().backupcontainer = reader.Value; // Where to save the backups?
                    reader.MoveToNextAttribute();
                    new Program().usecustomtmpdir = Boolean.Parse(reader.Value); // Do we use a custom tmp dir? (Default is {Backups save path}\tmp
                    reader.MoveToNextAttribute();
                    new Program().customtmpdir = reader.Value; // If the above is enabled, where is this dir you want?
                    reader.MoveToNextAttribute();
                    new Program().backupscustomidprefix = reader.Value; // Do you want to prefix your backups?
                    reader.MoveToNextAttribute();
                    new Program().compressbackups = Boolean.Parse(reader.Value); // Do you want to compress your backups?
                    reader.MoveToNextAttribute();
                    new Program().platform = reader.Value; // Platform? (Spigot/CraftBukkit/Vanilla)
                }
            }
            catch (Exception e)
            {
                // If something goes wrong, maybe this will help.
                ConsoleTools.Print("Error:\n" + e.Message + Environment.NewLine + new Program().configfile);
                ConsoleTools.Pause("Press any key to terminate");
                if (e.Message.ToLower().StartsWith("could not find file"))
                    ConsoleTools.Exit(2);
                else
                    ConsoleTools.Exit(1);
            }
        }
    }
}
