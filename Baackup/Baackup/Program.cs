using System;

namespace Baackup
{
    internal class Program
    {
        // Class variables

        public string backupcontainer;

        public bool backuplogs;

        public string backupmsg;

        public bool backupmsgactive;

        public bool backupplugins;

        public string backupscustomidprefix;

        public bool compressbackups;

        // Config path
        public string configfile = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\baackupconfig.xml");

        public string customtmpdir;

        public string platform;

        public string rconhostname;

        public string rconpass;

        public int rconport;

        public bool usecustomtmpdir;

        // Config options
        public bool usercon;

        public bool worldscontaineractive;
        public string worldscontainerpath;

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

        private static void Main(string[] args)
        {
            new Program().Start();
            ConsoleTools.Pause("Press any key to exit");
        }
    }
}
