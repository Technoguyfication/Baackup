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
        
        // Execution path
        public static string exepath;

        #endregion

        static void Main(string[] args)
        {
            ConsoleTools.Title("Baackup for Minecraft Server - Technoguyfication " + DateTime.Now.Year.ToString());
            try
            {
                exepath = args[0] + '\\';
            }
            catch (Exception e)
            {
                ConsoleTools.Print("There was an issue starting the program!\nAre you sure you started it with the Batch script?\n\nError details: " + e.Message);
                ConsoleTools.Pause();
                ConsoleTools.Exit(1);
            }

            new Program().Start();
            ConsoleTools.Pause();
            ConsoleTools.Exit(0);
        }

        public void Start()
        {
            // Display title and intro text
            ConsoleTools.Print("Baackup for Minecraft Server - Technoguyfication " + DateTime.Now.Year.ToString());
            ConsoleTools.Print("Running on path: " + exepath);

            if (XMLConfig.ConfigExists())
            {
                // Load program configuration from file
                XMLConfig.LoadConfig();

                // Check that we are running in a server directory.
                if (!IOStatus.FileExists("server.properties", true))
                {
                    ConsoleTools.Print("We did not detect you are running in a server directory!\nPlease but the batch file in your root directory\nwith the jar/exe file and server.properties!");
                    ConsoleTools.Pause();
                    ConsoleTools.Exit(2);
                }
                else
                {
                    ConsoleTools.Log("Found server.properties!");
                }
            }
            else
                XMLConfig.GenerateConfig();
        }
    }
}
