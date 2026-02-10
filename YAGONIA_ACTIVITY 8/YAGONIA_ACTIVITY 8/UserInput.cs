using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YAGONIA_ACTIVITY_8
{
    internal class UserInput
    {
        public static int GetInt(string message)
        {
            while (true)
            {
                try
                {
                    Console.Write(message);
                    return int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Please enter a number.");
                    Console.ResetColor();
                }
            }
        }

        public static string GetString(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

    }
}
