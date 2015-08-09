using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baackup
{
    public class ConsoleTools
    {
        public static void Print(string message, bool line = true)
        {
            if (line)
                Console.WriteLine(message + Environment.NewLine);
            else
                Console.Write(message);
        }

        public static void Log(string text)
        {
            Print('[' + DateTime.Now.ToString("hh:mm:ss") + "] " + text);
        }

        public static void Pause(string message = "")
        {
            if (!(message == ""))
                Print(message);
            Console.ReadKey(true);
        }

        public static void Title(string title)
        {
            Console.Title = title;
        }

        public static void Exit(int code = 0)
        {
            Environment.Exit(code);
        }

        public static void Clear()
        {
            Console.Clear();
        }
    }
}
