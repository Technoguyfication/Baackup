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
                // okay screw this, we're using mcrcon by Tiffi
                System.Diagnostics.Process.Start(Program.exepath + "Baackup\\mcrcon.exe", "-s -p " + Program.rconpass + " -H " + Program.rconhostname + " -P " + Program.rconport + " \"" + command + '"');
                Tools.Log("Passed RCON Command to Server: " + command);
            }
            else
            {
                Tools.Log("Failed to run RCON command: " + command + " (RCON Disabled)");
            }
        }
    }
}
