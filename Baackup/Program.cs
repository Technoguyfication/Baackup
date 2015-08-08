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
        public static bool usercon;
        public static string rconpass;
        public static string rconhostname;
        public static int rconport;
        public static bool worldscontaineractive;
        public static string worldscontainerpath;
        public static bool backupmsgactive;
        public static string backupmsg;
        public static bool backupplugins;
        public static bool backuplogs;
        public static string backupcontainer;
        public static bool usecustomtmpdir;
        public static string customtmpdir;
        public static string backupscustomidprefix;
        public static bool compressbackups;
        public static string platform;
        // Config path
        public static string configfile = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\baackupconfig.xml");

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
