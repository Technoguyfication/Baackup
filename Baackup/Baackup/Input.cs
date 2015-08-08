using System;

namespace Baackup
{
    internal class Input
    {
        public static string GetInput(string none = "")
        {
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
            while (true)
            {
                char key = Console.ReadKey(true).ToString()[0];
                if (yn)
                    if (key == 'y' || key == 'n')
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
    }
}
