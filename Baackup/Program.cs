using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Baackup
{
    class Program
    {
        #region Class Variables

        // Config path
        public static string Config_File = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + Properties.Resources.ConfigFileName);

        // Execution path
        public static string ServerDirectory;

        // TMP Settings
        public static string BackupID;

        #endregion Class Variables

        static void Main(string[] args)
        {
            Tools.Title(); // Basic Title

            // Attempt to get the executable path from the launch args
            try
            {
                ServerDirectory = args[0] + '\\';
            }
            catch (Exception e)
            {
                Tools.Log("There was an issue starting the program!\nAre you sure you started it with the Batch script?\n\nError details: " + e.Message);
                Tools.Pause();
                Tools.Exit(1);
            }

            new Program().Start(); // New Instance of the program, then start.

            Tools.Exit(1); // If for some reason we end up back here, there's an error so we exit with '1'
        }

        public void Start()
        {
            // Display title and intro text
            Tools.Log("Baackup Initialized...");
            Tools.Log("Running on path: " + ServerDirectory);

            // if (config exists and is valid)

            Tools.Log("Everything is OK");
            Backup.StartBackup(); // Begin backup process
        }
    }
}
