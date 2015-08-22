using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Sockets;
using System.IO;

namespace Baackup
{
    public class RCON
    {
        public static void Send(string command)
        {
            if (Program.usercon)
            {
                // We're using MCRCON by Tiiffi
                try
                {
                    System.Diagnostics.Process.Start(Program.exepath + "mcrcon.exe", "-s -p " + Program.rconpass + " -H " + Program.rconhostname + " -P " + Program.rconport + " \"" + command + '"');
                }
                catch (Exception e)
                {
                    Tools.Print("Failed to run RCON command: " + command + " (" + e.Message + ')');
                }
            }
            else
            {
                Tools.Log("Failed to run RCON command: " + command + " (RCON Disabled)");
            }
        }
    }
}
