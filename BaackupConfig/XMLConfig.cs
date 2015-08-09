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
        // Config path
        public static string configfile = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\baackupconfig.xml");

        public static void GenerateDefaultConfig()
        {
            // RCON
            Variables.usercon = false;
            Variables.rconhostname = "127.0.0.1";
            Variables.rconpass = null;
            Variables.rconport = 25575;
            
            // Worlds container
            Variables.worldscontaineractive = false;
            Variables.worldscontainerpath = null;

            // Backup Messages
            Variables.backupmsgactive = false;
            Variables.backupmsg = "say The server is backing up! Prepare for some slight lag!";

            Variables.backupfinishmsgactive = false;
            Variables.backupfinishmsg = "say Server Backup Completed!";

            // Backup container and Tmp
            Variables.backupcontainer = null;
            Variables.usecustomtmpdir = false;
            Variables.customtmpdir = null;

            // Backup ID
            Variables.backupscustomidprefix = null;
        }

        public static bool DoesConfigExist()
        {
            if (File.Exists(configfile))
                return true;
            else
                return false;
        }
    }
}
