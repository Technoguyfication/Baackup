using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using BaackupShared;

namespace Baackup
{
    public class RCON
    {
        public static void Send(string command)
        {
            try
            {
                if (Configuration.RCON_Enabled)
                {
                    // We're using MCRCON by Tiiffi

                    ProcessStartInfo RCONStartInfo = new ProcessStartInfo();

                    RCONStartInfo.FileName = string.Format("{0}\\mcrcon.exe", Program.ExecutableDirectory); // Set the exec path

                    RCONStartInfo.Arguments = string.Format("-s -p \"{0}\" -H {1} -P {2} \"{3}\"", Configuration.RCON_Password, Configuration.RCON_Hostname, Configuration.RCON_Port, command);
                    RCONStartInfo.WindowStyle = ProcessWindowStyle.Hidden; // Hide window

                    try
                    {
                        Process.Start(RCONStartInfo);
                    }
                    catch (Exception e)
                    {
                        Tools.Log(string.Format("Failed to launch RCON Executable: {0}", e.Message), "Error");
                        return;
                    }

                    Tools.Log(string.Format("RCON Command Sent: {0}"), command);
                }
                else
                {
                    Tools.Log(string.Format("Failed to run RCON command: {0} (RCON Disabled)", command));
                }
            }
            catch (ConfigNotInitializedException)
            {
                Tools.Log("Tried to access non-initalized configuration!", "Fatal");
            }
        }
    }
}
