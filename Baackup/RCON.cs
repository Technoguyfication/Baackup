#region GNU License

/*
 *  Baackup - The free and open source Minecraft server backup program.
 *  Copyright (C) 2016  Hayden (Technoguyfication) Andreyka
 *
 *  This program is free software; you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation; either version 2 of the License, or
 *  (at your option) any later version.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License along
 *  with this program; if not, write to the Free Software Foundation, Inc.,
 *  51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.
 */

#endregion

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

                    RCONStartInfo.FileName = string.Format("{0}\\Lib\\mcrcon.exe", Program.ExecutableDirectory); // Set the exec path

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
