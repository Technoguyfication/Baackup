using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace BaackupConfig
{
    public class XMLConfig
    {
        public static void GenerateDefaultConfig()
        {
            // RCON
            Variables.UseRCON = false;
            Variables.RCONHostname = "127.0.0.1";
            Variables.RCONPass = null;
            Variables.RCONPort = 25575;
            
            // Worlds container
            Variables.WorldsContainerActive = false;
            Variables.WorldsContainerPath = null;

            // Backup Messages
            Variables.BackupMessageActive = false;
            Variables.BackupMessage = "say The server is backing up! Prepare for some slight lag!";

            Variables.BackupFinishedMessageActive = false;
            Variables.BackupFinishedMessage = "say Server Backup Completed!";

            // Backup container and Tmp
            Variables.BackupContainer = null;
            Variables.UseCustomTMPDir = false;
            Variables.CustomTMPDir = null;

            // Backup ID
            Variables.BackupPrefix = null;
        }

        public static bool ConfigExists()
        {
            if (File.Exists(Variables.ConfigFilePath))
                return true;
            else
                return false;
        }

        public static void LoadConfig()
        {
            // Do something
        }

        public static void SaveConfig()
        {
            // Create a new XMLWriter

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;

            // Make sure we don't break everything if some error is thrown

            try
            {
                XmlWriter writer = XmlWriter.Create(Variables.ConfigFilePath, settings);

                writer.WriteStartDocument();
                writer.WriteComment("This is the config file for Baackup, NEVER share or upload this file anywhere on the internet as it could contain your server's RCON password and info in it. Please use the included Configuration tool to edit this file.");
                writer.WriteStartElement("Config");
                writer.WriteAttributeString("usercon", Variables.UseRCON.ToString());
                writer.WriteAttributeString("rconpass", Variables.RCONPass);
                writer.WriteAttributeString("rconhostname", Variables.RCONHostname);
                writer.WriteAttributeString("rconport", Variables.RCONPort.ToString());
                writer.WriteAttributeString("worldscontaineractive", Variables.WorldsContainerActive.ToString());
                writer.WriteAttributeString("worldscontainerpath", Variables.WorldsContainerPath);
                writer.WriteAttributeString("backupmsgactive", Variables.BackupMessageActive.ToString());
                writer.WriteAttributeString("backupmsg", Variables.BackupMessage);
                writer.WriteAttributeString("backupplugins", Variables.BackupPlugins.ToString());
                writer.WriteAttributeString("backuplogs", Variables.BackupLogs.ToString());
                writer.WriteAttributeString("backupcontainer", Variables.BackupContainer);
                writer.WriteAttributeString("usecustomtmpdir", Variables.UseCustomTMPDir.ToString());
                writer.WriteAttributeString("customtmpdir", Variables.CustomTMPDir);
                writer.WriteAttributeString("backupscustomidprefix", Variables.BackupPrefix);
                writer.WriteAttributeString("compressbackups", Variables.CompressBackups.ToString());
                writer.WriteAttributeString("platform", Variables.Platform);
                writer.WriteEndElement();
                writer.WriteEndDocument();

                writer.Flush();
                writer.Close();
            }
            catch (Exception e)
            {
                /* do something with this */
                string ex = e.Message;
            }
        }
    }
}
