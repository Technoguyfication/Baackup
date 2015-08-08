using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baackup
{
    class Program
    {
        #region Class Variables

        // Class variables

        // Config options
        public bool usercon;
        public string rconpass;
        public string rconhostname;
        public int rconport;
        public bool worldscontaineractive;
        public string worldscontainerpath;
        public bool backupmsgactive;
        public string backupmsg;
        public bool backupplugins;
        public bool backuplogs;
        public string backupcontainer;
        public bool usecustomtmpdir;
        public string customtmpdir;
        public string backupscustomidprefix;
        public bool compressbackups;
        public string platform;
        // Config path
        public string configfile = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\baackupconfig.xml");

        #endregion

        static void Main(string[] args)
        {
            new Program().Start();
            ConsoleTools.Pause("Press any key to exit");
        }

        public void Start()
        {
            // Display title and intro text
            ConsoleTools.Print("Baackup for Minecraft Server - Technoguyfication " + DateTime.Now.Year.ToString() + Environment.NewLine);
            ConsoleTools.Title("Baackup for Minecraft Server - Technoguyfication " + DateTime.Now.Year.ToString());

            if (XMLConfig.ConfigExists())
                XMLConfig.LoadConfig();
            else
                XMLConfig.GenerateConfig();
        }
    }
}
