using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaackupShared;

namespace Baackup
{
    public class Tools
    {
        /// Write text to the log. (Console)
        /// </summary>
        /// <param name="text">Message to print</param>
        /// <param name="level">Log Level. Defaults to [INFO]</param>
        public static void Log(string text, string level = "Info", bool verbose = false)
        {
            Console.WriteLine("[Baackup - " + DateTime.Now.ToString("hh:mm:ss") + "] [" + level.ToUpper() + "] " + text);
        }

        /// <summary>
        /// Pause the console and wait for keypress.
        /// </summary>
        /// <param name="message"></param>
        public static void Pause(string message = null)
        {
            // If the program should be autonomous, this needs to not do anything.

            /*if (!(message == null))
                Log(message);
            Console.ReadKey(true);*/
        }

        /// <summary>
        /// Sets the window title.
        /// </summary>
        /// <param name="title">Custom title. Defaults to nothing.</param>
        public static void Title(string title = null)
        {
            /* Example:
            Baackup For Minecraft Server - Technoguyfication - v1.0.0.0 - Main */

            string s = "[Baackup for Minecraft Server - Technoguyfication - v" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;

            if (!(title == null))
            {
                s = s + " - " + title; // Append the title to the end of the title.
            }

            Console.Title = s;
        }

        /// <summary>
        /// Exits the program with the provided Win32 exit code.
        /// </summary>
        /// <param name="code">Exit code to exit with. Default: 0</param>
        public static void Exit(int code = 0)
        {
            Environment.Exit(code);
        }

        /// <summary>
        /// Clears the console window.
        /// </summary>
        public static void Clear()
        {
            Console.Clear();
        }

        /// <summary>
        /// Waits (sleeps) for an amount of seconds.
        /// </summary>
        /// <param name="seconds">Seconds to pause for</param>
        public static void Wait(int seconds)
        {
            System.Threading.Thread.Sleep(seconds * 1000);
        }

        /// <summary>
        /// Generates a new backup identifier.
        /// </summary>
        /// <returns>Unique backup ID</returns>
        public static string NewBackupID()
        {
            return Configuration.Save_Prefix + '_' + DateTime.Now.ToString("yyyy-mmm-dd.hh-mm-ss-ffff--backup");
        }
    }
}
