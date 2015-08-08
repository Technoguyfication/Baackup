using System;

namespace Baackup
{
    public class ConsoleTools
    {
        public static void Clear()
        {
            Console.Clear();
        }

        public static void Exit(int code = 0)
        {
            Environment.Exit(code);
        }

        public static void Pause(string message = "")
        {
            if (!(message == ""))
                Print(message);
            Console.ReadKey(true);
        }

        public static void Print(string message, bool line = true)
        {
            if (line)
                Console.WriteLine(message);
            else
                Console.Write(message);
        }

        public static void Title(string title)
        {
            Console.Title = title;
        }
    }
}
