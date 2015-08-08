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
            Program Base = new Program();

            try // If anything goes wrong, this should keep it from braeking the whole program
            {
                using (XmlReader reader = XmlReader.Create(Base.configfile))
                {
                    reader.ReadToFollowing("Config"); // Here we specify the config.. not that there's anything else right now
                    reader.MoveToFirstAttribute();
                    Base.usercon = Boolean.Parse(reader.Value); // Use rcon?
                    reader.MoveToNextAttribute();
                    Base.rconpass = reader.Value; // Rcon password
                    reader.MoveToNextAttribute();
                    Base.rconhostname = reader.Value; // Rcon hostname
                    reader.MoveToNextAttribute();
                    Base.rconport = int.Parse(reader.Value); // Rcon port
                    reader.MoveToNextAttribute();
                    Base.worldscontaineractive = Boolean.Parse(reader.Value); // Use worlds container?
                    reader.MoveToNextAttribute();
                    Base.worldscontainerpath = reader.Value; // Path to worlds container
                    reader.MoveToNextAttribute();
                    Base.backupmsgactive = Boolean.Parse(reader.Value); // Use backup server broadcast?
                    reader.MoveToNextAttribute();
                    Base.backupmsg = reader.Value; // Backup server broadcast message?
                    reader.MoveToNextAttribute();
                    Base.backupplugins = Boolean.Parse(reader.Value);  // Backup plugins? (Spigot and Bukkit only)
                    reader.MoveToNextAttribute();
                    Base.backuplogs = Boolean.Parse(reader.Value); // Backup server logs?
                    reader.MoveToNextAttribute();
                    Base.backupcontainer = reader.Value; // Where to save the backups?
                    reader.MoveToNextAttribute();
                    Base.usecustomtmpdir = Boolean.Parse(reader.Value); // Do we use a custom tmp dir? (Default is {Backups save path}\tmp
                    reader.MoveToNextAttribute();
                    Base.customtmpdir = reader.Value; // If the above is enabled, where is this dir you want?
                    reader.MoveToNextAttribute();
                    Base.backupscustomidprefix = reader.Value; // Do you want to prefix your backups?
                    reader.MoveToNextAttribute();
                    Base.compressbackups = Boolean.Parse(reader.Value); // Do you want to compress your backups?
                    reader.MoveToNextAttribute();
                    Base.platform = reader.Value; // Platform? (Spigot/CraftBukkit/Vanilla)
                }
            }
            catch (Exception e)
            {
                // If something goes wrong, maybe this will help.
                ConsoleTools.Print("Error:\n" + e.Message + Environment.NewLine + Base.configfile);
                ConsoleTools.Pause("Press any key to terminate");
                if (e.Message.ToLower().StartsWith("could not find file"))
                    ConsoleTools.Exit(2);
                else
                    ConsoleTools.Exit(1);
            }
        }

        public static void CreateConfig() // This is the part where we write the config values to a file. I don't want to comment this shit.
        {
            Program Base = new Program();
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;

            try
            {
                XmlWriter writer = XmlWriter.Create(Base.configfile, settings);
                writer.WriteStartDocument();
                writer.WriteComment("This is the config file for Baackup, NEVER share or upload this file anywhere on the internet as it could contain your server's RCON password and info in it. However, feel free to edit this file to your liking.");
                writer.WriteStartElement("Config");
                writer.WriteAttributeString("usercon", Base.usercon.ToString());
                writer.WriteAttributeString("rconpass", Base.rconpass);
                writer.WriteAttributeString("rconhostname", Base.rconhostname);
                writer.WriteAttributeString("rconport", Base.rconport.ToString());
                writer.WriteAttributeString("worldscontaineractive", Base.worldscontaineractive.ToString());
                writer.WriteAttributeString("worldscontainerpath", Base.worldscontainerpath);
                writer.WriteAttributeString("backupmsgactive", Base.backupmsgactive.ToString());
                writer.WriteAttributeString("backupmsg", Base.backupmsg);
                writer.WriteAttributeString("backupplugins", Base.backupplugins.ToString());
                writer.WriteAttributeString("backuplogs", Base.backuplogs.ToString());
                writer.WriteAttributeString("backupcontainer", Base.backupcontainer);
                writer.WriteAttributeString("usecustomtmpdir", Base.usecustomtmpdir.ToString());
                writer.WriteAttributeString("backupscustomidprefix", Base.backupscustomidprefix);
                writer.WriteAttributeString("compressbackups", Base.compressbackups.ToString());
                writer.WriteAttributeString("platform", Base.platform);
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
            Program Base = new Program();
            ConsoleTools.Clear();
            ConsoleTools.Print("Would you like to use RCON integration with your server?");
            Base.usercon = Input.GetKeyTF();
            ConsoleTools.Clear();
            if (!(Base.usercon))
            {
                Base.rconpass = null;
                Base.rconhostname = null;
                Base.rconport = 0;
            }
            else
            {
                ConsoleTools.Print("Please enter your server's RCON Password.");
                Base.rconpass = Input.GetInput();
                ConsoleTools.Clear();

                ConsoleTools.Print("Please enter your server's hostname. (127.0.0.1 for local).");
                Base.rconhostname = Input.GetInput("127.0.0.1");
                ConsoleTools.Clear();

                ConsoleTools.Print("Please enter your server's RCON port. (Default: 25565)");
                Base.rconport = int.Parse(Input.GetInput("25565"));
            }
        }

        public static bool ConfigExists()
        {
            Program Base = new Program();
            if (File.Exists(Base.configfile))
                return true;
            else
                return false;
        }
    }
}
