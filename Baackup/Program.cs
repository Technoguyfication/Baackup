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
        } // This should not be used until configuration is verified!

        // Classes
        public static BaackupIO IO;

        #endregion Class Variables

        static void Main(string[] args)
        {
            Tools.Title(); // Basic Title

            // Attempt to get the server path
            if (args.Length > 0)
                ServerDirectory = args[0] + '\\';
            else
            {
                Tools.Log("Baackup must be started with the provided Batch script", "Fatal");
                Tools.Exit(1);
            }

            IO = new BaackupIO(ServerDirectory); // Set the IO reference now that we have a directory

            try
            {
                new Program().Start(); // New Instance of the program, then start.
            }
            catch (Exception e) // If something isn't caught yet, there's a problem
            {
                Tools.Log(string.Format("Uncaught error in program! Details: {0}", e.Message), "Fatal");
            }

            Tools.Log("Unrecoverable exception, program is in wrong class", "Fatal");
            Tools.Exit(1); // If for some reason we end up back here, there's an error so we exit with '1'
        }

        public void Start()
        {
            // Display startup messages
            Tools.Log("Baackup is starting...");
            Tools.Log(string.Format("Looking for server at: {0}", ServerDirectory));

            #region Configuration Initialization

            // Is the config existent and valid?
            try
            {
                Configuration.Initialize();
            }
            catch (ConfigNonexistentException) // The config wasn't found. I tried really hard to find it, but I'm the little programming language that couldn't.
            {
                Tools.Log("Could not find the configuration file! Please run the Configuration Tool.", "Fatal");
                Tools.Exit(2); // File not found
            }
            catch (ConfigInvalidException) // I found it, but I couldn't get it open :(
            {
                Tools.Log("The config could not be read, please reset it by deleting \"BaackupConfig.xml\" in your AppData and re-running the Configuration Tool.", "Fatal");
                Tools.Exit(4); // File could not be opened.
            }
            catch (ConfigResetException) // I found it, but it told me to wipe it.
            {
                Tools.Log("The config version was different than the required version. Resetting configuration and stopping program!", "Warning");
                Tools.Exit(0); // This isn't really an error.
            }
            catch (Exception e) // I found it, but it set the office on fire when I opened it D:
            {
                Tools.Log(string.Format("There was a general error while reading the configuration. Please try resetting the config file located in AppData. The error message was \"{0}\"", e.Message), "Fatal");
                Tools.Exit(1); // General Error
            }

            #endregion

            // We're good to go!
            Tools.Log("Everything is OK");
            Backup.StartBackup(IO); // Begin backup process
        }
    }
}
