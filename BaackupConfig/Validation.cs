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

namespace BaackupConfig
{
    class Validation
    {
        public static void ValidatePortEntry(object sender, EventArgs e)
        {
            string newinput = null; // Set up an empty "newninput"

            foreach (char c in Program.main.Box_RCON_Port.Text) // For each of the characters inside, if it's a number, then add it to the new "newinput"
            {
                if (IsValidInt(c))
                {
                    newinput = newinput + c;
                }
            }

            Program.main.Box_RCON_Port.Text = newinput; // Send the sanitized string
        }

        private static bool IsValidInt(char c) // Returns whether a character is a valid 32-bit signed integer
        {
            int o;
            return int.TryParse(c.ToString(), out o);
        }
    }
}
