using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BaackupShared;

namespace Baackup
{
    class Program
    {
        #region Class Variables

        // Execution paths
        public static string ServerDirectory { get; set; }
        public static string ExecutableDirectory
        {
            get
            {
                return Directory.GetDirectoryRoot(System.Reflection.Assembly.GetExecutingAssembly().Location); // Return the folder that the executable is inside
            }
        }

        // TMP Settings
        public static string BackupID = Tools.NewBackupID();
        public static string BackupTMPSave
        {
            get
            {
                if (Configuration.TMP_CustomEnabled)
                {
                    return string.Format("{0}\\{1}\\", Configuration.TMP_CustomPath, BackupID);
                }
                else
                {
                    return string.Format("{0}\\Baackup\\{1}", Path.GetTempPath(), BackupID);
                }
            }
        }

        // Classes
        public static BaackupIO IO;

        #endregion Class Variables

        static void Main(string[] args)
        {
            Tools.Title(); // Basic Title

            // Attempt to get the server path
            try
            {
                ServerDirectory = args[0] + '\\';
            }
            catch (Exception)
            {
                Tools.Log("Baackup must be started with the provided Batch script", "Fatal");
                Tools.Exit(1);
            }

            IO = new BaackupIO(ServerDirectory); // Set the IO reference now that we have a directory

            new Program().Start(); // New Instance of the program, then start.

            Tools.Log("Unrecoverable exception, program is in wrong class. Exiting.", "Fatal");
            Tools.Exit(1); // If for some reason we end up back here, there's an error so we exit with '1'
        }

        public void Start()
        {
            // Display title and intro text
            Tools.Log("Baackup Initialized...");
            Tools.Log("Running on path: " + ServerDirectory);

            // if (config exists and is valid)

            Tools.Log("Everything is OK");
            Backup.StartBackup(IO); // Begin backup process
        }
    }
}
