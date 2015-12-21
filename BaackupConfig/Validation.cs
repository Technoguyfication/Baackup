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
