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
                if (!File.Exists(Program.tmpsave + "\\mcrcon.exe"))
                {

                    string exename = Path.Combine(Program.tmpsave, "mcrcon.exe");

                    using (FileStream fsDst = new FileStream(exename, FileMode.Create, FileAccess.Write))
                    {
                        byte[] bytes = Properties.Resources.GetMcrcon();

                        fsDst.Write(bytes, 0, bytes.Length);
                    }
                }

                // run code
                System.Diagnostics.Process.Start(Program.tmpsave + "mcrcon.exe", "-s -p " + Program.rconpass + " -H " + Program.rconhostname + " -P " + Program.rconport + " \"" + command + '"');
            }
            else
            {
                Tools.Log("Failed to run RCON command: " + command + " (RCON Disabled)");
            }
        }
    }
}
