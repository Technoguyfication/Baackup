using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baackup
{
    class Input
    {
        public static string GetInput(string none = "")
        {
            Tools.Print(Environment.NewLine, false);
            while (true)
            {
                string text = Console.ReadLine();
                if (text == "")
                    if (!(none == ""))
                        return none;
                    else
                    { }
                else
                    return text;
            }
        }

        public static char GetKey(bool yn = false)
        {
            Tools.Print(Environment.NewLine, false);
            while (true)
            {
                char key = Console.ReadKey(true).KeyChar;
                if (yn)
                    if (key == 'y' | key == 'n')
                        return key;
                    else
                    { }
                else
                    return key;
            }
        }

        public static bool GetKeyTF()
        {
            if (GetKey(true) == 'y')
                return true;
            else
                return false;
        }

        public static int GetNum(int fallback = 0)
        {
            string result;
            bool valid;
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            while (true)
            {
                valid = true;
                if (!(fallback == 0))
                    result = GetInput(fallback.ToString());
                else
                    result = GetInput();
                foreach (char letter in alphabet)
                {
                    if (result.Contains(letter))
                    {
                        valid = false;
                    }
                }
                if (valid)
                    break;
            }
            return int.Parse(result);
        }
    }
}
